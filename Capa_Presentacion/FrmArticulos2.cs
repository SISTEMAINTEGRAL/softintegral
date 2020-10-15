using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Capa_negocio;
using Capa_Presentacion.DataSet;
using System.Diagnostics;
using Capa_Datos;

namespace Capa_Presentacion
{
    public partial class FrmArticulos2 : Form
    {
        //campos
        //en el caso de que guarde una articulo nuevo o editado
        private int opcionvista = 1;
        private int codigoarticulo;
        private DatosArticulo objarticulo;

        public int Codigoarticulo
        {
            get { return codigoarticulo; }
            set { codigoarticulo = value; }
        }
        public int Opcionvista
        {
            get { return opcionvista; }
            set { opcionvista = value; }
        }
        private bool isNuevo, isEditar;
        
        public FrmArticulos2()
        {
            InitializeComponent();
            
             
        }

        public FrmArticulos2(int varopcionvista)
        {
            opcionvista = varopcionvista;
        
        }
        private void FrmArticulos_Load(object sender, EventArgs e)
        {
            if (NegocioConfigEmpresa.confsistema("codigointernoproducto").ToString() == "True")
            {
                ChkCodInterno.Visible = true;
                ChkCodInterno.Checked = true;
            }
            else
            {
                ChkCodInterno.Visible = false;

            }

            llenarComboBoxCategoria(cbxCategoria,"idcategoria","nombre", NegocioCategoria.mostrar());
           llenarComboBoxCategoria(cbCategoria,"idcategoria","nombre", NegocioCategoria.mostrar());
           dataLista.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
           
           isEditar = false;
           isNuevo= false;
           //this.mostrar();
           mensajesDeAyuda();
            CBIVA.SelectedIndex = 2;


            //CBIVA.ValueMember = "0";
          this.tabControl1.SelectedIndex = 0;

        this.txtNombre.Select();

        this.txtNombre.Focus();
         
          // txtNombre.TextChanged += new EventHandler(txtNombre_TextChanged);

      
         
        }


