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

namespace RegistroDeTransacciones.Formularios
{
    public partial class FrmLogin : Form
    {
        Conexionbd conexion = new Conexionbd();
        public FrmLogin()
        {
            InitializeComponent();
            if (conexion.ConsultarEmpresa()==0)
            {
                label5.Enabled = true;
            }
            else
            {
                label5.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (conexion.Login(txtUser.Text,txtContra.Text)==1)
            {
                MessageBox.Show("Bienvenido Acceso consedido");
                FormPrincipal F = new FormPrincipal();
                F.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Invalida");
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {
            FrmAgregarEmpresa F = new FrmAgregarEmpresa();
            F.Show();
        }


    }
}
