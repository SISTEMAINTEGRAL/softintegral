using Capa_negocio;
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
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.Reporting.WinForms;
using Capa_Presentacion.Formreportes;
using Telerik.Reporting.Processing;


namespace Capa_Presentacion
{
    public partial class FrmListadoVentas : Form
    {
        public string idventa = "";
        
        public FrmListadoVentas()
        {
            InitializeComponent();
        }

        private void FrmListadoVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DVentaproducto.REPORTE_VENTAPRODUCTO' Puede moverla o quitarla según sea necesario.

            //this.mostrar();
            cbFormapago.SelectedIndex = 2;
            this.buscarPorFecha();
            this.actualizarTotal();
            this.mensajesDeAyuda();
            this.dataLista.Columns["Total"].DefaultCellStyle.Format = String.Format("###,##0.00");
            this.dataLista.Columns["fecha"].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm:ss";

            
            Chkcaja.Enabled = checkradiobuton();
            ChkFactura.Enabled = checkradiobuton();
            this.reportViewer1.RefreshReport();
            
        }

        private bool checkradiobuton()
        {
            bool flag = true;

            if (rdBVenta.Checked == true)
            {
               flag = true;

            }
            if (rdBPresupuesto.Checked == true)
            {
                flag = false;

            }
            return flag;
        
        }
        //mensajes de ayuda
        private void mensajesDeAyuda()
        {

            //mensaje de ayuda en el textbox total
            this.ttMensajeAyuda.SetToolTip(this.txtTotal, "Total de ventas");
            //mensaje de ayuda en el textbox buscar
            this.ttMensajeAyuda.SetToolTip(this.btnBuscar, "Buscar por fecha seleccionada");
            //mensaje de ayuda del boton listar ventas
            this.ttMensajeAyuda.SetToolTip(this.btnTodos, "Listar todas las ventas");
            //mensaje de ayuda del boton exportar excel
            this.ttMensajeAyuda.SetToolTip(this.btnExportarExcel,"Exportar a excel");
            //mensaje de ayuda del boton torta
            this.ttMensajeAyuda.SetToolTip(this.btnVisualizadorTorta, "Visualizar en forma de Pastel los 5 productos mas vendidos");
            //mensaje de ayuda del boton area
            this.ttMensajeAyuda.SetToolTip(this.btnVisualizadorArea, "Visualizar en forma de area los 5 productos mas vendidos");
            //mensaje de ayuda del boton grafico
            this.ttMensajeAyuda.SetToolTip(this.btnVisualizarGrafico, "Visualizar en forma de columnas los 5 productos mas vendidos");
        }