        public void pintarProductoSinStock() {
            decimal stock=0;
            foreach (DataGridViewRow row in dataLista.Rows)
            {
                
                stock =Convert.ToDecimal( row.Cells["stock_actual"].Value);
                if(stock<0){
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        
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
            btnCerrar.BackColor = Color.FromArgb(0, 100, 200);
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
            btnMaximizar.BackColor = Color.FromArgb(0, 100, 200);
        }
        private void btnMinimizar_MouseMove(object sender, MouseEventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(65, 39, 60);
        }
        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(0, 100, 200);

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

        /*Metodos Propios*/
        public void mostrar()
        {
            try
            {
                
                // this.dataLista.DataSource = NegocioArticulo.mostrar();
                if (dataLista.Rows.Count != 0)
                {
                    this.dataLista.Columns["precio_compra"].DefaultCellStyle.Format = String.Format("$###,##0.00");
                    this.dataLista.Columns["precio"].DefaultCellStyle.Format = String.Format("$###,##0.00");
                    this.dataLista.Columns["stock_actual"].DefaultCellStyle.Format = String.Format("###,##0.00");
                   
                    this.dataLista.Columns["idcategoria"].Visible = false;


                    pintarProductoSinStock();
                }
               
            }
            catch (Exception ex)
            {
                UtilityFrm.mensajeError("error con la Base de datos: " + ex.Message);
            }
            //datasource el origen de los datos,muestra las categorias en la grilla

            //oculto las dos primeras columnas
            this.ocultarColumnas();
            //muestro el total de las categorias
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataLista.RowCount);
            
        }
        private void ocultarColumnas()
        {
            //no muestro la columna eliminar categoria
            this.dataLista.Columns[0].Visible = false;

        }
        private void BuscarNombre()
        {
            try
            {
                this.dataLista.DataSource = NegocioArticulo.buscarNombre(this.txtNombre.Text,chkDescripcion.Checked == true ? txtDes.Text:"",chkcategoria.Checked == true ? cbCategoria.Text: "");
                pintarProductoSinStock();
            }

            catch (Exception ex)
            {
                UtilityFrm.mensajeError("Error Con Base de Datos :" + ex.Message);

            }
            //datasource el origen de los datos 

            //oculto las dos primeras columnas
            this.ocultarColumnas();
            //muestro el total de las categorias
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataLista.RowCount);

        }
        private void buscarcodigo()
        {
            dataLista.DataSource = NegocioArticulo.buscarIdProducto(txtNombre.Text );
            pintarProductoSinStock();
        }
        private void generarCodigoBarra() {
            
            bool cambiarcodigobarra = false;
            NegocioArticulo objart = new NegocioArticulo();
            string codigoBarra ="";
            try
            {
                do
                {
                    if (cambiarcodigobarra == true)
                    {
                        codigoBarra = Convert.ToString(Convert.ToInt32(codigoBarra) + 1);
                    }
                    else
                    {
                        codigoBarra = NegocioArticulo.obtenerIdArticulo().ToString();
                    }


                    codigoBarra = codigoBarra.PadLeft(12, '0');
                    int codigoControl = NegocioArticulo.calcDigControl(codigoBarra);
                    txtCodigoBarra.Text = codigoBarra + codigoControl;
                    objart.extraerdatos(0, "porbarra", txtCodigoBarra.Text);
                    cambiarcodigobarra = true;

                } while (objart.Sindatos == true);
                
            }
            catch (FormatException ex)
            {
                UtilityFrm.mensajeError("No se a podido generar codigo Barra:" + ex.Message);
            }
            catch (Exception ex)
            {
                UtilityFrm.mensajeError("Error:" + ex.Message);
            }
        
        }
        private void BuscarCodigoBarra() {
            try
            {
                this.dataLista.DataSource = NegocioArticulo.buscarCodigoBarra(this.txtNombre.Text);
                pintarProductoSinStock();
            }

            catch (Exception ex)
            {
                UtilityFrm.mensajeError("Error Con Base de Datos :" + ex.Message);

            }
            //datasource el origen de los datos 

            //oculto las dos primeras columnas
            this.ocultarColumnas();
            //muestro el total de las categorias
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataLista.RowCount);
        
        }
        private void BuscarCategoria()
        {
            try
            {
                this.dataLista.DataSource = NegocioArticulo.buscarCategoria(this.txtNombre.Text);
                pintarProductoSinStock();
            }

            catch (Exception ex)
            {
                UtilityFrm.mensajeError("Error Con Base de Datos :" + ex.Message);

            }
            //datasource el origen de los datos 

            //oculto las dos primeras columnas
            this.ocultarColumnas();
            //muestro el total de las categorias
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataLista.RowCount);

        }
        //muestra en el combobox los resultados cargados en categoria
        private void llenarComboBoxCategoria(ComboBox combo, string valuemember, string displaymember, DataTable midatatable) {
            combo.DataSource = midatatable;
            //valor real de la DB
             
            combo.ValueMember = valuemember;
            //lo que se muestra
            combo.DisplayMember = displaymember;
        
        }
        

        //mensajes de ayuda
        private void mensajesDeAyuda()  
        {

            //mensaje de ayuda en el textbox nombre
            this.ttMensajeAyuda.SetToolTip(this.txtNombre, "Ingrese el producto que desea buscar,(F1) para limpiar");
            //mensaje de ayuda en el textbox nombre
            this.ttMensajeAyuda.SetToolTip(this.txtNombreConfig, "Ingrese el nombre del producto");
            //mensaje de ayuda en el textbox nombre
            this.ttMensajeAyuda.SetToolTip(this.txtDescripcion, "Ingrese la descripción del producto");
            //mensaje de ayuda en el textbox codigoBarra
            this.ttMensajeAyuda.SetToolTip(this.txtCodigoBarra, "Ingrese el codigo de barra");
            //mensaje de ayuda del boton buscar
            this.ttMensajeAyuda.SetToolTip(this.btnBuscar, "Buscar por nombre de producto");
            //mensaje de ayuda del boton eliminar
            this.ttMensajeAyuda.SetToolTip(this.btnEliminar, "Borrar articulo");
            //mensaje de ayuda del boton Imprimir
            //this.ttMensajeAyuda.SetToolTip(this.btnImprimir, "imprime la lista de articulos");
            //mensaje de ayuda del boton nuevo codbar
            this.ttMensajeAyuda.SetToolTip(this.btnNuevoCodBar, "Crear un nuevo Codigo de barra");
            //mensaje de ayuda del boton nuevo codbar
            this.ttMensajeAyuda.SetToolTip(this.txtPrecio, "Ingrese un precio con los decimales correspondientes");
            //mensaje de ayuda en el textbox cantInicial
            this.ttMensajeAyuda.SetToolTip(this.txtCantInicial, "Ingrese el stock inicial para un producto");
        }
       
        /*EVENTOS*/
        //textBox
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buscar ()
        {


            if (txtNombre.Text != "")
            {
                txtNombre.Text = txtNombre.TextLength == 12 && IsNumeric(txtNombre.Text) ? "0" + txtNombre.Text : txtNombre.Text;
                if (ChkCodInterno.Checked == true)
                {
                    //por codigointerno
                    dataLista.DataSource = NegocioArticulo.buscarCodigoBarra(txtNombre.Text,17);

                    txtNombre.Focus();
                    txtNombre.SelectAll();
                    if (dataLista.Rows.Count != 0)
                    {
                        textBox1.Text = decimal.Round(Convert.ToDecimal(this.dataLista.CurrentRow.Cells["Precio"].Value), 2).ToString();
                    }
                }
                else if (txtNombre.TextLength >= 8 && IsNumeric(txtNombre.Text) == true)
                {
                    dataLista.DataSource = NegocioArticulo.buscarCodigoBarra(txtNombre.Text);

                    txtNombre.Focus();
                    txtNombre.SelectAll();
                    textBox1.Text = decimal.Round(Convert.ToDecimal(this.dataLista.CurrentRow.Cells["Precio"].Value), 2).ToString();
                }
                else if (IsNumeric(txtNombre.Text) == true)
                {
                    dataLista.DataSource = NegocioArticulo.buscarIdProducto(txtNombre.Text);
                    txtNombre.Focus();
                    txtNombre.SelectAll();
                    if (dataLista.RowCount != 0)
                    {
                        textBox1.Text = decimal.Round(Convert.ToDecimal(this.dataLista.CurrentRow.Cells["Precio"].Value), 2).ToString();
                    }

                }

                else
                {
                    this.BuscarNombre();
                }

                if (dataLista.RowCount != 0)
                {
                    this.dataLista.Columns["precio_compra"].DefaultCellStyle.Format = String.Format("$###,##0.00");
                    this.dataLista.Columns["precio"].DefaultCellStyle.Format = String.Format("$###,##0.00");
                    this.dataLista.Columns["stock_actual"].DefaultCellStyle.Format = String.Format("###,##0.00");
                    //this.dataLista.Columns["flete"].DefaultCellStyle.Format = String.Format("%0.00");
                    // this.dataLista.Columns["utilidad"].DefaultCellStyle.Format = String.Format("%0.00");
                }

            }

        }
        /*Botones*/
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //limpio textbox
            UtilityFrm.limpiarTextbox(txtDescripcion, txtNombreConfig, txtNombre, txtCodigo,txtCodigoBarra,txtUtilidad );
            //habilitar botones
            inicializartextbox();
            habilitarcontroles(false, true,true);
            //this.cbxPesable.Enabled = true;
            //this.btnGuardar.Enabled = true;
            //this.btnEditar.Enabled = false;
            //this.btnCancelar.Enabled = true;
            //this.btnNuevo.Enabled = false;
            //this.btnNuevoCodBar.Enabled = true;
            //this.cbxCategoria.Enabled = true;
            ////this.cbxCategoria.Text = "";
            ////habilitar textbox
            //this.txtCodigoBarra.Enabled = true;
            //this.txtPrecio.Enabled = true;
            //this.txtDescripcion.Enabled = true;
            //this.txtNombreConfig.Enabled = true;
            //this.txtCantInicial.Enabled = true;
          
            this.txtCodigoBarra.Focus();
            isEditar = false;
            isNuevo = true;
            generarCodigoBarra();
            txtCodigoBarra.SelectAll();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitarcontroles(true, false);
            
            UtilityFrm.limpiarTextbox(txtDescripcion, txtNombreConfig, txtNombre, txtCodigo, txtCodigoBarra, txtCantInicial);
            UtilityFrm.limpiarTextbox(txtPrecio,TxtPcompra,txtUtilidad);
            inicializartextbox();
            UtilityFrm.limpiarErrorProvider(txtPrecio,txtNombreConfig,txtCantInicial, errorIcono);
            
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DataTable dataproducto = new DataTable();
            try
            {
                string respuesta = "";
                //if (String.IsNullOrEmpty(txtPrecio.Text))
                //{

                //}
                //si el string es nulo o vacio 
                
                if (String.IsNullOrEmpty(txtNombreConfig.Text) || String.IsNullOrEmpty(txtPrecio.Text) || String.IsNullOrEmpty(txtCantInicial.Text) || String.IsNullOrEmpty(txtUtilidad.Text) || String.IsNullOrEmpty(TxtPcompra.Text) || String.IsNullOrEmpty(Txtflete.Text) )
                {
                    UtilityFrm.mensajeError("Hay Campos sin completar,rellene y vuelva a intentarlo");
                   
                    if(txtNombreConfig.Text.Length==0){ errorIcono.SetError(txtNombreConfig, "Ingrese un Nombre de Producto");}
                    if (txtPrecio.Text.Length == 0) { errorIcono.SetError(txtPrecio, "Ingrese un Precio"); }
                    if (txtCantInicial.Text.Length == 0) { errorIcono.SetError(txtCantInicial, "Ingrese una Cantidad Inicial"); }    
                    
                
                }
                else
                {
                    int pesable = cbxPesable.Checked == true ? 1 : 0;
                    if (isNuevo == true)
                    {
                        dataproducto = NegocioArticulo.buscarCodigoBarra(txtCodigoBarra.Text);

                        if (dataproducto.Rows.Count > 0)
                        {
                            UtilityFrm.mensajeError("El codigo de barra que intenta ingresar ya se encuentra agregado al sistema");
                            return;
                        }

                        objarticulo = new DatosArticulo();
                        //pesable es un bit que representa un producto si es pesable (KG) o no
                        objarticulo.Nombre = txtNombreConfig.Text.Trim();
                        objarticulo.Codigo = txtCodigoBarra.Text.Trim();
                        objarticulo.Descripcion = txtDescripcion.Text.Trim();
                        objarticulo.IdCategoria = Convert.ToInt32(cbxCategoria.SelectedValue);
                        objarticulo.Precio = Convert.ToDecimal(txtPrecio.Text.Trim());
                        objarticulo.StockActual = Convert.ToInt32(txtCantInicial.Text.Trim());
                        objarticulo.Pesable = pesable;
                        objarticulo.PrecioCompra = Convert.ToDecimal(TxtPcompra.Text);
                        objarticulo.Utilidad = Convert.ToDecimal(txtUtilidad.Text);
                        objarticulo.Flete = Convert.ToDecimal(Txtflete.Text);
                        objarticulo.Cantidadpormayor = Convert.ToDecimal(txtCantidadpormayor.Text);
                        objarticulo.Preciopormayor = Convert.ToDecimal(txtPreciopormayor.Text);
                        objarticulo.Idsubcategoria = Convert.ToInt32(CBSubcategoria.SelectedValue);
                        objarticulo.Iva = Convert.ToDecimal(CBIVA.Text == "" ? "0":CBIVA.Text );
                        objarticulo.Fecha = DateTime.Now;
                        objarticulo.Fecha_oferta = DateTime.Now;
                        objarticulo.Cantidadpormayor2 = Convert.ToDecimal(TxtCanPromo.Text);
                        objarticulo.Preciopormayor2 = Convert.ToDecimal(TxtPrecioPromo.Text);
                        objarticulo.Modo = 1;
                        objarticulo.Stock_minimo = Convert.ToDecimal(txtStock_minimo.Text);
                        objarticulo.Codigointerno = TxtCodinterno.Text;
                        respuesta = objarticulo.agregar(objarticulo, NegocioConfigEmpresa.confsistema("opcionsistema").ToString());
                        //respuesta = NegocioArticulo.insertar(txtNombreConfig.Text.Trim(), txtCodigoBarra.Text.Trim(), txtDescripcion.Text.Trim(),
                        //    Convert.ToInt32(cbxCategoria.SelectedValue), Convert.ToDecimal(txtPrecio.Text.Trim()),
                        //    Convert.ToInt32(txtCantInicial.Text.Trim()),
                        //    pesable,Convert.ToDecimal(TxtPcompra.Text),Convert.ToDecimal(txtUtilidad.Text),
                        //    Convert.ToDecimal (Txtflete.Text),Convert.ToDecimal(txtCantidadpormayor.Text),Convert.ToDecimal(txtPreciopormayor.Text)
                        //    ,Convert.ToInt32(CBSubcategoria.SelectedValue),Convert.ToDecimal (CBIVA.Text));

                        if (respuesta.Equals("ok"))
                        {
                            buscar();
                            UtilityFrm.mensajeConfirm("Se Agregó Correctamente");
                            this.mostrar();
                            isEditar = false;
                            isNuevo = false;
                            UtilityFrm.limpiarErrorProvider(txtCantInicial,txtNombreConfig,txtPrecio,errorIcono);
                        }
                        else
                        {
                            UtilityFrm.mensajeError(respuesta);
                        }


                    }
                    //si se va a editar
                    else if (isEditar == true)
                    {

                        //respuesta = NegocioArticulo.editar(Convert.ToInt32(txtCodigo.Text.Trim()), Convert.ToString(txtNombreConfig.Text.Trim()), txtCodigoBarra.Text.Trim(), Convert.ToString(txtDescripcion.Text.Trim()), Convert.ToInt32(cbxCategoria.SelectedValue));
                        objarticulo = new DatosArticulo();
                        objarticulo.Nombre = txtNombreConfig.Text.Trim();
                        objarticulo.IdArticulo = Convert.ToInt32(txtCodigo.Text.Trim());
                        objarticulo.Codigo = txtCodigoBarra.Text.Trim();
                        objarticulo.Descripcion = txtDescripcion.Text.Trim();
                        objarticulo.IdCategoria = Convert.ToInt32(cbxCategoria.SelectedValue);
                        objarticulo.Precio = Convert.ToDecimal(txtPrecio.Text.Trim());
                        objarticulo.StockActual = Convert.ToDecimal(txtCantInicial.Text.Trim());
                        objarticulo.Pesable = pesable;
                        objarticulo.PrecioCompra = Convert.ToDecimal(TxtPcompra.Text);
                        objarticulo.Utilidad = Convert.ToDecimal(txtUtilidad.Text);
                        objarticulo.Flete = Convert.ToDecimal(Txtflete.Text == "" ? "0" : Txtflete.Text);
                        objarticulo.Fecha = DateTime.Now;
                        objarticulo.Editarusuario = NegocioConfigEmpresa.idusuario;
                        objarticulo.Editarlugar = "formulario articulo";
                        objarticulo.Cantidadpormayor = Convert.ToDecimal(txtCantidadpormayor.Text);
                        objarticulo.Preciopormayor = Convert.ToDecimal(txtPreciopormayor.Text);
                        objarticulo.Cantidadpormayor2 = Convert.ToDecimal(TxtCanPromo.Text);
                        objarticulo.Preciopormayor2 = Convert.ToDecimal(TxtPrecioPromo.Text);
                        objarticulo.Idsubcategoria = Convert.ToInt32(CBSubcategoria.SelectedValue);
                        objarticulo.Iva = Convert.ToDecimal(CBIVA.Text);
                        objarticulo.Stock_minimo = Convert.ToDecimal(txtStock_minimo.Text);
                        objarticulo.Codigointerno = TxtCodinterno.Text;
                        objarticulo.Modo = 2;

                      respuesta =  objarticulo.editar(objarticulo, "negocio");

                        //respuesta = NegocioArticulo.editar(Convert.ToInt32(txtCodigo.Text.Trim()), Convert.ToString(txtNombreConfig.Text.Trim()), 
                        //    txtCodigoBarra.Text.Trim(), Convert.ToString(txtDescripcion.Text.Trim()), Convert.ToInt32(cbxCategoria.SelectedValue), 
                        //    Convert.ToDecimal(txtPrecio.Text.Trim()), Convert.ToDecimal(txtCantInicial.Text.Trim()), pesable,
                        //    Convert.ToDecimal(TxtPcompra.Text),Convert.ToDecimal(txtUtilidad.Text)
                        //    ,Convert.ToDecimal (Txtflete.Text == "" ? "0":Txtflete.Text),DateTime.Now,NegocioConfigEmpresa.idusuario,
                        //    "formulario articulo",Convert.ToDecimal(txtCantidadpormayor.Text),Convert.ToDecimal(txtPreciopormayor.Text),
                        //    Convert.ToInt32(CBSubcategoria.SelectedValue), Convert.ToDecimal(CBIVA.Text));



                        if (respuesta.Equals("ok"))
                        {
                            UtilityFrm.mensajeConfirm("Se Editó Correctamente");
                            buscar();
                            this.mostrar();
                            isEditar = false;
                            isNuevo = false;

                        }
                        else
                        {
                            UtilityFrm.mensajeError(respuesta);
                        }

                    }
                    else
                    {
                        UtilityFrm.mensajeError("No se ha podido guardar: " + respuesta);

                    }

                    //habilito el codigo para poder editar
                    habilitarcontroles(true,false);
                    UtilityFrm.limpiarTextbox(txtDescripcion, txtNombreConfig, txtNombre, txtCodigo, txtCodigoBarra, txtCantInicial);
                    UtilityFrm.limpiarTextbox(txtPrecio,txtUtilidad,TxtPcompra,Txtflete);
                    inicializartextbox();
                    UtilityFrm.limpiarErrorProvider(txtCantInicial, txtPrecio, txtNombreConfig,errorIcono);
                    this.btnNuevo.Focus();

                }



            }
            catch (Exception ex)
            {
                UtilityFrm.mensajeError("error: " + ex.Message + " ;" + ex.StackTrace);
                isEditar = false;
                isNuevo = false;
            }
            

        }

        private void inicializartextbox()
        {
            TxtPcompra.Text = "0";
            txtUtilidad.Text = "0";
            Txtflete.Text = "0";
            txtPrecio.Text = "0";
            txtPreciopormayor.Text = "0";
            txtCantidadpormayor.Text = "0";
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            
                habilitarcontroles(false, true);
                
            
        }

        private void habilitarcontroles(bool var1, bool var2, bool habcantinicial = false)
        {
            //this.btnNuevo.loke = var1;
            
            btnNuevo.Enabled = var1;
            isNuevo = var1;
            this.btnEditar.Enabled = var1;
            txtCantInicial.Enabled = var1;
            txtUtilidad.Enabled = var2;
            Txtflete.Enabled = var2;
            TxtPcompra.Enabled = var2;
            txtPrecio.Enabled = var2;
            cbxPesable.Enabled = var2;
            txtPreciopormayor.Enabled = var2;
            txtCantidadpormayor.Enabled = var2;
            TxtPrecioPromo.Enabled = var2;
            TxtCanPromo.Enabled = var2;
            CBSubcategoria.Enabled = var2;
            isEditar = var2;
            this.btnNuevoCodBar.Enabled = var2;
            txtPrecio.Enabled =var2;
            txtNombreConfig.Enabled = var2;
            txtCodigoBarra.Enabled = var2;
            txtDescripcion.Enabled = var2;
            this.cbxCategoria.Enabled = var2;
            this.btnCancelar.Enabled = var2;
            this.btnGuardar.Enabled = var2;
            this.CBIVA.Enabled = var2;
            txtStock_minimo.Enabled = var2;
            TxtCodinterno.Enabled = var2;

            this.txtCantInicial.Enabled = habcantinicial;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string respuesta = "";
            try
            {

                //si la respuesta es si elimina la fila actual
                if (MessageBox.Show("Seguro que desea Eliminar?", "Eliminar"
                   , MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    /*eliminar varias categoria*/
                    if (chkEliminar.Checked == true)
                    {
                        foreach (DataGridViewRow row in dataLista.Rows)
                        {
                            //Si la fila esta marcada lo elimina
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {

                                //le paso el idcategoria para poder eliminarlo
                                objarticulo.IdArticulo = Convert.ToInt32(row.Cells[1].Value);
                                respuesta = objarticulo.eliminar(objarticulo);
                                if (respuesta.Equals("ok"))
                                {
                                    UtilityFrm.mensajeConfirm(row.Cells[3].Value.ToString() +" Se Eliminó Correctamente");
                                }
                                else
                                {

                                    UtilityFrm.mensajeError("Error: " + respuesta);
                                }

                            }
                        }


                    }
                    else
                    {
                        /*eliminar un solo producto*/
                        respuesta = NegocioArticulo.eliminar(Convert.ToInt32(this.dataLista.CurrentRow.Cells[1].Value));
                        if (respuesta.Equals("ok"))
                        {
                            UtilityFrm.mensajeConfirm(dataLista.CurrentRow.Cells[3].Value.ToString() + " se eliminó correctamente");
                        }
                        else
                        {

                            UtilityFrm.mensajeError("Error: " + respuesta);
                        }


                    }
                    mostrar();
                }
                //desabilito el checkbox y el boton eliminar
                chkEliminar.Checked = false;
                btnEliminar.Enabled = false;
            }
            catch (Exception ex)
            {
                UtilityFrm.mensajeError("Error: " + respuesta + ", " + ex.Message);
            }

        }       
      
        
        //checkBox
        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
             //   dataLista.Columns[0].Width = 100;
                if (chkEliminar.Checked == true)
                {
                    this.dataLista.Columns[0].Visible = true;

                }
                else
                {
                    this.dataLista.Columns[0].Visible = false;
                }
            }
            catch (Exception s)
            {

                UtilityFrm.mensajeError(s.Message);
            }
           
        }

        //TabControl
        private void tabControl1_Selected_1(object sender, TabControlEventArgs e)
        {
            //si selecciono el tabLista borro los textbox y button
            if (tabControl1.SelectedIndex == 0)
            {
                txtCodigo.Text = string.Empty;
                txtCodigoBarra.Text = string.Empty;
                txtDescripcion.Text = string.Empty;
                txtNombreConfig.Text = string.Empty;
                txtPrecio.Text = string.Empty;
                txtCantInicial.Text= string.Empty;
                cbxCategoria.Enabled = false;
                btnEditar.Enabled = false;
                btnNuevo.Enabled = true;
                btnGuardar.Enabled = false;
                btnCancelar.Enabled = false;
                txtPrecio.Enabled = false;
                txtCantInicial.Enabled = false;
                txtNombreConfig.Enabled = false;
                txtCodigoBarra.Enabled = false;
                txtDescripcion.Enabled = false;
                btnNuevoCodBar.Enabled = false;
                errorIcono.Clear();

                this.txtNombre.Select();

                this.txtNombre.Focus();
            }
            if (tabControl1.SelectedIndex == 1)
            {
                btnEliminar.Enabled = false;
            }
        }
       
        //lista de datos
        private void dataLista_DoubleClick(object sender, EventArgs e)
        {
            

            if (opcionvista == 1)
            {

                this.btnNuevo.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = true;
                string temporal = string.Empty;
                //para editar categoria lleva a la caja de texto de configuracion
                txtCodigo.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["idarticulo"].Value);
                txtCodigoBarra.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["codigo"].Value);
                cbxCategoria.SelectedValue = Convert.ToString(this.dataLista.CurrentRow.Cells["idcategoria"].Value);
              //  CBSubcategoria.SelectedValue = Convert.ToString(this.dataLista.CurrentRow.Cells["idsubcategoria"].Value);
                txtNombreConfig.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["nombre"].Value);
                txtDescripcion.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["descripcion"].Value);
                txtUtilidad.Text = Convert.ToString(decimal.Round(Convert.ToDecimal(this.dataLista.CurrentRow.Cells["utilidad"].Value), 2));
                TxtPcompra.Text = Convert.ToString(decimal.Round(Convert.ToDecimal(this.dataLista.CurrentRow.Cells["precio_compra"].Value), 2));
                txtStock_minimo.Text = Convert.ToString(decimal.Round(Convert.ToDecimal(this.dataLista.CurrentRow.Cells["stock_minimo"].Value), 2));
                TxtCodinterno.Text = this.dataLista.CurrentRow.Cells["codigointerno"].Value.ToString();
                decimal precio = 0;
                precio = Convert.ToDecimal(this.dataLista.CurrentRow.Cells["precio"].Value);
                string iva  =Convert.ToString( UtilityFrm.formateodecimal ( Convert.ToDecimal(this.dataLista.CurrentRow.Cells["iva"].Value), 2));
                if (iva == "0")
                {
                    CBIVA.SelectedIndex = 0;
                }
                if (iva == "10,50")
                {
                    CBIVA.SelectedIndex = 1;
                }
                if (iva == "21,00")
                {
                    CBIVA.SelectedIndex = 2;
                }
                txtPrecio.Text = Convert.ToString(Decimal.Round(precio, 2));
                txtCantInicial.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["stock_actual"].Value);
                txtPreciopormayor.Text =UtilityFrm.formateodecimal(Convert.ToDecimal(this.dataLista.CurrentRow.Cells["preciopormayor"].Value),2);
                txtCantidadpormayor.Text = Convert.ToString( Convert.ToDecimal(this.dataLista.CurrentRow.Cells["cantidadpormayor"].Value));
                TxtCanPromo.Text = Convert.ToString(decimal.Round(Convert.ToDecimal(this.dataLista.CurrentRow.Cells["cantidadpormayor2"].Value), 2));
                TxtPrecioPromo.Text = Convert.ToString(decimal.Round(Convert.ToDecimal(this.dataLista.CurrentRow.Cells["preciopormayor2"].Value), 2));
                CBSubcategoria.SelectedValue = Convert.ToString(this.dataLista.CurrentRow.Cells["idsubcategoria"].Value);
                cbxPesable.Checked = Convert.ToBoolean(this.dataLista.CurrentRow.Cells["pesable"].Value);
                this.tabControl1.SelectedTab = tabConfiguracion;
            }
            else if (opcionvista == 2)
            {
                codigoarticulo = Convert.ToInt32(this.dataLista.CurrentRow.Cells["idarticulo"].Value);
                this.Close();
            }
            
        }
        private void dataLista_Click_1(object sender, EventArgs e)
        {
            btnEliminar.Enabled = true;
        }
        private void dataLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try {	        
            //se produce un evento cuando hago click en la columna 0 que es eliminar de la lista
            //se comparan el indice de columna de la lista =0 y el indice de la columna del evento=0
                if (e.ColumnIndex == dataLista.Columns[0].Index && e.RowIndex>= 0)
            {
                //creo una datagridviewrow para guarda los datos de la fila actual
                DataGridViewRow fila = dataLista.Rows[e.RowIndex];
                //creo un checkboxcell para obtener el checkbox seleccionado
                DataGridViewCheckBoxCell tildado = (DataGridViewCheckBoxCell)fila.Cells[0];


                if (Convert.ToBoolean(tildado.Value) == true)
                {
                    //si el valor de tildado es null es true y se desactiva 
                    tildado.Value = CheckState.Unchecked;

                }
                else
                {
                    //caso contrario se activa
                    tildado.Value = CheckState.Checked;
                }

              }
           }
            catch (Exception ex)
            {
                UtilityFrm.mensajeError("Has seleccionado una Opcion Incorrecta, el Origen es: " + ex.Message);
               
            }
        }

        private void txtCodigoBarra_KeyDown(object sender, KeyEventArgs e)
        {
            //comparo el evento pasado como parametro y el enum keys.enter
            if (e.KeyCode == Keys.Enter)
            {
                this.txtNombreConfig.Focus();
                //se pasa el control permitiendo eliminar el beep
                e.SuppressKeyPress = true;
            }
        }

        private void txtNombreConfig_KeyDown(object sender, KeyEventArgs e)
        {
            //comparo el evento pasado como parametro y el enum keys.enter
            if (e.KeyCode == Keys.Enter)
            {
                this.txtDescripcion.Focus();
                //se pasa el control permitiendo eliminar el beep
                e.SuppressKeyPress = true;
            }
        }

        private void cbxCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            //comparo el evento pasado como parametro y el enum keys.enter
            if (e.KeyCode == Keys.Enter)
            {
                this.txtPrecio.Focus();
                //se pasa el control permitiendo eliminar el beep
                e.SuppressKeyPress = true;
            }
        }

     

        private void tabConfiguracion_Click(object sender, EventArgs e)
        {
            this.btnNuevo.Focus();
        }

        private void tabConfiguracion_MouseClick(object sender, MouseEventArgs e)
        {
            this.btnNuevo.Focus();
        }


        private void calculo()
        { 
           
        
        }

        private void btnGenerarCodigo_Click(object sender, EventArgs e)
        {
            //FrmEtiquetas codigoBarra = new FrmEtiquetas();
            //codigoBarra.ShowDialog();
            try
            {
                if (tabControl1.SelectedTab == tabConfiguracion)
                {
                    if (txtCodigoBarra.Text.Length == 13)
                    {
                        FrmImpEtiquetas etiqueta = new FrmImpEtiquetas(txtNombreConfig.Text, txtCodigoBarra.Text, 1, Convert.ToInt32(txtCodigo.Text));
                        etiqueta.ShowDialog();
                    }
                }
                else if (tabControl1.SelectedTab == tabLista)
                {
                    if (this.dataLista.CurrentRow.Cells[2].Value.ToString().Length == 13)
                    {
                        FrmImpEtiquetas etiqueta = new FrmImpEtiquetas(this.dataLista.CurrentRow.Cells[3].Value.ToString(), this.dataLista.CurrentRow.Cells[2].Value.ToString(), 1, Convert.ToInt32(this.dataLista.CurrentRow.Cells[1].Value));
                        etiqueta.ShowDialog();
                    }
                    else
                    {
                        string nuevocodigo = UtilityFrm.agregarcodigobarra(this.dataLista.CurrentRow.Cells[2].Value.ToString());
                        NegocioArticulo.editarcodigobarra(Convert.ToInt32(this.dataLista.CurrentRow.Cells[1].Value), nuevocodigo);
                        FrmImpEtiquetas etiqueta = new FrmImpEtiquetas(this.dataLista.CurrentRow.Cells[3].Value.ToString(), nuevocodigo, 1, Convert.ToInt32(this.dataLista.CurrentRow.Cells[1].Value));
                        etiqueta.ShowDialog();
                        buscar();
                    }


                }
            }
            catch (Exception s)
            {

                UtilityFrm.mensajeError(s.Message);
            }
                
            
           
            
        }

        private void txtPrecio_KeyDown(object sender, KeyEventArgs e)
        {
         
            //comparo el evento pasado como parametro y el enum keys.enter
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCantInicial.Enabled == true)
                {
                    
                    txtCantInicial.Focus();
                }
                else {

                    this.btnGuardar.Focus();
                
                }

                //si el usuario no ingreso los decimales se agregan los ceros correspondientes
                if (txtPrecio.Text.Length > 0 && !txtPrecio.Text.Contains(","))
                {
                    txtPrecio.Text += ",00";

                }
                //se pasa el control permitiendo eliminar el beep
                e.SuppressKeyPress = true;
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
                 
              
                txtCodigoBarra.Text =  UtilityFrm.agregarcodigobarra(txtCodigoBarra.Text);
              

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            
            FrmImpArticulo impArt = new FrmImpArticulo(dataLista);
            impArt.ShowDialog();
            
        }


       

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo valores numericos

            UtilityFrm.NumDecTeclado(e,txtPrecio);
        }

        private void txtCodigoBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilityFrm.NumTeclado(e, txtCodigoBarra);
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            UtilityFrm.limpiarErrorProvider(txtPrecio,errorIcono);
            if (txtPrecio.Text.Length > 0 && txtPrecio.Text[0] == ',')
            {
                
                txtPrecio.Text = "";
            }
            else if(txtPrecio.Text.Length==0) {
                errorIcono.SetError(txtPrecio,"Es necesario un valor Numerico en el campo Precio");
            }
        }

        private void txtCantInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilityFrm.NumTeclado(e,txtCantInicial);
        }

        private void txtCodigoBarra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCantInicial_TextChanged(object sender, EventArgs e)
        {
            UtilityFrm.limpiarErrorProvider(txtCantInicial, errorIcono);
            if(txtCantInicial.Text.Length==0) {
                errorIcono.SetError(txtCantInicial,"Es necesario un valor Numerico en el campo Cantidad Inicial");
            }
        }

        private void txtNombreConfig_TextChanged(object sender, EventArgs e)
        {
            UtilityFrm.limpiarErrorProvider(txtNombreConfig, errorIcono);
            if (txtNombreConfig.Text.Length == 0)
            {
                errorIcono.SetError(txtNombreConfig, "Es necesario un nombre de producto");
            }
        }

        private void rdbNombre_CheckedChanged(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }

        private void rdbCodigoBarra_CheckedChanged(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }

        private void rbCategoria_CheckedChanged(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }

        private void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            //comparo el evento pasado como parametro y el enum keys.enter
            if (e.KeyCode == Keys.Enter)
            {
                this.cbxCategoria.Focus();
                //se pasa el control permitiendo eliminar el beep
                e.SuppressKeyPress = true;
            }
        }

        private void FrmArticulos_KeyDown(object sender, KeyEventArgs e)
        {
            //comparo el evento pasado como parametro y el enum keys.enter
            if (e.KeyCode == Keys.F1)
           {
                this.txtNombre.Focus();
                txtNombre.Text = "";
               
            }
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                //pasa a la lista el foco 
                dataLista.Focus();

            }
            if (e.KeyCode == Keys.Down)
            {
                //pasa a la lista el foco 
                dataLista.Focus();

            }
            if (e.KeyCode == Keys.Enter)
            {


                //se pasa el control permitiendo eliminar el beep
                e.SuppressKeyPress = true;


                try
                {
                    buscar();
                    //txtNombreProducto.Focus();
                }
                catch (Exception ex)
                {

                    UtilityFrm.mensajeError("Error: " + ex.Message);
                }

            }
        }
        public bool IsNumeric(string input)
        {
            long test;

            return long.TryParse(input, out test);
        }
        private void txtCantInicial_KeyDown(object sender, KeyEventArgs e)
        {
            //comparo el evento pasado como parametro y el enum keys.enter
            if (e.KeyCode == Keys.Enter)
            {
                //this.btnGuardar.Focus();
                this.cbxPesable.Focus();
                //se pasa el control permitiendo eliminar el beep
                e.SuppressKeyPress = true;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelHorizontal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbxPesable_KeyDown(object sender, KeyEventArgs e)
        {
            //comparo el evento pasado como parametro y el enum keys.enter
            if (e.KeyCode == Keys.Enter)
            {
                this.btnGuardar.Focus();

                //se pasa el control permitiendo eliminar el beep
                e.SuppressKeyPress = true;
            }
        }

        private void tabLista_Click(object sender, EventArgs e)
        {

        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls";
                fichero.FileName = "Listado de productos de " + DateTime.Now.ToString("dd-MM-yyyy");
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application aplicacion;
                    Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                    Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                    aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    libros_trabajo = aplicacion.Workbooks.Add();
                    hoja_trabajo =
                        (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);

                    hoja_trabajo.Cells.Rows[1].Font.Bold = true;
                    hoja_trabajo.Cells.Rows[1].Font.Size = 15;
                    hoja_trabajo.Cells[1, 1] = "Listado de productos : " + DateTime.Now;


                    hoja_trabajo.Range[hoja_trabajo.Cells[1, 1], hoja_trabajo.Cells[1, 10]].Merge();


                    if (dataLista.Rows.Count > 0)
                    {
                        //le paso el formato adecuado para los valores decimales pasando desde la fila 3 hasta datalista.rows.count+1 osea hasta el ultimo elemento
                        hoja_trabajo.Range[hoja_trabajo.Cells[3, 6], hoja_trabajo.Cells[dataLista.Rows.Count + 2, 7]].NumberFormat = "0,00";

                        hoja_trabajo.Range[hoja_trabajo.Cells[3, 8], hoja_trabajo.Cells[dataLista.Rows.Count + 2, 8]].NumberFormat = "0,00";
                        hoja_trabajo.Range[hoja_trabajo.Cells[3, 9], hoja_trabajo.Cells[dataLista.Rows.Count + 2, 9]].NumberFormat = "0,00";
                        hoja_trabajo.Range[hoja_trabajo.Cells[3, 10], hoja_trabajo.Cells[dataLista.Rows.Count + 2, 10]].NumberFormat = "0,00";
                    }
                    //Recorremos el DataGridView rellenando la hoja de trabajo
                    for (int i = 1; i < dataLista.Columns.Count; i++)
                    {

                        hoja_trabajo.Cells[2, i] = dataLista.Columns[i].Name;
                    }


                    for (int i = 0; i < dataLista.Rows.Count - 1; i++)
                    {

                        hoja_trabajo.Cells[i + 3, 1] = dataLista.Rows[i].Cells["idarticulo"].Value.ToString();
                        hoja_trabajo.Cells[i + 3, 2] = dataLista.Rows[i].Cells["codigo"].Value.ToString();
                        hoja_trabajo.Cells[i + 3, 3] = dataLista.Rows[i].Cells["nombre"].Value.ToString();
                        hoja_trabajo.Cells[i + 3, 4] = dataLista.Rows[i].Cells["descripcion"].Value.ToString();
                        hoja_trabajo.Cells[i + 3, 5] = dataLista.Rows[i].Cells["idcategoria"].Value.ToString();
                        hoja_trabajo.Cells[i + 3, 6] = dataLista.Rows[i].Cells["categoria"].Value.ToString();
                        hoja_trabajo.Cells[i + 3, 7] = dataLista.Rows[i].Cells["stock_actual"].Value;
                        hoja_trabajo.Cells[i + 3, 8] = dataLista.Rows[i].Cells["utilidad"].Value;
                        hoja_trabajo.Cells[i + 3, 9] = dataLista.Rows[i].Cells["precio_compra"].Value;
                        hoja_trabajo.Cells[i + 3, 10] =dataLista.Rows[i].Cells["flete"].Value;
                        hoja_trabajo.Cells[i + 3, 11] = dataLista.Rows[i].Cells["precio"].Value;


                    }


         
                   

                    //ajustar el tamaño de las celdas deacuerdo al tamaño de las columnas agregadas
                    hoja_trabajo.Cells.Columns.AutoFit();
                    //guardo el archivo con la ruta del archivo
                    libros_trabajo.SaveAs(fichero.FileName,
                        Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    libros_trabajo.Close(true);
                    aplicacion.Quit();
                    if (MessageBox.Show("Desea abrir el Excel ?", "Abrir Excel"
                        , MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    {
                        Process.Start(fichero.FileName);
                    }

                }
            }
            catch (Exception ex)
            {

                UtilityFrm.mensajeError("Error: " + ex.Message);
            }

        }

        private void chkDescripcion_CheckedChanged(object sender, EventArgs e)
        {
            txtDes.Enabled = chkDescripcion.Checked;
        }

        private void chkcategoria_CheckedChanged(object sender, EventArgs e)
        {
            cbCategoria.Enabled = chkcategoria.Checked;
        }

        private void TxtPcompra_MouseClick(object sender, MouseEventArgs e)
        {
            TxtPcompra.SelectAll();
        }

        private void TxtPcompra_Click(object sender, EventArgs e)
        {
            TxtPcompra.SelectAll();
        }

        private void txtUtilidad_Click(object sender, EventArgs e)
        {
            txtUtilidad.SelectAll();
        }

        private void Txtflete_Click(object sender, EventArgs e)
        {
            Txtflete.SelectAll();
        }

        private void txtPrecio_Click(object sender, EventArgs e)
        {
            txtPrecio.SelectAll();
        }

        private void TxtPcompra_Leave(object sender, EventArgs e)
        {
            calcularventa(Convert.ToDecimal(string.IsNullOrEmpty( TxtPcompra.Text) ? TxtPcompra.Text = "0": TxtPcompra.Text), Convert.ToDecimal(string.IsNullOrEmpty( txtUtilidad.Text) ? txtUtilidad.Text = "0":txtUtilidad.Text ), Convert.ToDecimal(String.IsNullOrEmpty(Txtflete.Text) ? Txtflete.Text = "0" : Txtflete.Text), Convert.ToDecimal(String.IsNullOrEmpty(txtPrecio.Text) ? txtPrecio.Text = "0" : txtPrecio.Text));
        }

        private void TxtPcompra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calcularventa(Convert.ToDecimal(TxtPcompra.Text), Convert.ToDecimal(txtUtilidad.Text), Convert.ToDecimal(String.IsNullOrEmpty(Txtflete.Text) ? Txtflete.Text = "0":Txtflete.Text), Convert.ToDecimal(txtPrecio.Text));
            }
        }

        private void txtUtilidad_Leave(object sender, EventArgs e)
        {
            calcularventa(Convert.ToDecimal(TxtPcompra.Text), Convert.ToDecimal(txtUtilidad.Text), Convert.ToDecimal(Txtflete.Text), Convert.ToDecimal(txtPrecio.Text));
        }


        private void calcularventa(decimal compra, decimal utilidad, decimal flete, decimal precio)
        {
            txtPrecio.Text = Convert.ToString(decimal.Round(UtilityFrm.calcularventa(compra, utilidad, flete, precio), 2));
            TxtPcompra.Text = decimal.Round(compra,2).ToString();
            txtUtilidad.Text = decimal.Round(utilidad,2).ToString();
            Txtflete.Text = decimal.Round(flete, 2).ToString() ;
        }

        private void calcularcosto(decimal compra, decimal utilidad, decimal flete, decimal precio)
        { 
            
        }

        private void txtUtilidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calcularventa(Convert.ToDecimal(TxtPcompra.Text), Convert.ToDecimal(txtUtilidad.Text), Convert.ToDecimal(Txtflete.Text), Convert.ToDecimal(txtPrecio.Text));
            }
        }

        private void Txtflete_Leave(object sender, EventArgs e)
        {
            calcularventa(TxtPcompra.Text == "" ? 0 : Convert.ToDecimal(TxtPcompra.Text), txtUtilidad.Text == "" ? 0 : Convert.ToDecimal(txtUtilidad.Text), Txtflete.Text == "" ? 0 : Convert.ToDecimal(Txtflete.Text), Convert.ToDecimal(txtPrecio.Text == "" ? txtPrecio.Text = "0" : txtPrecio.Text));
        }

        private void Txtflete_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calcularventa(Convert.ToDecimal(TxtPcompra.Text), Convert.ToDecimal(txtUtilidad.Text), Convert.ToDecimal(Txtflete.Text), Convert.ToDecimal(txtPrecio.Text));
            }
        }

        private void TxtPcompra_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtPcompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilityFrm.NumDecTeclado(e, TxtPcompra);
        }

        private void txtUtilidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilityFrm.NumDecTeclado(e, txtUtilidad);
        }

        private void dataLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            textBox1.Text = decimal.Round(Convert.ToDecimal(this.dataLista.CurrentRow.Cells["Precio"].Value), 2).ToString();

        }

        private void cbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbxCategoria_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxCategoria.ValueMember != "")
            {
                CBSubcategoria.DataSource = null;
                CBSubcategoria.Items.Clear();
                
                llenarComboBoxCategoria(CBSubcategoria, "idsubcategoria", "nombre", NegocioCategoria.buscar("", Convert.ToInt32(cbxCategoria.SelectedValue)));
            }
             }

        private void txtPreciopormayor_Click(object sender, EventArgs e)
        {
            txtPreciopormayor.SelectAll();
        }

        private void txtCantidadpormayor_Click(object sender, EventArgs e)
        {
            txtCantidadpormayor.SelectAll();
        }

        private void txtStock_minimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilityFrm.NumDecTeclado(e, txtStock_minimo);
        }

        private void Txtflete_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilityFrm.NumDecTeclado(e, Txtflete);
        }


          
    }
}
