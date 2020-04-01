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
               

                //if (NegocioConfigEmpresa.confsistema("facturar").ToString() == "True")
                //{

                //    cbTipoComprobante.Items.Add("FACTURA");
                //    cbTipoComprobante.Text = "FACTURA";
                //}

                if (NegocioConfigEmpresa.emciva == "MN")
                {
                    cbxCategoria.Items.Add("C");
                    cbxCategoria.Text = "C";
                }
                if (NegocioConfigEmpresa.emciva == "RI")
                {
                    cbxCategoria.Items.Add("A");
                    cbxCategoria.Items.Add("B");
                    cbxCategoria.Text = "B";
                }


                this.DGVenta.Columns["Precio"].DefaultCellStyle.Format = String.Format("$###,##0.00");
                DGVenta.Columns["Importe"].DefaultCellStyle.Format = String.Format("$###,##0.00");
                Lblvendedor.Text = NegocioConfigEmpresa.nombreusuario;
                DGVenta.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
               
                //foreach (DataGridViewColumn c in DGVenta.Columns)
                //{
                    
                //        if ((c.Index < 2) || (c.Index > 5))
                //        {

                //            c.ReadOnly = true;
                            

                //        }
                    
                    

                //}
                
            }
            catch (Exception s)
            {

                UtilityFrm.mensajeError(s.Message);
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
                    DataTable dt = NegocioCliente.buscarCodigoCliente(codCliente.ToString());
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
                        cbxCategoria.SelectedIndex = 1;
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
            catch (Exception)
            {
                
                throw;
            }
            
          }
          public void agregar_producto(int codproducto, decimal  precioProducto,decimal  descuentoProducto)
          {
              try
              {
                  int cantidadProducto = 1;
                  objnart.extraerdatos(codproducto, "poridarticulo");

                  TxtDetalle.Text = objnart.Nombre;
                  //asigno el valor del precio pasado en el formulario frmasignarPrecio
                  TxtPrecio.Text = Convert.ToString(precioProducto);
                  TxtCodigo.Text = Convert.ToString(objnart.IdArticulo);
                  TxtDesc.Text = Convert.ToString(descuentoProducto);
                  //si el descuento esta vacio se asigna 0 o se asigna su mismo contenido

                  TxtDesc.Text = (string.IsNullOrEmpty(TxtDesc.Text)) ? "0" : TxtDesc.Text;
                  //lo multiplico por 1 para obtener el mismo valor

                  decimal totalPagar = Convert.ToDecimal(txtTotalPagar.Text);
                  totalPagar = (cantidadProducto * precioProducto) + (totalPagar);
                  DGVenta.Rows.Add(TxtCodigo.Text, TxtDetalle.Text, TxtPrecio.Text, TxtDesc.Text, cantidadProducto.ToString());

                  txtTotalPagar.Text = totalPagar.ToString();
                  txtNombreProducto.Text = "";
                  txtNombreProducto.Focus();
              }
              catch (Exception)
              {
                  
                  throw;
              }

              
          }

          public void Buscar_producto(long codproducto, string tipo, bool agregardatagrid, decimal cantidad = 1, string codbarra = "")
          {
              try
              {
                  decimal precio;
                  decimal descuento;
                  decimal importe;
                  decimal total = 0;
                  decimal cantidadActual = 0;


                  objnart.extraerdatos(codproducto, tipo, codbarra);

                  if (objnart.Sindatos == true)
                  {



                      TxtDetalle.Text = objnart.Nombre;
                      TxtPrecio.Text = Convert.ToString(decimal.Round(objnart.Precio, 2));
                      TxtCodigo.Text = Convert.ToString(objnart.IdArticulo);
                      pesable = objnart.Pesable;


                      //si el descuento esta vacio se asigna 0 o se asigna su mismo contenido
                      TxtDesc.Text = (string.IsNullOrEmpty(TxtDesc.Text)) ? "0" : TxtDesc.Text;

                      bool encontrado = false;

                      //if (agregardatagrid == true)
                      //{
                          foreach (DataGridViewRow row in DGVenta.Rows)
                          {

                              if (Convert.ToString(row.Cells["Codigo"].Value) == TxtCodigo.Text)
                              {


                                  encontrado = true;

                                  row.Cells["Descuento"].Value = (string.IsNullOrEmpty(TxtDesc.Text)) ? "0" : TxtDesc.Text;
                                  //asigno el precio,descuento,cantidad
                                  precio = Convert.ToDecimal(row.Cells["Precio"].Value);
                                  descuento = Convert.ToDecimal(row.Cells["Descuento"].Value);
                                  cantidadActual = (Convert.ToDecimal(row.Cells["Cantidad"].Value));

                                  //incremento la cantidad del producto agregado
                                  cantidadActual += cantidad;
                                  row.Cells["Cantidad"].Value = cantidadActual;
                                  //calculo el precio con descuento incluido * la cantidad de articulos agregados
                                  importe = precio * cantidadActual;
                                  importe = importe - ((importe * descuento) / 100);
                                  row.Cells["Importe"].Value = importe;


                              }

                          }

                      

                      if (encontrado == false)
                      {
                          //si no se encuentra cantidad 

                          precio = Convert.ToDecimal(TxtPrecio.Text);
                          descuento = Convert.ToDecimal(TxtDesc.Text);
                          //le aplico el descuento correspondiente
                          precio = precio - ((precio * descuento) / 100);
                          // precio = precio * cantidad;
                          //no calculo el precio por la cantidad porque da el mismo numero
                         
                           DGVenta.Rows.Add(TxtCodigo.Text, TxtDetalle.Text, precio, cantidad, "0", TxtDesc.Text, precio,pesable,"cantidad"); 



                      }

                      totales();
                      //foreach (DataGridViewRow row in DGVenta.Rows)
                      //{
                      //    total = total + Convert.ToDecimal (row.Cells["importe"].Value);
                      //    decimal.Round(total, 2);
                      //}
                      //txtTotalPagar.Text = Convert.ToString(total);
                      //txtNombreProducto.Text = "";

                  }
                  else
                  {
                      // UtilityFrm.mensajeError( "No es una clave valida");

                      FrmMensajeAutoCierre.Show("No es una clave valida", "Error", 1000);




                      txtNombreProducto.SelectAll();

                  }

                   txtcant.SelectAll(); txtcant.Focus(); 
              }
              catch (Exception)
              {
                  
                  throw;
              }
             
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
                  decimal neto = 0;
                  decimal iva = 0;
                  decimal porcentaje = 0;
                  decimal cuota = 0;
                  decimal subtotal = 0;
                  if (DGVenta.RowCount != 0)
                  {
                      foreach (DataGridViewRow row in DGVenta.Rows)
                      {

                          //if (Convert.ToString(row.Cells["Codigo"].Value) == TxtCodigo.Text)
                          // {




                          // row.Cells["Descuento"].Value = TxtDesc.Text;
                          //asigno el precio,descuento,cantidad
                          subtotal = Decimal.Round ( Convert.ToDecimal(row.Cells["subtotal"].Value),2);
                          precio = Decimal.Round ( Convert.ToDecimal(row.Cells["Precio"].Value),2);
                          if (rTarjeta.Checked == true)
                          {
                              porcentaje = Convert.ToDecimal(cbMCuota.SelectedValue);
                              
                              row.Cells["Descuento"].Value = 0;
                          }
                         

                          descuento = Convert.ToDecimal(row.Cells["Descuento"].Value);
                          cantidadActual = Decimal.Round ( (Convert.ToDecimal(row.Cells["Cantidad"].Value)),2);

                          //incremento la cantidad del producto agregado
                          cantidadActual += cantidad;
                          row.Cells["Cantidad"].Value = cantidadActual;
                          //calculo el precio con descuento incluido * la cantidad de articulos agregados
                          if (row.Cells["Calculo"].Value == "cantidad" || row.Cells["Calculo"].Value == "")
                          {
                              importe = Decimal.Round(precio * cantidadActual, 2);
                          }
                          else
                          {
                              cantidadActual = Decimal.Round(Convert.ToDecimal(row.Cells["subtotal"].Value) / Convert.ToDecimal(row.Cells["precio"].Value), 2);
                             importe = Convert.ToDecimal(row.Cells["subtotal"].Value);
                          }
                              
                          
                          
                          row.Cells["subtotal"].Value = importe;
                          if (porcentaje != 0)
                          {
                              importe = importe + ((importe * porcentaje) / 100);
                          }
                          importe = importe - ((importe * descuento) / 100);
                          row.Cells["Importe"].Value = importe;


                          // }

                      }

                      foreach (DataGridViewRow row in DGVenta.Rows)
                      {
                          total = total + Convert.ToDecimal(row.Cells["importe"].Value);

                          decimal.Round(total, 2);

                      }

                      neto = Decimal.Round ( total / Convert.ToDecimal(1.21),2);
                      iva = total - neto;
                      if (rTarjeta.Checked == true)
                      {
                          cuota = total / Convert.ToDecimal(cbMCuota.Text);
                      }
                      else
                      {
                          Txtcuota.Text = txtTotalPagar.Text;
                      }
                      txtIVA.Text = iva.ToString("0.00");
                      txtNeto.Text = neto.ToString("0.00");
                      txtTotalPagar.Text = total.ToString("0.00");
                      Txtcuota.Text = cuota.ToString("0.00");
                      txtNombreProducto.Text = "";
                  }

                  
              }
              catch (Exception)
              {
                  
                  throw;
              }
              
          
          }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            
          //  Frmimpventicket miform = new Frmimpventicket();
           // miform.Codventa = 1080;
           // miform.Show();
            
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
                    UtilityFrm.mensajeError("Error al seleccionar un cliente. Causa:" + ex.Message);
                    clienteIncorrecto();
                    btnCliente.Focus();
                    
                }


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
              if (e.KeyCode == Keys.F1) {
                try
                {
                    Buscar_Cliente(1);
                    //consumidor final es 1
                    txtIdCliente.Text = "1";
                   
                }

                catch (Exception ex)
                {
                    UtilityFrm.mensajeError("Error al seleccionar un cliente. Causa:" + ex.Message);
                    clienteIncorrecto();
                    btnCliente.Focus();

                }

            }else if (e.KeyCode == Keys.F2) {
                  //guarda la venta
                  btnGuardar.PerformClick();

            }
              else if (e.KeyCode == Keys.F5)
              {
                  //Cambiar la cantidad manualmente
                  if (DGVenta.Rows.Count > 0)
                  {
                      FrmAsignarValores asignarValor = new FrmAsignarValores("Cantidad");
                      asignarValor.ShowDialog();
                      //modifico la cantidad del row seleccionado

                      if (asignarValor.Cantidad != 0)
                      {
                          DGVenta.CurrentRow.Cells["Cantidad"].Value = asignarValor.Cantidad;
                          Decimal PrecioTotal = Convert.ToDecimal(DGVenta.CurrentRow.Cells["Precio"].Value);
                          PrecioTotal = PrecioTotal * asignarValor.Cantidad;
                          DGVenta.CurrentRow.Cells["Importe"].Value = PrecioTotal;

                          actualizarPrecioTotal();
                      }
                     

                  }


              }
              else if (e.KeyCode == Keys.F6)
              {
                  btnAgregarPesable.PerformClick();
              }
              else if (e.KeyCode == Keys.F11)
              {
                  //CONSULTA DE PRECIO
                  btnCalculadora.PerformClick();
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

        

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            string nombretarjeta = "";
            decimal importecuota = 0;
            int cuota = 0;
            Negociocaja objcaja = new Negociocaja();
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
                if (aptofacturacion(cbxCategoria.Text,riva) != "ok")
                {
                    UtilityFrm.mensajeError(aptofacturacion(cbxCategoria.Text, riva));
                    return;
                }
            }


            
            FrmGuardarVenta venta = new FrmGuardarVenta(decimal.Round(Convert.ToDecimal(txtTotalPagar.Text), 2), Convert.ToInt32(txtIdCliente.Text), decimal.Round(Convert.ToDecimal(txtIVA.Text), 2), decimal.Round(Convert.ToDecimal(txtNeto.Text), 2), rContado.Checked == true ? "contado" : "tarjeta", nombretarjeta, importecuota, cuota, Convert.ToInt32(cbTarjeta.SelectedValue),cuit,txtRazonSocial.Text ,cbxCategoria.Text ,riva,domicilio);
            venta.ListadoDeProducto = DGVenta;
            venta.Tipo_comprobante = cbTipoComprobante.SelectedItem.ToString();
            venta.Concaja = objcaja.chequeocaja (this.Name,ref mensaje);

           // if (mensaje != "") { UtilityFrm.mensajeError(mensaje); } 
          
            

            venta.ShowDialog();

            if (venta.Trans == "ok")
                {
                    UtilityFrm.mensajeConfirm("La venta se realizó correctamente");
                    UtilityFrm.limpiarTextbox(txtNombreProducto, TxtPrecio, TxtDesc, TxtCodigo, TxtDetalle);
                    txtTotalPagar.Text = "0,00";
                    txtNeto.Text = "0,00";
                    txtIVA.Text = "0,00";
                    Txtcuota.Text = "0,00";
                    //limpia la grilla de productos
                    DGVenta.Rows.Clear();
                    txtNombreProducto.Enabled = true;
                    TxtDesc.Enabled = true;
                    TxtPrecio.Enabled = true;
                    btnProducto.Enabled = true;
                    btnAgregarPesable.Enabled = true;
                    txtNombreProducto.Focus();
                   
                }
                else
                {
                    UtilityFrm.mensajeError("Ha ocurrido un error: "+venta.Trans);
                }
            
        }

        private void txtNombreProducto_TextChanged_1(object sender, EventArgs e)
        {

            try
            {
                if (txtNombreProducto.TextLength >= 2 && IsNumeric(txtNombreProducto.Text) != true)
                {


                    dataGridView1.Visible = true;
                    dataGridView1.DataSource = NegocioArticulo.buscarNombre(txtNombreProducto.Text);

                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].Visible = false;
                    dataGridView1.Columns[2].Width = 350;
                    dataGridView1.Columns[3].Visible = false;
                    dataGridView1.Columns[4].Visible = false;
                    dataGridView1.Columns[5].Visible = false;
                    dataGridView1.Columns[6].Visible = false;



                }


                else
                    if ((IsNumeric(txtNombreProducto.Text) == true) && (txtNombreProducto.TextLength >= 13))
                    {
                        Buscar_producto(Convert.ToInt64(txtNombreProducto.Text), "porbarra", !chkporcantidad.Checked, 1, txtNombreProducto.Text);
                    }
                    else
                    {
                        dataGridView1.Visible = false;
                    }
                
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Buscar_producto(Convert.ToInt64(TxtCodigo.Text), "poridarticulo",!chkporcantidad.Checked);
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
                decimal precio = Convert.ToDecimal(fila.Cells["Precio"].Value);
                DGVenta.Rows.Remove(fila);
                totalPagar = (totalPagar- precio);
                txtTotalPagar.Text = totalPagar.ToString();

                UtilityFrm.limpiarTextbox(txtNombreProducto, TxtPrecio, TxtDesc, TxtCodigo, TxtDetalle);

            }
            catch (Exception ex)
            {

                UtilityFrm.mensajeError("Error al Borrar Fila :" + ex.Message);
            }
            //UtilityFrm.limpiarTextbox(txtIngOegr, txtPrecioCompra, txtNombreProducto, txtIdArticulo, txtPrecioVenta);
        }



        private void TxtPrecio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = false;
                e.SuppressKeyPress = true;
                
                if (!TxtPrecio.Text.Contains(","))
                {
                    TxtPrecio.Text += ",00";

                }
                TxtDesc.Focus();
            }
        }

        private void TxtPrecio_Leave(object sender, EventArgs e)
        {
            if (!TxtPrecio.Text.Contains(","))
            {
                TxtPrecio.Text += ",00";

            }
           
        }

        private void TxtSubtotal_Leave(object sender, EventArgs e)
        {
            if (!TxtPrecio.Text.Contains(","))
            {
                TxtPrecio.Text += ",00";

            }
        }

      

        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo valores numericos o comas
            if (Char.IsDigit(e.KeyChar))
            {

                e.Handled = false;

            }
            else if (e.KeyChar == '.' && !TxtPrecio.Text.Contains(',')) {
                e.Handled = true;
                SendKeys.Send(",");
               
                
            }
            else if (e.KeyChar == ',' && !TxtPrecio.Text.Contains(','))
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

        private void TxtDesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo valores numericos o comas
            UtilityFrm.NumTeclado(e, TxtDesc);
        }

        private void TxtDesc_Leave(object sender, EventArgs e)
        {
            if(TxtDesc.Text==""){
                TxtDesc.Text = "0";
            }

        }

        private void TxtDesc_KeyDown(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.Enter)
            {
                    if (TxtDesc.Text == "")
                     {
                           TxtDesc.Text = "0";
                      }
                    
                    
                        if (TxtCodigo.Text.ToString() != "")
                        {
                            Buscar_producto(Convert.ToInt64(TxtCodigo.Text), "poridarticulo", true, Convert.ToDecimal(txtcant.Text));
                            txtNombreProducto.Focus();

                        }
                    
                    txtNombreProducto.Focus();
             }
          
        }

       

        private void txtNombreProducto_KeyDown(object sender, KeyEventArgs e)
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

            if (e.KeyCode == Keys.Enter)
            {

                
                    //se pasa el control permitiendo eliminar el beep
                   e.SuppressKeyPress = true;
                   
               
                try
                {
                    txtNombreProducto.Text = txtNombreProducto.TextLength == 12 && IsNumeric(txtNombreProducto.Text) == true ? "0" + txtNombreProducto.Text : txtNombreProducto.Text;  
                    if (txtNombreProducto.TextLength >= 13 && IsNumeric(txtNombreProducto.Text) == true)
                    {
                        Buscar_producto(Convert.ToInt64(txtNombreProducto.Text), "porbarra",!chkporcantidad.Checked,1,txtNombreProducto.Text);
                        txtNombreProducto.Focus();

                    }

                    //if (txtNombreProducto.TextLength == 12)
                    //{
                    //    NegocioArticulo.buscarCodigoBarra(txtNombreProducto.Text);
                    //}
                    else if (IsNumeric(txtNombreProducto.Text) == true)
                    {
                        Buscar_producto(Convert.ToInt64(txtNombreProducto.Text), "poridarticulo", !chkporcantidad.Checked);

                    }
                    else
                    {
                        dataGridView1.Visible = false;
                        if (txtNombreProducto.Text  != "")
                        {
                            DialogResult dialogResult = MessageBox.Show("Desea agregar un producto que este fuera del sistema", "", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                DGVenta.Rows.Add("0", txtNombreProducto.Text, "0,00", "1", "0", "0", "0","0");
                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                //do something else
                            }
                        }
                        
                    
                    }
                    DGVenta.Rows[DGVenta.Rows.Count - 1].Cells[2].Selected = true;
                    if (chkporcantidad.Checked == true)
                    {
                        cambiartextbox();
                    }
                    
                    //txtNombreProducto.Focus();
                }
                catch (Exception ex)
                {

                    UtilityFrm.mensajeError("Error: "+ex.Message);
                }
              
            }
        }
        private void cambiartextbox()
        {
            Rectangle rec = DGVenta.GetCellDisplayRectangle(DGVenta.CurrentCell.ColumnIndex, DGVenta.CurrentCell.RowIndex, false);
            DGVenta.Focus();

            if (DGVenta.CurrentCell.ColumnIndex == 2)
            {
                preciocantidad = "precio";
            }

            else if ( DGVenta.CurrentCell.ColumnIndex == 3 )
            {
                preciocantidad = "cantidad";
            }

            else if (DGVenta.CurrentCell.ColumnIndex == 4)
            {
                preciocantidad = "subtotal";
            }

            else if (DGVenta.CurrentCell.ColumnIndex == 5)
            {
                preciocantidad = "descuento";
            }

            else if (DGVenta.CurrentCell.ColumnIndex == 6)
            {
                preciocantidad = "importe";
            }
            TxtcambioDv.Location = new Point(rec.Location.X + DGVenta.Location.X, rec.Location.Y + DGVenta.Location.Y);
           
            TxtcambioDv.Visible = true;
            TxtcambioDv.Text = DGVenta.CurrentCell.Value.ToString();
            TxtcambioDv.Focus();

            //if (pesable == 0)
            //{
            //    this.DGVenta.Rows[DGVenta.Rows.Count - 1].Cells["Importe"].ReadOnly = true;
            //}
            //else
            //{
            //    this.DGVenta.Rows[DGVenta.Rows.Count - 1].Cells["Importe"].ReadOnly = false;
            //}
            //this.DGVenta.Rows[1].Cells["Importe"].ReadOnly = false; 
            //this.DGVenta.Rows[DGVenta.Rows.Count - 1].Cells["Importe"].FormattedValue = format
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

                UtilityFrm.mensajeError("No hay datos asignados "+ex.Message);
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
            UtilityFrm.limpiarTextbox(txtIdCliente,TxtDetalle,txtNombreProducto,txtRazonSocial);
            UtilityFrm.limpiarTextbox(TxtPrecio,TxtCodigo);

            DGVenta.Rows.Clear();
            txtTotalPagar.Text = "0,00";
            TxtPrecio.Text = "0,00";
       
            TxtDesc.Text = "0";
            TxtDesc.Enabled = false;
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
                    Buscar_producto(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["idarticulo"].Value), "poridarticulo",!chkporcantidad.Checked);
                    dataGridView1.Visible = false;

                   
                    if (chkporcantidad.Checked == false) { txtNombreProducto.Focus(); };
                    DGVenta.Rows[DGVenta.Rows.Count - 1].Cells[2].Selected = true;
                    cambiartextbox();
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

                    UtilityFrm.mensajeError("No hay datos asignados " + ex.Message);
                   dataGridView1.Visible = true;
                    txtNombreProducto.Focus();
                }
               
            
            
        }

        private void txtRazonSocial_TextChanged(object sender, EventArgs e)
        {
            if (txtRazonSocial.Text.Count() > 0)
            {
                txtNombreProducto.Enabled = true;
                TxtDesc.Enabled = true;
                TxtPrecio.Enabled = true;
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

        private void txtIdCliente_Leave(object sender, EventArgs e)
        {

        }

        private void TxtDetalle_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

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
                    Buscar_producto(objconsulta.Idarticulo, "poridarticulo", !chkporcantidad.Checked);
                }
                else
                {
                     
                   
                }

            }
            catch (Exception ex)
            {

                UtilityFrm.mensajeError("Error al seleccionar un producto. Causa:" + ex.Message + ",cadena:" + ex.StackTrace);
                btnCliente.Focus();
            }

        }

      
        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {
           
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

            if (e.KeyCode == Keys.Up && DGVenta.Rows.Count > 0 && DGVenta.Rows[0].Selected)
            {
                //Si se presiona la tecla up, existe elementos en la grilla y se selecciona antes del primer elemento
                txtNombreProducto.Focus();

            }


        }

      
        /*METODOS PROPIOS*/
        //mensajes de ayuda
        private void mensajesDeAyuda()
        {

            //mensaje de ayuda en el textbox nombre
            this.ttMensajeAyuda.SetToolTip(this.txtNombreProducto, "Ingrese el producto que desea buscar");
            //mensaje de ayuda en el textbox nombre
            this.ttMensajeAyuda.SetToolTip(this.TxtCodigo, "Ingrese el Codigo de Cliente");
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
                txtNombreProducto.Focus();
            }
           
        
        }
        public void limpiarCampos() {
            UtilityFrm.limpiarTextbox(TxtDesc,TxtPrecio,TxtDetalle,TxtCodigo);
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
            btnCerrar.BackColor = Color.FromArgb(100, 0, 180);
        }
        private void btnRestaurar_MouseMove(object sender, MouseEventArgs e)
        {
            btnRestaurar.BackColor = Color.FromArgb(65, 39, 60);
        }
        private void btnRestaurar_MouseLeave(object sender, EventArgs e)
        {
            btnRestaurar.BackColor = Color.FromArgb(100, 0, 180);
        }
        private void btnMaximizar_MouseMove(object sender, MouseEventArgs e)
        {
            btnMaximizar.BackColor = Color.FromArgb(65, 39, 60);
        }
        private void btnMaximizar_MouseLeave(object sender, EventArgs e)
        {
            btnMaximizar.BackColor = Color.FromArgb(100, 0, 180);
        }
        private void btnMinimizar_MouseMove(object sender, MouseEventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(65, 39, 60);
        }
        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(100, 0, 180);
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

        private void DGVenta_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            
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
            TxtDesc.SelectAll(); 
        }

        private void txtcant_Validated(object sender, EventArgs e)
        {
            txtcant.SelectAll();
        }

        private void txtcant_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TxtCodigo.Text.ToString() != "" )
                { 
                  Buscar_producto(Convert.ToInt64(TxtCodigo.Text),"poridarticulo",true,Convert.ToDecimal ( txtcant.Text));
                  txtNombreProducto.Focus();
                
                }
            }
        }

        private void txtcant_MouseClick(object sender, MouseEventArgs e)
        {
            txtcant.SelectAll();
        }

        private void chkPreciomanual_CheckedChanged(object sender, EventArgs e)
        {
            lblPrecio.Enabled  = chkporcantidad.Checked;
            TxtPrecio.Enabled = chkporcantidad.Checked; 
        }

        private void DGVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGVenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Rectangle rec = DGVenta.GetCellDisplayRectangle(DGVenta.CurrentCell.ColumnIndex, DGVenta.CurrentCell.RowIndex, false);   
            

            if (DGVenta.Rows.Count > 0)
            {
                if (e.ColumnIndex == 2 || e.ColumnIndex == 3 || e.ColumnIndex == 5 || (e.ColumnIndex == 4 && Convert .ToInt16 ( DGVenta.CurrentRow.Cells["Dpesable"].Value) == 1))
                {

                    TxtcambioDv.Location = new Point(rec.Location.X + DGVenta.Location.X, rec.Location.Y + DGVenta.Location.Y);
                    preciocantidad = "precio";
                    TxtcambioDv.Visible = true;
                    TxtcambioDv.Text  = DGVenta.CurrentCell.Value.ToString();
                    TxtcambioDv.Focus();
                    

                }

                if (e.ColumnIndex == 3)
                {
                    preciocantidad = "cantidad";

                   
                }

                if (e.ColumnIndex == 5)
                {
                    preciocantidad = "descuento";
                  
                }

                if (e.ColumnIndex == 4)
                {
                    preciocantidad = "subtotal";
                }

            }
        }

        private void TxtcambioDv_KeyDown(object sender, KeyEventArgs e)
        {
            decimal cantidad = 0;
            if (e.KeyCode == Keys.Enter)
            {
                if (preciocantidad == "precio") { DGVenta.CurrentRow.Cells["Precio"].Value = Decimal.Round ( Convert.ToDecimal( TxtcambioDv.Text),2); }
                else if (preciocantidad == "cantidad") 
                { 
                    DGVenta.CurrentRow.Cells["cantidad"].Value = TxtcambioDv.Text;
                    DGVenta.CurrentRow.Cells["Calculo"].Value = "cantidad";
                }
                else if (preciocantidad == "descuento") { DGVenta.CurrentRow.Cells["descuento"].Value = TxtcambioDv.Text; }
                else if (preciocantidad == "subtotal") 
                {
                    DGVenta.CurrentRow.Cells["subtotal"].Value = Decimal.Round(Convert.ToDecimal(TxtcambioDv.Text), 2);
                    cantidad = Decimal.Round ( Convert.ToDecimal ( DGVenta.CurrentRow.Cells["subtotal"].Value) / Convert.ToDecimal ( DGVenta.CurrentRow.Cells["precio"].Value),2);
                    DGVenta.CurrentRow.Cells["cantidad"].Value = cantidad.ToString ("0.00");
                    DGVenta.CurrentRow.Cells["Calculo"].Value = "subtotal"; 
                
                }
              
                TxtcambioDv.Visible = false;
                totales();

                if (DGVenta.CurrentCell.ColumnIndex == 2 && mouse == false)
                {
                    
                    DGVenta.Rows[DGVenta.CurrentCell.RowIndex].Cells[3].Selected = true;
                }

                else if (DGVenta.CurrentCell.ColumnIndex == 3 && mouse == false )
                {
                    if ( pesable == 1)
                    {
                        DGVenta.Rows[DGVenta.CurrentCell.RowIndex].Cells[4].Selected = true;
                    }
                    else
                    {
                        DGVenta.Rows[DGVenta.CurrentCell.RowIndex].Cells[5].Selected = true;
                    }
                }

                else if (DGVenta.CurrentCell.ColumnIndex == 4 && mouse == false )
                {

                    DGVenta.Rows[DGVenta.CurrentCell.RowIndex].Cells[5].Selected = true;
                }
                else if (DGVenta.CurrentCell.ColumnIndex == 5 && mouse == false)
                {

                    DGVenta.Rows[DGVenta.CurrentCell.RowIndex].Cells[6].Selected = true;
                }
                if (DGVenta.CurrentCell.ColumnIndex != 6)
                {
                    cambiartextbox();
                }
                else
                {
                    if (mouse == true)
                    {
                        mouse = false;
                    }
                    txtNombreProducto.Focus();
                }
                //Convert.ToDecimal(row.Cells["Precio"].Value);
                
                
                //dataGridView1.CurrentRow.Cells["idarticulo"].Value
               
            
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
            cbTarjeta.SelectedIndex = 1;
           
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
            decimal cantidad = 0;
            if (DGVenta.Columns[e.ColumnIndex].Name == "precio") { DGVenta.CurrentRow.Cells["Precio"].Value = Decimal.Round(Convert.ToDecimal(DGVenta.CurrentRow.Cells["Precio"].Value), 2); }
            else if (preciocantidad == "cantidad")
            {
                //DGVenta.CurrentRow.Cells["cantidad"].Value = TxtcambioDv.Text;
                DGVenta.Columns[e.ColumnIndex].Name = "cantidad";
            }
            //else if (DGVenta.Columns[e.ColumnIndex].Name == "descuento") { DGVenta.CurrentRow.Cells["descuento"].Value = TxtcambioDv.Text; }
            else if (DGVenta.Columns[e.ColumnIndex].Name == "subtotal")
            {
                DGVenta.CurrentRow.Cells["subtotal"].Value = Decimal.Round(Convert.ToDecimal(DGVenta.CurrentRow.Cells["subtotal"].Value), 2);
                cantidad = Decimal.Round(Convert.ToDecimal(DGVenta.CurrentRow.Cells["subtotal"].Value) / Convert.ToDecimal(DGVenta.CurrentRow.Cells["precio"].Value), 2);
                DGVenta.CurrentRow.Cells["cantidad"].Value = cantidad.ToString("0.00");
                DGVenta.CurrentRow.Cells["Calculo"].Value = "subtotal";

            }

            //Convert.ToDecimal(row.Cells["Precio"].Value);
            // TxtcambioDv.Visible = false;
            totales();
            //dataGridView1.CurrentRow.Cells["idarticulo"].Value
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
       
      
      

    }
}
