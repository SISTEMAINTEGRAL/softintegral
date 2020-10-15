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
using System.Diagnostics;
using System.Threading;
using CrystalDecisions.Shared;





namespace Capa_Presentacion
{
    public partial class frmPventa : Form
    {
        
        public NegocioArticulo objnart = new NegocioArticulo();
        private int pesable;
        private long codigoprod;
        private string preciocantidad;
        private string cuit;
        private string riva;
        private string domicilio;
        private bool mouse = false;
        private string formadepago;
        private decimal precio;
        private bool datagriddobleclic = false; // si se hace doble clic te modifica si no lo agrega  
        private string buffer;
        private bool txtnombre_enter = false;
        private bool encontrado = false;
       // public event EventHandler GotFocus;
        NegocioUsuario objusuario = new NegocioUsuario();

        private const int datagridprecio = 4;
        private const int datagridcantidad = 5;
        private const int datagridsubtotal = 6;
        private const int datagriddescuento = 7;
        private const int datagridimporte = 8;
        public string Riva
            
        {
            get { return riva; }
            set { riva = value; }
        }
        
       

        private void frmPventa_Load(object sender, EventArgs e)
        {
            try
            {
               
                lblcant.Enabled = chkporcantidad.Checked;
                txtcant.Enabled = chkporcantidad.Checked;
                cbTipoComprobante.Items.Add("PRESUPUESTO");
                cbTipoComprobante.Items.Add("NOTA DE VENTA");
                cbTipoComprobante.SelectedIndex = 1;
                llenarcomboboxtarjeta();

                if (NegocioConfigEmpresa.confsistema ("pendientestock").ToString () == "True")
                {
                    CHKPendientestock.Visible = true;

                }
                else
                {
                    CHKPendientestock.Visible = false;
                }

                //if (NegocioConfigEmpresa.confsistema("facturar").ToString() == "True")
                //{

                //    cbTipoComprobante.Items.Add("FACTURA");
                //    cbTipoComprobante.Text = "FACTURA";
                //}

                if (NegocioConfigEmpresa.emciva == "MN")
                {
                    cbxCategoria.Items.Add("C");
                    cbxCategoria.Items.Add("X");
                    cbxCategoria.Text = "C";
                }
                if (NegocioConfigEmpresa.emciva == "RI")
                {
                    cbxCategoria.Items.Add("A");
                    cbxCategoria.Items.Add("B");
                    cbxCategoria.Items.Add("X");
                    cbxCategoria.Text = "B";
                }


               // this.DGVenta.Columns["Precio"].DefaultCellStyle.Format = String.Format("$###,##0.00");
                DGVenta.Columns["Importe"].DefaultCellStyle.Format = String.Format("$###,##0.00");
                Lblvendedor.Text = NegocioConfigEmpresa.nombreusuario;
                DGVenta.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
               
                
                
            }
            catch (Exception s)
            {

                {
                    // Qué ha sucedido
                    var mensaje = "Error message: " + s.Message;

                    // Información sobre la excepción interna
                    if (s.InnerException != null)
                    {
                        mensaje = mensaje + " Inner exception: " + s.InnerException.Message;
                    }

                    // Dónde ha sucedido
                    mensaje = mensaje + " Stack trace: " + s.StackTrace;
                    UtilityFrm.Log oLog = new UtilityFrm.Log();
                    oLog.Add(mensaje);
                    UtilityFrm.mensajeError(mensaje);
                }

            }


        }
        public frmPventa()
        {
            InitializeComponent();
            txtIdCliente.Focus();
           // DGVenta.Columns[2].DefaultCellStyle.Format = String.Format("$###,##0.00");
           // DGVenta.Columns[4].DefaultCellStyle.Format = String.Format("$###,##0.00");
           // DGVenta.Columns["Importe"].DefaultCellStyle.Format = String.Format("$###,##0.00");
        }

      
          public void Buscar_Cliente(int codCliente)
          {
            try
            {
                if (codCliente > 0)
                {
                    DataTable dt;
                    dt = NegocioCliente.buscarCodigoCliente(codCliente.ToString());
                                        
                     
                    if (dt.Rows.Count != 0)
                    {
                        DataRow row = dt.Rows[0];
                        string cliente = row["razon_social"].ToString();
                        cuit = row["cuit"].ToString();
                        riva = row["responsabilidadiva"].ToString();
                        domicilio =     row["direccion"].ToString();
                       
                        // UtilityFrm.mensajeConfirm("Se encontro el Cliente " + cliente);
                        txtRazonSocial.Text = cliente;
                        cbTipoComprobante.SelectedIndex = 1;
                        if (NegocioConfigEmpresa.emciva == "MN")
                        {
                            cbxCategoria.SelectedIndex = 0;
                        }
                        else
                        {
                            cbxCategoria.SelectedIndex = 1;
                        }
                            

                        if (row["idcliente"].ToString() == "1")
                        {
                            //si es consumidor final nota de ventas
                            // cbTipoComprobante.SelectedIndex = 1;
                            //cbxCategoria.SelectedIndex = 2;

                            btnAgregarPesable.Enabled = true;
                            txtNombreProducto.Enabled = true;
                            txtNombreProducto.Focus();
                        }

                    }
                    else
                    {
                        UtilityFrm.mensajeError("Error No se ha encontrado el Cliente");
                        clienteIncorrecto();
                        btnCliente.Focus();
                    }

                }
                else
                {
                    UtilityFrm.mensajeError("Error No se ha encontrado el Cliente");
                    clienteIncorrecto();
                    btnCliente.Focus();

                }
            }
            catch (Exception ex)
            {

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

          }
          public void agregar_producto(int codproducto, decimal  precioProducto,decimal  descuentoProducto)
          {
              try
              {
                  int cantidadProducto = 1;
                  objnart.extraerdatos(codproducto, "poridarticulo");

                 
                  decimal totalPagar = Convert.ToDecimal(txtTotalPagar.Text);
                  totalPagar = (cantidadProducto * precioProducto) + (totalPagar);
                  agregardatagridview(objnart.IdArticulo.ToString(), objnart.Nombre.ToString(), objnart.Precio.ToString(),"1", objnart.Precio.ToString(),
                  cantidadProducto.ToString(), objnart.Precio.ToString(), "0", objnart.Precio.ToString(), "0", "Cantidad", objnart.Preciopormayor.ToString(),
                  objnart.Cantidadpormayor.ToString(), objnart.Precio.ToString(),objnart.Iva.ToString("0,00"),"",objnart.Preciopormayor2.ToString(),
                  objnart.Cantidadpormayor2.ToString(),objnart.Precio_oferta.ToString(),objnart.Nombrecategoria.ToString(),objnart.StockActual.ToString(),
                  objnart.Stock_minimo.ToString(), "","");
                  //DGVenta.Rows.Add(objnart.IdArticulo, objnart.Nombre, objnart.Precio, "0", cantidadProducto.ToString(),objnart.Preciopormayor,objnart.Cantidadpormayor);

                  txtTotalPagar.Text = totalPagar.ToString();
                  txtNombreProducto.Text = "";
                  txtNombreProducto.Focus();
              }
              catch (Exception ex)
              {

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


        }
        public void agregardatagridview(string grididarticulo, string gridnombre,string gridpreciobase,string gridlista, string gridprecio, string gridcantidad, string gridsubtotal, string griddescuento,
                                        string gridimporte, string gridpesable, string gridcalculo, string gridpreciomayorista, string gridcantidadmayorista, 
                                        string preciounidad, string iva, string manual, string gridpreciomayorista2, string gridcantidadmayorista2, 
                                        string gridpreciooferta, string gridcategoria,string gridstockactual,string gridstockminimo, string gridpopupminimo, string gridpopupcero)
        {
            DGVenta.Rows.Add(grididarticulo, gridnombre +" "+ gridcategoria,gridpreciobase,gridlista,gridprecio, gridcantidad, gridsubtotal, griddescuento,
                             gridimporte, gridpesable, gridcalculo, gridpreciomayorista, gridcantidadmayorista,preciounidad,iva,manual,
                             gridpreciomayorista2,gridcantidadmayorista2,gridpreciooferta, gridstockactual, gridstockminimo, gridpopupminimo, gridpopupcero);
        }
          public int  Buscar_producto(long codproducto, string tipo, bool agregardatagrid, decimal cantidad = 1, string codbarra = "")
          {
            decimal subtotal = 0;
            decimal precio = 0;
            decimal descuento = 0;
            decimal importe = 0;
            decimal total = 0;
            decimal cantidadActual = 0;
            decimal cantidadbulto = 0;
            int indice = -1;
            int cont = -1;
            string  manual = "";
            decimal preciobase = 0;
            int lista = 0;
            bool preciobalanza = false;
            string calculo = "cantidad"; 

            try
              {


                if (tipo == "porbarra" && codbarra.Length > 12)
                {
                    if (codbarra.ToString().Substring(0, 2) == "20" || codbarra.ToString().Substring(0, 2) == "30" || codbarra.ToString().Substring(0, 2) == "02")
                    {
                        preciobalanza = true;
                        manual = "manual";
                        subtotal = Convert.ToDecimal(pluyprecio(codbarra, "precio",NegocioConfigEmpresa.confsistema("formato balanza").ToString()));
                        codbarra = pluyprecio(codbarra, "plu", NegocioConfigEmpresa.confsistema("formato balanza").ToString());
                       
                    }
                }
                

                     
                    objnart.extraerdatos(codproducto, tipo, codbarra);

                 

                if (objnart.Sindatos == false && preciobalanza == true)
                {
                    codbarra = txtNombreProducto.Text;
                    subtotal = Convert.ToDecimal(pluyprecio(codbarra, "precio"));
                    codbarra = pluyprecio(codbarra, "plu");
                    objnart.extraerdatos(codproducto, tipo, codbarra);
                }
 



                if (tipo == "porbarra")
                {
                    codproducto =  objnart.IdArticulo;
                }
                    if (objnart.Sindatos == false && tipo == "porbarra")
                    {
                        objnart.extraerdatos(codproducto,"porbulto", codbarra);
                        cantidadbulto = objnart.Bulto_cantidad;
                    }

                            
                
                      if (objnart.Sindatos == true)
                      {
                            if (NegocioConfigEmpresa.balanzapuerto != "" && CHKHabilitarbalanza.Checked && preciobalanza == false)
                            {
                                if (objnart.Pesable == 1)
                                {

                                    cantidad = comunicarytraerkilosbalanza();


                                }
                            }

                            if (preciobalanza == true)
                                    {
                                if (objnart.Precio != 0)
                                {
                                    cantidad = Decimal.Round((subtotal / objnart.Precio), 2);
                                    precio = subtotal;
                                }
                                       

                            }
                                    pesable = objnart.Pesable;
                                    encontrado = false;

                   
                            if (!recorrerDGventaencontraridarticulo(codproducto, ref indice, precio, descuento, cantidadActual, cantidadbulto, cantidad, importe,preciobalanza,subtotal) )
                            {
                                //si no se encuentra cantidad 
                                preciobase = decimal.Round(objnart.Precio, 2);
                        
                                precio = decimal.Round(objnart.Precio, 2);
                                        
                                precio = cambiarpreciosegunlista(ref lista, ref manual, RBPrecioNormal.Checked,
                                RBPreciomayorista1.Checked, RBPreciomayorista2.Checked, RBPrecioOferta.Checked,
                                objnart.Fechadeoferta, objnart.Precio_oferta, objnart.Preciopormayor, objnart.Preciopormayor2);
                                precio = precio == 0 ? preciobase : precio;
                        
                                if (preciobalanza == true)
                                {
                                    if (objnart.Precio != 0)
                                    {
                                        cantidad = Decimal.Round((subtotal / precio), 2);
                                    }
                           
                            
                                    calculo = "subtotal";
                                }
                        
                                    
                                   
                                              
                                    //no calculo el precio por la cantidad porque da el mismo numero
                                    agregardatagridview(objnart.IdArticulo.ToString(), objnart.Nombre, preciobase.ToString(), lista.ToString(),
                                        precio.ToString(), cantidad.ToString(),subtotal.ToString(), "0", objnart.Precio.ToString(), pesable.ToString(),
                                        calculo, objnart.Preciopormayor.ToString(), objnart.Cantidadpormayor.ToString(),
                                        objnart.Precio.ToString(), objnart.Iva.ToString(), manual, objnart.Cantidadpormayor2.ToString(),
                                        objnart.Preciopormayor2.ToString(), objnart.Precio_oferta.ToString(),objnart.Nombrecategoria.ToString(),
                                        objnart.StockActual.ToString(),objnart.Stock_minimo.ToString(),"","");
                                    //DGVenta.Rows.Add(objnart.IdArticulo, objnart.Nombre, cantidad, precio, "0", "0",pesable,"cantidad",objnart.Preciopormayor,objnart.Cantidadpormayor); 


                            }

                                  totales();
                         

                      }
                      else
                      {
                          FrmMensajeAutoCierre.Show("No es una clave valida", "Error", 1000);
                          txtNombreProducto.SelectAll();
                    
                      }

                       txtcant.SelectAll(); txtcant.Focus(); 
              }
              catch (Exception ex)
              {

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
            return indice;
          }
       
        private string pluyprecio(string codigoproducto, string traerpluoprecio, string formatobalanza = "")
        {
            string pluoprecio = "";
            try
            {
                
                if (traerpluoprecio == "plu")
                {
                    if (formatobalanza == "246")
                    {
                        pluoprecio = "0" + codigoproducto.ToString().Substring(2, 4);
                    }
                    else
                    {
                        pluoprecio = codigoproducto.ToString().Substring(2, 5);
                    }
                }
                else if (traerpluoprecio == "precio")
                {
                    int posicion = codigoproducto.Length;
                    string entero = "";
                    string flotante = "";
                    if (formatobalanza == "246")
                    {
                        entero = codigoproducto.Substring(6, 4);
                        flotante = codigoproducto.Substring(10, 2);
                    }
                    else
                    {
                        entero = codigoproducto.Substring(7, 3);
                        flotante = codigoproducto.Substring(10, 2);
                    }

                    pluoprecio = entero + "," + flotante;
                }


                
            }
            catch (Exception ex)
            {

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
            return pluoprecio;
        }
       
        private decimal comunicarytraerkilosbalanza()
        {
            decimal cantidad = 0;
            FrmAsignarPrecio objasignar = new FrmAsignarPrecio();
            try
            {
                
                objasignar.ShowDialog();
                if (!objasignar.IsCerro)
                {
                    cantidad = objasignar.PrecioTotal;
                    if (objasignar.Tara != 0)
                    {
                        cantidad = objasignar.PrecioTotal - objasignar.Tara;
                    }
                }
               
            }
            catch (Exception ex)
            {

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
            return cantidad;
        }
        private decimal cambiarpreciosegunlista(ref int lista,ref string manual, bool preciounitario, bool preciomayorista1
            , bool preciomayorista2, bool preciooferta, DateTime fechadeoferta, decimal valorpreciooferta
            , decimal valorpreciopormayor, decimal valorpreciopormayor2)
        {
            decimal precio = 0;
            try
            {
                

                if (preciounitario == true)
                {
                    if (objnart.Habilitarfechaoferta == true && objnart.Fechadeoferta >= DateTime.Now && objnart.Precio_oferta != 0)
                    {
                        lista = 4;
                        precio = decimal.Round(objnart.Precio_oferta, 2);
                        manual = "Manual";
                    }
                }

                if (RBPreciomayorista1.Checked == true)
                {
                    lista = 1;
                    precio = decimal.Round(objnart.Preciopormayor, 2);
                    manual = "Manual";
                }
                if (RBPreciomayorista2.Checked == true)
                {
                    lista = 2;
                    manual = "Manual";
                    precio = decimal.Round(objnart.Preciopormayor2, 2);
                }
                if (RBPrecioOferta.Checked == true)
                {
                    lista = 3;
                    manual = "Manual";
                    precio = decimal.Round(objnart.Precio_oferta, 2);
                }


                
            }
            catch (Exception ex)
            {

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
            return precio;
        }
        private bool recorrerDGventaencontraridarticulo(long idarticulo,ref int index, decimal precio, decimal descuento, decimal cantidadActual, decimal cantidadbulto, decimal cantidad, decimal importe, bool preciobalanza = false, decimal subtotal = 0)
        {
             encontrado = false;
            int cont = -1;
            try
            {
                foreach (DataGridViewRow row in DGVenta.Rows)
                {
                    cont++;
                    if (Convert.ToInt32(row.Cells["Codigo"].Value) == idarticulo)
                    {

                        encontrado = true;
                       
                        
                        descuento = Convert.ToDecimal(row.Cells["Descuento"].Value);
                        cantidadActual = cantidadbulto > 0 ? cantidadbulto : (Convert.ToDecimal(row.Cells["Cantidad"].Value));

                        //incremento la cantidad del producto agregado
                                         

                        if (chkporcantidad.Checked == false)
                        {
                            cantidadActual += cantidad;
                        }

                        row.Cells["Cantidad"].Value = cantidadActual;
                        //calculo el precio con descuento incluido * la cantidad de articulos agregados
                        if (preciobalanza == true)
                        {
                            subtotal = precio + Convert.ToDecimal(row.Cells["subtotal"].Value);
                        }
                        else
                        {
                            precio = Convert.ToDecimal(row.Cells["Cprecio"].Value);
                            subtotal = precio * cantidadActual;
                        }
                        

                        importe = subtotal - ((subtotal * descuento) / 100);
                        row.Cells["subtotal"].Value = decimal.Round(subtotal, 2);
                        row.Cells["Importe"].Value = importe;


                        index = cont;

                    }
                }

                
            }
            catch (Exception ex)
            {

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
            return encontrado;
        }
        private string cambiarpreciosegunlista(int numerolista)
        {
            string valor = "";
            DataGridViewRow fila = DGVenta.CurrentRow;

            try
            {

                if (DGVenta.Rows.Count != 0)
                {
                    switch (numerolista)
                    {
                        case 1:
                            {
                                valor = "0";
                                DGVenta.CurrentRow.Cells["Cprecio"].Value = fila.Cells["P_Unidad"].Value.ToString();
                                DGVenta.CurrentRow.Cells["manual"].Value = "Manual";
                                break;
                            }
                        case 2:
                            {
                                valor = "1";
                                DGVenta.CurrentRow.Cells["Cprecio"].Value = fila.Cells["Preciopormayor"].Value.ToString();
                                DGVenta.CurrentRow.Cells["manual"].Value = "Manual";
                                break;
                            }
                        case 3:
                            {
                                valor = "2";
                                DGVenta.CurrentRow.Cells["Cprecio"].Value = fila.Cells["Precio2"].Value.ToString();
                                DGVenta.CurrentRow.Cells["manual"].Value = "Manual";
                                break;
                            }
                        case 4:
                            {
                                valor = "3";
                                DGVenta.CurrentRow.Cells["Cprecio"].Value = fila.Cells["Precio_Oferta"].Value.ToString();
                                DGVenta.CurrentRow.Cells["manual"].Value = "Manual";
                                break;

                            }
                        default:
                            break;
                    }

                

                }


                return valor;
            }
            catch (Exception ex)
            {

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
            return valor;
        }

          private void totales()
          {

              try
              {
                  decimal precio = 0;
                  decimal descuento = 0;
                  decimal cantidadActual = 0;
                  decimal importe = 0;
                  decimal cantidad = 0;
                  decimal total = 0;
                  decimal total21 = 0;
                  decimal total105 = 0;
                  decimal neto21 = 0;
                  decimal iva21 = 0;
                  decimal neto105 = 0;
                  decimal iva105 = 0;
                  decimal porcentaje = 0;
                  decimal cuota = 0;
                  decimal subtotal = 0;
                  decimal preciopormayor = 0;
                  decimal cantidadpormayor = 0;
                  decimal preciounidad = 0;
                  decimal cantidadprecio2 = 0;
                  decimal precio2 = 0;
                  decimal stock_minimo = 0;
                  decimal stock_actual = 0;
                  
                  if (DGVenta.RowCount != 0)
                  {
                      foreach (DataGridViewRow row in DGVenta.Rows)
                      {

                         
                            subtotal = Decimal.Round (  Convert.ToDecimal(row.Cells["subtotal"].Value) ,2);
                            cantidadpormayor = Decimal.Round(Convert.ToDecimal(row.Cells["cantidadpormayor"].Value), 2);
                            preciopormayor= Decimal.Round(Convert.ToDecimal(row.Cells["preciopormayor"].Value), 2);
                          

                        precio = Decimal.Round ( Convert.ToDecimal(row.Cells["Cprecio"].Value),2);
                            descuento = Convert.ToDecimal(row.Cells["Descuento"].Value);
                            cantidadActual = Decimal.Round((Convert.ToDecimal(row.Cells["Cantidad"].Value)), 2);
                            preciounidad = Decimal.Round((Convert.ToDecimal(row.Cells["preciounidad"].Value)), 2);
                            cantidadprecio2= Decimal.Round((Convert.ToDecimal(row.Cells["preciocantidad2"].Value)), 2);
                            precio2 = Decimal.Round((Convert.ToDecimal(row.Cells["precio2"].Value)), 2);
                            stock_minimo = Decimal.Round((Convert.ToDecimal(row.Cells["stock_minimo"].Value)), 2);
                            stock_actual = Decimal.Round((Convert.ToDecimal(row.Cells["stock_actual"].Value)), 2);

                        int kia = row.Index;

                        decimal res = stock_actual - cantidadActual;

                        if (res <= 0 )
                        {
                            DGVenta.Rows[row.Index].DefaultCellStyle.BackColor = Color.FromArgb(183, 95, 77);
                            DGVenta.Rows[row.Index].DefaultCellStyle.ForeColor = Color.White;
                            if (row.Cells["popupcero"].Value == "")
                            {
                                UtilityFrm.notificacionpopup("ATENCION!", "ID = " + row.Cells["Codigo"].Value.ToString() + " SE ENCUENTRA EN CERO TU STOCK ACTUAL ES DE " + stock_actual, "peligro");
                            }
                            
                            row.Cells["popupcero"].Value = "notificacion";

                        }
                        else 
                        {
                            DGVenta.Rows[row.Index].DefaultCellStyle.BackColor = Color.White;
                            DGVenta.Rows[row.Index].DefaultCellStyle.ForeColor = Color.Black;
                            row.Cells["popupcero"].Value = "";
                        }

                        if (stock_minimo != 0 && row.Cells["popupcero"].Value == "")
                        {
                            if (res < stock_minimo)
                            {
                                DGVenta.Rows[row.Index].DefaultCellStyle.BackColor = Color.FromArgb(188, 162, 73);
                                DGVenta.Rows[row.Index].DefaultCellStyle.ForeColor = Color.White;
                                if (row.Cells["popupminimo"].Value == "")
                                {
                                    UtilityFrm.notificacionpopup("ATENCION!", "ID = " + row.Cells["Codigo"].Value.ToString() + " SE ENCUENTRA POR DEBAJO DEL STOCK MINIMO TU STOCK DISPONIBLE ES DE " + stock_actual, "precaucion");
                                }
                              
                                row.Cells["popupminimo"].Value = "notificacion";
                            }
                            else  
                            {
                                DGVenta.Rows[row.Index].DefaultCellStyle.BackColor = Color.White;
                                DGVenta.Rows[row.Index].DefaultCellStyle.ForeColor = Color.Black;
                                row.Cells["popupminimo"].Value = "";
                            }

                        }
                       






                        if (cantidadpormayor != 0 && row.Cells["Manual"].Value == "")
                        {
                            precio = cantidadActual >= cantidadpormayor ? preciopormayor : preciounidad;

                            

                        }

                        if (precio2 > 0 && cantidadprecio2 != 0 && row.Cells["Manual"].Value == "")
                        {
                            precio = cantidadActual >= cantidadprecio2 ? precio2 : precio;
                        }


                        row.Cells["Cprecio"].Value = precio;
                        if (rTarjeta.Checked == true)
                          {
                              porcentaje = Convert.ToDecimal(cbMCuota.SelectedValue);
                              
                              row.Cells["Descuento"].Value = 0;
                          }
                         

                          

                          //incremento la cantidad del producto agregado
                          cantidadActual += cantidad;
                          
                          //calculo el precio con descuento incluido * la cantidad de articulos agregados
                          if (row.Cells["Calculo"].Value == "cantidad" || row.Cells["Calculo"].Value == "")
                          {
                              importe = Decimal.Round(precio * cantidadActual, 2);
                          }
                          else
                          {
                             cantidadActual = Decimal.Round(Convert.ToDecimal(row.Cells["subtotal"].Value) / Convert.ToDecimal(row.Cells["Cprecio"].Value), 2);
                             importe = Convert.ToDecimal(row.Cells["subtotal"].Value);

                          }

                        row.Cells["Cantidad"].Value = cantidadActual;

                        row.Cells["subtotal"].Value = importe;
                          if (porcentaje != 0)
                          {
                              importe = importe + ((importe * porcentaje) / 100);
                          }
                          importe = importe - ((importe * descuento) / 100);

                          row.Cells["Importe"].Value = importe;

                        if (row.Cells["Civa"].Value.ToString() == "10,5000")
                        {
                            total105 = total105 + importe;
                        }
                       else
                        {
                            total21 = total21 + importe;
                        }

                        // }

                    }

                      foreach (DataGridViewRow row in DGVenta.Rows)
                      {
                          total = total + Convert.ToDecimal(row.Cells["importe"].Value);

                          decimal.Round(total, 2);

                      }

                      neto21 = Decimal.Round ( total21 / Convert.ToDecimal(1.21),2);
                      iva21 = total21 - neto21;

                      neto105 = Decimal.Round(total105 / Convert.ToDecimal(1.105), 2);
                      iva105 = total105 - neto105;

                    if (rTarjeta.Checked == true && total != 0 && cbMCuota.Text != "")
                      {
                          cuota = total / Convert.ToDecimal(cbMCuota.Text);
                      }
                      else
                      {
                          Txtcuota.Text = txtTotalPagar.Text;
                      }
                      txtIVA.Text = iva21.ToString("0.00");
                      txtNeto.Text = neto21.ToString("0.00");
                      txtIva105.Text = iva105.ToString("0.00");
                      txtNeto105.Text = neto105.ToString("0.00");
                      txtTotalPagar.Text = total.ToString("0.00");
                      Txtcuota.Text = cuota.ToString("0.00");
                      txtItems.Text =  DGVenta.RowCount.ToString();
                      txtNombreProducto.Text = "";
                  }

                  
              }
              catch (Exception ex)
              {

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


        }

        private bool stockcero()
        {
            bool stockbajocero = false;

            foreach (DataGridViewRow row in DGVenta.Rows)
            {

                decimal res = Convert.ToDecimal( row.Cells["stock_actual"].Value) - Convert.ToDecimal(row.Cells["cantidad"].Value) ;

                if (res <= 0 )
                {
                    stockbajocero = true;
                    return stockbajocero;
                }
                }

                return stockbajocero;
        }
        private void OnTimer(object state)
        {
            MessageBox.Show("Se ejecuto el evento");
        }
        public bool IsNumeric(string input)
        {
            long test;

            return long.TryParse(input, out test);
        }
     

        private void btnCliente_Click(object sender, EventArgs e)
        {
            
         
            
            FrmBusquedaAvaCliente cliente = new FrmBusquedaAvaCliente();
            
            cliente.ShowDialog();
            //si el usuario cierra la ventana isCerro es true, sino si selecciono algun articulo isCerro
            try
            {
                if (cliente.IsCerro)
                {
                    clienteIncorrecto();
                    txtIdCliente.Focus();
                   
                }
                else
                {

                    txtIdCliente.Text = cliente.IdCliente.ToString();
                    txtRazonSocial.Text = cliente.RazonSocial.ToString();
                    cuit = cliente.Cuit.ToString();
                    riva = cliente.Riva.ToString();
                    domicilio = cliente.Domicilio.ToString();
                    

                   if(txtIdCliente.Text=="1"){

                       cbTipoComprobante.SelectedIndex = 1;
                       cbxCategoria.SelectedIndex = 2;
                      
                   }
                   txtNombreProducto.Focus();
                }
                
            }
            catch (Exception ex)
            {

                UtilityFrm.mensajeError("Error al seleccionar un cliente. Causa:" + ex.Message+"cadena:"+ex.StackTrace);
                UtilityFrm.Log oLog = new UtilityFrm.Log();
                oLog.Add(ex.Message + ex.StackTrace);
                UtilityFrm.limpiarTextbox(txtIdCliente,txtRazonSocial);

                btnCliente.Focus();
            }
        }

        private void txtIdCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Buscar_Cliente(Convert.ToInt32(txtIdCliente.Text));
                   
                }
                catch (Exception ex)
                {
                    UtilityFrm.mensajeError("Error al seleccionar un cliente. Causa:" + ex.Message + "cadena:" + ex.StackTrace);
                    UtilityFrm.Log oLog = new UtilityFrm.Log();
                    oLog.Add(ex.Message + ex.StackTrace);
                    clienteIncorrecto();
                    btnCliente.Focus();
                    
                }


            }
            if (e.KeyCode == Keys.Down && DGCliente.Visible == true)
            {
                DGCliente.Focus();
            }

            if (e.KeyCode == Keys.Down && dataGridView1.Visible == true)
            {
                //si se preciona la tecla hacia abajo se pasa el foco a la grilla

                DGCliente.Focus();

            }

        }

        public void clienteIncorrecto(){
            //cuando el cliente no es encontrado o ingreso incorrecto de los datos
            UtilityFrm.limpiarTextbox(txtRazonSocial,txtIdCliente);
            //deselecciona el combobox de tipo comprobante
            //cbTipoComprobante.SelectedIndex = -1;
          
            btnAgregarPesable.Enabled = false;
            btnProducto.Enabled = false;
            txtNombreProducto.Enabled = false;
            cbTipoComprobante.Enabled = false;
            cbxCategoria.Enabled = false;
           

        }
        private void frmPventa_KeyDown(object sender, KeyEventArgs e)
        {

            try
            {
                if (e.KeyCode == Keys.F1)
                {
                    try
                    {
                        Buscar_Cliente(1);
                        //consumidor final es 1
                        txtIdCliente.Text = "1";
                        cbxCategoria.Text = "X";


                    }




                    catch (Exception ex)
                    {
                        UtilityFrm.mensajeError("Error al seleccionar un cliente. Causa:" + ex.Message + ex.StackTrace);
                        UtilityFrm.Log oLog = new UtilityFrm.Log();
                        oLog.Add(ex.Message + ex.StackTrace);
                        clienteIncorrecto();
                        btnCliente.Focus();

                    }

                }
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Control) + Convert.ToInt32(Keys.F1))
                {
                    Buscar_Cliente(1);
                    //consumidor final es 1
                    txtIdCliente.Text = "1";
                    cbxCategoria.Focus();
                }
                if (Convert.ToInt32(e.KeyData) == Convert.ToInt32(Keys.Shift) + Convert.ToInt32(Keys.F1))
                {
                    btnCliente_Click(sender, e);
                }

                else if (e.KeyCode == Keys.F2)
                {
                    //guarda la venta
                    btnGuardar.PerformClick();

                }
                else if (e.KeyCode == Keys.F3)
                {
                    rContado.Checked = true;

                }
                else if (e.KeyCode == Keys.F4)
                {
                    rctacte.Checked = true;
                }

                else if (e.KeyCode == Keys.F5)
                {
                    rTarjeta.Checked = true;
                    cbTarjeta.Focus();

                }
                else if (e.KeyCode == Keys.F6)
                {
                    RBPrecioNormal.Checked = true;
                    // btnAgregarPesable.PerformClick();
                }
                else if (e.KeyCode == Keys.F7)
                {
                    RBPreciomayorista1.Checked = true;
                }
                else if (e.KeyCode == Keys.F8)
                {
                    RBPreciomayorista2.Checked = true;
                }
                else if (e.KeyCode == Keys.F9)
                {
                    RBPrecioOferta.Checked = true;
                }
                else if (e.KeyCode == Keys.F11)
                {
                    if (CHKHabilitarbalanza.Checked == true)
                    { CHKHabilitarbalanza.Checked = false; }
                    else
                    { CHKHabilitarbalanza.Checked = true; }
                }
                else if (e.KeyCode == Keys.F12)
                {
                    //CONSULTA DE PRECIO
                    btnConsultas.PerformClick();
                }
                else if (e.KeyCode == Keys.Delete)
                {
                    quitarProducto();



                }

                else if (e.KeyCode == Keys.F10)
                {
                    if (chkporcantidad.Checked == true)
                    { chkporcantidad.Checked = false; }
                    else
                    { chkporcantidad.Checked = true; }

                }
                else if (e.KeyCode == Convert.ToInt32(Keys.Control) + Keys.F10)
                {
                    if (CHKHabilitarbalanza.Checked == true)
                    { CHKHabilitarbalanza.Checked = false; }
                    else
                    { CHKHabilitarbalanza.Checked = true; }

                }

                else if (e.KeyCode == Keys.Escape)
                {

                    if (MessageBox.Show("Está seguro de cerrar la ventana de ventas?", "Cerrar"
                           , MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                    {

                        this.Close();
                    }


                }
                else if (e.KeyCode == Keys.Down && txtNombreProducto.Focused == true && dataGridView1.Visible == false)
                {
                    //si se presiona el boton down y se encuentre el foco en la caja de texto de nombre de producto
                    //y la grilla de busqueda no está visible

                    //el foco se pasa a la grilla
                    if (DGVenta.Rows.Count > 0)
                    {
                        //y existen elementos en la grilla
                        DGVenta.Focus();
                    }



                }
            }
            catch (Exception ex)
            {

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

        }

        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool pendientedestock = false;
            string nombretarjeta = "";
            decimal importecuota = 0;
            int cuota = 0;
            Negociocaja objcaja = new Negociocaja();

            try
            {

                if (rTarjeta.Checked == true)
                {
                    nombretarjeta = cbTarjeta.Text;
                    importecuota = Convert.ToDecimal(Txtcuota.Text);
                    cuota = Convert.ToInt32(cbMCuota.Text);
                }


                if (cbTipoComprobante.Text == "" || cbxCategoria.Text == "")
                {
                    cbTipoComprobante.SelectedIndex = 1;
                    cbxCategoria.SelectedIndex = 1;
                }

                string mensaje = "";

                if (NegocioConfigEmpresa.confsistema("factura") == "True")
                {
                    if (aptofacturacion(cbxCategoria.Text, riva) != "ok")
                    {
                        UtilityFrm.mensajeError(aptofacturacion(cbxCategoria.Text, riva));
                        return;
                    }
                }


                if (rContado.Checked == true)
                {
                    formadepago = "contado";
                }
                else if (rTarjeta.Checked == true)
                {
                    formadepago = "tarjeta";
                }
                else if (rctacte.Checked == true)
                {
                    formadepago = "ctacte";
                }

                if (CHKPendientestock.Visible == true)
                {

                    pendientedestock = CHKPendientestock.Checked;

                }

                FrmGuardarVenta venta = new FrmGuardarVenta(decimal.Round(Convert.ToDecimal(txtTotalPagar.Text), 2), Convert.ToInt32(txtIdCliente.Text), 
                    decimal.Round(Convert.ToDecimal(txtIVA.Text), 2), decimal.Round(Convert.ToDecimal(txtNeto.Text), 2), formadepago, nombretarjeta, importecuota,
                   cuota, Convert.ToInt32(cbTarjeta.SelectedValue), cuit, txtRazonSocial.Text, cbxCategoria.Text, riva, domicilio,
                   Convert.ToDecimal(txtIva105.Text), Convert.ToDecimal(txtNeto105.Text), pendientedestock);
                venta.ListadoDeProducto = DGVenta;
                venta.Tipo_comprobante = cbTipoComprobante.SelectedItem.ToString();
                venta.Concaja = objcaja.chequeocaja(this.Name, ref mensaje, NegocioConfigEmpresa.nrocaja);

                // if (mensaje != "") { UtilityFrm.mensajeError(mensaje); } 


                if (stockcero() && NegocioConfigEmpresa.confsistema ("stockventa").ToString() == "True" && cbTipoComprobante.Text != "PRESUPUESTO")
                {
                    UtilityFrm.mensajeError("USTED TIENE PRODUCTOS CON BAJO STOCK, CORRIJALO Y VUELVA A INTENTARLO");
                    return;
                }
                venta.ShowDialog();

                if (venta.Trans == "ok")
                {

                    //UtilityFrm.mensajeConfirm("La venta se realizó correctamente");
                    if (cbTipoComprobante.SelectedItem.ToString() == "PRESUPUESTO")
                    {
                        UtilityFrm.notificacionpopup("PRESUPUESTO", "EL PRESUPUESTO SE REALIZO CORRECTAMENTE");
                    }
                    else
                    {
                        UtilityFrm.notificacionpopup("VENTA", "LA VENTA SE REALIZO CORRECTAMENTE");
                    }
                    
                    
                    UtilityFrm.limpiarTextbox(txtNombreProducto);
                    txtTotalPagar.Text = "0,00";
                    txtNeto.Text = "0,00";
                    txtIVA.Text = "0,00";
                    Txtcuota.Text = "0,00";
                    txtIva105.Text = "0,00";
                    txtNeto105.Text = "0,00";
                    txtItems.Text = "0,00";
                    //limpia la grilla de productos
                    DGVenta.Rows.Clear();
                    txtNombreProducto.Enabled = true;
                    //TxtDesc.Enabled = true;
                    //TxtPrecio.Enabled = true;
                    btnProducto.Enabled = true;
                    btnAgregarPesable.Enabled = true;
                    txtNombreProducto.Focus();

                }
                else
                {
                    UtilityFrm.mensajeError("Ha ocurrido un error: " + venta.Trans);
                }
            }
            catch (Exception ex)
            {

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

        }

        private void txtNombreProducto_TextChanged_1(object sender, EventArgs e)
        {

            try
            {
                string plus = "";
                int index = 0;
                if (txtNombreProducto.TextLength >= 2 && IsNumeric(txtNombreProducto.Text) != true)
                {


                    dataGridView1.Visible = true;
                    dataGridView1.DataSource = NegocioArticulo.buscarNombre(txtNombreProducto.Text);

                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].Visible = false;
                    dataGridView1.Columns[2].Width = 350;
                    for (int i = 3; i < 26; i++)
                    {
                        dataGridView1.Columns[i].Visible = false;
                    }
                    dataGridView1.Columns[26].Width = 350;



                }


                else
                {
                    dataGridView1.Visible = false;
                }



            }
            catch (Exception ex)
            {

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


        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Buscar_producto(0, "poridarticulo",!chkporcantidad.Checked);
            }
            catch (Exception ex)
            {

                UtilityFrm.mensajeError("No existe ningun producto para agregar");
           
                
            }
          
        }

        
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            decimal totalPagar=Convert.ToDecimal( txtTotalPagar.Text);
            try
            {
                DataGridViewRow fila = DGVenta.CurrentRow;
                decimal precio = Convert.ToDecimal(fila.Cells["Cprecio"].Value);
                DGVenta.Rows.Remove(fila);
                totalPagar = (totalPagar- precio);
                txtTotalPagar.Text = totalPagar.ToString();

                UtilityFrm.limpiarTextbox(txtNombreProducto);

            }
            catch (Exception ex)
            {
                
                    // Qué ha sucedido
                    var mensaje = "Error al Borrar Fila: " + ex.Message;

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
            //UtilityFrm.limpiarTextbox(txtIngOegr, txtPrecioCompra, txtNombreProducto, txtIdArticulo, txtPrecioVenta);
        }



       

       

        private void txtNombreProducto_KeyDown(object sender, KeyEventArgs e)
        {
            int index = 0;
            DataGridViewRow fila = DGVenta.CurrentRow;
            txtnombre_enter = false;
            try
            {
                if (e.KeyCode == Keys.F3)
                {
                    DGVenta.Focus();
                }

                if (e.KeyCode == Keys.Down && dataGridView1.Visible == true)
                {
                    //si se preciona la tecla hacia abajo se pasa el foco a la grilla

                    dataGridView1.Focus();

                }
                if (e.KeyCode == Keys.F6)
                {
                    if (DGVenta.Rows.Count != 0)
                    {
                        fila.Cells["Lista"].Value = cambiarpreciosegunlista(1);
                        DGVenta.CurrentRow.Cells["manual"].Value = "Manual";
                        DGVenta.Refresh();
                    }
                    
                    RBPrecioNormal.Checked = true;
                   
                    totales();
                }
                if (e.KeyCode == Keys.F7)
                {
                    RBPreciomayorista1.Checked = true;
                    if (DGVenta.Rows.Count != 0)
                    {
                        fila.Cells["Lista"].Value = cambiarpreciosegunlista(2);
                        DGVenta.CurrentRow.Cells["manual"].Value = "Manual";
                        DGVenta.Refresh();
                    }
                    
                   
                    totales();
                }
                if (e.KeyCode == Keys.F8)
                {
                    if (DGVenta.Rows.Count != 0)
                    {
                        fila.Cells["Lista"].Value = cambiarpreciosegunlista(3);
                        DGVenta.CurrentRow.Cells["manual"].Value = "Manual";
                        DGVenta.Refresh();
                    }
                    
                    
                    RBPreciomayorista2.Checked = true;
                   
                    totales();
                }
                if (e.KeyCode == Keys.F9)
                {
                    RBPrecioOferta.Checked = true;
                    if (DGVenta.Rows.Count != 0)
                    {
                        fila.Cells["Lista"].Value = cambiarpreciosegunlista(4);
                        DGVenta.CurrentRow.Cells["manual"].Value = "Manual";
                        DGVenta.Refresh();
                    }
                    
                    
                    totales();
                }

                if (e.KeyCode == Keys.Enter)
                {


                    //se pasa el control permitiendo eliminar el beep
                    e.SuppressKeyPress = true;

                    

                    txtNombreProducto.Text = txtNombreProducto.TextLength == 12 && IsNumeric(txtNombreProducto.Text) == true ? "0" + txtNombreProducto.Text : txtNombreProducto.Text;
                    if (txtNombreProducto.TextLength >= 13 && IsNumeric(txtNombreProducto.Text) == true)
                    {
                        index = Buscar_producto(0, "porbarra", !chkporcantidad.Checked, 1, txtNombreProducto.Text);

                        txtNombreProducto.Focus();

                    }
                    else if (CHKHabilitarbalanza.Checked == true)
                    {
                        if (IsNumeric(txtNombreProducto.Text))
                        {

                            index = Buscar_producto(0, "porbarra", !chkporcantidad.Checked, 1, txtNombreProducto.Text.PadLeft(5, '0'));
                        }
                    }
                    //if (txtNombreProducto.TextLength == 12)
                    //{
                    //    NegocioArticulo.buscarCodigoBarra(txtNombreProducto.Text);
                    //}
                    else if (IsNumeric(txtNombreProducto.Text) == true)
                    {
                        index = Buscar_producto(Convert.ToInt64(txtNombreProducto.Text), "poridarticulo", !chkporcantidad.Checked);

                    }
                    else
                    {
                       
                        if (txtNombreProducto.Text != "" && dataGridView1.Visible == true )
                        {
                            txtnombre_enter = true;
                            dataGridView1.Focus();
                            if (chkporcantidad.Checked == true)
                            {
                                cambiartextbox();
                            }
                            else
                            {
                                txtNombreProducto.Focus();
                            }
                            return;
                            //DialogResult dialogResult = MessageBox.Show("Desea agregar un producto que este fuera del sistema", "", MessageBoxButtons.YesNo);
                            //if (dialogResult == DialogResult.Yes)
                            //{
                            //    agregardatagridview("0", txtNombreProducto.Text, "0,00", "1", "0", "0", "0", "0", "0", "0", "0","0"); 
                            //    //DGVenta.Rows.Add("0", txtNombreProducto.Text, "0,00", "1", "0", "0", "0","0");
                            //}
                            //else if (dialogResult == DialogResult.No)
                            //{
                            //    //do something else
                            //}
                        }
                        else
                        {
                            dataGridView1.Visible = false;
                            return;
                        }


                    }
                    if (index < 0)
                    {
                        if (DGVenta.Rows.Count != 0)
                        {
                            //  habilitarcolumna("cantidad");
                            DGVenta.Rows[DGVenta.Rows.Count - 1].Cells[3 + 2].Selected = true;
                        }

                    }
                    else
                    {
                        //habilitarcolumna("cantidad");
                        DGVenta.Rows[index].Cells[3 + 2].Selected = true;
                    }

                    if (chkporcantidad.Checked == true )
                    {
                        
                            cambiartextbox();
                        
                       
                    }

                    //txtNombreProducto.Focus();


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
        private void cambiartextbox()
        {
            Rectangle rec = DGVenta.GetCellDisplayRectangle(DGVenta.CurrentCell.ColumnIndex, DGVenta.CurrentCell.RowIndex, false);
            DGVenta.Focus();

            try
            {


                if (DGVenta.CurrentCell.ColumnIndex == datagridprecio)
                {
                    preciocantidad = "Cprecio";
                }

                else if (DGVenta.CurrentCell.ColumnIndex == datagridcantidad)
                {
                    preciocantidad = "cantidad";
                }

                else if (DGVenta.CurrentCell.ColumnIndex == datagridsubtotal)
                {
                    preciocantidad = "subtotal";
                }

                else if (DGVenta.CurrentCell.ColumnIndex == datagriddescuento)
                {
                    preciocantidad = "descuento";
                }

                else if (DGVenta.CurrentCell.ColumnIndex == datagridimporte)
                {
                    preciocantidad = "importe";
                }
                TxtcambioDv.Location = new Point(rec.Location.X + DGVenta.Location.X, rec.Location.Y + DGVenta.Location.Y);

                TxtcambioDv.Visible = true;
                TxtcambioDv.Text = DGVenta.CurrentCell.Value.ToString();
                TxtcambioDv.Focus();
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
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                    Buscar_producto(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["idarticulo"].Value), "poridarticulo",!chkporcantidad.Checked);
                    dataGridView1.Visible = false;
                    txtNombreProducto.Focus();
                
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
                

                txtNombreProducto.Focus();
            }
           
        }

     

       

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea cancelar la venta?", "Cancelar"
                   , MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
            {
                cancelarVenta();   
            }
        }
        public void cancelarVenta() {
            UtilityFrm.limpiarTextbox(txtIdCliente,txtNombreProducto,txtRazonSocial);
            

            DGVenta.Rows.Clear();
            txtTotalPagar.Text = "0,00";
            //TxtPrecio.Text = "0,00";
       
            //TxtDesc.Text = "0";
            //TxtDesc.Enabled = false;
            btnGuardar.Enabled = false;
            btnProducto.Enabled = false;
            btnAgregarPesable.Enabled = false;
            btnCancelar.Enabled = false;
            txtIdCliente.Focus();
            txtNombreProducto.Enabled = false;
            cbTipoComprobante.SelectedIndex = -1;
            cbTipoComprobante.Enabled = false;

        }
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            
                try
                {


                    if (e.KeyCode == Keys.Enter)
                    {
                   int index = Buscar_producto(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["idarticulo"].Value), "poridarticulo",!chkporcantidad.Checked);
                    dataGridView1.Visible = false;

                   
                    if (chkporcantidad.Checked == false) { txtNombreProducto.Focus(); };
                    if (index < 0)
                    {
                        DGVenta.Rows[DGVenta.Rows.Count - 1].Cells[3 + 2].Selected = true;
                    }
                    else
                    {
                        DGVenta.Rows[index].Cells[3 + 2].Selected = true;
                    }
                    if (chkporcantidad.Checked == true && (NegocioConfigEmpresa.balanzapuerto == "" || objnart.Pesable == 0) )
                    {
                        cambiartextbox();
                    }
                    else
                    {
                        txtNombreProducto.Focus();
                        txtNombreProducto.SelectAll();
                    }

                       
                    }
                    else if (e.KeyCode == Keys.Up)
                          
                         {
                //pasa de la lista al campo nombreProducto 
                            if(dataGridView1.Rows.Count>0 && dataGridView1.Rows[0].Selected){
                            txtNombreProducto.Focus();
                            txtNombreProducto.SelectAll();
                    
                                }
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
                

                    dataGridView1.Visible = true;
                    txtNombreProducto.Focus();
                }
               
            
            
        }

        private void txtRazonSocial_TextChanged(object sender, EventArgs e)
        {
            if (txtRazonSocial.Text.Count() > 0)
            {
                txtNombreProducto.Enabled = true;
                //TxtDesc.Enabled = true;
                //TxtPrecio.Enabled = true;
                btnProducto.Enabled = true;
                btnAgregarPesable.Enabled = true;
                cbTipoComprobante.Enabled = true;
                cbxCategoria.Enabled = true;
            }
        }

        private void DGVenta_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (DGVenta.RowCount == 0)
            {

                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
            }
            else
            {

                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }

        private void DGVenta_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (DGVenta.RowCount == 0)
            {

                btnGuardar.Enabled = false;
            }
            else
            {

                btnGuardar.Enabled = true;
            }
        }

           
        private void btnProducto_Click(object sender, EventArgs e)
        {
            FrmConsulta objconsulta = new FrmConsulta(true);
            objconsulta.ShowDialog();
            
            //si el usuario cierra la ventana isCerro es true, sino si selecciono algun articulo isCerro
            try
            {
                if (objconsulta.IsCerro != false)
                {
                    int index = Buscar_producto(objconsulta.Idarticulo, "poridarticulo", !chkporcantidad.Checked);
                   
                        if (index < 0)
                    {
                        DGVenta.Rows[DGVenta.Rows.Count - 1].Cells[3].Selected = true;
                    }
                    else
                    {
                        DGVenta.Rows[index].Cells[3].Selected = true;
                    }
                    
                    if (chkporcantidad.Checked == true)
                    {
                        cambiartextbox();
                    }

                }
                else
                {
                     
                   
                }

            }
            catch (Exception ex)
            {

                UtilityFrm.mensajeError("Error al seleccionar un producto. Causa:" + ex.Message + ",cadena:" + ex.StackTrace);
                UtilityFrm.Log oLog = new UtilityFrm.Log();
                oLog.Add(ex.Message + ex.StackTrace);
                btnCliente.Focus();
            }

        }

      
        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtIdCliente.TextLength > 3 && !IsNumeric(txtIdCliente.Text))
            {

                
                DGCliente.Visible = true;


                DGCliente.DataSource = NegocioCliente.buscar(txtIdCliente.Text);

                DGCliente.Columns[0].Visible = false;
                DGCliente.Columns[1].Width = 350;
                DGCliente.Columns[2].Visible = false;
                DGCliente.Columns[3].Visible = false;
                DGCliente.Columns[4].Visible = false;
                DGCliente.Columns[5].Visible = false;
                DGCliente.Columns[6].Visible = false;
            }
            else
            {
                DGCliente.Visible = false;
            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                txtNombreProducto.Focus();
                txtNombreProducto.Text += e.KeyChar;
                //se mueve hasta la ultima posicion
                txtNombreProducto.Select(txtNombreProducto.Text.Length, 0);
            }
        }
        private void DGVenta_KeyDown(object sender, KeyEventArgs e)
        {
            DataGridViewRow fila = DGVenta.CurrentRow;

            if (e.KeyCode == Keys.Up && DGVenta.Rows.Count > 0 && DGVenta.Rows[0].Selected)
            {
                //Si se presiona la tecla up, existe elementos en la grilla y se selecciona antes del primer elemento
                txtNombreProducto.Focus();

            }
            if (e.KeyCode == Keys.F6)
            {
                fila.Cells["Lista"].Value = cambiarpreciosegunlista(1);
                RBPrecioNormal.Checked = true;
                DGVenta.Refresh();
                totales();
            }
            if (e.KeyCode == Keys.F7)
            {
                RBPreciomayorista1.Checked = true;
                fila.Cells["Lista"].Value = cambiarpreciosegunlista(2);
                DGVenta.Refresh();
                totales();
            }
            if (e.KeyCode == Keys.F8)
            {
                fila.Cells["Lista"].Value = cambiarpreciosegunlista(3);
                RBPreciomayorista2.Checked = true;
                DGVenta.Refresh();
                totales();
            }
            if (e.KeyCode == Keys.F9)
            {
                RBPrecioOferta.Checked = true;
                fila.Cells["Lista"].Value = cambiarpreciosegunlista(4);
                DGVenta.Refresh();
                totales();
            }


        }

      
        /*METODOS PROPIOS*/
        //mensajes de ayuda
        private void mensajesDeAyuda()
        {

            //mensaje de ayuda en el textbox nombre
            this.ttMensajeAyuda.SetToolTip(this.txtNombreProducto, "Ingrese el producto que desea buscar");
            //mensaje de ayuda en el textbox nombre
            //this.ttMensajeAyuda.SetToolTip(this.TxtCodigo, "Ingrese el Codigo de Cliente");
            //mensaje de ayuda del boton calculadora
            this.ttMensajeAyuda.SetToolTip(this.btnCalculadora, "Acceso a la Calculadora de windows(F11)");
            //mensaje de ayuda en el consulta de precios
            this.ttMensajeAyuda.SetToolTip(this.btnConsultas, "Consulta de precios (F12)");
        }



        public void quitarProducto()
        {
            try
            {
                if (DGVenta.Rows.Count > 0)
                {
                   

                        //selecciono la primera "0" porque solo selecciono 1 row
                        int rowSelected = DGVenta.SelectedRows[0].Index;
                        DGVenta.Rows.RemoveAt(rowSelected);
                        actualizarPrecioTotal();
                        totales();


                }
                else
                {

                    UtilityFrm.mensajeError("No existe Producto seleccionado ");


                }

            }
            catch (Exception ex)
            {

                UtilityFrm.mensajeError("Error: " + ex.Message);
            }

        }
        public void actualizarPrecioTotal() {
            if (DGVenta.Rows.Count > 0)
            {
                decimal total=0;
                foreach (DataGridViewRow row in DGVenta.Rows)
                {
                   
                    total = decimal.Round( total+  Convert.ToDecimal( row.Cells["Importe"].Value),2);

                }

                //asigno la sumatoria del importe(cantidad*precio) de los productos para saber el total a pagar en txtTotalPagar
                txtTotalPagar.Text = total.ToString();
            }
            else {
                txtTotalPagar.Text = "0,00";
                txtIVA.Text = "0,00";
                txtNeto.Text = "0,00";
                txtIva105.Text = "0,00";
                txtNeto105.Text = "0,00";
                txtNombreProducto.Focus();
            }
           
        
        }
        public void limpiarCampos() {
            //UtilityFrm.limpiarTextbox(TxtDesc,TxtPrecio,TxtDetalle,TxtCodigo);
            if ((DGVenta.Rows.Count > 0))
            {
                //si no hay productos agregados cambian los botones de guardado y cancelar a disabled
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;


            }
            else { 
               btnGuardar.Enabled = false;
               btnCancelar.Enabled = false;
            }
        }
        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            //calculadora
            Process proceso = new Process();
            proceso.StartInfo.FileName = "calc.exe";
            proceso.StartInfo.Arguments = "";
            proceso.Start();
        }

        //VENTANA Y PANEL SUPERIOR

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            //maximizar
            this.btnRestaurar.Visible = true;
            this.btnMaximizar.Visible = false;
            this.WindowState = FormWindowState.Maximized;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //cierra
            //if (NegocioConfigEmpresa.balanzapuerto != "")
            //{
            //    UtilityFrm.desconectarbalanza(serialPort1);
            //}

            this.Close();

        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            //minimiza
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            //restaurar
            this.btnRestaurar.Visible = false;
            this.btnMaximizar.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void panelHorizontal_DoubleClick(object sender, EventArgs e)
        {
            if (btnRestaurar.Visible == false || btnMaximizar.Visible == true)
            {
                //maximizar
                this.btnRestaurar.Visible = true;
                this.btnMaximizar.Visible = false;
                this.WindowState = FormWindowState.Maximized;

            }
            else
            {
                //restaurar
                this.btnRestaurar.Visible = false;
                this.btnMaximizar.Visible = true;
                this.WindowState = FormWindowState.Normal;
            }
        }
        private void btnCerrar_MouseMove(object sender, MouseEventArgs e)
        {
            btnCerrar.BackColor = Color.Red;
        }
        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.FromArgb(0,100,200);
        }
        private void btnRestaurar_MouseMove(object sender, MouseEventArgs e)
        {
            btnRestaurar.BackColor = Color.FromArgb(65, 39, 60);
        }
        private void btnRestaurar_MouseLeave(object sender, EventArgs e)
        {
            btnRestaurar.BackColor = Color.FromArgb(0,100,200);
        }
        private void btnMaximizar_MouseMove(object sender, MouseEventArgs e)
        {
            btnMaximizar.BackColor = Color.FromArgb(65, 39, 60);
        }
        private void btnMaximizar_MouseLeave(object sender, EventArgs e)
        {
            btnMaximizar.BackColor = Color.FromArgb(0,100,200);
        }
        private void btnMinimizar_MouseMove(object sender, MouseEventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(65, 39, 60);
        }
        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(0,100,200);
        }

