namespace Capa_Presentacion
{
    partial class FrmAsignarPrecio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.txtTara = new System.Windows.Forms.TextBox();
            this.lblcant = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(592, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "COLOQUE LO QUE QUIERA PESAR EN LA BALANZA Y PRESIONE ENTER";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // txtTara
            // 
            this.txtTara.Location = new System.Drawing.Point(340, 81);
            this.txtTara.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.txtTara.MaxLength = 10;
            this.txtTara.Name = "txtTara";
            this.txtTara.Size = new System.Drawing.Size(54, 26);
            this.txtTara.TabIndex = 68;
            this.txtTara.Text = "0";
            this.txtTara.Click += new System.EventHandler(this.txtTara_Click);
            this.txtTara.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTara_KeyDown);
            this.txtTara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTara_KeyPress);
            // 
            // lblcant
            // 
            this.lblcant.AutoSize = true;
            this.lblcant.Location = new System.Drawing.Point(255, 84);
            this.lblcant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcant.Name = "lblcant";
            this.lblcant.Size = new System.Drawing.Size(63, 20);
            this.lblcant.TabIndex = 69;
            this.lblcant.Text = "TARA :";
            // 
            // FrmAsignarPrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(669, 138);
            this.Controls.Add(this.txtTara);
            this.Controls.Add(this.lblcant);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAsignarPrecio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar Precio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAsignarPrecio_FormClosing);
            this.Load += new System.EventHandler(this.FrmAsignarPrecio_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAsignarPrecio_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort1;
        public System.Windows.Forms.TextBox txtTara;
        private System.Windows.Forms.Label lblcant;
    }
}