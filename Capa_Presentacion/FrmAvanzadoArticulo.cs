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
    public partial class FrmAvanzadoArticulo : Form
    {
        private string opcionvista = "PRECIOMASIVO";
        public int  posY = 0;
              public int   posX = 0;
        private bool isCerro = false;
        private bool isPesable = false;
        private DataGridView listadodearticulo;

        public DataGridView Listadodearticulo
        {
            get { return listadodearticulo; }
            set { listadodearticulo = value; }
        }
        

        private string nombreProducto;

       
        private int idProducto;
      
        private int stockActual;

        
        private decimal precio;




        public bool IsPesable
        {
            get { return isPesable; }
            set { isPesable = value; }
        }
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
        public FrmAvanzadoArticulo()
        {
            InitializeComponent();
            IsPesable = false;
            this.mostrar();
        }

        private void mostrar()
        {
            
           
        }
        public FrmAvanzadoArticulo(Boolean pesable, string varvista = "PRECIOMASIVO")
        {
            InitializeComponent();
            if(pesable==true){
                IsPesable = true;
               
            }
            opcionvista = varvista;
            
        }
        public FrmAvanzadoArticulo(string varvista)
        {
            InitializeComponent();
            opcionvista = varvista;
            if (opcionvista == "STOCK")
            {
                panelHorizontal.Name = "INVENTARIO";
            }
            
        }
        private void btnProducto_Click(object sender, EventArgs e)
        {
            //segun el radiobutton que seleccione buscara
            this.buscar();
            
            
        }

        private void FrmAvanzadoArticulo_Load(object sender, EventArgs e)
        {
            try
            {
                llenarComboBoxCategoria(cbCategoria);
                dataLista.DataSource = NegocioArticulo.mostrar();
                
                dataLista.Columns["precio"].DefaultCellStyle.Format = String.Format("$###,##0.00");
                dataLista.Columns["precio_compra"].DefaultCellStyle.Format = String.Format("$###,##0.00");
                dataLista.Columns["utilidad"].DefaultCellStyle.Format = String.Format("###,##0.00");
                dataLista.Columns["flete"].DefaultCellStyle.Format = String.Format("###,##0.00");
                this.dataLista.Columns["idarticulo"].Visible = false;
                this.dataLista.Columns["idcategoria"].Visible = false;

                dataLista.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                txtProducto.Focus();
                
            }
            catch (Exception s)
            {
                UtilityFrm.mensajeError(s.Message);
            }
            
        }

       
        private void txtProducto_TextChanged(object sender, EventArgs e)
        {
           
          
            
        }

        //No pesables
        private void BuscarCodigoBarra()
        {
            try
            {
                //dataLista.Rows.Clear();
                DataTable data = NegocioArticulo.buscarCodigoBarra(txtProducto.Text);


               

            }
            catch (Exception ex)
            {

                UtilityFrm.mensajeError("error: " + ex.Message);
            }
        }
        private void BuscarIdArticulo()
        {
            try
            {
                //dataLista.Rows.Clear();
                DataTable data = NegocioArticulo.buscarIdProducto(txtProducto.Text);


                foreach (DataRow producto in data.Rows)
                {

                    dataLista.Rows.Add(producto["idarticulo"], producto["codigo"], producto["nombre"]);
                    //    dataLista.Rows.Add(producto["idarticulo"], producto["codigo"], producto["nombre"], producto["precio"], producto["categoria"]);
                }

            }
            catch (Exception ex)
            {

                UtilityFrm.mensajeError("error: " + ex.Message);
            }
        }
        private void BuscarCategoria()
        {
            try
            {
               // dataLista.Rows.Clear();
                DataTable data = NegocioArticulo.buscarCategoria(txtProducto.Text);


                foreach (DataRow producto in data.Rows)
                {

                    dataLista.Rows.Add(producto["idarticulo"], producto["codigo"], producto["nombre"]);
                    //    dataLista.Rows.Add(producto["idarticulo"], producto["codigo"], producto["nombre"], producto["precio"], producto["categoria"]);
                }

            }
            catch (Exception ex)
            {

                UtilityFrm.mensajeError("error: " + ex.Message);
            }
        }
        private void BuscarNombre()
        {
            try
            {
                this.dataLista.DataSource = NegocioArticulo.buscarNombre(this.txtProducto.Text, chkDescripcion.Checked == true ? txtDes.Text : "", chkcategoria.Checked == true ? cbCategoria.Text : "");
                
            }

            catch (Exception ex)
            {
                UtilityFrm.mensajeError("Error Con Base de Datos :" + ex.Message);

            }
        }

        //Pesables
        private void BuscarCategoriaPesable()
        {
            try
            {
                //dataLista.Rows.Clear();
                DataTable data = NegocioArticulo.mostrarPesableXbusqueda(txtProducto.Text, "categoria");


                foreach (DataRow producto in data.Rows)
                {

                    dataLista.Rows.Add(producto["idarticulo"], producto["codigo"], producto["nombre"]);
                    //    dataLista.Rows.Add(producto["idarticulo"], producto["codigo"], producto["nombre"], producto["precio"], producto["categoria"]);
                }

            }
            catch (Exception ex)
            {

                UtilityFrm.mensajeError("error: " + ex.Message);
            }
        }
        private void BuscarIdArticuloPesable()
        {
            try
            {
                //dataLista.Rows.Clear();
                DataTable data = NegocioArticulo.mostrarPesableXbusqueda(txtProducto.Text, "idarticulo");


                foreach (DataRow producto in data.Rows)
                {

                    dataLista.Rows.Add(producto["idarticulo"], producto["codigo"], producto["nombre"]);
                    //    dataLista.Rows.Add(producto["idarticulo"], producto["codigo"], producto["nombre"], producto["precio"], producto["categoria"]);
                }

            }
            catch (Exception ex)
            {

                UtilityFrm.mensajeError("error: " + ex.Message);
            }
        }
        private void BuscarNombrePesable()
        {
            try
            {
                //dataLista.Rows.Clear();
                DataTable data = NegocioArticulo.mostrarPesableXbusqueda(txtProducto.Text, "nombre");


                foreach (DataRow producto in data.Rows)
                {

                    dataLista.Rows.Add(producto["idarticulo"], producto["codigo"], producto["nombre"], producto["precio"], producto["categoria"], producto["stock_actual"]);
                }

            }
            catch (Exception ex)
            {

                UtilityFrm.mensajeError("error: " + ex.Message);
            }
        }
        private void BuscarCodigoBarraPesable()
        {
            try
            {
                //dataLista.Rows.Clear();
                DataTable data = NegocioArticulo.mostrarPesableXbusqueda(txtProducto.Text, "codigo");


                foreach (DataRow producto in data.Rows)
                {

                    dataLista.Rows.Add(producto["idarticulo"], producto["codigo"], producto["nombre"]);
                    //    dataLista.Rows.Add(producto["idarticulo"], producto["codigo"], producto["nombre"], producto["precio"], producto["categoria"]);
                }

            }
            catch (Exception ex)
            {

                UtilityFrm.mensajeError("error: " + ex.Message);
            }
        }
      
        private void dataLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                productoSeleccionado();
            
            }
            catch (Exception ex)
            {

                UtilityFrm.mensajeError("Error: "+ex.Message);
            }
            
        }

        private void dataLista_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                //pasa al texto el foco 
                txtProducto.Focus();

            }
            if (e.KeyCode == Keys.Left)
            {
                //pasa al texto el foco 
                txtProducto.Focus();


            }
            if (e.KeyCode == Keys.Enter)
            {
                if (dataLista.Rows.Count > 0)
                {

                    try
                    {
                        productoSeleccionado();

                    }
                    catch (Exception ex)
                    {

                        UtilityFrm.mensajeError("Error: " + ex.Message);
                    }

                }


            }
        }
        public void productoSeleccionado() {

            this.idProducto = Convert.ToInt32(this.dataLista.CurrentRow.Cells["codigo"].Value);
            this.nombreProducto = Convert.ToString(this.dataLista.CurrentRow.Cells["producto"].Value);

            //convierte primero object a string y luego en float
            this.precio = decimal.Round(Convert.ToDecimal(this.dataLista.CurrentRow.Cells["precioProducto"].Value), 2);
            //this.precio = double.Parse(Convert.ToString(this.dataLista.CurrentRow.Cells["precio"].Value));
            this.stockActual = Convert.ToInt32(this.dataLista.CurrentRow.Cells["stock_actual"].Value);
            this.Close();
            this.isCerro = false;
        }

        private void txtProducto_KeyDown(object sender, KeyEventArgs e)
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
            if (e.KeyCode == Keys.Enter )
            {
                //pasa a la lista el foco 
                this.buscar();

            }
        }

        private void FrmAvanzadoArticulo_FormClosing(object sender, FormClosingEventArgs e)
        {
            isCerro = true;
        }

        private void dataLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //se produce un evento cuando hago click en la columna 0 que es eliminar de la lista
            //se comparan el indice de columna de la lista =0 y el indice de la columna del evento=0
            if (e.ColumnIndex == dataLista.Columns[0].Index)
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

        private void Btntraer_Click(object sender, EventArgs e)
        {
            try
            {
                decimal preciocompravar = 0;
                if (dataLista.RowCount != 0)
                {
                    foreach (DataGridViewRow fila in dataLista.Rows)
                    {
                        if (Convert.ToBoolean(fila.Cells[0].Value) == true)
                        {
                            if (recorrerlista(Convert.ToInt32(fila.Cells["idarticulo"].Value)) == false)
                            {
                                 //  , fila.Cells["utilidad"].Value, fila.Cells["flete"].Value, fila.Cells["precio"].Value
                                preciocompravar = Convert.ToDecimal ( fila.Cells["precio_compra"].Value);
                                if (opcionvista == "PRECIOMASIVO")
                                {
                                    listadodearticulo.Rows.Add(fila.Cells["idarticulo"].Value, fila.Cells["nombre"].Value, fila.Cells["descripcion"].Value, UtilityFrm.formateodecimal(Convert.ToDecimal(fila.Cells["precio_compra"].Value), 2), UtilityFrm.formateodecimal(Convert.ToDecimal(fila.Cells["utilidad"].Value), 2), UtilityFrm.formateodecimal(Convert.ToDecimal(fila.Cells["flete"].Value), 2), UtilityFrm.formateodecimal(Convert.ToDecimal(fila.Cells["precio"].Value), 2));
                                }
                                else if (opcionvista == "STOCK")
                                {
                                    listadodearticulo.Rows.Add(fila.Cells["idarticulo"].Value, fila.Cells["nombre"].Value, UtilityFrm.formateodecimal(Convert.ToDecimal(fila.Cells["precio_compra"].Value), 2), UtilityFrm.formateodecimal(Convert.ToDecimal(fila.Cells["precio"].Value), 2), "1", UtilityFrm.formateodecimal(Convert.ToDecimal(fila.Cells["stock_actual"].Value), 2));
                                }
                               
                            }
                            

                        }


                    }  
                
                }
                //this.listadodearticulo.Columns["Preciocompra"].DefaultCellStyle.Format = String.Format("$###,##0.00");
                //this.listadodearticulo.Columns["Precioventa"].DefaultCellStyle.Format = String.Format("$###,##0.00");
                //this.listadodearticulo.Columns["Utilidad"].DefaultCellStyle.Format = String.Format("%0.00");
                //this.listadodearticulo.Columns["Flete"].DefaultCellStyle.Format = String.Format("%0.00");
            
            }
            catch (Exception x)
            {
                UtilityFrm.mensajeError(x.Message);  
            }
        }


        private bool recorrerlista(int codigoarticulo)
        {
            bool encontrado = false;

            foreach (DataGridViewRow fila in listadodearticulo.Rows)
            {
                if (Convert.ToInt32(fila.Cells[0].Value) == codigoarticulo)
                {
                    encontrado = true;
                }
            
            }
           return encontrado;
        
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
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

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            //restaurar
            this.btnRestaurar.Visible = false;
            this.btnMaximizar.Visible = true;
            this.WindowState = FormWindowState.Normal;
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

        private void llenarComboBoxCategoria(ComboBox combo)
        {

            combo.DataSource = NegocioCategoria.mostrar();
            //valor real de la DB

            combo.ValueMember = "idcategoria";
            //lo que se muestra
            combo.DisplayMember = "nombre";

        }

        private void chkcategoria_CheckedChanged(object sender, EventArgs e)
        {
            cbCategoria.Enabled = chkcategoria.Checked ;
        }

        private void chkDescripcion_CheckedChanged(object sender, EventArgs e)
        {
            txtDes.Enabled = chkDescripcion.Checked;
        }
        private void buscar()
        {
            //segun el radiobutton que seleccione buscara
            //dataLista.Rows.Clear();
            if (rdbNombre.Checked == true)
            {
                this.BuscarNombre();
                
            }
            else if ((txtProducto.Text.Length >= 13))
            {

                string prod = txtProducto.Text;
                prod = prod.Remove(0, 13);
                txtProducto.Text = "";

                txtProducto.Text = prod.ToString();
                //se mueve hasta la ultima posicion
                txtProducto.Select(txtProducto.Text.Length, 0);
                // txtProducto.SelectAll();
                this.BuscarCodigoBarra();
               




            }
            else
            {
                this.BuscarCategoria();
                
            }

        }

        private void gbDetalleMovimento_Enter(object sender, EventArgs e)
        {

        }

        private void txtDes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.buscar();
            
            }
        }

        private void dataLista_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //se produce un evento cuando hago click en la columna 0 que es eliminar de la lista
                //se comparan el indice de columna de la lista =0 y el indice de la columna del evento=0
                if (e.ColumnIndex == dataLista.Columns[0].Index && e.RowIndex >= 0)
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

        private void MenuDeleteall_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < dataLista.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell check = (DataGridViewCheckBoxCell)dataLista.Rows[i].Cells[0];
                
                
                    
                    check.Value = CheckState.Checked;
                
            }
        }

        private void dataLista_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                contextMenuStrip1.Show(dataLista, new Point(e.X, e.Y));
                MenuDeleteall.Visible = true;

            } 
        }


    }
}
