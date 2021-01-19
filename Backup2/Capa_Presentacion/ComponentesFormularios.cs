using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Presentacion
{
    public class ComponentesFormularios
    {
        /// <summary>
        /// Retorna un color en argb representado en int del color violeta
        /// </summary>
        /// <returns>int</returns>
        public static int ColorPanelSuperiorVioleta()
        { 
            //violeta
            int colorRojo =100;
            int colorVerde = 0;
            int colorAzul=170;

            return Color.FromArgb(colorRojo, colorVerde, colorAzul).ToArgb();
        }

        /// <summary>
        /// Retorna un color en argb representado en int del color Azul
        /// </summary>
        /// <returns>int</returns>
         public static int ColorPanelSuperiorAzul()
        { 
            //azul
          
            int colorRojo =31;
            int colorVerde =97;
            int colorAzul=141  ;

            return Color.FromArgb(colorRojo, colorVerde, colorAzul).ToArgb();
        }   
         /// <summary>
        /// Retorna un color en argb representado en int del color Negro
        /// </summary>
        /// <returns>int</returns>
         public static int ColorPanelSuperiorNegro()
        { 
            //azul
          
            int colorRojo =33;
            int colorVerde =47;
            int colorAzul=61  ;

            return Color.FromArgb(colorRojo, colorVerde, colorAzul).ToArgb();
        }  
       

            }
}
