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
using Capa_Presentacion.Formreportes;
using Telerik.Reporting.Processing;
using Telerik.Reporting;
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
        private decimal iva105;
        private decimal neto105;
        private string opcionimpresion; //impresiondirecta / visor / guardarsinimprimir
        //deja la mercaderia en el formulario de retiro de mercaderia
        private bool pendientedestock;

        private const int INDEX_PRECIO = 4;
        private const int INDEX_PRECIONEGOCIO = 2;
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

        public bool Pendientedestock
        {
            get
            {
                return pendientedestock;
            }

            set
            {
                pendientedestock = value;
            }
        }

        Negociocomprobantes objcomprobante = new Negociocomprobantes();
        public FrmGuardarVenta(decimal totalAPagar,int idCliente, decimal ventaiva, decimal ventaneto, string formapago, string nombretarjeta, decimal importecuota, int cuota, int codtarjeta, string cuit, string razonsocial, string tipocomprobante, string responsableiva, string domicilio, decimal variva105 = 0, decimal varneto105 = 0, bool varpendientestock = false)
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
            this.neto105 = varneto105;
            this.iva105 = variva105;
            this.pendientedestock = varpendientestock;
            
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
                    txtAbono.Text = txtAbono.Text == "" ? "0" : txtAbono.Text;
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
                    UtilityFrm.mensajeError("El valor ingresado es Incorrecto ," + ex.Message + ex.StackTrace);
                    UtilityFrm.Log oLog = new UtilityFrm.Log();
                    oLog.Add(ex.Message + ex.StackTrace);
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


            DataTable DTOrdenpedido = new DataTable();
            DTOrdenpedido.Columns.Add("Codigo", typeof(string));
            DTOrdenpedido.Columns.Add("cantidadparcial", typeof(string));
            DTOrdenpedido.Columns.Add("cantidadtotal", typeof(string));
            DTOrdenpedido.Columns.Add("detalle", typeof(string));

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
            if (formapago == "ctacte")
            {
                codformapago = 3;
            }

            if (formapago == "multipago")
            {
                codformapago = 5;
            }

            try
            {

                //LISTA DE PRODUCTOS SE LE ASIGNA EN EL MOMENTO QUE SE MUESTRA EL FORMULARIO

                // NumberFormatInfo asociado con la cultura en-US.
                NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;

                    
                
                foreach (DataGridViewRow fila in listadoDeProducto.Rows)
                {
                    if (responsableiva != "EX")
                    {
                        var = Decimal.Round(Convert.ToDecimal(fila.Cells[INDEX_PRECIO].Value) / Convert.ToDecimal(1.21), 2);
                    }
                    else
                    {
                        var = Decimal.Round(Convert.ToDecimal(fila.Cells[INDEX_PRECIO].Value),2);
                    }
                  
                  //Math.Round(decValue, 2, MidpointRounding.AwayFromZero)
                 // var = Math.Round(var, 2, MidpointRounding.AwayFromZero);

                 precioneto  = var.ToString("0.0000",nfi);
                 //var = Convert.ToDecimal(fila.Cells["Cantidad"].Value);
                 //cantidad = var.ToString("0.00", nfi);
                    //recorro la lista pasado por paramentro y asigno al datatable para generar la transaccion
                    //dt.Rows.Add(fila.Cells["Codigo"].Value, fila.Cells["Precio"].Value, fila.Cells["Cantidad"].Value, fila.Cells["Descuento"].Value, fila.Cells["Importe"].Value);
                 dt.Rows.Add(fila.Cells["Codigo"].Value, fila.Cells[INDEX_PRECIO].Value, fila.Cells["Cantidad"].Value, fila.Cells["Descuento"].Value, fila.Cells["Importe"].Value, fila.Cells["Producto"].Value, precioneto, fila.Cells["Dpesable"].Value);

                  DTOrdenpedido.Rows.Add(fila.Cells["Codigo"].Value, "0", fila.Cells["Cantidad"].Value, fila.Cells["Producto"].Value);


                }

                  
              
              try
              {
                  if (NegocioConfigEmpresa.confsistema("facturar").ToString() == "True" && tipo_comprobante == "NOTA DE VENTA" && tipofactura != "X") 
                  {
                        if (NegocioConfigEmpresa.marcafiscal != "")
                        {
                            msg = objcomprobante.factura(NegocioConfigEmpresa.marcafiscal, dt, Convert.ToDouble(txtTotalAPagar.Text), NegocioConfigEmpresa.modelofiscal, NegocioConfigEmpresa.puertofiscal,
                                   1, razonsocial, razonsocial == "CONSUMIDOR FINAL" ? "99999999" : cuit, domicilio, tipofactura, responsableiva, "FACTURA", tipofactura, Convert.ToDouble(neto), Convert.ToDouble(iva), Convert.ToDouble(this.neto105), Convert.ToDouble(this.iva105));
                        }
                        else
                        {
                            UtilityFrm.mensajeError("La marca de la fiscal no se encuentra definido, la factura quedara pendiente");
                        }
                  if (msg.Substring (0,2) != "ok")
                  {
                      UtilityFrm.mensajeError(msg);
                      UtilityFrm.mensajeConfirm ("Se guardara la venta como pendiente de factura la puede encontrar en lista de ventas");
                       
                      estadofactura = 'P';
                      tipofactura = "ERROR";
                        }
                  else
                  {

                      estadofactura = 'F';
                            //corregir para que no genere errores
                            int nrocaracteres = Convert.ToInt32 ( msg.Length.ToString ());
                            nrocomprobante = msg.Substring(2, nrocaracteres - 2);
                           

                  }
                  }
                  else
                  {
                      estadofactura = 'P';
                  }

              }
              catch (Exception e)
              {
                    UtilityFrm.Log oLog = new UtilityFrm.Log();
                    oLog.Add(e.Message + e.StackTrace);
                    UtilityFrm.mensajeError(e.Message);
              }
                //valida el stock
                
               this.constock =  NegocioConfigEmpresa.confsistema("stock").ToString() == this.Name && pendientedestock == false ? true : false;

                if (tipo_comprobante == "PRESUPUESTO")
                {
                    constock = false;
                    concaja = false;
                }

              string Rta = objventa.Insertar(this.idCliente, DateTime.Now, Tipo_comprobante, 
                  objcomprobante.Puntoventa.PadLeft(5,'0'), msg.Substring(0, 2) == "ok" ? nrocomprobante.PadLeft(8, '0') : "0", 
                  IVA, this.concaja, NegocioConfigEmpresa.usuarioconectado, dt, 
                  Convert.ToDecimal(txtBonificacion.Text == "" ? txtBonificacion.Text = "0" : txtBonificacion.Text),
                  Convert.ToDecimal(txtTotalAPagar.Text), Convert.ToDecimal(lblsubtotal.Text), estadofactura, llenarventasmultipagos(),
                  this.constock, nroterminal,
                  codtarjeta, cupon, lote, importe, cuota, codformapago, neto,iva,objcomprobante.Cae,objcomprobante.Fechavto,
                  objcomprobante.Numerotipofactura.PadLeft (3,'0'),objcomprobante.Puntoventa.PadLeft (5,'0'),this.iva105,this.neto105);
               
                int objnum = objventa.Idventa;

                if (Rta == "OK" || Rta == "ok")
                {
                    if (pendientedestock == true)
                    {
                        NegocioRetirodeMercaderia.insertar(DateTime.Now, this.idCliente, NegocioConfigEmpresa.idusuario, "VENTA", "PENDIENTE", "", DTOrdenpedido, this.idCliente, 1, objnum);
                    }
                    
                    if (this.concaja == true && tipo_comprobante != "PRESUPUESTO")
                    {

                        Rta = Negociocaja.insertarmovcaja(4110107, Convert.ToSingle(txtTotalAPagar.Text), 0, Convert.ToString(DateTime.Now), NegocioConfigEmpresa.usuarioconectado , NegocioConfigEmpresa.idusuario , NegocioConfigEmpresa.turno, "Venta nro : " + objventa.Idventa.ToString(), objventa.Idventa, true,NegocioConfigEmpresa.nrocaja, codformapago);
                    }
                    else
                    {
                        Rta = "ok";
                    }

                    if (Rta == "ok")
                    {
                        trans = Rta;

                        Reporteventa mireporteventa = new Reporteventa();
                        // Frmimpnotaventa miformnotaventa = new Frmimpnotaventa();
                        // Frmimpventicket miformticket = new Frmimpventicket();

                        if (tipo_comprobante != "PRESUPUESTO")
                        {
                            if (NegocioConfigEmpresa.confsistema("imprimirventa").ToString() == "True")
                            {
                                if (NegocioConfigEmpresa.confsistema("tipoimpresion").ToString() == "tipocarro")
                                {
                                    //con crystal report
                                    //  miformnotaventa.Tipoimp = Convert.ToString(NegocioConfigEmpresa.confsistema("modoimpventa"));
                                    //   miformnotaventa.Codventa = objventa.Idventa;
                                    //   miformnotaventa.Show();
                                    // con reportviewer
                                     
                                    mireporteventa.Idventa = objventa.Idventa;
                                    mireporteventa.ShowDialog();

                                }

                                else
                                {
                                    if (NegocioConfigEmpresa.marcafiscal == "elec" && tipofactura != "X" && tipofactura != "ERROR")
                                    {
                                        if (opcionimpresion != "")
                                        {
                                            Ticketventa miticket = new Formreportes.Ticketventa(objventa.Idventa, opcionimpresion);
                                            miticket.ShowDialog();


                                        }
                                    }
                                    else if (tipofactura == "X")
                                    {
                                        if (opcionimpresion != "")
                                        {
                                            TicketProforma miticketproforma = new Formreportes.TicketProforma(objventa.Idventa, opcionimpresion);
                                            miticketproforma.ShowDialog();
                                        }

                                    }
                                    //miformticket.Tipoimp = Convert.ToString(NegocioConfigEmpresa.confsistema("modoimpventa"));
                                    //miformticket.Codventa = objventa.Idventa;
                                    //miformticket.Show();

                                }


                            }
                        }
                        else if (tipo_comprobante == "PRESUPUESTO")
                        {
                            FrmReportPresup frmReportPresup = new FrmReportPresup(objventa.Idventa);
                            frmReportPresup.ShowDialog();
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

                // Qué ha sucedido
                var mensaje = "Error message: " + ex.Message;

                // Información sobre la excepción interna
                if (ex.InnerException != null)
                {
                    mensaje = mensaje + " Inner exception: " + ex.InnerException.Message;
                }

                // Dónde ha sucedido
                mensaje = mensaje + " Stack trace: " + ex.StackTrace;
                UtilityFrm.Log oLog = new UtilityFrm.Log();
                oLog.Add(mensaje);
                UtilityFrm.mensajeError(mensaje);
            }

           
        }

       
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
           
            guardarventa();



          
            
        }
        private DataTable llenarventasmultipagos()
        {
            int codformap = 0;
            int count = 1;
            DataTable Dataventa = new DataTable();

            Dataventa.Columns.Add("idventa", typeof(int));
            Dataventa.Columns.Add("idcliente", typeof(int));
            Dataventa.Columns.Add("fecha", typeof(DateTime));
            Dataventa.Columns.Add("tipo_comprobante", typeof(string));
            Dataventa.Columns.Add("iva", typeof(decimal));
            Dataventa.Columns.Add("estado", typeof(string));
            Dataventa.Columns.Add("categoria", typeof(int));
            Dataventa.Columns.Add("encaja", typeof(bool));
            Dataventa.Columns.Add("enstock", typeof(bool));
            Dataventa.Columns.Add("usuario", typeof(string));
            Dataventa.Columns.Add("descuento", typeof(decimal));
            Dataventa.Columns.Add("total", typeof(decimal));
            Dataventa.Columns.Add("subtotal", typeof(decimal));
            Dataventa.Columns.Add("codformapago", typeof(int));
            Dataventa.Columns.Add("nrocomprobante", typeof(string));
            Dataventa.Columns.Add("total_neto", typeof(decimal));
            Dataventa.Columns.Add("precio_iva", typeof(decimal));
            Dataventa.Columns.Add("cae", typeof(string));
            Dataventa.Columns.Add("cae_fechavencimiento", typeof(string));
            Dataventa.Columns.Add("tipofactura", typeof(string));
            Dataventa.Columns.Add("puntoventa", typeof(string));
            Dataventa.Columns.Add("total_neto105", typeof(decimal));
            Dataventa.Columns.Add("precio_iva105", typeof(decimal));
            // Dataventa.Columns.Add("idmltpadre", typeof(int));
            Dataventa.Columns.Add("idcupon", typeof(int));
            Dataventa.Columns.Add("nroterminal", typeof(int));
            Dataventa.Columns.Add("Codtarjeta", typeof(int));
            Dataventa.Columns.Add("cupon", typeof(string));
            Dataventa.Columns.Add("lote", typeof(string));
            Dataventa.Columns.Add("importe", typeof(decimal));
            Dataventa.Columns.Add("cuotas", typeof(int));



            foreach (DataGridViewRow dataGrid in DGMultiPago.Rows)
            {
                if (dataGrid.Cells["FPago"].Value.ToString() == "EFECTIVO")
                {
                    codformap = 1;
                }
                if (dataGrid.Cells["FPago"].Value.ToString() == "TARJETA")
                {
                    codformap = 2;
                }
                if (dataGrid.Cells["FPago"].Value.ToString() == "CTACTE")
                {
                    codformap = 3;
                }


                Dataventa.Rows.Add(count, idCliente, DateTime.Now, "NOTA DE VENTA", 0, "P", "0", this.Concaja, this.constock, NegocioConfigEmpresa.usuarioconectado,
                   0, dataGrid.Cells["Importe"].Value, "0", codformap, "0", 0, "0", "0", "", "0", NegocioConfigEmpresa.puntoventa.PadLeft(5, '0'), "0", "0",
                    "0", "0", dataGrid.Cells["cCodTarjeta"].Value, dataGrid.Cells["cCupon"].Value, dataGrid.Cells["cLote"].Value,
                    dataGrid.Cells["cImporteCuota"].Value, dataGrid.Cells["cCuota"].Value);
                count++;
            }

            return Dataventa;

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
            try
            {
                llenarComboBoxTarjeta();
                if (formapago == "contado")
                {
                    this.tabTarjeta.SelectedTab = tbEfectivo;
                }
                if (formapago == "tarjeta")
                {
                    this.tabTarjeta.SelectedTab = tbTarjeta;
                    lblCuota.Text = cuota.ToString();
                    lblImportecuota.Text = importecuota.ToString();

                    lblntarjeta.Text = nombretarjeta;
                }
                if (formapago == "multipago")
                {
                    PanelMultipago.Visible = true;
                    CbFormaPago.SelectedIndex = 0;

                    cbTarjeta.DataSource = NegocioVenta.tarjeta();
                    //valor real de la DB
                    this.cbTarjeta.ValueMember = "Codigo";
                    //lo que se muestra
                    this.cbTarjeta.DisplayMember = "Descripcion";
                    cbTarjeta.SelectedIndex = 1;
                    txtTotalAPagar.Text = "0";
                    TxtSaldo.Text = totalAPagar.ToString();
                    TxtImporte.Text = TxtSaldo.Text;

                }
                else
                {
                    PanelMultipago.Visible = false;
                }
                txtAbono.Focus();
                txtAbono.SelectAll();
                // this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {

                // Qué ha sucedido
                var mensaje = "Error message: " + ex.Message;

                // Información sobre la excepción interna
                if (ex.InnerException != null)
                {
                    mensaje = mensaje + " Inner exception: " + ex.InnerException.Message;
                }

                // Dónde ha sucedido
                mensaje = mensaje + " Stack trace: " + ex.StackTrace;
                UtilityFrm.Log oLog = new UtilityFrm.Log();
                oLog.Add(mensaje);
                UtilityFrm.mensajeError(mensaje);
            }


           
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
                opcionimpresion = "";
                guardarventa();

            }
            else if (e.KeyCode == Keys.I)
            {
                opcionimpresion = "impresiondirecta";
                guardarventa();
            }
            else if (e.KeyCode == Keys.V)
            {
                opcionimpresion = "visor";
                guardarventa();
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

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            //minimiza
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
           
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            //restaurar
            
            this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btnMinimizar_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void btnCerrar_MouseMove(object sender, MouseEventArgs e)
        {
            btnCerrar.BackColor = Color.Red;
        }

        private void btnMaximizar_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btnMaximizar_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnMaximizar_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.FromArgb(0, 100,200);
        }

        private void btnRestaurar_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btnRestaurar_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void panelHorizontal_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void panelHorizontal_MouseMove(object sender, MouseEventArgs e)
        {
            int posY = 0;
            int posX = 0;
            //mientra no se apreta el boton izquierdo del mouse actualiza el valor posX Y posY 
            if (e.Button != MouseButtons.Left)
            {
                posY = e.Y;
                posX = e.X;

            }
            else
            {
                //Left tiene la distancia que hay entre el borde izq y el fondo de la pantalla
                Left = Left + (e.X - posX);
                //top tiene la distancia que hay entre el borde sup y el fondo de la pantalla
                Top = Top + (e.Y - posY);

            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            agregardatagridmultipago();
        }

        private void cbMCuota_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (cbMCuota.SelectedIndex >= 0 && CbFormaPago.Text == "TARJETA")
            {
                CalcularCuota();
            }
        }

        private void cbMCuota_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cbTarjeta_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbTarjeta.ValueMember != "")
            {
                cbMCuota.DataSource = NegocioVenta.tarjeta(10, Convert.ToInt32(cbTarjeta.SelectedValue));
                //valor real de la DB
                this.cbMCuota.ValueMember = "porcentaje";
                //lo que se muestra
                this.cbMCuota.DisplayMember = "cuota";
            }
        }

        private void CbFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbFormaPago_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtImporte_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.E)
            {
                CbFormaPago.SelectedIndex = 0;
            }
            if (e.KeyCode == Keys.T)
            {
                CbFormaPago.SelectedIndex = 1;
            }
            if (e.KeyCode == Keys.C)
            {
                CbFormaPago.SelectedIndex = 2;
            }
            if (e.KeyCode == Keys.Enter)
            {
                if (CbFormaPago.Text == "TARJETA")
                {
                    CalcularCuota();
                    cbTarjeta.Focus();
                }
                if (CbFormaPago.Text == "EFECTIVO" || CbFormaPago.Text == "CTACTE")
                {
                    agregardatagridmultipago();
                    TxtImporte.Focus();
                    TxtImporte.SelectAll();
                }

            }
        }

        private void agregardatagridmultipago()
        {
            try
            {
                bool agregaralgrid = true;
                decimal importe = 0;
                decimal saldo = 0;


                if (TxtImporte.Text == "0" || TxtImporte.Text == "")
                {
                    agregaralgrid = false;
                }
                importe = Convert.ToDecimal(TxtImporte.Text);


                saldo = Convert.ToDecimal(TxtSaldo.Text) - importe;

                if (saldo < 0)
                {
                    UtilityFrm.mensajeError("El importe que se desea pagar esta por debajo del saldo");
                    return;
                }
                if (CbFormaPago.Text == "TARJETA")
                {
                    if (TxtLote2.Text == "" || Txtcupon2.Text == "" || cbMCuota.Text == "" || Txtcuota.Text == "" || cbTarjeta.Text == "")
                    {
                        agregaralgrid = false;
                    }


                    agregaralgrid = TxtLote2.Text == "0" ? false : true;
                    agregaralgrid = Txtcupon2.Text == "0" ? false : true;

                    if (agregaralgrid == true)
                    {
                        CalcularCuota();
                        importe = Convert.ToDecimal(Txtcuota.Text) * Convert.ToDecimal(cbMCuota.Text);
                        DGMultiPago.Rows.Add(CbFormaPago.Text, importe.ToString(), TxtLote2.Text, Txtcupon2.Text, cbMCuota.Text, Txtcuota.Text, cbTarjeta.SelectedValue, TxtImporte.Text);
                    }
                    else
                    {
                        UtilityFrm.mensajeError("Hay campos que no se encuentran completados");
                    }

                }
                else if (CbFormaPago.Text == "")
                {
                    UtilityFrm.mensajeError("Elija la forma de pago");
                }
                else
                {

                    DGMultiPago.Rows.Add(CbFormaPago.Text, TxtImporte.Text, "0", "0", "0", "0", "0", TxtImporte.Text);
                }
                totalesdgmultipago();
                inicializarcontroles();
                TxtImporte.Focus();
            }
            catch (Exception ex)
            {

                UtilityFrm.mensajeError("");
            }
        }
        private void inicializarcontroles()
        {
            TxtLote2.Text = "0";
            Txtcupon2.Text = "0";
            Txtcuota.Text = "0,00";
            TxtImporte.Text = "0";
        }
        private void totalesdgmultipago()
        {
            decimal importe = 0;
            decimal total = 0;
            decimal totalsininteres = 0;
            decimal importesininteres = 0;
            decimal porcentaje = 0;
            decimal saldo = 0;

            if (DGMultiPago.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in DGMultiPago.Rows)
                {

                    importesininteres = Convert.ToDecimal(row.Cells["Importesininteres"].Value);
                    importe = Convert.ToDecimal(row.Cells["Importe"].Value);
                    //totalsininteres = Convert.ToDecimal(row.Cells["Importesininteres"].Value);
                    total = total + importe;
                    totalsininteres = totalsininteres + importesininteres;

                }
            }
            saldo = totalAPagar - totalsininteres;
            txtTotalAPagar.Text = total.ToString();
            TxtSaldo.Text = saldo.ToString();
            lblsubtotal.Text = total.ToString();

        }

        private void CalcularCuota()
        {
            decimal porcentaje = 0;
            decimal importe = 0;
            decimal importecuota = 0;

            porcentaje = Convert.ToDecimal(cbMCuota.SelectedValue);
            importe = Convert.ToDecimal(TxtImporte.Text);

            if (porcentaje != 0)
            {
                importe = importe + ((importe * porcentaje) / 100);
            }

            importecuota = importe / Convert.ToDecimal(cbMCuota.Text);
            Txtcuota.Text = importecuota.ToString();
        }
        private void TxtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilityFrm.NumDecTeclado(e, TxtImporte);
        }

        private void CbFormaPago_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtImporte.Focus();
                TxtImporte.SelectAll();
            }
        }

        private void CbFormaPago_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (CbFormaPago.Text == "TARJETA")
            {
                cbMCuota.Enabled = true;
                cbTarjeta.Enabled = true;
                txtCupon.Enabled = true;
                txtLote.Enabled = true;
                Txtcuota.Enabled = true;
                Txtcupon2.Enabled = true;
                TxtLote2.Enabled = true;

            }
            else
            {
                cbMCuota.Enabled = false;
                cbTarjeta.Enabled = false;
                txtCupon.Enabled = false;
                txtLote.Enabled = false;
                Txtcuota.Enabled = false;
                Txtcupon2.Enabled = false;
                TxtLote2.Enabled = false;
            }
        }

        private void DGMultiPago_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != DGMultiPago.Columns["Eliminar"].Index)
            {
                return;
            }
            else
            {
                DGMultiPago.Rows.RemoveAt(e.RowIndex);
                totalesdgmultipago();
            }
        }
    }
}
