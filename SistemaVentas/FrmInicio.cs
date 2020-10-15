using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Presentacion;
using Capa_negocio;
using System.Threading;
namespace SistemaVentas
{
    public partial class FrmInicio : Form
    {
        
        //sirve para saber si el boton de despliegue está activo
        Boolean isVentaDesplegado = false;
        Boolean isProductoDesplegado = false;
        Boolean isStockDesplegado = false;

        int InicialusuariosY;
        int InicialproveedorY;
        int InicialclientesY;
        int InicialcajaY;
        int InicialstockY;
        int InicialconsultasY;
        int InicialVentasY;
        int InicialConfiguracionY;

        private FrmArticulos objformarticulo = null;
        private FrmArticulos2 objformarticulo2 = null;
        private frmPventa objformventa = null;
        private FrmProveedorCorregido objformproveedor = null;
        private FrmClientes objformcliente = null;
        private FrmCaja objformcaja = null;
        private FrmUsuario objformusuario = null;
        private FrmConfig objformconfig = null;
        private FrmListadoVentas objformlistaventa = null;
        private FrmPreciosmasivos objformpreciomasivo = null;
        private FrmPreciosmasivos2 objformpreciomasivo2 = null;
        private FrmConsulta objformconsulta = null;
        private FrmOrdenAdjudicacion objadj = null;
        private FrmStockRetirodeMercaderia objmerc = null;
        private FrmMovStock1 objstock = null;
        private frmPventa2 objformventa2 = null;

        private FrmConsulta Forminstanciaconsulta
        {
            get
            {
                if (objformconsulta == null)
                {
                    objformconsulta = new FrmConsulta();
                    objformconsulta.Disposed += new EventHandler(form_Disposedconsulta);
                }
                return objformconsulta;
            }
        }
        void form_Disposedconsulta(object sender, EventArgs e)
        {
            objformconsulta = null;
        }

        private FrmPreciosmasivos Forminstanciapreciomasivo
        {
            get
            {
                if (objformpreciomasivo == null)
                {
                    objformpreciomasivo = new FrmPreciosmasivos();
                    objformpreciomasivo.Disposed += new EventHandler(form_Disposedpreciomasivo);
                }
                return objformpreciomasivo;
            }
        }


        void form_Disposedpreciomasivo(object sender, EventArgs e)
        {
            objformpreciomasivo = null;
        }
        private FrmPreciosmasivos2 Forminstanciapreciomasivo2
        {
            get
            {
                if (objformpreciomasivo2 == null)
                {
                    objformpreciomasivo2 = new FrmPreciosmasivos2();
                    objformpreciomasivo2.Disposed += new EventHandler(form_Disposedpreciomasivo2);
                }
                return objformpreciomasivo2;
            }
        }
        void form_Disposedpreciomasivo2(object sender, EventArgs e)
        {
            objformpreciomasivo2 = null;
        }

        private FrmListadoVentas Forminstancialistadoventa
        {
            get
            {
                if (objformlistaventa == null)
                {
                    objformlistaventa = new FrmListadoVentas();
                    objformlistaventa.Disposed += new EventHandler(form_Disposedlistadoventa);
                }
                return objformlistaventa;
            }
        }
        void form_Disposedlistadoventa(object sender, EventArgs e)
        {
            objformlistaventa = null;
        }

        private FrmCaja Forminstanciacaja
        {
            get
            {
                if (objformcaja == null)
                {
                    objformcaja = new FrmCaja();
                    objformcaja.Disposed += new EventHandler(form_Disposedcaja);
                }
                return objformcaja;
            }
        }
        void form_Disposedcaja(object sender, EventArgs e)
        {
            objformcaja = null;
        }

        private FrmClientes Forminstanciacliente
        {
            get
            {
                if (objformcliente == null)
                {
                    objformcliente = new FrmClientes();
                    objformcliente.Disposed += new EventHandler(form_DisposedCliente);
                }
                return objformcliente;
            }
        }
        void form_DisposedCliente(object sender, EventArgs e)
        {
            objformcliente = null;
        }


