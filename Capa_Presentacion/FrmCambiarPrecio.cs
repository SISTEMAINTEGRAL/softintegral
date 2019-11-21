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
    public partial class FrmCambiarPrecio : Form
    {
        private string nombreProducto;
        private decimal precioAnterior;
        private decimal precioVenta;
        private int idArticulo = 0;
        private int utilidad=0;
      
       
        private decimal precioCompra;
      
        public FrmCambiarPrecio()
        {
            InitializeComponent();
       

        }
        public FrmCambiarPrecio(string nombreProducto ,decimal precioAnterior)
        {
            InitializeComponent();
            this.nombreProducto = nombreProducto;
           this.precioAnterior= precioAnterior;
           
        }
        public FrmCambiarPrecio(int idArticulo,string nombreProducto, decimal precioAnterior)
        {
            InitializeComponent();
            this.nombreProducto = nombreProducto;
            this.precioAnterior = precioAnterior;
            this.idArticulo = idArticulo;
        }
        public FrmCambiarPrecio(string nombreProducto, decimal precioAnterior,decimal precioCompra)
        {
            InitializeComponent();
            this.nombreProducto = nombreProducto;
            this.precioAnterior = precioAnterior;
            this.precioCompra = precioCompra;
        }
        private void FrmCambiarPrecio_Load(object sender, EventArgs e)
        {
            txtNombreProducto.Text = nombreProducto;
            txtPrecioAnterior.Text = Convert.ToString( Decimal.Round(precioAnterior, 2));
            txtPrecioCompra.Text = Convert.ToString(Decimal.Round(precioCompra, 2));
           
            
        }
        private void cambiarPrecio() { 
            
            
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardarPrecio();
           
            
        }

        private void cbxPrecioFinal_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPrecioFinal.Checked == true)
            {
                txtPrecioVenta.Enabled = true;
                txtPrecioCompra.Enabled = true;
                txtUtilidad.Enabled = false;
                txtUtilidad.Text = "0";
                txtPrecioVenta.Focus();

            }
            else
            {
                txtPrecioVenta.Enabled = false;
                txtPrecioCompra.Enabled = true;
                txtUtilidad.Enabled = true;
                UtilityFrm.limpiarTextbox(txtPrecioVenta);
            }
        }

        private void txtUtilidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo valores numericos

            if (Char.IsDigit(e.KeyChar) || e.KeyChar == ',')
            {
              
                e.Handled = false;

            }
            else if (Char.IsControl(e.KeyChar))
            {

                e.Handled = false;
            }
          
            else {
                e.Handled = true;
                
            }
        }

        private void txtUtilidad_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {

                    decimal precioCompra, utilidad, precioVenta;
                    if (txtPrecioCompra.Text == "0" || txtPrecioCompra.Text == "0,00")
                    {
                        //si entra desde el formulario FrmPrecio entrará por acá
                        precioCompra = Convert.ToDecimal(txtPrecioCompra.Text);
                        utilidad = Convert.ToDecimal(txtUtilidad.Text);
                        precioVenta = (utilidad * precioCompra) / 100;
                        precioVenta = precioVenta + precioCompra;
                        txtPrecioVenta.Text = Convert.ToString(precioVenta);
                        btnGuardar.Focus();
                    }
                    else
                    {
                        precioCompra = Convert.ToDecimal(txtPrecioCompra.Text);
                        utilidad = Convert.ToDecimal(txtUtilidad.Text);
                        precioVenta = (utilidad * precioCompra) / 100;
                        precioVenta = precioVenta + precioCompra;
                        txtPrecioVenta.Text = Convert.ToString(precioVenta);
                        btnGuardar.Focus();

                    }
                    e.Handled = false;
                    e.SuppressKeyPress = true;




                }
            }
            catch (Exception ex)
            {

                UtilityFrm.mensajeError("Has introducido algun valor incorrecto");
            }
            

        }
        public decimal PrecioVenta
        {
            get { return precioVenta; }
            set { precioVenta = value; }
        }

        private void txtPrecioVenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter&&txtPrecioCompra.Text!="0")
            {
               
               
                    //si el usuario no ingreso los decimales se agregan los ceros correspondientes
                    if (txtPrecioVenta.Text.Length > 0 && !txtPrecioVenta.Text.Contains(","))
                    {
                        txtPrecioVenta.Text += ",00";

                    }

                    precioCompra = Convert.ToDecimal(txtPrecioCompra.Text);
                    precioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
                    decimal ganancia = precioVenta - precioCompra;
                    decimal utilidad = decimal.Round((ganancia * 100) / precioCompra,2);
                    txtUtilidad.Text = utilidad.ToString();
                e.Handled = false;
                    e.SuppressKeyPress = true;
                    
                    btnGuardar.Focus(); 
                
            }
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo valores numericos
            UtilityFrm.NumDecTeclado(e, txtPrecioVenta);


        }
        public int IdArticulo
        {
            get { return idArticulo; }
            set { idArticulo = value; }
        }

        private void txtPrecioVenta_TextChanged(object sender, EventArgs e)
        {
            UtilityFrm.limpiarErrorProvider(txtPrecioVenta, errorIcono);
            if (txtPrecioVenta.Text.Length > 0 && txtPrecioVenta.Text[0] == ',')
            {

                txtPrecioVenta.Text = "";
            }
            else if (txtPrecioVenta.Text.Length == 0)
            {
                errorIcono.SetError(txtPrecioVenta, "Es necesario un valor Numerico en el campo Precio de Venta");
            }
        }

        private void FrmCambiarPrecio_KeyDown(object sender, KeyEventArgs e)
        {
                //comparo el evento pasado como parametro y el enum keys.enter
            if (e.KeyCode == Keys.Escape)
            {
                 this.Close();
              
            }
        
        }

        private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilityFrm.NumDecTeclado(e, txtPrecioCompra);
        }

        private void txtPrecioCompra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //si el usuario no ingreso los decimales se agregan los ceros correspondientes
                if (txtPrecioCompra.Text.Length > 0 && !txtPrecioCompra.Text.Contains(","))
                {
                    txtPrecioCompra.Text += ",00";

                }
                txtUtilidad.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtPrecioCompra_TextChanged(object sender, EventArgs e)
        {
            UtilityFrm.limpiarErrorProvider(txtPrecioCompra, errorIcono);
            if (txtPrecioCompra.Text.Length > 0 && txtPrecioCompra.Text[0] == ',')
            {

                txtPrecioCompra.Text = "";
            }
            else if (txtPrecioCompra.Text.Length == 0)
            {
                errorIcono.SetError(txtPrecioCompra, "Es necesario un valor Numerico en el campo Precio de compra");
            }
        }

        //guarda el precio actualizado
        public void guardarPrecio() {


            try
            {
                decimal precioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
                  decimal precioCompra = Convert.ToDecimal(txtPrecioCompra.Text);
                if (precioVenta > 0 && idArticulo != 0&&precioCompra>0)
                {

                    this.precioVenta = precioVenta;
                    this.utilidad = Convert.ToInt32(txtUtilidad.Text);
                    NegocioArticulo.editarPrecio(this.idArticulo, precioVenta,precioCompra, this.utilidad);
                    this.Close();
                    UtilityFrm.mensajeConfirm("La edición se realizó Correctamente");
                }
                else
                {
                    UtilityFrm.mensajeError("No se a podido guardar ");
                }

            }

            catch (Exception ex)
            {
                UtilityFrm.mensajeError("No se a podido guardar :" + ex.Message);

            }
        }
    }
}
