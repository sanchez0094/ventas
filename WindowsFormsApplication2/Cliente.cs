using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Cliente: Persona
    {
        private int nroCliente;
        private int tipo;

        public int pNroCliente
        {
            set { nroCliente = value; }
            get { return nroCliente; }
        }
        public int pTipo
        {
            set { tipo = value; }
            get { return tipo; }
        }
        public Cliente() : base()
        {
            nroCliente = 0;
            tipo = 0;
        }
        public Cliente(int nroCliente, int tipo, string nombre, int documento, int tipodoc, bool sexo, string direccion)
            : base(nombre, documento, tipodoc, sexo, direccion)
        {
            this.nroCliente = nroCliente;
            this.tipo = tipo;
        }
        public string toStringtipo()
        {
            string T = "";
            switch (tipo)
            {
                case 1: { T = "Responsable Inscripto"; break; }
                case 2: { T = "Monotributista"; break; }
                case 3: { T = "Consumidor Final"; break; }


            }
            return T;
        }

        public string toStringCliente()
        {
            return "Numero de Cliente" + nroCliente + "\n"
                + "Tipo" + toStringtipo() + "\n"
                + base.toStringpersona() + "\n";
        }


    }
}

