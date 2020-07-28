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
    public partial class FrmCaja : Form
    {
        

        private string ingegr;

        private long valoringreso;

        private long valoregreso;

        private DateTimePicker  fecha;

        private long idcierre;

        private long idturno;

        public FrmCaja()
        {
            
            InitializeComponent();
        }

        private void btnCierreX_Click(object sender, EventArgs e)
        {
         
            
           
          

        }

        private void btnCierreZ_Click(object sender, EventArgs e)
        {
            try
            {
          
            }
            catch (Exception ex)
            {

                UtilityFrm.mensajeError("Error de impresión, Causa:"+ex);
            }
            
           
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
            
           
           
            

        }

        //muestra en el combobox los resultados cargados en tipo movimiento de caja
        private void llenarComboBoxTipoMovimiento()
        {
           

            
            this.cbTipoMov.DataSource = Negociocaja.mostrartipomov(6,0, ingegr);
            //valor real de la DB
            this.cbTipoMov.ValueMember = "Codtipomov";
            //lo que se muestra
            this.cbTipoMov.DisplayMember = "Nombre";

        }

        //muestra en el combobox los resultados cargados en tipo movimiento de caja
        private void llenarComboBoxPlancuenta()
        {
            
            if (cbTipoMov.ValueMember != "")
            {
                this.cbxPlanCuenta.DataSource = Negociocaja.mostrartipomov(5, Convert.ToInt32(cbTipoMov.SelectedValue), " ");
            
            }
            
             
            //valor real de la DB
            this.cbxPlanCuenta.ValueMember = "Codigo_Plan";
            //lo que se muestra
            this.cbxPlanCuenta.DisplayMember = "Cuenta";

        }

        private void buscarporfecha()
        
        {
            {
                try
                {
                    this.dataLista.DataSource = Negociocaja.buscarmovimiento ( Convert.ToString  ( this.dtpFechaCaja.Text.Substring (0,10) + "00:00:00"),Convert.ToString (this.dtpFechaCaja.Text.Substring(0,10) + "23:59:59"),NegocioConfigEmpresa.nrocaja);
                }

                catch (Exception ex)
                {
                    UtilityFrm.mensajeError("Error Con Base de Datos :" + ex.Message);

                }
                //datasource el origen de los datos 

                //oculto las dos primeras columnas
               // this.ocultarColumnas();
                //muestro el total de las categorias
                lblTotal.Text = "Total de Registros: " + Convert.ToString(dataLista.RowCount);

            }     
           
        }

        private void grpboxConsulta_Enter(object sender, EventArgs e)
        {

        }

        private void FrmCaja_Load(object sender, EventArgs e)
        {
            //fecha =  DateTime.Now;
           // panelHorizontal.BackColor = Color.FromArgb(ComponentesFormularios.ColorPanelSuperiorVioleta());
            checkradioingegr();
            
            llenarComboBoxTipoMovimiento();
            
            Negociocaja objcaja = new Negociocaja();
            objcaja.extrestadocaja(1,"",0,false,NegocioConfigEmpresa.nrocaja);

            if (objcaja.Codcuenta != 0)
            {
                if (objcaja.Fecha.Substring(0, 10) != dtpFechaCaja.Value.ToString("dd/MM/yyyy"))
                {
                    if (objcaja.Codcuenta == 9100001)
                    {
                        DialogResult dialogResult = MessageBox.Show("La caja se encuentra abierta de una fecha anterior, desea cerrarla?", "Caja abierta", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            FrmCerrarCaja objcerrar = new FrmCerrarCaja();
                            objcerrar.ShowDialog();

                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            //do something else
                        }

                    }

                }

                if (objcaja.Codcuenta == 9100002)
                {
                    if (objcaja.Fecha.Substring(0, 10) == dtpFechaCaja.Value.ToString("dd/MM/yyyy"))
                    {
                        MessageBox.Show("La caja del dia de hoy esta cerrada");
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("La caja se encuentra cerrada, desea darle apertura?", "Caja cerrada", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            FrmAperturacaja objapertura = new FrmAperturacaja();
                            objapertura.ShowDialog();
                        }
                    }
                }
                

                //  else if (dialogResult == DialogResult.No)
               // {
                    //do something else
               // }
                
                
            }
            else
            {
                if (UtilityFrm.mensajeopcionsiono("Se detecto una nueva caja en el sistema, desea darle apertura?"))
                {
                    FrmAperturacaja objapertura = new FrmAperturacaja();
                    objapertura.ShowDialog();
                }
            }
            objcaja.extrestadocaja(1, "", 0,false,NegocioConfigEmpresa.nrocaja);
            estadoabicerrada(objcaja.Codcuenta);
            refrescarcaja(Convert.ToString(DateTime.Today));
            totales();
            // voy a usar pal reporte nae objcaja.Idcierre;
            //mireporte(obj
        }

        private void cbTipoMov_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            llenarComboBoxPlancuenta();
        }

        private void rbIngreso_CheckedChanged(object sender, EventArgs e)
        {

            checkradioingegr();
           

        }

        private void rbEgreso_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkradioingegr()
        {
            if (rbIngreso.Checked == true)
            {
                ingegr = "I";
            }

            if (rbEgreso.Checked == true)
            {
                ingegr = "E";
            }
            
            llenarComboBoxTipoMovimiento();
              
        
        }

        private void BtnCerrarCaja_Click(object sender, EventArgs e)
        {
            Negociocaja objcaja = new Negociocaja();
            FrmCerrarCaja objcerrar = new FrmCerrarCaja();
            objcerrar.ShowDialog();
            objcaja.extrestadocaja(1, "", 0,false,NegocioConfigEmpresa.nrocaja);
            estadoabicerrada(objcaja.Codcuenta);
            refrescarcaja(Convert.ToString(DateTime.Today));
            totales();
            
        }

        

        public void refrescarcaja(string fecha)
        {


           // DateTimePicker fecha = new DateTimePicker();
            DataTable midatatable = Negociocaja.buscarmovimiento(fecha.Substring(0, 10) + " 00:00:00", fecha.Substring(0, 10) + " 23:59:59",NegocioConfigEmpresa.nrocaja);
            dataLista.DataSource = midatatable;
            
            
            DataView dv = new DataView(midatatable);
            
            dv.RowFilter = "cod_cuenta = 9100001";
             foreach (DataRow lista in midatatable.Rows)
                {
                    

                    idcierre = Convert.ToInt64 ( lista["idcierre"].ToString()); 
                   
                
                }

            
            dataLista.AutoResizeColumns();
            dataLista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataLista.Columns["Fecha"].Width = 400;
            dataLista.Columns["Ingreso"].DefaultCellStyle.Format = "###,##0.00";
            dataLista.Columns["Egreso"].DefaultCellStyle.Format = "###,##0.00";
            //Cod_mov,Cod_cuenta,Concepto,Fecha ,Comprobante,Ingreso,Egreso,Turno
           
        }

        private void dtpFechaCaja_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void dtpFechaCaja_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {

                refrescarcaja (dtpFechaCaja.Value.ToString ("dd/MM/yyyy"));
                totales(); 
            }
        }

        private void totales()
        {
          float   varingreso = 0;
          float   varegreso = 0;


            foreach (DataGridViewRow row in dataLista.Rows)
            {
                if (row.Cells["Cod_cuenta"].Value.ToString () != "9100001")
                {
                    varingreso = varingreso + Convert.ToSingle(row.Cells["ingreso"].Value);
                    varegreso = varegreso + Convert.ToSingle(row.Cells["egreso"].Value);
                }
                else
                {
                    float var = Convert.ToSingle (row.Cells["ingreso"].Value.ToString());
                    txtsaldoinicial.Text = var.ToString ("0.00");
                }
                
            }
            float total = Convert.ToSingle( txtsaldoinicial.Text)  + (varingreso - varegreso);
            txtTotalIngreso.Text = varegreso.ToString("0.00")  ;
            txtToltaEgreso.Text  = varingreso.ToString ("0.00") ;
            txtTotal.Text = total.ToString("0.00");
           
            // Convert.ToSingle ( txtTotalIngreso.Text  ), Convert.ToSingle ( txtToltaEgreso.Text ), Convert.ToSingle ( txtTotal.Text )
        }
        private void estadoabicerrada(long codcuenta)
        {
            if (codcuenta == 9100001)
            {
                botonhabdes(false, true);
            }

            if (codcuenta  == 9100002)
            {
                botonhabdes(true, false);

            }
        
        }

        private void botonhabdes(bool habloq1, bool habloq2)
        { 
          
          BtnApertura.Enabled = habloq1;
          BtnCerrarCaja.Enabled = habloq2;
          btnAgregar.Enabled = habloq2;

        }

        private void dtpFechaCaja_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataLista_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Right)
            {

                contextMenuStrip1.Show(dataLista, new Point(e.X, e.Y));
                
             
            } 
        }

        private void dataLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Menudelete_Click(object sender, EventArgs e)
        {
            Negociocaja objcaja = new Negociocaja();
            bool eliminar = true;

            DataGridViewRow row = dataLista.CurrentRow;
            if (9100001 == Convert.ToInt32(row.Cells["Cod_cuenta"].Value.ToString()))
            {
                MessageBox.Show("No se puede eliminar la apertura");
                eliminar = false;
            }
            
            
            else
            {
                if (9100002 == Convert.ToInt32(row.Cells["Cod_cuenta"].Value.ToString()))
                {
                    objcaja.extrestadocaja(1, "",0,false,NegocioConfigEmpresa.nrocaja);
                    if (Convert.ToInt32(row.Cells["Cod_mov"].Value.ToString()) != objcaja.Codmov)
                    {
                        MessageBox.Show("No se puede eliminar este cierre");
                        eliminar = false;
                    }

                }
                if (eliminar == true)
                {
                    DialogResult dialogResult = MessageBox.Show("Seguro que quiere eliminar el movimiento?", "Precaucion", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string rta = Negociocaja.eliminar(Convert.ToInt32(row.Cells["Cod_mov"].Value.ToString()));
                        if (rta == "ok")
                        {
                            MessageBox.Show("Se elimino correctamente");

                        }

                    }

                }

            }
            refrescarcaja(dtpFechaCaja.Value.ToString("dd/MM/yyyy"));
            objcaja.extrestadocaja(1, "",0,false,NegocioConfigEmpresa.nrocaja);
            estadoabicerrada(objcaja.Codcuenta);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
                
            {
                Negociocaja objcaja = new Negociocaja();
                bool concaja = true;
                bool control = true;
                string msg = "";

                objcaja.extrestadocaja(1, "", 0,false,NegocioConfigEmpresa.nrocaja);
                objcaja.extrestadocaja(2, objcaja.Fecha.Substring(0,10), 0,false,NegocioConfigEmpresa.nrocaja);
                //codigo de cuenta para cierre de caja
                //si está cerrado no permite generar la venta hasta no abrir la caja
                if (objcaja.Fecha.Substring(0, 10) != Convert.ToString(DateTime.Today).Substring(0, 10))
                {
                    if (objcaja.Codcuenta == 9100001)
                    {
                        
                        concaja = false;
                        msg = "La caja se encuentra abierta de una fecha anterior, no se puede continuar";
                    }

                }

                if (objcaja.Codcuenta == 9100002)
                {
                    
                    concaja = false;
                    msg = "La caja esta cerrada, para vender realizar la apertura correspondiente";
                }

                if (concaja == true)
                {
                    if (rbEgreso.Checked == true)
                    {
                        if (objcaja.Ingreso < Convert.ToDouble(textBox2.Text))
                        {
                            control = false;
                            msg = "No tiene fondo para realizar el movimiento";
                        }
                    }

                    if ((TxtConcepto.Text == "") || (textBox2.Text == ""))
                    {

                        control = false;
                        msg = "Controle de no dejar valores en blanco y vuelva a intentar";


                    }

                    if (control == true)
                    {

                        string rpta = Negociocaja.insertarmovcaja(Convert.ToInt32(cbxPlanCuenta.SelectedValue), (rbIngreso.Checked == true) ? Convert.ToSingle(textBox2.Text) : 0,
                                             (rbEgreso.Checked == true) ? Convert.ToSingle(textBox2.Text) : 0, Convert.ToString(DateTime.Today), NegocioConfigEmpresa.usuarioconectado, 1, NegocioConfigEmpresa.turno,
                                             TxtConcepto.Text, 0, true,NegocioConfigEmpresa.nrocaja,1);
                        refrescarcaja(Convert.ToString(DateTime.Today));
                        totales();
                        checkradioingegr();
                        TxtConcepto.Clear();
                        textBox2.Clear();
                    }
                    else
                    {
                        UtilityFrm.mensajeError(msg);

                    }
                }
                else
                {
                    UtilityFrm.mensajeError(msg);
                
                }
               
            }
            catch (Exception ex)
            {
                UtilityFrm.mensajeError("Ha ocurrido un error:"+ ex.Message);
            }
          
        }

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
            this.Close();

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
            btnCerrar.BackColor = Color.FromArgb(ComponentesFormularios.ColorPanelSuperiorVioleta());
        }

        private void btnRestaurar_MouseMove(object sender, MouseEventArgs e)
        {
            btnRestaurar.BackColor = Color.FromArgb(65, 39, 60);
        }

        private void btnRestaurar_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(0, 100, 200);
        }


        private void btnMaximizar_MouseMove(object sender, MouseEventArgs e)
        {
            btnMaximizar.BackColor = Color.FromArgb(65, 39, 60);
        }

        private void btnMaximizar_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(0, 100, 200);
        }

        private void btnMinimizar_MouseMove(object sender, MouseEventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(65, 39, 60);
        }

        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.FromArgb(0, 100, 200);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void BtnInformecaja_Click(object sender, EventArgs e)
        {
            FrmReporteCaja mireportecaja = new FrmReporteCaja();
            mireportecaja.Idcierre = Convert.ToInt32 ( idcierre);
            mireportecaja.Idcaja = NegocioConfigEmpresa.nrocaja;
            mireportecaja.ShowDialog();
        }

        private void panelHorizontal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnApertura_Click(object sender, EventArgs e)
        {
            Negociocaja objcaja = new Negociocaja();
            FrmAperturacaja objformapcaja = new FrmAperturacaja();
            objcaja.extrestadocaja(1, "", 0, false, NegocioConfigEmpresa.nrocaja);
            if (objcaja.Fecha.Substring(0, 10) == dtpFechaCaja.Value.ToString("dd/MM/yyyy"))
            {
                MessageBox.Show("La caja del dia de la fecha se encuentra cerrada");

            }
            else
            {
                objformapcaja.ShowDialog();
                refrescarcaja(Convert.ToString(DateTime.Today));
                objcaja.extrestadocaja(1, "", 0, false, NegocioConfigEmpresa.nrocaja);
                estadoabicerrada(objcaja.Codcuenta);
            }
        }
    }
}
