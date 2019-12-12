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
        public static string agregarserieequipo(string serie,int idequipo,int idmarca,int idmodelo)
        {
            DatosServicioTecnico dservicio = new Capa_Datos.DatosServicioTecnico(serie,idequipo,idmarca,idmodelo);
            return dservicio.agregareditarequipo(dservicio, "agregarserieequipo");  
        }
        public static DataTable buscarmarca()
        {
            DatosServicioTecnico dservicio = new DatosServicioTecnico();
            return dservicio.buscarmarca(dservicio);
        }
        public static DataTable buscarmodelo(int idmarca,int idequipo)
        {
            DatosServicioTecnico dservicio = new DatosServicioTecnico(idmarca,idequipo);
            return dservicio.buscarmodelo(dservicio);
        }
        public static DataTable buscarequipo(string varserie, int varidmarca, int varidmodelo, int varidequipo,bool pormarca = false, bool pormodelo = false, bool porequipo = false)
        {
            DatosServicioTecnico stecnico = new DatosServicioTecnico(varserie,varidequipo,varidmarca,varidmodelo);
            return stecnico.Buscarequipo(stecnico,pormarca,pormodelo,porequipo);
        }
        public static void agregarmarca(string varmarca)
        {
            DatosServicioTecnico stecnico = new DatosServicioTecnico(varmarca, "");
            stecnico.agregarmarcaymodelo(stecnico, "agregarmarca");
        }
        public static void agregarmodelo(string varmodelo, int idmarca,int idequipo )
        {
            DatosServicioTecnico stecnico = new DatosServicioTecnico("", varmodelo,idmarca,idequipo);
            stecnico.agregarmarcaymodelo(stecnico, "agregarmodelo");
        }
        public static void agregarequipo(string equipo)
        {
            DatosServicioTecnico servicio = new DatosServicioTecnico(equipo);
            servicio.agregareditarequipo(servicio, "agregarequipo");
        }
        public static string editarseriequipo(string serie, int idequipo, int idmarca, int idmodelo, int idserieyequipo)
        {
            DatosServicioTecnico dservicio = new Capa_Datos.DatosServicioTecnico(serie, idequipo, idmarca, idmodelo,idserieyequipo);
            return dservicio.agregareditarequipo(dservicio, "modificarserie");
        }
    }
}
