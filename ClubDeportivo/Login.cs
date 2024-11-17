using MySql.Data.MySqlClient;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ClubDeportivo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

               private void btnLogin_Click(object sender, EventArgs e)
        {
            // Capturar los datos ingresados
            string user = txtUser.Text;
            string pass = txtPass.Text;

            if (user.Length < 1 || pass.Length < 1)
            {
                MessageBox.Show("Los campos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Cadena de conexión a la base de datos MySQL
                string connectionString = "SERVER=localhost;DATABASE=clubdeportivo;UID=root;PASSWORD=060966;";

                // Crear una conexión a la base de datos
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        // Consulta SQL para verificar si el usuario y la contraseña coinciden
                        string query = "SELECT COUNT(*) FROM usuario WHERE username = @username AND password = @password";

                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@username", user);
                        cmd.Parameters.AddWithValue("@password", pass); // NOTA: Deberías encriptar la contraseña en la base de datos y compararla encriptada también.

                        // Ejecutar la consulta y obtener el resultado
                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            // Si el usuario y contraseña son correctos, abrir el formulario principal
                            Form main = new Main();
                            main.Show();
                            this.Hide();
                        }
                        else
                        {
                            // Mostrar mensaje de error si no coinciden
                            MessageBox.Show("El usuario o la contraseña es incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error al conectar con la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }
    }
}
