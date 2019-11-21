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
namespace Capa_Presentacion
{
    public partial class FrmBusquedaAvaArticulo : Form
    {
        private string nombreProducto;
        private int idProducto;
        private int stockActual;
        private decimal precio;
        
        private bool isCerro=false;

      
        public FrmBusquedaAvaArticulo()
        {
            InitializeComponent();
            this.mostrar();
        }
        public FrmBusquedaAvaArticulo(Boolean pesable)
        {
            InitializeComponent();
            if(pesable==true){
                this.mostrarPesable();
            }
            
        }

        private void mostrarPesable()
        {

            try
            {
                this.dataLista.DataSource = NegocioArticulo.mostrarPesable();
                //this.dataLista.Columns["precio"].DefaultCellStyle.Format = "c3";
                //this.dataLista.Columns["precio"].ValueType = Type.GetType("System.Decimal");
                //this.dataLista.Columns["precio"].DefaultCellStyle.Format = String.Format("###,##0.00");
                this.dataLista.Columns["precio"].DefaultCellStyle.Format = String.Format("$###,##0.00");
            
            }
            catch (Exception ex)
            {
                UtilityFrm.mensajeError("error con la Base de datos: " + ex.Message);
            }

            //muestro el total de las categorias
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataLista.RowCount);
        }
        private void FrmBusquedaAvaArticulo_Load(object sender, EventArgs e)
        {
           
        }
        /*Metodos Propios*/
        public void mostrar()
        {
            try
            {
                this.dataLista.DataSource = NegocioArticulo.mostrar();
                //this.dataLista.Columns["precio"].DefaultCellStyle.Format = "c3";
                //this.dataLista.Columns["precio"].ValueType = Type.GetType("System.Decimal");
                //this.dataLista.Columns["precio"].DefaultCellStyle.Format = String.Format("###,##0.00");
                this.dataLista.Columns["precio"].DefaultCellStyle.Format = String.Format("$###,##0.00");
           
            }
            catch (Exception ex)
            {
                UtilityFrm.mensajeError("error con la Base de datos: " + ex.Message);
            }

            //muestro el total de las categorias
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataLista.RowCount);
        }

        private void dataLista_DoubleClick(object sender, EventArgs e)
        {
            this.idProducto = Convert.ToInt32(this.dataLista.CurrentRow.Cells["idarticulo"].Value);
            this.nombreProducto = Convert.ToString(this.dataLista.CurrentRow.Cells["nombre"].Value);
            
            //convierte primero object a string y luego en float
            this.precio = decimal.Round(Convert.ToDecimal(this.dataLista.CurrentRow.Cells["precio"].Value), 2);
            //this.precio = double.Parse(Convert.ToString(this.dataLista.CurrentRow.Cells["precio"].Value));
            this.stockActual = Convert.ToInt32(this.dataLista.CurrentRow.Cells["stock_actual"].Value);
            this.Close();
            this.isCerro = false;
        }

        //Propiedades
        public string NombreProducto
        {
            get { return nombreProducto; }
            set { nombreProducto = value; }
        }
        public int IdProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }
        public int StockActual
        {
            get { return stockActual; }
            set { stockActual = value; }
        }
        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public bool IsCerro
        {
            get { return isCerro; }
            set { isCerro = value; }
        }
        private void FrmBusquedaAvaArticulo_FormClosing(object sender, FormClosingEventArgs e)
        {
            isCerro = true;
        }

        private void dataLista_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter){
                this.idProducto = Convert.ToInt32(this.dataLista.CurrentRow.Cells["idarticulo"].Value);
                this.nombreProducto = Convert.ToString(this.dataLista.CurrentRow.Cells["nombre"].Value);

                //convierte primero object a string y luego en float
                this.precio = decimal.Round(Convert.ToDecimal(this.dataLista.CurrentRow.Cells["precio"].Value));
                //this.precio = double.Parse(Convert.ToString(this.dataLista.CurrentRow.Cells["precio"].Value));
                this.stockActual = Convert.ToInt32(this.dataLista.CurrentRow.Cells["stock_actual"].Value);
                this.Close();
                this.isCerro = false;
            
            }
            
        }

        private void FrmBusquedaAvaArticulo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape){
                this.Close();
                
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            //compara si el primer caracter es numero, si es true se cambia a codigo de barra
            if (txtBuscar.Text != String.Empty)
            {
                if (Char.IsNumber(txtBuscar.Text, 0) && ((rdbNombre.Checked == true) || (rdbCategoria.Checked == true)))
                {
                    rdbCodigoBarra.Checked = true;

                    this.BuscarCodigoBarraPesable();

                }
                else if (Char.IsLetter(txtBuscar.Text, 0) && ((rdbCodigo.Checked == true) || (rdbCodigoBarra.Checked == true)))
                {

                    rdbNombre.Checked = true;

                    this.BuscarNombrePesable();
                }
                else if (rdbNombre.Checked == true) //segun el radiobutton que seleccione buscara
                {
                    this.BuscarNombrePesable();
                }
                else if (rdbCodigoBarra.Checked == true)
                {

                    if (txtBuscar.Text.Length > 13)
                    {
                        string prod = txtBuscar.Text;
                        prod = prod.Remove(0, 13);
                        txtBuscar.Text = "";

                        txtBuscar.Text = prod.ToString();
                        //se mueve hasta la ultima posicion
                        txtBuscar.Select(txtBuscar.Text.Length, 0);
                        // txtProducto.SelectAll();

                    }
                    this.BuscarCodigoBarraPesable();

                }
                else if (rdbCodigo.Checked == true)
                {
                    this.BuscarIdArticuloPesable();
                }
                else if (rdbCategoria.Checked == true)
                {
                    this.BuscarCategoriaPesable();
                }

            }
            else {

                this.mostrarPesable();
            }
           
           
              
        }

        private void BuscarIdArticuloPesable()
        {
            DataTable data = NegocioArticulo.mostrarPesableXbusqueda(txtBuscar.Text, "idarticulo");
      

            foreach (DataRow producto in data.Rows)
            {
                dataLista.Rows.Add(producto["idarticulo"], producto["codigo"], producto["nombre"], producto["precio"], producto["categoria"]);
            }
            
        }

        private void BuscarCategoriaPesable()
        {
            DataTable data = NegocioArticulo.mostrarPesableXbusqueda(txtBuscar.Text, "categoria");
           

            foreach (DataRow producto in data.Rows)
            {
                dataLista.Rows.Add(producto["idarticulo"], producto["codigo"], producto["nombre"], producto["precio"], producto["categoria"]);
            }
        }

        private void BuscarNombrePesable()
        {
            try
            {
                dataLista.Rows.Clear();
                DataTable data = NegocioArticulo.mostrarPesableXbusqueda(txtBuscar.Text, "nombre");


                foreach (DataRow producto in data.Rows)
                {
                    UtilityFrm.mensajeConfirm("hola");
                   // dataLista.Rows.Add(producto["idarticulo"], producto["codigo"], producto["nombre"]);
                    //    dataLista.Rows.Add(producto["idarticulo"], producto["codigo"], producto["nombre"], producto["precio"], producto["categoria"]);
                }

            }
            catch (Exception ex)
            {

                UtilityFrm.mensajeError("error: "+ex.Message);
            }
           
        }

        private void BuscarCodigoBarraPesable()
        {
            DataTable data = NegocioArticulo.mostrarPesableXbusqueda(txtBuscar.Text, "codigo");
        

            foreach (DataRow producto in data.Rows)
            {
              //  dataLista.Rows.Add(producto["idarticulo"], producto["codigo"], producto["nombre"], producto["precio"], producto["categoria"]);
            }
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            ////segun el radiobutton que seleccione buscara
            //if (rdbNombre.Checked == true)
            //{
            //    this.BuscarNombrePesable();
            //}
            //else if (rdbCodigoBarra.Checked == true)
            //{

            //    txtBuscar.Multiline = true;
            //    this.BuscarCodigoBarraPesable();

            //}
            //else if (rdbCodigo.Checked == true)
            //{
            //    this.BuscarIdArticuloPesable();
            //}
            //else
            //{
            //    this.BuscarCategoriaPesable();
            //}
        }
    }
}
