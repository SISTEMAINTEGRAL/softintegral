namespace Capa_Presentacion
{
    partial class FrmConexion
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
            this.Txtbasedatos = new System.Windows.Forms.TextBox();
            this.lblservidor = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.lblDataSource = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNomUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.BtnGuardarConexion = new XanderUI.XUISuperButton();
            this.BtnCerrar = new XanderUI.XUISuperButton();
            this.SuspendLayout();
            // 
            // Txtbasedatos
            // 
            this.Txtbasedatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txtbasedatos.Location = new System.Drawing.Point(243, 47);
            this.Txtbasedatos.Margin = new System.Windows.Forms.Padding(6, 12, 6, 12);
            this.Txtbasedatos.Name = "Txtbasedatos";
            this.Txtbasedatos.Size = new System.Drawing.Size(236, 30);
            this.Txtbasedatos.TabIndex = 53;
            // 
            // lblservidor
            // 
            this.lblservidor.AutoSize = true;
            this.lblservidor.Location = new System.Drawing.Point(76, 49);
            this.lblservidor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblservidor.Name = "lblservidor";
            this.lblservidor.Size = new System.Drawing.Size(148, 25);
            this.lblservidor.TabIndex = 54;
            this.lblservidor.Text = "Base de datos :";
            // 
            // txtServidor
            // 
            this.txtServidor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtServidor.Location = new System.Drawing.Point(244, 97);
            this.txtServidor.Margin = new System.Windows.Forms.Padding(6, 12, 6, 12);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(236, 30);
            this.txtServidor.TabIndex = 55;
            // 
            // lblDataSource
            // 
            this.lblDataSource.AutoSize = true;
            this.lblDataSource.Location = new System.Drawing.Point(75, 99);
            this.lblDataSource.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDataSource.Name = "lblDataSource";
            this.lblDataSource.Size = new System.Drawing.Size(96, 25);
            this.lblDataSource.TabIndex = 56;
            this.lblDataSource.Text = "Servidor :";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(241, 201);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.txtContraseña.MaxLength = 50;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(239, 30);
            this.txtContraseña.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(77, 202);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 76;
            this.label2.Text = "Contraseña :";
            // 
            // lblNomUsuario
            // 
            this.lblNomUsuario.AutoSize = true;
            this.lblNomUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblNomUsuario.Location = new System.Drawing.Point(76, 152);
            this.lblNomUsuario.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNomUsuario.Name = "lblNomUsuario";
            this.lblNomUsuario.Size = new System.Drawing.Size(90, 25);
            this.lblNomUsuario.TabIndex = 75;
            this.lblNomUsuario.Text = "Usuario :";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(243, 147);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.txtUsuario.MaxLength = 50;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(236, 30);
            this.txtUsuario.TabIndex = 74;
            // 
            // BtnGuardarConexion
            // 
            this.BtnGuardarConexion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardarConexion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(247)))));
            this.BtnGuardarConexion.ButtonImage = global::Capa_Presentacion.Properties.Resources.Save_20px;
            this.BtnGuardarConexion.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.BtnGuardarConexion.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.BtnGuardarConexion.ButtonText = "Guardar conexion";
            this.BtnGuardarConexion.CornerRadius = 5;
            this.BtnGuardarConexion.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnGuardarConexion.HoverBackgroundColor = System.Drawing.Color.IndianRed;
            this.BtnGuardarConexion.HoverTextColor = System.Drawing.Color.Yellow;
            this.BtnGuardarConexion.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.BtnGuardarConexion.Location = new System.Drawing.Point(49, 313);
            this.BtnGuardarConexion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnGuardarConexion.Name = "BtnGuardarConexion";
            this.BtnGuardarConexion.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.BtnGuardarConexion.SelectedTextColor = System.Drawing.Color.White;
            this.BtnGuardarConexion.Size = new System.Drawing.Size(235, 61);
            this.BtnGuardarConexion.SuperSelected = false;
            this.BtnGuardarConexion.TabIndex = 135;
            this.BtnGuardarConexion.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.BtnGuardarConexion.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnGuardarConexion.Click += new System.EventHandler(this.BtnGuardarConexion_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(247)))));
            this.BtnCerrar.ButtonImage = global::Capa_Presentacion.Properties.Resources.Save_20px;
            this.BtnCerrar.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.BtnCerrar.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.BtnCerrar.ButtonText = "Cerrar";
            this.BtnCerrar.CornerRadius = 5;
            this.BtnCerrar.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnCerrar.HoverBackgroundColor = System.Drawing.Color.IndianRed;
            this.BtnCerrar.HoverTextColor = System.Drawing.Color.Yellow;
            this.BtnCerrar.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.BtnCerrar.Location = new System.Drawing.Point(292, 313);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.BtnCerrar.SelectedTextColor = System.Drawing.Color.White;
            this.BtnCerrar.Size = new System.Drawing.Size(235, 61);
            this.BtnCerrar.SuperSelected = false;
            this.BtnCerrar.TabIndex = 135;
            this.BtnCerrar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.BtnCerrar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // FrmConexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 443);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnGuardarConexion);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNomUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.lblDataSource);
            this.Controls.Add(this.Txtbasedatos);
            this.Controls.Add(this.lblservidor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmConexion";
            this.Text = "FrmConexion";
            this.Load += new System.EventHandler(this.FrmConexion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txtbasedatos;
        private System.Windows.Forms.Label lblservidor;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Label lblDataSource;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNomUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private XanderUI.XUISuperButton BtnGuardarConexion;
        private XanderUI.XUISuperButton BtnCerrar;
    }
}