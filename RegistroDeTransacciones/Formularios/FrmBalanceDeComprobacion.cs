using RegistroDeTransacciones.Reportes;
using SistemaDePagoEmpleados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDeTransacciones
{
    public partial class FrmBalanceDeComprobacion : Form
    {
        List<BalanceDeComprobacion> lBalance = new List<BalanceDeComprobacion>();
        BalanceDeComprobacion oBalance;

        public FrmBalanceDeComprobacion()
        {
            InitializeComponent();
            CargarTabla();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            try
            {
                oBalance = new BalanceDeComprobacion();
                lBalance = oBalance.getBalanceDeComprobacion();
                BalancedeComprobacionDoc doc = new BalancedeComprobacionDoc();
                doc.PrintDocument(lBalance);
                MessageBox.Show("Archivo guardado con éxito en: " + doc.path, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start(doc.path);
            }
            catch (Exception ee)
            {
                MessageBox.Show("Ocurrió un problema al intentar guardar el documento:\n" + ee, "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        public void CargarTabla()
        {
            oBalance = new BalanceDeComprobacion();
            lBalance = oBalance.getBalanceDeComprobacion();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lBalance;
            dataGridView1.Visible = true;
        }
    }
}
