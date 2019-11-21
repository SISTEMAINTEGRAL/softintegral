using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
namespace Capa_negocio
{
   public  class NegocioBackup
    {

       public static string backupBaseDeDatos(string ruta){

           return new DatosBackup().generarBackup(ruta) ;
       }
    }
}
