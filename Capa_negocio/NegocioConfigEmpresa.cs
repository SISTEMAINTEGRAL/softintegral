using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data;
namespace Capa_negocio
{
    public static class NegocioConfigEmpresa
    {
        //EQUIPO

        public static string equipo;
        public static int idequipo;
        public static string usuarioconectado;
        public static string turno;
        public static int idusuario;
        public static int codsucursal;
        public static DateTime fecha;
        public static string ruta;
        public static string ip;
        public static int puertofiscal;
        public static int modelofiscal;
        public static int idempresa;
        public static string marcafiscal;
        public static string nombreusuario;
        public static string impticket;
        public static string impreporte;
        public static string puntoventa;
        public static string balanzapuerto;
        public static string formatoimpfactelectronica;
        public static string formatoimpproforma;
        public static string formatoimpremito;
        public static string certificado;

        public static string[] ReglasUsuario { get; set; }
        public static int idroles;

        //EMPRESA

        public static string emrazonsocial;
        public static long emcuit;
        public static string emciva;
        public static string emdomicilio;
        public static string emlocalidad;
        public static string emprovincia;
        public static string emtelefono;
        public static string emmail;
        public static int emcodempresa;
        public static string urllogin = "https://wsaa.afip.gov.ar/ws/services/LoginCms?wsdl";
        public static string urlservicio = "https://servicios1.afip.gov.ar/wsfev1/service.asmx?WSDL";



        public static bool usuariosa;

        public static DataTable mostrar()
        {

            DataTable midatatable = new DataTable();
            midatatable = new DatosConfigEmpresa().mostrar();



            foreach (DataRow fila in midatatable.Rows)
            {

                emrazonsocial = fila["razon_social"].ToString();
                emcuit = Convert.ToInt64(fila["cuit"].ToString());
                emciva = fila["condicion_frente_iva"].ToString();
                emdomicilio = fila["domicilio"].ToString();
                emlocalidad = fila["localidad"].ToString();
                emprovincia = fila["provincia"].ToString();
                emtelefono = fila["telefono"].ToString();
                emmail = fila["Mail"].ToString();
                emcodempresa = Convert.ToInt32(fila["cod_empresa"].ToString());


            }

            return new DatosConfigEmpresa().mostrar();


        }


        public static string agregar(string razonSocial, string condicionFrenteIVA, long cuit, Byte[] logo)
        {


            DatosConfigEmpresa empresa = new DatosConfigEmpresa();
            empresa.Cuit = cuit;
            empresa.CondicionFrenteIVA = condicionFrenteIVA;
            empresa.RazonSocial = razonSocial;
            empresa.Logo = logo;
            return empresa.agregarEmpresa(empresa);


        }


        public static string modificar(string razonSocial, string condicionFrenteIVA, Int64 cuit, Byte[] logo)
        {


            DatosConfigEmpresa empresa = new DatosConfigEmpresa();
            empresa.Cuit = cuit;
            empresa.CondicionFrenteIVA = condicionFrenteIVA;
            empresa.RazonSocial = razonSocial;
            empresa.Logo = logo;
            return empresa.ModificarEmpresa(empresa);


        }
        //inicializamos las variables globales que se van a ocupar durante todo el proyecto

        public static void inivarglobal(string equipo, string usuario, string turno, int idusuario, int codsucursal, DateTime fecha, string ruta, string ip, int puertofiscal, int modelofiscal, int empresa, string marcafiscal)
        {
            NegocioConfigEmpresa.equipo = equipo;
            NegocioConfigEmpresa.usuarioconectado = usuario;
            NegocioConfigEmpresa.turno = turno;
            NegocioConfigEmpresa.idusuario = idusuario;
            NegocioConfigEmpresa.codsucursal = codsucursal;
            NegocioConfigEmpresa.fecha = fecha;
            NegocioConfigEmpresa.ruta = ruta;
            NegocioConfigEmpresa.ruta = ruta;
            NegocioConfigEmpresa.ip = ip;
            NegocioConfigEmpresa.puertofiscal = puertofiscal;
            NegocioConfigEmpresa.modelofiscal = modelofiscal;
            NegocioConfigEmpresa.idempresa = empresa;
            NegocioConfigEmpresa.marcafiscal = marcafiscal;
            NegocioConfigEmpresa.impreporte = impreporte;
            NegocioConfigEmpresa.impticket = impticket;
            NegocioConfigEmpresa.certificado = certificado;



        }

