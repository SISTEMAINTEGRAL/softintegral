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
    public partial class FrmUnidades : Form
    {
        private void FrmUnidades_Load(object sender, EventArgs e)
        {
            this.mostrar();
        }
        public FrmUnidades()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void dataLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void mostrar()
        {
            try
            {
                this.dataLista.DataSource = NegocioUnidades.mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: "+ ex.Message);
                
            }
            //datasource el origen de los datos,muestra las categorias en la grilla
            

            //oculto la primera columna
            this.ocultarColumnas();
            //muestro el total de las categorias
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataLista.RowCount);

        }

        public  void ocultarColumnas()
        {
            this.dataLista.Columns[0].Visible = false;
        }

        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {

        }
      
    }
}
