using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using Capa_negocio; 
namespace Capa_Presentacion
{
    public partial class Frmserviciotecnico : Form
    {   /* ESTADOS DEL SERVICIO*/
        //INI INICIALIZADO,PR PROCESO,PND PENDIENTE,PR PRESUPUESTADO,FN FINALIZADO,CN CANCELADO
        //RES RESUELTO,CNF CONFIRMADO,SS SIN SOLUCION
        private string estadoservicio;
        public Frmserviciotecnico()
        {
            InitializeComponent();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            //minimiza
            this.WindowState = FormWindowState.Minimized;
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

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            //restaurar
            this.btnRestaurar.Visible = false;
            this.btnMaximizar.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(100, 0, 180);
        }

        private void btnMinimizar_MouseMove(object sender, MouseEventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(65, 39, 60);
        }

        private void btnMaximizar_MouseLeave(object sender, EventArgs e)
        {
            btnMaximizar.BackColor = Color.FromArgb(100, 0, 180);
        }

        private void btnMaximizar_MouseMove(object sender, MouseEventArgs e)
        {
            btnMaximizar.BackColor = Color.FromArgb(65, 39, 60);
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.FromArgb(100, 0, 180);
        }

        private void btnCerrar_MouseMove(object sender, MouseEventArgs e)
        {
            btnCerrar.BackColor = Color.Red;
        }
        int posY = 0;
        int posX = 0;

        public string Estadoservicio
        {
            get
            {
                return estadoservicio;
            }

            set
            {
                estadoservicio = value;
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

        private void Frmserviciotecnico_Load(object sender, EventArgs e)
        {
            UtilityFrm.completarcombobox(CBCliente, "idcliente", "razon_social", NegocioCliente.mostrar(), true);
            UtilityFrm.completarcombobox(CBMar, "idmarca", "marca", Negocioserviciotecnico.buscarmarca());
            UtilityFrm.completarcombobox(CBEquipo, "idequipo", "equipo", Negociogeneral.selecciondeconsultasinfiltro("ordenservicio_equipo"));
            Estadoservicio = "INI";
            formulariosegunestado();
        }
        private void formulariosegunestado()
        {
            CBCliente.Text = "";
            TxtOrden.Text = "";
            LblDNI.Text = "";
            LbIdcliente.Text = "";
            TxtSerie.Text = "";
            CBEquipo.Text = "";
            CBMar.Text = "";
            CBMod.Text = "";
            CBestadoorden.Text = "";
            CBestadoequipo.Text = "";
            Txtpiezafaltante.Text = "";
            TxtDetalle.Text = "";
            DGDetalleitems.Rows.Clear();



            if (estadoservicio == "INI")
            {
                CBestadoorden.SelectedValue = "INICIALIZADO";
                TxtDetalle.Enabled = false;
                DGDetalleitems.Enabled = false;
            }

        }
        private void CBCliente_SelectedValueChanged(object sender, EventArgs e)
        {
            
            
            
            buscarcliente(CBCliente.SelectedValue.ToString());
            
        }

        private void TxtBuscarCliente_Click(object sender, EventArgs e)
        {
            
            FrmClientes cliente = new Capa_Presentacion.FrmClientes();
            cliente.ShowDialog();
            
           
            buscarcliente(cliente.Idcliente.ToString());

           
        }

        private void CBCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (IsNumeric (CBCliente.Text))
                {
                    buscarcliente(CBCliente.Text);
                }
            }
        }
        public bool IsNumeric(string input)
        {
            long test;

            return long.TryParse(input, out test);
        }
        private void buscarcliente(string codcliente)
        {
            DataTable datocliente = new DataTable();
            
            

            datocliente = NegocioCliente.buscarCodigoCliente(codcliente);


            foreach (DataRow row in datocliente.Rows)
            {

                LblDNI.Text = Convert.ToString(row["cuit"]);
                LbIdcliente.Text = Convert.ToString(row["idcliente"]);
                CBCliente.Text = Convert.ToString(row["razon_social"]);
            }
        }

