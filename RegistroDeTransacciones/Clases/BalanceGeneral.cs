using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeTransacciones.Clases
{
    class BalanceGeneral
    {
        //Declaración de Variables
        private string cuenta;
        private string saldo;

        // Metodos de Acceso Get y Set


        public string Cuenta
        {
            get { return cuenta; }
            set { cuenta = value; }
        }

        public string Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

    }
}
