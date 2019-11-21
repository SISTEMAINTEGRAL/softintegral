using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_negocio;

namespace Capa_Presentacion
{
    public partial class Frmprivilegio : Form
    {

        public Frmprivilegio()
        {
            InitializeComponent();
        }

        private void Frmprivilegio_Load(object sender, EventArgs e)
        {

            NegocioUsuario objusuario = new NegocioUsuario();
            
            llenarcombobox(cbxRoles, "roles","codroles","roles");
            llenarcombobox(cbmodulos,"procesos", "codigo", "proceso");
            dataGridView1.DataSource = objusuario.mostrarprivilegio(Convert.ToInt32 (cbxRoles.SelectedValue), Convert.ToInt32(cbmodulos.SelectedValue));
            cbmodulos.SelectedIndex = 8;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void llenarcombobox(ComboBox combo, string tabla, string valor, string display)
        {
            NegocioUsuario objusuario = new NegocioUsuario();
            combo.DataSource = objusuario.mostrartabla(tabla);

            combo.ValueMember = valor;
            //lo que se muestra
            combo.DisplayMember = display;
            

        
        }

        private void cbmodulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            NegocioUsuario objusuario = new NegocioUsuario();
            if (cbxRoles.ValueMember != "" && cbmodulos.ValueMember != "")
            {
                dataGridView1.DataSource = objusuario.mostrarprivilegio(Convert.ToInt32(cbxRoles.SelectedValue), Convert.ToInt32(cbmodulos.SelectedValue));
                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }

        private void cbxRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            NegocioUsuario objusuario = new NegocioUsuario();
            if (cbxRoles.ValueMember != "" && cbmodulos.ValueMember != "")
            {
                dataGridView1.DataSource = objusuario.mostrarprivilegio(Convert.ToInt32(cbxRoles.SelectedValue),Convert.ToInt32(cbmodulos.SelectedValue));
                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            NegocioUsuario objusuario = new NegocioUsuario();
            DataTable dt = new DataTable();
            dt.Columns.Add("Codigo", typeof(int));
            dt.Columns.Add("descripcion", typeof(string));
            dt.Columns.Add("observacion", typeof(string));
            dt.Columns.Add("estado", typeof(bool));
            dt.Columns.Add("codproceso", typeof(int));
            dt.Columns.Add("codsubproceso", typeof(int));
            //dt.Columns.Add("Importe", typeof(decimal));
            //dt.Columns.Add("Producto", typeof(string));


            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (Convert.ToBoolean ( fila.Cells["estado"].Value.ToString()) == true )
                {
                   dt.Rows.Add(fila.Cells["Codigo"].Value, fila.Cells["descripcion"].Value, fila.Cells["observacion"].Value, fila.Cells["estado"].Value, fila.Cells["codproceso"].Value, fila.Cells["codsubproceso"].Value);
                }

                
                
                               
            }

            if (dataGridView1.RowCount != 0)
            {
                objusuario.actualizarprivilegio(Convert.ToInt32(cbxRoles.SelectedValue), Convert.ToInt32(cbmodulos.SelectedValue), dt); 
            
            }


        }
    }
}
