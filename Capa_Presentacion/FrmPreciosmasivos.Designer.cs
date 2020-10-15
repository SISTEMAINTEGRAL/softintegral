namespace Capa_Presentacion
{
    partial class FrmPreciosmasivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPreciosmasivos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHorizontal = new System.Windows.Forms.Panel();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lblSistemaVenta = new System.Windows.Forms.Label();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbcampoamodificar = new System.Windows.Forms.ComboBox();
            this.DGVenta = new System.Windows.Forms.DataGridView();
            this.menucodarticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menunombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menudescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menupreciocompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menutilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuflete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuprecioventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilidadpormayor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preciopormayor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilidadpormayor2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciopormayor2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utilidadoferta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_oferta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Menudelete = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtcambioDv = new System.Windows.Forms.TextBox();
            this.xuiCustomGroupbox1 = new XanderUI.XUICustomGroupbox();
            this.BtnImproducto = new XanderUI.XUISuperButton();
            this.BtnExportar = new XanderUI.XUISuperButton();
            this.BtnImprimir = new XanderUI.XUISuperButton();
            this.btnAplicar = new XanderUI.XUISuperButton();
            this.BtnCambiar = new XanderUI.XUISuperButton();
            this.btnLimpiarG = new XanderUI.XUISuperButton();
            this.btnCliente = new XanderUI.XUISuperButton();
            this.BtnExportarbalanza = new XanderUI.XUISuperButton();
            this.panelHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVenta)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.xuiCustomGroupbox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHorizontal
            // 
            this.panelHorizontal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.panelHorizontal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHorizontal.Controls.Add(this.btnMaximizar);
            this.panelHorizontal.Controls.Add(this.btnRestaurar);
            this.panelHorizontal.Controls.Add(this.btnMinimizar);
            this.panelHorizontal.Controls.Add(this.btnCerrar);
            this.panelHorizontal.Controls.Add(this.lblSistemaVenta);
            this.panelHorizontal.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHorizontal.Location = new System.Drawing.Point(0, 0);
            this.panelHorizontal.Margin = new System.Windows.Forms.Padding(6);
            this.panelHorizontal.Name = "panelHorizontal";
            this.panelHorizontal.Size = new System.Drawing.Size(1284, 37);
            this.panelHorizontal.TabIndex = 65;
            this.panelHorizontal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHorizontal_MouseMove);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.BackgroundImage")));
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMaximizar.Location = new System.Drawing.Point(1222, 4);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(6);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(22, 25);
            this.btnMaximizar.TabIndex = 5;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            this.btnMaximizar.MouseLeave += new System.EventHandler(this.btnMaximizar_MouseLeave);
            this.btnMaximizar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnMaximizar_MouseMove);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.BackgroundImage")));
            this.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRestaurar.Location = new System.Drawing.Point(1222, 4);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(6);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(22, 25);
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
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimizar.Location = new System.Drawing.Point(1192, 4);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(6);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(22, 25);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            this.btnMinimizar.MouseLeave += new System.EventHandler(this.btnMinimizar_MouseLeave);
            this.btnMinimizar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnMinimizar_MouseMove);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCerrar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.ErrorImage")));
            this.btnCerrar.Location = new System.Drawing.Point(1252, 4);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(6);
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
            this.lblSistemaVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSistemaVenta.AutoSize = true;
            this.lblSistemaVenta.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistemaVenta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSistemaVenta.Location = new System.Drawing.Point(6, 9);
            this.lblSistemaVenta.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSistemaVenta.Name = "lblSistemaVenta";
            this.lblSistemaVenta.Size = new System.Drawing.Size(224, 28);
            this.lblSistemaVenta.TabIndex = 3;
            this.lblSistemaVenta.Text = "PRECIOS MASIVOS";
            this.lblSistemaVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPorcentaje.Location = new System.Drawing.Point(347, 106);
            this.txtPorcentaje.Margin = new System.Windows.Forms.Padding(6);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(91, 30);
            this.txtPorcentaje.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 61;
            this.label1.Text = "Porcentaje % :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 25);
            this.label3.TabIndex = 60;
            this.label3.Text = "Campo a modificar :";
            // 
            // cbcampoamodificar
            // 
            this.cbcampoamodificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbcampoamodificar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcampoamodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbcampoamodificar.FormattingEnabled = true;
            this.cbcampoamodificar.Items.AddRange(new object[] {
            "Precio_compra",
            "Utilidad",
            "Precio_venta",
            "Flete"});
            this.cbcampoamodificar.Location = new System.Drawing.Point(344, 32);
            this.cbcampoamodificar.Margin = new System.Windows.Forms.Padding(6);
            this.cbcampoamodificar.Name = "cbcampoamodificar";
            this.cbcampoamodificar.Size = new System.Drawing.Size(261, 33);
            this.cbcampoamodificar.TabIndex = 59;
            // 
            // DGVenta
            // 
            this.DGVenta.AllowUserToAddRows = false;
            this.DGVenta.AllowUserToDeleteRows = false;
            this.DGVenta.AllowUserToOrderColumns = true;
            this.DGVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menucodarticulo,
            this.menunombre,
            this.menudescripcion,
            this.menupreciocompra,
            this.menutilidad,
            this.menuflete,
            this.menuprecioventa,
            this.utilidadpormayor,
            this.Preciopormayor,
            this.utilidadpormayor2,
            this.preciopormayor2,
            this.utilidadoferta,
            this.precio_oferta});
            this.DGVenta.EnableHeadersVisualStyles = false;
            this.DGVenta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVenta.Location = new System.Drawing.Point(0, 41);
            this.DGVenta.Margin = new System.Windows.Forms.Padding(8, 14, 8, 14);
            this.DGVenta.MultiSelect = false;
            this.DGVenta.Name = "DGVenta";
            this.DGVenta.RowHeadersWidth = 38;
            this.DGVenta.Size = new System.Drawing.Size(1276, 574);
            this.DGVenta.TabIndex = 67;
            this.DGVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVenta_CellContentClick);
            this.DGVenta.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVenta_CellContentDoubleClick);
            this.DGVenta.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVenta_CellEndEdit);
            this.DGVenta.SelectionChanged += new System.EventHandler(this.DGVenta_SelectionChanged);
            this.DGVenta.Click += new System.EventHandler(this.DGVenta_Click);
            this.DGVenta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DGVenta_MouseClick);
            // 
            // menucodarticulo
            // 
            this.menucodarticulo.FillWeight = 56.2305F;
            this.menucodarticulo.HeaderText = "Codigo";
            this.menucodarticulo.MinimumWidth = 6;
            this.menucodarticulo.Name = "menucodarticulo";
            // 
            // menunombre
            // 
            this.menunombre.FillWeight = 345.1665F;
            this.menunombre.HeaderText = "Nombre";
            this.menunombre.MinimumWidth = 6;
            this.menunombre.Name = "menunombre";
            // 
            // menudescripcion
            // 
            this.menudescripcion.FillWeight = 29.04725F;
            this.menudescripcion.HeaderText = "Descripcion";
            this.menudescripcion.MinimumWidth = 6;
            this.menudescripcion.Name = "menudescripcion";
            // 
            // menupreciocompra
            // 
            this.menupreciocompra.FillWeight = 92.95119F;
            this.menupreciocompra.HeaderText = "Preciocompra";
            this.menupreciocompra.MinimumWidth = 6;
            this.menupreciocompra.Name = "menupreciocompra";
            // 
            // menutilidad
            // 
            this.menutilidad.FillWeight = 92.95119F;
            this.menutilidad.HeaderText = "Utilidad";
            this.menutilidad.MinimumWidth = 6;
            this.menutilidad.Name = "menutilidad";
            // 
            // menuflete
            // 
            this.menuflete.FillWeight = 32.99492F;
            this.menuflete.HeaderText = "Flete";
            this.menuflete.MinimumWidth = 6;
            this.menuflete.Name = "menuflete";
            // 
            // menuprecioventa
            // 
            this.menuprecioventa.FillWeight = 92.95119F;
            this.menuprecioventa.HeaderText = "Minorista";
            this.menuprecioventa.MinimumWidth = 6;
            this.menuprecioventa.Name = "menuprecioventa";
            // 
            // utilidadpormayor
            // 
            this.utilidadpormayor.FillWeight = 92.95119F;
            this.utilidadpormayor.HeaderText = "UtilidadX6";
            this.utilidadpormayor.MinimumWidth = 6;
            this.utilidadpormayor.Name = "utilidadpormayor";
            // 
            // Preciopormayor
            // 
            this.Preciopormayor.FillWeight = 92.95119F;
            this.Preciopormayor.HeaderText = "PrecioX6";
            this.Preciopormayor.MinimumWidth = 6;
            this.Preciopormayor.Name = "Preciopormayor";
            // 
            // utilidadpormayor2
            // 
            this.utilidadpormayor2.FillWeight = 92.95119F;
            this.utilidadpormayor2.HeaderText = "UtilidadXCaja";
            this.utilidadpormayor2.MinimumWidth = 6;
            this.utilidadpormayor2.Name = "utilidadpormayor2";
            // 
            // preciopormayor2
            // 
            this.preciopormayor2.FillWeight = 92.95119F;
            this.preciopormayor2.HeaderText = "PrecioXCaja";
            this.preciopormayor2.MinimumWidth = 6;
            this.preciopormayor2.Name = "preciopormayor2";
            // 
            // utilidadoferta
            // 
            this.utilidadoferta.FillWeight = 92.95119F;
            this.utilidadoferta.HeaderText = "UtilidadOferta";
            this.utilidadoferta.MinimumWidth = 6;
            this.utilidadoferta.Name = "utilidadoferta";
            // 
            // precio_oferta
            // 
            this.precio_oferta.FillWeight = 92.95119F;
            this.precio_oferta.HeaderText = "Precio_Oferta";
            this.precio_oferta.MinimumWidth = 6;
            this.precio_oferta.Name = "precio_oferta";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menudelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(158, 28);
            // 
            // Menudelete
            // 
            this.Menudelete.Name = "Menudelete";
            this.Menudelete.Size = new System.Drawing.Size(157, 24);
            this.Menudelete.Text = "Eliminar fila";
            this.Menudelete.Click += new System.EventHandler(this.Menudelete_Click);
            // 
            // TxtcambioDv
            // 
            this.TxtcambioDv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtcambioDv.Location = new System.Drawing.Point(792, 219);
            this.TxtcambioDv.Margin = new System.Windows.Forms.Padding(8, 14, 8, 14);
            this.TxtcambioDv.MaxLength = 10;
            this.TxtcambioDv.Name = "TxtcambioDv";
            this.TxtcambioDv.Size = new System.Drawing.Size(268, 30);
            this.TxtcambioDv.TabIndex = 71;
            this.TxtcambioDv.Text = "0";
            this.TxtcambioDv.Visible = false;
            this.TxtcambioDv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtcambioDv_KeyDown);
            this.TxtcambioDv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtcambioDv_KeyPress);
            this.TxtcambioDv.Leave += new System.EventHandler(this.TxtcambioDv_Leave);
            // 
            // xuiCustomGroupbox1
            // 
            this.xuiCustomGroupbox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xuiCustomGroupbox1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.xuiCustomGroupbox1.BorderWidth = 1;
            this.xuiCustomGroupbox1.Controls.Add(this.BtnExportarbalanza);
            this.xuiCustomGroupbox1.Controls.Add(this.BtnImproducto);
            this.xuiCustomGroupbox1.Controls.Add(this.BtnExportar);
            this.xuiCustomGroupbox1.Controls.Add(this.BtnImprimir);
            this.xuiCustomGroupbox1.Controls.Add(this.btnAplicar);
            this.xuiCustomGroupbox1.Controls.Add(this.BtnCambiar);
            this.xuiCustomGroupbox1.Controls.Add(this.btnLimpiarG);
            this.xuiCustomGroupbox1.Controls.Add(this.btnCliente);
            this.xuiCustomGroupbox1.Controls.Add(this.cbcampoamodificar);
            this.xuiCustomGroupbox1.Controls.Add(this.label3);
            this.xuiCustomGroupbox1.Controls.Add(this.txtPorcentaje);
            this.xuiCustomGroupbox1.Controls.Add(this.label1);
            this.xuiCustomGroupbox1.Location = new System.Drawing.Point(6, 622);
            this.xuiCustomGroupbox1.Name = "xuiCustomGroupbox1";
            this.xuiCustomGroupbox1.ShowText = true;
            this.xuiCustomGroupbox1.Size = new System.Drawing.Size(1265, 179);
            this.xuiCustomGroupbox1.TabIndex = 72;
            this.xuiCustomGroupbox1.TabStop = false;
            this.xuiCustomGroupbox1.Text = "Precios";
            this.xuiCustomGroupbox1.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // BtnImproducto
            // 
            this.BtnImproducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnImproducto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(247)))));
            this.BtnImproducto.ButtonImage = global::Capa_Presentacion.Properties.Resources.Save_20px;
            this.BtnImproducto.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.BtnImproducto.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.BtnImproducto.ButtonText = "Importar Productos";
            this.BtnImproducto.CornerRadius = 5;
            this.BtnImproducto.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnImproducto.HoverBackgroundColor = System.Drawing.Color.IndianRed;
            this.BtnImproducto.HoverTextColor = System.Drawing.Color.Yellow;
            this.BtnImproducto.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.BtnImproducto.Location = new System.Drawing.Point(886, 101);
            this.BtnImproducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnImproducto.Name = "BtnImproducto";
            this.BtnImproducto.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.BtnImproducto.SelectedTextColor = System.Drawing.Color.White;
            this.BtnImproducto.Size = new System.Drawing.Size(177, 61);
            this.BtnImproducto.SuperSelected = false;
            this.BtnImproducto.TabIndex = 136;
            this.BtnImproducto.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.BtnImproducto.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnImproducto.Click += new System.EventHandler(this.BtnImproducto_Click);
            // 
            // BtnExportar
            // 
            this.BtnExportar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExportar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(247)))));
            this.BtnExportar.ButtonImage = global::Capa_Presentacion.Properties.Resources.Save_20px;
            this.BtnExportar.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.BtnExportar.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.BtnExportar.ButtonText = "Exportar Productos";
            this.BtnExportar.CornerRadius = 5;
            this.BtnExportar.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnExportar.HoverBackgroundColor = System.Drawing.Color.IndianRed;
            this.BtnExportar.HoverTextColor = System.Drawing.Color.Yellow;
            this.BtnExportar.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.BtnExportar.Location = new System.Drawing.Point(883, 26);
            this.BtnExportar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnExportar.Name = "BtnExportar";
            this.BtnExportar.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.BtnExportar.SelectedTextColor = System.Drawing.Color.White;
            this.BtnExportar.Size = new System.Drawing.Size(180, 64);
            this.BtnExportar.SuperSelected = false;
            this.BtnExportar.TabIndex = 136;
            this.BtnExportar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.BtnExportar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnExportar.Click += new System.EventHandler(this.BtnExportar_Click);
            // 
            // BtnImprimir
            // 
            this.BtnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnImprimir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(247)))));
            this.BtnImprimir.ButtonImage = global::Capa_Presentacion.Properties.Resources.printer;
            this.BtnImprimir.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.BtnImprimir.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.BtnImprimir.ButtonText = "Imprimir etiqueta ";
            this.BtnImprimir.CornerRadius = 5;
            this.BtnImprimir.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnImprimir.HoverBackgroundColor = System.Drawing.Color.IndianRed;
            this.BtnImprimir.HoverTextColor = System.Drawing.Color.Yellow;
            this.BtnImprimir.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.BtnImprimir.Location = new System.Drawing.Point(1071, 26);
            this.BtnImprimir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnImprimir.Name = "BtnImprimir";
            this.BtnImprimir.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.BtnImprimir.SelectedTextColor = System.Drawing.Color.White;
            this.BtnImprimir.Size = new System.Drawing.Size(181, 64);
            this.BtnImprimir.SuperSelected = false;
            this.BtnImprimir.TabIndex = 134;
            this.BtnImprimir.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.BtnImprimir.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAplicar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(247)))));
            this.btnAplicar.ButtonImage = global::Capa_Presentacion.Properties.Resources.Save_20px;
            this.btnAplicar.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnAplicar.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnAplicar.ButtonText = "Aplicar cambios";
            this.btnAplicar.CornerRadius = 5;
            this.btnAplicar.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAplicar.HoverBackgroundColor = System.Drawing.Color.IndianRed;
            this.btnAplicar.HoverTextColor = System.Drawing.Color.Yellow;
            this.btnAplicar.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnAplicar.Location = new System.Drawing.Point(1072, 101);
            this.btnAplicar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnAplicar.SelectedTextColor = System.Drawing.Color.White;
            this.btnAplicar.Size = new System.Drawing.Size(179, 62);
            this.btnAplicar.SuperSelected = false;
            this.btnAplicar.TabIndex = 134;
            this.btnAplicar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnAplicar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // BtnCambiar
            // 
            this.BtnCambiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCambiar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(247)))));
            this.BtnCambiar.ButtonImage = null;
            this.BtnCambiar.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.BtnCambiar.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.BtnCambiar.ButtonText = "Cambiar";
            this.BtnCambiar.CornerRadius = 5;
            this.BtnCambiar.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnCambiar.HoverBackgroundColor = System.Drawing.Color.IndianRed;
            this.BtnCambiar.HoverTextColor = System.Drawing.Color.Yellow;
            this.BtnCambiar.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.BtnCambiar.Location = new System.Drawing.Point(451, 94);
            this.BtnCambiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCambiar.Name = "BtnCambiar";
            this.BtnCambiar.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.BtnCambiar.SelectedTextColor = System.Drawing.Color.White;
            this.BtnCambiar.Size = new System.Drawing.Size(145, 46);
            this.BtnCambiar.SuperSelected = false;
            this.BtnCambiar.TabIndex = 133;
            this.BtnCambiar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.BtnCambiar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnCambiar.Click += new System.EventHandler(this.BtnCambiar_Click);
            // 
            // btnLimpiarG
            // 
            this.btnLimpiarG.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(247)))));
            this.btnLimpiarG.ButtonImage = global::Capa_Presentacion.Properties.Resources.sweep;
            this.btnLimpiarG.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnLimpiarG.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnLimpiarG.ButtonText = "";
            this.btnLimpiarG.CornerRadius = 5;
            this.btnLimpiarG.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLimpiarG.HoverBackgroundColor = System.Drawing.Color.IndianRed;
            this.btnLimpiarG.HoverTextColor = System.Drawing.Color.Yellow;
            this.btnLimpiarG.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnLimpiarG.Location = new System.Drawing.Point(15, 97);
            this.btnLimpiarG.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiarG.Name = "btnLimpiarG";
            this.btnLimpiarG.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnLimpiarG.SelectedTextColor = System.Drawing.Color.White;
            this.btnLimpiarG.Size = new System.Drawing.Size(102, 62);
            this.btnLimpiarG.SuperSelected = false;
            this.btnLimpiarG.TabIndex = 132;
            this.btnLimpiarG.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnLimpiarG.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLimpiarG.Click += new System.EventHandler(this.btnLimpiarG_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(247)))));
            this.btnCliente.ButtonImage = global::Capa_Presentacion.Properties.Resources.search_magnifier_interface_symbol;
            this.btnCliente.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnCliente.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnCliente.ButtonText = "";
            this.btnCliente.CornerRadius = 5;
            this.btnCliente.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCliente.HoverBackgroundColor = System.Drawing.Color.IndianRed;
            this.btnCliente.HoverTextColor = System.Drawing.Color.Yellow;
            this.btnCliente.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnCliente.Location = new System.Drawing.Point(15, 31);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnCliente.SelectedTextColor = System.Drawing.Color.White;
            this.btnCliente.Size = new System.Drawing.Size(103, 61);
            this.btnCliente.SuperSelected = false;
            this.btnCliente.TabIndex = 131;
            this.btnCliente.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnCliente.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // BtnExportarbalanza
            // 
            this.BtnExportarbalanza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExportarbalanza.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(247)))));
            this.BtnExportarbalanza.ButtonImage = global::Capa_Presentacion.Properties.Resources.Save_20px;
            this.BtnExportarbalanza.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.BtnExportarbalanza.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.BtnExportarbalanza.ButtonText = "Exportar Balanza";
            this.BtnExportarbalanza.CornerRadius = 5;
            this.BtnExportarbalanza.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnExportarbalanza.HoverBackgroundColor = System.Drawing.Color.IndianRed;
            this.BtnExportarbalanza.HoverTextColor = System.Drawing.Color.Yellow;
            this.BtnExportarbalanza.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.BtnExportarbalanza.Location = new System.Drawing.Point(703, 26);
            this.BtnExportarbalanza.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnExportarbalanza.Name = "BtnExportarbalanza";
            this.BtnExportarbalanza.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.BtnExportarbalanza.SelectedTextColor = System.Drawing.Color.White;
            this.BtnExportarbalanza.Size = new System.Drawing.Size(172, 61);
            this.BtnExportarbalanza.SuperSelected = false;
            this.BtnExportarbalanza.TabIndex = 138;
            this.BtnExportarbalanza.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.BtnExportarbalanza.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnExportarbalanza.Click += new System.EventHandler(this.BtnExportarbalanza_Click);
            // 
            // FrmPreciosmasivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 813);
            this.ControlBox = false;
            this.Controls.Add(this.xuiCustomGroupbox1);
            this.Controls.Add(this.TxtcambioDv);
            this.Controls.Add(this.DGVenta);
            this.Controls.Add(this.panelHorizontal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPreciosmasivos";
            this.Text = "FrmPreciosmasivos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPreciosmasivos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPreciosmasivos_KeyDown);
            this.panelHorizontal.ResumeLayout(false);
            this.panelHorizontal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVenta)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.xuiCustomGroupbox1.ResumeLayout(false);
            this.xuiCustomGroupbox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHorizontal;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label lblSistemaVenta;
        private System.Windows.Forms.DataGridView DGVenta;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menudelete;
        private System.Windows.Forms.ComboBox cbcampoamodificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPorcentaje;
        public System.Windows.Forms.TextBox TxtcambioDv;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox1;
        private XanderUI.XUISuperButton btnLimpiarG;
        private XanderUI.XUISuperButton btnCliente;
        private XanderUI.XUISuperButton btnAplicar;
        private XanderUI.XUISuperButton BtnCambiar;
        private XanderUI.XUISuperButton BtnImprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn menucodarticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn menunombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn menudescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn menupreciocompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn menutilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuflete;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuprecioventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn utilidadpormayor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preciopormayor;
        private System.Windows.Forms.DataGridViewTextBoxColumn utilidadpormayor2;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciopormayor2;
        private System.Windows.Forms.DataGridViewTextBoxColumn utilidadoferta;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_oferta;
        private XanderUI.XUISuperButton BtnExportar;
        private XanderUI.XUISuperButton BtnImproducto;
        private XanderUI.XUISuperButton BtnExportarbalanza;
    }
}