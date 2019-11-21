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
    public partial class FrmCerrarCaja : Form
    {

        private long idcierre;

        public long Idcierre
        {
            get { return idcierre; }
            set { idcierre = value; }
        }
        private long idturno;

        public long Idturno
        {
            get { return idturno; }
            set { idturno = value; }
        }

        private bool cerrocaja;

        public bool Cerrocaja
        {
            get { return cerrocaja; }
            set { cerrocaja = value; }
        }
        
        public FrmCerrarCaja()
        {
            InitializeComponent();
        }

        public FrmCerrarCaja(ref int cuenta)
        { 
          
        }

        private void BtnApertura_Click(object sender, EventArgs e)
        {


            string msg = "";
            Negociocaja objcaja = new Negociocaja();
            objcaja.extrestadocaja(1, "",0);
            float importe = 0 ;
            if (TxtConcepto.Text == "" || TxtConcepto.Text == "0")
            {
                MessageBox.Show("ingrese un importe para continuar");

            }
            else
            {
                importe = Convert.ToSingle( TxtConcepto.Text ) -  Convert.ToSingle(lblsaldoActual.Text) ;

                if (importe < 0)
                {
                  msg =  Negociocaja.insertarmovcaja(9100003, 0, (importe * -1) , objcaja.Fecha, NegocioConfigEmpresa.usuarioconectado, NegocioConfigEmpresa.idusuario , NegocioConfigEmpresa.turno, "FALTANTE DE CAJA", 0, true );
                }

                else if (importe > 0)  
                {
                    Negociocaja.insertarmovcaja(9100004, importe, 0, objcaja.Fecha, NegocioConfigEmpresa.usuarioconectado,NegocioConfigEmpresa.idusuario, NegocioConfigEmpresa.turno, "SOBRANTE DE CAJA", 0, true);
                }
               
                  msg =  Negociocaja.insertarmovcaja(9100002, 0, 0, objcaja.Fecha, NegocioConfigEmpresa.usuarioconectado, NegocioConfigEmpresa.idusuario, NegocioConfigEmpresa.turno, "CIERRE DE CAJA", 0, true);

                  if (msg == "ok")
                  {
                      idcierre = 0;
                      idturno = 0;
                      objcaja.extraercierre("id_turno");
                      idturno = objcaja.Idturno;
                      objcaja.extraercierre("cod_cierre");
                      idcierre = objcaja.Idcierre;
                      // objcaja.extrestadocaja(3, "", idturno);
                      
                      
                      objcaja.extrestadocaja(2, objcaja.Fecha.Substring(0, 10), 0,true);
                      if (this.Text == "Cierre de turno")
                      {
                          
                          Negociocaja.insertarcierrecaja(idcierre, objcaja.Fecha, NegocioConfigEmpresa.turno, objcaja.Ingreso, objcaja.Egreso, 1, Convert.ToDecimal (lblsaldoActual.Text), Convert.ToDecimal(TxtConcepto.Text), 1, NegocioConfigEmpresa.idusuario, "CIERRE");
                          
                      }

                      if (this.Text == "Cierre de caja")
                      {

                          Negociocaja.insertarcierrecaja(idcierre, DateTime.Now.ToString(), NegocioConfigEmpresa.turno, objcaja.Ingreso, objcaja.Egreso, idturno, Convert.ToDecimal(lblsaldoActual.Text), Convert.ToDecimal(TxtConcepto.Text), 1, NegocioConfigEmpresa.idusuario, "CIERRE");

                      }

                      if (msg != "ok")
                      {
                          UtilityFrm.mensajeError("Ha ocurrido un error: " + msg);

                      }
                  }
                  else
                  {
                      UtilityFrm.mensajeError("Ha ocurrido un error: " + msg);
                      
                    
                  }
                //Negociocaja.insertarmovcaja (    
          
            }
            this.Close();

        }

        private void FrmCerrarCaja_Load(object sender, EventArgs e)
        {
            try
            {

                Negociocaja objcaja = new Negociocaja();
                objcaja.extrestadocaja(1, "", 0);
                objcaja.extrestadocaja(2, objcaja.Fecha.Substring (0,10), 0);
                lblsaldoActual.Text = Convert.ToString(objcaja.Ingreso - objcaja.Egreso);
                lblsaldoActual.Text = lblsaldoActual.Text == "Saldo" ? "0" : lblsaldoActual.Text;
                if (this.Text == "Cierre de turno")
                {
                    BtnApertura.Text = "cerrar turno";

                }

            }
            catch (Exception x)
            {
                UtilityFrm.mensajeError(x.Message);
            }
                    }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            calculototales();
        }

        private void calculototales()
        {
            decimal  ac = 0;
            decimal   res = 0;
            TextBox[] atextbox = {textBox1,textBox2,textBox3,textBox4,textBox5,textBox6,textBox7,textBox8,textBox9,textBox10,textBox11,textBox12 };
            Label[] alabel = { label3,label5,label10,label11,label6,label7,label9,label8,label12,label13,label14,label15};

            for (int i = 0; i < atextbox.Length; i++)
            {
               
                if (atextbox[i].Text != "" )
                {
                    res = Convert.ToDecimal (atextbox[i].Text) * Convert.ToDecimal (alabel[i].Text);
                    ac = ac + res;
                }
            
            }
            TxtConcepto.Text = ac.ToString();

        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            calculototales();
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            calculototales();
        }

        private void textBox3_Validated(object sender, EventArgs e)
        {
            calculototales();
        }

        private void textBox4_Validated(object sender, EventArgs e)
        {
            calculototales();
        }

        private void textBox5_Validated(object sender, EventArgs e)
        {
            calculototales();
        }

        private void textBox6_Validated(object sender, EventArgs e)
        {
            calculototales();
        }

        private void textBox7_Validated(object sender, EventArgs e)
        {
            calculototales();
        }

        private void textBox8_Validated(object sender, EventArgs e)
        {
            calculototales();
        }

        private void textBox9_Validated(object sender, EventArgs e)
        {
            calculototales();
        }

        private void textBox10_Validated(object sender, EventArgs e)
        {
            calculototales();
        }

        private void textBox11_Validated(object sender, EventArgs e)
        {
            calculototales();
        }

        private void textBox12_Validated(object sender, EventArgs e)
        {
            calculototales();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.SelectAll();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.SelectAll();
        }
        private void textBox4_Click(object sender, EventArgs e)
        {
            
        }
        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.SelectAll();
        }
        private void textBox6_Click(object sender, EventArgs e)
        {
            textBox6.SelectAll();
        }
        private void textBox7_Click(object sender, EventArgs e)
        {
            textBox7.SelectAll();
        }
        private void textBox8_Click(object sender, EventArgs e)
        {
            textBox8.SelectAll();
        }
        private void textBox9_Click(object sender, EventArgs e)
        {
            textBox9.SelectAll();
        }
        private void textBox10_Click(object sender, EventArgs e)
        {
            textBox10.SelectAll();
        }
        private void textBox11_Click(object sender, EventArgs e)
        {
            textBox11.SelectAll();
        }
        private void textBox12_Click(object sender, EventArgs e)
        {
            textBox12.SelectAll();
        }

        private void textBox4_Click_1(object sender, EventArgs e)
        {
            textBox4.SelectAll();
        }

        private void textBox5_Click_1(object sender, EventArgs e)
        {
            textBox5.SelectAll();
        }

        private void textBox6_Click_1(object sender, EventArgs e)
        {
            textBox6.SelectAll();
        }

        private void textBox7_Click_1(object sender, EventArgs e)
        {
            textBox7.SelectAll();
        }

        private void textBox8_Click_1(object sender, EventArgs e)
        {
            textBox8.SelectAll();
        }

        private void textBox9_Click_1(object sender, EventArgs e)
        {
            textBox9.SelectAll();
        }

        private void textBox10_Click_1(object sender, EventArgs e)
        {
            textBox10.SelectAll();
        }

        private void textBox11_Click_1(object sender, EventArgs e)
        {
            textBox11.SelectAll();
        }

        private void textBox12_Click_1(object sender, EventArgs e)
        {
            textBox12.SelectAll();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            //maximizar
            this.btnRestaurar.Visible = true;
            this.btnMaximizar.Visible = false;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            //cierra
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbxCajas_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            calculototales();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            calculototales();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            calculototales();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            calculototales();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            calculototales();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            calculototales();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            calculototales();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            calculototales();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            calculototales ();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            calculototales();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            calculototales();
        }

       

    }
}