        int posY = 0;
        int posX = 0;
        private void panelHorizontal_MouseMove(object sender, MouseEventArgs e)
        {
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

        private void btnAyuda_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            FrmConsulta consultas = new FrmConsulta();
            consultas.Show();
        }

        private void btnAgregarPesable_Click(object sender, EventArgs e)
        {
            FrmAsignarPrecio asignarPrecio = new FrmAsignarPrecio();
            asignarPrecio.ShowDialog();
            if(asignarPrecio.IsCerro==false){
                //el cero pertenece al descuento
                DGVenta.Rows.Add(asignarPrecio.Codigo, asignarPrecio.Producto, asignarPrecio.PrecioXKg, asignarPrecio.KgReal,0, asignarPrecio.PrecioTotal);
                this.actualizarPrecioTotal();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FiscalPrinterLib.HASAR mihasar = new FiscalPrinterLib.HASAR();
            //HASAR mihasar = new HASAR();
            //HasarArgentina.ImpresoraFiscalRG3561 prueba = new HasarArgentina.ImpresoraFiscalRG3561();
            //FrmCerrarCaja formcierrecaja = new FrmCerrarCaja();
            //formcierrecaja.Text = "Cierre de turno";
            
            //formcierrecaja.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (pesable == 0) { UtilityFrm.NumTeclado(e, txtcant); };
        }

        private void chkporcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void chkporcantidad_CheckedChanged(object sender, EventArgs e)
        {
            txtcant.Enabled = chkporcantidad.Checked;
            lblcant.Enabled = chkporcantidad.Checked; 
        }

        private void TxtDesc_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtDesc_MouseClick(object sender, MouseEventArgs e)
        {
            //TxtDesc.SelectAll(); 
        }

        private void txtcant_Validated(object sender, EventArgs e)
        {
            txtcant.SelectAll();
        }

        private void txtcant_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    if (TxtCodigo.Text.ToString() != "" )
            //    { 
            //      Buscar_producto(Convert.ToInt64(TxtCodigo.Text),"poridarticulo",true,Convert.ToDecimal ( txtcant.Text));
            //      txtNombreProducto.Focus();
                
            //    }
            //}
        }

