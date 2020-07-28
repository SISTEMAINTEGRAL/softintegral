using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_negocio;
namespace Capa_Presentacion
{
    public partial class FrmConsultas : Form
    {
        public FrmConsultas()
        {
            InitializeComponent();
        }

        private void FrmConsultas_Load(object sender, EventArgs e)
        {
            this.dataLista.Columns["precio"].DefaultCellStyle.Format = String.Format("$###,##0.00");
            this.mostrar();
            txtProducto.Focus();
        }
        public void mostrar()
        {
            try
            {

                  DataTable productos = NegocioArticulo.mostrar();
                foreach (DataRow producto  in productos.Rows)
                {


                    dataLista.Rows.Add(producto["idarticulo"],producto["codigo"],producto["nombre"],producto["precio"],producto["categoria"]);
                }
              
                //this.dataLista.Columns["precio"].DefaultCellStyle.Format = "c3";
                //this.dataLista.Columns["precio"].ValueType = Type.GetType("System.Decimal");
                //this.dataLista.Columns["precio"].DefaultCellStyle.Format = String.Format("###,##0.00");
               
            }
            catch (Exception ex)
            {
                UtilityFrm.mensajeError("error con la Base de datos: " + ex.Message);
            }
            //datasource el origen de los datos,muestra las categorias en la grilla

           
       

        }
        private void btnCalculadora_Click(object sender, EventArgs e)
        {
             //calculadora
                  Process proceso = new Process();
        proceso.StartInfo.FileName = "calc.exe";
        proceso.StartInfo.Arguments = "";
        proceso.Start();
        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
            //compara si el primer caracter es numero, si es true se cambia a codigo de barra
            if (txtProducto.Text!=String.Empty )
            {
                if (Char.IsNumber(txtProducto.Text, 0) && ((rdbNombre.Checked == true) || (rbCategoria.Checked == true)))
                {
                   
                    rdbCodigoBarra.Checked = true;
                    
                    this.BuscarCodigoBarra();
                    //this.txtProducto.KeyDown += txtProducto_KeyDown;

                   
                   // this.txtProducto_KeyPress(this, new KeyPressEventArgs((char)(Keys.Enter)));
                    
                }
                else if (Char.IsLetter(txtProducto.Text, 0) && ((rbCodigo.Checked == true) || (rdbCodigoBarra.Checked == true)))
                {

                    rdbNombre.Checked = true;

                    this.BuscarNombre();
                }
               

                


            }
            else { 
            
            }
                //segun el radiobutton que seleccione buscara
                if (rdbNombre.Checked == true)
                {
                    this.BuscarNombre();
                }
                else if (rdbCodigoBarra.Checked == true)
                {
                    this.BuscarCodigoBarra();

                }
                else if (rbCodigo.Checked == true)
                {
                    this.BuscarCodigo();
                }
                else if (rbCategoria.Checked == true)
                {
                    this.BuscarCategoria();
                }
              
            
            
           
        }

        public void BuscarNombre()
        {
           DataTable data= NegocioArticulo.buscarNombre(txtProducto.Text);
           dataLista.Rows.Clear();
            foreach (DataRow producto in data.Rows)
	{
        dataLista.Rows.Add(producto["idarticulo"], producto["codigo"], producto["nombre"], producto["precio"], producto["categoria"]);
	}
            
        }
        public void BuscarCategoria()
        {
            DataTable data = NegocioArticulo.buscarCategoria(txtProducto.Text);
            dataLista.Rows.Clear();
            foreach (DataRow producto in data.Rows)
            {
                dataLista.Rows.Add(producto["idarticulo"], producto["codigo"], producto["nombre"], producto["precio"], producto["categoria"]);
            }
        }
        public void BuscarCodigo()
        {
            DataTable data = NegocioArticulo.buscarIdProducto(txtProducto.Text);
            dataLista.Rows.Clear();
            foreach (DataRow producto in data.Rows)
            {
                dataLista.Rows.Add(producto["idarticulo"], producto["codigo"], producto["nombre"], producto["precio"], producto["categoria"]);
            }
        }

        public void BuscarCodigoBarra()
        {
            DataTable data = NegocioArticulo.buscarCodigoBarra(txtProducto.Text);
            dataLista.Rows.Clear();
            foreach (DataRow producto in data.Rows)
            {
                dataLista.Rows.Add(producto["idarticulo"], producto["codigo"], producto["nombre"], producto["precio"], producto["categoria"]);
            }
           // this.txtProducto_KeyDown(this, new KeyEventArgs(Keys.Enter));
        }

     

        private void btnProducto_Click(object sender, EventArgs e)
        {
            
            //segun el radiobutton que seleccione buscara
            if (rdbNombre.Checked == true)
            {
                this.BuscarNombre();
            }
            else if (rdbCodigoBarra.Checked == true)
            {

             
                this.BuscarCodigoBarra();

            }
            else if (rbCodigo.Checked == true)
            {
                this.BuscarCodigo();
            }
            else
            {
                this.BuscarCategoria();
            }
        }

        private void rdbNombre_CheckedChanged(object sender, EventArgs e)
        {
            //al hacer click en un radiobutton cambia el foco al textbox producto
            txtProducto.Focus();
        }

        private void rdbCodigoBarra_CheckedChanged(object sender, EventArgs e)
        {
            //al hacer click en un radiobutton cambia el foco al textbox producto
            txtProducto.Focus();
        }

        private void rbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            //al hacer click en un radiobutton cambia el foco al textbox producto
            txtProducto.Focus();
        }

        private void rbCategoria_CheckedChanged(object sender, EventArgs e)
        {
            //al hacer click en un radiobutton cambia el foco al textbox producto
            txtProducto.Focus();
        }

        private void grpboxConsulta_Enter(object sender, EventArgs e)
        {

        }

        private void dataLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblNomProducto_Click(object sender, EventArgs e)
        {

        }

        private void gbDetalleMovimento_Enter(object sender, EventArgs e)
        {

        }

        private void txtProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtProducto_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                //se pasa el control permitiendo eliminar el beep
               // UtilityFrm.mensajeConfirm("se generó");
                e.Handled = false;
                e.SuppressKeyPress = true;
                btnProducto.Focus();
               
               
            }
               
           
                
              
            
            
         

        }

        private void FrmConsultas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                //limpiar la caja de texto txtProducto
                txtProducto.Text="";

            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtProducto.Text = "";
        }
        //mensajes de ayuda
        private void mensajesDeAyuda()
        {

            //mensaje de ayuda en el textbox nombre

            this.ttMensajeAyuda.SetToolTip(this.txtProducto, "Ingrese el producto ha buscar");
            //mensaje de ayuda en el textbox nombre
            this.ttMensajeAyuda.SetToolTip(this.btnLimpiar, "Limpia el texto a buscar (F1)");
            //mensaje de ayuda en el textbox nombre
            this.ttMensajeAyuda.SetToolTip(this.btnProducto, "Busca el valor ingresado en la lista");
          

        }
       


       

       
    }
}
