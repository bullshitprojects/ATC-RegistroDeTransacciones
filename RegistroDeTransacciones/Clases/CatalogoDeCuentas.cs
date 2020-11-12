using MySql.Data.MySqlClient;
using RegistroDeTransacciones;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SistemaDePagoEmpleados
{
    class CatalogoDeCuentas
    {
        //Declaración de Variables

        private string codigo;
        private string cuenta;
        private string naturaleza;
        private MySqlCommand command;
        private List<CatalogoDeCuentas> lCatalogo;
        private StringBuilder query = new StringBuilder();
        private Conexionbd connect;
        private MySqlDataReader reader;
        private CatalogoDeCuentas oCatalogo;
        // Metodos de Acceso Get y Set

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Cuenta
        {
            get { return cuenta; }
            set { cuenta = value; }
        }

        public string Naturaleza
        {
            get { return naturaleza; }
            set { naturaleza = value; }
        }



        // Metodo de obtencion de Catalogo de cuenta
        public List<CatalogoDeCuentas> CargarCatalogoDeCuentas()
        {
            try
            {
                lCatalogo = new List<CatalogoDeCuentas>();
                query.Append("SELECT * FROM catalogo_cuenta ORDER BY codigo");
                connect = new Conexionbd();
                connect.openCon();
                command = new MySqlCommand(query.ToString(), connect.Conectarbd);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    oCatalogo = new CatalogoDeCuentas();
                    oCatalogo.Naturaleza = reader.GetString(1);
                    oCatalogo.Codigo = reader.GetString(2);
                    oCatalogo.Cuenta = reader.GetString(3);
                    lCatalogo.Add(oCatalogo);
                }
                connect.closeCon();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return lCatalogo;
        }


        //Metodo para Agregar una cuenta
        public string InsertarCuenta(string codigo, string cuenta, string naturaleza)
        {
            string salida = "Asiento Insertado Con Exito";
            try
            {
                query.Append("INSERT INTO catalogo_cuenta (naturaleza, codigo, cuenta) VALUES ('")
                    .Append(naturaleza).Append("', '").Append(codigo).Append("', '").Append(cuenta).Append("')");
                connect = new Conexionbd();
                connect.executeQuery(query.ToString());

            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
               
            }
            return salida;
        }


        public string EliminarCuenta(string codigo, string cuenta)
        {
            string salida = "Cuenta Eliminado";
            try
            {
                query.Append("DELETE FROM catalogo_cuenta  WHERE codigo = '")
                    .Append(codigo).Append("' AND cuenta = '").Append(cuenta).Append("'");
                connect = new Conexionbd();
                connect.executeQuery(query.ToString());
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
            }
            return salida;
        }

    }
}