        public void mostrar()
        {
            try
            {
                dataLista.Rows.Clear();
                DataTable ventas = NegocioVenta.Mostrar();
                foreach (DataRow venta in ventas.Rows)
                {

                    string estado = venta["estado"].ToString();

                    if (estado.Equals("F"))
                    {
                        estado = "FACTURADO";

                    }
                    else if(estado.Equals("P")){
                        estado = "PENDIENTE";
                    }


                    //string tipo_comprobante = venta["tipo_comprobante"].ToString();
                    //tipo_comprobante = tipo_comprobante == "V" ? "VENTA" : "";
                    dataLista.Rows.Add(venta["idventa"], venta["razon_social"], venta["fecha"], venta["tipo_comprobante"], venta["total"],estado,venta["Factura"]);
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
        public void exportarAExcel()
        {
            try
            {
                SaveFileDialog fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls";
                fichero.FileName = "Listado de ventas - " + DateTime.Now.ToString("dd-MM-yyyy");
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application aplicacion;
                    Microsoft.Office.Interop.Excel.Workbook libros_trabajo;
                    Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
                    aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    libros_trabajo = aplicacion.Workbooks.Add();
                    hoja_trabajo =
                        (Microsoft.Office.Interop.Excel.Worksheet)libros_trabajo.Worksheets.get_Item(1);
     
            
                   if(dataLista.Rows.Count>0){
                       //le paso el formato adecuado para los valores decimales pasando desde la fila 2 hasta datalista.rows.count+1 osea hasta el ultimo elemento
                       hoja_trabajo.Range[hoja_trabajo.Cells[2, 6], hoja_trabajo.Cells[dataLista.Rows.Count+1, 5]].NumberFormat = "0,00";
                   
                   }
                    //Recorremos el DataGridView rellenando la hoja de trabajo
                    for (int i = 0; i < dataLista.Columns.Count; i++)
                    {
                       
                        hoja_trabajo.Cells[1, i+1] = dataLista.Columns[i].Name;
                       
                    }

                   
                    for (int i = 0; i < dataLista.Rows.Count; i++)
                    {

                        hoja_trabajo.Cells[i + 2, 1] = dataLista.Rows[i].Cells["codigo"].Value.ToString();
                        hoja_trabajo.Cells[i + 2, 2] = dataLista.Rows[i].Cells["razon_social"].Value.ToString();
                        hoja_trabajo.Cells[i + 2, 3] = dataLista.Rows[i].Cells["fecha"].Value.ToString();
                        hoja_trabajo.Cells[i + 2, 4] = dataLista.Rows[i].Cells["tipo_comprobante"].Value.ToString();
                        hoja_trabajo.Cells[i + 2, 5] =  dataLista.Rows[i].Cells["total"].Value;
                        hoja_trabajo.Cells[i + 2, 6] = dataLista.Rows[i].Cells["estado"].Value.ToString();
                        hoja_trabajo.Cells[i + 2, 9] = dataLista.Rows[i].Cells["cuit"].Value.ToString();
                        hoja_trabajo.Cells[i + 2, 10] = dataLista.Rows[i].Cells["Nrocomprobante"].Value.ToString();
                        hoja_trabajo.Cells[i + 2, 11] = dataLista.Rows[i].Cells["Letra"].Value.ToString();
                        hoja_trabajo.Cells[i + 2, 12] = dataLista.Rows[i].Cells["Neto21"].Value.ToString();
                        hoja_trabajo.Cells[i + 2, 13] = dataLista.Rows[i].Cells["Totaliva21"].Value.ToString();
                        hoja_trabajo.Cells[i + 2, 14] = dataLista.Rows[i].Cells["Total_Neto105"].Value.ToString();
                        hoja_trabajo.Cells[i + 2, 15] = dataLista.Rows[i].Cells["Totaliva105"].Value.ToString();
                        hoja_trabajo.Cells[i + 2, 16] = dataLista.Rows[i].Cells["CAE"].Value.ToString();
                        hoja_trabajo.Cells[i + 2, 17] = dataLista.Rows[i].Cells["CAE_Fechavencimiento"].Value.ToString();

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

                UtilityFrm.mensajeError("Error: "+ex.Message);
            }
           
        }
        public void actualizarTotal() {
            decimal totalVendido= Convert.ToDecimal("0,00");
            
            if (dataLista.Rows.Count > 0)
            {
                foreach (DataGridViewRow venta in dataLista.Rows)
                {
                    totalVendido = totalVendido+ decimal.Round( Convert.ToDecimal( venta.Cells["Total"].Value),2);
                }
                txtTotal.Text = totalVendido.ToString();
            }
            else {

                txtTotal.Text = "0,00";
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.buscarPorFecha();
            this.actualizarTotal();
        }

        /*Metodos propios*/
        public void buscarPorFecha()
        {
            int codformapago = 0;
            switch (cbFormapago.Text)
            {
                case "EFECTIVO":
                    {
                        codformapago = 1;
                        break;
                    }
                case "TARJETA":
                    {
                        codformapago = 2;
                        break;
                    }
                case "CTACTE":
                    {
                        codformapago = 3;
                        break;
                    }

                default:
                    break;
            }
            dataLista.Rows.Clear();
            try
            {
                DataTable dt = NegocioVenta.BuscarFechas(dtpFechaIni.Value.ToString("dd/MM/yyyy") + " 00:00:00", dtpFechaFin.Value.ToString("dd/MM/yyyy") + " 23:59:59",
                    ChkFactura.Checked == true ? 'P' : 'F',Chkcaja.Checked == true ? false : true, rdBPresupuesto.Checked == true ? "PRESUPUESTO" : "NOTA DE VENTA" ,
                    txtIdVenta.Text != "" ? Convert.ToInt32(txtIdVenta.Text) : 0,  txtPuntoventa.Text.PadLeft(5, '0'), codformapago,
                    txtIdVenta.Text != "" ? true : false,cbFormapago.Text != "TODO" ? true : false, txtPuntoventa.Text != "" ? true : false );
                foreach (DataRow venta in dt.Rows)
                {

                    string estado = venta["estado"].ToString();

                    if (estado.Equals("F"))
                    {
                        estado = "FACTURADO";

                    }
                    else if (estado.Equals("P"))
                    {
                        estado = "PENDIENTE";
                    }
                    else if (estado.Equals ("N"))
	                    {
                            estado = "NOTA DE CREDITO";
	                    }
                    else
                    {
                        estado = "PRESUPUESTADO";
                    }
                    dataLista.Rows.Add(venta["idventa"], venta["razon_social"], venta["fecha"], venta["tipo_comprobante"], venta["total"], estado, venta ["caja"], venta ["idcliente"],
                        venta ["cuit"], venta["Nrocomprobante"], venta["factura"], venta["Neto21"], venta["Totaliva21"], venta["Total_Neto105"], venta["Totaliva105"], venta["CAE"],
                        venta["CAE_Fechavencimiento"], venta["enstock"], venta ["formadepago"], venta ["PAGO"]);
                }
       
            }

            catch (Exception ex)
            {
                UtilityFrm.mensajeError("Error Con Base de Datos :" + ex.Message);

            }
           
           

        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            this.mostrar();
            this.actualizarTotal();
        }

       


      

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            //calculadora
            Process proceso = new Process();
            proceso.StartInfo.FileName = "calc.exe";
            proceso.StartInfo.Arguments = "";
            proceso.Start();
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            exportarAExcel();
        }

       

        


        //VENTANA Y PANEL SUPERIOR

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            //maximizar
            this.btnRestaurar.Visible = true;
            this.btnMaximizar.Visible = false;
            this.WindowState = FormWindowState.Maximized;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //cierra
            this.Close();
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
        private void btnCerrar_MouseMove(object sender, MouseEventArgs e)
        {
            btnCerrar.BackColor = Color.Red;
        }
        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.FromArgb(0, 100, 200);
        }
        private void btnRestaurar_MouseMove(object sender, MouseEventArgs e)
        {
            btnRestaurar.BackColor = Color.FromArgb(65, 39, 60);
        }
        private void btnRestaurar_MouseLeave(object sender, EventArgs e)
        {
            btnRestaurar.BackColor = Color.FromArgb(0, 100, 200);
        }
        private void btnMaximizar_MouseMove(object sender, MouseEventArgs e)
        {
            btnMaximizar.BackColor = Color.FromArgb(65, 39, 60);
        }
        private void btnMaximizar_MouseLeave(object sender, EventArgs e)
        {
            btnMaximizar.BackColor = Color.FromArgb(0, 100, 200);
        }
        private void btnMinimizar_MouseMove(object sender, MouseEventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(65, 39, 60);
        }
        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(0, 100, 200);

        }

        private void dataLista_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
               if (dataLista.Rows.Count > 0)
                {
                    DateTime date = Convert.ToDateTime(this.dataLista.CurrentRow.Cells["fecha"].Value);
                    
                    FrmDetalleVentas venta = new FrmDetalleVentas(Convert.ToString(this.dataLista.CurrentRow.Cells["codigo"].Value),
                        Convert.ToString(this.dataLista.CurrentRow.Cells["Razon_social"].Value),
                        date.ToShortDateString(),
                         Convert.ToString(this.dataLista.CurrentRow.Cells["tipo_comprobante"].Value),
                        Convert.ToString(this.dataLista.CurrentRow.Cells["estado"].Value),
                        Convert.ToString(Decimal.Round(Convert.ToDecimal(this.dataLista.CurrentRow.Cells["total"].Value), 2))
                        , Convert.ToString(this.dataLista.CurrentRow.Cells["idcliente"].Value), 
                        Convert.ToString(this.dataLista.CurrentRow.Cells["cuit"].Value),
                        Convert.ToString(this.dataLista.CurrentRow.Cells["letra"].Value));
                    venta.ShowDialog();
                  
                }
           
           
           
        }
        private void dataLista_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                DTDetalleventa.DataSource = NegocioVenta.MostrarDetalle(dataLista.CurrentRow.Cells["Codigo"].Value.ToString ());
            }

