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
using System.Globalization;

namespace Capa_Presentacion
{
    public partial class FrmDetalleVentas : Form
    {
        private string idcliente;
        private string letra;
        public FrmDetalleVentas()
        {
            InitializeComponent();
        }
        public FrmDetalleVentas(string codigoVenta,string razon_social,string fecha,string tipo_comprobante,string estado,string total, string varidcliente, string cuit, string varletra)
        {
            InitializeComponent();
            txtCodigo.Text = codigoVenta;
            txtEstado.Text = estado;
            txtTipoComprobante.Text = tipo_comprobante;
            txtRazonSocial.Text = razon_social;
            txtFechaVenta.Text = fecha;
            txtTotal.Text = total;
            txtcuit.Text = cuit;
            idcliente = varidcliente;
            letra = varletra;

            mostrar();
        }
        private void FrmDetalleVentas_Load(object sender, EventArgs e)
        {
            dataLista.Columns["cantidad"].DefaultCellStyle.Format = String.Format("###,##0.000");
            dataLista.Columns["precio"].DefaultCellStyle.Format = String.Format("$###,##0.00");
            dataLista.Columns["descuento"].DefaultCellStyle.Format = String.Format("###,##0.00");
            dataLista.Columns["Importe"].DefaultCellStyle.Format = String.Format("$###,##0.00");

            btnPagarMovimiento.Enabled = txtEstado.Text == "PENDIENTE" ? true : false;
            btncredito.Enabled = txtEstado.Text == "FACTURADO" ? true : false;

            if (NegocioConfigEmpresa.emciva == "MN")
            {
                
                cbxCategoria.Items.Add("C");
                cbxCategoria.Items.Add("X");
                //cbxCategoria.Text = "C";
            }
            if (NegocioConfigEmpresa.emciva == "RI")
            {
                cbxCategoria.Items.Add("A");
                cbxCategoria.Items.Add("B");
                cbxCategoria.Items.Add("X");
                //cbxCategoria.Text = "B";
            }
            cbxCategoria.Text = letra;

            if (letra == "X")
            {
                cbxCategoria.Enabled = true;
            }
            else
            {
                cbxCategoria.Enabled = false;
            }

        }
        private void btnPagarMovimiento_Click(object sender, EventArgs e)
        {
            impresioncomprobante("FACTURA");
            
        }
        public void impresioncomprobante(string tipocomprobante)
        {
            string msg = "ok";
            decimal iva105;
            decimal iva21;
            decimal neto105;
            decimal neto21;
            Negociocomprobantes objcomprobante = new Negociocomprobantes();
            char estadofactura = 'P';
            DataTable datacliente = new DataTable();
            DataTable dataventa = new DataTable();
            datacliente = NegocioCliente.buscarCodigoCliente(idcliente);
            dataventa = NegocioVenta.buscarventa(Convert.ToInt32(txtCodigo.Text));
            string nrocomprobante = "0";
            DataRow row = datacliente.Rows[0];
            DataRow rowventa = dataventa.Rows[0];
            neto21 = decimal.Round(Convert.ToDecimal(rowventa["Neto21"].ToString()), 2);
            iva21 = decimal.Round(Convert.ToDecimal(rowventa["Totaliva21"].ToString()), 2);
            neto105 = decimal.Round(Convert.ToDecimal(rowventa["Total_Neto105"].ToString()), 2);
            iva105 = decimal.Round(Convert.ToDecimal(rowventa["TotalIva105"].ToString()), 2);
            int varidventa = 0;

            DataTable dt = detalleventa(row["responsabilidadiva"].ToString());

            if (NegocioConfigEmpresa.confsistema("facturar").ToString() == "True" && txtTipoComprobante.Text == "NOTA DE VENTA" && cbxCategoria.Text != "X")
            {
                //&& tipo_comprobante == "NOTA DE VENTA"

                msg = objcomprobante.factura(NegocioConfigEmpresa.marcafiscal, dt, Convert.ToDouble(txtTotal.Text), NegocioConfigEmpresa.modelofiscal, NegocioConfigEmpresa.puertofiscal,
                 1, row["razon_social"].ToString(), row["razon_social"].ToString() == "CONSUMIDOR FINAL" ? "99999999" : row["cuit"].ToString(), row["direccion"].ToString(), cbxCategoria.Text,
                 row["responsabilidadiva"].ToString(), tipocomprobante, cbxCategoria.Text, Convert.ToDouble(neto21), Convert.ToDouble(iva21),
                 Convert.ToDouble(neto105), Convert.ToDouble(iva105));

                if (msg.Substring(0, 2) != "ok")
                {
                    UtilityFrm.mensajeError(msg);
                    if (tipocomprobante == "FACTURA")
                    {
                        UtilityFrm.mensajeConfirm("Se guardara la venta como pendiente de factura la puede encontrar en lista de ventas");
                        estadofactura = 'P';
                        
                    }
                    else
                    {
                        UtilityFrm.mensajeConfirm("La nota de credito no se pudo realizar");
                    }
                    return;
                }
                else
                {
                    int nrocaracteres = Convert.ToInt32(msg.Length.ToString());
                    nrocomprobante = msg.Substring(2, nrocaracteres - 2);

                    if (tipocomprobante == "FACTURA")
                    {
                        estadofactura = 'F';
                    }
                    else
                    {
                        estadofactura = 'N';
                    }


                }
                this.Close();
            }
            else if (txtTipoComprobante.Text == "PRESUPUESTO")
            {
                estadofactura = 'P';
            }
            string mensaje = "ok";
            if (cbxCategoria.Text != "X")
            {
                try
                {
                    varidventa = NegocioVenta.cambiarestadoventa(Convert.ToInt32(txtCodigo.Text), estadofactura, nrocomprobante.PadLeft(8, '0'), objcomprobante.Cae,
                         objcomprobante.Fechavto, objcomprobante.Puntoventa.PadLeft(5, '0'), objcomprobante.Numerotipofactura.PadLeft(3, '0'));
                }
                catch (Exception ex)
                {

                    mensaje = ex.ToString();
                }
               
                
            }
            else
            {
                UtilityFrm.mensajeError("PARA PODER REALIZAR LA FACTURA TIENE QUE CAMBIAR EL NUMERO DE LETRA");
                return;
            }

            if (mensaje.Equals("ok"))
            {
                if (tipocomprobante == "FACTURA")
                {
                    UtilityFrm.notificacionpopup("FACTURACION","LA FACTURACION SE REALIZO CORRECTAMENTE");
 //                   UtilityFrm.mensajeConfirm("La facturación se realizó Correctamente");
                }
                else
                {
                    UtilityFrm.mensajeConfirm("La nota de credito se realizo correctamente");
                }

                Close();
            }
            else
            {
                UtilityFrm.mensajeError(mensaje);
            }

        }
        public DataTable detalleventa(string responsableiva)
        {
            string precioneto = "";
            decimal var = 0;
            DataTable datacliente = new DataTable();
            
            

            DataTable dt = new DataTable();
            dt.Columns.Add("Codigo", typeof(string));
            dt.Columns.Add("Precio", typeof(decimal));
            dt.Columns.Add("Cantidad", typeof(decimal));
            dt.Columns.Add("Descuento", typeof(decimal));
            dt.Columns.Add("Importe", typeof(decimal));
            dt.Columns.Add("Producto", typeof(string));
            dt.Columns.Add("Precioneto", typeof(string));
            dt.Columns.Add("Pesable", typeof(int));
            NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;

           

            DataTable ventas = NegocioVenta.MostrarDetalle(txtCodigo.Text);
            foreach (DataRow venta in ventas.Rows)
            {
                if (responsableiva != "EX")
                {
                     var = Decimal.Round(Convert.ToDecimal(venta["precio"]) / Convert.ToDecimal(1.21), 4);
                }
                else
                {
                    var = Decimal.Round(Convert.ToDecimal(venta["precio"]));
                }
                
                //Math.Round(decValue, 2, MidpointRounding.AwayFromZero)
                // var = Math.Round(var, 2, MidpointRounding.AwayFromZero);

                precioneto = var.ToString("0.0000", nfi);
                //recorro la lista pasado por paramentro y asigno al datatable para generar la transaccion
                //dt.Rows.Add(fila.Cells["Codigo"].Value, fila.Cells["Precio"].Value, fila.Cells["Cantidad"].Value, fila.Cells["Descuento"].Value, fila.Cells["Importe"].Value);
                // dt.Rows.Add(fila.Cells["Codigo"].Value, fila.Cells["Precio"].Value, fila.Cells["Cantidad"].Value, fila.Cells["Descuento"].Value, fila.Cells["Importe"].Value, fila.Cells["Producto"].Value, precioneto);


                //string tipo_comprobante = venta["tipo_comprobante"].ToString();
                //tipo_comprobante = tipo_comprobante == "V" ? "VENTA" : "";
                dt.Rows.Add(venta["idarticulo"], venta["precio"], venta["cantidad"], venta["descuento"], venta["importe"], venta["articulo"], precioneto, venta["Pesable"]);
                //
            }
            return dt;
        
        }
        public void mostrar() {

            try
            {
                dataLista.Rows.Clear();
                DataTable ventas = NegocioVenta.MostrarDetalle(txtCodigo.Text);
                foreach (DataRow venta in ventas.Rows)
                {

                   

                    //string tipo_comprobante = venta["tipo_comprobante"].ToString();
                    //tipo_comprobante = tipo_comprobante == "V" ? "VENTA" : "";
                    dataLista.Rows.Add(venta["idarticulo"], venta["articulo"], venta["precio"], venta["descuento"], venta["cantidad"], venta["importe"]);
                    //
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

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            this.exportarAExcel();
        }
        public void exportarAExcel()
        {
            try
            {
                SaveFileDialog fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls";
                fichero.FileName = "Venta Numero "+ txtCodigo.Text+"- "+   DateTime.Now.ToString("dd-MM-yyyy");
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application aplicacion;
                    Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                    Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                    aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    libros_trabajo = aplicacion.Workbooks.Add();
                    hoja_trabajo =
                    (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.ActiveSheet ;
                    //hoja_trabajo.Cells.Font.Bold = true;
                    hoja_trabajo.Cells.Rows[1].Font.Bold = true;
                    hoja_trabajo.Cells.Rows[1].Font.Size = 15;
                    hoja_trabajo.Cells[1, 1] = "Venta Nº : "+txtCodigo.Text+ " - Fecha "+txtFechaVenta.Text;
                   

                    hoja_trabajo.Range[hoja_trabajo.Cells[1, 1], hoja_trabajo.Cells[1, 10]].Merge();

                   // rango.Merge(true);
                    
                    //Recorremos el DataGridView rellenando la hoja de trabajo
                    for (int i = 0; i < dataLista.Columns.Count; i++)
                    {

                        hoja_trabajo.Cells[2, i + 1] = dataLista.Columns[i].Name;
                    }

                    for (int i = 0; i < dataLista.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataLista.Columns.Count; j++)
                        {
                            //se coloca 3 porque la primera celda pertenece al nombre de la columna y luego los datos
                            hoja_trabajo.Cells[i+3 , j + 1] = dataLista.Rows[i].Cells[j].Value.ToString();
                        }
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

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            //minimiza
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            //maximizar
            this.btnRestaurar.Visible = true;
            this.btnMaximizar.Visible = false;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            //restaurar
            this.btnRestaurar.Visible = false;
            this.btnMaximizar.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbDetalleMovimento_Enter(object sender, EventArgs e)
        {

        }

        private void btncredito_Click(object sender, EventArgs e)
        {
            impresioncomprobante("NOTA DE CREDITO");
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
    }
}
