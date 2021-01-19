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
    public partial class FrmEmpresa : Form
    {
        public FrmEmpresa()
        {
            InitializeComponent();
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
            //if (NegocioConfigEmpresa.balanzapuerto != "")
            //{
            //    UtilityFrm.desconectarbalanza(serialPort1);
            //}

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

        private void btnCerrar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEmpresa_Load(object sender, EventArgs e)
        {
            cbrespiva.DataSource = NegocioCliente.responsabilidadiva();
            cbrespiva.ValueMember = "id";
            //lo que se muestra
            cbrespiva.DisplayMember = "descripcion";
            cbrespiva.SelectedIndex = 3;

            Cbprovincia.DataSource = NegocioCliente.provincia();
            Cbprovincia.ValueMember = "id";
            //lo que se muestra
            Cbprovincia.DisplayMember = "provincia";
            Cbprovincia.SelectedValue = 5;


            txtCuit.Text = NegocioConfigEmpresa.emcuit.ToString();
            txtRazonSocial.Text = NegocioConfigEmpresa.emrazonsocial.ToString();
            txtDireccion.Text = NegocioConfigEmpresa.emdomicilio.ToString();
            CBlocalidad.Text = NegocioConfigEmpresa.emlocalidad.ToString();
            Cbprovincia.Text = NegocioConfigEmpresa.emprovincia.ToString();
            cbrespiva.Text = NegocioConfigEmpresa.emciva.ToString();
            txtTelefono.Text = NegocioConfigEmpresa.emtelefono.ToString();



        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string iva = "";

            switch (cbrespiva.Text)
            {
                case "RESPONSABLE INSCRIPTO" :
                    {
                        iva = "RI";
                        break;
                    }
                case "MONOTRIBUTO":
                    {
                        iva = "MN";
                        break;
                    }
                case "EXCENTO":
                    {
                        iva = "EX";
                        break;
                    }

                default:
                    break;
            }

            //NegocioConfigEmpresa.modificar(txtRazonSocial.Text, iva, Convert.ToInt64( txtCuit.Text), CBlocalidad.Text, Cbprovincia.Text, txtDireccion.Text, txtTelefono.Text);
        }
    }
}
