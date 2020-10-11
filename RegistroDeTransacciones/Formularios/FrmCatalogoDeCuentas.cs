using RegistroDeTransacciones;
using RegistroDeTransacciones.Reportes;
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                CatalogodeCuentaDoc doc = new CatalogodeCuentaDoc();
                doc.PrintDocument(lCatalogo);
                MessageBox.Show("Archivo guardado con éxito en: " + doc.path, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start(doc.path);
            }
            catch (Exception ee)
            {
                MessageBox.Show("Ocurrió un problema al intentar guardar el documento:\n" +  ee , "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
