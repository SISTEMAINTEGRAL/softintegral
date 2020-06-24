using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_Datos;
using FiscalPrinterLib;

namespace Capa_negocio
{   

   public class Negociocaja
       
    {
       
       
        private long idturno;

        public long Idturno
        {
            get { return idturno; }
            set { idturno = value; }
        }

        

        private long codmov;

        public long Codmov
        {
            get { return codmov; }
            set { codmov = value; }
        }
        private float ingreso;

        public float Ingreso
        {
            get { return ingreso; }
            set { ingreso = value; }
        }
        private float egreso;

        public float Egreso
        {
            get { return egreso; }
            set { egreso = value; }
        }

        private string fecha;

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

       private string fechad;

        public string Fechad
        {
          get { return fechad; }
          set { fechad = value; }

   
        }
        private string fechah;
       

        public string Fechah
        {
          get { return fechah; }
          set { fechah = value; }
        }private long idcierre;

        public long Idcierre
        {
            get { return idcierre; }
            set { idcierre = value; }
        }

        private long   codcuenta;

        public long Codcuenta
        {
            get { return codcuenta; }
            set { codcuenta = value; }
        }

        public static DataTable mostrartipomov(int modo, int tipomodo, string ingegr)
        {
            
            return new DatosCaja().mostrartipomov(modo, tipomodo,ingegr );
        }

        public static DataTable buscarmovimiento(string   fechadesde, string fechahasta)
        {
            DatosCaja  caja = new DatosCaja ();
           
            caja.FechaD1   = fechadesde;
            caja.FechaH1 = fechahasta;
           
           
            //seguir de aca
            return caja.metbuscarfecha(caja.FechaD1, caja.FechaH1);
          
        }

        public static string insertarmovcaja(long codcuenta , float ingreso, float egreso, string Fecha , string usuario, int  idusuario , string turno , string concepto, long comprobante , bool estado)
        {
            DatosCaja objcaja = new DatosCaja();
            
            objcaja.Codcuenta  = codcuenta;
            objcaja.Ingreso  = ingreso;
            objcaja.Egreso = egreso;
            objcaja.Fecha = Fecha;
            objcaja.Usuario = usuario;
            objcaja.Idusuario = idusuario;
            objcaja.Turno = turno;
            objcaja.Concepto = concepto;
            objcaja.Comprobante = comprobante;
            objcaja.Estado = estado;
            
            
            return objcaja.agregar(objcaja);
        }

        public static string insertarcierrecaja(long codcierre, string fecha, string turno, float totalingreso, float  totalegreso, long idturno, decimal impsistema, decimal impreal, long idcaja, int usuario, string aperturacierre)
        {
            DatosCaja objcaja = new DatosCaja();

            objcaja.Idcierre = codcierre;
            objcaja.Fecha = fecha;
            objcaja.Turno = turno;
            objcaja.Ingreso = totalingreso;
            objcaja.Egreso = totalegreso;
            objcaja.Idturno = idturno;
            objcaja.Impsistema = impsistema;
            objcaja.Impreal = impreal;
            objcaja.Idcaja = idcaja;
            objcaja.Idusuario = usuario;
            objcaja.Aperturacierre = aperturacierre; 

            return objcaja.agregarcierre(objcaja);
        
        }

        public bool chequeocaja(string formulario,ref string mensaje)
        {
            
            bool concaja = true;
            mensaje = "";
            

            this.extrestadocaja(1, "", 0);
            //codigo de cuenta para cierre de caja
            //si está cerrado no permite generar la venta hasta no abrir la caja
            if (this.Fecha.Substring(0, 10) != Convert.ToString(DateTime.Today).Substring(0, 10))
            {
                if (this.Codcuenta == DatosCaja.cuentaaperturacaja)
                {
                    // DialogResult dialogResult = MessageBox.Show("La caja se encuentra abierta de una fecha anterior, no se puede continuar", "Caja abierta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //  varguardar = "";
                    mensaje = "La caja se encuentra abierta de una fecha anterior, no se puede continuar";
                    concaja = false;
                }

            }

            if (this.Codcuenta == DatosCaja.cuentacierrecaja)
            {
                //UtilityFrm.mensajeError("La caja esta cerrada, para vender realizar la apertura correspondiente");
                //                varguardar = "";
                mensaje = "La caja se encuentra cerrada, realizar la apertura correspondiente antes de continuar";
                concaja = false;
            }
            if ("FrmClientes" != formulario)
            {
                if (NegocioConfigEmpresa.confsistema("puntodeventa").ToString() != formulario)
                {
                    if (formulario != "")
                    {
                        concaja = false;
                    }
                    


                }
            }
          

           

            return concaja;
        }
        public  void extrestadocaja(int modo, string fecha, long idturno, bool ingreso = false)
        {
            //modo 1 = movimiento de caja, modo 2 : suma de ingresos y egresos segun fecha diaria, modo 3 : suma de ingresos y egresos segun turno
            DatosCaja  ObjCaja= new DatosCaja ();

            ObjCaja.Extestadocaja(modo,fecha,idturno, ingreso  );

            if (modo == 1)
            {

                 this.codcuenta = ObjCaja.Codcuenta;
                 this.fecha = ObjCaja.Fecha;
                 this.codmov = ObjCaja.Codmov;
          
            
            }

            if (modo == 2)
            {
                this.ingreso = ObjCaja.Ingreso;
                this.egreso = ObjCaja.Egreso;
              
            }
            

        }
      
       public static string eliminar(long codmov)
        {

            DatosCaja objcaja = new DatosCaja();
            objcaja.Codmov  = codmov;
            return objcaja.eliminarcaja (objcaja);
        }

       public void extraercierre(string campo)
       {
           DatosCaja objcaja = new DatosCaja();
           objcaja.Extcierrecaja(campo);
          
              this.idturno = objcaja.Idturno;
              this.idcierre = objcaja.Idcierre;           
           

       }

      


                
    }
}
