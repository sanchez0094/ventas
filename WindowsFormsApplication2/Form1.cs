using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {

        double CGV, Aart, Amontoventas, cClientesGral, cRI, cM, cCF, aRI, aM, aCF, cVtasRI, cVtasM, cVtasCF, cRIM, cArtMayQ, CArt;

        private void btnnuevo_Click_1(object sender, EventArgs e)
        {
            this.nuevaVenta(true);
            txtNombre.Focus();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta Seguro que decea Cancelar?", "Se eliminaran todos los datos", MessageBoxButtons.YesNo) == DialogResult.Yes)

            {
                this.estadoInicial(false);
                txtnrocliente.Text = "";
                cbocliente.SelectedIndex = -1;
                txtNombre.Text = "";
                txtDocumento.Text = "";
                cboTipoDoc.SelectedIndex = -1;
                txtdomicilio.Text = "";
                txtdescrip.Text = "";
                txtnroArt.Text = "";
                txtprecio.Text = "";
                txtcantidad.Text = "";
                cboarticulo.SelectedIndex = -1;
                txtnroVenta.Text = "";
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)// boton salir
        {
        
            if (MessageBox.Show("¿Esta seguro de salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Close();
            }
        
    }

       

        private void tbpCliente_Click(object sender, EventArgs e)
        {
            this.estadoInicial(false);
        }

       

     

        Ventas aMenorPrecio = null;
        Ventas vmayor = null;

        

        public Form1()
        {
            InitializeComponent();
            CGV = 0;
            CArt = 0;
            Amontoventas = 0;
            Aart = 0;
            cClientesGral = 0;
            cRI = 0;
            cM = 0;
            cCF = 0;
            aRI = 0;
            aM = 0;
            aCF = 0;
            cVtasRI = 0;
            cVtasM = 0;
            cVtasCF = 0;
            cRIM = 0;
            cArtMayQ = 0;
        }
        private void estadoInicial(bool x)//ESTADO INICIAL DE ELEMENTOS DEL FORM
        {
            btncancelar.Enabled = x;
            btnregistrar.Enabled = x;
            btnnuevo.Enabled = !x;
            btnsalir.Enabled = !x;
            gbClientes.Enabled = x;
            gbArticulos.Enabled = x;
            gbVentas.Enabled = x;
        }


        private void nuevaVenta(bool x)//ELEMENTOS DEL FORM EN NUEVA VENTA 
        {
            btncancelar.Enabled = x;
            btnregistrar.Enabled = x;
            btnnuevo.Enabled = !x;
            btnsalir.Enabled = x;
            gbClientes.Enabled = x;
            gbArticulos.Enabled = x;
            gbVentas.Enabled = x;
        }

        private void txtNroCliente_KeyPress(object sender,
         KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar))// solo se introduscan numeros
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar)) //perimitir  retroceso 
            {
                e.Handled = false;
            }
            else
            {

                e.Handled = true; // para desactivar teclas 
            }
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe completar el campo  Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                txtNombre.Focus();

            }
            else if (txtdomicilio.Text == "")
            {
                MessageBox.Show("Debe completar el campo Domicilio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                txtdomicilio.Focus();

            }
            else if (cboTipoDoc.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Tipo de Documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                cboTipoDoc.Focus();
            }
            else if (txtDocumento.Text == "")
            {
                MessageBox.Show("Debe completar el campo Numero de Documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                txtDocumento.Focus();
            }
            else if (txtnrocliente.Text == "")
            {
                MessageBox.Show("Debe completar el campo Numero de Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                txtnrocliente.Focus();
            }
            else if (cbocliente.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Tipo de Cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                cbocliente.Focus();

            }
            else if (txtnroArt.Text == "")
            {
                MessageBox.Show("Debe completar el campo Nro Articulo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                txtnroArt.Focus();

            }
            else if (cboarticulo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un 'Tipo de articulo'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                cboarticulo.Focus();

            }
            else if (txtdescrip.Text == "")
            {
                MessageBox.Show("Debe completar el campo 'Descripción'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                txtdescrip.Focus();

            }
            else if (txtprecio.Text == "")
            {
                MessageBox.Show("Debe completar el campo 'Precio Unitario'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                txtprecio.Focus();

            }
            else if (txtnroVenta.Text == "")
            {
                MessageBox.Show("Debe completar el campo 'Nro Venta'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                txtnroVenta.Focus();

            }
            else if (txtcantidad.Text == "")
            {
                MessageBox.Show("Debe completar el campo 'Cantidad'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                txtcantidad.Focus();

            }
            else
            {
                Cliente c = new Cliente();
                c.pDireccion = txtdomicilio.Text;
                c.pdocumento = Convert.ToInt32(txtDocumento.Text);
                c.pnombre = txtNombre.Text;
                c.pNroCliente = Convert.ToInt32(txtnrocliente.Text);
                c.psexo = rbtfem.Checked;
                c.pTipo = cbocliente.SelectedIndex + 1;
                c.ptipodoc = cboTipoDoc.SelectedIndex + 1;
                cClientesGral++;// contador clientes general

                Articulo a = new Articulo();
                a.pDescripcion = txtdescrip.Text;
                a.pNroArticulo = Convert.ToInt32(txtnroArt.Text);
                a.pPrecio = Convert.ToDouble(txtprecio.Text);
                a.pTipoArticulo = cboarticulo.SelectedIndex + 1;
                CArt++;//contador articulo general 
                Ventas v = new Ventas();
                v.pArticulo = a;
                v.pcliente = c;
                v.pCantidad = Convert.ToDouble(txtcantidad.Text);
                v.pFecha = dtpfecha.Value;
                v.pNroVenta = Convert.ToInt32(txtnroVenta.Text);
                v.calcularMonto();
                lblmontofinal.Text = v.calcularMonto().ToString();//monto final

                CGV++;// cont general
                MessageBox.Show(v.toStringVentas());

                Aart += v.pCantidad; // acumulador de articulos
                lbltotalventas.Text =  Aart.ToString();// total de articulos


                Amontoventas += v.calcularMonto();// acumulador monot de ventas 
                lblfinal.Text = "$" + Amontoventas.ToString();// total ventas de un dia


                lblpmontoventas.Text = "$" + Math.Round((Amontoventas / CGV), 2).ToString();// promedio monto de ventas

                switch (v.pcliente.pTipo)
                {
                    case 1:
                        {
                            cRI++;
                            aRI += v.calcularMonto();
                            break;
                        }
                    case 2:
                        {
                            cM++;
                            aM += v.calcularMonto();
                            break;
                        }
                    case 3:
                        {
                            cCF++;
                            aCF += v.calcularMonto();
                            break;
                        }
                }

                if (cRI > 0)
                { lblPRI.Text = "$" + Math.Round((aRI / cRI), 2).ToString(); }// promedio monto de ventas Rensponsable Inscripto

                if (cRI > 0)
                { lblRI.Text = "%" + Math.Round(((cRI / CGV) * 100), 2).ToString(); }//porcentaje ventas Rensponsable Inscripto

                if (cM > 0)
                { lblPM.Text = "$" + Math.Round((aM / cM), 2).ToString(); }// promedio monto de ventas monotributista

                if (cM > 0)
                { lblM.Text = "%" + Math.Round(((cM / CGV) * 100), 2).ToString(); } // porcentaje ventas monotributista

                if (cCF > 0)
                { lblPCF.Text = "$" + Math.Round((aCF / cCF), 2).ToString(); }// promedio monto de ventas consumidor final
                if (cCF > 0)
                { lblCF.Text = "%" + Math.Round(((cCF / CGV) * 100), 2).ToString(); }//porcentaje ventas consumidor final


                if (c.pTipo == 1 && c.psexo == false)/// hombres resposables inscriptos
                {
                    cRIM++;
                }
                lblPorcCliRespMasc.Text = "%" + Convert.ToString(Math.Round((cRIM / cClientesGral) * 100, 2));



                if (a.pPrecio > 500)
                {
                    cArtMayQ++;
                }
                lblArt500.Text = "$" + Convert.ToString(Math.Round((cArtMayQ / CArt) * 100, 2));


                //Ventas por tipo cliente 

                if (v.pcliente.pTipo == 1)
                    cVtasRI++;

                else if (v.pcliente.pTipo == 2)
                    cVtasM++;
                else
                    cVtasCF++;

                if (cVtasRI >= cVtasM && cVtasRI >= cVtasCF)
                    lblValorTipoCliente.Text = "Responsable Inscripto";
                else if (cVtasM >= cVtasCF)
                    lblValorTipoCliente.Text = "Monotributista";
                else
                    lblValorTipoCliente.Text = "Consumidor Final";

                //Validación para saber cual es la venta con mayor cantidad de articulos vendidos en una sola operación
                if (CGV == 1)
                {
                    vmayor = v;
                }
                else if (vmayor.pCantidad > v.pCantidad)

                {
                    vmayor = v;
                }

                lblNroVentM.Text = Convert.ToString(vmayor.pNroVenta);
                lblFechaM.Text = Convert.ToString(vmayor.pFecha);
                lblNroArticuloM.Text = Convert.ToString(vmayor.pArticulo.pNroArticulo);
                lblTipoArtM.Text = Convert.ToString(vmayor.pArticulo.toStringTipoArticulo());
                lblDesM.Text = vmayor.pArticulo.pDescripcion;
                lblPrecioUM.Text = "$ " + Convert.ToString(vmayor.pArticulo.pPrecio);
                lblCantM.Text = Convert.ToString(vmayor.pCantidad);
                lblMontoM.Text = "$ " + Convert.ToString(vmayor.calcularMonto());
                lblNroClientM.Text = Convert.ToString(vmayor.pcliente.pNroCliente);
                lblClienteM.Text = vmayor.pcliente.pnombre;
                lblTipodocM.Text = Convert.ToString(vmayor.pcliente.ptipodoc);
                lblNumerodocM.Text = Convert.ToString(vmayor.pcliente.pdocumento);
                lblSexoM.Text = vmayor.pcliente.toStringSexo();
                lblTipoclienteM.Text = vmayor.pcliente.toStringtipo();


                if (CGV == 1) /// Articulo mas barato
                {
                    aMenorPrecio = v;
                }
                else if (aMenorPrecio.pArticulo.pPrecio > v.pArticulo.pPrecio)
                {
                    aMenorPrecio = v;
                }



                lblNA.Text = Convert.ToString(aMenorPrecio.pArticulo.pNroArticulo);
                lbltipo.Text = aMenorPrecio.pArticulo.toStringTipoArticulo();
                lbldescripcion.Text = aMenorPrecio.pArticulo.pDescripcion;
                lblpreunitario.Text = "$ " + Convert.ToString(aMenorPrecio.pArticulo.pPrecio);


                txtnrocliente.Text = "";
                cbocliente.SelectedIndex = -1;
                txtNombre.Text = "";
                txtDocumento.Text = "";
                cboTipoDoc.SelectedIndex = -1;
                txtdomicilio.Text = "";
                txtdescrip.Text = "";
                txtnroArt.Text = "";
                txtprecio.Text = "";
                txtcantidad.Text = "";
                cboarticulo.SelectedIndex = -1;
                txtnroVenta.Text = "";

            }
        }
    }
}
    

