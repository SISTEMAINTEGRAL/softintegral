using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data;
namespace Capa_negocio
{
    public class NegocioTarjeta
    {
        public static string insertar(string nombre, int codigoFormaPago)
        {
            DatosTarjeta tarjeta = new DatosTarjeta(nombre, codigoFormaPago);
            return tarjeta.agregarTarjeta(tarjeta);

        }


        public static DataTable mostrar()
        {
            return new DatosTarjeta().mostrarTarjetas();
        }
    }
}
