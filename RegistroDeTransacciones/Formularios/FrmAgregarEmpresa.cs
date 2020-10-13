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
    public partial class FrmAgregarEmpresa : Form
    {
        Conexionbd conexion = new Conexionbd();
        public FrmAgregarEmpresa()
        {
            InitializeComponent();
            txtNombre.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Mensaje = conexion.AgregarEmpresa(txtNombre.Text, txtNit.Text, txtRazonSocial.Text, txttEmail.Text, txtUser.Text, txtContra.Text);
            MessageBox.Show(Mensaje);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAgregarEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                string Mensaje = conexion.AgregarEmpresa(txtNombre.Text, txtNit.Text, txtRazonSocial.Text, txttEmail.Text, txtUser.Text, txtContra.Text);
                MessageBox.Show(Mensaje);
                this.Close();
            }
        }
    }
}
