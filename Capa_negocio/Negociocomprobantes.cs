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
            this.cae = "";
            this.fechavto = "";
            this.puntoventa = "";
            this.numerotipofactura = "";
       }
        private string cae;
        private string fechavto; 
        private  object numerofactura;
        private string url = "https://wsaahomo.afip.gov.ar/ws/services/LoginCms";
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

        public string Cae
        {
            get
            {
                return cae;
            }

            set
            {
                cae = value;
            }
        }

        public string Fechavto
        {
            get
            {
                return fechavto;
            }

            set
            {
                fechavto = value;
            }
        }

        public string Numerotipofactura
        {
            get
            {
                return numerotipofactura;
            }

            set
            {
                numerotipofactura = value;
            }
        }

        public string Puntoventa
        {
            get
            {
                return puntoventa;
            }

            set
            {
                puntoventa = value;
            }
        }

        private string numerotipofactura;
        private string puntoventa;

        const int TIPOCOMPROBANTE_FACTURA_C = 11;
        const int TIPOCOMPROBANTE_FACTURA_A = 1;
        const int TIPOCOMPROBANTE_FACTURA_B = 6;
        // VER QUE NUMERO ES = const int TIPOCOMPROBANTE_NOTACREDITO_C = 1;
        const int TIPOCOMPROBANTE_NOTACREDITO_A = 3;
        const int TIPOCOMPROBANTE_NOTACREDITO_B = 8;


        NegocioFHasar objhasar = new NegocioFHasar();
        NegocioFElectronica objelectronica;
        
        public string factura(string marca, DataTable dt, double total,int modelofiscal, int puerto,int tiporesponsabilidad,string razonsocial = "CONSUMIDOR FINAL",string cuit = "9999999999", string domicilio = "", string tipoticket = "", string responsableiva = "CF", string tipocomprobante = "FACTURA",string tipofactura = "B",double neto21 = 0.00,double civa21 = 0.00,double neto105 = 0.00,double civa105 = 0.00)
        {
            string msg = "";
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
                    case "elec":
                        {
                            NegocioFElectronica miclase = new Capa_negocio.NegocioFElectronica();
                            int tiponumerofactura = 0;
                            switch (tipofactura)
                            {
                                case "A":
                                    {
                                        tiponumerofactura = TIPOCOMPROBANTE_FACTURA_A;
                                        break;
                                    }
                                case "B":
                                    {
                                        tiponumerofactura = TIPOCOMPROBANTE_FACTURA_B;
                                        break;
                                    }
                                case "C":
                                    {
                                        tiponumerofactura = TIPOCOMPROBANTE_FACTURA_C;
                                        break;
                                    }
                                   
                            }
                            
                         msg =   miclase.comprobante_electronico(tiponumerofactura,Convert.ToInt64 (cuit),total,neto21,civa21,neto105,civa105, ref cae, ref fechavto, ref numerotipofactura, ref puntoventa );
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
