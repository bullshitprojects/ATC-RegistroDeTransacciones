﻿using RegistroDeTransacciones;
using RegistroDeTransacciones.Formularios;
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
    public partial class Form1 : Form
    {
        LibroDiario Transaccion = new LibroDiario();
        Conexionbd conexion = new Conexionbd();
        List<LibroDiario> libroDiario = new List<LibroDiario>();
        public static Form1 f1;

        public Form1()
        {
            InitializeComponent();
            Form1.f1 = this;
            CargarTabla();
        }

        public void CrearAsiento()
        {
            try
            {
                Transaccion = new LibroDiario();
                Transaccion.Codigo = txtCod.Text;
                Transaccion.Cuenta = txtCuenta.Text;
                Transaccion.Concepto = txtConcepto.Text;
                Transaccion.Fecha = txtFecha.Text;
                Transaccion.Asiento = Convert.ToString(txtAsiento.Value);
                Transaccion.Orden = Convert.ToString(txtOrden.Value);
                if (txtNaturaleza.SelectedIndex == 0)
                {
                    Transaccion.Parcial = Convert.ToDouble(txtValor.Text);
                }
                else if (txtNaturaleza.SelectedIndex == 1)
                {
                    Transaccion.Debe = Convert.ToDouble(txtValor.Text);
                }
                else if (txtNaturaleza.SelectedIndex == 2)
                {
                    Transaccion.Haber = Convert.ToDouble(txtValor.Text);
                }
                //Agregar Transaccion a la Lista
                libroDiario.Add(Transaccion);

                CargarTabla();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void Limpiar()
        {
            txtCod.Text = "";
            txtCuenta.Text = "";
            txtConcepto.Text = "";
            txtFecha.Text = "";
            txtValor.Text = "";
        }

        public void CargarTabla()
        {
            libroDiario= conexion.CargarLibroDiario();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = libroDiario;
            dataGridView1.Visible = true;
        }


        private void btnCalcularSalario_Click_1(object sender, EventArgs e)
        {
            conexion.InsertarAsiento(txtCod.Text, txtCuenta.Text, txtConcepto.Text, txtFecha.Text, Convert.ToString(txtAsiento.Value), Convert.ToString(txtOrden.Value), txtNaturaleza.SelectedItem.ToString(), Convert.ToDouble(txtValor.Text));        
            CrearAsiento();
            Limpiar();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            FrmCargarCatalogoDeCuenta F = new FrmCargarCatalogoDeCuenta();
            F.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmBalanceDeComprobacion F = new FrmBalanceDeComprobacion();
            F.Show();
        }

        private void btnGenerarBoleta_Click(object sender, EventArgs e)
        {
            FrmMayorizacion F = new FrmMayorizacion();
            F.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
