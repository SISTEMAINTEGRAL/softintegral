namespace Capa_Presentacion
{
    partial class FrmMovStock1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAnular = new System.Windows.Forms.Button();
            this.dataLista = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaIni = new System.Windows.Forms.DateTimePicker();
            this.lblFechaIni = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.Dtproducto = new System.Windows.Forms.DataGridView();
            this.Dtproveedor = new System.Windows.Forms.DataGridView();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.LblDetalle = new System.Windows.Forms.Label();
            this.btnBuscarProd = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.lblCntIngOegr = new System.Windows.Forms.Label();
            this.lblNomProducto = new System.Windows.Forms.Label();
            this.dataListaMov = new System.Windows.Forms.DataGridView();
            this.Codigo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preciocompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockActual1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttMensajeAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelHorizontal = new System.Windows.Forms.Panel();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lblSistemaVenta = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.Lista = new System.Windows.Forms.TabPage();
            this.Agregar = new System.Windows.Forms.TabPage();
            this.rdbEgreso = new System.Windows.Forms.RadioButton();
            this.rdbIngreso = new System.Windows.Forms.RadioButton();
            this.xuiCustomGroupbox1 = new XanderUI.XUICustomGroupbox();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.ChRegistrar = new System.Windows.Forms.CheckBox();
            this.btnBuscarProv = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTComprobante = new System.Windows.Forms.Label();
            this.LblDesprov = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSerie = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCorrelativa = new System.Windows.Forms.TextBox();
            this.cbTipoComprobante = new System.Windows.Forms.ComboBox();
            this.lblCorrelativa = new System.Windows.Forms.Label();
            this.xuiCustomGroupbox2 = new XanderUI.XUICustomGroupbox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dtproducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dtproveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaMov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.panelHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.Lista.SuspendLayout();
            this.Agregar.SuspendLayout();
            this.xuiCustomGroupbox1.SuspendLayout();
            this.xuiCustomGroupbox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnAnular
            // 
            this.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnular.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.Location = new System.Drawing.Point(1167, 35);
            this.btnAnular.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(140, 49);
            this.btnAnular.TabIndex = 4;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Visible = false;
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
            this.dataLista.Location = new System.Drawing.Point(7, 104);
            this.dataLista.Margin = new System.Windows.Forms.Padding(4);
            this.dataLista.MultiSelect = false;
            this.dataLista.Name = "dataLista";
            this.dataLista.ReadOnly = true;
            this.dataLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataLista.Size = new System.Drawing.Size(1380, 380);
            this.dataLista.TabIndex = 6;
            this.dataLista.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLista_RowLeave);
            this.dataLista.SelectionChanged += new System.EventHandler(this.dataLista_SelectionChanged);
            this.dataLista.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataLista_MouseClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 505);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1380, 145);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarExcel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarExcel.Image = global::Capa_Presentacion.Properties.Resources.Microsoft_Excel_20px;
            this.btnExportarExcel.Location = new System.Drawing.Point(1352, 18);
            this.btnExportarExcel.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(35, 34);
            this.btnExportarExcel.TabIndex = 30;
            this.btnExportarExcel.UseVisualStyleBackColor = true;
            // 
            // btnTodos
            // 
            this.btnTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodos.Location = new System.Drawing.Point(1004, 35);
            this.btnTodos.Margin = new System.Windows.Forms.Padding(4);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(140, 49);
            this.btnTodos.TabIndex = 15;
            this.btnTodos.Text = "Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "Fecha Fin";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(273, 54);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(208, 30);
            this.dtpFechaFin.TabIndex = 2;
            // 
            // dtpFechaIni
            // 
            this.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIni.Location = new System.Drawing.Point(18, 54);
            this.dtpFechaIni.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaIni.Name = "dtpFechaIni";
            this.dtpFechaIni.Size = new System.Drawing.Size(208, 30);
            this.dtpFechaIni.TabIndex = 1;
            // 
            // lblFechaIni
            // 
            this.lblFechaIni.AutoSize = true;
            this.lblFechaIni.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIni.Location = new System.Drawing.Point(21, 16);
            this.lblFechaIni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaIni.Name = "lblFechaIni";
            this.lblFechaIni.Size = new System.Drawing.Size(160, 30);
            this.lblFechaIni.TabIndex = 7;
            this.lblFechaIni.Text = "Fecha Inicio";
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(841, 35);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(140, 49);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Dtproducto
            // 
            this.Dtproducto.AllowUserToAddRows = false;
            this.Dtproducto.AllowUserToDeleteRows = false;
            this.Dtproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dtproducto.Location = new System.Drawing.Point(116, 209);
            this.Dtproducto.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Dtproducto.MultiSelect = false;
            this.Dtproducto.Name = "Dtproducto";
            this.Dtproducto.ReadOnly = true;
            this.Dtproducto.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtproducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dtproducto.Size = new System.Drawing.Size(486, 126);
            this.Dtproducto.TabIndex = 46;
            this.Dtproducto.Visible = false;
            this.Dtproducto.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtproducto_CellContentDoubleClick);
            this.Dtproducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dtproducto_KeyDown);
            this.Dtproducto.Leave += new System.EventHandler(this.Dtproducto_Leave);
            // 
            // Dtproveedor
            // 
            this.Dtproveedor.AllowUserToAddRows = false;
            this.Dtproveedor.AllowUserToDeleteRows = false;
            this.Dtproveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtproveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dtproveedor.Location = new System.Drawing.Point(140, 0);
            this.Dtproveedor.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Dtproveedor.MultiSelect = false;
            this.Dtproveedor.Name = "Dtproveedor";
            this.Dtproveedor.ReadOnly = true;
            this.Dtproveedor.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dtproveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dtproveedor.Size = new System.Drawing.Size(433, 70);
            this.Dtproveedor.TabIndex = 47;
            this.Dtproveedor.Visible = false;
            this.Dtproveedor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dtproveedor_CellDoubleClick);
            this.Dtproveedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dtproveedor_KeyDown);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(108, 23);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(247, 30);
            this.txtNombreProducto.TabIndex = 77;
            this.txtNombreProducto.TextChanged += new System.EventHandler(this.txtNombreProducto_TextChanged);
            this.txtNombreProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombreProducto_KeyDown);
            this.txtNombreProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreProducto_KeyPress);
            // 
            // LblDetalle
            // 
            this.LblDetalle.AutoSize = true;
            this.LblDetalle.Location = new System.Drawing.Point(414, 28);
            this.LblDetalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDetalle.Name = "LblDetalle";
            this.LblDetalle.Size = new System.Drawing.Size(27, 25);
            this.LblDetalle.TabIndex = 45;
            this.LblDetalle.Text = "...";
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProd.Image = global::Capa_Presentacion.Properties.Resources.Search_15px;
            this.btnBuscarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarProd.Location = new System.Drawing.Point(363, 21);
            this.btnBuscarProd.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.Size = new System.Drawing.Size(35, 34);
            this.btnBuscarProd.TabIndex = 44;
            this.btnBuscarProd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscarProd.UseVisualStyleBackColor = true;
            this.btnBuscarProd.Click += new System.EventHandler(this.btnBuscarProd_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Image = global::Capa_Presentacion.Properties.Resources.Plus_15px;
            this.btnAgregar.Location = new System.Drawing.Point(774, 29);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(35, 30);
            this.btnAgregar.TabIndex = 40;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtcantidad
            // 
            this.txtcantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcantidad.Location = new System.Drawing.Point(704, 28);
            this.txtcantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtcantidad.MaxLength = 8;
            this.txtcantidad.Multiline = true;
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(66, 30);
            this.txtcantidad.TabIndex = 39;
            this.txtcantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcantidad_KeyDown);
            // 
            // lblCntIngOegr
            // 
            this.lblCntIngOegr.AutoSize = true;
            this.lblCntIngOegr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCntIngOegr.Location = new System.Drawing.Point(581, 30);
            this.lblCntIngOegr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCntIngOegr.Name = "lblCntIngOegr";
            this.lblCntIngOegr.Size = new System.Drawing.Size(102, 25);
            this.lblCntIngOegr.TabIndex = 43;
            this.lblCntIngOegr.Text = "Cantidad :";
            // 
            // lblNomProducto
            // 
            this.lblNomProducto.AutoSize = true;
            this.lblNomProducto.Location = new System.Drawing.Point(11, 28);
            this.lblNomProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomProducto.Name = "lblNomProducto";
            this.lblNomProducto.Size = new System.Drawing.Size(90, 25);
            this.lblNomProducto.TabIndex = 41;
            this.lblNomProducto.Text = "Producto";
            // 
            // dataListaMov
            // 
            this.dataListaMov.AllowUserToAddRows = false;
            this.dataListaMov.AllowUserToDeleteRows = false;
            this.dataListaMov.AllowUserToOrderColumns = true;
            this.dataListaMov.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataListaMov.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataListaMov.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListaMov.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataListaMov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListaMov.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo1,
            this.Nombre,
            this.Preciocompra,
            this.PrecioVenta1,
            this.Cantidad1,
            this.StockActual1});
            this.dataListaMov.EnableHeadersVisualStyles = false;
            this.dataListaMov.Location = new System.Drawing.Point(9, 223);
            this.dataListaMov.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.dataListaMov.MultiSelect = false;
            this.dataListaMov.Name = "dataListaMov";
            this.dataListaMov.RowHeadersWidth = 38;
            this.dataListaMov.Size = new System.Drawing.Size(1378, 371);
            this.dataListaMov.TabIndex = 73;
            this.dataListaMov.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListaMov_CellDoubleClick);
            // 
            // Codigo1
            // 
            this.Codigo1.HeaderText = "Codigo";
            this.Codigo1.MaxInputLength = 300;
            this.Codigo1.Name = "Codigo1";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Preciocompra
            // 
            this.Preciocompra.HeaderText = "PrecioCompra";
            this.Preciocompra.MaxInputLength = 300;
            this.Preciocompra.Name = "Preciocompra";
            // 
            // PrecioVenta1
            // 
            this.PrecioVenta1.HeaderText = "PrecioVenta";
            this.PrecioVenta1.MaxInputLength = 300;
            this.PrecioVenta1.Name = "PrecioVenta1";
            // 
            // Cantidad1
            // 
            this.Cantidad1.HeaderText = "Cantidad";
            this.Cantidad1.MaxInputLength = 100;
            this.Cantidad1.Name = "Cantidad1";
            // 
            // StockActual1
            // 
            this.StockActual1.HeaderText = "StockActual";
            this.StockActual1.MaxInputLength = 300;
            this.StockActual1.Name = "StockActual1";
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // ttMensajeAyuda
            // 
            this.ttMensajeAyuda.AutomaticDelay = 90;
            this.ttMensajeAyuda.AutoPopDelay = 2000;
            this.ttMensajeAyuda.InitialDelay = 90;
            this.ttMensajeAyuda.ReshowDelay = 18;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 90;
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
            this.panelHorizontal.Margin = new System.Windows.Forms.Padding(4);
            this.panelHorizontal.Name = "panelHorizontal";
            this.panelHorizontal.Size = new System.Drawing.Size(1421, 37);
            this.panelHorizontal.TabIndex = 64;
            this.panelHorizontal.DoubleClick += new System.EventHandler(this.panelHorizontal_DoubleClick);
            this.panelHorizontal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHorizontal_MouseMove);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackgroundImage = global::Capa_Presentacion.Properties.Resources.maximize_Checkbox_16px;
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMaximizar.Location = new System.Drawing.Point(1343, 1);
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
            this.btnRestaurar.Location = new System.Drawing.Point(1343, 1);
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
            this.btnMinimizar.Location = new System.Drawing.Point(1299, 1);
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
            this.btnCerrar.Location = new System.Drawing.Point(1387, 1);
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
            this.lblSistemaVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSistemaVenta.AutoSize = true;
            this.lblSistemaVenta.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistemaVenta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSistemaVenta.Location = new System.Drawing.Point(4, 7);
            this.lblSistemaVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSistemaVenta.Name = "lblSistemaVenta";
            this.lblSistemaVenta.Size = new System.Drawing.Size(314, 28);
            this.lblSistemaVenta.TabIndex = 3;
            this.lblSistemaVenta.Text = "MOVIMIENTO DE STOCK    ";
            this.lblSistemaVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.Agregar);
            this.tabControl2.Controls.Add(this.Lista);
            this.tabControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tabControl2.Location = new System.Drawing.Point(10, 51);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1403, 698);
            this.tabControl2.TabIndex = 77;
            // 
            // Lista
            // 
            this.Lista.Controls.Add(this.dataGridView1);
            this.Lista.Controls.Add(this.btnExportarExcel);
            this.Lista.Controls.Add(this.dataLista);
            this.Lista.Controls.Add(this.btnBuscar);
            this.Lista.Controls.Add(this.btnTodos);
            this.Lista.Controls.Add(this.btnAnular);
            this.Lista.Controls.Add(this.label1);
            this.Lista.Controls.Add(this.lblFechaIni);
            this.Lista.Controls.Add(this.dtpFechaFin);
            this.Lista.Controls.Add(this.dtpFechaIni);
            this.Lista.Location = new System.Drawing.Point(4, 34);
            this.Lista.Name = "Lista";
            this.Lista.Padding = new System.Windows.Forms.Padding(3);
            this.Lista.Size = new System.Drawing.Size(1395, 660);
            this.Lista.TabIndex = 1;
            this.Lista.Text = "Lista";
            this.Lista.UseVisualStyleBackColor = true;
            // 
            // Agregar
            // 
            this.Agregar.Controls.Add(this.Dtproducto);
            this.Agregar.Controls.Add(this.xuiCustomGroupbox2);
            this.Agregar.Controls.Add(this.dataListaMov);
            this.Agregar.Controls.Add(this.button2);
            this.Agregar.Controls.Add(this.button1);
            this.Agregar.Controls.Add(this.rdbIngreso);
            this.Agregar.Controls.Add(this.rdbEgreso);
            this.Agregar.Controls.Add(this.xuiCustomGroupbox1);
            this.Agregar.Location = new System.Drawing.Point(4, 34);
            this.Agregar.Name = "Agregar";
            this.Agregar.Padding = new System.Windows.Forms.Padding(3);
            this.Agregar.Size = new System.Drawing.Size(1395, 660);
            this.Agregar.TabIndex = 0;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            // 
            // rdbEgreso
            // 
            this.rdbEgreso.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbEgreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEgreso.Location = new System.Drawing.Point(163, 9);
            this.rdbEgreso.Name = "rdbEgreso";
            this.rdbEgreso.Size = new System.Drawing.Size(150, 45);
            this.rdbEgreso.TabIndex = 12;
            this.rdbEgreso.TabStop = true;
            this.rdbEgreso.Text = "Egreso";
            this.rdbEgreso.UseVisualStyleBackColor = true;
            // 
            // rdbIngreso
            // 
            this.rdbIngreso.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbIngreso.Checked = true;
            this.rdbIngreso.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rdbIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbIngreso.Location = new System.Drawing.Point(7, 9);
            this.rdbIngreso.Name = "rdbIngreso";
            this.rdbIngreso.Size = new System.Drawing.Size(150, 45);
            this.rdbIngreso.TabIndex = 11;
            this.rdbIngreso.TabStop = true;
            this.rdbIngreso.Text = "Ingreso";
            this.rdbIngreso.UseVisualStyleBackColor = true;
            // 
            // xuiCustomGroupbox1
            // 
            this.xuiCustomGroupbox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xuiCustomGroupbox1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.xuiCustomGroupbox1.BorderWidth = 1;
            this.xuiCustomGroupbox1.Controls.Add(this.LblDesprov);
            this.xuiCustomGroupbox1.Controls.Add(this.lblTComprobante);
            this.xuiCustomGroupbox1.Controls.Add(this.label2);
            this.xuiCustomGroupbox1.Controls.Add(this.btnBuscarProv);
            this.xuiCustomGroupbox1.Controls.Add(this.ChRegistrar);
            this.xuiCustomGroupbox1.Controls.Add(this.txtProveedor);
            this.xuiCustomGroupbox1.Controls.Add(this.cbTipoComprobante);
            this.xuiCustomGroupbox1.Controls.Add(this.lblSerie);
            this.xuiCustomGroupbox1.Controls.Add(this.txtSerie);
            this.xuiCustomGroupbox1.Controls.Add(this.lblCorrelativa);
            this.xuiCustomGroupbox1.Controls.Add(this.txtCorrelativa);
            this.xuiCustomGroupbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuiCustomGroupbox1.Location = new System.Drawing.Point(7, 64);
            this.xuiCustomGroupbox1.Name = "xuiCustomGroupbox1";
            this.xuiCustomGroupbox1.ShowText = true;
            this.xuiCustomGroupbox1.Size = new System.Drawing.Size(1382, 82);
            this.xuiCustomGroupbox1.TabIndex = 13;
            this.xuiCustomGroupbox1.TabStop = false;
            this.xuiCustomGroupbox1.Text = "Registrar comprobante";
            this.xuiCustomGroupbox1.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // txtProveedor
            // 
            this.txtProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProveedor.Enabled = false;
            this.txtProveedor.Location = new System.Drawing.Point(150, 31);
            this.txtProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtProveedor.Multiline = true;
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(136, 30);
            this.txtProveedor.TabIndex = 33;
            this.txtProveedor.TextChanged += new System.EventHandler(this.txtProveedor_TextChanged);
            this.txtProveedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProveedor_KeyDown);
            // 
            // ChRegistrar
            // 
            this.ChRegistrar.AutoSize = true;
            this.ChRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChRegistrar.Location = new System.Drawing.Point(16, 37);
            this.ChRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.ChRegistrar.Name = "ChRegistrar";
            this.ChRegistrar.Size = new System.Drawing.Size(14, 13);
            this.ChRegistrar.TabIndex = 37;
            this.ChRegistrar.UseVisualStyleBackColor = true;
            this.ChRegistrar.CheckedChanged += new System.EventHandler(this.ChRegistrar_CheckedChanged);
            // 
            // btnBuscarProv
            // 
            this.btnBuscarProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProv.Image = global::Capa_Presentacion.Properties.Resources.Search_15px;
            this.btnBuscarProv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarProv.Location = new System.Drawing.Point(288, 31);
            this.btnBuscarProv.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnBuscarProv.Name = "btnBuscarProv";
            this.btnBuscarProv.Size = new System.Drawing.Size(35, 30);
            this.btnBuscarProv.TabIndex = 44;
            this.btnBuscarProv.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscarProv.UseVisualStyleBackColor = true;
            this.btnBuscarProv.Click += new System.EventHandler(this.btnBuscarProv_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Proveedor";
            // 
            // lblTComprobante
            // 
            this.lblTComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTComprobante.Location = new System.Drawing.Point(474, 35);
            this.lblTComprobante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTComprobante.Name = "lblTComprobante";
            this.lblTComprobante.Size = new System.Drawing.Size(112, 30);
            this.lblTComprobante.TabIndex = 43;
            this.lblTComprobante.Text = "Tipo Com. :";
            // 
            // LblDesprov
            // 
            this.LblDesprov.Location = new System.Drawing.Point(333, 33);
            this.LblDesprov.Name = "LblDesprov";
            this.LblDesprov.Size = new System.Drawing.Size(144, 26);
            this.LblDesprov.TabIndex = 45;
            this.LblDesprov.Text = "...";
            // 
            // txtSerie
            // 
            this.txtSerie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerie.Enabled = false;
            this.txtSerie.Location = new System.Drawing.Point(916, 37);
            this.txtSerie.Margin = new System.Windows.Forms.Padding(4);
            this.txtSerie.MaxLength = 4;
            this.txtSerie.Multiline = true;
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(83, 30);
            this.txtSerie.TabIndex = 39;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1064, 604);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 37);
            this.button1.TabIndex = 74;
            this.button1.Text = "Guardar cambios";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.Location = new System.Drawing.Point(815, 38);
            this.lblSerie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(69, 25);
            this.lblSerie.TabIndex = 41;
            this.lblSerie.Text = "Serie :";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1234, 604);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 37);
            this.button2.TabIndex = 75;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // txtCorrelativa
            // 
            this.txtCorrelativa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorrelativa.Enabled = false;
            this.txtCorrelativa.Location = new System.Drawing.Point(1183, 37);
            this.txtCorrelativa.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorrelativa.MaxLength = 8;
            this.txtCorrelativa.Multiline = true;
            this.txtCorrelativa.Name = "txtCorrelativa";
            this.txtCorrelativa.Size = new System.Drawing.Size(123, 30);
            this.txtCorrelativa.TabIndex = 40;
            // 
            // cbTipoComprobante
            // 
            this.cbTipoComprobante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbTipoComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoComprobante.Enabled = false;
            this.cbTipoComprobante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTipoComprobante.FormattingEnabled = true;
            this.cbTipoComprobante.Items.AddRange(new object[] {
            "TICKET",
            "BOLETA",
            "FACTURA",
            "REMITO"});
            this.cbTipoComprobante.Location = new System.Drawing.Point(608, 33);
            this.cbTipoComprobante.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipoComprobante.Name = "cbTipoComprobante";
            this.cbTipoComprobante.Size = new System.Drawing.Size(179, 33);
            this.cbTipoComprobante.TabIndex = 38;
            // 
            // lblCorrelativa
            // 
            this.lblCorrelativa.AutoSize = true;
            this.lblCorrelativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrelativa.Location = new System.Drawing.Point(1023, 40);
            this.lblCorrelativa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorrelativa.Name = "lblCorrelativa";
            this.lblCorrelativa.Size = new System.Drawing.Size(117, 25);
            this.lblCorrelativa.TabIndex = 42;
            this.lblCorrelativa.Text = "Correlativa :";
            // 
            // xuiCustomGroupbox2
            // 
            this.xuiCustomGroupbox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xuiCustomGroupbox2.BorderColor = System.Drawing.Color.DodgerBlue;
            this.xuiCustomGroupbox2.BorderWidth = 1;
            this.xuiCustomGroupbox2.Controls.Add(this.Dtproveedor);
            this.xuiCustomGroupbox2.Controls.Add(this.txtNombreProducto);
            this.xuiCustomGroupbox2.Controls.Add(this.lblNomProducto);
            this.xuiCustomGroupbox2.Controls.Add(this.LblDetalle);
            this.xuiCustomGroupbox2.Controls.Add(this.txtcantidad);
            this.xuiCustomGroupbox2.Controls.Add(this.btnBuscarProd);
            this.xuiCustomGroupbox2.Controls.Add(this.btnAgregar);
            this.xuiCustomGroupbox2.Controls.Add(this.lblCntIngOegr);
            this.xuiCustomGroupbox2.Location = new System.Drawing.Point(7, 149);
            this.xuiCustomGroupbox2.Name = "xuiCustomGroupbox2";
            this.xuiCustomGroupbox2.ShowText = true;
            this.xuiCustomGroupbox2.Size = new System.Drawing.Size(1385, 71);
            this.xuiCustomGroupbox2.TabIndex = 78;
            this.xuiCustomGroupbox2.TabStop = false;
            this.xuiCustomGroupbox2.Text = "Items :";
            this.xuiCustomGroupbox2.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // FrmMovStock1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1421, 798);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.panelHorizontal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMovStock1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmMovStock1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMovStock1_MouseMove);
            this.Move += new System.EventHandler(this.FrmMovStock1_Move);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dtproducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dtproveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaMov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.panelHorizontal.ResumeLayout(false);
            this.panelHorizontal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.Lista.ResumeLayout(false);
            this.Lista.PerformLayout();
            this.Agregar.ResumeLayout(false);
            this.xuiCustomGroupbox1.ResumeLayout(false);
            this.xuiCustomGroupbox1.PerformLayout();
            this.xuiCustomGroupbox2.ResumeLayout(false);
            this.xuiCustomGroupbox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dataLista;
        private System.Windows.Forms.Label lblFechaIni;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.ToolTip ttMensajeAyuda;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panelHorizontal;
        private System.Windows.Forms.Label lblSistemaVenta;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaIni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.DataGridView Dtproveedor;
        private System.Windows.Forms.DataGridView Dtproducto;
        private System.Windows.Forms.Label LblDetalle;
        private System.Windows.Forms.Button btnBuscarProd;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label lblCntIngOegr;
        private System.Windows.Forms.Label lblNomProducto;
        private System.Windows.Forms.DataGridView dataListaMov;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preciocompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockActual1;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage Agregar;
        private System.Windows.Forms.Label lblCorrelativa;
        private System.Windows.Forms.ComboBox cbTipoComprobante;
        private System.Windows.Forms.TextBox txtCorrelativa;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSerie;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox1;
        private System.Windows.Forms.Label LblDesprov;
        private System.Windows.Forms.Label lblTComprobante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarProv;
        private System.Windows.Forms.CheckBox ChRegistrar;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.RadioButton rdbIngreso;
        private System.Windows.Forms.RadioButton rdbEgreso;
        private System.Windows.Forms.TabPage Lista;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox2;
    }
}