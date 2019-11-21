using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data;
namespace Capa_negocio
{
   public class NegocioFormaDePago
    {

       public static DataTable mostrarTarjetas() { 

        
       return new DatosFormaDePago().mostrar();


       }
    }
}
