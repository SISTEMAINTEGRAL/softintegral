using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_negocio;
using System.Diagnostics;
namespace Capa_Presentacion
{
    public partial class FrmMovStock1 : Form
    {
        private string codigoproducto;
        private string producto;
        private string precio;
        private string precioventa;
        private string cantidad;
        private string stockactual;
        private string proveedor = "";
        private string preciocantidad;
        private bool datagriddobleclic;
        private bool encontrado;
        private int index = -1;

        public FrmMovStock1()
        {
            InitializeComponent();
        }

        private void txtProveedor_TextChanged(object sender, EventArgs e)
        {
            if (txtProveedor.TextLength >= 2 && IsNumeric(txtNombreProducto.Text) != true)
            {
                Dtproveedor.Visible = true;
                Dtproveedor.DataSource = NegocioProveedor.buscar(txtProveedor.Text);

                Dtproveedor.Columns[0].Visible = false;
                Dtproveedor.Columns[1].Visible = false;
                Dtproveedor.Columns[2].Width = 350;
                Dtproveedor.Columns[3].Visible = false;
                Dtproveedor.Columns[4].Visible = false;
                Dtproveedor.Columns[5].Visible = false;
                Dtproveedor.Columns[6].Visible = false;
            }
        }
        public bool IsNumeric(string input)
        {
            long test;

            return long.TryParse(input, out test);
        }

        private void extraerproveedor(int idproveedor)
        {

            DataTable dataproveedor = new DataTable();
            proveedor = idproveedor.ToString();
            dataproveedor = NegocioProveedor.buscar(idproveedor.ToString(), 6);
            DataRow row = dataproveedor.Rows[0];
            if (dataproveedor.Rows.Count != 0)
            {
                LblDesprov.Text = row["razon_social"].ToString();

            }
            else
            {
                proveedor = "0";
            }


        }

        private void cambiartextbox()
        {
            Rectangle rec = dataListaMov.GetCellDisplayRectangle(dataListaMov.CurrentCell.ColumnIndex, dataListaMov.CurrentCell.RowIndex, false);
            dataListaMov.Focus();

            //if (dataListaMov.CurrentCell.ColumnIndex == 2)
            //{
            //    preciocantidad = "Cprecio";
            //}

             if (dataListaMov.CurrentCell.ColumnIndex == 4)
            {
                preciocantidad = "cantidad";
            }

            //else if (dataListaMov.CurrentCell.ColumnIndex == 4)
            //{
            //    preciocantidad = "subtotal";
            //}

            //else if (dataListaMov.CurrentCell.ColumnIndex == 5)
            //{
            //    preciocantidad = "descuento";
            //}

            //else if (dataListaMov.CurrentCell.ColumnIndex == 6)
            //{
            //    preciocantidad = "importe";
            //}
            TxtcambioDv.Location = new Point(rec.Location.X + dataListaMov.Location.X, rec.Location.Y + dataListaMov.Location.Y);

            TxtcambioDv.Visible = true;
            TxtcambioDv.Text = dataListaMov.CurrentCell.Value.ToString();
            TxtcambioDv.Focus();

           
        }

