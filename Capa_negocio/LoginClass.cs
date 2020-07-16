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
using System.Windows.Forms;
using Capa_Datos;
using System.Data;
using System.Data.SqlClient;
using Capa_negocio.AFIP.WSAA;
namespace Capa_negocio
{
    class LoginClass
    {

        private static UInt32 _globalId;
        private string serv;

        public string Serv
        {
            get
            {
                return serv;
            }

            set
            {
                serv = value;
            }
        }

        public string Url
        {
            get
            {
                return url;
            }

            set
            {
                url = value;
            }
        }

        public DateTime Generationtime
        {
            get
            {
                return generationtime;
            }

            set
            {
                generationtime = value;
            }
        }

        public DateTime Expirationtime
        {
            get
            {
                return expirationtime;
            }

            set
            {
                expirationtime = value;
            }
        }

        public bool Logeado
        {
            get
            {
                return !(Token == "");
            }


        }

        public string Token
        {
            get
            {
                return token;
            }


        }

        public string Sing
        {
            get
            {
                return sing;
            }


        }

        public X509Certificate2 Certificado
        {
            get
            {
                return certificado;
            }

            set
            {
                certificado = value;
            }
        }

        private string url;
        private string cert_path;
        private SecureString clave;

        private XmlDocument XmlLoginTicketRequest;
        private XmlDocument XmlLoginTicketResponse;
        private UInt32 uniqueId;
        private DateTime generationtime;
        private DateTime expirationtime;

        private Boolean logeado;

        private X509Certificate2 certificado;


        private XDocument xdocrequest;
        private XDocument xdocresponse;
        private string token;
        private string sing;


        public LoginClass(string serv, string url, string cert_path, string clave)
        {
            this.serv = serv;
            this.url = url;
            this.cert_path = cert_path;
            this.clave = new SecureString();
            foreach (char character in clave)
                this.clave.AppendChar(character);
            this.clave.MakeReadOnly();
        }

        public void hacerLogin(LoginClass miclaselogin)
        {
            string cmsFirmadoBase64;
            string loginTicketResponse;
            XmlNode uniqueIdNode;
            XmlNode generationTimeNode;
            XmlNode ExpirationTimeNode;
            XmlNode ServiceNode;
            try
            {
                _globalId += 1;

                // Preparo el XML Request
                XmlLoginTicketRequest = new XmlDocument();
                XMLLOADER.loadTemplate(XmlLoginTicketRequest, "LoginTemplate");
                uniqueIdNode = XmlLoginTicketRequest.SelectSingleNode("//uniqueId");
                generationTimeNode = XmlLoginTicketRequest.SelectSingleNode("//generationTime");
                ExpirationTimeNode = XmlLoginTicketRequest.SelectSingleNode("//expirationTime");
                ServiceNode = XmlLoginTicketRequest.SelectSingleNode("//service");
                generationTimeNode.InnerText = DateTime.Now.AddMinutes(-10).ToString("s");
                ExpirationTimeNode.InnerText = DateTime.Now.AddMinutes(+10).ToString("s");
                uniqueIdNode.InnerText = Convert.ToString(_globalId);
                ServiceNode.InnerText = serv;
                
                // Obtenemos el Cert
                Certificado = new X509Certificate2();
                if (clave.IsReadOnly())
                {
                    Certificado.Import(File.ReadAllBytes(cert_path), clave, X509KeyStorageFlags.PersistKeySet);
                }
                else
                {
                    Certificado.Import(File.ReadAllBytes(cert_path));
                }

                var msgBytes = Encoding.UTF8.GetBytes(XmlLoginTicketRequest.OuterXml);

                // Firmamos
                var infoContenido = new ContentInfo(msgBytes);
                var cmsFirmado = new SignedCms(infoContenido);
                var cmsFirmante = new CmsSigner(Certificado);
                cmsFirmante.IncludeOption = X509IncludeOption.EndCertOnly;
                cmsFirmado.ComputeSignature(cmsFirmante);
                cmsFirmadoBase64 = Convert.ToBase64String(cmsFirmado.Encode());

                // Hago el login
                
                DatosConfigEmpresa miclaseticket = new DatosConfigEmpresa();
               

               
                var servicio = new LoginCMSService();
                string url = NegocioConfigEmpresa.urllogin;
                servicio.Url = url;
                
                if (miclaseticket.verificartiketfiscal() == false)
                {

                    loginTicketResponse = servicio.loginCms(cmsFirmadoBase64);
                    // Analizamos la respuesta
                    XmlLoginTicketResponse = new XmlDocument();
                    XmlLoginTicketResponse.LoadXml(loginTicketResponse);
                    token = XmlLoginTicketResponse.SelectSingleNode("//token").InnerText;
                    sing = XmlLoginTicketResponse.SelectSingleNode("//sign").InnerText;
                    var exStr = XmlLoginTicketResponse.SelectSingleNode("//expirationTime").InnerText;
                    var genStr = XmlLoginTicketResponse.SelectSingleNode("//generationTime").InnerText;
                    expirationtime = DateTime.Parse(exStr);
                    generationtime = DateTime.Parse(genStr);
                    xdocrequest = XDocument.Parse(XmlLoginTicketRequest.OuterXml);
                    xdocresponse = XDocument.Parse(XmlLoginTicketResponse.OuterXml);
                    miclaseticket.Token = token;
                    miclaseticket.Sign = sing;
                    miclaseticket.Fecha = expirationtime;
                    miclaseticket.agregarticket(miclaseticket);
                    
                }
                else
                {
                    token = miclaseticket.Token;
                    sing = miclaseticket.Sign;
                    expirationtime = miclaseticket.Fecha;
                }




              //  MessageBox.Show("Exito");
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public class XMLLOADER
        {
            public static void load(XmlDocument doc, string file)
            {
                doc.Load(Path.GetFullPath(System.Windows.Forms.Application.StartupPath + @"\" + file + ".xml"));

            }
            public static void loadTemplate(XmlDocument doc, string file)
            {
                load(doc, @"Template\" + file);
            }

        }
    }
}
