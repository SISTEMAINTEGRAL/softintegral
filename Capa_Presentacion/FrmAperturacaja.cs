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

            
                objcaja.extraercierre("id_turno");
                idturno =  objcaja.Idturno == 1 ? 1 : objcaja.Idturno  + 1 ;
                objcaja.extraercierre("cod_cierre");
                idcierre = objcaja.Idcierre == 1 ? 1 : objcaja.Idcierre + 1;
                
                string msg = Negociocaja.insertarcierrecaja(idcierre, DateTime.Now.ToString() , NegocioConfigEmpresa.turno , objcaja.Ingreso, objcaja.Egreso, idturno, 0, 0,0 ,NegocioConfigEmpresa.idusuario, "APERTURA");

                if (msg == "ok")
                {
                    try
                    {
                        Negociocaja.insertarmovcaja(9100001, Convert.ToSingle(txtImporte.Text),
                         0, fecha.Value.ToString("dd/MM/yyyy"), NegocioConfigEmpresa.usuarioconectado, NegocioConfigEmpresa.idusuario, NegocioConfigEmpresa.turno,
                        "APERTURA DE CAJA", 0, true);
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
    }
}
