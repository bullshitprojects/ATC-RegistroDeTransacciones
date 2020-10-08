using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeTransacciones
{
    class BalanceDeComprobacion
    {
        //Declaración de Variables

        private string codigo;
        private string cuenta;
        private double movimientoDeudor;
        private double movimientoAcreedor;
        private double saldoDeudor;
        private double saldoAcreedor;

        // Metodos de Acceso Get y Set

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Cuenta
        {
            get { return cuenta; }
            set { cuenta = value; }
        }

        public double MovimientoDeudor
        {
            get { return movimientoDeudor; }
            set { movimientoDeudor = value; }
        }
        public double MovimientoAcreedor
        {
            get { return movimientoAcreedor; }
            set { movimientoAcreedor = value; }
        }

        public double SaldoDeudor
        {
            get { return saldoDeudor; }
            set { saldoDeudor = value; }
        }
        public double SaldoAcreedor
        {
            get { return saldoAcreedor; }
            set { saldoAcreedor = value; }
        }

        //Metodos
    }
}
