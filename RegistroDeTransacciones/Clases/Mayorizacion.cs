using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace RegistroDeTransacciones
{
    class Mayorizacion
    {
        //Declaración de Variables
        private string fecha;
        private string concepto;
        private string codigo;
        private string cuenta;
        private string parcial;
        private string debe;
        private string haber;
        private string saldo;
        private MySqlCommand command;
        private List<Mayorizacion> lMayorizacion;
        private Mayorizacion oMayorizacion;
        private StringBuilder query = new StringBuilder();
        private MySqlDataReader reader;
        private Conexionbd connect;

        //constructor 
        public Mayorizacion()
        {
            Fecha = "\n ";
            Concepto = "\n ";
            Codigo = "\n ";
            Cuenta = "\n ";
            Parcial = "\n ";
            Debe = "\n ";
            Haber = "\n ";
            Saldo = "\n ";
        }
        // Metodos de Acceso Get y Set
        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
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

        public string Parcial
        {
            get { return parcial; }
            set { parcial = value; }
        }

        public string Debe
        {
            get { return debe; }
            set { debe = value; }
        }

        public string Haber
        {
            get { return haber; }
            set { haber = value; }
        }

        public string Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }


        public List<Mayorizacion> getMayorizacion()
        {
            try
            {
                lMayorizacion = new List<Mayorizacion>();
                string cuentaFlotante = "";
                double totalDebe = 0;
                double totalHaber = 0;
                double saldo = 0;
                int acesso = 0;
                query.Append("SELECT fecha, codigo, cuenta, concepto, debe, haber FROM libro_diario ORDER BY codigo, cuenta , asiento");
                connect = new Conexionbd();
                connect.openCon();
                command = new MySqlCommand(query.ToString(), connect.Conectarbd);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (cuentaFlotante != reader.GetString(1))
                    {
                        if (acesso == 1)
                        {
                            //Fila de totales
                            oMayorizacion = new Mayorizacion();
                            oMayorizacion.Fecha = "";
                            oMayorizacion.Codigo = "";
                            oMayorizacion.Concepto = "                                Total";

                            oMayorizacion.Debe = "$  " + Convert.ToString(totalDebe);
                            oMayorizacion.Haber = "$  " + Convert.ToString(totalHaber);
                            oMayorizacion.Saldo = "$  " + Convert.ToString(saldo);
                            lMayorizacion.Add(oMayorizacion);

                            //Fila en blanco
                            oMayorizacion = new Mayorizacion();
                            oMayorizacion.Fecha = ".";
                            oMayorizacion.Codigo = " ";
                            oMayorizacion.Concepto = " ";
                            oMayorizacion.Debe = " ";
                            oMayorizacion.Haber = " ";
                            oMayorizacion.Saldo = " ";
                            lMayorizacion.Add(oMayorizacion);
                            totalDebe = 0;
                            totalHaber = 0;
                            saldo = 0;
                        }
                        acesso = 1;
                    }

                    oMayorizacion = new Mayorizacion();
                    oMayorizacion.Fecha = reader.GetString(0);
                    oMayorizacion.Codigo = reader.GetString(1);
                    oMayorizacion.Cuenta = reader.GetString(2);
                    oMayorizacion.Concepto = reader.GetString(3);
                    oMayorizacion.Debe = "$  " + (reader.GetValue(4).ToString());
                    oMayorizacion.Haber = "$  " + (reader.GetValue(5).ToString());

                    if (saldo + (Convert.ToDouble(reader.GetValue(4).ToString()) - Convert.ToDouble(reader.GetValue(5).ToString())) < 0)
                    {
                        oMayorizacion.Saldo = "$  " + Convert.ToString(saldo + (Convert.ToDouble(reader.GetValue(4).ToString()) - Convert.ToDouble(reader.GetValue(5).ToString())) * -1);
                        saldo += ((Convert.ToDouble(reader.GetValue(4).ToString()) - Convert.ToDouble(reader.GetValue(5).ToString()))) * -1;
                    }
                    else
                    {
                        oMayorizacion.Saldo = "$  " + Convert.ToString(saldo + (Convert.ToDouble(reader.GetValue(4).ToString()) - Convert.ToDouble(reader.GetValue(5).ToString())));
                        saldo += (Convert.ToDouble(reader.GetValue(4).ToString()) - Convert.ToDouble(reader.GetValue(5).ToString()));
                    }

                    cuentaFlotante = oMayorizacion.Codigo;
                    totalDebe += Convert.ToDouble(reader.GetValue(4).ToString());
                    totalHaber += Convert.ToDouble(reader.GetValue(5).ToString());
                    lMayorizacion.Add(oMayorizacion);

                }
                // Agregamos los ultimos totales
                oMayorizacion = new Mayorizacion();
                oMayorizacion.Fecha = "";
                oMayorizacion.Codigo = "";
                oMayorizacion.Concepto = "                                Total";

                oMayorizacion.Debe = "$  " + Convert.ToString(totalDebe);
                oMayorizacion.Haber = "$  " + Convert.ToString(totalHaber);
                oMayorizacion.Saldo = "$  " + Convert.ToString(saldo);
                lMayorizacion.Add(oMayorizacion);
                reader.Close();
                connect.closeCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return lMayorizacion;
        }

    }
}
