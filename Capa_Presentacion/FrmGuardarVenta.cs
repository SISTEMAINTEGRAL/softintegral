using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_negocio;
using System.Globalization;


namespace Capa_Presentacion
{
    public partial class FrmGuardarVenta : Form
    {
        private int codtarjeta;

        public int Codtarjeta
        {
            get { return codtarjeta; }
            set { codtarjeta = value; }
        }
        private bool imprimir = false  ;
        private bool facturar = true;
        private string trans;
        private int idCliente;
        private DataGridView listadoDeProducto;
        private bool isCerro = false;
        private decimal totalAPagar = 0;
        private string tipo_comprobante="";
        private string categoria = "";
        private decimal iva = 0;
        private decimal neto = 0;
        private string formapago = "";
        private decimal importecuota = 0;
        private string nombretarjeta = "";
        private string razonsocial;

        public string Razonsocial
        {
            get { return razonsocial; }
            set { razonsocial = value; }
        }

        public decimal Importecuota
        {
            get { return importecuota; }
            set { importecuota = value; }
        }
        private int cuota = 0;

        public int Cuota
        {
            get { return cuota; }
            set { cuota = value; }
        }
        public string Formapago
        {
            get { return formapago; }
            set { formapago = value; }
        }
        private bool concaja = false;

        public bool Concaja
        {
            get { return concaja; }
            set { concaja = value; }
        }

        private bool constock = false;

        public bool Constock
        {
            get { return constock; }
            set { constock = value; }
        }

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        public string Tipo_comprobante
        {
            get { return tipo_comprobante; }
            set { tipo_comprobante = value; }
        }
        public bool IsCerro
        {
            get { return isCerro; }
            set { isCerro = value; }
        }

        public string Trans
        {
            get { return trans; }
            set { trans = value; }
        }
        public DataGridView ListadoDeProducto
        {
            get { return listadoDeProducto; }
            set { listadoDeProducto = value; }
        }
        private string cupon;

        public string Cupon
        {
            get { return cupon; }
            set { cupon = value; }
        }
        private string lote;

        public string Lote
        {
            get { return lote; }
            set { lote = value; }
        }
        private string cuit;

        public string Cuit
        {
            get { return cuit; }
            set { cuit = value; }
        }

        private string tipofactura;

        public string Tipofactura
        {
            get { return tipofactura; }
            set { tipofactura = value; }
        }

        private string responsableiva;

        public string Responsableiva
        {
            get { return responsableiva; }
            set { responsableiva = value; }
        }

        private string domicilio;

        public string Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }

        Negociocomprobantes objcomprobante = new Negociocomprobantes();
        public FrmGuardarVenta(decimal totalAPagar,int idCliente, decimal ventaiva, decimal ventaneto, string formapago, string nombretarjeta, decimal importecuota, int cuota, int codtarjeta, string cuit, string razonsocial, string tipocomprobante, string responsableiva, string domicilio)
        {
           
            InitializeComponent();
            //redondeo 2 digitos
            this.totalAPagar = decimal.Round(totalAPagar, 2);
            txtTotalAPagar.Text = Convert.ToString(totalAPagar);
            txtAbono.Text = Convert.ToString(totalAPagar);
            lblsubtotal.Text = Convert.ToString(totalAPagar);
            this.idCliente = idCliente;
            this.iva = ventaiva;
            this.neto = ventaneto;
            this.formapago = formapago;
            this.nombretarjeta = nombretarjeta;
            this.cuota = cuota;
            this.importecuota = importecuota;
            this.codtarjeta = codtarjeta;
            this.cuit = cuit;
            this.razonsocial = razonsocial;
            this.tipofactura = tipocomprobante;
            this.domicilio = domicilio;
            this.responsableiva = responsableiva;
            
            
        }

