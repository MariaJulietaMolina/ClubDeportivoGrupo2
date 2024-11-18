using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace ClubDeportivo
{
    public partial class MemberList : Form
    {
        public MemberList()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MySqlConnection connectionDB = Datos.Conexion.connection();
            try
            {
                connectionDB.Open();
                MySqlCommand command = new MySqlCommand();
                command.Connection = connectionDB;
                command.CommandText = ("select * from socio;");
                command.ExecuteNonQuery();
                connectionDB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtDocument_TextChanged(object sender, EventArgs e)
        {
            string dni = txtDocument.Text;

            if (!string.IsNullOrEmpty(dni))
            {
                MySqlConnection connectionDB = Datos.Conexion.connection();
                try
                {
                    connectionDB.Open();
                    string query = "SELECT * FROM socio WHERE documento = @documento";
                    MySqlCommand command = new MySqlCommand(query, connectionDB);
                    command.Parameters.AddWithValue("@documento", dni);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;

                    // Aplicar el estilo de fuente
                    dataGridView1.DefaultCellStyle.Font = new Font("Arial Rounded MT Bold", 12);
                    dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial Rounded MT Bold", 10, FontStyle.Bold);

                    connectionDB.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar socio: " + ex.Message);
                }
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            string dni = txtDocument.Text; // Ingresa el DNI ingresado en el textbox

            if (string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Por favor, ingrese un DNI válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MySqlConnection connectionDB = Datos.Conexion.connection();
            try
            {
                connectionDB.Open();
                string query = "UPDATE socio SET fechaCobro = DATE_ADD(fechaCobro, INTERVAL 1 MONTH) WHERE documento = @documento";
                MySqlCommand command = new MySqlCommand(query, connectionDB);

                //filtrar por DNI
                command.Parameters.AddWithValue("@documento", dni);

                int rowsAffected = command.ExecuteNonQuery(); 

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Espere mientras se imprime el comprobante de pago.", "Pago actualizado correctamente", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró un socio con el DNI proporcionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                connectionDB.Close();

                // Actualizamos el DataGrid para reflejar los cambios
                LoadAllSocios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar fecha de cobro: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connectionDB = Datos.Conexion.connection();
            try
            {
                connectionDB.Open();
                string query = "SELECT * FROM socio WHERE DATEDIFF(CURDATE(), fechaCobro) >= 21";
                MySqlCommand command = new MySqlCommand(query, connectionDB);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;

                // Aplica el estilo de fuente
                dataGridView1.DefaultCellStyle.Font = new Font("Arial Rounded MT Bold", 12);
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial Rounded MT Bold", 12, FontStyle.Bold);

                connectionDB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar socios con más de 21 días de atraso: " + ex.Message);
            }
        }

        private void LoadAllSocios()
        {
            MySqlConnection connectionDB = Datos.Conexion.connection();
            try
            {
                connectionDB.Open();
                
                string query = "SELECT nombre, apellido,id, documento AS DNI,  fecha_nacimiento, genero, email, fechaCobro FROM socio";
                MySqlCommand command = new MySqlCommand(query, connectionDB);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Limpiar el DataGridView antes de asignar el nuevo DataSource
                dataGridView1.DataSource = null;
                dataGridView1.Columns.Clear();

                // Asignar el DataSource
                dataGridView1.DataSource = dataTable;

         

                // Aplicar el estilo de fuente
                dataGridView1.DefaultCellStyle.Font = new Font("Arial Rounded MT Bold", 12);
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial Rounded MT Bold", 12, FontStyle.Bold);

                connectionDB.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar todos los socios: " + ex.Message);
            }
        }

        private void lblDoc_Click(object sender, EventArgs e)
        {

        }

        private void MemberList_Load(object sender, EventArgs e)
        {
            LoadAllSocios();
        }
    }
}