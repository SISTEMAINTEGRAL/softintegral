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
    public partial class FrmAperturacaja : Form
    {
        private DateTimePicker  fecha;
        public FrmAperturacaja()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            fecha = new DateTimePicker();
            Negociocaja objcaja = new Negociocaja();
            string varfecha = fecha.Text;
          
            long idcierre = 0;
            long idturno = 0;

            
                objcaja.extraercierre("id_turno",NegocioConfigEmpresa.nrocaja);
                idturno =   objcaja.Idturno  + 1 ;
                objcaja.extraercierre("cod_cierre",NegocioConfigEmpresa.nrocaja);
                idcierre =  objcaja.Idcierre + 1;
                
                string msg = Negociocaja.insertarcierrecaja(idcierre, DateTime.Now.ToString() , NegocioConfigEmpresa.turno , objcaja.Ingreso, objcaja.Egreso, idturno, 0, 0,0 ,NegocioConfigEmpresa.idusuario, "APERTURA",NegocioConfigEmpresa.nrocaja,0);

                if (msg == "ok")
                {
                    try
                    {
                        Negociocaja.insertarmovcaja(9100001, Convert.ToSingle(txtImporte.Text),
                         0, fecha.Value.ToString("dd/MM/yyyy"), NegocioConfigEmpresa.usuarioconectado, NegocioConfigEmpresa.idusuario, NegocioConfigEmpresa.turno,
                        "APERTURA DE CAJA", 0, true, NegocioConfigEmpresa.nrocaja,1);
                    }
                    catch (Exception s)
                    {

                        UtilityFrm.mensajeError(s.Message);
                    }
                    
                    
                
                }
                else
                {
                    UtilityFrm.mensajeError(msg);
                }
                

            
            this.Close();

        }

        private void FrmAperturacaja_Load(object sender, EventArgs e)
        {
            
           // lblTotalPagar.Text = fecha.ToShortDateString(); 
            label5.Text = Convert.ToString(DateTime.Now.Hour) + ":" + Convert.ToString(DateTime.Now.Minute); 
            llenarComboBox();
        }

        private void llenarComboBox()
        {
            string buscarnombre = "";
            this.cbCajero.DataSource = NegocioUsuario.mostrarusuario (buscarnombre);


            //valor real de la DB
            this.cbCajero.ValueMember = "idusuario";
            //lo que se muestra
            this.cbCajero.DisplayMember = "usuario";

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelHorizontal_MouseMove(object sender, MouseEventArgs e)
        {
            int posY = 0;
            int posX = 0;
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

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.FromArgb(0, 100, 200);
        }

        private void btnCerrar_MouseMove(object sender, MouseEventArgs e)
        {
            btnCerrar.BackColor = Color.Red;
        }
    }
}
