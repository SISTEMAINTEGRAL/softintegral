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
    public partial class FrmBusquedaAvaProveedor : Form
    {
        private string nombreProveedor;
        private int idProveedor;
        //para saber si se cerró la ventana
        private bool isCerro = false;

        public FrmBusquedaAvaProveedor()
        {
            InitializeComponent();
        }

        private void FrmBusquedaAvaProveedor_Load(object sender, EventArgs e)
        {
            this.mostrar();
        }
         /*Metodos Propios*/
        public void mostrar()
        {
            try
            {
                this.dataLista.DataSource = NegocioProveedor.mostrar();
               
                this.dataLista.Columns[0].Width = 150;
                this.dataLista.Columns[1].Width = 250;
                this.dataLista.Columns[2].Width = 250;
                this.dataLista.Columns[3].Width = 250;
                this.dataLista.Columns[4].Width = 250;
                this.dataLista.Columns[5].Width = 250;
                this.dataLista.Columns[6].Width = 250;
              
            }
            catch (Exception ex)
            {
                UtilityFrm.mensajeError("error con la Base de datos: " + ex.Message);
            }

            //muestro el total de las categorias
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataLista.RowCount);
        }
        private void dataLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.idProveedor = Convert.ToInt32(this.dataLista.CurrentRow.Cells["idproveedor"].Value);
            this.nombreProveedor= Convert.ToString(this.dataLista.CurrentRow.Cells["razon_social"].Value);
            this.Close();
            this.isCerro = false;
        }
        public bool IsCerro
        {
            get { return isCerro; }
            set { isCerro = value; }
        }
        public int IdProveedor
        {
            get { return idProveedor; }
            set { idProveedor = value; }
        }
        public string NombreProveedor
        {
            get { return nombreProveedor; }
            set { nombreProveedor = value; }
        }

        private void FrmBusquedaAvaProveedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            isCerro = true;
        }

        private void dataLista_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {

                this.idProveedor = Convert.ToInt32(this.dataLista.CurrentRow.Cells["idproveedor"].Value);
                this.nombreProveedor = Convert.ToString(this.dataLista.CurrentRow.Cells["razon_social"].Value);
                this.Close();
                this.isCerro = false;
            }
        }

        private void dataLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
