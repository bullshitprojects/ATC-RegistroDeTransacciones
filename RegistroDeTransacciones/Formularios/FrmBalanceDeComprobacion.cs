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
        Conexionbd conexion = new Conexionbd();

        public FrmBalanceDeComprobacion()
        {
            InitializeComponent();
            CargarTabla();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lBalance = conexion.BalanceDeComprobacion(); // Obtencion de la lista de Balance de Comprobacion

            //programar reporte de balance de comprobacion -- Julio


        }

        public void CargarTabla()
        {
            lBalance = conexion.BalanceDeComprobacion();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lBalance;
            dataGridView1.Visible = true;
        }
    }
}
