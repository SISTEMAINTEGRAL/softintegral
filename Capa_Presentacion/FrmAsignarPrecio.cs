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
    public partial class FrmAsignarPrecio : Form
    {
        private string producto;
        private decimal  precioTotal;
        private bool isCerro = false;
        private decimal kgReal;
        private decimal precioXKg;
        private decimal  descuento;
        private int codigo;

        public FrmAsignarPrecio()
        {
            InitializeComponent();
        }

        public FrmAsignarPrecio(string producto)
        {
            this.producto = producto;

            InitializeComponent();
            txtNombreProducto.Text = this.Producto;

          
        }

        private void FrmAsignarPrecio_Load(object sender, EventArgs e)
        {

            txtNombreProducto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtNombreProducto.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtNombreProducto.AutoCompleteCustomSource = this.mostrarProductosPesables();
            
        }

        public AutoCompleteStringCollection mostrarProductosPesables() {

            DataTable dt = NegocioArticulo.mostrarPesable();
          AutoCompleteStringCollection autoCompleteStringCol = new AutoCompleteStringCollection();

         
          foreach (DataRow row in dt.Rows)
          {
              autoCompleteStringCol.Add(row["nombre"].ToString());
          }
          return autoCompleteStringCol;
            
        }
        //propiedades
        public string Producto
        {
            get { return producto; }
            set { producto = value; }
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public decimal PrecioXKg
        {
            get { return precioXKg; }
            set { precioXKg = value; }
        }
        public decimal  PrecioTotal
        {
            get { return precioTotal; }
            set { precioTotal = value; }
        }
        public decimal KgReal
        {
            get { return kgReal; }
            set { kgReal = value; }
        }
        public decimal  Descuento
        {
            get { return descuento; }
            set { descuento = value; }
        }
        public bool IsCerro
        {
            get { return isCerro; }
            set { isCerro = value; }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {


            if (txtNombreProducto.Text == string.Empty || txtPrecio.Text == string.Empty || txtKgReal.Text == string.Empty || txtPrecioxKg.Text == string.Empty)
            {
                UtilityFrm.mensajeError("el precio no puede ser 0");
            }
            else
            {
                PrecioTotal = Convert.ToDecimal(txtPrecio.Text);
                Producto = txtNombreProducto.Text;
                PrecioTotal = Convert.ToDecimal(txtPrecio.Text);
                PrecioXKg = Convert.ToDecimal(txtPrecioxKg.Text);
                KgReal = Convert.ToDecimal(txtKgReal.Text);
                codigo = Convert.ToInt32(txtCodigo.Text);

                this.Close();

                this.isCerro = false;
            }
        }
        private void txtPrecio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
              
             
                if (txtPrecio.Text.Length>0)
                {
                    decimal precioXKg = Convert.ToDecimal(txtPrecio.Text);
                    decimal kgReal =decimal.Round( precioXKg/Convert.ToDecimal( txtPrecioxKg.Text),3);
                    txtKgReal.Text = kgReal.ToString();
                    if (!txtPrecio.Text.Contains(","))
                    {
                        txtPrecio.Text += ",00";
                        
                    }
                    btnGuardar.Focus();
                }
                e.Handled = false;
                e.SuppressKeyPress = true;
            }
        }

     

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo valores numericos


            if (Char.IsDigit(e.KeyChar))
            {

                e.Handled = false;

            }
            else if (e.KeyChar == '.' && !txtPrecio.Text.Contains(','))
            {
                e.Handled = true;
                SendKeys.Send(",");


            }
            else if (e.KeyChar == ',' && !txtPrecio.Text.Contains(','))
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

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo valores numericos


            if (Char.IsDigit(e.KeyChar))
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

        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            if (txtPrecio.Text==string.Empty)
            {
                txtPrecio.Text += "0,00";

            }else if (!txtPrecio.Text.Contains(","))
            {
                txtPrecio.Text += ",00";

            }
        }

     

        private void FrmAsignarPrecio_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.isCerro = true;
        }

       

        private void btnProducto_Click(object sender, EventArgs e)
        {
            FrmAvanzadoArticulo producto = new FrmAvanzadoArticulo(true);
            producto.ShowDialog();
            if (!producto.IsCerro)
            {
                //si no se cerro y se seleccionó un producto de la lista 
                txtNombreProducto.Text = producto.NombreProducto;
                txtPrecioxKg.Text =  producto.Precio.ToString();
                txtPrecio.Enabled = true;
                txtPrecio.Focus();
                txtCodigo.Text = producto.IdProducto.ToString() ;
            }
           
        }

        private void txtNombreProducto_TextChanged(object sender, EventArgs e)
        {

            if (txtNombreProducto.Text.Length > 0 && IsNumeric(txtNombreProducto.Text) == false)
            {
              
                txtPrecio.Enabled = true;
                
            }
            else
            {
               
                txtPrecio.Enabled = false;
                UtilityFrm.limpiarTextbox(txtPrecio);
            }
          
        }

        private void txtNombreProducto_Leave(object sender, EventArgs e)
        {
            if (txtPrecioxKg.Text.Length > 0 && txtNombreProducto.Text.Length > 0)
            {
                txtPrecio.Enabled = true;

            }
            else {
                txtPrecio.Enabled = false;
                UtilityFrm.limpiarTextbox(txtPrecio);
            }
        }


        private void Buscar_producto(int codproducto, string tipo)
        {

              NegocioArticulo objnart = new NegocioArticulo();
      

            objnart.extraerdatos(codproducto, tipo);

            if (objnart.Sindatos == true)
            {



                txtNombreProducto.Text = objnart.Nombre;
                txtPrecioxKg.Text = Convert.ToString(decimal.Round(objnart.Precio, 2));
                txtCodigo.Text = Convert.ToString(objnart.IdArticulo);


                bool encontrado = false;

              


               
            }
            else
            {
                // UtilityFrm.mensajeError( "No es una clave valida");

                FrmMensajeAutoCierre.Show("No es una clave valida", "Error", 1000);




                txtNombreProducto.SelectAll();

            }
        }

        private void txtNombreProducto_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Down && dataGridView1.Visible == true)
            //{
            //    //si se preciona la tecla hacia abajo se pasa el foco a la grilla
            //    dataGridView1.Focus();

            //}

            if (e.KeyCode == Keys.Enter)
            {

                if (txtNombreProducto.Text.Length > 0)
                {

                    //se pasa el control permitiendo eliminar el beep
                    e.SuppressKeyPress = true;

                    try
                    {
                        if (txtNombreProducto.TextLength == 13 && IsNumeric(txtNombreProducto.Text) == true)
                        {
                            Buscar_producto(Convert.ToInt64(txtNombreProducto.Text), "porbarra");


                        }
                        IsNumeric(txtNombreProducto.Text);
                        if (IsNumeric(txtNombreProducto.Text) == true)
                        {
                            Buscar_producto(Convert.ToInt64(txtNombreProducto.Text), "poridarticulo");
                        }
                        else if (IsNumeric(txtNombreProducto.Text) == false)
                        {
                            Buscar_producto(txtNombreProducto.Text, "pornombre");

                            //NegocioArticulo art= NegocioArticulo.extraerdatosPesable(txtNombreProducto.Text, "pornombre");
                            //txtPrecioxKg.Text = Convert.ToString(decimal.Round(art.Precio, 2));

                            //txtCodigo.Text = art.IdArticulo.ToString();
                        }
                        


                    }
                    catch (Exception ex)
                    {

                        UtilityFrm.mensajeError("Error: " + ex.Message);

                    }

                
            }
            else
            {

                UtilityFrm.mensajeError("Error: El nombre de Producto o codigo está vacio");


            }

            }

             
               
        }

        public bool IsNumeric(string input)
        {
            long test;

            return long.TryParse(input, out test);
        }

        public void Buscar_producto(long codproducto, string tipo)
        {
           


            NegocioArticulo art=NegocioArticulo.extraerdatosPesable(codproducto, tipo);

            if (art.Sindatos == true)
            {



                txtNombreProducto.Text = art.Nombre;
                txtPrecioxKg.Text = Convert.ToString(decimal.Round(art.Precio, 2));
                txtCodigo.Text = Convert.ToString(art.IdArticulo);
                txtPrecio.Focus();
             

                

               
            }
            else
            {
                // UtilityFrm.mensajeError( "No es una clave valida");

                FrmMensajeAutoCierre.Show("No es una clave valida", "Error", 1000);




                txtNombreProducto.SelectAll();

            }
        }
        public void Buscar_producto(string nombre, string tipo)
        {


            NegocioArticulo art= NegocioArticulo.extraerdatosPesable(txtNombreProducto.Text, "pornombre");
        

            if (art.Sindatos == true)
            {



                txtNombreProducto.Text = art.Nombre;
                txtPrecioxKg.Text = Convert.ToString(decimal.Round(art.Precio, 2));
                txtCodigo.Text = Convert.ToString(art.IdArticulo);

                txtPrecio.Focus();




            }
            else
            {
                // UtilityFrm.mensajeError( "No es una clave valida");

                FrmMensajeAutoCierre.Show("No es una clave valida", "Error", 1000);




                txtNombreProducto.SelectAll();

            }
        }
        private void FrmAsignarPrecio_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape){
                this.Close();
            
            }
        }

    }
}
