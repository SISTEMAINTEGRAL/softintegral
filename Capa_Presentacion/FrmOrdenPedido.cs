using Capa_negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class FrmOrdenPedido : Form
    {
        private string cuit;
        private string domicilio;
        private int idcliente;
        private string riva;
        int posY = 0;
        int posX = 0;
        public NegocioArticulo objnart = new NegocioArticulo();
        public FrmOrdenPedido()
        {
            InitializeComponent();
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
                        domicilio = row["direccion"].ToString();
                        idcliente = Convert.ToInt32 (row["idcliente"].ToString())  ;

                        // UtilityFrm.mensajeConfirm("Se encontro el Cliente " + cliente);
                        TxtRazonsocial.Text = cliente;
                        TxtCuit.Text = cuit;
                       

                    }
                    else
                    {
                        UtilityFrm.mensajeError("Error No se ha encontrado el Cliente");
                        //clienteIncorrecto();
                       // btnCliente.Focus();
                    }

                }
                else
                {
                    UtilityFrm.mensajeError("Error No se ha encontrado el Cliente");
                   // clienteIncorrecto();
                   // btnCliente.Focus();

                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void txtIdCliente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtIdCliente.TextLength >= 2 && IsNumeric(txtIdCliente.Text) != true)
                {


                    DGCliente.Visible = true;
                    DGCliente.DataSource = NegocioCliente.buscar(txtIdCliente.Text);

                    DGCliente.Columns[0].Visible = false;
                    DGCliente.Columns[1].Width = 550;
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
            catch (Exception)
            {

                throw;
            }
        }
        public bool IsNumeric(string input)
        {
            long test;

            return long.TryParse(input, out test);
        }

        private void txtIdCliente_KeyDown(object sender, KeyEventArgs e)
        {
            DataTable midata = new DataTable();
            if (e.KeyCode == Keys.Enter)
            {
                if (IsNumeric (txtIdCliente.Text) == true)
                {
                    Buscar_Cliente(Convert.ToInt32(txtIdCliente.Text));
                }
                else
                {
                    UtilityFrm.mensajeError("Para buscar un cliente en la caja de texto debe ser solo numerico");
                }
               



            }
            if (e.KeyCode == Keys.Down && DGCliente.Visible == true)
            {
                //si se preciona la tecla hacia abajo se pasa el foco a la grilla
                DGCliente.Focus();

            }
        }

        private void BtnBuscarcliente_Click(object sender, EventArgs e)
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
                    
                    txtIdCliente.Focus();

                }
                else
                {

                    TxtCuit.Text = cliente.Cuit.ToString();
                    TxtRazonsocial.Text = cliente.RazonSocial.ToString();
                    cuit = cliente.Cuit.ToString();
                    riva = cliente.Riva.ToString();
                    domicilio = cliente.Domicilio.ToString();


                    
                    
                }

            }
            catch (Exception ex)
            {

                UtilityFrm.mensajeError("Error al seleccionar un cliente. Causa:" + ex.Message + "cadena:" + ex.StackTrace);
                UtilityFrm.limpiarTextbox(txtIdCliente, TxtRazonsocial,TxtCuit);
                BtnBuscarcliente.Focus();
            }
        }

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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //cierra
            this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            //maximizar
            this.btnRestaurar.Visible = true;
            this.btnMaximizar.Visible = false;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            //minimiza
            this.WindowState = FormWindowState.Minimized;
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

        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(0, 100, 200);
        }

        private void btnMinimizar_MouseMove(object sender, MouseEventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(65, 39, 60);
        }

        private void btnMaximizar_MouseLeave(object sender, EventArgs e)
        {
            btnMaximizar.BackColor = Color.FromArgb(0, 100, 200);
        }

        private void btnMaximizar_MouseMove(object sender, MouseEventArgs e)
        {
            btnMaximizar.BackColor = Color.FromArgb(65, 39, 60);
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.FromArgb(0, 100, 200);
        }

        private void btnCerrar_MouseMove(object sender, MouseEventArgs e)
        {
            btnCerrar.BackColor = Color.Red;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            //restaurar
            this.btnRestaurar.Visible = false;
            this.btnMaximizar.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void btnRestaurar_MouseLeave(object sender, EventArgs e)
        {
            btnRestaurar.BackColor = Color.FromArgb(0, 100, 200);
        }

        private void btnRestaurar_MouseMove(object sender, MouseEventArgs e)
        {
            btnRestaurar.BackColor = Color.FromArgb(65, 39, 60);
        }

        public void Buscar_producto(long codproducto, string tipo, bool agregardatagrid, decimal cantidad = 1, string codbarra = "")
        {
            try
            {
                decimal precio;
                decimal descuento;
                decimal importe = 0;
                decimal total = 0;
                decimal cantidadActual = 0;


                objnart.extraerdatos(codproducto, tipo, codbarra);

                if (objnart.Sindatos == true)
                {



                    //TxtDetalle.Text = objnart.Nombre;
                    //TxtPrecio.Text = Convert.ToString(decimal.Round(objnart.Precio, 2));
                    //TxtCodigo.Text = Convert.ToString(objnart.IdArticulo);
                    //pesable = objnart.Pesable;


                    //si el descuento esta vacio se asigna 0 o se asigna su mismo contenido
                  //  TxtDesc.Text = (string.IsNullOrEmpty(TxtDesc.Text)) ? "0" : TxtDesc.Text;

                    bool encontrado = false;

                    //if (agregardatagrid == true)
                    //{
                    foreach (DataGridViewRow row in DGDetalleitems.Rows)
                    {

                        if (Convert.ToString(row.Cells["CCodigo"].Value) == txtNombreProducto.Text)
                        {


                            encontrado = true;

                           // row.Cells["Descuento"].Value = (string.IsNullOrEmpty(TxtDesc.Text)) ? "0" : TxtDesc.Text;
                            //asigno el precio,descuento,cantidad
                            precio = Convert.ToDecimal(row.Cells["CPrecio"].Value);
                            //descuento = Convert.ToDecimal(row.Cells["Descuento"].Value);
                            cantidadActual = (Convert.ToDecimal(row.Cells["CCantidad"].Value));

                            //incremento la cantidad del producto agregado
                            cantidadActual += cantidad;
                            row.Cells["CCantidad"].Value = cantidadActual;
                            //calculo el precio con descuento incluido * la cantidad de articulos agregados
                            importe = precio * cantidadActual;
                           // importe = importe - ((importe * descuento) / 100);
                            row.Cells["CImporte"].Value = importe;


                        }

                    }



                    if (encontrado == false)
                    {
                        //si no se encuentra cantidad 

                        precio = Convert.ToDecimal(objnart.Precio);
                        //descuento = Convert.ToDecimal(TxtDesc.Text);
                        //le aplico el descuento correspondiente
                        //precio = precio - ((precio * descuento) / 100);
                         importe = precio * cantidad;
                         
                        //no calculo el precio por la cantidad porque da el mismo numero

                        DGDetalleitems.Rows.Add(objnart.IdArticulo, objnart.Descripcion, precio, cantidad, importe);



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

               // txtcant.SelectAll(); txtcant.Focus();
            }
            catch (Exception)
            {

                throw;
            }

        }
        private void totales()
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
            if (DGDetalleitems.RowCount != 0)
            {
                foreach (DataGridViewRow row in DGDetalleitems.Rows)
                {

                    precio = Decimal.Round(Convert.ToDecimal(row.Cells["CPrecio"].Value), 2);
                    cantidadActual = Decimal.Round((Convert.ToDecimal(row.Cells["CCantidad"].Value)), 2);
                    importe = Decimal.Round(precio * cantidadActual, 2);

                    total = total + Convert.ToDecimal(row.Cells["Cimporte"].Value);

                    decimal.Round(total, 2);
                    txtTotalPagar.Text = total.ToString("0.00");
                }
            }
        }

        private void DGCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Buscar_Cliente(Convert.ToInt32 (  DGCliente.CurrentRow.Cells["idcliente"].Value));
                DGCliente.Visible = false;
            }
        }

        private void DGProductos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Buscar_producto(Convert.ToInt32(this.DGProductos.CurrentRow.Cells["idarticulo"].Value), "poridarticulo", true);
                DGProductos.Visible = false;


                //if (chkporcantidad.Checked == false) { txtNombreProducto.Focus(); };
             //   DGDetalleitems.Rows[DGProductos.Rows.Count - 1].Cells[2].Selected = true;
                //cambiartextbox();
            }
            else if (e.KeyCode == Keys.Up)

            {
                //pasa de la lista al campo nombreProducto 
                if (DGProductos.Rows.Count > 0 && DGProductos.Rows[0].Selected)
                {
                    txtNombreProducto.Focus();
                    txtNombreProducto.SelectAll();

                }
            }
        }

        private void txtNombreProducto_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (txtNombreProducto.TextLength >= 2 && IsNumeric(txtNombreProducto.Text) != true)
                {


                    
            try
            {
                if (txtNombreProducto.TextLength >= 2 && IsNumeric(txtNombreProducto.Text) != true)
                {


                    DGProductos.Visible = true;
                            DGProductos.DataSource = NegocioArticulo.buscarNombre(txtNombreProducto.Text);

                            DGProductos.Columns[0].Visible = false;
                    DGProductos.Columns[1].Visible = false;
                    DGProductos.Columns[2].Width = 350;
                    DGProductos.Columns[3].Visible = false;
                    DGProductos.Columns[4].Visible = false;
                    DGProductos.Columns[5].Visible = false;
                    DGProductos.Columns[6].Visible = false;



                }


                else
                    if ((IsNumeric(txtNombreProducto.Text) == true) && (txtNombreProducto.TextLength >= 13))
                    {
                        Buscar_producto(Convert.ToInt64(txtNombreProducto.Text), "porbarra", true, 1, txtNombreProducto.Text);
                    }
                    else
                    {
                        DGProductos.Visible = false;
                    }
                
            }
            catch (Exception)
            {

                throw;
            }
                    DGProductos.Visible = true;
                    DGProductos.DataSource = NegocioArticulo.buscarNombre(txtNombreProducto.Text);

                    DGProductos.Columns[0].Visible = false;
                    DGProductos.Columns[0].Visible = false;
                    DGProductos.Columns[1].Visible = false;
                    DGProductos.Columns[2].Width = 350;
                    DGProductos.Columns[3].Visible = false;
                    DGProductos.Columns[4].Visible = false;
                    DGProductos.Columns[5].Visible = false;
                    DGProductos.Columns[6].Visible = false;



                }


                else
                    if ((IsNumeric(txtNombreProducto.Text) == true) && (txtNombreProducto.TextLength >= 13))
                {
                    Buscar_producto(Convert.ToInt64(txtNombreProducto.Text), "porbarra",true , 1, txtNombreProducto.Text);
                }
                else
                {
                    DGProductos.Visible = false;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtNombreProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && DGProductos.Visible == true)
            {
                //si se preciona la tecla hacia abajo se pasa el foco a la grilla
                DGProductos.Focus();

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
                        Buscar_producto(Convert.ToInt64(txtNombreProducto.Text), "porbarra", true, 1, txtNombreProducto.Text);
                        txtNombreProducto.Focus();

                    }

                    //if (txtNombreProducto.TextLength == 12)
                    //{
                    //    NegocioArticulo.buscarCodigoBarra(txtNombreProducto.Text);
                    //}
                    else if (IsNumeric(txtNombreProducto.Text) == true)
                    {
                        Buscar_producto(Convert.ToInt64(txtNombreProducto.Text), "poridarticulo", true);

                    }
                    else
                    {
                        DGProductos.Visible = false;
                        


                    }
                    DGDetalleitems.Rows[DGDetalleitems.Rows.Count - 1].Cells[2].Selected = true;
                    
                    //txtNombreProducto.Focus();
                }
                catch (Exception ex)
                {

                    UtilityFrm.mensajeError("Error: " + ex.Message);
                }

            }
        }

        private void BtnBuscarProducto_Click(object sender, EventArgs e)
        {
            FrmConsulta objconsulta = new FrmConsulta(true);
            objconsulta.ShowDialog();

            //si el usuario cierra la ventana isCerro es true, sino si selecciono algun articulo isCerro
            try
            {
                if (objconsulta.IsCerro != false)
                {
                    Buscar_producto(objconsulta.Idarticulo, "poridarticulo", true);
                }
                else
                {


                }

            }
            catch (Exception ex)
            {

                UtilityFrm.mensajeError("Error al seleccionar un producto. Causa:" + ex.Message + ",cadena:" + ex.StackTrace);
                BtnBuscarcliente.Focus();
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Codigo", typeof(string));
          //  dt.Columns.Add("Precio", typeof(decimal));
            dt.Columns.Add("Cantidadtotal", typeof(decimal));
           // dt.Columns.Add("Importe", typeof(decimal));
            dt.Columns.Add("Detalle", typeof(string));
            dt.Columns.Add("Cantidadparcial", typeof(string));


            foreach (DataGridViewRow fila in DGDetalleitems.Rows)
            {
                dt.Rows.Add(fila.Cells["CCodigo"].Value, fila.Cells["CCantidad"].Value, fila.Cells["CDetalle"].Value,0);
            }

            NegocioOrdenpedido.insertar(DateTime.Now, idcliente, NegocioConfigEmpresa.idusuario, CbTipopedido.Text, "Inicio", "", dt);
        }
    }
}
