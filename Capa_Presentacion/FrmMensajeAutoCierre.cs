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
    public partial class FrmMensajeAutoCierre : Form
    {
        public FrmMensajeAutoCierre()
        {
            InitializeComponent();
        }

         System.Threading.Timer TiempoParaCierre;
        string Titulo;
        /// <summary>
        /// Crea un formulario de autocierre 
        /// </summary>
        /// <param name="texto">Texto que va a mostrar</param>
        /// <param name="titulo">Titulo de la ventana</param>
        /// <param name="tiempo">Tiempo que se va a mostrar</param>
        public FrmMensajeAutoCierre(string texto, string titulo, int tiempo)
        {
            InitializeComponent();
            Titulo = titulo;
            TiempoParaCierre = new System.Threading.Timer(OnTimerElapsed,
                null, tiempo, System.Threading.Timeout.Infinite);
            MessageBox.Show(texto, titulo);
        }
        /// <summary>
        /// Muestra la ventana de autocierre
        /// </summary>
        /// <param name="text"></param>
        /// <param name="caption"></param>
        /// <param name="timeout"></param>
        public static void Show(string text, string caption, int timeout)
        {
            new FrmMensajeAutoCierre(text, caption, timeout);
        }

      public  void OnTimerElapsed(object state)
        {
            IntPtr mbWnd = FindWindow(null, Titulo);
            if (mbWnd != IntPtr.Zero)
                SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
            TiempoParaCierre.Dispose();
        }
        const int WM_CLOSE = 0x0010;
        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
  




       

        private void FrmMensajeAutoCierre_Load(object sender, EventArgs e)
        {

        }
    }
}
