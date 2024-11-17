using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ClubDeportivo.Datos
{
    /*
    internal class Conexion
    {
        private MySqlConnection conecction;
        private string database = "club_deportivo";
        private string server = "localhost";
        private string port = "3306";
        private string user = "root";
        private string pass = "060966";
        private string stringConnection;

        public Conexion()
        {
            stringConnection = "datasource = " + server +
                    " ; port = " + port + " ; username = " 
                    + user + " ; Database = " + database;
        }

        public MySqlConnection getConnection()
        {
            if (conecction == null)
            {
                try
                {
                    conecction = new MySqlConnection(stringConnection);
                    conecction.Open();

                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
            return conecction;
        }
    }
    */
    internal class Conexion
    {
        public static MySqlConnection connection()
        {
            string servidor = "server=localhost; database=clubdeportivo; user=root; password=060966";
            MySqlConnection connectionDB = new MySqlConnection(servidor);

            try
            {
                return connectionDB;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }

    }
}