        private void Dtproveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                extraerproveedor(Convert.ToInt32(this.Dtproveedor.CurrentRow.Cells["idproveedor"].Value));
                Dtproveedor.Visible = false;
            }
        }

        private void txtProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && Dtproveedor.Visible == true)
            {
                //si se preciona la tecla hacia abajo se pasa el foco a la grilla
                Dtproveedor.Focus();

            }

            if (e.KeyCode == Keys.Enter && IsNumeric(txtProveedor.Text) == true)
            {
                extraerproveedor(Convert.ToInt32(txtProveedor.Text));
            }
        }

        private void Dtproveedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            extraerproveedor(Convert.ToInt32(this.Dtproveedor.CurrentRow.Cells["idproveedor"].Value));
        }

        private void txtNombreProducto_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreProducto.TextLength >= 2 && IsNumeric(txtNombreProducto.Text) != true)
            {
                Dtproducto.Visible = true;
                Dtproducto.DataSource = NegocioArticulo.buscarNombre(txtNombreProducto.Text);

                Dtproducto.Columns[0].Visible = false;
                Dtproducto.Columns[1].Visible = false;
                Dtproducto.Columns[2].Width = 350;
                Dtproducto.Columns[3].Visible = false;
                Dtproducto.Columns[4].Visible = false;
                Dtproducto.Columns[5].Visible = false;
                Dtproducto.Columns[6].Visible = false;
            }
            else
            {
                Dtproducto.Visible = false;
            }
        }

        private void txtNombreProducto_KeyDown(object sender, KeyEventArgs e)
        {
            NegocioArticulo objart = new NegocioArticulo();
            datagriddobleclic = false;
            if (e.KeyCode == Keys.Down && Dtproducto.Visible == true)
            {
                //si se preciona la tecla hacia abajo se pasa el foco a la grilla
                Dtproducto.Focus();


            }

            if (e.KeyCode == Keys.Enter && IsNumeric(txtNombreProducto.Text) == true)
            {
                txtNombreProducto.Text = txtNombreProducto.TextLength == 12 ? "0" + txtNombreProducto.Text : txtNombreProducto.Text;
                if (txtNombreProducto.TextLength >= 13 && IsNumeric(txtNombreProducto.Text) == true)
                {
                    objart.extraerdatos(0, "porbarra", txtNombreProducto.Text);
                    codigoproducto = objart.IdArticulo.ToString();
                    extraerproducto(objart.IdArticulo);

                }
                else
                {
                    extraerproducto(Convert.ToInt32(txtNombreProducto.Text));
                }

                if (index < 0)
                {
                    if (dataListaMov.Rows.Count != 0)
                    {
                        dataListaMov.Rows[dataListaMov.Rows.Count - 1].Cells[4].Selected = true;
                    }

                }
                else
                {
                    dataListaMov.Rows[index].Cells[4].Selected = true;
                }
                txtNombreProducto.Focus();
                if (chkporcantidad.Checked == true )
                {
                    cambiartextbox();
                }


            }
        }
        private void extraerproducto(int idproducto)
        {
            DataTable midataproducto = new DataTable();

            midataproducto = NegocioArticulo.buscarIdProducto(idproducto.ToString());


            if (midataproducto.Rows.Count != 0)
            {
                DataRow row = midataproducto.Rows[0];
               
                codigoproducto = row["idarticulo"].ToString();
                producto = row["nombre"].ToString();
                precio = row["precio_compra"].ToString();
                precioventa = row["precio"].ToString();
                stockactual = row["stock_actual"].ToString();


            }

            if (totales(Convert.ToInt32(codigoproducto)) == false)
            {
                encontrado = false;
                dataListaMov.Rows.Add(codigoproducto, producto, precio, precioventa, 1, stockactual);

            }
            else
            {
                encontrado = true;
            }

        }

        private void txtcantidad_KeyDown(object sender, KeyEventArgs e)
        {
            
                txtcantidad.Text = txtcantidad.Text == "" ? "1" : txtcantidad.Text;

                if (totales(Convert.ToInt32(codigoproducto)) == false)
                {
                    dataListaMov.Rows.Add(codigoproducto, producto, precio, precioventa, txtcantidad.Text, stockactual);
                }

                txtNombreProducto.Focus();
            
        }

        private void Dtproducto_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            datagriddobleclic = false;
            extraerproducto(Convert.ToInt32(this.Dtproducto.CurrentRow.Cells["idarticulo"].Value));
            Dtproducto.Visible = false;
            txtNombreProducto.Focus();
        }

        private void Dtproducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                extraerproducto(Convert.ToInt32(this.Dtproducto.CurrentRow.Cells["idarticulo"].Value));
                Dtproducto.Visible = false;
                txtNombreProducto.Focus();
                
                txtNombreProducto.Text = string.Empty;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
                txtcantidad.Text = txtcantidad.Text == "" ? "1" : txtcantidad.Text;
                if (totales(Convert.ToInt32(codigoproducto)) == false)
                {
                    dataListaMov.Rows.Add(codigoproducto, producto, precio, precioventa, txtcantidad.Text, stockactual);
                }

                txtNombreProducto.Focus();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string correlativa = "0";
            string serie = "0";
            string comprobante = "";
            string ingresouegreso = "";
            string respuesta = "";

            if (ChRegistrar.Checked == true && proveedor != string.Empty)
            {
                correlativa = txtCorrelativa.Text == string.Empty ? txtCorrelativa.Text = "0" : txtCorrelativa.Text;
                serie = txtSerie.Text == string.Empty ? txtSerie.Text = "0" : txtSerie.Text;
                comprobante = cbTipoComprobante.Text;


            }
            else if (ChRegistrar.Checked == false)
            {
                proveedor = "0";
            }

            DataTable dt = new DataTable();
            dt.Columns.Add("Codigo", typeof(string));
            dt.Columns.Add("Precio", typeof(decimal));
            dt.Columns.Add("PrecioVenta", typeof(decimal));
            dt.Columns.Add("Cantidad", typeof(string));
            dt.Columns.Add("StockActual", typeof(string));

            ingresouegreso = rdbIngreso.Checked == true ? "INGRESO" : "EGRESO";

            foreach (DataGridViewRow row in dataListaMov.Rows)
            {

                dt.Rows.Add(row.Cells[0].Value, row.Cells[2].Value, row.Cells[3].Value, row.Cells[4].Value, row.Cells[5].Value);

            }
            if (dataListaMov.RowCount != 0)
            {
                respuesta = NegocioMovStock.insertar(Convert.ToInt32(proveedor), DateTime.Today,
               serie, correlativa, comprobante, 0, "EMITIDO", ingresouegreso, dt);
            }


            if (respuesta.Equals("ok"))
            {
                limpiartodo();
                UtilityFrm.mensajeConfirm("Se Agrego Correctamente");
                dataListaMov.Rows.Clear();
                //this.mostrar();


            }
            else
            {
                UtilityFrm.mensajeError("No se ha podido Agregar: " + respuesta);

            }
        }
        private void limpiartodo()
        {
            ChRegistrar.Checked = false;
            txtProveedor.Enabled = false;
            cbTipoComprobante.SelectedIndex = 1;
            txtSerie.Enabled = false;
            txtCorrelativa.Enabled = false;
            LblDesprov.Text = "...";
            txtNombreProducto.Text = "";
            lblNomProducto.Text = "...";
            txtcantidad.Text = "";


        }

        private void Dtproducto_Leave(object sender, EventArgs e)
        {
            //Dtproducto.Visible = false;
        }

        private bool totales(int idproducto)
        {
            bool encontrado = false;
            decimal TotalD = 0;
            int cont = -1;
            index = -1;
            foreach (DataGridViewRow row in dataListaMov.Rows)
            {
                cont++;
                if (idproducto != 0)
                {
                    if (Convert.ToInt32(row.Cells["Codigo1"].Value) == idproducto)
                    {
                        row.Cells["cantidad1"].Value = Convert.ToDecimal(row.Cells["cantidad1"].Value) + 1;//+ Convert.ToDecimal(txtcantidad.Text);
                        encontrado = true;
                        index = cont;
                        return encontrado;
                    }
                }
                

                TotalD = TotalD + Convert.ToDecimal(row.Cells["cantidad1"].Value);
            }

            TxtCan.Text = TotalD.ToString();
            TxtItems.Text = dataListaMov.Rows.Count.ToString();
            return encontrado;
        }

        private void dataListaMov_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Rectangle rec = dataListaMov.GetCellDisplayRectangle(dataListaMov.CurrentCell.ColumnIndex, dataListaMov.CurrentCell.RowIndex, false);
            datagriddobleclic = true;
            //e.ColumnIndex == 2 || parametrizacion

            if (dataListaMov.Rows.Count > 0)
            {
                if ((e.ColumnIndex == 2 && (NegocioConfigEmpresa.usuariosa == true ) || (e.ColumnIndex == 4 )))
                {

                    TxtcambioDv.Location = new Point(rec.Location.X + dataListaMov.Location.X, rec.Location.Y + dataListaMov.Location.Y);
                    preciocantidad = "cantidad";
                    TxtcambioDv.Visible = true;
                    TxtcambioDv.Text = dataListaMov.CurrentCell.Value.ToString();
                    TxtcambioDv.Focus();

                   


                }

                //if (e.ColumnIndex == 4)
                //{
                //    preciocantidad = "cantidad";


                //}
                //if (e.ColumnIndex == 2)
                //{
                //    preciocantidad = "Cprecio";


                //}

                //if (e.ColumnIndex == 5)
                //{
                //    preciocantidad = "descuento";

                //}

                //if (e.ColumnIndex == 4)
                //{
                //    preciocantidad = "subtotal";
                //}

            }
        }

        private void TxtcambioDv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (preciocantidad == "cantidad")
                {
                    if (datagriddobleclic == true || encontrado == false)
                    {

                        dataListaMov.CurrentRow.Cells["Cantidad1"].Value = Convert.ToDecimal(TxtcambioDv.Text);
                        datagriddobleclic = false;


                    }
                    else
                    {
                        dataListaMov.CurrentRow.Cells["Cantidad1"].Value = Convert.ToDecimal(TxtcambioDv.Text) + Convert.ToDecimal(dataListaMov.CurrentRow.Cells["Cantidad1"].Value);
                    }

                }
                totales(0);
                txtNombreProducto.Focus();
                TxtcambioDv.Visible = false;

            }
            
        }

        private void btnBuscarProv_Click(object sender, EventArgs e)
        {
            proveedor = "";
            FrmProveedor objproveedor = new FrmProveedor();
            objproveedor.Opcionvista = 2;
            objproveedor.ShowDialog();
            proveedor = objproveedor.Codigoproveedor.ToString();
            if (proveedor != string.Empty)
            {
                extraerproveedor(Convert.ToInt32(proveedor));
            }
        }

        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            datagriddobleclic = false;
            FrmAvanzadoArticulo objavanzado = new FrmAvanzadoArticulo("STOCK");
            objavanzado.Listadodearticulo = dataListaMov;

            objavanzado.ShowDialog();
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
        int posY = 0;
        int posX = 0;
        
        private void FrmMovStock1_Move(object sender, EventArgs e)
        {
            
        }

        private void FrmMovStock1_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn c in dataListaMov.Columns)
            {
                if ((c.Index != 4))
                {
                    c.ReadOnly = true;
                }

            }
        }

        private void FrmMovStock1_MouseMove(object sender, MouseEventArgs e)
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

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            //restaurar
            this.btnRestaurar.Visible = false;
            this.btnMaximizar.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(0,100,200);
        }

        private void btnMinimizar_MouseMove(object sender, MouseEventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(65, 39, 60);
        }

        private void btnMaximizar_MouseLeave(object sender, EventArgs e)
        {
            btnMaximizar.BackColor = Color.FromArgb(0,100,200);
        }

        private void btnMaximizar_MouseMove(object sender, MouseEventArgs e)
        {
            btnMaximizar.BackColor = Color.FromArgb(65, 39, 60);
        }

        private void btnRestaurar_MouseLeave(object sender, EventArgs e)
        {
            btnRestaurar.BackColor = Color.FromArgb(0,100,200);
        }

        private void btnRestaurar_MouseMove(object sender, MouseEventArgs e)
        {
            btnRestaurar.BackColor = Color.FromArgb(65, 39, 60);
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.FromArgb(0,100,200);
        }

        private void btnCerrar_MouseMove(object sender, MouseEventArgs e)
        {

            btnCerrar.BackColor = Color.Red;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down && Dtproducto.Visible == true)
            {
                //si se preciona la tecla hacia abajo se pasa el foco a la grilla
                Dtproducto.Focus();


            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreProducto.TextLength >= 2 && IsNumeric(txtNombreProducto.Text) != true)
            {
                Dtproducto.Visible = true;
                Dtproducto.DataSource = NegocioArticulo.buscarNombre(txtNombreProducto.Text);

                Dtproducto.Columns[0].Visible = false;
                Dtproducto.Columns[1].Visible = false;
                Dtproducto.Columns[2].Width = 350;
                Dtproducto.Columns[3].Visible = false;
                Dtproducto.Columns[4].Visible = false;
                Dtproducto.Columns[5].Visible = false;
                Dtproducto.Columns[6].Visible = false;
            }
            else
            {
                Dtproducto.Visible = false;
            }
        }

        private void ChRegistrar_CheckedChanged(object sender, EventArgs e)
        {
            txtProveedor.Enabled = ChRegistrar.Checked;
            cbTipoComprobante.Enabled = ChRegistrar.Checked;
            txtSerie.Enabled = ChRegistrar.Checked;
            txtCorrelativa.Enabled = ChRegistrar.Checked;
            btnBuscarProv.Enabled = ChRegistrar.Checked;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            NegocioMovStock objstock = new NegocioMovStock();

            dataLista.DataSource = NegocioMovStock.buscarFecha(dtpFechaIni.Text, dtpFechaFin.Text);
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

        private void dataLista_RowLeave(object sender, DataGridViewCellEventArgs e)
        {    //label3.Text = dataLista.CurrentRow.Cells["idmov_stock"].Value.ToString ();
            dataGridView1.DataSource = NegocioMovStock.mostrarDetalleMovStock(Convert.ToInt32(dataLista.CurrentRow.Cells["idmov_stock"].Value));
        }

        private void dataLista_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //label3.Text = dataLista.CurrentRow.Cells["idmov_stock"].Value.ToString();
                dataGridView1.DataSource = NegocioMovStock.mostrarDetalleMovStock(Convert.ToInt32(dataLista.CurrentRow.Cells["idmov_stock"].Value));
                
            }
        }

        private void dataLista_SelectionChanged(object sender, EventArgs e)
        {
            //label3.Text = dataLista.CurrentRow.Cells["idmov_stock"].Value.ToString();
            dataGridView1.DataSource = NegocioMovStock.mostrarDetalleMovStock(Convert.ToInt32(dataLista.CurrentRow.Cells["idmov_stock"].Value));
        }

        private void txtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataListaMov_DoubleClick(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FrmMovStock1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
            {
                if (chkporcantidad.Checked == true)
                { chkporcantidad.Checked = false; }
                else
                { chkporcantidad.Checked = true; }
            }
        }
    }
}
