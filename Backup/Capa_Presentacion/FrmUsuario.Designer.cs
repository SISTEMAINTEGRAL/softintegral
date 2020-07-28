namespace Capa_Presentacion
{
    partial class FrmUsuario
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
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ttMensajeAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.lblClientes = new System.Windows.Forms.Label();
            this.gbDetalleMovimento = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cbxRoles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNomUsuario = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.Notificacion = new System.Windows.Forms.NotifyIcon(this.components);
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.gbDetalleMovimento.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(130, 28);
            // 
            // ttMensajeAyuda
            // 
            this.ttMensajeAyuda.AutomaticDelay = 90;
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.lblClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblClientes.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.Color.Snow;
            this.lblClientes.Image = global::Capa_Presentacion.Properties.Resources.fondo1;
            this.lblClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblClientes.Location = new System.Drawing.Point(16, 41);
            this.lblClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(221, 62);
            this.lblClientes.TabIndex = 36;
            this.lblClientes.Text = "Usuarios";
            // 
            // gbDetalleMovimento
            // 
            this.gbDetalleMovimento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDetalleMovimento.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbDetalleMovimento.Controls.Add(this.button1);
            this.gbDetalleMovimento.Controls.Add(this.checkBox1);
            this.gbDetalleMovimento.Controls.Add(this.label4);
            this.gbDetalleMovimento.Controls.Add(this.txtNombre);
            this.gbDetalleMovimento.Controls.Add(this.btnCancelar);
            this.gbDetalleMovimento.Controls.Add(this.btnGuardar);
            this.gbDetalleMovimento.Controls.Add(this.txtConfirmar);
            this.gbDetalleMovimento.Controls.Add(this.label3);
            this.gbDetalleMovimento.Controls.Add(this.txtContraseña);
            this.gbDetalleMovimento.Controls.Add(this.label2);
            this.gbDetalleMovimento.Controls.Add(this.btnListar);
            this.gbDetalleMovimento.Controls.Add(this.btnBuscar);
            this.gbDetalleMovimento.Controls.Add(this.btnAgregar);
            this.gbDetalleMovimento.Controls.Add(this.cbxRoles);
            this.gbDetalleMovimento.Controls.Add(this.label1);
            this.gbDetalleMovimento.Controls.Add(this.lblNomUsuario);
            this.gbDetalleMovimento.Controls.Add(this.txtProducto);
            this.gbDetalleMovimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gbDetalleMovimento.Location = new System.Drawing.Point(17, 108);
            this.gbDetalleMovimento.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.gbDetalleMovimento.Name = "gbDetalleMovimento";
            this.gbDetalleMovimento.Padding = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.gbDetalleMovimento.Size = new System.Drawing.Size(832, 613);
            this.gbDetalleMovimento.TabIndex = 40;
            this.gbDetalleMovimento.TabStop = false;
            this.gbDetalleMovimento.Text = "Cuentas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(603, 59);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 33);
            this.button1.TabIndex = 77;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(39, 524);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(268, 29);
            this.checkBox1.TabIndex = 76;
            this.checkBox1.Text = "SUPER ADMINISTRADOR";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 218);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 75;
            this.label4.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(320, 214);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(238, 30);
            this.txtNombre.TabIndex = 74;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(620, 553);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 49);
            this.btnCancelar.TabIndex = 72;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(468, 553);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(140, 49);
            this.btnGuardar.TabIndex = 73;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmar.Location = new System.Drawing.Point(320, 428);
            this.txtConfirmar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.PasswordChar = '*';
            this.txtConfirmar.ReadOnly = true;
            this.txtConfirmar.Size = new System.Drawing.Size(238, 30);
            this.txtConfirmar.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 432);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 25);
            this.label3.TabIndex = 70;
            this.label3.Text = "Confirmar Contraseña";
            // 
            // txtContraseña
            // 
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtContraseña.Location = new System.Drawing.Point(320, 353);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.ReadOnly = true;
            this.txtContraseña.Size = new System.Drawing.Size(238, 30);
            this.txtContraseña.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 357);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 68;
            this.label2.Text = "Contraseña";
            // 
            // btnListar
            // 
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.Image = global::Capa_Presentacion.Properties.Resources.User_Account_50px;
            this.btnListar.Location = new System.Drawing.Point(320, 42);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(81, 71);
            this.btnListar.TabIndex = 66;
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = global::Capa_Presentacion.Properties.Resources.Find_User_Male_50px;
            this.btnBuscar.Location = new System.Drawing.Point(209, 42);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(81, 71);
            this.btnBuscar.TabIndex = 65;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Image = global::Capa_Presentacion.Properties.Resources.Add_User_Male_50px;
            this.btnAgregar.Location = new System.Drawing.Point(99, 42);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(81, 71);
            this.btnAgregar.TabIndex = 64;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cbxRoles
            // 
            this.cbxRoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122)))));
            this.cbxRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRoles.Enabled = false;
            this.cbxRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxRoles.Location = new System.Drawing.Point(320, 276);
            this.cbxRoles.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbxRoles.Name = "cbxRoles";
            this.cbxRoles.Size = new System.Drawing.Size(237, 33);
            this.cbxRoles.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 281);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Rol";
            // 
            // lblNomUsuario
            // 
            this.lblNomUsuario.AutoSize = true;
            this.lblNomUsuario.Location = new System.Drawing.Point(211, 159);
            this.lblNomUsuario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNomUsuario.Name = "lblNomUsuario";
            this.lblNomUsuario.Size = new System.Drawing.Size(79, 25);
            this.lblNomUsuario.TabIndex = 26;
            this.lblNomUsuario.Text = "Usuario";
            // 
            // txtProducto
            // 
            this.txtProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProducto.Location = new System.Drawing.Point(320, 155);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.Size = new System.Drawing.Size(238, 30);
            this.txtProducto.TabIndex = 1;
            // 
            // Notificacion
            // 
            this.Notificacion.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Notificacion.BalloonTipText = "TU HERMANA EN TANGA";
            this.Notificacion.BalloonTipTitle = "TANGA";
            this.Notificacion.ContextMenuStrip = this.contextMenuStrip1;
            this.Notificacion.Text = "Notificacion";
            this.Notificacion.Visible = true;
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Capa_Presentacion.Properties.Resources.fondo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(853, 738);
            this.Controls.Add(this.gbDetalleMovimento);
            this.Controls.Add(this.lblClientes);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUsuario";
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.gbDetalleMovimento.ResumeLayout(false);
            this.gbDetalleMovimento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolTip ttMensajeAyuda;
        private System.Windows.Forms.GroupBox gbDetalleMovimento;
        private System.Windows.Forms.Label lblNomUsuario;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxRoles;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon Notificacion;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
    }
}