using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransaccionesContabilidad.ViewModel
{
    class AjusteIva
    {
        public Double SaldoIvaDebitoFiscal { get; set; }
        public Double SaldoIvaCreditoFiscal { get; set; }

        public Double IvaAPagarDebe { get; set; }
        public Double IvaAPagarHaber { get; set; }

        public Double ajuste { get; set; }

        public void getIvaAPagar()
        {
            this.IvaAPagarDebe = 0; this.IvaAPagarHaber = 0;

            // Termina en haber
            if (SaldoIvaDebitoFiscal > SaldoIvaCreditoFiscal)
            {
                this.IvaAPagarHaber = this.SaldoIvaDebitoFiscal - SaldoIvaCreditoFiscal;
                this.ajuste = SaldoIvaDebitoFiscal;
            }

            // Termina en debe
            else if (SaldoIvaCreditoFiscal > SaldoIvaDebitoFiscal)
            {
                this.IvaAPagarDebe = this.SaldoIvaCreditoFiscal - SaldoIvaDebitoFiscal;
                this.ajuste = SaldoIvaCreditoFiscal;
            }

            // Se liquidan de una vez
            else if (SaldoIvaDebitoFiscal == SaldoIvaCreditoFiscal)
            {
                this.ajuste = 0;
            }
        }
    }
}
