using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeTransacciones
{
    class Mayorizacion
    {
        //Declaración de Variables
        private string fecha;
        private string concepto;
        private string codigo;
        private string cuenta;
        private string parcial;
        private string debe;
        private string haber;
        private string saldo;

        //constructor 
        public Mayorizacion()
        {
            Fecha = "\n ";
            Concepto = "\n ";
            Codigo = "\n ";
            Cuenta = "\n ";
            Parcial = "\n ";
            Debe = "\n ";
            Haber = "\n ";
            Saldo = "\n ";
        }
        // Metodos de Acceso Get y Set
        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

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

        public string Concepto
        {
            get { return concepto; }
            set { concepto = value; }
        }

        public string Parcial
        {
            get { return parcial; }
            set { parcial = value; }
        }

        public string Debe
        {
            get { return debe; }
            set { debe = value; }
        }

        public string Haber
        {
            get { return haber; }
            set { haber = value; }
        }

        public string Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
    }
}
