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
        public FrmDetalleVentas()
        {
            InitializeComponent();
        }
        public FrmDetalleVentas(string codigoVenta,string razon_social,string fecha,string tipo_comprobante,string estado,string total, string varidcliente, string cuit)
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
        }
        private void btnPagarMovimiento_Click(object sender, EventArgs e)
        {
            impresioncomprobante("FACTURA");
            
        }
        public void impresioncomprobante(string tipocomprobante)
        {
            string msg = "ok";
            Negociocomprobantes objcomprobante = new Negociocomprobantes();
            char estadofactura = 'P';
            DataTable datacliente = new DataTable();
            datacliente = NegocioCliente.buscarCodigoCliente(idcliente);
            string nrocomprobante = "0";
            DataRow row = datacliente.Rows[0];
            DataTable dt = detalleventa(row["responsabilidadiva"].ToString());
            
            if (NegocioConfigEmpresa.confsistema("facturar").ToString() == "True" && txtTipoComprobante.Text == "NOTA DE VENTA")
            {
                //&& tipo_comprobante == "NOTA DE VENTA"
                msg = objcomprobante.factura(NegocioConfigEmpresa.marcafiscal, dt, Convert.ToDouble(txtTotal.Text), NegocioConfigEmpresa.modelofiscal, NegocioConfigEmpresa.puertofiscal,
                 1, row["razon_social"].ToString(), row["razon_social"].ToString() == "CONSUMIDOR FINAL" ? "99999999999" : row["cuit"].ToString(), row["direccion"].ToString(), "B", row["responsabilidadiva"].ToString(),tipocomprobante);
                if (msg.Substring(0, 2) != "ok")
                {
                    UtilityFrm.mensajeError(msg);
                    UtilityFrm.mensajeConfirm("Se guardara la venta como pendiente de factura la puede encontrar en lista de ventas");
                    estadofactura = 'P';
                }
                else
                {
                    nrocomprobante = msg.Substring(2, 8);
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
            string mensaje = NegocioVenta.cambiarestadoventa(Convert.ToInt32(txtCodigo.Text), estadofactura, nrocomprobante);

            if (mensaje.Equals("ok"))
            {
                UtilityFrm.mensajeConfirm("La facturación se realizó Correctamente");
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
    }
}
