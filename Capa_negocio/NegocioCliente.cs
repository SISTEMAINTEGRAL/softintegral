using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_Datos;
namespace Capa_negocio
{
   public class NegocioCliente
    {
        public static string insertar(string razonSocial, string direccion, long cuit,DateTime fechaNacimiento, long tel, long numDocumento, string email, string responsableanteiva, int idprovincia, int idlocalidad)
        {
            DatosCliente cliente = new DatosCliente(razonSocial, direccion, cuit, tel, numDocumento, email, responsableanteiva, idprovincia, idlocalidad);
            
            return cliente.agregar(cliente);
        }
        public static string eliminar(int idCliente)
        {
            DatosCliente cliente = new DatosCliente(idCliente);
            
            return cliente.eliminar(cliente);
}
        public static string editar(int idCliente, string razonSocial, string direccion, long cuit, DateTime fechaNacimiento, long tel, long numDocumento, string email, string responsableiva, int idprovincia, int idlocalidad)
        {
            DatosCliente cliente = new DatosCliente(razonSocial,direccion,cuit,tel,numDocumento,email,responsableiva,idprovincia,idlocalidad);
            return cliente.editar(cliente);
        }
        public static DataTable buscar(string texto)
        {
            DatosCliente cliente = new DatosCliente();
           
                cliente.BuscarCliente= texto;
                return cliente.buscarTexto(cliente);
        }
        public static DataTable buscarCodigoCliente(string texto, int modo = 6)
        {
            DatosCliente cliente = new DatosCliente();

            cliente.BuscarCliente = texto;
            return cliente.buscarCodigoCliente(cliente, modo);
        }
        public static DataTable mostrar()  {
            
                return new DatosCliente().mostrar();
            }
        public static DataTable responsabilidadiva()
        {
            return new DatosCliente().Responsabilidadiva();
        }

        public static DataTable provincia()
        {
            return new DatosCliente().provincia();
        }

        public static DataTable localidad(int idprovincia)
        {
            return new DatosCliente(idprovincia,0).localidad();
        
        }
        //ctacte----------------------------------------------------------------------------------------
        public static string agregarctacte (int codcliente, int codventa, string estado, decimal saldo, decimal pagado, decimal total)
        {
            DatosCliente objcliente = new DatosCliente(codcliente, codventa, saldo, total, pagado, estado, "ingresarctacte");
            return objcliente.agregaromodificarctacte(objcliente);
        }
        public static string modificarctacte(int codcliente, int codventa, string estado, decimal saldo, decimal pagado, decimal total)
        {
            DatosCliente objcliente = new DatosCliente(codcliente, codventa, saldo, total, pagado, estado, "modificarctacte");
            return objcliente.agregaromodificarctacte(objcliente);
        }

        public static DataTable buscarporcodigoctacte (int codcliente, string fechaD, string fechaH)
        {
            DatosCliente objcliente = new DatosCliente(codcliente, fechaD,fechaH);
            return objcliente.buscarporcodigoctacte(objcliente);

        }
        //public static string modificarlistactacte(DataTable midata, decimal totalapagar)
        //{
        //    //DatosCliente objcliente = new DatosCliente();
            
        //    //return objcliente(midata,"");
        //}

        public static string agregaromodificarrecibo(DataTable midata, decimal totalapagar, int codcliente, int idusuario, ref int codrecibo)
        {
            DatosCliente objcliente = new DatosCliente(codcliente);
         
           
            return objcliente.agregarrecibo(ref codrecibo,objcliente,midata,totalapagar,false ,idusuario);
        }

        public static DataTable reporterecibo(int codrecibo)
        {
            DatosCliente objcliente = new DatosCliente();
            return objcliente.reporterecibo(codrecibo);
        }

        public static string modificarestadocajarecibo(int codrecibo)
        {
            DatosCliente objcliente = new DatosCliente();
            return objcliente.modificarcajarecibo(codrecibo,"cerrartransaccion");


        }

    }
 }

