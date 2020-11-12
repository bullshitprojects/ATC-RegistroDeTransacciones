using MySql.Data.MySqlClient;
using RegistroDeTransacciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDePagoEmpleados
{
    class LibroDiario
    {
        //Declaración de Variables
        private string fecha;
        private string concepto;
        private string codigo;
        private string asiento;
        private string orden;
        private string cuenta;

        private double parcial;
        private double debe;
        private double haber;
        private MySqlCommand command;
        private MySqlDataReader reader;
        private List<LibroDiario> libroDiario;
        private StringBuilder query = new StringBuilder();
        private Conexionbd connect;

        // Metodos de Acceso Get y Set
        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public string Asiento
        {
            get { return asiento; }
            set { asiento = value; }
        }

        public string Orden
        {
            get { return orden; }
            set { orden = value; }
        }

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

        public string Concepto
        {
            get { return concepto; }
            set { concepto = value; }
        }

        public double Parcial
        {
            get { return parcial; }
            set { parcial = value; }
        }
        public double Debe
        {
            get { return debe; }
            set { debe = value; }
        }
        public double Haber
        {
            get { return haber; }
            set { haber = value; }
        }

        //Metodo para cargar el libro diario
        public List<LibroDiario> CargarLibroDiario()
        {
            try
            {
                connect = new Conexionbd();
                libroDiario = new List<LibroDiario>();
                query.Append("SELECT fecha, asiento, orden, codigo, cuenta, concepto, parcial, debe, haber FROM libro_diario ORDER BY asiento, orden");
                connect.openCon();
                command = new MySqlCommand(query.ToString(), connect.Conectarbd);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    LibroDiario Transaccion = new LibroDiario();
                    Transaccion.Fecha = reader.GetString(1);
                    Transaccion.Asiento = reader.GetString(2);
                    Transaccion.Orden = reader.GetString(3);
                    Transaccion.Codigo = reader.GetString(4);
                    Transaccion.Cuenta = reader.GetString(5);
                    Transaccion.Concepto = reader.GetString(6);
                    Transaccion.Parcial = Convert.ToDouble(reader.GetValue(7).ToString());
                    Transaccion.Debe = Convert.ToDouble(reader.GetValue(8).ToString());
                    Transaccion.Haber = Convert.ToDouble(reader.GetValue(9).ToString());
                    libroDiario.Add(Transaccion);
                }
                reader.Close();
                connect.closeCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al querer recuperar los datos. Detalles del error:\n " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return libroDiario;
        }


        //Metodo para Agregar un Asiento contable
        public string InsertarAsiento(string codigo, string cuenta, string concepto, string fecha, string asiento, string orden, string naturaleza, double valor)
        {
            string salida;
            try
            {
                if (naturaleza == "Parcial")
                {
                    query.Append("INSERT INTO libro_diario (fecha, asiento, orden, codigo, cuenta, concepto, parcial, debe, haber) VALUES ('")
                        .Append(fecha).Append("','").Append(asiento).Append("','").Append(orden).Append("','").Append(codigo).Append("','").Append(cuenta)
                        .Append("','").Append(concepto).Append("',").Append(valor).Append(",0,0)");
                }
                if (naturaleza == "Debe")
                {
                    query.Append("INSERT INTO libro_diario (fecha, asiento, orden, codigo, cuenta, concepto, parcial, debe, haber) VALUES ('")
                        .Append(fecha).Append("','").Append(asiento).Append("','").Append(orden).Append("','").Append(codigo).Append("','").Append(cuenta)
                        .Append("','").Append(concepto).Append("',0,").Append(valor).Append(",0)");
                }
                if (naturaleza == "Haber")
                {
                    query.Append("INSERT INTO libro_diario (fecha, asiento, orden, codigo, cuenta, concepto, parcial, debe, haber) VALUES ('")
                        .Append(fecha).Append("','").Append(asiento).Append("','").Append(orden).Append("','").Append(codigo).Append("','").Append(cuenta)
                        .Append("','").Append(concepto).Append("',0,0,").Append(valor).Append(")");
                }
                connect = new Conexionbd();
                if (connect.executeQuery(query.ToString()))
                {
                    salida = "Asiento Insertado Con Exito";
                }
                else
                {
                    salida = "Ocurrió un error al querer guardar los datos. Contacta al administrador del sistema";
                }
            }
            catch (Exception ex)
            {
                salida = "Ocurrió un error al querer guardar los datos. Detalles del error:\n" + ex.ToString();
            }
            return salida;
        }

        //Metodo para Eliminar La empresa y todos sus registros
        public string EliminarAsiento(string asiento, string orden)
        {
            string salida = "Asiento Eliminado";
            try
            {
                connect = new Conexionbd();
                query.Append("DELETE FROM libro_diario WHERE asiento='").Append(asiento).Append("' AND orden ='").Append(orden).Append("'");
                connect.executeQuery(query.ToString());
            }
            catch (Exception ex)
            {
                salida = "Ocurrió un error al querer eliminar el asiento. Detalles del error:\n" + ex.ToString();
            }
            return salida;
        }


    }
}