        private void txtcant_MouseClick(object sender, MouseEventArgs e)
        {
            txtcant.SelectAll();
        }

        private void chkPreciomanual_CheckedChanged(object sender, EventArgs e)
        {
            //lblPrecio.Enabled  = chkporcantidad.Checked;
            //TxtPrecio.Enabled = chkporcantidad.Checked; 
        }

        private void DGVenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Rectangle rec = DGVenta.GetCellDisplayRectangle(DGVenta.CurrentCell.ColumnIndex, DGVenta.CurrentCell.RowIndex, false);
            datagriddobleclic = true;
            //e.ColumnIndex == 2 || parametrizacion

            try
            {
                if (DGVenta.Rows.Count > 0)
                {
                    if ((e.ColumnIndex == datagridprecio && (NegocioConfigEmpresa.usuariosa == true || objusuario.TieneRegla("45") == true)) || e.ColumnIndex == datagridcantidad || e.ColumnIndex == datagriddescuento || (e.ColumnIndex == datagridsubtotal && Convert.ToInt16(DGVenta.CurrentRow.Cells["Dpesable"].Value) == 1))
                    {

                        TxtcambioDv.Location = new Point(rec.Location.X + DGVenta.Location.X, rec.Location.Y + DGVenta.Location.Y);
                        preciocantidad = "Cprecio";
                        TxtcambioDv.Visible = true;
                        TxtcambioDv.Text = DGVenta.CurrentCell.Value.ToString();
                        TxtcambioDv.Focus();

                        if (e.ColumnIndex == datagridprecio)
                        {
                            DGVenta.CurrentRow.Cells["Manual"].Value = "Manual";
                        }


                    }

                    if (e.ColumnIndex == datagridcantidad)
                    {
                        preciocantidad = "cantidad";


                    }
                    if (e.ColumnIndex == datagridprecio)
                    {
                        preciocantidad = "Cprecio";


                    }

                    if (e.ColumnIndex == datagriddescuento)
                    {
                        preciocantidad = "descuento";

                    }

                    if (e.ColumnIndex == datagridsubtotal)
                    {
                        preciocantidad = "subtotal";
                    }

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

        private void TxtcambioDv_KeyDown(object sender, KeyEventArgs e)
        {
            decimal cantidad = 0;

            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (preciocantidad == "Cprecio") { DGVenta.CurrentRow.Cells["Cprecio"].Value = Decimal.Round(Convert.ToDecimal(TxtcambioDv.Text), 2); }
                    else if (preciocantidad == "cantidad")
                    {
                        if (datagriddobleclic == true || encontrado == false)
                        {
                            DGVenta.CurrentRow.Cells["cantidad"].Value = Convert.ToDecimal(TxtcambioDv.Text);
                            datagriddobleclic = false;
                        }
                        else
                        {
                            DGVenta.CurrentRow.Cells["cantidad"].Value = Convert.ToDecimal(TxtcambioDv.Text) + Convert.ToDecimal(DGVenta.CurrentRow.Cells["cantidad"].Value);
                            //DGVenta.CurrentRow.Cells["cantidad"].Value = Convert.ToDecimal(TxtcambioDv.Text);// + Convert.ToDecimal(DGVenta.CurrentRow.Cells["cantidad"].Value);
                        }

                        DGVenta.CurrentRow.Cells["Calculo"].Value = "cantidad";
                    }
                    else if (preciocantidad == "descuento") { DGVenta.CurrentRow.Cells["descuento"].Value = TxtcambioDv.Text; }
                    else if (preciocantidad == "subtotal")
                    {
                        DGVenta.CurrentRow.Cells["subtotal"].Value = Decimal.Round(Convert.ToDecimal(TxtcambioDv.Text), 2);
                        cantidad = Decimal.Round(Convert.ToDecimal(DGVenta.CurrentRow.Cells["subtotal"].Value) / Convert.ToDecimal(DGVenta.CurrentRow.Cells["Cprecio"].Value), 2);
                        DGVenta.CurrentRow.Cells["cantidad"].Value = cantidad.ToString("0.00");
                        DGVenta.CurrentRow.Cells["Calculo"].Value = "subtotal";

                    }

                    TxtcambioDv.Visible = false;
                    totales();

                    if (DGVenta.CurrentCell.ColumnIndex == datagridprecio)
                    {

                        habilitarcolumna("cantidad");
                    }

                    else if (DGVenta.CurrentCell.ColumnIndex == datagridcantidad)
                    {
                        if (pesable == 1)
                        {
                            habilitarcolumna("subtotal");
                        }
                        else
                        {
                            txtNombreProducto.Focus();
                            //DGVenta.Rows[DGVenta.CurrentCell.RowIndex].Cells[5].Selected = true;
                        }
                    }

                    else if (DGVenta.CurrentCell.ColumnIndex == datagridsubtotal)
                    {
                        txtNombreProducto.Focus();
                        return;
                        //DGVenta.Rows[DGVenta.CurrentCell.RowIndex].Cells[5 + 2].Selected = true;
                    }
                    else if (DGVenta.CurrentCell.ColumnIndex == datagriddescuento)
                    {
                        habilitarcolumna("importe");
                        //DGVenta.Rows[DGVenta.CurrentCell.RowIndex].Cells[6 + 2].Selected = true;
                    }
                    if (DGVenta.CurrentCell.ColumnIndex != datagridcantidad  )
                    {
                       
                            cambiartextbox();
                       
                        
                    }
                    else
                    {

                        txtNombreProducto.Focus();
                    }
                    //Convert.ToDecimal(row.Cells["Precio"].Value);


                    //dataGridView1.CurrentRow.Cells["idarticulo"].Value


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

        private void habilitarcolumna(string columnaparahabilitar)
        {
            switch (columnaparahabilitar)
            {
                case "descuento":
                    {
                        DGVenta.Rows[DGVenta.CurrentCell.RowIndex].Cells[6 + 1].Selected = true;
                        break;
                    }
                case "importe":
                    {
                        DGVenta.Rows[DGVenta.CurrentCell.RowIndex].Cells[6 + 2].Selected = true;
                        break;
                    }
                case "cantidad":
                    {
                        DGVenta.Rows[DGVenta.CurrentCell.RowIndex].Cells[3 + 2].Selected = true;
                        break;
                    }
                case "subtotal":
                    {
                        DGVenta.Rows[DGVenta.CurrentCell.RowIndex].Cells[4 + 2].Selected = true;
                        break;
                    }
                default:
                    break;
            }
        }
        private void TxtcambioDv_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtcambioDv_Leave(object sender, EventArgs e)
        {
            TxtcambioDv.Visible = false;
        }

        private void TxtcambioDv_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilityFrm.NumDecTeclado(e, TxtcambioDv);
        }

        private void DGVenta_Click(object sender, EventArgs e)
        {
            
        }

        private void DGVenta_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
               // DGVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                mouse = true;
                contextMenuStrip1.Show(DGVenta, new Point(e.X, e.Y));

            }
        }

