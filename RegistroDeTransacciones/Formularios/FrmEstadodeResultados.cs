using System;
using System.Windows.Forms;
using TransaccionesContabilidad.ViewModel;

namespace RegistroDeTransacciones.Formularios
{
    public partial class FrmEstadodeResultados : Form
    {
        public FrmEstadodeResultados()
        {
            InitializeComponent();
            initBalance();
         }
       

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEstadodeResultados_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InventarioFinal invFinal = new InventarioFinal();
            invFinal.CalcularInventarioFinal(this.dataGridView1);
            iva frmIva = new iva();
            frmIva.CalcularIva(this.dataGridView1);
            estadoDeResultados(invFinal, frmIva);
            this.tabEstado.SelectedTab = tabPage2;
        }

        public void estadoDeResultados(InventarioFinal invFinal, iva Iva)
        {
            this.dataGridView2.Rows.Add(2109, "IVA DEBITO FISCAL", "$" + 0, "$ " + Iva.ivaDebito);
            this.dataGridView2.Rows.Add(2109, "IVA CREDITO FISCAL", "$" + Iva.ivaCredito, "$" + 0);
            this.dataGridView2.Rows.Add(211103, "IVA A PAGAR", 0, "$ " + Iva.ivaPagar);
            this.dataGridView2.Rows.Add("", "AJUSTE DE IVA", "$ " + Iva.ivaCredito, "$ " + (Iva.ivaDebito + Iva.ivaPagar));
            this.dataGridView2.Rows.Add(4101, "COMPRAS", invFinal.inventarioInicial, 0);
            this.dataGridView2.Rows.Add(1109, "INVENTARIO", 0, invFinal.inventarioInicial);
            this.dataGridView2.Rows.Add(0, "MERCANCIA DISPONIBLE", invFinal.inventarioInicial, invFinal.inventarioInicial);
            this.dataGridView2.Rows.Add(1109, "INVENTARIO", invFinal.inventarioFinal, 0);
            this.dataGridView2.Rows.Add(4101, "COMPRAS", 0, invFinal.inventarioFinal);
            this.dataGridView2.Rows.Add(0, "DETERMINAR COSTO DE VENTA", invFinal.inventarioFinal, invFinal.inventarioFinal);
            this.dataGridView2.Refresh();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double suma1, suma2, suma3, suma4;
            suma1 = 0;
            suma2 = 0;
            suma3 = 0;
            suma4 = 0;
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                double deudor, acreedor;
                deudor = Convert.ToDouble(this.dataGridView1.Rows[i].Cells[2].Value);
                acreedor = Convert.ToDouble(this.dataGridView1.Rows[i].Cells[3].Value);
                suma1 += deudor;
                suma2 += acreedor;
                if (deudor > acreedor)
                {
                    this.dataGridView1.Rows[i].Cells[4].Value = deudor - acreedor;
                    suma3 += (deudor - acreedor);
                    this.dataGridView1.Rows[i].Cells[5].Value = 0;
                }
                else
                {
                    this.dataGridView1.Rows[i].Cells[5].Value = acreedor - deudor;
                    suma4 += (acreedor - deudor);
                    this.dataGridView1.Rows[i].Cells[4].Value = 0;
                }
            }
            this.lblSuma1.Text = suma1.ToString();
            this.lblSuma2.Text = suma2.ToString();
            this.lblSuma3.Text = suma3.ToString();
            this.lblSuma4.Text = suma4.ToString();
        }
        public void initBalance()
        {
            this.dataGridView1.Rows.Clear();
            this.dataGridView1.Rows.Add(1109, "INVENTARIO", 0, 0, 0, 0);
            this.dataGridView1.Rows.Add(4101, "COMPRAS", 0, 0, 0, 0);
            this.dataGridView1.Rows.Add(5101, "VENTAS", 0, 0, 0, 0);
            this.dataGridView1.Rows.Add(2109, "IVA DEBITO FISCAL", 0, 0, 0, 0);
            this.dataGridView1.Rows.Add(1112, "IVA CREDITO FISCAL", 0, 0, 0, 0);
            this.dataGridView1.Rows.Add(11010103, "BANCO", 0, 0, 0, 0);
            this.dataGridView1.Rows.Add(11010102, "CAJA CHICA", 0, 0, 0, 0);
            this.dataGridView1.Refresh();
        }
    }
}