        private void CBMar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBMar.ValueMember != "")
            {
                UtilityFrm.completarcombobox(CBMod, "idmodelo", "modelo", Negocioserviciotecnico.buscarmodelo(Convert.ToInt32(CBMar.SelectedValue), Convert.ToInt32(CBEquipo.SelectedValue)));
            }
        }

        private void TxtSerie_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                buscarequipo(TxtSerie.Text);
            }
        }
        private void buscarequipo(string equiposerie)
        {
            DataTable mitabla = new DataTable();
            mitabla = Negocioserviciotecnico.buscarequipo(equiposerie, 0, 0, 0);
            if (mitabla.Rows.Count == 0)
            {
               UtilityFrm.mensajeConfirm("El equipo no se encuentra dado de alta");
            }
            else
            {
                foreach (DataRow  row in mitabla.Rows)
                {
                    CBEquipo.Text = Convert.ToString(row["equipo"]);
                    CBMar.Text =  Convert.ToString(row["marca"]);
                    CBMod.Text = Convert.ToString(row["modelo"]);
                }
            }

        }

        private void TxtBuscarEquipo_Click(object sender, EventArgs e)
        {
            FrmEquipo formequipo = new Capa_Presentacion.FrmEquipo();
            formequipo.ShowDialog();
            buscarequipo(formequipo.Serie); 
            
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

        private void CBMar_KeyDown(object sender, KeyEventArgs e)
        {
            DataTable tabla = new DataTable();

            if (e.KeyCode == Keys.Enter)
            {
                tabla = Negociogeneral.selecciondeconsultageneral("marca", "marca", CBMar.Text);
                if (tabla.Rows.Count == 0)
                {
                    if (UtilityFrm.mensajeopcionsiono("La marca" + CBMar.Text + " no esta cargado en el sistema, desea agregarlo?") == true)
                    {
                        Negocioserviciotecnico.agregarmarca(CBMar.Text);
                        string valor = CBMar.Text;
                        UtilityFrm.completarcombobox(CBMar, "idmarca", "marca", Negocioserviciotecnico.buscarmarca());



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
                        Negocioserviciotecnico.agregarmodelo(CBMod.Text, Convert.ToInt32(CBMar.SelectedValue), Convert.ToInt32(CBEquipo.SelectedValue));
                        string valor = CBMod.Text;
                        UtilityFrm.completarcombobox(CBMod, "idmodelo", "modelo", Negocioserviciotecnico.buscarmodelo(Convert.ToInt32(CBMar.SelectedValue), Convert.ToInt32(CBEquipo.SelectedValue)));
                        CBMod.Text = valor;

                    }
                    else
                    {
                        CBMod.Text = "";
                    }

                }
            }
        }

        private void xuiCustomGroupbox4_Enter(object sender, EventArgs e)
        {

        }

        private void BtnAgregarAccesorio_Click(object sender, EventArgs e)
        {
            if (TxtAccesorioequipo.Text  != "")
            {
                DGAccesorio.Rows.Add(TxtAccesorioequipo.Text );
                DGAccesorio.CurrentCell = DGAccesorio.Rows[DGAccesorio.Rows.Count - 1].Cells[1];
                TxtAccesorioequipo.Focus();
                TxtAccesorioequipo.SelectAll();
            }
        }

        private void DGAccesorio_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MenuEliminar.Visible = true;
                Menucontextual.Show(DGAccesorio, new Point(e.X, e.Y));
                
            }
        }

        private void Menueliminar_Click(object sender, EventArgs e)
        {
            
        }

        private void DGAccesorio_MouseClick(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Right)
            //{
            //    MenuEliminar.Visible = true;
            //    Menucontextual.Show(DGAccesorio, new Point(e.X, e.Y));
            //}
        }

        private void TxtAccesorioequipo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (TxtAccesorioequipo.Text != "")
                {
                    DGAccesorio.Rows.Add(TxtAccesorioequipo.Text);
               //     DGAccesorio.CurrentCell = DGAccesorio.Rows[DGAccesorio.Rows.Count - 1].Cells[1];
                    TxtAccesorioequipo.Focus();
                    TxtAccesorioequipo.SelectAll();
                }
            }
        }

        private void MenuEliminar_Click_1(object sender, EventArgs e)
        {
            if (DGAccesorio.Rows.Count > 0)
            {


                //selecciono la primera "0" porque solo selecciono 1 row
                int rowSelected = DGAccesorio.SelectedRows[0].Index;
                DGAccesorio.Rows.RemoveAt(rowSelected);



            }
            else
            {

                UtilityFrm.mensajeError("No existe Producto seleccionado ");


            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
