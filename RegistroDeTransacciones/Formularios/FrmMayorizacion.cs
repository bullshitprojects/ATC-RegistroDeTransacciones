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
    public partial class FrmMayorizacion : Form
    {

        List<Mayorizacion> lMayorizacion = new List<Mayorizacion>();
        Conexionbd conexion = new Conexionbd();

        public FrmMayorizacion()
        {
            InitializeComponent();
            CargarTabla();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lMayorizacion = conexion.Mayorizacion(); // Obtencion de la lista de Mayorizacion por cuentas
            // esta se utilizo todo en string ya que se necesita poner filas en blanco.

            //programar reporte de balance de comprobacion -- Julio

        }

        public void CargarTabla()
        {
            lMayorizacion = conexion.Mayorizacion();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lMayorizacion;
            dataGridView1.Visible = true;
        }
    }
}