        private frmPventa Forminstanciaventa
        {
            get
            {
                if (objformventa == null)
                {
                    objformventa = new frmPventa();
                    objformventa.Disposed += new EventHandler(form_DisposedVenta);
                }
                return objformventa;
            }
        }
        private frmPventa2 Forminstanciaventa2
        {
            get
            {
                if (objformventa2 == null)
                {
                    objformventa2 = new frmPventa2();
                    objformventa2.Disposed += new EventHandler(form_DisposedVenta2);
                }
                return objformventa2;
            }
        }
        void form_DisposedVenta(object sender, EventArgs e)
        {
            objformventa = null;
        }
        void form_DisposedVenta2(object sender, EventArgs e)
        {
            objformventa2 = null;
        }

        private FrmArticulos  FormInstanciaProd
        {
            get
            {
                if (objformarticulo == null)
                {
                    objformarticulo = new FrmArticulos ();
                    objformarticulo.Disposed += new EventHandler(form_DisposedArticulo);
                }
                return objformarticulo;
            }
        
        }

        private FrmArticulos2 FormInstanciaProd2
        {
            get
            {
                if (objformarticulo2 == null)
                {
                    objformarticulo2 = new FrmArticulos2();
                    objformarticulo2.Disposed += new EventHandler(form_DisposedArticulo2);
                }
                return objformarticulo2;
            }

        }
        void form_DisposedArticulo(object sender, EventArgs e)
        {
            objformarticulo = null;
        }
        void form_DisposedArticulo2(object sender, EventArgs e)
        {
            objformarticulo2 = null;
        }
        private FrmProveedorCorregido FormInstanciaProv
        {
            get
            {
                if (objformproveedor == null)
                {
                    objformproveedor = new FrmProveedorCorregido();
                    objformproveedor.Disposed += new EventHandler(form_DisposedProv);
                }
                return objformproveedor;
            }

        }
        void form_DisposedProv(object sender, EventArgs e)
        {
            objformproveedor = null;
        }

        private FrmStockRetirodeMercaderia Forminstanciaretiro
        {
            get
            {
                if (objmerc == null)
                {
                    objmerc = new FrmStockRetirodeMercaderia();
                    objmerc.Disposed += new EventHandler(form_Disposedmerc);
                }
                return objmerc;
            }
        }
        void form_Disposedmerc(object sender, EventArgs e)
        {
            objmerc = null;
        }
        private FrmMovStock1 Forminstanciastock
        {
            get
            {
                if (objstock == null)
                {
                    objstock = new FrmMovStock1();
                    objstock.Disposed += new EventHandler(form_Disposedstock);
                }
                return objstock;
            }
        }
        void form_Disposedstock(object sender, EventArgs e)
        {
            objstock = null;
        }

        private FrmOrdenAdjudicacion ForminstanciaAdjudicacion
        {
            get
            {
                if (objadj== null)
                {
                    objadj = new FrmOrdenAdjudicacion();
                    objadj.Disposed += new EventHandler(form_Disposedadjudicacion);
                }
                return objadj;
            }
        }
        void form_Disposedadjudicacion(object sender, EventArgs e)
        {
            objadj = null;
        }
        public FrmInicio()
        {
            //le paso al delegado threadStart el metodo abrirformulario
            Thread t = new Thread(new ThreadStart(abrirFormulario));
            t.Start();
            //Thread.Sleep(1000);
            Thread.Sleep(3000);

            InitializeComponent();
            t.Abort();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
           
            NegocioUsuario objusuario = new NegocioUsuario();
           // panelHorizontal.BackColor = Color.FromArgb(ComponentesFormularios.ColorPanelSuperiorVioleta());
            

            //posicion inicial

             InicialusuariosY = btnUsuarios.Location.Y;
            InicialproveedorY = btnProveedor.Location.Y;
             InicialclientesY = btnClientes.Location.Y;
            InicialcajaY = btnCaja.Location.Y;
            InicialstockY = btnStock.Location.Y;
            InicialconsultasY = btnConsultas.Location.Y;
            InicialVentasY = btnVentas.Location.Y;
            InicialConfiguracionY = btnConfiguracion.Location.Y;

            //Turno segun la hora

            NegocioConfigEmpresa.turno = UtilityFrm.turnosegunhora();


            //privilegios
            if (NegocioConfigEmpresa.usuariosa != true)
            { 
              btnProductos.Visible = objusuario.TieneRegla ("37");
              btnVentas.Visible = objusuario.TieneRegla("38");
              btnProveedor.Visible = objusuario.TieneRegla("39");
              btnClientes.Visible = objusuario.TieneRegla("40");
              btnCaja.Visible = objusuario.TieneRegla("41");
              btnUsuarios.Visible = objusuario.TieneRegla("42");
              btnStock.Visible = objusuario.TieneRegla("43");
              btnConfiguracion.Visible = objusuario.TieneRegla("44");


            }

        }