        private void txtAbono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = false;
                e.SuppressKeyPress = true; 
                totales();
               
            }
        }

        private void totales()
        {
            decimal totalPagar = 0;
            decimal abono = 0;
            decimal cambio = 0;
            
               
               
                try
                {
                    if (txtBonificacion.Text != "")
                    {
                        txtTotalAPagar.Text = Convert.ToString(this.totalAPagar - ((Convert.ToDecimal(txtBonificacion.Text) * this.totalAPagar) / 100));
                        //totalPagar = Convert.ToDecimal(txtTotalAPagar.Text);
                        //abono = Convert.ToDecimal(txtAbono.Text);
                        //cambio = abono - (totalPagar);
                        //txtCambio.Text = cambio.ToString();
                    }

                    if (!txtAbono.Text.Contains(","))
                    {
                        txtAbono.Text += ",00";
                    }

                    totalPagar = Convert.ToDecimal(txtTotalAPagar.Text);
                    abono = Convert.ToDecimal(txtAbono.Text);
                    cambio = abono - (totalPagar);
                    //si el cambio es positivo lo agrego o sino muestro un msj
                    if (cambio >= 0 || abono >= totalPagar)
                    {
                        txtCambio.Text = cambio.ToString();
                        lblPrecioEfectivo.Text = Convert.ToString(abono - cambio);
                        lblPrecioTotal.Text = lblPrecioEfectivo.Text;
                    }
                    else
                    {
                        UtilityFrm.mensajeError("El valor ingresado es Incorrecto");
                        txtAbono.Text = "0,0";
                        txtAbono.Focus();
                    }

                }
                catch (Exception ex)
                {
                    UtilityFrm.mensajeError("El valor ingresado es Incorrecto ," + ex.Message);
                    UtilityFrm.limpiarTextbox(txtCambio, txtAbono);
                }




            
           
        }
        public void guardarventa()
        {
            int nroterminal = 0;
            int codtarjeta = 0;
            string cupon = "";
            string lote = "";
            decimal importe = 0;
            int cuota = 0;
            int codformapago = 1;
            string msg = "ok";
            string  precioneto = "";
            string cantidad = "";
            decimal var = 0;
            Char  estadofactura = 'P'; //P : pendiente de factura F : facturado
            string nrocomprobante = "";

            totales();
            NegocioVenta objventa = new NegocioVenta();
            DataTable dt = new DataTable();
            dt.Columns.Add("Codigo", typeof(string));
            dt.Columns.Add("Precio", typeof(decimal));
            dt.Columns.Add("Cantidad", typeof(string));
            dt.Columns.Add("Descuento", typeof(decimal));
            dt.Columns.Add("Importe", typeof(decimal));
            dt.Columns.Add("Producto", typeof(string));
            dt.Columns.Add("Precioneto", typeof(string));
            dt.Columns.Add("Pesable", typeof(int));
            decimal IVA = 21;

            if (formapago == "tarjeta")
            {
                codtarjeta = this.codtarjeta;
                cupon = txtCupon.Text == "" ? "0":txtCupon.Text;
                lote = txtLote.Text == "" ? "0" : txtLote.Text;
                cuota = Convert.ToInt32(lblCuota.Text);
                importe = Convert.ToDecimal(lblImportecuota.Text);
                codformapago = 2;
            }

            
            /*IMPORTANTE HACER NOTA DE VENTA PARA IMPRIMIR*/
            //if (MessageBox.Show("Desea Imprimir Venta?", "Imprimir"
            //   , MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            //{
            //    FrmImpVenta venta = new FrmImpVenta(totalAPagar);
            //    venta.Show();
            //}
            //else {
            //    this.Close();
            //}

            try
            {

                //LISTA DE PRODUCTOS SE LE ASIGNA EN EL MOMENTO QUE SE MUESTRA EL FORMULARIO

                // NumberFormatInfo asociado con la cultura en-US.
                NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;

                    
                
                foreach (DataGridViewRow fila in listadoDeProducto.Rows)
                {
                    if (responsableiva != "EX")
                    {
                        var = Decimal.Round(Convert.ToDecimal(fila.Cells["Precio"].Value) / Convert.ToDecimal(1.21), 2);
                    }
                    else
                    {
                        var = Decimal.Round(Convert.ToDecimal(fila.Cells["Precio"].Value),2);
                    }
                  
                  //Math.Round(decValue, 2, MidpointRounding.AwayFromZero)
                 // var = Math.Round(var, 2, MidpointRounding.AwayFromZero);

                 precioneto  = var.ToString("0.0000",nfi);
                 //var = Convert.ToDecimal(fila.Cells["Cantidad"].Value);
                 //cantidad = var.ToString("0.00", nfi);
                    //recorro la lista pasado por paramentro y asigno al datatable para generar la transaccion
                    //dt.Rows.Add(fila.Cells["Codigo"].Value, fila.Cells["Precio"].Value, fila.Cells["Cantidad"].Value, fila.Cells["Descuento"].Value, fila.Cells["Importe"].Value);
                 dt.Rows.Add(fila.Cells["Codigo"].Value, fila.Cells["Precio"].Value, fila.Cells["Cantidad"].Value, fila.Cells["Descuento"].Value, fila.Cells["Importe"].Value, fila.Cells["Producto"].Value, precioneto, fila.Cells["Dpesable"].Value);



                }

                  
              
              try
              {
                  if (NegocioConfigEmpresa.confsistema("facturar").ToString() == "True" && tipo_comprobante == "NOTA DE VENTA") 
                  { 
                     msg = objcomprobante.factura(NegocioConfigEmpresa.marcafiscal, dt, Convert.ToDouble(txtTotalAPagar.Text), NegocioConfigEmpresa.modelofiscal, NegocioConfigEmpresa.puertofiscal, 
                      1,razonsocial,razonsocial == "CONSUMIDOR FINAL" ? "99999999999": cuit,domicilio,tipofactura,responsableiva);
                  if (msg.Substring (0,2) != "ok")
                  {
                      UtilityFrm.mensajeError(msg);
                      UtilityFrm.mensajeConfirm ("Se guardara la venta como pendiente de factura la puede encontrar en lista de ventas");
                      estadofactura = 'P';
                  }
                  else
                  {
                      estadofactura = 'F';
                      nrocomprobante = msg.Substring(2, 8);
                  }
                  }
                  else
                  {
                      estadofactura = 'P';
                  }

              }
              catch (Exception e)
              {
                  UtilityFrm.mensajeError(e.Message);
              }
              string Rta = objventa.Insertar(this.idCliente, DateTime.Today, Tipo_comprobante, "0000", msg.Substring(0, 2) == "ok" ? nrocomprobante : "0", IVA, this.concaja, this.constock, NegocioConfigEmpresa.usuarioconectado, dt, Convert.ToDecimal(txtBonificacion.Text == "" ? txtBonificacion.Text = "0" : txtBonificacion.Text), Convert.ToDecimal(txtTotalAPagar.Text), Convert.ToDecimal(lblsubtotal.Text), estadofactura, NegocioConfigEmpresa.confsistema("stock").ToString() == this.Name ? true : false, nroterminal, codtarjeta, cupon, lote, importe, cuota, codformapago);
               
                int objnum = objventa.Idventa;

                if (Rta == "OK")
                {
                    if (this.concaja == true)
                    {

                        Rta = Negociocaja.insertarmovcaja(4110107, Convert.ToSingle(txtTotalAPagar.Text), 0, Convert.ToString(DateTime.Now), NegocioConfigEmpresa.usuarioconectado , NegocioConfigEmpresa.idusuario , NegocioConfigEmpresa.turno, "Venta nro : " + objventa.Idventa.ToString(), objventa.Idventa, true);
                    }
                    else
                    {
                        Rta = "ok";
                    }

                    if (Rta == "ok")
                    {
                        trans = Rta;

                        Reporteventa mireporteventa = new Reporteventa();
                        //Frmimpnotaventa miformnotaventa = new Frmimpnotaventa();
                       // Frmimpventicket miformticket = new Frmimpventicket();

                        if (NegocioConfigEmpresa.confsistema("imprimirventa").ToString() == "True")
                        {
                            if (NegocioConfigEmpresa.confsistema("tipoimpresion").ToString() == "tipocarro")
                            {
                                //miformnotaventa.Tipoimp = Convert.ToString(NegocioConfigEmpresa.confsistema("modoimpventa"));
                                //miformnotaventa.Codventa = objventa.Idventa;
                                //miformnotaventa.Show();
                                mireporteventa.Idventa = objventa.Idventa;
                                mireporteventa.ShowDialog ();

                            }

                            else
                            {
                                //miformticket.Tipoimp = Convert.ToString(NegocioConfigEmpresa.confsistema("modoimpventa"));
                                //miformticket.Codventa = objventa.Idventa;
                                //miformticket.Show();
                            
                            }
                           

                        }



                        if (facturar == true)
                        {
                            //  NegocioFHasar objhasar = new NegocioFHasar();
                            //objhasar.Comprobantefiscal(1, 1, "CONSUMIDOR FINAL", "9999999", 1, "", dt,Convert.ToDouble (lblPrecioTotal.Text ));
                        }
                        //  crystalReportViewer1.ReportSource = ventasTicket1;

                        this.Close();
                    }
                    else
                    {

                        UtilityFrm.mensajeError("Error en la base de Datos 1");
                    }

                }
                else
                {

                    UtilityFrm.mensajeError("Error en la base de Datos 2");
                }
            }
            catch (Exception ex)
            {

                UtilityFrm.mensajeError(ex.Message);
            }

           
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            
            guardarventa();



          
            
        }

        private void txtAbono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {

                e.Handled = false;

            }
            else if (e.KeyChar == '.' && !txtAbono.Text.Contains(',')) {
                e.Handled = true;
                SendKeys.Send(",");
               
                
            }
            else if (e.KeyChar == ',' && !txtAbono.Text.Contains(','))
            {

                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {

                e.Handled = false;
            }

            else
            {
                e.Handled = true;

            }
        }

        private void FrmGuardarVenta_Load(object sender, EventArgs e)
        {
           //el foco se posa en abono
           
            llenarComboBoxTarjeta();
            if (formapago == "contado")
            {
                this.tabTarjeta.SelectedTab = tbEfectivo;
            }
            if (formapago == "tarjeta")
	       {
		      this.tabTarjeta.SelectedTab = tbTarjeta;
              lblCuota.Text =  cuota.ToString();
              lblImportecuota.Text = importecuota.ToString();
            
              lblntarjeta.Text = nombretarjeta;
	       }
           
            txtAbono.Focus();
            txtAbono.SelectAll();
           // this.reportViewer1.RefreshReport();
        }
        public void llenarComboBoxTarjeta() {

            //this.cbxTarjeta.DataSource = NegocioFormaDePago.mostrarTarjetas();
            //valor real de la DB
            //this.cbxTarjeta.ValueMember = "cod_forma_pago";
            //lo que se muestra
            //this.cbxTarjeta.DisplayMember = "nombre";
        }
        private void FrmGuardarVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
             isCerro=true;
        }

        private void txtAbono_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmGuardarVenta_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.F2){
                imprimir = true;
                btnGuardar.PerformClick();

            }

            else if (e.KeyCode == Keys.F2)
            {
                imprimir = false ;
                btnGuardar.PerformClick();

            }
            else if (e.KeyCode == Keys.Escape) {
                this.Close();
            }
        }

        private void txtBonificacion_Leave(object sender, EventArgs e)
        {
            
           
           
        }

        private void txtBonificacion_Layout(object sender, LayoutEventArgs e)
        {

        }

        private void txtBonificacion_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                totales();
              
            }
            
        }

        private void txtAbono_DragLeave(object sender, EventArgs e)
        {
            totales();
        }

        private void txtBonificacion_Validated(object sender, EventArgs e)
        {
            totales();
        }

        private void txtAbono_Click(object sender, EventArgs e)
        {
            txtAbono.SelectAll();
        }

        
    }
}
