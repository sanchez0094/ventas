using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    abstract class Persona
    {
        protected string nombre;
        protected int documento;
        protected int tipodoc;
        protected bool sexo;
        protected string direccion;


        public string pnombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public int pdocumento
        {
            set { documento = value; }
            get { return documento; }
        }
        public int ptipodoc
        {
            set { tipodoc = value; }
            get { return tipodoc; }
        }
        public bool psexo
        {
            set { sexo = value; }
            get { return sexo; }
        }
        public string pDireccion
        {
            set { direccion = value; }
            get { return direccion; }
        }

        public Persona()
        {
            nombre = direccion = "";
            documento = 0;
            tipodoc = 0;
            sexo = false;

        }
        public Persona(string nombre, int documento, int tipodoc, bool sexo, string direccion)
        {
            this.nombre = nombre;
            this.documento = documento;
            this.tipodoc = tipodoc;
            this.sexo = sexo;
            this.direccion = direccion;

        }
        public string toStringSexo()
        {
            if (sexo == true)
                return "femenino";
            else
                return "masculino";

        }
        public string toStringTipodoc()
        {
            string td = "";
            switch (tipodoc)
            {
                case 1: { td = "D.N.I"; break; }
                case 2: { td = "LE"; break; }
                case 3: { td = "pasaporte"; break; }
            }
            return td;
        }

        public string toStringpersona()
        {
            return
            "Nombre: " + nombre + "\n"
            + "Documento: " + documento + "\n"
            + "Tipo de Documento: " + toStringTipodoc() + "\n"
            + "Sexo:" + toStringSexo() + "\n"
            + "Direccion" + direccion + "\n";
        }
    
}
}