        private void Menudeleteselect_Click(object sender, EventArgs e)
        {
            quitarProducto();
        }

        private void llenarcomboboxtarjeta()
        {
            cbTarjeta.DataSource = NegocioVenta.tarjeta();
            //valor real de la DB
            this.cbTarjeta.ValueMember = "Codigo";
            //lo que se muestra
            this.cbTarjeta.DisplayMember = "Descripcion";
            cbTarjeta.SelectedIndex = 0;
           
        }

        private void llenarcomboboxcuota()
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

        private void rTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            cbMCuota.Enabled = rTarjeta.Checked;
            cbTarjeta.Enabled = rTarjeta.Checked;
            totales();
        }

        private void cbTarjeta_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void rContado_CheckedChanged(object sender, EventArgs e)
        {
            if (rContado.Checked == true)
            {
                totales();
            }
        }

        private void cbCuota_SelectedIndexChanged(object sender, EventArgs e)
        {
            totales();
        }

        private void cbTarjeta_SelectedValueChanged(object sender, EventArgs e)
        {
            llenarcomboboxcuota();
            
        }

        private void cbMCuota_SelectedIndexChanged(object sender, EventArgs e)
        {
            totales();
        }

        private string aptofacturacion(string factura, string catcontribuyente)
        {
            string msg = "ok";

            if (factura == "B")
            {
                if (catcontribuyente == "RI")
                {
                    msg = "El contribuyente no es apto para este tipo de factura";
                }
            }

            if (factura == "A")
            {
                if (catcontribuyente != "RI")
                {
                    msg = "El contribuyente no es apto para este tipo de factura";
                }
            }



            return msg;
        }

