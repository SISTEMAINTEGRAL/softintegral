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
            DatosCliente cliente = new DatosCliente();
            cliente.RazonSocial= razonSocial;
            cliente.Direccion = direccion;
            cliente.Cuit= cuit;
            cliente.Tel= tel;
            cliente.NumDocumento = numDocumento;
            cliente.Email = email;
            cliente.FechaNacimiento = fechaNacimiento;
            cliente.Responsableiva  = responsableanteiva;
            cliente.Idprovincia = idprovincia;
            cliente.Idlocalidad = idlocalidad;
            return cliente.agregar(cliente);
        }
        public static string eliminar(int idCliente)
        {
            DatosCliente cliente = new DatosCliente();
            cliente.IdCliente=idCliente;
            return cliente.eliminar(cliente);
}
        public static string editar(int idCliente, string razonSocial, string direccion, long cuit, DateTime fechaNacimiento, long tel, long numDocumento, string email, string responsableiva, int idprovincia, int idlocalidad)
        {
            DatosCliente cliente = new DatosCliente();
            cliente.RazonSocial=razonSocial;
            cliente.Direccion = direccion;
            cliente.Cuit = cuit;
            cliente.Tel = tel;
            cliente.NumDocumento = numDocumento;
            cliente.Email = email;
            cliente.IdCliente = idCliente;
            cliente.FechaNacimiento = fechaNacimiento;
            cliente.Responsableiva = responsableiva;
            cliente.Idprovincia = idprovincia;
            cliente.Idlocalidad = idlocalidad;

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

        public static DataTable localidad(int idlocalidad)
        {
            return new DatosCliente(idlocalidad).localidad();
        
        }
        }
 }

