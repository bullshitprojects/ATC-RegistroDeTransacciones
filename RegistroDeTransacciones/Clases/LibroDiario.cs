using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDePagoEmpleados
{
    class LibroDiario
    {
        //Declaración de Variables
        private string fecha;
        private string concepto;
        private string codigo;
        private string asiento;
        private string orden;
        private string cuenta;

        private double parcial;
        private double debe;
        private double haber;

        // Metodos de Acceso Get y Set
        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public string Asiento
        {
            get { return asiento; }
            set { asiento = value; }
        }

        public string Orden
        {
            get { return orden; }
            set { orden = value; }
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

        public double Parcial
        {
            get { return parcial; }
            set { parcial = value; }
        }
        public double Debe
        {
            get { return debe; }
            set { debe = value; }
        }
        public double Haber
        {
            get { return haber; }
            set { haber = value; }
        }



        //Metodos

    }
}
