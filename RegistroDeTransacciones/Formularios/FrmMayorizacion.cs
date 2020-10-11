using RegistroDeTransacciones.Reportes;
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
           
            try
            {
                lMayorizacion = conexion.Mayorizacion();
                MayorizacionDoc doc = new MayorizacionDoc();
                doc.PrintDocument(lMayorizacion);
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
            lMayorizacion = conexion.Mayorizacion();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lMayorizacion;
            dataGridView1.Visible = true;
        }
    }
}
