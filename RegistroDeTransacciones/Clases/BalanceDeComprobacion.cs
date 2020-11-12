using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace RegistroDeTransacciones
{
    class BalanceDeComprobacion
    {
        //Declaración de Variables

        private string codigo;
        private string cuenta;
        private double movimientoDeudor;
        private double movimientoAcreedor;
        private double saldoDeudor;
        private double saldoAcreedor;
        private MySqlCommand command;
        private List<BalanceDeComprobacion> lBalanceDeComprobacion;
        private BalanceDeComprobacion oBalanceDeComprobacion;
        private StringBuilder query = new StringBuilder();
        private MySqlDataReader reader;
        private Conexionbd connect;
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

        public double MovimientoDeudor
        {
            get { return movimientoDeudor; }
            set { movimientoDeudor = value; }
        }
        public double MovimientoAcreedor
        {
            get { return movimientoAcreedor; }
            set { movimientoAcreedor = value; }
        }

        public double SaldoDeudor
        {
            get { return saldoDeudor; }
            set { saldoDeudor = value; }
        }
        public double SaldoAcreedor
        {
            get { return saldoAcreedor; }
            set { saldoAcreedor = value; }
        }

        //Metodos

        public List<BalanceDeComprobacion> getBalanceDeComprobacion()
        {
            try
            {
                lBalanceDeComprobacion = new List<BalanceDeComprobacion>();
                double movimientoDeudor = 0;
                double movimientoAcreedor = 0;
                double saldoDeudor = 0;
                double saldoAcreedor = 0;

                query.Append("SELECT codigo, cuenta, SUM(debe) AS deudor, SUM(haber) AS acreedor FROM libro_diario GROUP BY codigo, cuenta ORDER BY codigo");
                connect = new Conexionbd();
                connect.openCon();
                command = new MySqlCommand(query.ToString(), connect.Conectarbd);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    oBalanceDeComprobacion = new BalanceDeComprobacion();
                    oBalanceDeComprobacion.Codigo = reader.GetString(0);
                    oBalanceDeComprobacion.Cuenta = reader.GetString(1);
                    oBalanceDeComprobacion.MovimientoDeudor = Convert.ToDouble(reader.GetValue(2).ToString());
                    oBalanceDeComprobacion.MovimientoAcreedor = Convert.ToDouble(reader.GetValue(3).ToString());
                    double comprobacion = oBalanceDeComprobacion.MovimientoDeudor - oBalanceDeComprobacion.MovimientoAcreedor;
                    if (comprobacion >= 0)
                    {
                        oBalanceDeComprobacion.SaldoDeudor = comprobacion;
                        oBalanceDeComprobacion.SaldoAcreedor = 0;
                    }
                    else
                    {
                        oBalanceDeComprobacion.SaldoDeudor = 0;
                        oBalanceDeComprobacion.SaldoAcreedor = comprobacion * -1;
                    }
                    movimientoDeudor += oBalanceDeComprobacion.MovimientoDeudor;
                    movimientoAcreedor += oBalanceDeComprobacion.MovimientoAcreedor;
                    saldoDeudor += oBalanceDeComprobacion.SaldoDeudor;
                    saldoAcreedor += oBalanceDeComprobacion.SaldoAcreedor;
                    lBalanceDeComprobacion.Add(oBalanceDeComprobacion);
                }

                reader.Close();
                connect.closeCon();
                oBalanceDeComprobacion = new BalanceDeComprobacion();
                oBalanceDeComprobacion.Cuenta = "           Sumas Iguales";
                oBalanceDeComprobacion.MovimientoDeudor = movimientoDeudor;
                oBalanceDeComprobacion.MovimientoAcreedor = movimientoAcreedor;
                oBalanceDeComprobacion.SaldoDeudor = saldoDeudor;
                oBalanceDeComprobacion.SaldoAcreedor = saldoAcreedor;
                lBalanceDeComprobacion.Add(oBalanceDeComprobacion);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo consultar bien: " + ex.ToString());
            }
            return lBalanceDeComprobacion;
        }
    }
}
