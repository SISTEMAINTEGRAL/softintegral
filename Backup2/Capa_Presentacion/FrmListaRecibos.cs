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
using Capa_Presentacion.Formreportes;

namespace Capa_Presentacion
{
    public partial class FrmListaRecibos : Form
    {
        public FrmListaRecibos()
        {
            InitializeComponent();
        }

        private void BtnBuscarRecibo_Click(object sender, EventArgs e)
        {
            BuscarRecibo();
            
        }
        private void BuscarRecibo()
        {
            DgRecibos.DataSource = NegocioCliente.BuscarFechasRecibo(DTDesdeRec.Value.ToString("dd/MM/yyyy") + " 00:00:00", DTHastaRec.Value.ToString("dd/MM/yyyy") + " 23:59:59", true, !Chkcaja.Checked, 0, TxtNroRecibo.Text == "" ? 0 : Convert.ToInt32(TxtNroRecibo.Text));

            if (DgRecibos.Rows.Count != 0)
            {
                DgRecibos.Columns[5].Visible = false;
            }
        }
        private void DgRecibos_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow row = DgRecibos.CurrentRow;
            if (e.Button == MouseButtons.Right)
            {
                if (Convert.ToBoolean(row.Cells["concaja"].Value) == false )
                {
                   MenuConfRecibo.Visible = true;
                }
                else
                {
                    MenuConfRecibo.Visible = false;
                }

                contextMenuStrip1.Show(DgRecibos, new Point(e.X, e.Y));

                

            }
        }
        //VENTANA Y PANEL SUPERIOR

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            //maximizar
            this.btnRestaurar.Visible = true;
            this.btnMaximizar.Visible = false;
            this.WindowState = FormWindowState.Maximized;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //cierra
            this.Close();
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

        private void panelHorizontal_DoubleClick(object sender, EventArgs e)
        {
            if (btnRestaurar.Visible == false || btnMaximizar.Visible == true)
            {
                //maximizar
                this.btnRestaurar.Visible = true;
                this.btnMaximizar.Visible = false;
                this.WindowState = FormWindowState.Maximized;

            }
            else
            {
                //restaurar
                this.btnRestaurar.Visible = false;
                this.btnMaximizar.Visible = true;
                this.WindowState = FormWindowState.Normal;
            }
        }
        int posY = 0;
        int posX = 0;
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
        private void btnCerrar_MouseMove(object sender, MouseEventArgs e)
        {
            btnCerrar.BackColor = Color.Red;
        }
        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.FromArgb(0, 100, 200);
        }
        private void btnRestaurar_MouseMove(object sender, MouseEventArgs e)
        {
            btnRestaurar.BackColor = Color.FromArgb(65, 39, 60);
        }
        private void btnRestaurar_MouseLeave(object sender, EventArgs e)
        {
            btnRestaurar.BackColor = Color.FromArgb(0, 100, 200);
        }
        private void btnMaximizar_MouseMove(object sender, MouseEventArgs e)
        {
            btnMaximizar.BackColor = Color.FromArgb(65, 39, 60);
        }
        private void btnMaximizar_MouseLeave(object sender, EventArgs e)
        {
            btnMaximizar.BackColor = Color.FromArgb(0, 100, 200);
        }
        private void btnMinimizar_MouseMove(object sender, MouseEventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(65, 39, 60);
        }
        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(0, 100, 200);

        }
        private void Menureimprimir_Click(object sender, EventArgs e)
        {
           FrmReporteRecibo formrecibo = new Formreportes.FrmReporteRecibo(Convert.ToInt32( DgRecibos.CurrentRow.Cells["Codrecibo"].Value));
            formrecibo.ShowDialog();

        }

        private void MenuConfRecibo_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            bool constock = false;
            try
            {
                Negociocaja objcaja = new Negociocaja();

                DataGridViewRow row = DgRecibos.CurrentRow;
               
                if (Convert.ToBoolean(row.Cells["concaja"].Value) == false)
                {
                    if (objcaja.chequeocaja("", ref mensaje, NegocioConfigEmpresa.nrocaja) == true)
                    {
                         Negociocaja.insertarmovcaja(1310101, Convert.ToSingle( row.Cells["MontoPagado"].Value), 0, Convert.ToString(DateTime.Now), NegocioConfigEmpresa.usuarioconectado, NegocioConfigEmpresa.idusuario, NegocioConfigEmpresa.turno, "Recibo nro : " + row.Cells["codrecibo"].Value.ToString(), Convert.ToInt32(row.Cells["codrecibo"].Value), true, NegocioConfigEmpresa.nrocaja, 1);


                        NegocioCliente.modificarestadocajarecibo(Convert.ToInt32(row.Cells["codrecibo"].Value));
                        BuscarRecibo();
                    }
                    else
                    {
                        UtilityFrm.mensajeError(mensaje);

                    }

                }

            }
            catch (Exception i)
            {
                UtilityFrm.mensajeError(i.Message);

            }
        }
    }
}
