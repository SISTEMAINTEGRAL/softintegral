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
   public class NegocioCategoria
    {
        public static string insertar(string nombre,string descripcion) {
            DatosCategoria dcategoria = new DatosCategoria();
            dcategoria.Nombre = nombre;
            dcategoria.Descripcion = descripcion;
            return dcategoria.agregar(dcategoria);
        }
        public static string eliminar(int idCategoria)
        {
            DatosCategoria dcategoria = new DatosCategoria();
            dcategoria.IdCategoria = idCategoria;
            return dcategoria.eliminar(dcategoria);
}
        public static string editar(int idCategoria,string nombre, string descripcion)
        {
            DatosCategoria dcategoria = new DatosCategoria();
            dcategoria.Nombre = nombre;
            dcategoria.Descripcion = descripcion;
            dcategoria.IdCategoria = idCategoria;
            return dcategoria.editar(dcategoria);
        }
        public static DataTable buscar(string texto)
        {
            DatosCategoria dcategoria = new DatosCategoria();
           
                dcategoria.BuscarCategoria = texto;
                return dcategoria.buscarTexto(dcategoria);
        }
        public static DataTable mostrar()  {
            
                return new DatosCategoria().mostrar();
            }
    }
}
