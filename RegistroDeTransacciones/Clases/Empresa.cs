using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeTransacciones.Clases
{
    class Empresa
    {
        //Declaración de Variables
        private string nEmpresa;
        private string nitEmpresa;
        private string razonSocial;
        private string email;
        private string usuario;
        private string contra;

        // Metodos de Acceso Get y Set
        public string NEmpresa
        {
            get { return nEmpresa; }
            set { nEmpresa = value; }
        }

        public string RazonSocial
        {
            get { return razonSocial; }
            set { razonSocial = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string NitEmpresa
        {
            get { return nitEmpresa; }
            set { nitEmpresa = value; }
        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public string Contra
        {
            get { return contra; }
            set { contra = value; }
        }


    }
}