            if (e.KeyCode == Keys.Enter)
            {
                if (dataLista.Rows.Count > 0)
                {

                    DateTime date = Convert.ToDateTime(this.dataLista.CurrentRow.Cells["fecha"].Value);

                    FrmDetalleVentas venta = new FrmDetalleVentas(Convert.ToString(this.dataLista.CurrentRow.Cells["codigo"].Value),
                        Convert.ToString(this.dataLista.CurrentRow.Cells["razon_social"].Value),
                        date.ToShortDateString(),
                         Convert.ToString(this.dataLista.CurrentRow.Cells["tipo_comprobante"].Value),
                        Convert.ToString(this.dataLista.CurrentRow.Cells["estado"].Value),
                        Convert.ToString(Decimal.Round(Convert.ToDecimal(this.dataLista.CurrentRow.Cells["total"].Value), 2))
                        , Convert.ToString(this.dataLista.CurrentRow.Cells["idcliente"].Value), Convert.ToString(this.dataLista.CurrentRow.Cells["cuit"].Value), Convert.ToString(this.dataLista.CurrentRow.Cells["letra"].Value));
                    venta.ShowDialog();
                   
                }

            }

        }

        private void btnVisualizarLista_Click(object sender, EventArgs e)
        {
            if (dataLista.Visible == false && chartRankingVentas.Visible == true)
            {
                dataLista.Visible = true;
                chartRankingVentas.Visible = false;
                txtTotal.Visible = true;
                lblTotal.Visible = true;
            }

            if (reportViewer1.Visible == true)
            {
                
                reportViewer1.Visible = false;
            }
        }

        private void btnVisualizarGrafico_Click(object sender, EventArgs e)
        {
            chartRankingVentas.Series["Ventas"].ChartType = SeriesChartType.Column;

            if (reportViewer1.Visible == true)
            {
                reportViewer1.Visible = false;
            }

            if (dataLista.Visible == true&&chartRankingVentas.Visible==false)
            {
                dataLista.Visible = false;
                txtTotal.Visible = false;
                lblTotal.Visible = false;
                mostrarRanking5Producto();
               
            }
        }

        private void btnVisualizadorTorta_Click(object sender, EventArgs e)
        {
            chartRankingVentas.Series["Ventas"].ChartType = SeriesChartType.Pie;
            if (dataLista.Visible == true && chartRankingVentas.Visible == false)
            {
                dataLista.Visible = false;
                txtTotal.Visible = false;
                lblTotal.Visible = false;
      
                mostrarRanking5Producto();

            }
            if (reportViewer1.Visible == true)
            {
                reportViewer1.Visible = false;
            }
        }

        private void btnVisualizadorArea_Click(object sender, EventArgs e)
        {

            if (reportViewer1.Visible == true )
            {
                reportViewer1.Visible = false;
            }
            chartRankingVentas.Series["Ventas"].ChartType = SeriesChartType.Area; 
            if (dataLista.Visible == true && chartRankingVentas.Visible == false)
            {
                dataLista.Visible = false;
                txtTotal.Visible = false;
                lblTotal.Visible = false;


                mostrarRanking5Producto();

            }
        }
        public void mostrarRanking5Producto(){
            try
            {
                DataTable dt = NegocioVenta.MostrarRanking5Productos();
                if (dt.Rows.Count > 0)
                {
                    chartRankingVentas.Series["Ventas"].Points.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        chartRankingVentas.Series["Ventas"].Points.AddXY(row["nombre"], row["cantidad"]);
                    }


                    //ejemplo: chartRankingVentas.Series["Ventas"].Points.AddXY("Producto2", 50);
                    //chartRankingVentas.Series["Ventas"].Points.AddXY("Producto3", 20);
                    //chartRankingVentas.Series["Ventas"].Points.AddXY("Producto4", 70);
                    //chartRankingVentas.Series["Ventas"].Points.AddXY("Producto5", 1000);
                    chartRankingVentas.Visible = true;

                }
                else
                {

                    UtilityFrm.mensajeError("No existen ventas en este momento");
                    chartRankingVentas.Visible = true;
                }

            }
            catch (Exception ex)
            {

                UtilityFrm.mensajeError("Error: "+ex.Message);
            }
           
        }

        private void dataLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
           DTDetalleventa.DataSource = NegocioVenta.MostrarDetalle(dataLista.CurrentRow.Cells["Codigo"].Value.ToString ());
        }

        private void dataLista_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow row = dataLista.CurrentRow;
            if (e.Button == MouseButtons.Right)
            {
                if (Convert.ToBoolean(row.Cells["caja"].Value) == false && Convert.ToString (row.Cells["Tipo_comprobante"].Value) != "PRESUPUESTO")
                {
                    menuconfventa.Visible = true;
                }
                else
                {
                    menuconfventa.Visible = false;
                }
                
                contextMenuStrip1.Show(dataLista, new Point(e.X, e.Y));

                if (Convert.ToString(row.Cells["Estado"].Value) != "FACTURADO")
                {
                    if (Convert.ToString(row.Cells["Estado"].Value) != "PRESUPUESTO")
                    {
                        MenuAnular.Visible = true;
                    }
                    
                }
                else
                {
                    MenuAnular.Visible = false;
                }

            }

            if (e.Button == MouseButtons.Left)
            {
                DTDetalleventa.DataSource = NegocioVenta.MostrarDetalle(dataLista.CurrentRow.Cells["Codigo"].Value.ToString ());
            }
        }

        private void menuconfventa_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            bool constock = false;
            try
            {
                Negociocaja objcaja = new Negociocaja();
                
                DataGridViewRow row = dataLista.CurrentRow;
                if (Convert.ToBoolean(row.Cells["caja"].Value) == false)
                {
                    if (objcaja.chequeocaja("", ref mensaje,NegocioConfigEmpresa.nrocaja) == true)
                    {
                        Negociocaja.insertarmovcaja(4110107, Convert.ToSingle(row.Cells["Total"].Value.ToString()), 0, Convert.ToString(DateTime.Now), NegocioConfigEmpresa.usuarioconectado, NegocioConfigEmpresa.idusuario, NegocioConfigEmpresa.turno, "Venta nro : " + row.Cells["codigo"].Value.ToString(), Convert.ToInt64(row.Cells["codigo"].Value.ToString()), true,NegocioConfigEmpresa.nrocaja, Convert.ToInt32(row.Cells["Formadepago"].Value.ToString()));
                        
                        
                        if (NegocioConfigEmpresa.confsistema("stock").ToString() == this.Name)
                        {
                            DataTable ventas = cargardetallestock(row.Cells["codigo"].Value.ToString());
                            
                           mensaje =  NegocioMovStock.insertar(0, DateTime.Today,
                             "", row.Cells["codigo"].Value.ToString(), "VENTA", 0, "EMITIDO", "EGRESO", ventas);
                           if (mensaje != "ok")
                           {
                               constock = false;
                                UtilityFrm.mensajeError(mensaje);
                           }
                           else
                           {
                               constock = true;
                           }
                          
                        }
                        NegocioVenta.cambiarestadoventa(Convert.ToInt32(row.Cells["codigo"].Value.ToString()), true, constock);
                    }
                    else
                    {
                        UtilityFrm.mensajeError(mensaje);
                    
                    }

                }
               
            }
            catch (Exception i)
            {
                UtilityFrm.mensajeError(i.Message);
            
            }
            buscarPorFecha();
            actualizarTotal();
        }

        private DataTable cargardetallestock(string codigoventa)
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("Codigo", typeof(string));
            dt.Columns.Add("Precio", typeof(decimal));
            dt.Columns.Add("PrecioVenta", typeof(decimal));
            dt.Columns.Add("Cantidad", typeof(string));
            dt.Columns.Add("StockActual", typeof(string));



            DataTable ventas = NegocioVenta.MostrarDetalle(codigoventa);
            
            foreach (DataRow venta in ventas.Rows)
            {



                //string tipo_comprobante = venta["tipo_comprobante"].ToString();
                //tipo_comprobante = tipo_comprobante == "V" ? "VENTA" : "";
                dt.Rows.Add(venta["idarticulo"], venta["precio"], venta["importe"], venta["cantidad"]);
                //
            }
            return dt;
        
        
        }

        private void menureimpresion_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataLista.CurrentRow;
            Reporteventa miformnotaventa = new Reporteventa();
            //Reporteventa mireporteventa = new Reporteventa();
          //  Frmimpnotaventa mireporteventa = new Frmimpnotaventa();
           // Frmimpventicket miformticket = new Frmimpventicket();

            if (NegocioConfigEmpresa.confsistema("imprimirventa").ToString() == "True")
            {
                if (NegocioConfigEmpresa.confsistema("tipoimpresion").ToString () == "tipocarro")
                {
                    //miformnotaventa.Tipoimp = Convert.ToString(NegocioConfigEmpresa.confsistema("modoimpventa"));
                    miformnotaventa.Idventa = Convert.ToInt32(row.Cells["codigo"].Value.ToString()); 
                    miformnotaventa.ShowDialog();
                    //mireporteventa.Tipoimp = Convert.ToString(NegocioConfigEmpresa.confsistema("modoimpventa"));
                    //mireporteventa.Codventa = Convert.ToInt32(row.Cells["codigo"].Value.ToString());
                    //mireporteventa.Show();

                }

                else
                {
                    //  Ticketventa miticket = new Ticketventa(Convert.ToInt32(row.Cells["codigo"].Value.ToString()));
                    //miticket.ShowDialog();
                    Ticketventa miticket = new Formreportes.Ticketventa(Convert.ToInt32(row.Cells["codigo"].Value.ToString()));
                    if (NegocioConfigEmpresa.marcafiscal == "elec" && row.Cells["Letra"].Value.ToString() != "X")
                    {
                         miticket = new Formreportes.Ticketventa(Convert.ToInt32( row.Cells["codigo"].Value.ToString()));
                        miticket.ShowDialog();

                    }
                    else if (row.Cells["Letra"].Value.ToString() == "X")
                    {   
                        TicketProforma miticketproforma = new Formreportes.TicketProforma(Convert.ToInt32(row.Cells["codigo"].Value.ToString()));
                        miticketproforma.ShowDialog();
                    }
                    
                  

                    // reportName is the Assembly Qualified Name of the report



                    //       miformticket.Tipoimp = Convert.ToString(NegocioConfigEmpresa.confsistema("modoimpventa"));
                    //     miformticket.Codventa = Convert.ToInt32(row.Cells["codigo"].Value.ToString());
                    //   miformticket.Show();

                }


            }
        }

        private void rdBVenta_Click(object sender, EventArgs e)
        {
            Chkcaja.Enabled = checkradiobuton();
            ChkFactura.Enabled = checkradiobuton();
        }

        private void rdBPresupuesto_Click(object sender, EventArgs e)
        {
            Chkcaja.Enabled = checkradiobuton();
            ChkFactura.Enabled = checkradiobuton();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ReportParameter[] parametros = new ReportParameter[2];
            
            
            parametros[0] = new ReportParameter("fechaini", dtpFechaIni.Text);
            parametros[1] = new ReportParameter("fechafin", dtpFechaFin.Text);
            REPORTE_VENTAPRODUCTOTableAdapter.Fill(DVentaproducto.REPORTE_VENTAPRODUCTO, Convert.ToDateTime(dtpFechaIni.Text + " 00:00:00"), Convert.ToDateTime(dtpFechaFin.Text + " 23:59:59"));
            
            reportViewer1.LocalReport.SetParameters(parametros);
            this.reportViewer1.RefreshReport();
            reportViewer1.Visible = true;
            
        }

        private void dataLista_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            
           DTDetalleventa.DataSource = NegocioVenta.MostrarDetalle(dataLista.CurrentRow.Cells["Codigo"].Value.ToString());
        }

        private void dataLista_SelectionChanged(object sender, EventArgs e)
        {
            
            DTDetalleventa.DataSource = NegocioVenta.MostrarDetalle(dataLista.CurrentRow.Cells["Codigo"].Value.ToString());
        }

        private void MenuAnular_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            Negociocaja objcaja = new Negociocaja();
            DataGridViewRow row = dataLista.CurrentRow;
           
          mensaje = NegocioVenta.anular(Convert.ToInt32(row.Cells["Codigo"].Value), Convert.ToBoolean(row.Cells["stock"].Value));
          
            if (!mensaje.Equals("ok") )
            {
                UtilityFrm.mensajeError(mensaje);
            }
            else
            {
                if (Convert.ToBoolean(row.Cells["caja"].Value))
                {
                    if (objcaja.chequeocaja("", ref mensaje,NegocioConfigEmpresa.nrocaja))
                    {
                        Negociocaja.insertarmovcaja(5230000, 0, Convert.ToSingle(row.Cells["Total"].Value), DateTime.Today.ToString(), NegocioConfigEmpresa.usuarioconectado, NegocioConfigEmpresa.idusuario, NegocioConfigEmpresa.turno, "ANULACION", Convert.ToInt32(row.Cells["Codigo"].Value), true,NegocioConfigEmpresa.nrocaja, Convert.ToInt32(row.Cells["Formadepago"].Value));
                    }  
                }
            }
            buscarPorFecha();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void txtIdVenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscarPorFecha();
            }
        }

        private void txtPuntoventa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscarPorFecha();
            }
        }

        private void FrmListadoVentas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscarPorFecha();
            }
        }
    }
}
