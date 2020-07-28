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
    public partial class FrmBusquedaAvaCliente : Form
    {
        
        private int idCliente;
        private long cuit;
        private string razonSocial;
        private string riva;
        private string domicilio;

        public string Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }

        public string Riva
        {
            get { return riva; }
            set { riva = value; }
        }
        
        private bool isCerro=false;

      
        public FrmBusquedaAvaCliente()
        {
            InitializeComponent();
        }

        private void FrmBusquedaAvaArticulo_Load(object sender, EventArgs e)
        {
            this.mostrar();
        }
        /*Metodos Propios*/
        public void mostrar()
        {
            try
            {
                this.dataLista.DataSource = NegocioCliente.mostrar();
                this.dataLista.Columns[0].Width = 150;
                this.dataLista.Columns[1].Width = 250;
                this.dataLista.Columns[2].Width = 250;
                this.dataLista.Columns[3].Width = 150;
                this.dataLista.Columns[4].Width = 150;
                this.dataLista.Columns[5].Width = 150;
                this.dataLista.Columns[6].Width = 200;
                this.dataLista.Columns[7].Width = 0;
                this.dataLista.Columns[8].Width = 100;
            }
            catch (Exception ex)
            {
                UtilityFrm.mensajeError("error con la Base de datos: " + ex.Message);
            }

            //muestro el total de las categorias
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataLista.RowCount);
        }

        private void dataLista_DoubleClick(object sender, EventArgs e)
        {
            seleccionarCliente();
        }

   
        private void FrmBusquedaAvaArticulo_FormClosing(object sender, FormClosingEventArgs e)
        {
            isCerro = true;
        }

        public void seleccionarCliente() {

            this.idCliente = Convert.ToInt32(this.dataLista.CurrentRow.Cells["idcliente"].Value);
            this.razonSocial = Convert.ToString(this.dataLista.CurrentRow.Cells["razon_social"].Value);
            this.cuit = Convert.ToInt64(this.dataLista.CurrentRow.Cells["cuit"].Value);
            this.riva = this.dataLista.CurrentRow.Cells["responsabilidadiva"].Value.ToString();
            this.domicilio = this.dataLista.CurrentRow.Cells["direccion"].Value.ToString();
            this.Close();
            this.isCerro = false;
        
        }
        private void dataLista_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    seleccionarCliente();

                }
            }
            catch (Exception ex)
            {

                UtilityFrm.mensajeError("error:"+ex.Message);
            }
           
            
        }

        private void FrmBusquedaAvaArticulo_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Escape){
                this.Close();
                
            }
        }
        //Propiedades
       
        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }
        public long Cuit
        {
            get { return cuit; }
            set { cuit = value; }
        }
        public string RazonSocial
        {
            get { return razonSocial; }
            set { razonSocial = value; }
        }
        public bool IsCerro
        {
            get { return isCerro; }
            set { isCerro = value; }
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (rdbRazonSocial.Checked == true)
                    {
                        this.dataLista.DataSource = NegocioCliente.buscar(this.txtBuscar.Text);
                    }

                    if (rdbCuit.Checked == true)
                    {
                        this.dataLista.DataSource = NegocioCliente.buscarCodigoCliente(this.txtBuscar.Text, 7);
                    }
                    if (rdbCodigo.Checked == true)
                    {
                        this.dataLista.DataSource = NegocioCliente.buscarCodigoCliente(this.txtBuscar.Text);
                    }
            }

            catch (Exception ex)
            {
                UtilityFrm.mensajeError("Error Con Base de Datos :" + ex.Message);

            }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
