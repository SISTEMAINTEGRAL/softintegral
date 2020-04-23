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
        //si ingresamos 0 se agrega una categoria nueva si es distinto de 0 agregamos una subcategoria
        public static string insertar(string nombre,string descripcion,int idcategoria) {
            DatosCategoria dcategoria = new DatosCategoria();
            dcategoria.Nombre = nombre;
            dcategoria.Descripcion = descripcion;
            dcategoria.IdCategoria = idcategoria;
            
            return dcategoria.agregar(dcategoria);
        }
        


        public static string eliminar(int idCategoria)
        {
            DatosCategoria dcategoria = new DatosCategoria();
            dcategoria.IdCategoria = idCategoria;
            return dcategoria.eliminar(dcategoria);
}
        public static string editar(int idCategoria,string nombre, string descripcion,int idsubcategoria = 0)
        {
            DatosCategoria dcategoria = new DatosCategoria();
            dcategoria.Nombre = nombre;
            dcategoria.Descripcion = descripcion;
            dcategoria.IdCategoria = idCategoria;
            dcategoria.Idsubcategoria = idsubcategoria;
            return dcategoria.editar(dcategoria);
        }
        public static DataTable buscar(string texto)
        {
            DatosCategoria dcategoria = new DatosCategoria();
           
                dcategoria.BuscarCategoria = texto;
                return dcategoria.buscarTexto(dcategoria);
        }
        public static DataTable buscar(string texto,int idcategoria)
        {
            DatosCategoria dcategoria = new DatosCategoria();

            dcategoria.IdCategoria  = idcategoria;
            dcategoria.BuscarCategoria = texto;

            return dcategoria.buscarTexto(dcategoria);
        }

        public static DataTable mostrar()  {
            
                return new DatosCategoria().mostrar();
            }
    }
}
