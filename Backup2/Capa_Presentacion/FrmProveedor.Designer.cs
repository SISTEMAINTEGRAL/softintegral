namespace Capa_Presentacion
{
    partial class FrmProveedor
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
            this.ttMensajeAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAgregarOcambiar = new System.Windows.Forms.TabPage();
            this.grpboxProveedor = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new XanderUI.XUISuperButton();
            this.btnEditar = new XanderUI.XUISuperButton();
            this.btnGuardar = new XanderUI.XUISuperButton();
            this.btnCancelar = new XanderUI.XUISuperButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CBlocalidad = new System.Windows.Forms.ComboBox();
            this.Cbprovincia = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCuit = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.tabLista = new System.Windows.Forms.TabPage();
            this.dataLista = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabAgregarOcambiar.SuspendLayout();
            this.grpboxProveedor.SuspendLayout();
            this.tabLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).BeginInit();
            this.SuspendLayout();
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // ttMensajeAyuda
            // 
            this.ttMensajeAyuda.AutomaticDelay = 90;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 90;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabAgregarOcambiar);
            this.tabControl1.Controls.Add(this.tabLista);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(45, 25);
            this.tabControl1.Location = new System.Drawing.Point(13, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(998, 691);
            this.tabControl1.TabIndex = 11;
            // 
            // tabAgregarOcambiar
            // 
            this.tabAgregarOcambiar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabAgregarOcambiar.Controls.Add(this.grpboxProveedor);
            this.tabAgregarOcambiar.Location = new System.Drawing.Point(4, 29);
            this.tabAgregarOcambiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAgregarOcambiar.Name = "tabAgregarOcambiar";
            this.tabAgregarOcambiar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabAgregarOcambiar.Size = new System.Drawing.Size(990, 658);
            this.tabAgregarOcambiar.TabIndex = 1;
            this.tabAgregarOcambiar.Text = "Agregar o cambiar";
            this.tabAgregarOcambiar.UseVisualStyleBackColor = true;
            // 
            // grpboxProveedor
            // 
            this.grpboxProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpboxProveedor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpboxProveedor.Controls.Add(this.btnNuevo);
            this.grpboxProveedor.Controls.Add(this.btnEditar);
            this.grpboxProveedor.Controls.Add(this.btnGuardar);
            this.grpboxProveedor.Controls.Add(this.btnCancelar);
            this.grpboxProveedor.Controls.Add(this.label4);
            this.grpboxProveedor.Controls.Add(this.label1);
            this.grpboxProveedor.Controls.Add(this.CBlocalidad);
            this.grpboxProveedor.Controls.Add(this.Cbprovincia);
            this.grpboxProveedor.Controls.Add(this.txtEmail);
            this.grpboxProveedor.Controls.Add(this.lblEmail);
            this.grpboxProveedor.Controls.Add(this.txtTelefono);
            this.grpboxProveedor.Controls.Add(this.lblTel);
            this.grpboxProveedor.Controls.Add(this.txtDireccion);
            this.grpboxProveedor.Controls.Add(this.lblDireccion);
            this.grpboxProveedor.Controls.Add(this.txtDocumento);
            this.grpboxProveedor.Controls.Add(this.txtCuit);
            this.grpboxProveedor.Controls.Add(this.txtRazonSocial);
            this.grpboxProveedor.Controls.Add(this.txtCodigo);
            this.grpboxProveedor.Controls.Add(this.lblCuit);
            this.grpboxProveedor.Controls.Add(this.lblRazonSocial);
            this.grpboxProveedor.Controls.Add(this.lblCodigo);
            this.grpboxProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpboxProveedor.Location = new System.Drawing.Point(8, 7);
            this.grpboxProveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpboxProveedor.Name = "grpboxProveedor";
            this.grpboxProveedor.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpboxProveedor.Size = new System.Drawing.Size(989, 639);
            this.grpboxProveedor.TabIndex = 0;
            this.grpboxProveedor.TabStop = false;
            this.grpboxProveedor.Text = "Proveedores";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(247)))));
            this.btnNuevo.ButtonImage = null;
            this.btnNuevo.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnNuevo.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnNuevo.ButtonText = "Nuevo";
            this.btnNuevo.CornerRadius = 5;
            this.btnNuevo.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnNuevo.HoverBackgroundColor = System.Drawing.Color.IndianRed;
            this.btnNuevo.HoverTextColor = System.Drawing.Color.Yellow;
            this.btnNuevo.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnNuevo.Location = new System.Drawing.Point(7, 574);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnNuevo.SelectedTextColor = System.Drawing.Color.White;
            this.btnNuevo.Size = new System.Drawing.Size(194, 56);
            this.btnNuevo.SuperSelected = false;
            this.btnNuevo.TabIndex = 121;
            this.btnNuevo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnNuevo.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(247)))));
            this.btnEditar.ButtonImage = null;
            this.btnEditar.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnEditar.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnEditar.ButtonText = "Editar";
            this.btnEditar.CornerRadius = 5;
            this.btnEditar.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnEditar.HoverBackgroundColor = System.Drawing.Color.IndianRed;
            this.btnEditar.HoverTextColor = System.Drawing.Color.Yellow;
            this.btnEditar.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnEditar.Location = new System.Drawing.Point(208, 574);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnEditar.SelectedTextColor = System.Drawing.Color.White;
            this.btnEditar.Size = new System.Drawing.Size(194, 56);
            this.btnEditar.SuperSelected = false;
            this.btnEditar.TabIndex = 122;
            this.btnEditar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnEditar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(247)))));
            this.btnGuardar.ButtonImage = null;
            this.btnGuardar.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnGuardar.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnGuardar.ButtonText = "Guardar";
            this.btnGuardar.CornerRadius = 5;
            this.btnGuardar.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnGuardar.HoverBackgroundColor = System.Drawing.Color.IndianRed;
            this.btnGuardar.HoverTextColor = System.Drawing.Color.Yellow;
            this.btnGuardar.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnGuardar.Location = new System.Drawing.Point(493, 574);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnGuardar.SelectedTextColor = System.Drawing.Color.White;
            this.btnGuardar.Size = new System.Drawing.Size(194, 56);
            this.btnGuardar.SuperSelected = false;
            this.btnGuardar.TabIndex = 123;
            this.btnGuardar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnGuardar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(247)))));
            this.btnCancelar.ButtonImage = null;
            this.btnCancelar.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnCancelar.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnCancelar.ButtonText = "Cancelar";
            this.btnCancelar.CornerRadius = 5;
            this.btnCancelar.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCancelar.HoverBackgroundColor = System.Drawing.Color.IndianRed;
            this.btnCancelar.HoverTextColor = System.Drawing.Color.Yellow;
            this.btnCancelar.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnCancelar.Location = new System.Drawing.Point(694, 574);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnCancelar.SelectedTextColor = System.Drawing.Color.White;
            this.btnCancelar.Size = new System.Drawing.Size(194, 56);
            this.btnCancelar.SuperSelected = false;
            this.btnCancelar.TabIndex = 124;
            this.btnCancelar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnCancelar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 420);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 30);
            this.label4.TabIndex = 35;
            this.label4.Text = "Provincia :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 491);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 30);
            this.label1.TabIndex = 34;
            this.label1.Text = "Localidad :";
            // 
            // CBlocalidad
            // 
            this.CBlocalidad.Enabled = false;
            this.CBlocalidad.FormattingEnabled = true;
            this.CBlocalidad.Location = new System.Drawing.Point(351, 483);
            this.CBlocalidad.Name = "CBlocalidad";
            this.CBlocalidad.Size = new System.Drawing.Size(389, 38);
            this.CBlocalidad.TabIndex = 33;
            // 
            // Cbprovincia
            // 
            this.Cbprovincia.Enabled = false;
            this.Cbprovincia.FormattingEnabled = true;
            this.Cbprovincia.Location = new System.Drawing.Point(351, 417);
            this.Cbprovincia.Name = "Cbprovincia";
            this.Cbprovincia.Size = new System.Drawing.Size(389, 38);
            this.Cbprovincia.TabIndex = 32;
            this.Cbprovincia.SelectedValueChanged += new System.EventHandler(this.Cbprovincia_SelectedValueChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(357, 348);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(382, 37);
            this.txtEmail.TabIndex = 19;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(37, 351);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(78, 30);
            this.lblEmail.TabIndex = 22;
            this.lblEmail.Text = "Email";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(357, 284);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(322, 37);
            this.txtTelefono.TabIndex = 18;
            this.txtTelefono.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTelefono_KeyDown);
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(37, 290);
            this.lblTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(117, 30);
            this.lblTel.TabIndex = 20;
            this.lblTel.Text = "Telefono";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(357, 223);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(354, 37);
            this.txtDireccion.TabIndex = 17;
            this.txtDireccion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDireccion_KeyDown);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(37, 228);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(129, 30);
            this.lblDireccion.TabIndex = 18;
            this.lblDireccion.Text = "Dirección";
            // 
            // txtDocumento
            // 
            this.txtDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDocumento.Enabled = false;
            this.txtDocumento.Location = new System.Drawing.Point(774, 166);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(160, 37);
            this.txtDocumento.TabIndex = 16;
            this.txtDocumento.Visible = false;
            this.txtDocumento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDocumento_KeyDown);
            // 
            // txtCuit
            // 
            this.txtCuit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCuit.Enabled = false;
            this.txtCuit.Location = new System.Drawing.Point(357, 164);
            this.txtCuit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(382, 37);
            this.txtCuit.TabIndex = 15;
            this.txtCuit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCuit_KeyDown);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRazonSocial.Enabled = false;
            this.txtRazonSocial.Location = new System.Drawing.Point(357, 103);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(382, 37);
            this.txtRazonSocial.TabIndex = 14;
            this.txtRazonSocial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRazonSocial_KeyDown);
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Location = new System.Drawing.Point(357, 43);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(382, 37);
            this.txtCodigo.TabIndex = 13;
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(37, 166);
            this.lblCuit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(199, 30);
            this.lblCuit.TabIndex = 12;
            this.lblCuit.Text = "Cuit / Cuil / DNI";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(37, 105);
            this.lblRazonSocial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(291, 30);
            this.lblRazonSocial.TabIndex = 11;
            this.lblRazonSocial.Text = "Nombre o Razon Social";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(37, 43);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(103, 30);
            this.lblCodigo.TabIndex = 10;
            this.lblCodigo.Text = "Código";
            // 
            // tabLista
            // 
            this.tabLista.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabLista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabLista.Controls.Add(this.dataLista);
            this.tabLista.Controls.Add(this.lblTotal);
            this.tabLista.Controls.Add(this.chkEliminar);
            this.tabLista.Controls.Add(this.txtNombre);
            this.tabLista.Controls.Add(this.lblNombre);
            this.tabLista.Controls.Add(this.btnImprimir);
            this.tabLista.Controls.Add(this.btnEliminar);
            this.tabLista.Controls.Add(this.btnBuscar);
            this.tabLista.Location = new System.Drawing.Point(4, 29);
            this.tabLista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabLista.Name = "tabLista";
            this.tabLista.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabLista.Size = new System.Drawing.Size(960, 653);
            this.tabLista.TabIndex = 0;
            this.tabLista.Text = "Lista";
            // 
            // dataLista
            // 
            this.dataLista.AllowUserToAddRows = false;
            this.dataLista.AllowUserToDeleteRows = false;
            this.dataLista.AllowUserToOrderColumns = true;
            this.dataLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataLista.Location = new System.Drawing.Point(15, 143);
            this.dataLista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataLista.MultiSelect = false;
            this.dataLista.Name = "dataLista";
            this.dataLista.ReadOnly = true;
            this.dataLista.RowHeadersWidth = 51;
            this.dataLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataLista.Size = new System.Drawing.Size(919, 550);
            this.dataLista.TabIndex = 11;
            this.dataLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLista_CellClick);
            this.dataLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLista_CellContentClick);
            this.dataLista.DoubleClick += new System.EventHandler(this.dataLista_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 112;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(603, 95);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(26, 30);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "0";
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkEliminar.Location = new System.Drawing.Point(27, 97);
            this.chkEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Size = new System.Drawing.Size(203, 34);
            this.chkEliminar.TabIndex = 9;
            this.chkEliminar.Text = "Eliminar Varios";
            this.chkEliminar.UseVisualStyleBackColor = true;
            this.chkEliminar.CheckedChanged += new System.EventHandler(this.chkEliminar_CheckedChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(27, 46);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(334, 37);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(25, 7);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(298, 30);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre o Razon Social ";
            // 
            // btnImprimir
            // 
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(723, 39);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(140, 49);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(559, 39);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(140, 49);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(395, 39);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(140, 49);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FrmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1040, 822);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.FrmProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabAgregarOcambiar.ResumeLayout(false);
            this.grpboxProveedor.ResumeLayout(false);
            this.grpboxProveedor.PerformLayout();
            this.tabLista.ResumeLayout(false);
            this.tabLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.ToolTip ttMensajeAyuda;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLista;
        private System.Windows.Forms.DataGridView dataLista;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TabPage tabAgregarOcambiar;
        private System.Windows.Forms.GroupBox grpboxProveedor;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBlocalidad;
        private System.Windows.Forms.ComboBox Cbprovincia;
        private XanderUI.XUISuperButton btnNuevo;
        private XanderUI.XUISuperButton btnEditar;
        private XanderUI.XUISuperButton btnGuardar;
        private XanderUI.XUISuperButton btnCancelar;
    }
}