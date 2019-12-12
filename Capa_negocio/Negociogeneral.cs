using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data;
using System.Data.SqlClient;


namespace Capa_negocio
{
   public class Negociogeneral
    {

        public static DataTable selecciondeconsultageneral(string tabla, string campo, string valor)
        {
            Datosgenerales general = new Datosgenerales(tabla,valor,campo);
            return general.selecciondeconsultageneral(general);
        }
        public static DataTable selecciondeconsultasinfiltro(string tabla)
        {
            Datosgenerales general = new Datosgenerales(tabla);
            return general.selecciondeconsultageneral(general,"modoseleccionsinfiltro");
        }
    }
}