        private void FrmInicio_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.F1)
            {
                //AYUDAS DE TECLADO
                if (lbl1.Visible == true)
                {
                    lbl1.Visible = false;
                    lbl2.Visible = false;
                    lbl3.Visible = false;
                    lbl4.Visible = false;
                    lbl5.Visible = false;
                    lbl6.Visible = false;
                    lbl7.Visible = false;
                    lbl8.Visible = false;
                    lbl1.SendToBack();
                    lbl2.SendToBack();
                    lbl3.SendToBack();
                    lbl4.SendToBack();
                    lbl5.SendToBack();
                    lbl6.SendToBack();
                    lbl7.SendToBack();
                    lbl8.SendToBack();
                }
                else
                {
                    lbl1.Visible = true;
                    lbl2.Visible = true;
                    lbl3.Visible = true;
                    lbl4.Visible = true;
                    lbl5.Visible = true;
                    lbl6.Visible = true;
                    lbl7.Visible = true;
                    lbl8.Visible = true;
                    lbl1.BringToFront();
                    lbl2.BringToFront();
                    lbl3.BringToFront();
                    lbl4.BringToFront();
                    lbl5.BringToFront();
                    lbl6.BringToFront();
                    lbl7.BringToFront();
                    lbl8.BringToFront();
                }  

            }
        }


        public void abrirFormulario()
        {

            Application.Run( new SplashScreen());
           
        }

        //color panelprincipal 65; 39; 60
        //metodos
        private  void abrirMDIParent(Form formularioHijo) {

            if (panelPrincipal.Controls.Count > 0)
            {
                this.panelPrincipal.Controls.RemoveAt(0);
            }
                //forma de mostrarse como ventana de nivel superior desactivada
                           
                formularioHijo.TopLevel = false;
                formularioHijo.Dock= DockStyle.Fill;
                this.panelPrincipal.Controls.Add(formularioHijo);
                this.panelPrincipal.Tag = formularioHijo;


                Thread.Sleep(1000);
               formularioHijo.Show();
        }
       
        //maximizar
            //this.btnRestaurar.Visible = true;
            //this.btnMax.Visible = false;
            //this.WindowState = FormWindowState.Maximized;

   

       
      

        //VENTANA Y PANEL SUPERIOR
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            //vuelve tamaño original
            this.btnRestaurar.Visible = false;
            this.btnMaximizar.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //cierra
            this.Dispose();
            Application.Exit();
            this.Close();
            
            
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
                //maximizar
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


        //BOTONES LATERAL IZQUIERDO
        int usuariosY;
        int cajaY;
        int clientesY;
        int proveedorY;
        int ventasY;
        int stockY;
        int consultasY;
        int configuracionY;
        int recibosY;

        private void btnProductos_Click(object sender, EventArgs e)
        {

            //valor constante que se tienen que mover los botones
            int movimiento = 200;
            if (btnCategoria.Visible == false && btnListaProducto.Visible == false)
            {
                
                if(isVentaDesplegado==true || isStockDesplegado == true) {
                //si se encuentra desplegado se vuelve al Lugar Inicial
                    volverAPosicionInicial();

                }
                isProductoDesplegado = true;
                //asigno los valores de la coordenadas Y de los botones antes de mover
                ventasY = btnVentas.Location.Y;
                proveedorY = btnProveedor.Location.Y;
                clientesY = btnClientes.Location.Y;
                cajaY = btnCaja.Location.Y;
                usuariosY = btnUsuarios.Location.Y;
                stockY = btnStock.Location.Y;
                consultasY = btnConsultas.Location.Y;
                configuracionY = btnConfiguracion.Location.Y;

                btnCategoria.Visible = true;
                btnListaProducto.Visible = true;
                pnCategoria.Visible = true;
                pnlistaProducto.Visible = true;
                btnConsultas.Visible = true;
                pnConsultas.Visible = true;
                pnConfig.Visible = true;
                BtnPrecioMasivo.Visible = true;
                Pnlpreciomasivo.Visible = true;
               


                //al hacer click en producto se desplaza los submenus
                //sumo la posicion actual más un valor preciso para abarcar la posicion exacta
                //botones
                btnVentas.Location = new System.Drawing.Point(0, (ventasY+movimiento));
                btnProveedor.Location = new System.Drawing.Point(0, (proveedorY + movimiento));
                btnClientes.Location = new System.Drawing.Point(0, (clientesY + movimiento));
                btnCaja.Location = new System.Drawing.Point(0, (cajaY + movimiento));
                btnUsuarios.Location = new System.Drawing.Point(0, (usuariosY + movimiento));
                btnStock.Location = new System.Drawing.Point(0, (stockY + movimiento));
                btnConfiguracion.Location = new System.Drawing.Point(0, (configuracionY + movimiento));
                //paneles
                pnVentas.Location=new System.Drawing.Point(0, (ventasY+movimiento));
                pnProveedor.Location=new System.Drawing.Point(0, (proveedorY+movimiento));
                pnClientes.Location=new System.Drawing.Point(0, (clientesY + movimiento));
                pnCaja.Location=new System.Drawing.Point(0, (cajaY + movimiento));
                pnUsuarios.Location = new System.Drawing.Point(0, (usuariosY + movimiento));
                pnStock.Location = new System.Drawing.Point(0, (stockY + movimiento));
                pnConfig.Location = new System.Drawing.Point(0, (configuracionY + movimiento));
            }
            else {
                volverAPosicionInicial();
          
            }
        }

     
        private void btnVentas_Click(object sender, EventArgs e)
        {
            
            //valor constante que se tienen que mover los botones
            int movimiento = 100;

            if (btnGenerarVenta.Visible == false && btnListaVenta.Visible == false && BtnRecibo.Visible == false)
            {
              
                if (isProductoDesplegado == true || isStockDesplegado == true)
                {
                    //si se encuentra desplegado se vuelve al Lugar Inicial
                    volverAPosicionInicial();

                }
                isVentaDesplegado = true;
                //asigno los valores de la coordenadas Y de los botones antes de mover
                ventasY = btnVentas.Location.Y;
                proveedorY = btnProveedor.Location.Y;
                clientesY = btnClientes.Location.Y;
                cajaY = btnCaja.Location.Y;
                usuariosY = btnUsuarios.Location.Y;
                stockY = btnStock.Location.Y;
                consultasY = btnConsultas.Location.Y;
                configuracionY = btnConfiguracion.Location.Y;
                recibosY = BtnRecibo.Location.Y;

                btnGenerarVenta.Visible = true;
                btnListaVenta.Visible = true;
                pnGenerarVenta.Visible = true;
                pnListaVenta.Visible = true;
                pnConfig.Visible = true;
                BtnRecibo.Visible = true;
               

                //al hacer click en producto se desplaza los submenus
                //sumo la posicion actual más un valor preciso para abarcar la posicion exacta
                //botones

                btnProveedor.Location = new System.Drawing.Point(0, (proveedorY + movimiento));
                btnClientes.Location = new System.Drawing.Point(0, (clientesY + movimiento));
                btnCaja.Location = new System.Drawing.Point(0, (cajaY + movimiento));
                btnUsuarios.Location = new System.Drawing.Point(0, (usuariosY + movimiento));
                btnStock.Location = new System.Drawing.Point(0, (stockY + movimiento));
                btnConfiguracion.Location = new System.Drawing.Point(0, (configuracionY + movimiento));
                //paneles

                pnProveedor.Location = new System.Drawing.Point(0, (proveedorY + movimiento));
                pnClientes.Location = new System.Drawing.Point(0, (clientesY + movimiento));
                pnCaja.Location = new System.Drawing.Point(0, (cajaY + movimiento));
                pnUsuarios.Location = new System.Drawing.Point(0, (usuariosY + movimiento));
                pnStock.Location = new System.Drawing.Point(0, (stockY + movimiento));
                pnConfig.Location = new System.Drawing.Point(0, (configuracionY + movimiento));
            }
            else
            {

                volverAPosicionInicial();

            }


            
        }
        private void btnListaProducto_Click(object sender, EventArgs e)
        {
            if (NegocioConfigEmpresa.confsistema("opcionsistema").ToString() == "negocio")
            {
                FrmArticulos2 articulos = this.FormInstanciaProd2;
                articulos.Show();
                articulos.WindowState = FormWindowState.Maximized;
                articulos.BringToFront();

            }
            else if (NegocioConfigEmpresa.confsistema("opcionsistema").ToString() == "mayorista")
            {
                FrmArticulos articulos = this.FormInstanciaProd;
                articulos.Show();
                articulos.WindowState = FormWindowState.Maximized;
                articulos.BringToFront();
            }

        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            FrmCategoria categoria = new FrmCategoria();
            categoria.Show();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            //sgpProgresoFormulario.Visible = true;
            FrmProveedorCorregido proveedor = this.FormInstanciaProv ;
            proveedor.Opcionvista = 1;

            proveedor.Show();
            //proveedor.WindowState = FormWindowState.Maximized;
            proveedor.BringToFront();
            
            

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmClientes clientes = this.Forminstanciacliente;
            clientes.Modoshowdialog = false;
            clientes.Show();
            clientes.WindowState = FormWindowState.Maximized;
            clientes.BringToFront();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {

            //valor constante que se tienen que mover los botones
            int movimiento = 150;

            if (BtnAdjudicaciones.Visible == false && BtnListaStock.Visible == false && BtnListaStock.Visible == false)
            {

                if (isStockDesplegado == true || isProductoDesplegado  == true || isVentaDesplegado == true)
                {
                    //si se encuentra desplegado se vuelve al Lugar Inicial
                    volverAPosicionInicial();

                }
                isStockDesplegado = true;
               
                configuracionY = btnConfiguracion.Location.Y;
                PlAdj.Visible = true;
                PlRetiro.Visible = true;
                Plstock.Visible = true;

                BtnListaStock.Visible = true;
                BtnRetiroMerc.Visible = true;
                BtnAdjudicaciones.Visible = true;
               

                
                btnConfiguracion.Location = new System.Drawing.Point(0, (configuracionY + movimiento));
                
                pnConfig.Location = new System.Drawing.Point(0, (configuracionY + movimiento));
            }
            else
            {

                volverAPosicionInicial();

            }
            //Frmstockmov stock = new Frmstockmov();
            //FrmStockmov stock = new FrmStockmov();

            //FrmMovStock1 stock = new FrmMovStock1();
            //stock.ShowDialog();

            //abrirMDIParent(stock);
        }

        private void lblSistemaVenta_Click(object sender, EventArgs e)
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
                //maximizar
                this.btnRestaurar.Visible = false;
                this.btnMaximizar.Visible = true;
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
           
        }

        private void panelHorizontal_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void btnCaja_Click(object sender, EventArgs e)
        {
            FrmCaja caja = this.Forminstanciacaja ;
            caja.Show();
            caja.WindowState = FormWindowState.Maximized;
            caja.BringToFront();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            try
            {
                FrmConsulta precio = this.Forminstanciaconsulta;
                precio.Show();
                precio.WindowState = FormWindowState.Maximized;
                precio.BringToFront();
            }
            catch (Exception ex)
            {

                UtilityFrm.mensajeError("error "+ex);
            }
            

        }

        private void btnTecnico_Click(object sender, EventArgs e)
        {
            FrmImpresora configuracion = new FrmImpresora();
            configuracion.ShowDialog();

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {

            FrmUsuario usuario = new FrmUsuario();
         
            //sgpProgresoFormulario.Visible = true;
            abrirMDIParent(usuario);

          //  backgroundWorker1.RunWorkerAsync();
           
            
           // 


            
         
            
            
        }

        public void mostrarFormularioUsuario()
        {
            //espera
            FrmUsuario usuario = new FrmUsuario();
            Thread.Sleep(1000);
            abrirMDIParent(usuario);
        }

       

        private void btnListaVenta_Click(object sender, EventArgs e)
        {
            
            FrmListadoVentas listadoVentas = this.Forminstancialistadoventa;
            listadoVentas.Show();
            listadoVentas.WindowState = FormWindowState.Maximized;
            listadoVentas.BringToFront();
        }

     



       


        //vuelve a la normalidad todos los botones en el caso de que se encuentren desplegados
        public void volverAPosicionInicial()
        {
            isVentaDesplegado = false;
            isProductoDesplegado = false;
            isStockDesplegado = false;

            BtnRecibo.Visible = false;
            btnCategoria.Visible = false;
            btnListaProducto.Visible = false;
            pnCategoria.Visible = false;
            pnlistaProducto.Visible = false;
            btnConsultas.Visible = false;
            pnConsultas.Visible = false;
            btnGenerarVenta.Visible = false;
            btnListaVenta.Visible = false;
            pnListaVenta.Visible = false;
            pnGenerarVenta.Visible = false;
            BtnPrecioMasivo.Visible = false;
            Pnlpreciomasivo.Visible = false;
            BtnRetiroMerc.Visible = false;
            BtnListaStock.Visible = false;
            BtnAdjudicaciones.Visible = false;
            PlRetiro.Visible = false;
            Plstock.Visible = false;
            PlAdj.Visible = false;
            
           
            //al hacer click en producto se contrae los submenus
            //botones
            btnVentas.Location = new System.Drawing.Point(0, InicialVentasY);
            btnUsuarios.Location = new System.Drawing.Point(0, InicialusuariosY);
            btnCaja.Location = new System.Drawing.Point(0, InicialcajaY);
            btnClientes.Location = new System.Drawing.Point(0, InicialclientesY);
            btnProveedor.Location = new System.Drawing.Point(0, InicialproveedorY);
            btnStock.Location = new System.Drawing.Point(0, (InicialstockY));
            btnConfiguracion.Location = new System.Drawing.Point(0, (InicialConfiguracionY));


            //paneles
            pnVentas.Location = new System.Drawing.Point(0, InicialVentasY);
            pnProveedor.Location = new System.Drawing.Point(0, InicialproveedorY);
            pnClientes.Location = new System.Drawing.Point(0, InicialclientesY);
            pnCaja.Location = new System.Drawing.Point(0, InicialcajaY);
            pnUsuarios.Location = new System.Drawing.Point(0, InicialusuariosY);
            pnStock.Location = new System.Drawing.Point(0, InicialstockY);
            pnConfig.Location = new System.Drawing.Point(0, (InicialConfiguracionY));
        }

        private void btnGenerarVenta_Click(object sender, EventArgs e)
        {
            if (NegocioConfigEmpresa.confsistema("opcionsistema").ToString() == "negocio")
            {
                frmPventa2 objventa = this.Forminstanciaventa2;
                objventa.Show();
                objventa.WindowState = FormWindowState.Maximized;
                objventa.BringToFront();
            }
            else if (NegocioConfigEmpresa.confsistema("opcionsistema").ToString() == "mayorista")
            {
                frmPventa objventa = this.Forminstanciaventa;
                objventa.Show();
                objventa.WindowState = FormWindowState.Maximized;
                objventa.BringToFront();
            }
                
           
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            mostrarFormularioUsuario();
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnPrecioMasivo_Click(object sender, EventArgs e)
        {
             if (NegocioConfigEmpresa.confsistema("opcionsistema").ToString() == "mayorista")
            {
                FrmPreciosmasivos objpreciomasivo = this.Forminstanciapreciomasivo;
                objpreciomasivo.Show();
                objpreciomasivo.WindowState = FormWindowState.Maximized;
                objpreciomasivo.BringToFront();
            }
            else if (NegocioConfigEmpresa.confsistema("opcionsistema").ToString() == "negocio")
            {
                FrmPreciosmasivos2 objpreciomasivo = this.Forminstanciapreciomasivo2;
                objpreciomasivo.Show();
                objpreciomasivo.WindowState = FormWindowState.Maximized;
                objpreciomasivo.BringToFront();
            }
           
            
        }

        private void BtnListaStock_Click(object sender, EventArgs e)
        {
            
            objstock = this.Forminstanciastock;
            objstock.Show();
            objstock.WindowState = FormWindowState.Maximized;
            objstock.BringToFront();
        }

        private void BtnAdjudicaciones_Click(object sender, EventArgs e)
        {
            objadj = this.ForminstanciaAdjudicacion;
            objadj.Show();
            objadj.WindowState = FormWindowState.Maximized;
            objadj.BringToFront();
        }

        private void BtnRetiroMerc_Click(object sender, EventArgs e)
        {
            objmerc = this.Forminstanciaretiro;
            objmerc.Show();
            objmerc.WindowState = FormWindowState.Maximized;
            objmerc.BringToFront();
        }

        private void BtnTarjeta_Click(object sender, EventArgs e)
        {
            FrmTarjeta objtarjeta = new FrmTarjeta();
            objtarjeta.Show();
        }

        private void BtnRecibo_Click(object sender, EventArgs e)
        {
            FrmListaRecibos objrecibo = new FrmListaRecibos();
            objrecibo.Show();
        }
    }
}
