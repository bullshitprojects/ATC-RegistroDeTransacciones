﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDePagoEmpleados
{
    class CatalogoDeCuentas
    {
        //Declaración de Variables

        private string codigo;
        private string cuenta;
        private string detalle;
        private string naturaleza;



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

        public string Naturaleza
        {
            get { return naturaleza; }
            set { naturaleza = value; }
        }

        public string Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }

        // Metodo de obtencion de Catalogo de cuenta

        public List<CatalogoDeCuentas> Catalogo()
        {
            List<CatalogoDeCuentas> catalogoDeCuentas = new List<CatalogoDeCuentas>();
            CatalogoDeCuentas Ln = new CatalogoDeCuentas();
            Ln.Codigo = "1101";
            Ln.Cuenta = "EFECTIVO Y EQUIVALENTES DE EFECTIVO";
            Ln.Naturaleza = "Debe";
            Ln.Detalle = "";
            catalogoDeCuentas.Add(Ln);
            Ln = new CatalogoDeCuentas();
            Ln.Codigo = "1102";
            Ln.Cuenta = "INVERSIONES A CORTO PLAZO ";
            Ln.Naturaleza = "Debe";
            Ln.Detalle = "";
            catalogoDeCuentas.Add(Ln);
            Ln = new CatalogoDeCuentas();
            Ln.Codigo = "1103";
            Ln.Cuenta = "EFECTIVO Y EQUIVALENTES DE EFECTIVO";
            Ln.Naturaleza = "Haber";
            Ln.Detalle = "";
            catalogoDeCuentas.Add(Ln);
            Ln = new CatalogoDeCuentas();
            Ln.Codigo = "1104";
            Ln.Cuenta = "INVERSIONES A CORTO PLAZO ";
            Ln.Naturaleza = "Haber";
            Ln.Detalle = "";
            catalogoDeCuentas.Add(Ln);
            return catalogoDeCuentas;
        }
    }
}