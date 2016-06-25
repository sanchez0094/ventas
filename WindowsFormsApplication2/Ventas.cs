using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class Ventas
    {
        private int nroVenta;
        private DateTime fecha;
        private double cantidad;
        private Cliente cliente;
        private Articulo articulo;

        public int pNroVenta
        {
            set { nroVenta = value; }
            get { return nroVenta; }
        }
        public DateTime pFecha
        {
            set { fecha = value; }
            get { return fecha; }
        }
        public double pCantidad
        {
            set { cantidad = value; }
            get { return cantidad; }
        }
        internal Cliente pcliente
        {
            set { cliente = value; }
            get { return cliente; }
        }

        internal Articulo pArticulo
        {
            set { articulo = value; }
            get { return articulo; }
        }

        public Ventas()
        {
            nroVenta = 0;
            fecha = DateTime.Today;
            cantidad = 0;
            cliente = null;
            articulo = null;
        }

        public Ventas(int nroVenta, DateTime fecha, double cantidad, Cliente cliente, Articulo articulo)
        {
            this.nroVenta = nroVenta;
            this.fecha = fecha;
            this.cantidad = cantidad;
            this.cliente = cliente;
            this.articulo = articulo;
        }
        public double calcularMonto()
        {
            return
                   Math.Round((cantidad * articulo.pPrecio), 2);
        }

        public string toStringVentas()
        {
            return
                    "Numero de Venta: " + nroVenta + "\n"
                    + "Fecha: " + fecha + "\n"
                    + "Cantidad: " + cantidad + "\n"
                    + "Cliente:" + cliente.toStringCliente() + "\n"
                    + "Articulo:" + articulo.toStringArticulo() + "\n"
                    + "Monto Final:$" + calcularMonto() + "\n";
        }
    }
}