        public static string confequipo(string equipo, string usuario, string turno, int idusuario, int codsucursal, DateTime fecha, string ruta, string ip, int puertofiscal, int modelofiscal, int empresa, string marcafiscal, string impticket = "", string impreporte = "", string varcertificado = "")
        {
            string msg = "";

            try
            {
                DatosConfigEmpresa objequipo = new DatosConfigEmpresa();
                objequipo.Equipo = equipo;
                objequipo.Usuario = usuario;
                objequipo.Turno = turno;
                objequipo.Idusuario = idusuario;
                objequipo.Codsucursal = codsucursal;
                objequipo.Fecha = fecha;
                objequipo.Ruta = ruta;
                objequipo.Ip = ip;
                objequipo.Puertofiscal = puertofiscal;
                objequipo.Modelofiscal = modelofiscal;
                objequipo.Idempresa = idempresa;
                objequipo.Marcafiscal = marcafiscal;
                objequipo.Impticket = impticket;
                objequipo.Impreporte = impreporte;
                objequipo.Certificado = varcertificado;

                msg = objequipo.confequipo(objequipo);
                NegocioConfigEmpresa.inivarglobal(equipo, usuario, turno, idusuario, codsucursal, fecha, ruta, ip, puertofiscal, modelofiscal, empresa, marcafiscal);


            }

            catch (Exception ex)
            {
                throw;
            }
            return msg;
        }

        public static string mostrarequipo(string equipo)
        {
            string msg = "ok";
            DatosConfigEmpresa objempresa = new DatosConfigEmpresa();
            if (objempresa.Mostrarequipo(equipo) == true)
            {
                NegocioConfigEmpresa.equipo = objempresa.Equipo;
                NegocioConfigEmpresa.idequipo = objempresa.Idequipo;
                NegocioConfigEmpresa.usuarioconectado = objempresa.Usuario;
                NegocioConfigEmpresa.turno = objempresa.Turno;
                NegocioConfigEmpresa.idusuario = objempresa.Idusuario;
                NegocioConfigEmpresa.codsucursal = objempresa.Codsucursal;
                NegocioConfigEmpresa.fecha = objempresa.Fecha;
                NegocioConfigEmpresa.ruta = objempresa.Ruta;
                NegocioConfigEmpresa.ip = objempresa.Ip;
                NegocioConfigEmpresa.puertofiscal = objempresa.Puertofiscal;
                NegocioConfigEmpresa.modelofiscal = objempresa.Modelofiscal;
                NegocioConfigEmpresa.idempresa = objempresa.Idempresa;
                NegocioConfigEmpresa.marcafiscal = objempresa.Marcafiscal;
                NegocioConfigEmpresa.impreporte = objempresa.Impreporte;
                NegocioConfigEmpresa.impticket = objempresa.Impticket;
                NegocioConfigEmpresa.puntoventa = objempresa.Puntoventa;
                NegocioConfigEmpresa.balanzapuerto = objempresa.BalanzaPuerto1;
                NegocioConfigEmpresa.formatoimpfactelectronica = objempresa.FormatoImpFactElectronica1;
                NegocioConfigEmpresa.formatoimpproforma = objempresa.Formatoimpproforma;
                NegocioConfigEmpresa.formatoimpremito = objempresa.Formatoimpremito;
                NegocioConfigEmpresa.certificado = objempresa.Certificado;
            }
            else
            {
                msg = "Este equipo no se encuentra registrado, se procede a darlo de alta";

            }

            return msg;
        }

        public static string actualizarequipo(string usuario, string turno, int idusuario, DateTime fecha, int idequipo)
        {
            string msg = "";
            DatosConfigEmpresa objemp = new DatosConfigEmpresa();
            msg = objemp.actualizarequipo(usuario, turno, idusuario, fecha, idequipo);

            return msg;

        }
        //parametrisa segun lo requiera
        public static object confsistema(string nombre)
        {

            DatosConfigEmpresa objemp = new DatosConfigEmpresa();
            return objemp.configsistema(nombre);

        }
    }
}
