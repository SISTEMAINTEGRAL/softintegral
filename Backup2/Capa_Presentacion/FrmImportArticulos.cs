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
    public partial class FrmImportArticulos : Form
    {
        public FrmImportArticulos()
        {
            InitializeComponent();
        }

        private void panelHorizontal_Paint(object sender, PaintEventArgs e)
        {

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

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            //maximizar
            this.btnRestaurar.Visible = true;
            this.btnMaximizar.Visible = false;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            dataLista.DataSource = NegocioArticulo.mostrarsqlite();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DataTable tablaArticulos = GrillaADataTable(dataLista);
            string respuesta = NegocioArticulo.importarproducto(tablaArticulos, NegocioConfigEmpresa.confsistema("opcionsistema").ToString());
            UtilityFrm.mensajeConfirm("La actualizacion se realizo con exito");
          //  dataLista.Rows.Clear();

        }
        public DataTable GrillaADataTable(DataGridView grillaACopiar)
        {

            DataTable table = new DataTable("articulo");
            table.Columns.Add("idarticulo");
            table.Columns.Add("codigo");
            table.Columns.Add("nombre");
            table.Columns.Add("descripcion");
            table.Columns.Add("idcategoria");
            table.Columns.Add("idsubcategoria");
            table.Columns.Add("precio");
            table.Columns.Add("stock_actual");
            table.Columns.Add("PrecioCompra");
            table.Columns.Add("Utilidad");
            table.Columns.Add("estado");
            table.Columns.Add("pesable");
            table.Columns.Add("preciomanual");
            table.Columns.Add("flete");
            table.Columns.Add("stock_minimo");
            table.Columns.Add("balanza");
            table.Columns.Add("utilidadpormayor");
            table.Columns.Add("preciopormayor");
            table.Columns.Add("utilidadpormayor2");
            table.Columns.Add("preciopormayor2");
            table.Columns.Add("utilidadoferta");
            table.Columns.Add("Precio_Oferta");
            table.Columns.Add("iva");
                     

            


                foreach (DataGridViewRow row in grillaACopiar.Rows)
            {
                table.Rows.Add(row.Cells["idarticulo"].Value, row.Cells["codigo"].Value, row.Cells["nombre"].Value, row.Cells["descripcion"].Value, row.Cells["idcategoria"].Value,
                row.Cells["idsubcategoria"].Value, row.Cells["precio"].Value, row.Cells["stock_actual"].Value, row.Cells["precio_compra"].Value, row.Cells["utilidad"].Value,
                row.Cells["estado"].Value, row.Cells["pesable"].Value, row.Cells["preciomanual"].Value, row.Cells["flete"].Value, row.Cells["stock_minimo"].Value,
                row.Cells["balanza"].Value, row.Cells["utilidadpormayor"].Value, row.Cells["preciopormayor"].Value, row.Cells["utilidadpormayor2"].Value,
                row.Cells["preciopormayor2"].Value, row.Cells["utilidadoferta"].Value, row.Cells["precio_oferta"].Value, row.Cells["iva"].Value);
            }


            return table;
        }

        private void BtnTraerNube_Click(object sender, EventArgs e)
        {
            dataLista.DataSource = NegocioArticulo.mostrarmysql();
        }
    }
}