        private void frmPventa_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void DGVenta_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
           
        }

        private void DGVenta_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //decimal cantidad = 0;
            //if (DGVenta.Columns[e.ColumnIndex].Name == "precio") { DGVenta.CurrentRow.Cells["Cprecio"].Value = Decimal.Round(Convert.ToDecimal(DGVenta.CurrentRow.Cells["Cprecio"].Value), 2); }
            //else if (preciocantidad == "cantidad")
            //{
            //    //DGVenta.CurrentRow.Cells["cantidad"].Value = TxtcambioDv.Text;
            //    DGVenta.Columns[e.ColumnIndex].Name = "cantidad";
            //}
            ////else if (DGVenta.Columns[e.ColumnIndex].Name == "descuento") { DGVenta.CurrentRow.Cells["descuento"].Value = TxtcambioDv.Text; }
            //else if (DGVenta.Columns[e.ColumnIndex].Name == "subtotal")
            //{
            //    DGVenta.CurrentRow.Cells["subtotal"].Value = Decimal.Round(Convert.ToDecimal(DGVenta.CurrentRow.Cells["subtotal"].Value), 2);
            //    cantidad = Decimal.Round(Convert.ToDecimal(DGVenta.CurrentRow.Cells["subtotal"].Value) / Convert.ToDecimal(DGVenta.CurrentRow.Cells["Cprecio"].Value), 2);
            //    DGVenta.CurrentRow.Cells["cantidad"].Value = cantidad.ToString("0.00");
            //    DGVenta.CurrentRow.Cells["Calculo"].Value = "subtotal";

            //}

            ////Convert.ToDecimal(row.Cells["Precio"].Value);
            //// TxtcambioDv.Visible = false;
            //totales();
            ////dataGridView1.CurrentRow.Cells["idarticulo"].Value
        }
        private void Validar_Keypress (object sender,System.Windows.Forms.KeyPressEventArgs e)
        {
            //obtener indice de la columna 
            int columna = DGVenta.CurrentCell.ColumnIndex;
            string valor = "";
            //solo valores numericos
             
            valor = DGVenta.CurrentRow.Cells[columna].Value.ToString ();

            if (Char.IsDigit(e.KeyChar))
            {

                e.Handled = false;


            }
            else if (e.KeyChar == ',' && !valor.Contains(','))
            {
                e.Handled = false;
                //solo una coma decimal
                //&& !valor.Contains(',')


            }
            else if (e.KeyChar == '.' && !valor.Contains(','))
            {
                //&& !valor.Contains(',')
                e.Handled = true;
                valor += ",";
                //se mueve hasta la ultima posicion
                //valor.Select(valor.Length, 0);
            }


            else if (Char.IsControl(e.KeyChar))
            {

                e.Handled = false;
            }

            else
            {
                e.Handled = true;
               // SystemSounds.Beep.Play();
            }
             
        }

        private void DGVenta_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
           
           // e.Control.KeyPress -= new KeyPressEventHandler(Validar_Keypress);
           // e.Control.KeyPress += new KeyPressEventHandler(Validar_Keypress);
            
        }

        private void txtNombreProducto_LocationChanged(object sender, EventArgs e)
        {

        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            
            
            
        }

        private void cbxCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNombreProducto.Focus();
            }
        }

        private void cbTarjeta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbMCuota.Focus();
            }
        }

        private void cbMCuota_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNombreProducto.Focus();
            }
        }

        private void DGCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Buscar_Cliente(Convert.ToInt32(DGCliente.CurrentRow.Cells["idcliente"].Value));
                DGCliente.Visible = false;
                txtNombreProducto.Focus();
            }
            
        }

        private void DGCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGCliente_DoubleClick(object sender, EventArgs e)
        {

        }

        private void DGCliente_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dataGridView1_Enter(object sender, EventArgs e)
        {
            int index = 0;
            try
            {
                if (txtnombre_enter == true && dataGridView1.Rows.Count != 0)
                {
                    index = Buscar_producto(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["idarticulo"].Value), "poridarticulo", !chkporcantidad.Checked);
                    if (index < 0)
                    {
                        if (DGVenta.Rows.Count != 0)
                        {
                            //  habilitarcolumna("cantidad");
                            DGVenta.Rows[DGVenta.Rows.Count - 1].Cells[3 + 2].Selected = true;
                        }

                    }
                    else
                    {
                        //habilitarcolumna("cantidad");
                        DGVenta.Rows[index].Cells[3 + 2].Selected = true;
                    }

                    if (chkporcantidad.Checked == true && objnart.Pesable == 0)
                    {
                        dataGridView1.Visible = false;
                        txtnombre_enter = false;
                        cambiartextbox();
                        
                    }


                }
            }
            catch (Exception)
            {

                dataGridView1.Focus();

            }
              
                //txtNombreProducto.Focus();
               // UtilityFrm.mensajeConfirm("se apreto el enter");
          
        }

        private void DGVenta_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }

        private void controlarstock()
        {
           
        }
    }
}
