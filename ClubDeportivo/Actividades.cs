using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ClubDeportivo.Datos;
using System.Net;

namespace ClubDeportivo
{
    public partial class Actividades : Form
    {
        public Actividades()
        {
            InitializeComponent();
        }

        private bool isPago = false;
        private bool isSocio = false;

        // TextBox que ingresa el nombre de la actividad a buscar en el grid
        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM actividades WHERE nombre_actividad LIKE '%{txtUser.Text}%'";
            LoadDataToGrid(query);
        }

        // Button que busca la actividad ingresada del TextBox en la base de datos para reflejarla en el grid
        private void btnClean_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            LoadDataToGrid("SELECT * FROM actividades");
        }

        // Método para cargar datos en el DataGrid
        private void LoadDataToGrid(string query)
        {
            try
            {
                using (MySqlConnection connection = Conexion.connection())
                {
                    connection.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}");
            }
        }

        // DataGrid que muestra la información de la base de datos actividad
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que la fila y columna seleccionadas sean válidas
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                try
                {
                    // Obtiene el valor de la celda seleccionada
                    string nombreActividad = dataGridView1.Rows[e.RowIndex].Cells["nombre_actividad"].Value.ToString();

                
                    MessageBox.Show($"Actividad seleccionada: {nombreActividad}", "Información");

                    
                    int idActividad = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al seleccionar la actividad: {ex.Message}");
                }
            }
        }

        // TextBox que ingresa el DNI de la persona para darle cupo
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        // Button que agrega el DNI de la persona como ID para darle cupo en la actividad, restando 1 al cupo
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && !string.IsNullOrWhiteSpace(textBox1.Text))
            {
                try
                {
                    string dni = textBox1.Text;
                    int idActividad = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

                    using (MySqlConnection connection = Conexion.connection())
                    {
                        connection.Open();

                        // Verifica cupo disponible
                        string query = $"SELECT cupo, dni_inscritos FROM actividades WHERE id = {idActividad}";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int cupo = reader.GetInt32(0);
                            string dniInscritos = reader.GetString(1);

                            if ((checkBox1.Checked || checkBox2.Checked) && cupo > 0 && !dniInscritos.Split(',').Contains(dni))
                            {
                                reader.Close();

                                // Actualiza cupo y agregar DNI
                                query = $"UPDATE actividades SET cupo = cupo - 1, dni_inscritos = CONCAT(dni_inscritos, '{dni},') WHERE id = {idActividad}";
                                cmd = new MySqlCommand(query, connection);
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Inscripción realizada con éxito.");
                                LoadDataToGrid("SELECT * FROM actividades");
                            }
                            else if (!(checkBox1.Checked || checkBox2.Checked))
                            {
                                MessageBox.Show("Debe abonar la actividad primero.");
                            }
                            else
                            {
                                MessageBox.Show("Cupo lleno o DNI ya inscrito.");
                            }
                        }

                        else
                        {
                            MessageBox.Show("Actividad no encontrada.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al inscribir: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una actividad con la fila selectora ( flecha). Y/O asegurece de haber seleccionado un medio de pago para la actividad.");
            }
        }

        // Button que suma 1 al cupo (dando lugar a otra persona)
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int idActividad = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                    string dniToRemove = textBox1.Text;

                    using (MySqlConnection connection = Conexion.connection())
                    {
                        connection.Open();
                        string query = $"UPDATE actividades SET cupo = cupo + 1, " +
                                       $"dni_inscritos = REPLACE(dni_inscritos, '{dniToRemove}', '') " +
                                       $"WHERE id = {idActividad} AND cupo < 15";
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cupo liberado.");
                            LoadDataToGrid("SELECT * FROM actividades");
                        }
                        else
                        {
                            MessageBox.Show("Cupo máximo alcanzado o no se pudo liberar el DNI.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al liberar cupo: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una actividad.");
            }
        }


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            isPago = checkBox2.Checked; 
          
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            isSocio = checkBox1.Checked;
        }

    }
}
