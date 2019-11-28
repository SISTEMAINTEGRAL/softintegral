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
    public partial class FrmEquipo : Form
    {
        private string modo;
        public FrmEquipo()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //cierra
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
        int posY = 0;
        int posX = 0;

        public string Modo
        {
            get
            {
                return modo;
            }

            set
            {
                modo = value;
            }
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

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void buscar()
        {
            int varidmarca = 0;
            int varidmodelo = 0;
            int varididcategoria = 0;

            if (CHKMarca.Checked == true)
            {
                varidmarca = Convert.ToInt32 (cbmarcacons.SelectedValue) ;
            }

            if (CHKModelo.Checked == true)
            {
                varidmodelo = Convert.ToInt32(cbmodelocons.SelectedValue);

            }
            if (CHKCategoria.Checked == true)
            {
                varididcategoria = Convert.ToInt32(cbcategoriacons.SelectedValue);
            }
            //DGordenservicio.DataSource = Negocioserviciotecnico.
        }

        public void habilitarcontroles(bool var1, bool var2)
        {
            TxtNombre.Enabled = var1;
            TxtDescripcion.Enabled = var1;
            CBCategoria.Enabled = var1;
            cbmarcacons.Enabled = var1;
            CBModelo.Enabled = var1;
            BtnAgregar.Enabled = var2;
            BtnEditar.Enabled = var2;

            BtnAceptar.Enabled = var1;
            BtnCancelar.Enabled = var1;



        }

        private void CHKMarca_CheckedChanged(object sender, EventArgs e)
        {
            cbmarcacons.Enabled = CHKMarca.Checked; 
        }

        private void CHKModelo_CheckedChanged(object sender, EventArgs e)
        {
            cbmodelocons.Enabled = CHKModelo.Checked;
        }

        private void CHKCategoria_CheckedChanged(object sender, EventArgs e)
        {
            cbcategoriacons.Enabled = CHKCategoria.Checked;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void FrmEquipo_Load(object sender, EventArgs e)
        {
            
            habilitarcontroles(false, true);
            CBCategoria.DataSource = NegocioCategoria.buscar ("");
            CBCategoria.ValueMember = "idcategoria";
            CBCategoria.DisplayMember = "nombre";
           

            cbmarcacons.DataSource = Negocioserviciotecnico.buscarmarca ();
            CBCategoria.ValueMember = "idmarca";
            CBCategoria.DisplayMember = "descripcion";


            

        }
        

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            habilitarcontroles(true, false);
            modo = "agregar";
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            habilitarcontroles(true, false);
            modo = "modificar";
        }

        private void CBModelo_SelectedValueChanged(object sender, EventArgs e)
        {
            cbmodelocons.DataSource = Negocioserviciotecnico.buscarmodelo(Convert.ToInt32(cbmarcacons.SelectedIndex));

            cbmodelocons.ValueMember = "idmodelo";
            //lo que se muestra
            cbmodelocons.DisplayMember = "descripcion";
        }

        private void TxtBuscarCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
