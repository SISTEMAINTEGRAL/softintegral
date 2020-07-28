using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class FrmPopup : Form
    {
        public FrmPopup(string message, Color bgcolor)
        {
            InitializeComponent();
            BackColor = bgcolor;
            LblMensaje.Text = message;
        }

        System.Threading.Timer TiempoParaCierre;
        string Titulo;

        private void FrmPopup_Load(object sender, EventArgs e)
        {
            Top = 20;
            Left = Screen.PrimaryScreen.Bounds.Width - Width - 20;
            timer2.Start();
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
