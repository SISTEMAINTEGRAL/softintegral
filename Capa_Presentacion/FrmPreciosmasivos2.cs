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
using Capa_Datos;
using System.Globalization;

namespace Capa_Presentacion
{
    public partial class FrmPreciosmasivos2 : Form
    {
        public int posY = 0;
        public int posX = 0;
        private string cambiovalor;
        public FrmPreciosmasivos2()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FrmAvanzadoArticulo objavanzado = new FrmAvanzadoArticulo();
            objavanzado.Listadodearticulo = DGVenta;

            objavanzado.ShowDialog();

        }

        private void FrmPreciosmasivos_Load(object sender, EventArgs e)
        {
            //Selección fila completa.


            //No permitir selección múltiple
            //dataGridView1.Rows.Add("", "", "");
            foreach (DataGridViewColumn c in DGVenta.Columns)
            {
                if ((c.Index < 3))
                {
                    c.ReadOnly = true;
                }

            }
            //|| (c.Index != 4) || (c.Index != 5) || (c.Index != 6)

            //this.DGVenta.Columns["Precio_compra"].DefaultCellStyle.Format = String.Format("$###,##0.00");
            //this.DGVenta.Columns["Precioventa"].DefaultCellStyle.Format = String.Format("$###,##0.00");
            //this.DGVenta.Columns["Utilidad"].DefaultCellStyle.Format = String.Format("%0.00");
            //this.DGVenta.Columns["Flete"].DefaultCellStyle.Format = String.Format("%0.00");

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

        private void FrmPreciosmasivos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                int rowSelected = DGVenta.SelectedRows[0].Index;
                DGVenta.Rows.RemoveAt(rowSelected);
            }
        }

        private void DGVenta_Click(object sender, EventArgs e)
        {

        }

        private void DGVenta_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Menudelete.Visible = true;
                contextMenuStrip1.Show(DGVenta, new Point(e.X, e.Y));

            }
        }

        private void Menudelete_Click(object sender, EventArgs e)
        {
            int rowSelected = DGVenta.SelectedRows[0].Index;
            DGVenta.Rows.RemoveAt(rowSelected);
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

        private void refrescar()
        {
            if (DGVenta.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in DGVenta.Rows)
                {

                    row.Cells[6].Value = UtilityFrm.formateodecimal(UtilityFrm.calcularventa(Convert.ToDecimal(row.Cells[3].Value), Convert.ToDecimal(row.Cells[4].Value), Convert.ToDecimal(row.Cells[5].Value), Convert.ToDecimal(row.Cells[6].Value)), 2);




                }
            }
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            try
            {


                if (DGVenta.Rows.Count != 0)
                {
                    foreach (DataGridViewRow row in DGVenta.Rows)
                    {
                        row.Cells[6].Value = UtilityFrm.formateodecimal(UtilityFrm.calcularventa(Convert.ToDecimal(row.Cells[3].Value), Convert.ToDecimal(row.Cells[4].Value), Convert.ToDecimal(row.Cells[5].Value), Convert.ToDecimal(row.Cells[6].Value)), 2);

                    }

                    if (UtilityFrm.mensajeopcionsiono("Desea aplicar los cambios?") == true)
                    {
                        

                        DataTable tablaArticulos = GrillaADataTable(DGVenta);
                        NegocioArticulo.editarPrecioMasivo(tablaArticulos, NegocioConfigEmpresa.confsistema("opcionsistema").ToString());
                        UtilityFrm.mensajeConfirm("La actualizacion se realizo con exito");
                        DGVenta.Rows.Clear();
                    }

                }

            }
            catch (Exception s)
            {
                UtilityFrm.mensajeError(s.Message);
            }

        }
        //Metodos propios
        public DataTable GrillaADataTable(DataGridView grillaACopiar)
        {

            DataTable table = new DataTable("articulo");
            table.Columns.Add("Codigo");
            table.Columns.Add("Producto");
            table.Columns.Add("Utilidad");
            table.Columns.Add("PrecioCompra");
            table.Columns.Add("PrecioVenta");
            table.Columns.Add("Flete");

            foreach (DataGridViewRow row in grillaACopiar.Rows)
            {
                table.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[4].Value,
                    row.Cells[3].Value, row.Cells[6].Value, row.Cells[5].Value);
            }


            return table;
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
            btnMinimizar.BackColor = Color.FromArgb(0,100,200);
        }

        private void btnLimpiarG_Click(object sender, EventArgs e)
        {
            DGVenta.Rows.Clear();
        }

        private void DGVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGVenta_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Rectangle rec = DGVenta.GetCellDisplayRectangle(DGVenta.CurrentCell.ColumnIndex, DGVenta.CurrentCell.RowIndex, false);


            //if (DGVenta.Rows.Count > 0)
            //{
            //    if (e.ColumnIndex == 3)
            //    {
            //        TxtcambioDv.Location = new Point(rec.Location.X + DGVenta.Location.X, rec.Location.Y + DGVenta.Location.Y);
            //        cambiovalor = "preciocompra";
            //        TxtcambioDv.Visible = true;
            //        TxtcambioDv.Text = DGVenta.CurrentCell.Value.ToString();
            //        TxtcambioDv.Focus();


            //    }

            //    if (e.ColumnIndex == 4)
            //    {
            //        TxtcambioDv.Location = new Point(rec.Location.X + DGVenta.Location.X, rec.Location.Y + DGVenta.Location.Y);
            //        cambiovalor = "utilidad";
            //        TxtcambioDv.Visible = true;
            //        TxtcambioDv.Text = DGVenta.CurrentCell.Value.ToString();
            //        TxtcambioDv.Focus();
            //    }

            //    if (e.ColumnIndex == 5)
            //    {
            //        TxtcambioDv.Location = new Point(rec.Location.X + DGVenta.Location.X, rec.Location.Y + DGVenta.Location.Y);
            //        cambiovalor = "flete";
            //        TxtcambioDv.Visible = true;
            //        TxtcambioDv.Text = DGVenta.CurrentCell.Value.ToString();
            //        TxtcambioDv.Focus();
            //    }

            //    if (e.ColumnIndex == 6)
            //    {
            //        TxtcambioDv.Location = new Point(rec.Location.X + DGVenta.Location.X, rec.Location.Y + DGVenta.Location.Y);
            //        cambiovalor = "precioventa";
            //        TxtcambioDv.Visible = true;
            //        TxtcambioDv.Text = DGVenta.CurrentCell.Value.ToString();
            //        TxtcambioDv.Focus();
            //    }

            //}
        }

        private void TxtcambioDv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                calcularutilidadgrid();

            }
        }

        private void calcularutilidadgrid( )
        {


            DGVenta.CurrentRow.Cells[6].Value = UtilityFrm.formateodecimal(UtilityFrm.calcularventa(Convert.ToDecimal(DGVenta.CurrentRow.Cells[3].Value), Convert.ToDecimal(DGVenta.CurrentRow.Cells[4].Value), Convert.ToDecimal(DGVenta.CurrentRow.Cells[5].Value), Convert.ToDecimal(DGVenta.CurrentRow.Cells[6].Value)), 2);
            


        }

        private void TxtcambioDv_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilityFrm.NumDecTeclado(e, TxtcambioDv);
        }

        private void TxtcambioDv_Leave(object sender, EventArgs e)
        {
            calcularutilidadgrid();
            TxtcambioDv.Visible = false;
        }

        private void BtnCambiar_Click(object sender, EventArgs e)
        {
            if (DGVenta.Rows.Count != 0)
            {
                foreach (DataGridViewRow row in DGVenta.Rows)
                {


                    if (cbcampoamodificar.Text != "" && txtPorcentaje.Text != "")
                    {
                        if (cbcampoamodificar.Text == "Precio_compra")
                        {

                            row.Cells[3].Value = UtilityFrm.formateodecimal(UtilityFrm.calcularventa(Convert.ToDecimal(row.Cells[3].Value), Convert.ToDecimal(txtPorcentaje.Text)), 2);
                        }
                        if (cbcampoamodificar.Text == "Utilidad")
                        {

                            row.Cells[4].Value = UtilityFrm.formateodecimal(Convert.ToDecimal(txtPorcentaje.Text), 2);
                        }
                        if (cbcampoamodificar.Text == "Flete")
                        {

                            row.Cells[5].Value = UtilityFrm.formateodecimal(Convert.ToDecimal(txtPorcentaje.Text), 2);
                        }
                        if (cbcampoamodificar.Text == "Precio_venta")
                        {

                            row.Cells[6].Value = UtilityFrm.formateodecimal(UtilityFrm.calcularventa(Convert.ToDecimal(row.Cells[6].Value), Convert.ToDecimal(txtPorcentaje.Text)), 2);
                        }
                    }



                }
            }
            refrescar();
        }

        private void DGVenta_SelectionChanged(object sender, EventArgs e)
        {

            //DGVenta.CurrentCell = DGVenta.CurrentRow.Cells[4];

            //DGVenta.BeginEdit(true);
            //DGVenta.CurrentCell = DGVenta.CurrentRow.Cells[3];
            //DGVenta.BeginEdit(true);
            //DGVenta.CurrentCell = DGVenta.CurrentRow.Cells[5];
            //DGVenta.BeginEdit(true);
            //DGVenta.CurrentCell = DGVenta.CurrentRow.Cells[6];
            //DGVenta.BeginEdit(true);
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DGVenta.CurrentCell = DGVenta.CurrentRow.Cells[2];
            DGVenta.BeginEdit(true);
        }

        private void DGVenta_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            
           
            DGVenta.CurrentRow.Cells[3].Value = UtilityFrm.GetdigitFromString(DGVenta.CurrentRow.Cells[3].Value.ToString(),true);
            DGVenta.CurrentRow.Cells[4].Value = UtilityFrm.GetdigitFromString(DGVenta.CurrentRow.Cells[4].Value.ToString(), true);
            DGVenta.CurrentRow.Cells[5].Value = UtilityFrm.GetdigitFromString(DGVenta.CurrentRow.Cells[5].Value.ToString(), true);

            calcularutilidadgrid();
            DGVenta.CurrentRow.Cells[3].Value = UtilityFrm.formateodecimal(Convert.ToDecimal ( DGVenta.CurrentRow.Cells[3].Value), 2);
            DGVenta.CurrentRow.Cells[4].Value = UtilityFrm.formateodecimal(Convert.ToDecimal(DGVenta.CurrentRow.Cells[4].Value), 2);
            DGVenta.CurrentRow.Cells[5].Value = UtilityFrm.formateodecimal(Convert.ToDecimal(DGVenta.CurrentRow.Cells[5].Value), 2);
        }

        private void BtnImprimir_Click(object sender, EventArgs e)
        {
            if (DGVenta.Rows.Count != 0)
            {
                NegocioArticulo.cargarproductogondola(rellenarlistaidarticulo(), NegocioConfigEmpresa.idequipo, NegocioConfigEmpresa.confsistema("opcionsistema").ToString());
                Formreportes.FrmGondola2 mifrmreportegondola = new Formreportes.FrmGondola2(NegocioConfigEmpresa.idequipo);
                // Formreportes.FrmReporteGondola mifrmreportegondola = new Formreportes.FrmReporteGondola(NegocioConfigEmpresa.idequipo); 
                mifrmreportegondola.ShowDialog();
                DGVenta.Rows.Clear();
            }
        }
        public List<int> rellenarlistaidarticulo()
        {
            List<int> codigoarticulo = new List<int>();

            foreach (DataGridViewRow row in DGVenta.Rows)
            {
                codigoarticulo.Add(Convert.ToInt32(row.Cells[0].Value));
            }
            return codigoarticulo;
        }

        private void BtnExportar_Click(object sender, EventArgs e)
        {
        
            if (UtilityFrm.mensajeopcionsiono("Desea exportar todos los productos del sistema"))
            {
                NegocioArticulo.ExportarProductos(NegocioArticulo.mostrartodo(), true, "negocio");
            }
            else if (DGVenta.Rows.Count != 0)
            {

                NegocioArticulo.ExportarProductos(GrillaADataTable(DGVenta),false);
            }
            
            UtilityFrm.mensajeConfirm("La actualizacion se realizo con exito");
            DGVenta.Rows.Clear();
        }

        private void DGVenta_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //UtilityFrm.Validar_DatagridPress(sender, e, DGVenta);
        }

        private void BtnExportarbalanza_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            mensaje =  UtilityFrm.archivotxtbalanza(NegocioArticulo.mostrartodo(true));
           
            if (mensaje == "")
            {
                UtilityFrm.notificacionpopup("Exportacion Archivo", "La exportacion del archivo se realizo con exito");
            }
            else
            {
                UtilityFrm.mensajeError("La exportacion no se realizo correctamente" + mensaje);
            }
        }
    }
}
