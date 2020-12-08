using RegistroDeTransacciones.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDeTransacciones.Formularios
{
    public partial class FrmBalanceGeneral : Form
    {
        List<BalanceDeComprobacion> lBalance = new List<BalanceDeComprobacion>();
        List<BalanceGeneral> lActivo = new List<BalanceGeneral>();
        List<BalanceGeneral> lPasivo = new List<BalanceGeneral>();
        List<BalanceGeneral> lCapital = new List<BalanceGeneral>();
        List<BalanceGeneral> lCuentasDeudoras = new List<BalanceGeneral>();
        List<BalanceGeneral> lCuentasAcreedoras = new List<BalanceGeneral>();

        BalanceDeComprobacion oBalance;
        BalanceGeneral oActivo;
        BalanceGeneral oPasivo;
        BalanceGeneral oCapital;
        BalanceGeneral oCuentasDeudoras;
        BalanceGeneral oCuentasAcreedoras;

        double activo = 0;
        double pasivo = 0;
        double capital = 0;
        double cuentasDeudoras = 0;
        double cuentasAcreedoras = 0;
        double inventarioInicial = 0;
        double inventarioFinal = 0;
        double totalMercancias = 0;
        double utilidadBruta = 0;
        double impuesto=0;
        double utilidad = 0;


        public FrmBalanceGeneral()
        {
            InitializeComponent();
            CargarTabla();
        }

        public void CargarTabla()
        {
            try
            {
                oBalance = new BalanceDeComprobacion();
                lBalance = oBalance.getBalanceDeComprobacion();

                foreach (var item in lBalance)
                {

                    switch (item.Codigo.Substring(0, 1))
                    {
                        case "1":
                            oActivo = new BalanceGeneral();
                            oActivo.Cuenta = item.Cuenta;
                            oActivo.Saldo = "$  " + Convert.ToString(item.SaldoDeudor);
                            lActivo.Add(oActivo);
                            activo += item.SaldoDeudor;
                            break;
                        case "2":
                            oPasivo = new BalanceGeneral();
                            oPasivo.Cuenta = item.Cuenta;
                            oPasivo.Saldo = "$  " + Convert.ToString(item.SaldoAcreedor);
                            lPasivo.Add(oPasivo);
                            pasivo += item.SaldoAcreedor;
                            break;
                        case "3":
                            oCapital = new BalanceGeneral();
                            oCapital.Cuenta = item.Cuenta;
                            oCapital.Saldo = "$  " + Convert.ToString(item.SaldoAcreedor);
                            lCapital.Add(oCapital);
                            capital += item.SaldoAcreedor;
                            break;

                        case "4":
                            oCuentasDeudoras = new BalanceGeneral();
                            oCuentasDeudoras.Cuenta = item.Cuenta;
                            oCuentasDeudoras.Saldo = "$  " + Convert.ToString(item.SaldoDeudor);
                            lCuentasDeudoras.Add(oCuentasDeudoras);
                            cuentasDeudoras += item.SaldoDeudor;
                            break;

                        case "5":
                            oCuentasAcreedoras = new BalanceGeneral();
                            oCuentasAcreedoras.Cuenta = item.Cuenta;
                            oCuentasAcreedoras.Saldo = "$  " + Convert.ToString(item.SaldoAcreedor);
                            lCuentasAcreedoras.Add(oCuentasAcreedoras);
                            cuentasAcreedoras += item.SaldoAcreedor;
                            break;
                    }

                }

                oActivo = new BalanceGeneral();
                oActivo.Cuenta = "    Total Activos";
                oActivo.Saldo = "$  " + Convert.ToString(activo);
                lActivo.Add(oActivo);

                oPasivo = new BalanceGeneral();
                oPasivo.Cuenta = "    Total Pasivos";
                oPasivo.Saldo = "$  " + Convert.ToString(pasivo);
                lPasivo.Add(oPasivo);

                oCapital = new BalanceGeneral();
                oCapital.Cuenta = "    Total Capital";
                oCapital.Saldo = "$  " + Convert.ToString(capital);
                lCapital.Add(oCapital);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = lActivo;
                dataGridView1.Visible = true;

                dataGridView2.DataSource = null;
                dataGridView2.DataSource = lPasivo;
                dataGridView2.Visible = true;

                dataGridView3.DataSource = null;
                dataGridView3.DataSource = lCapital;
                dataGridView3.Visible = true;

                txtActivos.Text = Convert.ToString(activo);
                txtPasivos.Text = Convert.ToString(pasivo + capital);



            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtInventarioInicial_Leave(object sender, EventArgs e)
        {
            CalcularER();
        }

        private void txtInventarioFinal_Leave(object sender, EventArgs e)
        {
            CalcularER();
        }

        public void CalcularER() {
            try
            {
                if (txtInventarioInicial.Text != "" && txtInventarioFinal.Text != "")
                {
                    inventarioInicial = Convert.ToDouble(txtInventarioInicial.Text);
                    //txtInventarioInicial.Text = "$ " + inventarioInicial.ToString();
                    inventarioFinal = Convert.ToDouble(txtInventarioFinal.Text);
                    //txtInventarioFinal.Text = "$ " + inventarioFinal.ToString();
                    totalMercancias = inventarioInicial - inventarioFinal;
                    txtTotalMercancias.Text = "$ " + totalMercancias.ToString();

                    // Estado resultados
                    utilidadBruta = cuentasAcreedoras - cuentasDeudoras - totalMercancias;
                    txtUtilidadbruta.Text = "$ " + utilidadBruta.ToString();

                    impuesto = utilidadBruta * .25;
                    txtImpuesto.Text = "$ " + impuesto.ToString();

                    utilidad = utilidadBruta - impuesto;
                    txtUtilidadNeta.Text= "$ " + utilidad.ToString();

                }


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
