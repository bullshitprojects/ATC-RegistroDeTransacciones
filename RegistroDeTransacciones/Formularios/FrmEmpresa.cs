using RegistroDeTransacciones;
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

namespace SistemaDePagoEmpleados
{
    public partial class Form2 : Form
    {
        Conexionbd conexion = new Conexionbd();
        Empresa oEmpresa = new Empresa();
        public Form2()
        {
            InitializeComponent();
            CargarDatos();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Mensaje = conexion.EliminarEmpresa();
            MessageBox.Show(Mensaje);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Mensaje = conexion.ModificarEmpresa(txtNombre.Text, txtNit.Text, txtRazonSocial.Text, txtEmail.Text, txtUser.Text, txtContra.Text);
            MessageBox.Show(Mensaje);
            this.Close();
        }

        public void CargarDatos() {
            oEmpresa = conexion.CargarEmpresa();
            txtNombre.Text = oEmpresa.NEmpresa;
            txtNit.Text = oEmpresa.NitEmpresa;
            txtRazonSocial.Text = oEmpresa.RazonSocial;
            txtEmail.Text = oEmpresa.Email;
            txtUser.Text = oEmpresa.Usuario;
            txtContra.Text = oEmpresa.Contra;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
