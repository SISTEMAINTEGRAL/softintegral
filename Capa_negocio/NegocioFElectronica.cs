using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Net;
using System.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.Pkcs;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Runtime.InteropServices;
using System.Xml.Linq;

using Capa_negocio.AFIP.WSFE;
using Microsoft.VisualBasic;

namespace Capa_negocio
{
  public class NegocioFElectronica
    {
        private static UInt32 _globalId;
        private  FEAuthRequest authRequest;
        private string serv;

        const int ID_TASA_IVA_NINGUNO = 3;
        const int ID_TASA_IVA_EXENTO = 1;
        const int ID_TASA_IVA_10_50 = 4;
        const int ID_TASA_IVA_21_00 = 5;

        const int TIPOCOMPROBANTE_FACTURA_A = 1;
        const int TIPOCOMPROBANTE_NOTADECREDITO_A = 3;
        const int TIPOCOMPROBANTE_FACTURA_B = 6;
        const int TIPOCOMPROBANTE_NOTADECREDITO_B = 8;
        const int TIPOCOMPROBANTE_FACTURA_C = 11;
        const int TIPOCOMPROBANTE_NOTADECREDITO_C = 13;

        const int CONCEPTO_PRODUCTOSERVICIO = 3;
        const int CONCEPTO_SERVICIO = 2;
        const int CONCEPTO_PRODUCTO = 1;




