using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data;
using System.Data.SqlClient;

namespace Capa_negocio
{
   public class NegocioUnidades
    {
        public static string insertar(string nombre)
        {
            DatosUnidades dUnidades= new DatosUnidades();
            dUnidades.Nombre = nombre;
            return dUnidades.agregar(dUnidades);
        }
        public static string eliminar(int idUnidad)
        {
            DatosUnidades dUnidades = new DatosUnidades();
            dUnidades.IdUnidad = idUnidad;
            return dUnidades.eliminar(dUnidades);
        }
        public static string editar(int idUnidad, string nombre)
        {
            DatosUnidades dUnidades = new DatosUnidades();
            dUnidades.IdUnidad = idUnidad;
            dUnidades.Nombre = nombre;
            return dUnidades.editar(dUnidades);
        }
        public static DataTable buscar(string texto)
        {
            DatosUnidades dunidades = new DatosUnidades();
            return dunidades.buscarTexto(dunidades,texto);
        }
        public static DataTable mostrar()
        {

            return new DatosUnidades().mostrar();
        }
    }
}
