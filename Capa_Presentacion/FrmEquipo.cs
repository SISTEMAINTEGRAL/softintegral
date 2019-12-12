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
        private string serie;
        private int serieidequipo;  
        //modo agregar o modificar segun corresponda
        private string modo;
        private bool opcionshowdialog;
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
            //this.btnRestaurar.Visible = true;
            //this.btnMaximizar.Visible = false;
            //this.WindowState = FormWindowState.Maximized;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            //minimiza
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            ////restaurar
            //this.btnRestaurar.Visible = false;
            //this.btnMaximizar.Visible = true;
            //this.WindowState = FormWindowState.Normal;
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

        public bool Opcionshowdialog
        {
            get
            {
                return opcionshowdialog;
            }

            set
            {
                opcionshowdialog = false;
            }
        }

        public int Serieidequipo
        {
            get
            {
                return serieidequipo;
            }

            set
            {
                serieidequipo = value;
            }
        }

        public string Serie
        {
            get
            {
                return serie;
            }

            set
            {
                serie = value;
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
            DataTable midatatable = new DataTable();

            if (CHKMarca.Checked == true)
            {
                varidmarca = Convert.ToInt32 (cbmarcacons.SelectedValue) ;
            }

            if (CHKModelo.Checked == true)
            {
                varidmodelo = Convert.ToInt32(cbmodelocons.SelectedValue);

            }
            if (CHKEquipo.Checked == true)
            {
                varididcategoria = Convert.ToInt32(CBEquipoLista.SelectedValue);
            }
            midatatable = Negocioserviciotecnico.buscarequipo(TxtEquipo.Text, Convert.ToInt32(cbmarca2.SelectedValue), Convert.ToInt32(cbmodelocons.SelectedValue), Convert.ToInt32(CBEquipoLista.SelectedValue), CHKMarca.Checked, CHKModelo.Checked, CHKEquipo.Checked);

            if (midatatable.Rows.Count != 0)
            {
                DGordenservicio.DataSource = midatatable;
            }
        }

        public void habilitarcontroles(bool var1, bool var2)
        {
            Txtserie.Enabled = var1;
            //TxtDescripcion.Enabled = var1;
            CBEquipo.Enabled = var1;
            CBMar.Enabled = var1;
            CBMod.Enabled = var1;
            UtilityFrm.habilitargunaboton(BtnAgregar, var2);
            UtilityFrm.habilitargunaboton(BtnEditar, var2);

            UtilityFrm.habilitargunaboton(BtnAceptar, var1);
            UtilityFrm.habilitargunaboton(BtnCancelar, var1);
            



        }

        private void CHKMarca_CheckedChanged(object sender, EventArgs e)
        {
            cbmarca2.Enabled = CHKMarca.Checked;
            CHKModelo.Enabled = CHKMarca.Checked;

        }

        private void CHKModelo_CheckedChanged(object sender, EventArgs e)
        {
            cbmodelocons.Enabled = CHKModelo.Checked;

        }

        private void CHKCategoria_CheckedChanged(object sender, EventArgs e)
        {
            CBEquipoLista.Enabled = CHKEquipo.Checked;
            CHKMarca.Enabled = CHKEquipo.Checked;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (modo == "agregar")
                {
                    if (verificardatos() == true)
                    {
                        Negocioserviciotecnico.agregarserieequipo(Txtserie.Text, Convert.ToInt32(CBEquipo.SelectedValue), Convert.ToInt32(CBMar.SelectedValue), Convert.ToInt32(CBMod.SelectedValue));
                    }

                }
                if (modo == "modificar")
                {
                    if (Serieidequipo != 0)
                    {
                        Negocioserviciotecnico.editarseriequipo(Txtserie.Text, Convert.ToInt32(CBEquipo.SelectedValue), Convert.ToInt32(CBMar.SelectedValue), Convert.ToInt32(CBMod.SelectedValue), Serieidequipo);
                    }

                }
                Serieidequipo = 0;
                habilitarcontroles(false, true);
                if (modo == "modificar")
                {
                    buscar();
                    this.xuiFlatTab1.SelectedTab = TabLista;
                }
                limpiarformulario();

            }
            catch (Exception)
            {

                throw;
            }
                    }
        private bool verificardatos()
        {
            bool variable = true;
            if (Txtserie.Text  == "" )
            {
                variable = false;
            }
            if (CBMar.ValueMember == "")
            {
                variable = false;
            }
            if (CBMod.ValueMember == "")
            {
                variable = false;
            }
            if (CBEquipo.ValueMember == "")
            {
                variable = false;
            }

            return variable;
        }

        private void FrmEquipo_Load(object sender, EventArgs e)
        {
            

            habilitarcontroles(false, true);
            
            //CBCategoria.DataSource = NegocioCategoria.buscar ("");
            //CBCategoria.ValueMember = "idcategoria";
            //CBCategoria.DisplayMember = "nombre";

            UtilityFrm.completarcombobox(CBMar, "idmarca", "marca", Negocioserviciotecnico.buscarmarca());

            UtilityFrm.completarcombobox(CBEquipo, "idequipo", "equipo", Negociogeneral.selecciondeconsultasinfiltro ("ordenservicio_equipo"));

            UtilityFrm.completarcombobox(CBEquipoLista, "idequipo", "equipo", Negociogeneral.selecciondeconsultasinfiltro("ordenservicio_equipo"));

            UtilityFrm.completarcombobox(cbmarca2, "idmarca", "marca", Negocioserviciotecnico.buscarmarca());
        }


        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            habilitarcontroles(true, false);
            modo = "agregar";
            limpiarformulario();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            habilitarcontroles(true, false);
            modo = "modificar";
        }

        private void CBModelo_SelectedValueChanged(object sender, EventArgs e)
        {
           // UtilityFrm.completarcombobox(cbmodelocons, "idmodelo", "descripcion", Negocioserviciotecnico.buscarmodelo(Convert.ToInt32(cbmarcacons.SelectedIndex), Convert.ToInt32(CBEquipo.SelectedIndex)));


        }

        private void TxtBuscarCliente_Click(object sender, EventArgs e)
        {
            buscar();
        }
        
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            habilitarcontroles(false,true);
        }

        private void limpiarformulario ()
        {
            Txtserie.Text = "";
            //TxtDescripcion.Text = "";
            CBEquipo.Text = "";
            CBMar.Text = "";
            CBMod.Text = "";
        }

        

        private void BtnMin_Click(object sender, EventArgs e)
        {
            //minimiza
            WindowState = FormWindowState.Minimized;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            //cierra
            Close();
        }

       

       

       

        private void CBMar_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void CBMar_KeyDown(object sender, KeyEventArgs e)
        {
            DataTable tabla = new DataTable();

            if (e.KeyCode == Keys.Enter)
            {
               tabla =    Negociogeneral.selecciondeconsultageneral("marca", "marca", CBMar.Text);
                if (tabla.Rows.Count == 0)
                {
                    if (UtilityFrm.mensajeopcionsiono("La marca" + CBMar.Text + " no esta cargado en el sistema, desea agregarlo?") == true)
                    {
                        Negocioserviciotecnico.agregarmarca(CBMar.Text);
                        string valor = CBMar.Text;
                        UtilityFrm.completarcombobox(CBMar, "idmarca", "marca", Negocioserviciotecnico.buscarmarca() );
                        
                        

                    }
                    else
                    {
                        CBMar.Text = "";
                    }
                    
                }
            }
        }

        private void CBMod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable tabla = new DataTable();
                tabla = Negociogeneral.selecciondeconsultageneral("modelo", "modelo", CBMod.Text);
                if (tabla.Rows.Count == 0)
                {
                    if (UtilityFrm.mensajeopcionsiono("El modelo " + CBMod.Text + " no esta cargado en el sistema, desea agregarlo?") == true)
                    {
                        Negocioserviciotecnico.agregarmodelo(CBMod.Text,Convert.ToInt32 (CBMar.SelectedValue),Convert.ToInt32(CBEquipo.SelectedValue));
                        string valor = CBMod.Text;
                        UtilityFrm.completarcombobox(CBMod, "idmodelo", "modelo", Negocioserviciotecnico.buscarmodelo(Convert.ToInt32( CBMar.SelectedValue ), Convert.ToInt32(CBEquipo.SelectedValue)));
                        CBMod.Text = valor;

                    }
                    else
                    {
                        CBMod.Text = "";
                    }

                }
            }
        }

        private void CBMar_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CBMar.ValueMember  != "")
            {
                UtilityFrm.completarcombobox(CBMod, "idmodelo", "modelo", Negocioserviciotecnico.buscarmodelo(Convert.ToInt32(CBMar.SelectedValue), Convert.ToInt32(CBEquipo.SelectedValue)));
            }
            

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            //cierra
            this.Close();
        }

        private void BtnRes_Click_1(object sender, EventArgs e)
        {
            //restaurar
            this.BtnRestaurar.Visible = false;
            this.btnMaximizar.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void btnMaximizar_Click_1(object sender, EventArgs e)
        {
            //maximizar
            this.BtnRestaurar.Visible = true;
            this.btnMaximizar.Visible = false;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            //minimiza
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelHorizontal_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void panelHorizontal_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (BtnRestaurar.Visible == false || btnMaximizar.Visible == true)
            {
                //maximizar
                this.BtnRestaurar.Visible = true;
                this.btnMaximizar.Visible = false;
                this.WindowState = FormWindowState.Maximized;

            }
            else
            {
                //restaurar
                this.BtnRestaurar.Visible = false;
                this.btnMaximizar.Visible = true;
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void bunifuTextbox1_MouseClick(object sender, MouseEventArgs e)
        {
            FrmClientes clientes = new Capa_Presentacion.FrmClientes() ;
            clientes.Show();
        }

        private void bunifuTextbox1_Click(object sender, EventArgs e)
        {
            FrmClientes clientes = new Capa_Presentacion.FrmClientes();
            clientes.Show();
        }

        private void CBEquipo_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void CBEquipo_KeyDown(object sender, KeyEventArgs e)
        {
            DataTable tabla = new DataTable();
            if (e.KeyCode == Keys.Enter)
            {
                tabla = Negociogeneral.selecciondeconsultageneral("ordenservicio_equipo", "equipo", CBEquipo.Text);
                if (tabla.Rows.Count == 0)
                {
                    if (UtilityFrm.mensajeopcionsiono("El nombre del equipo " + CBEquipo.Text + " no esta cargado en el sistema, desea agregarlo?") == true)
                    {
                        Negocioserviciotecnico.agregarequipo(CBEquipo.Text);
                        string valor = "";
                        valor = CBEquipo.Text;
                        UtilityFrm.completarcombobox(CBEquipo, "idequipo", "equipo", Negociogeneral.selecciondeconsultasinfiltro("ordenservicio_equipo"));
                        CBEquipo.ValueMember = valor;

                    }
                }
            }
        }

        private void CBEquipo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CBMar.ValueMember != "" && CBEquipo.ValueMember != "")
            {
                UtilityFrm.completarcombobox(CBMod, "idmodelo", "modelo", Negocioserviciotecnico.buscarmodelo(Convert.ToInt32(CBMar.SelectedValue), Convert.ToInt32(CBEquipo.SelectedValue)));
            }
        }

        private void DGordenservicio_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (opcionshowdialog == false)
            {
                Serieidequipo = Convert.ToInt32(this.DGordenservicio.CurrentRow.Cells["id"].Value);
                CBEquipo.SelectedValue = Convert.ToInt32(this.DGordenservicio.CurrentRow.Cells["idequipo"].Value);
                Txtserie.Text = Convert.ToString(this.DGordenservicio.CurrentRow.Cells["serie"].Value);
                //CBEquipo.Text = Convert.ToString(this.DGordenservicio.CurrentRow.Cells["equipo"].Value);
                CBMar.SelectedValue = Convert.ToInt32(this.DGordenservicio.CurrentRow.Cells["idmarca"].Value);
                CBMod.SelectedValue = Convert.ToInt32(this.DGordenservicio.CurrentRow.Cells["idmodelo"].Value);
                modo = "editar";
                this.xuiFlatTab1.SelectedTab = TabEquipo;
            }
            else
            {
                serie = Convert.ToString(this.DGordenservicio.CurrentRow.Cells["serie"].Value);
                Close();
            }
            
        }
    }
}
