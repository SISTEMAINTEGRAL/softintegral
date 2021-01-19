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
        private decimal precioTotal;
        private bool isCerro = false;
        private decimal kgReal;
        private decimal precioXKg;
        private decimal descuento;
        private int codigo;
        private string buffer;
        private bool unenter = false;
        private decimal tara;
        public FrmAsignarPrecio()
        {
            InitializeComponent();
        }

        public FrmAsignarPrecio(string varbuffer)
        {
            this.buffer = varbuffer;

            InitializeComponent();



        }

        private void FrmAsignarPrecio_Load(object sender, EventArgs e)
        {
            string mensaje = "";
            try
            {
                

                mensaje = UtilityFrm.conectarbalanza(serialPort1);
                if (mensaje != "ok")
                {
                    UtilityFrm.mensajeError(mensaje + "error conexion de balanza");
                    this.Close();
                }
                txtTara.Focus();
                txtTara.SelectAll();
            }
            catch (Exception)
            {

                throw;
            }
           
            //buffer = serialPort1.ReadExisting().ToString();
            //txtNombreProducto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //txtNombreProducto.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //txtNombreProducto.AutoCompleteCustomSource = this.mostrarProductosPesables();
            //UtilityFrm.conectarbalanza();
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
        public decimal PrecioTotal
        {
            get { return PrecioTotal1; }
            set { PrecioTotal1 = value; }
        }
        public decimal KgReal
        {
            get { return kgReal; }
            set { kgReal = value; }
        }
        public decimal Descuento
        {
            get { return descuento; }
            set { descuento = value; }
        }
        public bool IsCerro
        {
            get { return isCerro; }
            set { isCerro = value; }
        }

        public decimal PrecioTotal1
        {
            get
            {
                return precioTotal;
            }

            set
            {
                precioTotal = value;
            }
        }

        public decimal Tara
        {
            get
            {
                return tara;
            }

            set
            {
                tara = value;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {



        }
        private void txtPrecio_KeyDown(object sender, KeyEventArgs e)
        {

        }



        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //solo valores numericos



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

        }



        private void FrmAsignarPrecio_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.isCerro = true;
        }



        private void btnProducto_Click(object sender, EventArgs e)
        {
            FrmAvanzadoArticulo producto = new FrmAvanzadoArticulo(true);
            producto.ShowDialog();
            if (!producto.IsCerro)
            {
                //si no se cerro y se seleccionó un producto de la lista 

            }

        }

        private void txtNombreProducto_TextChanged(object sender, EventArgs e)
        {



        }

        private void txtNombreProducto_Leave(object sender, EventArgs e)
        {

        }


        private void Buscar_producto(int codproducto, string tipo)
        {

            NegocioArticulo objnart = new NegocioArticulo();


            objnart.extraerdatos(codproducto, tipo);

            if (objnart.Sindatos == true)
            {






                bool encontrado = false;





            }
            else
            {
                // UtilityFrm.mensajeError( "No es una clave valida");

                FrmMensajeAutoCierre.Show("No es una clave valida", "Error", 1000);






            }
        }

        private void txtNombreProducto_KeyDown(object sender, KeyEventArgs e)
        {




        }

        public bool IsNumeric(string input)
        {
            long test;

            return long.TryParse(input, out test);
        }

        public void Buscar_producto(long codproducto, string tipo)
        {



            NegocioArticulo art = NegocioArticulo.extraerdatosPesable(codproducto, tipo);

            if (art.Sindatos == true)
            {








            }
            else
            {
                // UtilityFrm.mensajeError( "No es una clave valida");

                FrmMensajeAutoCierre.Show("No es una clave valida", "Error", 1000);






            }
        }
        public void Buscar_producto(string nombre, string tipo)
        {




        }
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            
                
              //  buffer = serialPort1.ReadExisting().ToString();

           
                //UtilityFrm.mensajeConfirm(buffer);
                
                
            

        }
        private void FrmAsignarPrecio_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {

                    pasarpreciobalanza();


                }
                if (e.KeyCode == Keys.Escape)
                {
                    isCerro = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
           
          
        }
        private string pasarpreciobalanza()
        {
            string msg = "";
            try
            {
                //txtTara.Text = string.Format("###,##0.00");
                buffer = serialPort1.ReadExisting();
                FrmMensajeAutoCierre.Show("CARGANDO...", "CARGANDO PESO", 500);
                buffer = serialPort1.ReadExisting();
                precioTotal = UtilityFrm.Leerbalanza(buffer);
                Tara = Convert.ToDecimal(txtTara.Text);
                UtilityFrm.desconectarbalanza(serialPort1);
                this.Close();
            }
            catch (Exception EX)
            {

               msg = EX.Message + "problema balanza";
            }
            return msg;
        }

        private void txtTara_Click(object sender, EventArgs e)
        {
            txtTara.SelectAll();
        }

        private void txtTara_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pasarpreciobalanza();
            }
        }

        private void txtTara_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            UtilityFrm.NumDecTeclado(e, txtTara);
        }
    }


    }

