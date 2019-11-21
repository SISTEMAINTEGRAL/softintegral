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
using Capa_Presentacion;


namespace SistemaVentas
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
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

        private void btnCerrar_MouseMove(object sender, MouseEventArgs e)
        {
            btnCerrar.BackColor = Color.Red;
        }

        private void btnMinimizar_MouseMove(object sender, MouseEventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(65, 39, 60);
        }
        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.Navy;
        }

        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.Navy;
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


        public void login()
        {
            try
            {


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void lblSistemaVenta_MouseMove(object sender, MouseEventArgs e)
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

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter){
                e.SuppressKeyPress = true;
                txtContraseña.Focus();
                
            }
        }

        private void txtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {


                e.SuppressKeyPress = true;
                NegocioUsuario objusuario = new NegocioUsuario();
                FrmInicio objini = new FrmInicio();
                try
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        if (objusuario.login(txtUsuario.Text, txtContraseña.Text) == true)
                        {

                            // NegocioConfigEmpresa.inivarglobal (System.Environment.MachineName,txtUsuario.Text,"mañana",);
                            // VERIFICA QUE EL EQUIPO ESTE DADO DE ALTA SI LO ESTA ACTUALIZA EL USUARIO SINO AGREGA EL EQUIPO 
                            string msg = NegocioConfigEmpresa.mostrarequipo(System.Environment.MachineName);
                            NegocioConfigEmpresa.mostrar();
                            NegocioConfigEmpresa.nombreusuario = objusuario.Nombreusuario;
                            NegocioConfigEmpresa.usuariosa = objusuario.Usuariosa;
                            NegocioConfigEmpresa.ReglasUsuario = objusuario.Reglaprivilegio.ToString().Split(',');


                            if (msg == "ok")
                            {

                                msg = NegocioConfigEmpresa.actualizarequipo(objusuario.Usuario, UtilityFrm.turnosegunhora(), objusuario.Idusuario, DateTime.Now, NegocioConfigEmpresa.idequipo);

                                msg = NegocioConfigEmpresa.mostrarequipo(System.Environment.MachineName);

                                if (msg == "ok")
                                {

                                    this.Hide();
                                    objini.Show();
                                }
                                else
                                {
                                    MessageBox.Show(msg);
                                }
                            }
                            else
                            {
                                MessageBox.Show(msg);
                                NegocioConfigEmpresa.confequipo(System.Environment.MachineName, txtUsuario.Text, UtilityFrm.turnosegunhora(), objusuario.Idusuario, 1, DateTime.Now, "", "", 1, 1, 1, "");
                            }



                        }
                        else
                        {
                            MessageBox.Show("El usuario o contraseña es incorrecta");
                        }

                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                btnIngresar.Focus();
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
             NegocioUsuario  objusuario = new NegocioUsuario  ();
             FrmInicio objini = new FrmInicio();
             try
             {
               

                if (objusuario.login(txtUsuario.Text, txtContraseña.Text) == true)
                 {

                    // NegocioConfigEmpresa.inivarglobal (System.Environment.MachineName,txtUsuario.Text,"mañana",);
                    // VERIFICA QUE EL EQUIPO ESTE DADO DE ALTA SI LO ESTA ACTUALIZA EL USUARIO SINO AGREGA EL EQUIPO 
                    string msg =  NegocioConfigEmpresa.mostrarequipo(System.Environment.MachineName);
                    NegocioConfigEmpresa.mostrar();
                    NegocioConfigEmpresa.nombreusuario = objusuario.Nombreusuario;
                    NegocioConfigEmpresa.usuariosa = objusuario.Usuariosa;
                    NegocioConfigEmpresa.ReglasUsuario = objusuario.Reglaprivilegio.ToString().Split(',');
                    

                    if (msg == "ok")
                    {
                       
                        msg = NegocioConfigEmpresa.actualizarequipo(objusuario.Usuario,UtilityFrm.turnosegunhora(), objusuario.Idusuario,DateTime.Now,NegocioConfigEmpresa.idequipo);

                        msg = NegocioConfigEmpresa.mostrarequipo(System.Environment.MachineName);

                        if (msg == "ok")
                        {

                            this.Hide();
                            objini.Show();
                        }
                        else
                        {
                            MessageBox.Show(msg);
                        }
                    }
                    else
                    {
                        MessageBox.Show(msg);
                        NegocioConfigEmpresa.confequipo(System.Environment.MachineName, txtUsuario.Text, UtilityFrm.turnosegunhora (), objusuario.Idusuario, 1, DateTime.Now, "", "", 1, 1, 1, "");
                    }

                     

                 }
                 else
                 {
                     MessageBox.Show("El usuario o contraseña es incorrecta");
                 }
             }
             catch(Exception ex)
             {
                 MessageBox.Show(ex.Message );
             }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}
