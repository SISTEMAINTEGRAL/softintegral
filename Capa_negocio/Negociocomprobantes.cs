using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Capa_negocio
{
   public class Negociocomprobantes
    {
       public  Negociocomprobantes()
       {
           this.numerofactura = 0;
           this.cantidaditemvendido = 0;
           this.montoventa = 0;
           this.montoiva = 0;
           this.montopagado = 0;
           this.montoivanoinscripto = 0;
           this.montoimpuestosinternos = 0;
       }

        private  object numerofactura;

        public object Numerofactura
        {
            get { return numerofactura; }
            set { numerofactura = value; }
        }
        private object cantidaditemvendido;

        public object Cantidaditemvendido
        {
            get { return cantidaditemvendido; }
            set { cantidaditemvendido = value; }
        }
        private object montoventa;

        public object Montoventa
        {
            get { return montoventa; }
            set { montoventa = value; }
        }


        private object montoiva;

        public object Montoiva
        {
            get { return montoiva; }
            set { montoiva = value; }
        }


        private object montopagado;

        public object Montopagado
        {
            get { return montopagado; }
            set { montopagado = value; }
        }

        
        private object montoivanoinscripto;

        public object MontoIVANoInscripto
        {
            get { return MontoIVANoInscripto; }
            set { MontoIVANoInscripto = value; }
        }
        private object montoimpuestosinternos;

        public object Montoimpuestosinternos
        {
            get { return montoimpuestosinternos; }
            set { montoimpuestosinternos = value; }
        }

       
       

        NegocioFHasar objhasar = new NegocioFHasar();
        
        
        public string factura(string marca, DataTable dt, double total,int modelofiscal, int puerto,int tiporesponsabilidad,string razonsocial = "CONSUMIDOR FINAL",string cuit = "9999999999", string domicilio = "", string tipoticket = "", string responsableiva = "CF", string tipocomprobante = "FACTURA")
        {
            string msg = "ok";
            try
            {
                switch (marca)
                {
                    case "hasar":
                        {

                            objhasar.Comprobantefiscal(modelofiscal, puerto, razonsocial, cuit, 1, "", dt, total);



                            break;
                        }
                    case "epson":
                        {

                            NegocioFEpson objepson = new NegocioFEpson(razonsocial, cuit, domicilio);
                            msg =  objepson.comprobantefiscal(tipoticket,responsableiva,dt,tipocomprobante);
                            break;
                        }
                    case "electronica":
                        {
                            break;
                        }
                }

                return msg;
            
            }
            catch
            { 
                throw; 
            }
           
        }

        public string imprimirxz(string xz, string marcafiscal)
        {
            string msg = "";
            if (marcafiscal == "")
            {
                msg = "La marca de la fiscal no se especifico correctamente";
            }
            switch (marcafiscal)
            {
                case "hasar":
                    {
                         break;
                    }
                case "epson":
                    {
                        NegocioFEpson objepson = new NegocioFEpson();
                        msg = objepson.imprimirxz(xz);
                        break;
                    }
                case "electronica":
                    {
                        break;
                    }
            }

            return msg;
            
        }
        public string Descargarperiodo(string marca, string path, string desde, string hasta)
        {
            NegocioFEpson objepson = new NegocioFEpson();
            string msg = "";

            if (marca == "hasar")
            {
                
            }

            if (marca == "epson")
            {
               msg = objepson.DescargarElPeriodoPendiente(path, desde, hasta);
            }

            return msg;
        
        }

        public void Cancelardocumento()
        {
            NegocioFEpson obj = new NegocioFEpson();
            obj.cancelarcomprobante();
        
        }


    }
}
