using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Presentacion.DataSet;
namespace Capa_Presentacion
{
    public partial class FrmImpArticulo : Form
    {
        public FrmImpArticulo(DataGridView listaArticulos)
        {
            //foreach (DataRow fila in listaArticulos.Rows)
            //{
            //    DataRow filaDataTable = new DataRow();
                
               
            InitializeComponent();
        }
    }
}
