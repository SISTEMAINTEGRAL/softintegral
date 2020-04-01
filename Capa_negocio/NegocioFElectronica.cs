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
        public string comprobante_electronico(int tipocomprobante, long nrodoc, double total, double neto, double civa, ref string cae, ref string fechavto, ref string tipofactura, ref string puntoventa)
        {

            try
            {
                LoginClass miloginclase = new LoginClass("wsfe", "https://wsaahomo.afip.gov.ar/ws/services/LoginCms", "C:\\Backup\\Sistema de ventas\\softintegral\\SistemaVentas\\bin\\Debug\\Certificado\\certificado.pfx", "Cristian3043");
                miloginclase.hacerLogin(miloginclase);
                int doctipoid = 96;
                authRequest = new AFIP.WSFE.FEAuthRequest();
                authRequest.Cuit = 20314729154;
                authRequest.Sign = miloginclase.Sing;
                authRequest.Token = miloginclase.Token;

                Service servicio = new AFIP.WSFE.Service();
                servicio = getServicio();
                servicio.Url = "https://wswhomo.afip.gov.ar/wsfev1/service.asmx?WSDL";
                //servicio.ClientCertificates.Add(certificado);

                //ver conceptoid
                int conceptoid = 1;
                if (nrodoc.ToString().Length == 11)
                {
                    doctipoid = 80;
                }


                //  Service service = getServicio();
                servicio.ClientCertificates.Add(miloginclase.Certificado);
                FECAERequest req = new AFIP.WSFE.FECAERequest();
                FECAECabRequest cab = new AFIP.WSFE.FECAECabRequest();
                FECAEDetRequest det = new AFIP.WSFE.FECAEDetRequest();

                cab.CantReg = 1;
                cab.PtoVta = Convert.ToInt32 (NegocioConfigEmpresa.puntoventa) ;
                cab.CbteTipo = tipocomprobante;
                req.FeCabReq = cab;

                det.Concepto = conceptoid;
                det.DocTipo = doctipoid;
                det.DocNro = nrodoc;

                // ultimo comprobante autorizado 

                FERecuperaLastCbteResponse lastres = servicio.FECompUltimoAutorizado(authRequest, 3, tipocomprobante);
                int last = lastres.CbteNro;
                det.CbteDesde = last + 1;
                det.CbteHasta = last + 1;
                int nrocomprobante = last + 1;

                det.CbteFch = DateTime.Now.ToString("yyyyMMdd");
                if (tipocomprobante == 1 || tipocomprobante == 6)
                {
                    det.ImpNeto = neto;
                    det.ImpIVA = civa;
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
                int tipoalicuota = 3;
                if (tipocomprobante == 1 || tipocomprobante == 6)
                {
                    tipoalicuota = 5;
                }

                AlicIva alicuota = new AlicIva();
                alicuota.Id = tipoalicuota;
                if (tipocomprobante == 1 || tipocomprobante == 6)
                {
                    alicuota.BaseImp = neto;
                    alicuota.Importe = civa;
                    det.Iva = new[] { alicuota };
                }
                else
                {
                    alicuota.BaseImp = 0;
                    alicuota.Importe = 0;
                }
                

               

                req.FeDetReq = new[] { det };

                FECAEResponse r = servicio.FECAESolicitar(authRequest, req);
                cae = r.FeDetResp[0].CAE; //string CAE
                string ESTADO = r.FeCabResp.Resultado;
                string resultado = r.FeDetResp[0].Resultado;
                fechavto = r.FeDetResp[0].CAEFchVto;//string vto
                
                puntoventa = NegocioConfigEmpresa.puntoventa;
                tipofactura = tipocomprobante.ToString ("00");
                
                
                string m = "ok";

                {
                    if (r.FeDetResp[0].Observaciones is object)
                    {
                        foreach (var o in r.FeDetResp[0].Observaciones)
                            m += string.Format("Obs: {0} ({1})", o.Msg, o.Code) + Constants.vbCrLf;
                    }
                }
                {
                    if (r.Errors is object)
                    {
                        foreach (var er in r.Errors)
                            m += string.Format("Er: {0}: {1}", er.Code, er.Msg) + Constants.vbCrLf;
                    }
                }
                {
                    if (r.Events is object)
                    {
                        foreach (var ev in r.Events)
                            m += string.Format("Ev: {0}: {1}", ev.Code, ev.Msg) + Constants.vbCrLf;
                    }
                }
                if (m == "ok")
                {
                    m = m + nrocomprobante.ToString();
                }
                return m;

            }
            catch (Exception)
            {

                throw;
            }
          

            // string error = r.error;
            //  string desde = r.FeDetResp[0].CbteDesde;
            //  string hasta = r.FeDetResp[0].CbteHasta;
            // string OBSERVACION = r.FeDetResp[0].Observaciones;
        }
        private Service getServicio()
        {
            var s = new Service();
            s.Url = "https://wswhomo.afip.gov.ar/wsfev1/service.asmx?WSDL";
            return s;
        }

        public void hacerLogin()
        {
            
        }
    }
   

   
}
