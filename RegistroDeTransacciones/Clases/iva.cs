using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransaccionesContabilidad.ViewModel
{
    public class iva
    {
        public double debitoHaber, debitoDeber,ivaDebito;
        public double creditoHaber, creditoDeber,ivaCredito;
        public double ivaPagar;
        public double ivaDebe, ivaHaber;
        public void CalcularIva(DataGridView tabla)
        {
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                if (tabla.Rows[i].Cells[0].Value.Equals(2109))
                {
                    debitoHaber = Convert.ToDouble(tabla.Rows[i].Cells[3].Value);
                    debitoDeber = Convert.ToDouble(tabla.Rows[i].Cells[2].Value);
                }
                if (tabla.Rows[i].Cells[0].Value.Equals(1112))
                {
                    creditoHaber = Convert.ToDouble(tabla.Rows[i].Cells[3].Value);
                    creditoDeber = Convert.ToDouble(tabla.Rows[i].Cells[2].Value);
                }
            }
            ivaDebito = debitoDeber - debitoHaber;
            ivaCredito = creditoHaber - creditoDeber;
            ivaPagar = ivaCredito - ivaDebito;
            ivaDebe = debitoDeber + creditoDeber;
            ivaHaber = debitoHaber + creditoHaber;
        }
    }
}
