using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransaccionesContabilidad.ViewModel
{
    public class InventarioFinal
    {
        public double inventarioInicial, compras, ventas, inventarioFinal, costoVenta;
        public void CalcularInventarioFinal(DataGridView tabla)
        {
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                if (tabla.Rows[i].Cells[0].Value.Equals(1109))
                {
                    inventarioInicial = Convert.ToDouble(tabla.Rows[i].Cells[4].Value) + Convert.ToDouble(tabla.Rows[i].Cells[5].Value);
                }
                if (tabla.Rows[i].Cells[0].Value.Equals(4101))
                {
                    compras = Convert.ToDouble(tabla.Rows[i].Cells[4].Value) + Convert.ToDouble(tabla.Rows[i].Cells[5].Value);
                }
                if (tabla.Rows[i].Cells[0].Value.Equals(5101))
                {
                    ventas = Convert.ToDouble(tabla.Rows[i].Cells[4].Value) + Convert.ToDouble(tabla.Rows[i].Cells[5].Value);
                }
            }
            inventarioFinal = inventarioInicial + compras - ventas;
            costoVenta = inventarioInicial + compras - inventarioFinal;
        }
    }
}
