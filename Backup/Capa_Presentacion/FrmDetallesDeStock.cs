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
namespace Capa_Presentacion
{
    public partial class FrmDetallesDeStock : Form
    {
        
        public FrmDetallesDeStock(string codigoMov,string fecha,string movimiento,string estado,string total)
        {
            InitializeComponent();
            txtCodigo.Text = codigoMov;
            txtFechaMov.Text = fecha;
            txtMovimiento.Text = movimiento;
            txtEstado.Text = estado;
            txtTotal.Text = total;

        }
        
        public FrmDetallesDeStock()
        {
            InitializeComponent();
        }
        public void mostrar() {
            try
            {
                dataLista.Rows.Clear();
                DataTable productos = NegocioMovStock.mostrarDetalleMovStock(Convert.ToInt32(txtCodigo.Text));
                foreach (DataRow producto in productos.Rows)
                {


                    dataLista.Rows.Add(producto["idarticulo"], producto["Nombre del Producto"], producto["PrecioCompra"], producto["cantidad"], producto["subTotal"]);
                }

                //this.dataLista.Columns["precio"].DefaultCellStyle.Format = "c3";
                //this.dataLista.Columns["precio"].ValueType = Type.GetType("System.Decimal");
                this.dataLista.Columns["precioCompra"].DefaultCellStyle.Format = String.Format("###,##0.00");
                this.dataLista.Columns["subtotal"].DefaultCellStyle.Format = String.Format("###,##0.00");

            }
            catch (Exception ex)
            {
                UtilityFrm.mensajeError("error con la Base de datos: " + ex.Message);
            }
            //datasource el origen de los datos,muestra las categorias en la grilla



        }
        private void dataLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmDetallesDeStock_Load(object sender, EventArgs e)
        {
            this.mostrar();
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
                    hoja_trabajo.Cells[1, 1] = "Movimiento de Stock Nº: " + txtCodigo.Text + " Fecha " + txtFechaMov.Text;
                   

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
        
    }
}
