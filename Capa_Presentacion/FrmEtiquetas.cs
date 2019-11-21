using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarcodeLib;
using Capa_Presentacion.Reportes;
namespace Capa_Presentacion
{
    public partial class FrmEtiquetas : Form
    {
        private int idarticulo;

        public int Idarticulo
        {
            get { return idarticulo; }
            set { idarticulo = value; }
        }
        public FrmEtiquetas()
        {
            InitializeComponent();
        }

        private void btnEtiquetaPer_Click(object sender, EventArgs e)
        {
            //Frm articulos = new FrmArticulos();
            //articulos.ShowDialog();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            FrmSeleccionarProductos buscarProducto = new FrmSeleccionarProductos(dataListaCodigoBarra,this.btnProducto);
         
            this.cbxCantidad.Enabled = true;
            buscarProducto.ShowDialog();
        }

        private void btnLimpiarG_Click(object sender, EventArgs e)
        {
            this.cbxCantidad.Text = string.Empty;
            this.cbxCantidad.Enabled = false;
            this.btnGenerarEtiqueta.Enabled = false;
            this.txtCodigoBarra.Text = string.Empty;
           
            
            if (dataListaCodigoBarra.Rows.Count > 0)
            {
                //si la respuesta es si elimina la fila actual
                if (MessageBox.Show("Seguro que desea limpiar todos los Productos de la grilla?", "LIMPIAR GRILLA"
                   , MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    this.btnProducto.Enabled = true;
                    dataListaCodigoBarra.Rows.Clear();
                   
                }
            }
            
           
        }

        private void cbxCantidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btnGenerarEtiqueta.Enabled = true;
        }

        public void btnGenerarEtiqueta_Click(object sender, EventArgs e)
        {
            string nombreArt=string.Empty;
            int cantidad= Convert.ToInt32( cbxCantidad.SelectedItem);
            txtCodigoBarra.Text = Convert.ToString(this.dataListaCodigoBarra.CurrentRow.Cells[1].Value);
            nombreArt=Convert.ToString(this.dataListaCodigoBarra.CurrentRow.Cells[2].Value);
            idarticulo = Convert.ToInt32(this.dataListaCodigoBarra.CurrentRow.Cells[0].Value);
            if (txtCodigoBarra.Text == string.Empty)
            {
                UtilityFrm.mensajeError("No se ha podido Imprimir, porque no existe Codigo de Barra en este producto : "
                    + Convert.ToString(this.dataListaCodigoBarra.CurrentRow.Cells[2].Value));

            }
            else {

                //GENERA CODIGO DE BARRA EN EL PANEL CODIGOBARRA
                //Barcode codigoDeBarra = new Barcode();
                ////mostrar el texto de codigo
                //codigoDeBarra.IncludeLabel = true;
                //pnCodigoBarra.BackgroundImage = codigoDeBarra.Encode(TYPE.CODE128, txtCodigoBarra.Text, Color.Black, Color.White, 425, 137);

                //FrmReporteEtiqueta reporte = new FrmReporteEtiqueta(txtCodigoBarra.Text);
                
                //reporte.ShowDialog();
                FrmImpEtiquetas etiqueta = new FrmImpEtiquetas(nombreArt,txtCodigoBarra.Text,  cantidad, idarticulo);
                etiqueta.ShowDialog();
            }
        }

        private void pnCodigoBarra_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCodigoBarra_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbCodigoBarra_Click(object sender, EventArgs e)
        {

        }

        
    }
}
