using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class NewMemberForm : Form
    {
        private bool isAptoFisico = false;
        private bool isCuota = false;
        public NewMemberForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            MySqlConnection connectionDB = Datos.Conexion.connection();

            string name = txtName.Text;
            string lastname = txtLastName.Text;
            string document = txtDocument.Text;
            string birthday = dtpBirth.Value.ToString("yyyy-MM-dd"); // Formateo de fecha
            string gender = cboGender.Text;
            string email = txtEmail.Text;
            string fechaCobro = dateTimePicker1.Value.ToString("yyyy-MM-dd"); // Formateo de fecha

            if (name.Length < 1 ||
                lastname.Length < 1 ||
                document.Length < 1 ||
                birthday.Length < 1 ||
                gender.Length < 1 ||
                email.Length < 1 ||
                !isAptoFisico ||
                !isCuota)
            {
                MessageBox.Show("Los campos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    connectionDB.Open();
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = connectionDB;
                    // Consulta SQL con fechaCobro incluida
                    command.CommandText = ("insert into socio(nombre, apellido, documento, fecha_nacimiento, genero, email, fechaCobro)" +
                        " values('" + txtName.Text + "', '" + txtLastName.Text + "', '" + txtDocument.Text + "', '" + dtpBirth.Value.ToString("yyyy-MM-dd") + "', '" + cboGender.Text + "', '" + txtEmail.Text + "', '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "')");
                    command.ExecuteNonQuery();
                    connectionDB.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
                MessageBox.Show("Por favor, espere mientras se imprime su credencial.", "REGISTRO EXITOSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtLastName.Clear();
            txtDocument.Clear();
            //txtBirth.Clear();
            txtEmail.Clear();
            cboGender.Text = "";
        }

        private void dtpBirth_ValueChanged(object sender, EventArgs e)
        {
            dtpBirth.CustomFormat = "yyyy/MM/dd";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            //convierte el booblean del check en true
            isAptoFisico = checkBox1.Checked;

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            isCuota = checkBox2.Checked;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewMemberForm_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "yyyy/MM/dd";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}