using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel;
using System.IO;
using System.Configuration;
using System.Globalization;

namespace Capa_negocio
{
    class NegocioFEpson
    {
        private int retorno = 0;
        private int tipocontribuyente;
        const int ERROR_NINGUNO = 0;

        // ConfigurarVelocidad()
        [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int ConfigurarVelocidad(int velocidad);

        // ConfigurarPuerto()
        [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int ConfigurarPuerto(string puerto);

        // Conectar()
        [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int Conectar();

        // Desconectar()
        [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int Desconectar();

        // Consultar()
        [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int ConsultarVersionDll(StringBuilder descripcion, int descripcion_largo_maximo, ref int mayor, ref int menor);

        // ImprimirCierreX() 
        [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int ImprimirCierreX();

        // ImprimirCierreZ() 
        [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                               CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int ImprimirCierreZ();

        [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int AbrirComprobante(int id_tipo_documento);

        [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]

        public static extern int ConsultarDescripcionDeError (int nro_error, StringBuilder respuesta, int respuesta_largo_maximo);

        [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]

        public static extern int CargarDatosCliente(string nombre_o_razon_social1, string nombre_o_razon_social2, string domicilio1, string domicilio2, string domicilio3, int id_tipo_documento, string numero_documento, int id_responsabilidad_iva);
        [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int ImprimirItem ( int id_modificador , string descripcion , string cantidad, string precio ,int id_tasa_iva ,int ii_id ,string ii_valor, int id_codigo , string  codigo ,string codigo_unidad_matrix , int codigo_unidad_medida );
        [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int  ImprimirSubtotal() ;
        [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int ConsultarNumeroComprobanteActual(StringBuilder respuesta, int respuesta_largo_maximo);
        [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int CerrarComprobante();
        [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        
        public static extern int DescargarPeriodoPendiente(string path);
        [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]

        public static extern int ConfimarDescarga(string hasta);
        [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]

        public static extern int Descargar(String desde, String hasta, String path);
        [System.Runtime.InteropServices.DllImport("EpsonFiscalInterface.dll", CharSet = System.Runtime.InteropServices.CharSet.Ansi,
                                                                                CallingConvention = System.Runtime.InteropServices.CallingConvention.StdCall)]
        public static extern int Cancelar();
        
        
       // Private Declare Function Descargar Lib "EpsonFiscalInterface.dll" (ByVal desde As String, ByVal hasta As String, ByVal path As String) As Integer

        //Private Declare Function DescargarPeriodoPendiente Lib "EpsonFiscalInterface.dll" (ByVal path As String) As Integer
        //Private Declare Function ConfimarDescarga Lib "EpsonFiscalInterface.dll" (ByVal hasta As String) As Integer
        
        
        const int ID_TIPO_COMPROBANTE_TIQUET = 1;                            // "83"  Tique
        const int ID_TIPO_COMPROBANTE_TIQUE_FACTURA = 2;//                     ' "81"  Tique Factura A, "82" Tique Factura B, "111" Tique Factura C, "118" Tique Factura M
        const int ID_TIPO_COMPROBANTE_TIQUE_NOTA_DE_CREDITO = 3; //            ' "110" Tique Nota de Credito, "112" Tique Nota de Credito A, "113" Tique Nota de Credito B, "114" Tique Nota de Credito C, "119" Tique Nota de Credito M
        const int  ID_TIPO_COMPROBANTE_TIQUE_NOTA_DE_DEBITO = 4;//              ' "115" Tique Nota de Debito A, "116" Tique Nota de Debito B, "117" Tique Nota de Debito C, "120" Tique Nota de Debito M
        const int ID_TIPO_COMPROBANTE_DNFH_GENERIC = 21;//                     ' "910" DNFH Documento Generico 
        const int  ID_TIPO_COMPROBANTE_DNFH_INTERNAL_USE = 22;//                ' "950" DNFH Documento de uso interno 
        const int  ID_TIPO_COMPROBANTE_DNFH_VALORIZADO_REMITO_R = 51;//         ' "91"  DNFH Valorizado Remito R 
        const int  ID_TIPO_COMPROBANTE_DNFH_VALORIZADO_REMITO_X = 52;//         ' "901" DNFH Valorizado Remito X 
        const int ID_TIPO_COMPROBANTE_DNFH_VALORIZADO_RECIBO_X = 53;//         ' "902" DNFH Valorizado Recibo X 
        const int ID_TIPO_COMPROBANTE_DNFH_VALORIZADO_PRESUPUESTO_X = 54;//    ' "903" DNFH Valorizado Presupuesto X 
        const int  ID_TIPO_COMPROBANTE_DNFH_VALORIZADO_DONACION = 55;//         ' "907" DNFH Valorizado Comprobante Donacion 

        const int ID_TIPO_DOCUMENTO_NINGUNO = 0;
        const int ID_TIPO_DOCUMENTO_DNI = 1;
        const int  ID_TIPO_DOCUMENTO_CUIL = 2;
        const int ID_TIPO_DOCUMENTO_CUIT = 3;
        const int  ID_TIPO_DOCUMENTO_CEDULA_IDENTIDAD = 4;
        const int ID_TIPO_DOCUMENTO_PASAPORTE = 5;
        const int ID_TIPO_DOCUMENTO_LIB_CIVICA = 6;
        const int ID_TIPO_DOCUMENTO_LIB_ENROLAMIENTO = 7;

        const int ID_RESPONSABILIDAD_IVA_NINGUNO = 0;
        const int ID_RESPONSABILIDAD_IVA_RESPONSABLE_INSCRIPTO = 1;
        const int ID_RESPONSABILIDAD_IVA_NO_RESPONSABLE = 3;
        const int ID_RESPONSABILIDAD_IVA_MONOTRIBUTISTA = 4;
        const int ID_RESPONSABILIDAD_IVA_CONSUMIDOR_FINAL = 5;
        const int ID_RESPONSABILIDAD_IVA_EXENTO = 6;
        const int ID_RESPONSABILIDAD_IVA_NO_CATEGORIZADO = 7;
        const int ID_RESPONSABILIDAD_IVA_MONOTRIBUTISTA_SOCIAL = 8;
        const int ID_RESPONSABILIDAD_IVA_CONTRIBUYENTE_EVENTUAL = 9;
        const int ID_RESPONSABILIDAD_IVA_CONTRIBUYENTE_EVENTUAL_SOCIAL = 10;
        const int ID_RESPONSABILIDAD_IVA_MONOTRIBUTO_INDEPENDIENTE_PROMOVIDO = 11;

        const int ID_TASA_IVA_NINGUNO = 0;
        const int ID_TASA_IVA_EXENTO = 1;
        const int ID_TASA_IVA_10_50 = 4;
        const int ID_TASA_IVA_21_00 = 5;

        const int ID_IMPUESTO_NINGUNO = 0;
         const int ID_IMPUESTO_INTERNO_FIJO = 1;
        const int ID_IMPUESTO_INTERNO_PORCENTUAL = 2;

        const int ID_CODIGO_INTERNO = 1;
        const int ID_CODIGO_MATRIX = 2;

        const int MAX_DESCRIPTION = 1000;
        const int MAX_ANSWER = 200;

        
    const int AFIP_CODIGO_UNIDAD_MEDIDA_SIN_DESCRIPCION = 0;
    const int AFIP_CODIGO_UNIDAD_MEDIDA_KILOGRAMO = 1;
    const int AFIP_CODIGO_UNIDAD_MEDIDA_METROS = 2;
    const int AFIP_CODIGO_UNIDAD_MEDIDA_METRO_CUADRADO = 3;
    const int AFIP_CODIGO_UNIDAD_MEDIDA_METRO_CUBICO = 4;
    const int AFIP_CODIGO_UNIDAD_MEDIDA_LITROS = 5;
    const int AFIP_CODIGO_UNIDAD_MEDIDA_UNIDAD = 7;
    const int AFIP_CODIGO_UNIDAD_MEDIDA_PAR = 8;
    const int AFIP_CODIGO_UNIDAD_MEDIDA_DOCENA = 9;
    const int AFIP_CODIGO_UNIDAD_MEDIDA_QUILATE = 10;
    const int AFIP_CODIGO_UNIDAD_MEDIDA_MILLAR = 11;
    const int AFIP_CODIGO_UNIDAD_MEDIDA_MEGA_U_INTER_ACT_ANTIB = 12;
    const int AFIP_CODIGO_UNIDAD_MEDIDA_UNIDAD_INT_ACT_INMUNG = 13;
    const int AFIP_CODIGO_UNIDAD_MEDIDA_GRAMO = 14;
    const int AFIP_CODIGO_UNIDAD_MEDIDA_MILIMETRO = 15;
    const int  AFIP_CODIGO_UNIDAD_MEDIDA_MILIMETRO_CUBICO = 16;
    const int  AFIP_CODIGO_UNIDAD_MEDIDA_KILOMETRO = 17;
    const int  AFIP_CODIGO_UNIDAD_MEDIDA_HECTOLITRO = 18;
    const int  AFIP_CODIGO_UNIDAD_MEDIDA_MEGA_UNIDAD_INT_ACT_INMUNG = 19;
    const int  AFIP_CODIGO_UNIDAD_MEDIDA_CENTIMETRO = 20;
    const int AFIP_CODIGO_UNIDAD_MEDIDA_KILOGRAMO_ACTIVO = 21;
    const int  AFIP_CODIGO_UNIDAD_MEDIDA_GRAMO_ACTIVO = 22;
    const int  AFIP_CODIGO_UNIDAD_MEDIDA_GRAMO_BASE = 23;
    const int  AFIP_CODIGO_UNIDAD_MEDIDA_UIACTHOR = 24;
    const int  AFIP_CODIGO_UNIDAD_MEDIDA_JGO_PQT_MAZO_NAIPES = 25;
    const int  AFIP_CODIGO_UNIDAD_MEDIDA_MUIACTHOR = 26;
    const int  AFIP_CODIGO_UNIDAD_MEDIDA_CENTIMETRO_CUBICO = 27;
    const int  AFIP_CODIGO_UNIDAD_MEDIDA_UIACTANT = 28;
    const int  AFIP_CODIGO_UNIDAD_MEDIDA_TONELADA = 29;
    const int  AFIP_CODIGO_UNIDAD_MEDIDA_DECAMETRO_CUBICO = 30;
    const int  AFIP_CODIGO_UNIDAD_MEDIDA_HECTOMETRO_CUBICO = 31;
    const int  AFIP_CODIGO_UNIDAD_MEDIDA_KILOMETRO_CUBICO = 32;
    const int  AFIP_CODIGO_UNIDAD_MEDIDA_MICROGRAMO = 33;
    const int  AFIP_CODIGO_UNIDAD_MEDIDA_NANOGRAMO = 34;
    const int  AFIP_CODIGO_UNIDAD_MEDIDA_PICOGRAMO = 35;
    const int  AFIP_CODIGO_UNIDAD_MEDIDA_MUIACTANT = 36;
    const int  AFIP_CODIGO_UNIDAD_MEDIDA_UIACTIG = 37;
    const int  AFIP_CODIGO_UNIDAD_MEDIDA_MILIGRAMO = 41;
    const int  AFIP_CODIGO_UNIDAD_MEDIDA_MILILITRO = 47;
    const int  AFIP_CODIGO_UNIDAD_MEDIDA_CURIE = 48;
    const int  AFIP_CODIGO_UNIDAD_MEDIDA_MILICURIE = 49;
    const int  AFIP_CODIGO_UNIDAD_MEDIDA_MICROCURIE = 50;
    const int  AFIP_CODIGO_UNIDAD_MEDIDA_U_INTER_ACT_HORMONAL = 51;
    const int  AFIP_CODIGO_UNIDAD_MEDIDA_MEGA_U_INTER_ACT_HORMONAL = 52;
    const int  AFIP_CODIGO_UNIDAD_MEDIDA_KILOGRAMO_BASE = 53;
    const int  AFIP_CODIGO_UNIDAD_MEDIDA_GRUESA = 54;
    const int  AFIP_CODIGO_UNIDAD_MEDIDA_MUIACTIG = 55;
    const int  AFIP_CODIGO_UNIDAD_MEDIDA_KILOGRAMO_BRUTO = 61;
    const int  AFIP_CODIGO_UNIDAD_MEDIDA_PACK = 62;
    const int  AFIP_CODIGO_UNIDAD_MEDIDA_HORMA = 63;

        private string razonsocial;

        public string Razonsocial
        {
          get { return razonsocial; }
          set { razonsocial = value; }
        }
        private string cuit;

        public string Cuit
        {
            get { return cuit; }
            set { cuit = value; }
        }
                private string domicilio;

        public string Domicilio
        {
          get { return domicilio; }
          set { domicilio = value; }
        }

        public NegocioFEpson ()
        {
         
        }

        public NegocioFEpson (string varrazonsocial, string varcuit, string vardomicilio)
        {
            razonsocial = varrazonsocial;
            cuit = varcuit;
            domicilio = vardomicilio ;
        }

        public string imprimirxz(string xz)
        {
            try
            {
                int error;
                string msg = "ok";
                /* connect */
                ConfigurarVelocidad(9600);
                ConfigurarPuerto(NegocioConfigEmpresa.puertofiscal.ToString());
                error = Conectar();
                msg = error == 0 ? "ok"  : "Connect: " + error.ToString();
                if (error == 0)
                {
                    if (xz == "X")
                    {
                        /* print x */
                        error = ImprimirCierreX();
                        msg = error == 0 ? "ok" : "Closure Cashier: " + error.ToString();

                    }

                    if (xz == "Z")
                    {
                        /* print z */
                        error = ImprimirCierreZ();
                        msg = error == 0 ? "ok" : "Closure Day: " + error.ToString();

                    }
                    /* clsoe port */
                    error = Desconectar();
                    msg = error == 0 ? "ok" : "Disconect: " + error.ToString();
                }
                


               

                return msg;
            }
            catch (Exception)
            {
                
                throw;
            }
           
        }

        public void cancelarcomprobante()
        {
            ConfigurarVelocidad(9600);
            ConfigurarPuerto(NegocioConfigEmpresa.puertofiscal.ToString());
            retorno = Conectar();

          retorno =  Cancelar();
          Desconectar();
        }

        public string comprobantefiscal(string tipoticket,string responsableiva, DataTable dtDetalle, string tipocomprobate = "FACTURA" )
        {
           // int tipocomprobante = 0;
            ConfigurarVelocidad(9600);
            ConfigurarPuerto(NegocioConfigEmpresa.puertofiscal.ToString () );
            string msg = "ok";
            string comprobanteactual;
            int  unidadmedida = 0;
            decimal  cantidad = 0;
            retorno = Conectar();

            if (retorno != ERROR_NINGUNO )
            {
                msg = mostrarmensaje(retorno, "Problema de conexion");
                return msg;
            }

            StringBuilder respuesta = new StringBuilder(MAX_ANSWER );

            if (responsableiva == "RI")
            {
                tipocontribuyente = ID_RESPONSABILIDAD_IVA_RESPONSABLE_INSCRIPTO;
            }

            if (responsableiva == "MN")
            {
                tipocontribuyente = ID_RESPONSABILIDAD_IVA_MONOTRIBUTISTA;
            }

            if (responsableiva == "EX")
            {
                tipocontribuyente = ID_RESPONSABILIDAD_IVA_EXENTO;
            }

            if (responsableiva == "CF")
            {
                tipocontribuyente = ID_RESPONSABILIDAD_IVA_CONSUMIDOR_FINAL;
            }

            
            
            msg = abrirticketfactura(tipocomprobate);
            if (msg == "ok")
            {
                NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
                foreach (DataRow row in dtDetalle.Rows)
                {
                    if (Convert.ToInt16 ( row["Pesable"].ToString ()) == 1)
                    {
                        unidadmedida = AFIP_CODIGO_UNIDAD_MEDIDA_LITROS;
                    }
                    else
                    {
                        unidadmedida = AFIP_CODIGO_UNIDAD_MEDIDA_UNIDAD;
                    }
                    cantidad = Convert.ToDecimal ( row["cantidad"].ToString ());
                    ImprimirItem(200, row["Producto"].ToString(), cantidad.ToString ("0.00",nfi), row["Precioneto"].ToString(), responsableiva == "EX" ? ID_TASA_IVA_EXENTO : ID_TASA_IVA_21_00, ID_IMPUESTO_NINGUNO, "", ID_CODIGO_INTERNO, "1234567890", "", unidadmedida);
                }

               
                obtenersubtotal();
                retorno = ConsultarNumeroComprobanteActual(respuesta, MAX_ANSWER);
                comprobanteactual = respuesta.ToString();
                msg = msg + completarceros(comprobanteactual);
                
                retorno = CerrarComprobante();
                retorno = Desconectar();
            }
            else
            {
                Cancelar();
                Desconectar();
            }
            return msg;
           
        }
        private string completarceros(string comprobante)
        {
            if (comprobante.Length < 8)
            {

                comprobante = comprobante.PadLeft(8, '0');

            }
            return comprobante;

        }

        private string abrirdocumento(int id)
        {
            string msg = "ok";

            switch (id)
            {
                case 83: 
                   msg = abrirtique();
                    break;
                case 81:
                    msg = abrirticketfactura();
                    break;
                case 82:
                    msg = abrirticketfactura();
                    break;
                case 111:
                    msg = abrirticketfactura();
                    break;
                default:
                    break;
            }
            return msg;
        }

        private string abrirtique()
        {
            string msg;
            retorno = AbrirComprobante(ID_TIPO_COMPROBANTE_TIQUET);
            msg = mostrarmensaje(retorno,"tiquet abierto");
            return msg;
        }

        private string abrirticketfactura (string tipodocumento = "FACTURA")
        {
                string msg = "ok";
            //cargar datos del cliente
            retorno = CargarDatosCliente(razonsocial, "",domicilio, "", "", ID_TIPO_DOCUMENTO_CUIT, cuit, tipocontribuyente);
            if (retorno != ERROR_NINGUNO )
            {
               msg = mostrarmensaje(retorno, "Problema en la carga de cliente");
            }
            //apertura del comprobante
            if (msg == "ok")
            {
                if (tipodocumento == "FACTURA")
                {
                    retorno = AbrirComprobante(ID_TIPO_COMPROBANTE_TIQUE_FACTURA);
                }
                else
                {
                    retorno = AbrirComprobante(ID_TIPO_COMPROBANTE_TIQUE_NOTA_DE_CREDITO);
                }

                if (retorno != ERROR_NINGUNO)
                {
                  msg =  mostrarmensaje(retorno, "Tiquet factura abierto");
                }
                
            }

            return msg;
        }

        public string DescargarElPeriodoPendiente(string path, string desde, string hasta)
        { 
             //crear directorio
            string msg = "ok";
            string fecha = "";
            fecha = DateTime.Today.ToString ("ddMMyy");
            ConfigurarVelocidad(9600);
            ConfigurarPuerto(NegocioConfigEmpresa.puertofiscal.ToString());
            retorno = Conectar();
        //My.Computer.FileSystem.CreateDirectory("c:\\descargas")

        ////ejecutar funcion
            retorno = Descargar(desde,hasta,path);

            if (retorno == ERROR_NINGUNO)
            {
                retorno = ConfimarDescarga(fecha);
            }

            msg = mostrarmensaje(retorno, "Problema al descargar periodo");
            retorno = Desconectar();
            

        //MostrarMensaje(retorno, "Descarga período pendiente realizadas. Ver carpeta c:\descargas")
            
            return  msg ;
        }

        //private string abrirticketfactura_B()
        //{
        //   string  msg = "ok";

        //   retorno = CargarDatosCliente(razonsocial, "", domicilio, "", "", ID_TIPO_DOCUMENTO_CUIT, cuit, tipocontribuyente );
           
        //    if (retorno != ERROR_NINGUNO )
        //   {
        //       msg = mostrarmensaje(retorno, "problema al cargar el cliente");
        //       return msg;   

        //   }
        //   retorno = AbrirComprobante(ID_TIPO_COMPROBANTE_TIQUE_FACTURA);
        //   if (retorno != ERROR_NINGUNO )
        //   {
        //      msg = mostrarmensaje(retorno, "tiquet factura abierto");    
        //   }
        //   return msg;

        //}

        //private string abrirticketfactura_C()
        //{
        //    string msg = "ok";
        //    retorno = CargarDatosCliente(razonsocial, "", domicilio, "", "", ID_TIPO_DOCUMENTO_CUIT, cuit, ID_RESPONSABILIDAD_IVA_MONOTRIBUTISTA);
        //    if (retorno != ERROR_NINGUNO )
        //    {
        //       msg = mostrarmensaje(retorno, "problema al cargar datos del cliente");

        //    }
        //    retorno = AbrirComprobante(ID_TIPO_COMPROBANTE_TIQUE_FACTURA);
        //    if (retorno != ERROR_NINGUNO)
        //    {
        //        msg = mostrarmensaje(retorno, "problema al abrir el ticket");

        //    }
        //    return msg;

        //}

        private string mostrarmensaje(int retorno, string mensaje)
        {
            StringBuilder respuesta = new StringBuilder();
            string hexval = "";
            string msg = "";
            if (retorno == ERROR_NINGUNO)
            {
                msg = "ok";


            }
            else
            {
              ConsultarDescripcionDeError(retorno, respuesta, MAX_DESCRIPTION);
                hexval = string.Format("{0:X4}", retorno);
                msg = mensaje + "Error: 0x" + hexval + "Descripcion : " + respuesta.ToString();
            }

            return msg;

        }

        private string obtenersubtotal()
        {
            string msg = "ok";
            retorno = ImprimirSubtotal();

            if (retorno != ERROR_NINGUNO )
            {
              msg =  mostrarmensaje (retorno, "problema en el subtotal");
            }
            return msg;
        }

        

    }
}
