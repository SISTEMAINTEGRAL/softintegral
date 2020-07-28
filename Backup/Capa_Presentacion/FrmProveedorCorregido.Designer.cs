namespace Capa_Presentacion
{
    partial class FrmProveedorCorregido
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
            this.panelHorizontal = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lblSistemaVenta = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLista = new System.Windows.Forms.TabPage();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.dataLista = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tabAgregarOcambiar = new System.Windows.Forms.TabPage();
            this.xuiCustomGroupbox1 = new XanderUI.XUICustomGroupbox();
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
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).BeginInit();
            this.tabAgregarOcambiar.SuspendLayout();
            this.xuiCustomGroupbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHorizontal
            // 
            this.panelHorizontal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.panelHorizontal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHorizontal.Controls.Add(this.label16);
            this.panelHorizontal.Controls.Add(this.btnMaximizar);
            this.panelHorizontal.Controls.Add(this.btnRestaurar);
            this.panelHorizontal.Controls.Add(this.btnMinimizar);
            this.panelHorizontal.Controls.Add(this.btnCerrar);
            this.panelHorizontal.Controls.Add(this.lblSistemaVenta);
            this.panelHorizontal.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHorizontal.Location = new System.Drawing.Point(0, 0);
            this.panelHorizontal.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.panelHorizontal.Name = "panelHorizontal";
            this.panelHorizontal.Size = new System.Drawing.Size(1098, 37);
            this.panelHorizontal.TabIndex = 68;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(-1, -1);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(213, 36);
            this.label16.TabIndex = 7;
            this.label16.Text = "PROVEEDORES";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackgroundImage = global::Capa_Presentacion.Properties.Resources.maximize_Checkbox_16px;
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMaximizar.Location = new System.Drawing.Point(1026, 3);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(22, 25);
            this.btnMaximizar.TabIndex = 5;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Visible = false;
            this.btnMaximizar.MouseLeave += new System.EventHandler(this.btnMaximizar_MouseLeave);
            this.btnMaximizar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnMaximizar_MouseMove);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.BackgroundImage = global::Capa_Presentacion.Properties.Resources.Restore_Window_20px;
            this.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRestaurar.Location = new System.Drawing.Point(1026, 3);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(22, 25);
            this.btnRestaurar.TabIndex = 2;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.MouseLeave += new System.EventHandler(this.btnRestaurar_MouseLeave);
            this.btnRestaurar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnRestaurar_MouseMove);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackgroundImage = global::Capa_Presentacion.Properties.Resources.Minus_20px;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimizar.Location = new System.Drawing.Point(992, 3);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(22, 25);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Visible = false;
            this.btnMinimizar.MouseLeave += new System.EventHandler(this.btnMinimizar_MouseLeave);
            this.btnMinimizar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnMinimizar_MouseMove);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackgroundImage = global::Capa_Presentacion.Properties.Resources.Delete_20px;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCerrar.ErrorImage = null;
            this.btnCerrar.Location = new System.Drawing.Point(1060, 3);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(22, 25);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            this.btnCerrar.MouseLeave += new System.EventHandler(this.btnCerrar_MouseLeave);
            this.btnCerrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCerrar_MouseMove);
            // 
            // lblSistemaVenta
            // 
            this.lblSistemaVenta.Location = new System.Drawing.Point(0, 0);
            this.lblSistemaVenta.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSistemaVenta.Name = "lblSistemaVenta";
            this.lblSistemaVenta.Size = new System.Drawing.Size(233, 51);
            this.lblSistemaVenta.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLista);
            this.tabControl1.Controls.Add(this.tabAgregarOcambiar);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 37);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1098, 696);
            this.tabControl1.TabIndex = 69;
            // 
            // tabLista
            // 
            this.tabLista.Controls.Add(this.chkEliminar);
            this.tabLista.Controls.Add(this.dataLista);
            this.tabLista.Controls.Add(this.txtNombre);
            this.tabLista.Controls.Add(this.lblNombre);
            this.tabLista.Location = new System.Drawing.Point(4, 38);
            this.tabLista.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabLista.Name = "tabLista";
            this.tabLista.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabLista.Size = new System.Drawing.Size(1090, 654);
            this.tabLista.TabIndex = 0;
            this.tabLista.Text = "Lista";
            this.tabLista.UseVisualStyleBackColor = true;
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkEliminar.Location = new System.Drawing.Point(621, 41);
            this.chkEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Size = new System.Drawing.Size(196, 33);
            this.chkEliminar.TabIndex = 13;
            this.chkEliminar.Text = "Eliminar Varios";
            this.chkEliminar.UseVisualStyleBackColor = true;
            this.chkEliminar.Visible = false;
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
            this.dataLista.Location = new System.Drawing.Point(9, 121);
            this.dataLista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataLista.MultiSelect = false;
            this.dataLista.Name = "dataLista";
            this.dataLista.ReadOnly = true;
            this.dataLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataLista.Size = new System.Drawing.Size(1070, 524);
            this.dataLista.TabIndex = 12;
            this.dataLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLista_CellContentClick);
            this.dataLista.DoubleClick += new System.EventHandler(this.dataLista_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 107;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(9, 69);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(376, 42);
            this.txtNombre.TabIndex = 10;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombre_KeyDown);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(7, 20);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(354, 36);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre o Razon Social ";
            // 
            // tabAgregarOcambiar
            // 
            this.tabAgregarOcambiar.Controls.Add(this.xuiCustomGroupbox1);
            this.tabAgregarOcambiar.Location = new System.Drawing.Point(4, 38);
            this.tabAgregarOcambiar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabAgregarOcambiar.Name = "tabAgregarOcambiar";
            this.tabAgregarOcambiar.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabAgregarOcambiar.Size = new System.Drawing.Size(1090, 654);
            this.tabAgregarOcambiar.TabIndex = 1;
            this.tabAgregarOcambiar.Text = "Agregar o Modificar";
            this.tabAgregarOcambiar.UseVisualStyleBackColor = true;
            // 
            // xuiCustomGroupbox1
            // 
            this.xuiCustomGroupbox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xuiCustomGroupbox1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.xuiCustomGroupbox1.BorderWidth = 1;
            this.xuiCustomGroupbox1.Controls.Add(this.btnNuevo);
            this.xuiCustomGroupbox1.Controls.Add(this.btnEditar);
            this.xuiCustomGroupbox1.Controls.Add(this.btnGuardar);
            this.xuiCustomGroupbox1.Controls.Add(this.btnCancelar);
            this.xuiCustomGroupbox1.Controls.Add(this.label4);
            this.xuiCustomGroupbox1.Controls.Add(this.label1);
            this.xuiCustomGroupbox1.Controls.Add(this.CBlocalidad);
            this.xuiCustomGroupbox1.Controls.Add(this.Cbprovincia);
            this.xuiCustomGroupbox1.Controls.Add(this.txtEmail);
            this.xuiCustomGroupbox1.Controls.Add(this.lblEmail);
            this.xuiCustomGroupbox1.Controls.Add(this.txtTelefono);
            this.xuiCustomGroupbox1.Controls.Add(this.lblTel);
            this.xuiCustomGroupbox1.Controls.Add(this.txtDireccion);
            this.xuiCustomGroupbox1.Controls.Add(this.lblDireccion);
            this.xuiCustomGroupbox1.Controls.Add(this.txtDocumento);
            this.xuiCustomGroupbox1.Controls.Add(this.txtCuit);
            this.xuiCustomGroupbox1.Controls.Add(this.txtRazonSocial);
            this.xuiCustomGroupbox1.Controls.Add(this.txtCodigo);
            this.xuiCustomGroupbox1.Controls.Add(this.lblCuit);
            this.xuiCustomGroupbox1.Controls.Add(this.lblRazonSocial);
            this.xuiCustomGroupbox1.Controls.Add(this.lblCodigo);
            this.xuiCustomGroupbox1.Location = new System.Drawing.Point(5, 9);
            this.xuiCustomGroupbox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.xuiCustomGroupbox1.Name = "xuiCustomGroupbox1";
            this.xuiCustomGroupbox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.xuiCustomGroupbox1.ShowText = true;
            this.xuiCustomGroupbox1.Size = new System.Drawing.Size(1078, 637);
            this.xuiCustomGroupbox1.TabIndex = 0;
            this.xuiCustomGroupbox1.TabStop = false;
            this.xuiCustomGroupbox1.Text = "Proveedores";
            this.xuiCustomGroupbox1.TextColor = System.Drawing.Color.DodgerBlue;
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
            this.btnNuevo.Location = new System.Drawing.Point(9, 562);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnNuevo.SelectedTextColor = System.Drawing.Color.White;
            this.btnNuevo.Size = new System.Drawing.Size(226, 64);
            this.btnNuevo.SuperSelected = false;
            this.btnNuevo.TabIndex = 117;
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
            this.btnEditar.Location = new System.Drawing.Point(243, 562);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnEditar.SelectedTextColor = System.Drawing.Color.White;
            this.btnEditar.Size = new System.Drawing.Size(226, 64);
            this.btnEditar.SuperSelected = false;
            this.btnEditar.TabIndex = 118;
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
            this.btnGuardar.Location = new System.Drawing.Point(614, 565);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnGuardar.SelectedTextColor = System.Drawing.Color.White;
            this.btnGuardar.Size = new System.Drawing.Size(226, 64);
            this.btnGuardar.SuperSelected = false;
            this.btnGuardar.TabIndex = 119;
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
            this.btnCancelar.Location = new System.Drawing.Point(848, 565);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnCancelar.SelectedTextColor = System.Drawing.Color.White;
            this.btnCancelar.Size = new System.Drawing.Size(226, 64);
            this.btnCancelar.SuperSelected = false;
            this.btnCancelar.TabIndex = 120;
            this.btnCancelar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnCancelar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 344);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 29);
            this.label4.TabIndex = 39;
            this.label4.Text = "Provincia :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 407);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 38;
            this.label1.Text = "Localidad :";
            // 
            // CBlocalidad
            // 
            this.CBlocalidad.Enabled = false;
            this.CBlocalidad.FormattingEnabled = true;
            this.CBlocalidad.Location = new System.Drawing.Point(367, 397);
            this.CBlocalidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CBlocalidad.Name = "CBlocalidad";
            this.CBlocalidad.Size = new System.Drawing.Size(437, 37);
            this.CBlocalidad.TabIndex = 37;
            // 
            // Cbprovincia
            // 
            this.Cbprovincia.Enabled = false;
            this.Cbprovincia.FormattingEnabled = true;
            this.Cbprovincia.Location = new System.Drawing.Point(367, 336);
            this.Cbprovincia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cbprovincia.Name = "Cbprovincia";
            this.Cbprovincia.Size = new System.Drawing.Size(437, 37);
            this.Cbprovincia.TabIndex = 36;
            this.Cbprovincia.SelectedValueChanged += new System.EventHandler(this.Cbprovincia_SelectedValueChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(374, 278);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(430, 35);
            this.txtEmail.TabIndex = 33;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(14, 282);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(74, 29);
            this.lblEmail.TabIndex = 35;
            this.lblEmail.Text = "Email";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(374, 230);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(362, 35);
            this.txtTelefono.TabIndex = 31;
            this.txtTelefono.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTelefono_KeyDown);
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(14, 232);
            this.lblTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(110, 29);
            this.lblTel.TabIndex = 34;
            this.lblTel.Text = "Telefono";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(374, 181);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(398, 35);
            this.txtDireccion.TabIndex = 30;
            this.txtDireccion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDireccion_KeyDown);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(14, 187);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(115, 29);
            this.lblDireccion.TabIndex = 32;
            this.lblDireccion.Text = "Dirección";
            // 
            // txtDocumento
            // 
            this.txtDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDocumento.Enabled = false;
            this.txtDocumento.Location = new System.Drawing.Point(843, 138);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(180, 35);
            this.txtDocumento.TabIndex = 29;
            this.txtDocumento.Visible = false;
            this.txtDocumento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDocumento_KeyDown);
            // 
            // txtCuit
            // 
            this.txtCuit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCuit.Enabled = false;
            this.txtCuit.Location = new System.Drawing.Point(374, 135);
            this.txtCuit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(430, 35);
            this.txtCuit.TabIndex = 28;
            this.txtCuit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCuit_KeyDown);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRazonSocial.Enabled = false;
            this.txtRazonSocial.Location = new System.Drawing.Point(374, 89);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(430, 35);
            this.txtRazonSocial.TabIndex = 27;
            this.txtRazonSocial.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtRazonSocial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRazonSocial_KeyDown);
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Location = new System.Drawing.Point(374, 41);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(430, 35);
            this.txtCodigo.TabIndex = 26;
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(14, 138);
            this.lblCuit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(176, 29);
            this.lblCuit.TabIndex = 25;
            this.lblCuit.Text = "Cuit / Cuil / DNI";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(14, 91);
            this.lblRazonSocial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(268, 29);
            this.lblRazonSocial.TabIndex = 24;
            this.lblRazonSocial.Text = "Nombre o Razon Social";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(14, 41);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(92, 29);
            this.lblCodigo.TabIndex = 23;
            this.lblCodigo.Text = "Código";
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // FrmProveedorCorregido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 733);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelHorizontal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmProveedorCorregido";
            this.Text = "FrmProveedorCorregido";
            this.Load += new System.EventHandler(this.FrmProveedor_Load);
            this.panelHorizontal.ResumeLayout(false);
            this.panelHorizontal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabLista.ResumeLayout(false);
            this.tabLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).EndInit();
            this.tabAgregarOcambiar.ResumeLayout(false);
            this.xuiCustomGroupbox1.ResumeLayout(false);
            this.xuiCustomGroupbox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHorizontal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label lblSistemaVenta;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLista;
        private System.Windows.Forms.TabPage tabAgregarOcambiar;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox1;
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
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dataLista;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.CheckBox chkEliminar;
    }
}