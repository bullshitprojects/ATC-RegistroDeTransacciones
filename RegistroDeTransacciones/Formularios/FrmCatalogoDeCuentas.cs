using RegistroDeTransacciones;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDePagoEmpleados
{
    public partial class Form3 : Form
    {
        Conexionbd conexion = new Conexionbd();
        List<CatalogoDeCuentas> lCatalogo = new List<CatalogoDeCuentas>();

        public Form3()
        {
            InitializeComponent();
            CargarTabla();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void CargarTabla()
        {
            lCatalogo = conexion.CargarCatalogoDeCuentas();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lCatalogo;
            dataGridView1.Visible = true;
        }
    }
}
