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
    public class Negocioserviciotecnico
    {
        public static string insertarequipo(string nombreequipo, string descripcionequipo, int idcategoria, int idmarca, int idmodelo)
        {
             
            DatosServicioTecnico dservicio = new DatosServicioTecnico(0, idmarca, idmodelo, idcategoria, nombreequipo, descripcionequipo);
            return dservicio.agregareditarequipo(dservicio, "agregarequipo");
        }

        public static string editarequipo(int idequipo,int idmarca, int idmodelo, int idcategoria, string nombreequipo, string descripcionequipo)
        {
            DatosServicioTecnico dservicio = new Capa_Datos.DatosServicioTecnico(idequipo, idmarca, idmodelo, idcategoria, nombreequipo, descripcionequipo);
            return dservicio.agregareditarequipo(dservicio, "modificarequipo");
        }
        public static string agregarserieequipo(string serie, int idequipo)
        {
            DatosServicioTecnico dservicio = new Capa_Datos.DatosServicioTecnico(serie,idequipo);
            return dservicio.agregareditarequipo(dservicio, "agregarserieequipo");  
        }
        public static DataTable buscarmarca()
        {
            DatosServicioTecnico dservicio = new DatosServicioTecnico();
            return dservicio.buscarmarca(dservicio);
        }
        public static DataTable buscarmodelo(int idmarca)
        {
            DatosServicioTecnico dservicio = new DatosServicioTecnico(idmarca);
            return dservicio.buscarmodelo(dservicio);
        }
        public static DataTable buscarequipo(int varidmarca, int varidmodelo, int varidcategoria, string vardescripcionequipo,bool pormarca = false, bool pormodelo = false, bool porcategoria = false)
        {
            DatosServicioTecnico stecnico = new DatosServicioTecnico(0,varidmarca,varidmodelo,varidcategoria,"",vardescripcionequipo);
            return stecnico.Buscarequipo(stecnico,pormarca,pormodelo,porcategoria);
        }

    }
}
