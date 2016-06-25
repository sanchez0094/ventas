using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Articulo
    {
        private int nroArticulo;
        private string descripcion;
        private double precio;
        private int tipoArticulo;

        public int pNroArticulo
        {
            set { nroArticulo = value; }
            get { return nroArticulo; }
        }
        public string pDescripcion
        {
            set { descripcion = value; }
            get { return descripcion; }
        }
        public double pPrecio
        {
            set { precio = value; }
            get { return precio; }
        }
        public int pTipoArticulo
        {
            set { tipoArticulo = value; }
            get { return tipoArticulo; }
        }

        public Articulo()
        {
            nroArticulo = tipoArticulo = 0;
            descripcion = "";
            precio = 0;

        }
        public Articulo(int nroArticulo, string descripcion, double precio, int tipoArticulo)
        {
            this.nroArticulo = nroArticulo;
            this.descripcion = descripcion;
            this.precio = precio;
            this.tipoArticulo = tipoArticulo;
        }

        public string toStringTipoArticulo()
        {
            string TA = "";
            switch (tipoArticulo)

            {
                case 1: { TA = "Alimentos"; break; }
                case 2: { TA = "Perfumeria"; break; }
                case 3: { TA = "Limpieza"; break; }

            }
            return TA;

        }

        public string toStringArticulo()
        {
            return
                  "Numero  del Articulo:" + nroArticulo + "\n"
                  + "Descripcion: " + descripcion + "\n"
                  + "Precio:$" + precio + "\n"
                  + "Tipo de Articulo:" + toStringTipoArticulo() + "\n";
        }



    
}
}
