using RegistroDeTransacciones.Reportes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RegistroDeTransacciones.Formularios
{
    public partial class FrmMayorizacion : Form
    {
        Mayorizacion oMayorizacion;
        List<Mayorizacion> lMayorizacion = new List<Mayorizacion>();

        public FrmMayorizacion()
        {
            InitializeComponent();
            CargarTabla();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            try
            {
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
            oMayorizacion = new Mayorizacion();
            lMayorizacion = oMayorizacion.getMayorizacion();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lMayorizacion;
            dataGridView1.Visible = true;
        }
    }
}
