namespace SistemaVentas
{
    partial class Form1
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
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.lblCambio = new System.Windows.Forms.Label();
            this.txtAbono = new System.Windows.Forms.TextBox();
            this.lblAbono = new System.Windows.Forms.Label();
            this.gbxEfectivo = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxEfectivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCambio
            // 
            this.txtCambio.Enabled = false;
            this.txtCambio.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambio.Location = new System.Drawing.Point(36, 164);
            this.txtCambio.Margin = new System.Windows.Forms.Padding(4);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.ReadOnly = true;
            this.txtCambio.Size = new System.Drawing.Size(285, 44);
            this.txtCambio.TabIndex = 56;
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.Location = new System.Drawing.Point(85, 126);
            this.lblCambio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(175, 37);
            this.lblCambio.TabIndex = 55;
            this.lblCambio.Text = "Cambio $ :";
            // 
            // txtAbono
            // 
            this.txtAbono.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbono.Location = new System.Drawing.Point(36, 69);
            this.txtAbono.Margin = new System.Windows.Forms.Padding(4);
            this.txtAbono.Name = "txtAbono";
            this.txtAbono.Size = new System.Drawing.Size(285, 44);
            this.txtAbono.TabIndex = 1;
            this.txtAbono.TextChanged += new System.EventHandler(this.txtAbono_TextChanged);
            // 
            // lblAbono
            // 
            this.lblAbono.AutoSize = true;
            this.lblAbono.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbono.Location = new System.Drawing.Point(61, 31);
            this.lblAbono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAbono.Name = "lblAbono";
            this.lblAbono.Size = new System.Drawing.Size(221, 37);
            this.lblAbono.TabIndex = 53;
            this.lblAbono.Text = "Abona con $ :";
            // 
            // gbxEfectivo
            // 
            this.gbxEfectivo.Controls.Add(this.txtCambio);
            this.gbxEfectivo.Controls.Add(this.lblCambio);
            this.gbxEfectivo.Controls.Add(this.txtAbono);
            this.gbxEfectivo.Controls.Add(this.lblAbono);
            this.gbxEfectivo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEfectivo.Location = new System.Drawing.Point(13, 13);
            this.gbxEfectivo.Margin = new System.Windows.Forms.Padding(4);
            this.gbxEfectivo.Name = "gbxEfectivo";
            this.gbxEfectivo.Padding = new System.Windows.Forms.Padding(4);
            this.gbxEfectivo.Size = new System.Drawing.Size(344, 223);
            this.gbxEfectivo.TabIndex = 1;
            this.gbxEfectivo.TabStop = false;
            this.gbxEfectivo.Text = "Efectivo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(380, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 130);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 400);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbxEfectivo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxEfectivo.ResumeLayout(false);
            this.gbxEfectivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.TextBox txtAbono;
        private System.Windows.Forms.Label lblAbono;
        private System.Windows.Forms.GroupBox gbxEfectivo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}