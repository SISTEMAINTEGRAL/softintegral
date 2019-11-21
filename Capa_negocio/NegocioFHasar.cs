using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_Datos;
using FiscalPrinterLib;
using System.Drawing;



namespace Capa_negocio
{
   public class NegocioFHasar  
    {

        private object numerofactura;

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
        private object montoventas;

        public object Montoventas
        {
            get { return montoventas; }
            set { montoventas = value; }
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

        public object Montoivanoinscripto
        {
            get { return montoivanoinscripto; }
            set { montoivanoinscripto = value; }
        }


        private object montoimpuestointerno;

        public object Montoimpuestointerno
        {
            get { return montoimpuestointerno; }
            set { montoimpuestointerno = value; }
        }

        
       private string msg;


      
       public void Comprobantefiscal(int modelofiscal, int puerto, string razonsocial, string documento, int tiporesponsabilidad, string domicilio, DataTable dtDetalles, double montototal)
       {
           string msg = "ok";
          object varcantidaditemvendido = 0;
          object varmontoventas = 0;
          object varmontopagado = 0;
          object varmontoivanoinscripto = 0;
          object varmontoimpuestointerno = 0;
          object varmontoiva = 0;
          object varnumerofactura = 0;
           try
           {
              
          // HASAR mihasar = new HASAR();
               FiscalPrinterLib.HASAR mihasar = new FiscalPrinterLib.HASAR();
               

           mihasar.ErrorFiscal += new _FiscalEvents_ErrorFiscalEventHandler(mihasar_ErrorFiscal);
           mihasar.ErrorImpresora += new _FiscalEvents_ErrorImpresoraEventHandler(mihasar_ErrorImpresora);
           mihasar.FaltaPapel += new _FiscalEvents_FaltaPapelEventHandler(mihasar_FaltaPapel);
           mihasar.ImpresoraNoResponde += new _FiscalEvents_ImpresoraNoRespondeEventHandler(mihasar_ImpresoraNoResponde);
           mihasar.ProgresoDeteccion += new _FiscalEvents_ProgresoDeteccionEventHandler(mihasar_ProgresoDeteccion);
           
            
           switch (modelofiscal)
           {
               case 1:
               mihasar.Modelo = ModelosDeImpresoras.MODELO_P441;
               break;
               default:
                msg = "no es el modelo indicado";
               break;
           }

           mihasar.Puerto = puerto;
           mihasar.Comenzar();

           //responsable inscripto
           mihasar.DatosCliente(razonsocial, documento, TiposDeDocumento.TIPO_DNI, TiposDeResponsabilidades.CONSUMIDOR_FINAL, domicilio);
           mihasar.AbrirComprobanteFiscal(DocumentosFiscales.TICKET_C);
           //imprimir item
           
           foreach ( DataRow row in dtDetalles.Rows  )
           {
               mihasar.ImprimirItem(row["Producto"].ToString(), Convert.ToDouble(row["cantidad"].ToString()), Convert.ToDouble (row["Importe"].ToString()), 21.0, 0.0); //Descripcion , cantidad, monto, iva, impuesto interno
               
           }

           


           mihasar.Subtotal(false, out varcantidaditemvendido   , out varmontoventas  , out varmontoiva  , out varmontopagado , out varmontoivanoinscripto  , out  varmontoimpuestointerno );
           
          string mensaje = ("Subtotal Comprobante ::: $ " + varmontoventas.ToString());
           
           mihasar.CerrarComprobanteFiscal(1,out varnumerofactura );

           this.cantidaditemvendido = varcantidaditemvendido;
           this.montoventas = varmontoventas;
           this.montoiva = varmontoiva;
           this.montopagado = varmontopagado;
           this.montoivanoinscripto = varmontoivanoinscripto;
           this.montoimpuestointerno = varmontoimpuestointerno;
           this.numerofactura = varnumerofactura;
               
           }
           catch (Exception ex)
           {
               throw;
           }
         
       }

        void mihasar_ProgresoDeteccion(int Puerto, int Velocidad)
       {
           msg = "Evento: ProgesoDetección";
       }

        void mihasar_ImpresoraNoResponde(int CantidadReintentos)
       {
           msg = "Evento: ImpresoraNoResponde";
       }

        void mihasar_FaltaPapel()
       {
           msg = "Evento: FaltaPapel";
       }

        void mihasar_ErrorImpresora(int Flags)
       {
           msg = "Evento: ErrorImpresora";
       }

        void mihasar_ErrorFiscal(int Flags)
       {
           switch (Flags)
           {
               case (int)FiscalPrinterLib.FiscalBits.F_INVALID_COMMAND:
                   msg = "OCX Fiscal HASAR ::: Comando Inválido para el estado fiscal actual";
                   break;
               case (int)FiscalPrinterLib.FiscalBits.F_INVALID_FIELD_DATA:
                   msg = "OCX Fiscal HASAR ::: Campo de datos inválido";
                   break;
               case (int)FiscalPrinterLib.FiscalBits.F_TOTAL_OVERFLOW:
                   msg = "OCX Fiscal HASAR ::: Se excede monto límite comprobante";
                   break;
               case (int)FiscalPrinterLib.FiscalBits.F_UNRECOGNIZED_COMMAND:
                   msg = "OCX Fiscal HASAR ::: Comando desconocido";
                   break;
               default:
                   msg = "OCX Fiscal HASAR ::: Comando rechazado - Evento: ErrorFiscal( )";
                   break;
           };
          
       }

       
    }
}