        public NegocioFElectronica ()
        {
            //string serv, string url, string cert_path, string clave
            //this.serv = serv;
            //this.url = url;
            //this.cert_path = cert_path;
            //this.clave = new SecureString();
            //foreach (char character in clave)
            //    this.clave.AppendChar(character);
            //this.clave.MakeReadOnly();
        }
        public string comprobante_electronico(int tipocomprobante, long nrodoc, double total, double neto21, double civa21,double neto105,double civa105, ref string cae, ref string fechavto, ref string tipofactura, ref string puntoventa)
        {
            string m = "ok";
            try
            {
                LoginClass miloginclase = new LoginClass("wsfe", NegocioConfigEmpresa.urllogin, NegocioConfigEmpresa.certificado, "");
                miloginclase.hacerLogin(miloginclase);
                int doctipoid = 96;
                authRequest = new FEAuthRequest();
                authRequest.Cuit = NegocioConfigEmpresa.emcuit;
                authRequest.Sign = miloginclase.Sing;
                authRequest.Token = miloginclase.Token;
                int cont = 0;

                Service servicio = new Service();
                servicio = getServicio();
                servicio.Url = NegocioConfigEmpresa.urlservicio;
                //servicio.ClientCertificates.Add(certificado);

                //ver conceptoid
                int conceptoid = CONCEPTO_PRODUCTO;
                if (nrodoc.ToString().Length == 11)
                {
                    doctipoid = 80;
                }


                //  Service service = getServicio();
                servicio.ClientCertificates.Add(miloginclase.Certificado);
                FECAERequest req = new FECAERequest();
                FECAECabRequest cab = new FECAECabRequest();
                FECAEDetRequest det = new FECAEDetRequest();

                cab.CantReg = 1;
                cab.PtoVta = Convert.ToInt32 (NegocioConfigEmpresa.puntoventa) ;
                cab.CbteTipo = tipocomprobante;
                req.FeCabReq = cab;

                det.Concepto = conceptoid;
                det.DocTipo = doctipoid;
                det.DocNro = nrodoc;

                // ultimo comprobante autorizado 

                FERecuperaLastCbteResponse lastres = servicio.FECompUltimoAutorizado(authRequest, Convert.ToInt32(NegocioConfigEmpresa.puntoventa), tipocomprobante);
                int last = lastres.CbteNro;
                det.CbteDesde = last + 1;
                det.CbteHasta = last + 1;
                int nrocomprobante = last + 1;

                det.CbteFch = DateTime.Now.ToString("yyyyMMdd");
                if (tipocomprobante == TIPOCOMPROBANTE_FACTURA_A || tipocomprobante == TIPOCOMPROBANTE_FACTURA_B || tipocomprobante == TIPOCOMPROBANTE_NOTADECREDITO_A || tipocomprobante == TIPOCOMPROBANTE_NOTADECREDITO_B)
                {
                    decimal totalneto = decimal.Round ( Convert.ToDecimal(neto21 + neto105),2);
                    decimal totaliva = decimal.Round ( Convert.ToDecimal(civa21 + civa105),2);
                    det.ImpNeto = Convert.ToDouble (totalneto);
                    det.ImpIVA = Convert.ToDouble( totaliva);
                }
                else
                {
                    det.ImpNeto = total;
                    det.ImpIVA = 0;
                }
                
                det.ImpTotal = total;

                det.ImpTotConc = 0.00;
                det.ImpOpEx = 0.00;
                det.ImpTrib = 0.00;

                det.MonId = "PES";
                det.MonCotiz = 1;
                int tipoalicuota = ID_TASA_IVA_NINGUNO;

                AlicIva alicuota = new AlicIva();
                if (tipocomprobante == TIPOCOMPROBANTE_FACTURA_A || tipocomprobante == TIPOCOMPROBANTE_FACTURA_B || tipocomprobante == TIPOCOMPROBANTE_NOTADECREDITO_A || tipocomprobante == TIPOCOMPROBANTE_NOTADECREDITO_B)
                {
                    if (neto21 > 0)
                    {
                        tipoalicuota = ID_TASA_IVA_21_00;
                        alicuota.Id = tipoalicuota;
                        alicuota.BaseImp = neto21;
                        alicuota.Importe = civa21;
                    }
                   
                   
                    if (neto105 > 0 && neto21 > 0)
                    {
                        AlicIva alicuota2 = new AlicIva();
                        tipoalicuota = ID_TASA_IVA_10_50;
                        alicuota2.Id = tipoalicuota;
                        alicuota2.BaseImp = neto105;
                        alicuota2.Importe = civa105;
                        det.Iva = new[] { alicuota, alicuota2 };
                    }
                    else if (neto105 > 0)
                    {
                        tipoalicuota = ID_TASA_IVA_10_50;
                        alicuota.Id = tipoalicuota;
                        alicuota.BaseImp = neto105;
                        alicuota.Importe = civa105;
                        det.Iva = new[] { alicuota };
                    }
                    else
                    {
                        det.Iva = new[] { alicuota };
                    }
                    
                }
                else if (tipocomprobante != TIPOCOMPROBANTE_FACTURA_C)
                {
                    alicuota.Id = tipoalicuota;
                    alicuota.BaseImp = 0;
                    alicuota.Importe = 0;
                    det.Iva = new[] { alicuota};
                }

               
               
                

               

                req.FeDetReq = new[] { det };

                FECAEResponse r = servicio.FECAESolicitar(authRequest, req);
                cae = r.FeDetResp[0].CAE; //string CAE
                string ESTADO = r.FeCabResp.Resultado;
                string resultado = r.FeDetResp[0].Resultado;
                fechavto = r.FeDetResp[0].CAEFchVto;//string vto
                
                puntoventa = NegocioConfigEmpresa.puntoventa;
                tipofactura = tipocomprobante.ToString ("00");
                
                
                

                {
                    if (r.FeDetResp[0].Observaciones is object)
                    {
                        m = "";
                        foreach (var o in r.FeDetResp[0].Observaciones)
                            m += string.Format("Obs: {0} ({1})", o.Msg, o.Code) + Constants.vbCrLf;
                    }
                }
                {
                    if (r.Errors is object)
                    {
                        m = "";
                        foreach (var er in r.Errors)
                            m += string.Format("Er: {0}: {1}", er.Code, er.Msg) + Constants.vbCrLf;
                    }
                }
                {
                    if (r.Events is object)
                    {
                        m = "";
                        foreach (var ev in r.Events)
                            m += string.Format("Ev: {0}: {1}", ev.Code, ev.Msg) + Constants.vbCrLf;
                    }
                }
                if (m == "ok")
                {
                    m = m + nrocomprobante.ToString();
                }
                

            }
            catch (Exception e)
            {
                m = e.Message;
               
            }

            return m;
            // string error = r.error;
            //  string desde = r.FeDetResp[0].CbteDesde;
            //  string hasta = r.FeDetResp[0].CbteHasta;
            // string OBSERVACION = r.FeDetResp[0].Observaciones;
        }
        private Service getServicio()
        {
            var s = new Service();
            s.Url = NegocioConfigEmpresa.urlservicio;
            return s;
        }

        public void hacerLogin()
        {
            
        }
    }
   

   
}
