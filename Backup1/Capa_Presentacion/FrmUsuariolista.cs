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

    

    public partial class FrmUsuariolista : Form
    {
        private string buscarnombre;
        private  int posY;
        private  int posX;
        
        public string Buscarnombre
        {
            get { return buscarnombre; }
            set { buscarnombre = value; }
        }

        private int idusuario;

        public int Idusuario
        {
            get { return idusuario; }
            set { idusuario = value; }
        }
        private string usuario;

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        private string clave;

        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }
        private string nombreusuario;

        public string Nombreusuario
        {
            get { return nombreusuario; }
            set { nombreusuario = value; }
        }
        private string turno;

        public string Turno
        {
            get { return turno; }
            set { turno = value; }
        }
        private bool sa;

        public bool Sa
        {
            get { return sa; }
            set { sa = value; }
        }
        

        public FrmUsuariolista()
        {
            InitializeComponent();
        }

        private void FrmUsuariolista_Load(object sender, EventArgs e)
        {
            try
            {
                buscarnombre = "";
                dataListausuario.DataSource = NegocioUsuario.mostrarusuario(buscarnombre);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { 
                
            
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            dataListausuario.DataSource = NegocioUsuario.mostrarusuario(txtNombre.Text);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataListausuario.DataSource = NegocioUsuario.mostrarusuario(txtNombre.Text);
        }

        private void dataListausuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataListausuario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.usuario = dataListausuario.CurrentRow.Cells["usuario"].Value.ToString();
            this.nombreusuario = dataListausuario.CurrentRow.Cells["nombre"].Value.ToString();
            this.clave = dataListausuario.CurrentRow.Cells["password"].Value.ToString();
            this.idusuario = Convert.ToInt32(dataListausuario.CurrentRow.Cells["idusuario"].Value);
            this.sa = Convert.ToBoolean(dataListausuario.CurrentRow.Cells["sa"].Value);
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
