namespace Capa_Presentacion
{
    partial class FrmTarjeta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ttMensajeAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.tabLista = new System.Windows.Forms.TabPage();
            this.dataLista = new Guna.UI.WinForms.GunaDataGridView();
            this.DEliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.TxtMarca = new System.Windows.Forms.TextBox();
            this.lblNomArticulo = new System.Windows.Forms.Label();
            this.xuiCustomGroupbox2 = new XanderUI.XUICustomGroupbox();
            this.DGCuotaTarjeta = new System.Windows.Forms.DataGridView();
            this.menucodarticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menunombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new XanderUI.XUISuperButton();
            this.btnCancelar = new XanderUI.XUISuperButton();
            this.btnNuevo = new XanderUI.XUISuperButton();
            this.btnGuardar = new XanderUI.XUISuperButton();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtEntidadEmisora = new System.Windows.Forms.TextBox();
            this.tabConfiguracion = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelHorizontal = new System.Windows.Forms.Panel();
            this.lblSistemaVentas = new System.Windows.Forms.Label();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lblSistemaVenta = new System.Windows.Forms.Label();
            this.tabLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).BeginInit();
            this.xuiCustomGroupbox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGCuotaTarjeta)).BeginInit();
            this.tabConfiguracion.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.panelHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // ttMensajeAyuda
            // 
            this.ttMensajeAyuda.AutomaticDelay = 90;
            // 
            // tabLista
            // 
            this.tabLista.BackColor = System.Drawing.Color.White;
            this.tabLista.Controls.Add(this.dataLista);
            this.tabLista.Controls.Add(this.label3);
            this.tabLista.Controls.Add(this.txtNombre);
            this.tabLista.Location = new System.Drawing.Point(4, 29);
            this.tabLista.Margin = new System.Windows.Forms.Padding(4);
            this.tabLista.Name = "tabLista";
            this.tabLista.Padding = new System.Windows.Forms.Padding(4);
            this.tabLista.Size = new System.Drawing.Size(1426, 857);
            this.tabLista.TabIndex = 0;
            this.tabLista.Text = "Lista";
            this.tabLista.Click += new System.EventHandler(this.tabLista_Click);
            // 
            // dataLista
            // 
            this.dataLista.AllowUserToAddRows = false;
            this.dataLista.AllowUserToDeleteRows = false;
            this.dataLista.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataLista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataLista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataLista.BackgroundColor = System.Drawing.Color.White;
            this.dataLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataLista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataLista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataLista.ColumnHeadersHeight = 38;
            this.dataLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DEliminar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataLista.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataLista.EnableHeadersVisualStyles = false;
            this.dataLista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataLista.Location = new System.Drawing.Point(7, 76);
            this.dataLista.MultiSelect = false;
            this.dataLista.Name = "dataLista";
            this.dataLista.ReadOnly = true;
            this.dataLista.RowHeadersVisible = false;
            this.dataLista.RowTemplate.Height = 24;
            this.dataLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataLista.Size = new System.Drawing.Size(1392, 578);
            this.dataLista.StandardTab = true;
            this.dataLista.TabIndex = 108;
            this.dataLista.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dataLista.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataLista.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataLista.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataLista.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataLista.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataLista.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataLista.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataLista.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataLista.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataLista.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLista.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataLista.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataLista.ThemeStyle.HeaderStyle.Height = 38;
            this.dataLista.ThemeStyle.ReadOnly = true;
            this.dataLista.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataLista.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataLista.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLista.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataLista.ThemeStyle.RowsStyle.Height = 24;
            this.dataLista.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataLista.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLista_CellClick);
            this.dataLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLista_CellContentClick);
            this.dataLista.Click += new System.EventHandler(this.dataLista_Click_1);
            this.dataLista.DoubleClick += new System.EventHandler(this.dataLista_DoubleClick);
            // 
            // DEliminar
            // 
            this.DEliminar.HeaderText = "Eliminar";
            this.DEliminar.Name = "DEliminar";
            this.DEliminar.ReadOnly = true;
            this.DEliminar.Width = 112;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 30);
            this.label3.TabIndex = 36;
            this.label3.Text = "Buscar :";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(128, 32);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(333, 37);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombre_KeyDown);
            // 
            // TxtMarca
            // 
            this.TxtMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtMarca.Enabled = false;
            this.TxtMarca.Location = new System.Drawing.Point(249, 111);
            this.TxtMarca.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMarca.MaxLength = 100;
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.Size = new System.Drawing.Size(293, 37);
            this.TxtMarca.TabIndex = 15;
            this.TxtMarca.TextChanged += new System.EventHandler(this.txtNombreConfig_TextChanged);
            // 
            // lblNomArticulo
            // 
            this.lblNomArticulo.AutoSize = true;
            this.lblNomArticulo.Location = new System.Drawing.Point(14, 120);
            this.lblNomArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomArticulo.Name = "lblNomArticulo";
            this.lblNomArticulo.Size = new System.Drawing.Size(91, 30);
            this.lblNomArticulo.TabIndex = 11;
            this.lblNomArticulo.Text = "Marca";
            // 
            // xuiCustomGroupbox2
            // 
            this.xuiCustomGroupbox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xuiCustomGroupbox2.BorderColor = System.Drawing.Color.DodgerBlue;
            this.xuiCustomGroupbox2.BorderWidth = 1;
            this.xuiCustomGroupbox2.Controls.Add(this.DGCuotaTarjeta);
            this.xuiCustomGroupbox2.Controls.Add(this.btnEditar);
            this.xuiCustomGroupbox2.Controls.Add(this.btnCancelar);
            this.xuiCustomGroupbox2.Controls.Add(this.btnNuevo);
            this.xuiCustomGroupbox2.Controls.Add(this.btnGuardar);
            this.xuiCustomGroupbox2.Controls.Add(this.label1);
            this.xuiCustomGroupbox2.Controls.Add(this.lblNomArticulo);
            this.xuiCustomGroupbox2.Controls.Add(this.TxtEntidadEmisora);
            this.xuiCustomGroupbox2.Controls.Add(this.TxtMarca);
            this.xuiCustomGroupbox2.Location = new System.Drawing.Point(16, 17);
            this.xuiCustomGroupbox2.Name = "xuiCustomGroupbox2";
            this.xuiCustomGroupbox2.ShowText = true;
            this.xuiCustomGroupbox2.Size = new System.Drawing.Size(1403, 816);
            this.xuiCustomGroupbox2.TabIndex = 126;
            this.xuiCustomGroupbox2.TabStop = false;
            this.xuiCustomGroupbox2.Text = "Tarjeta";
            this.xuiCustomGroupbox2.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // DGCuotaTarjeta
            // 
            this.DGCuotaTarjeta.AllowUserToAddRows = false;
            this.DGCuotaTarjeta.AllowUserToDeleteRows = false;
            this.DGCuotaTarjeta.AllowUserToOrderColumns = true;
            this.DGCuotaTarjeta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGCuotaTarjeta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGCuotaTarjeta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGCuotaTarjeta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGCuotaTarjeta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGCuotaTarjeta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGCuotaTarjeta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menucodarticulo,
            this.menunombre});
            this.DGCuotaTarjeta.EnableHeadersVisualStyles = false;
            this.DGCuotaTarjeta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGCuotaTarjeta.Location = new System.Drawing.Point(597, 20);
            this.DGCuotaTarjeta.Margin = new System.Windows.Forms.Padding(8, 14, 8, 14);
            this.DGCuotaTarjeta.MultiSelect = false;
            this.DGCuotaTarjeta.Name = "DGCuotaTarjeta";
            this.DGCuotaTarjeta.RowHeadersWidth = 38;
            this.DGCuotaTarjeta.Size = new System.Drawing.Size(776, 647);
            this.DGCuotaTarjeta.TabIndex = 127;
            // 
            // menucodarticulo
            // 
            this.menucodarticulo.HeaderText = "Cuota";
            this.menucodarticulo.Name = "menucodarticulo";
            this.menucodarticulo.ReadOnly = true;
            // 
            // menunombre
            // 
            this.menunombre.HeaderText = "Interes";
            this.menunombre.Name = "menunombre";
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
            this.btnEditar.Location = new System.Drawing.Point(234, 726);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnEditar.SelectedTextColor = System.Drawing.Color.White;
            this.btnEditar.Size = new System.Drawing.Size(194, 56);
            this.btnEditar.SuperSelected = false;
            this.btnEditar.TabIndex = 111;
            this.btnEditar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnEditar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.btnCancelar.Location = new System.Drawing.Point(644, 726);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnCancelar.SelectedTextColor = System.Drawing.Color.White;
            this.btnCancelar.Size = new System.Drawing.Size(194, 56);
            this.btnCancelar.SuperSelected = false;
            this.btnCancelar.TabIndex = 111;
            this.btnCancelar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnCancelar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            this.btnNuevo.Location = new System.Drawing.Point(32, 726);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnNuevo.SelectedTextColor = System.Drawing.Color.White;
            this.btnNuevo.Size = new System.Drawing.Size(194, 56);
            this.btnNuevo.SuperSelected = false;
            this.btnNuevo.TabIndex = 111;
            this.btnNuevo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnNuevo.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.btnGuardar.Location = new System.Drawing.Point(436, 726);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnGuardar.SelectedTextColor = System.Drawing.Color.White;
            this.btnGuardar.Size = new System.Drawing.Size(194, 56);
            this.btnGuardar.SuperSelected = false;
            this.btnGuardar.TabIndex = 111;
            this.btnGuardar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnGuardar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 211);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Entidad Emisora";
            // 
            // TxtEntidadEmisora
            // 
            this.TxtEntidadEmisora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtEntidadEmisora.Enabled = false;
            this.TxtEntidadEmisora.Location = new System.Drawing.Point(249, 204);
            this.TxtEntidadEmisora.Margin = new System.Windows.Forms.Padding(4);
            this.TxtEntidadEmisora.MaxLength = 100;
            this.TxtEntidadEmisora.Name = "TxtEntidadEmisora";
            this.TxtEntidadEmisora.Size = new System.Drawing.Size(293, 37);
            this.TxtEntidadEmisora.TabIndex = 15;
            this.TxtEntidadEmisora.TextChanged += new System.EventHandler(this.txtNombreConfig_TextChanged);
            // 
            // tabConfiguracion
            // 
            this.tabConfiguracion.BackColor = System.Drawing.Color.White;
            this.tabConfiguracion.Controls.Add(this.xuiCustomGroupbox2);
            this.tabConfiguracion.Location = new System.Drawing.Point(4, 29);
            this.tabConfiguracion.Margin = new System.Windows.Forms.Padding(4);
            this.tabConfiguracion.Name = "tabConfiguracion";
            this.tabConfiguracion.Padding = new System.Windows.Forms.Padding(4);
            this.tabConfiguracion.Size = new System.Drawing.Size(1426, 857);
            this.tabConfiguracion.TabIndex = 1;
            this.tabConfiguracion.Text = "Agregar o Cambiar";
            this.tabConfiguracion.Click += new System.EventHandler(this.tabConfiguracion_Click);
            this.tabConfiguracion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabConfiguracion_MouseClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabLista);
            this.tabControl1.Controls.Add(this.tabConfiguracion);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(45, 25);
            this.tabControl1.Location = new System.Drawing.Point(13, 53);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1434, 890);
            this.tabControl1.TabIndex = 10;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected_1);
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panelHorizontal
            // 
            this.panelHorizontal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.panelHorizontal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHorizontal.Controls.Add(this.lblSistemaVentas);
            this.panelHorizontal.Controls.Add(this.btnMaximizar);
            this.panelHorizontal.Controls.Add(this.btnRestaurar);
            this.panelHorizontal.Controls.Add(this.btnMinimizar);
            this.panelHorizontal.Controls.Add(this.btnCerrar);
            this.panelHorizontal.Controls.Add(this.lblSistemaVenta);
            this.panelHorizontal.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHorizontal.Location = new System.Drawing.Point(0, 0);
            this.panelHorizontal.Margin = new System.Windows.Forms.Padding(4);
            this.panelHorizontal.Name = "panelHorizontal";
            this.panelHorizontal.Size = new System.Drawing.Size(1455, 45);
            this.panelHorizontal.TabIndex = 64;
            this.panelHorizontal.DoubleClick += new System.EventHandler(this.panelHorizontal_DoubleClick);
            this.panelHorizontal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHorizontal_MouseMove);
            // 
            // lblSistemaVentas
            // 
            this.lblSistemaVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSistemaVentas.AutoSize = true;
            this.lblSistemaVentas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistemaVentas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSistemaVentas.Location = new System.Drawing.Point(15, 6);
            this.lblSistemaVentas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSistemaVentas.Name = "lblSistemaVentas";
            this.lblSistemaVentas.Size = new System.Drawing.Size(90, 28);
            this.lblSistemaVentas.TabIndex = 7;
            this.lblSistemaVentas.Text = "Tarjeta";
            this.lblSistemaVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackgroundImage = global::Capa_Presentacion.Properties.Resources.maximize_Checkbox_16px;
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMaximizar.Location = new System.Drawing.Point(1376, 6);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(29, 31);
            this.btnMaximizar.TabIndex = 5;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            this.btnMaximizar.MouseLeave += new System.EventHandler(this.btnMaximizar_MouseLeave);
            this.btnMaximizar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnMaximizar_MouseMove);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.BackgroundImage = global::Capa_Presentacion.Properties.Resources.Restore_Window_20px;
            this.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRestaurar.Location = new System.Drawing.Point(1376, 6);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(29, 31);
            this.btnRestaurar.TabIndex = 2;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            this.btnRestaurar.MouseLeave += new System.EventHandler(this.btnRestaurar_MouseLeave);
            this.btnRestaurar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnRestaurar_MouseMove);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackgroundImage = global::Capa_Presentacion.Properties.Resources.Minus_20px;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimizar.Location = new System.Drawing.Point(1332, 6);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(29, 31);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            this.btnMinimizar.MouseLeave += new System.EventHandler(this.btnMinimizar_MouseLeave);
            this.btnMinimizar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnMinimizar_MouseMove);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackgroundImage = global::Capa_Presentacion.Properties.Resources.Delete_20px;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCerrar.ErrorImage = null;
            this.btnCerrar.Location = new System.Drawing.Point(1420, 6);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(29, 31);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            this.btnCerrar.MouseLeave += new System.EventHandler(this.btnCerrar_MouseLeave);
            this.btnCerrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCerrar_MouseMove);
            // 
            // lblSistemaVenta
            // 
            this.lblSistemaVenta.Location = new System.Drawing.Point(0, 0);
            this.lblSistemaVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSistemaVenta.Name = "lblSistemaVenta";
            this.lblSistemaVenta.Size = new System.Drawing.Size(133, 28);
            this.lblSistemaVenta.TabIndex = 6;
            // 
            // FrmTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1455, 1028);
            this.Controls.Add(this.panelHorizontal);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "FrmTarjeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmArticulos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmArticulos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmArticulos_KeyDown);
            this.tabLista.ResumeLayout(false);
            this.tabLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).EndInit();
            this.xuiCustomGroupbox2.ResumeLayout(false);
            this.xuiCustomGroupbox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGCuotaTarjeta)).EndInit();
            this.tabConfiguracion.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.panelHorizontal.ResumeLayout(false);
            this.panelHorizontal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip ttMensajeAyuda;
        private System.Windows.Forms.TabPage tabLista;
        private System.Windows.Forms.TextBox TxtMarca;
        private System.Windows.Forms.Label lblNomArticulo;
        private System.Windows.Forms.TabPage tabConfiguracion;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panelHorizontal;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.Label lblSistemaVenta;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblSistemaVentas;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaDataGridView dataLista;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DEliminar;
        private XanderUI.XUISuperButton btnCancelar;
        private XanderUI.XUISuperButton btnGuardar;
        private XanderUI.XUISuperButton btnEditar;
        private XanderUI.XUISuperButton btnNuevo;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox2;
        private System.Windows.Forms.DataGridView DGCuotaTarjeta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtEntidadEmisora;
        private System.Windows.Forms.DataGridViewTextBoxColumn menucodarticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn menunombre;
    }
}