using System;
using System.Reflection;
using System.Text;
using MySql.Data.MySqlClient;


namespace RegistroDeTransacciones
{
    class Conexionbd
    {
        //Cadena de Conexion
        private StringBuilder cadenaConexion = new StringBuilder();
        
        private string message;
        public MySqlConnection Conectarbd;
        MySqlCommand cmd;

        public StringBuilder CadenaConexion
        {
            get { return cadenaConexion; }
            set { cadenaConexion = value; }
        }
        //Constructor
        public Conexionbd()
        {
            CadenaConexion.Append("server=").Append(server).Append(";port=").Append(port).Append("; database=").Append(database).Append(";uid=").Append(user).Append(";password=").Append(pass).Append(";");
            Conectarbd = new MySqlConnection(CadenaConexion.ToString());
        }

        //Metodo para abrir la conexion
        public void openCon()
        {
            try
            {
                Conectarbd.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error al abrir BD " + ex.Message);
            }
        }

        //Metodo para cerrar la conexion
        public void closeCon()
        {
            Conectarbd.Close();
        }

        //execute update, delete, create

        public bool executeQuery(string query)
        {
            try
            {
                cmd = new MySqlCommand(query, Conectarbd);
                openCon();
                cmd.ExecuteNonQuery();
                closeCon();
                return true;
            }
            catch (Exception ex)
            {
                closeCon();
                message = ex.ToString();
                return false;
            }
        }

        public string  getMessage()
        {
            return message;
        }
    }
}
