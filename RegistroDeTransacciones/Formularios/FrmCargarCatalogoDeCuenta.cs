﻿using SistemaDePagoEmpleados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace RegistroDeTransacciones
{
    public partial class FrmCargarCatalogoDeCuenta : Form
    {
        List<CatalogoDeCuentas> lCatalogo = new List<CatalogoDeCuentas>();
        CatalogoDeCuentas oCatalogo;

        public FrmCargarCatalogoDeCuenta()
        {
            InitializeComponent();
            CargarTabla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CargarTabla()
        {
            oCatalogo = new CatalogoDeCuentas();
            lCatalogo = oCatalogo.CargarCatalogoDeCuentas();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lCatalogo;
            dataGridView1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1.f1.txtConcepto.Focus();
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Mandamos nuestro DataGridView y la posición deseada
                Form1.f1.txtCod.Text = DataGridViewUtils.GetValorCelda(dataGridView1, 0);
                Form1.f1.txtCuenta.Text = DataGridViewUtils.GetValorCelda(dataGridView1, 1);
                if (DataGridViewUtils.GetValorCelda(dataGridView1, 2)=="Parcial")
                {
                    Form1.f1.txtNaturaleza.SelectedIndex =01;
                }
                if (DataGridViewUtils.GetValorCelda(dataGridView1, 2) == "Debe")
                {
                    Form1.f1.txtNaturaleza.SelectedIndex = 1;
                }
                if (DataGridViewUtils.GetValorCelda(dataGridView1, 2) == "Haber")
                {
                    Form1.f1.txtNaturaleza.SelectedIndex = 2;
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        public class DataGridViewUtils
        {
            public static string GetValorCelda(DataGridView dgv, int num)
            {
                try
                {
                    string valor = "";
                    valor = dgv.Rows[dgv.CurrentRow.Index].Cells[num].Value.ToString();
                    return valor;
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }
    }
}
