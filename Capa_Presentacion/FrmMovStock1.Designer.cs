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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAnular = new System.Windows.Forms.Button();
            this.dataLista = new System.Windows.Forms.DataGridView();
            this.tabLista = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaIni = new System.Windows.Forms.DateTimePicker();
            this.lblFechaIni = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabGenerar = new System.Windows.Forms.TabPage();
            this.Dtproducto = new System.Windows.Forms.DataGridView();
            this.TxtcambioDv = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Dtproveedor = new System.Windows.Forms.DataGridView();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.LblDetalle = new System.Windows.Forms.Label();
            this.btnBuscarProd = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.lblCntIngOegr = new System.Windows.Forms.Label();
            this.lblNomProducto = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblDesprov = new System.Windows.Forms.Label();
            this.btnBuscarProv = new System.Windows.Forms.Button();
            this.cbTipoComprobante = new System.Windows.Forms.ComboBox();
            this.ChRegistrar = new System.Windows.Forms.CheckBox();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.lblTComprobante = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCorrelativa = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();
            this.txtCorrelativa = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.rdbIngreso = new System.Windows.Forms.RadioButton();
            this.rdbEgreso = new System.Windows.Forms.RadioButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).BeginInit();
            this.tabLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabGenerar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtproducto)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtproveedor)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaMov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.panelHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(1038, 53);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(26, 30);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "0";
            // 
            // btnAnular
            // 
            this.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnular.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.Location = new System.Drawing.Point(843, 46);
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
            this.dataLista.Location = new System.Drawing.Point(8, 107);
            this.dataLista.Margin = new System.Windows.Forms.Padding(4);
            this.dataLista.MultiSelect = false;
            this.dataLista.Name = "dataLista";
            this.dataLista.ReadOnly = true;
            this.dataLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataLista.Size = new System.Drawing.Size(1357, 468);
            this.dataLista.TabIndex = 6;
            this.dataLista.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLista_RowLeave);
            this.dataLista.SelectionChanged += new System.EventHandler(this.dataLista_SelectionChanged);
            this.dataLista.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataLista_MouseClick);
            // 
            // tabLista
            // 
            this.tabLista.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabLista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabLista.Controls.Add(this.dataGridView1);
            this.tabLista.Controls.Add(this.btnExportarExcel);
            this.tabLista.Controls.Add(this.btnTodos);
            this.tabLista.Controls.Add(this.label1);
            this.tabLista.Controls.Add(this.dtpFechaFin);
            this.tabLista.Controls.Add(this.dtpFechaIni);
            this.tabLista.Controls.Add(this.dataLista);
            this.tabLista.Controls.Add(this.lblTotal);
            this.tabLista.Controls.Add(this.lblFechaIni);
            this.tabLista.Controls.Add(this.btnAnular);
            this.tabLista.Controls.Add(this.btnBuscar);
            this.tabLista.Location = new System.Drawing.Point(4, 29);
            this.tabLista.Margin = new System.Windows.Forms.Padding(4);
            this.tabLista.Name = "tabLista";
            this.tabLista.Padding = new System.Windows.Forms.Padding(4);
            this.tabLista.Size = new System.Drawing.Size(1375, 803);
            this.tabLista.TabIndex = 0;
            this.tabLista.Text = "Lista";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 587);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1357, 196);
            this.dataGridView1.TabIndex = 31;
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarExcel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarExcel.Image = global::Capa_Presentacion.Properties.Resources.Microsoft_Excel_20px;
            this.btnExportarExcel.Location = new System.Drawing.Point(1297, 11);
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
            this.btnTodos.Location = new System.Drawing.Point(680, 46);
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
            this.label1.Location = new System.Drawing.Point(275, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "Fecha Fin";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(280, 49);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(208, 32);
            this.dtpFechaFin.TabIndex = 2;
            // 
            // dtpFechaIni
            // 
            this.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIni.Location = new System.Drawing.Point(25, 49);
            this.dtpFechaIni.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaIni.Name = "dtpFechaIni";
            this.dtpFechaIni.Size = new System.Drawing.Size(208, 32);
            this.dtpFechaIni.TabIndex = 1;
            // 
            // lblFechaIni
            // 
            this.lblFechaIni.AutoSize = true;
            this.lblFechaIni.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIni.Location = new System.Drawing.Point(28, 11);
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
            this.btnBuscar.Location = new System.Drawing.Point(517, 46);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(140, 49);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabLista);
            this.tabControl1.Controls.Add(this.tabGenerar);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(45, 25);
            this.tabControl1.Location = new System.Drawing.Point(4, 51);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1383, 836);
            this.tabControl1.TabIndex = 1;
            // 
            // tabGenerar
            // 
            this.tabGenerar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabGenerar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabGenerar.Controls.Add(this.Dtproducto);
            this.tabGenerar.Controls.Add(this.TxtcambioDv);
            this.tabGenerar.Controls.Add(this.button2);
            this.tabGenerar.Controls.Add(this.button1);
            this.tabGenerar.Controls.Add(this.groupBox3);
            this.tabGenerar.Controls.Add(this.groupBox2);
            this.tabGenerar.Controls.Add(this.rdbIngreso);
            this.tabGenerar.Controls.Add(this.rdbEgreso);
            this.tabGenerar.Controls.Add(this.dataListaMov);
            this.tabGenerar.Location = new System.Drawing.Point(4, 29);
            this.tabGenerar.Margin = new System.Windows.Forms.Padding(4);
            this.tabGenerar.Name = "tabGenerar";
            this.tabGenerar.Padding = new System.Windows.Forms.Padding(4);
            this.tabGenerar.Size = new System.Drawing.Size(1375, 803);
            this.tabGenerar.TabIndex = 1;
            this.tabGenerar.Text = "Generar";
            // 
            // Dtproducto
            // 
            this.Dtproducto.AllowUserToAddRows = false;
            this.Dtproducto.AllowUserToDeleteRows = false;
            this.Dtproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtproducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dtproducto.Location = new System.Drawing.Point(119, 238);
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
            // TxtcambioDv
            // 
            this.TxtcambioDv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtcambioDv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtcambioDv.Location = new System.Drawing.Point(775, 316);
            this.TxtcambioDv.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.TxtcambioDv.MaxLength = 10;
            this.TxtcambioDv.Multiline = true;
            this.TxtcambioDv.Name = "TxtcambioDv";
            this.TxtcambioDv.Size = new System.Drawing.Size(135, 30);
            this.TxtcambioDv.TabIndex = 76;
            this.TxtcambioDv.Text = "0";
            this.TxtcambioDv.Visible = false;
            this.TxtcambioDv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtcambioDv_KeyDown);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1200, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 37);
            this.button2.TabIndex = 75;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1035, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 37);
            this.button1.TabIndex = 74;
            this.button1.Text = "Guardar cambios";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.Dtproveedor);
            this.groupBox3.Controls.Add(this.txtNombreProducto);
            this.groupBox3.Controls.Add(this.LblDetalle);
            this.groupBox3.Controls.Add(this.btnBuscarProd);
            this.groupBox3.Controls.Add(this.btnAgregar);
            this.groupBox3.Controls.Add(this.txtcantidad);
            this.groupBox3.Controls.Add(this.lblCntIngOegr);
            this.groupBox3.Controls.Add(this.lblNomProducto);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(15, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1349, 79);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle de movimiento de stock";
            // 
            // Dtproveedor
            // 
            this.Dtproveedor.AllowUserToAddRows = false;
            this.Dtproveedor.AllowUserToDeleteRows = false;
            this.Dtproveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtproveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dtproveedor.Location = new System.Drawing.Point(236, -11);
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
            this.txtNombreProducto.Location = new System.Drawing.Point(104, 37);
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
            this.LblDetalle.Location = new System.Drawing.Point(491, 39);
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
            this.btnBuscarProd.Location = new System.Drawing.Point(377, 34);
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
            this.btnAgregar.Location = new System.Drawing.Point(1284, 34);
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
            this.txtcantidad.Location = new System.Drawing.Point(1090, 34);
            this.txtcantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtcantidad.MaxLength = 8;
            this.txtcantidad.Multiline = true;
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(182, 30);
            this.txtcantidad.TabIndex = 39;
            this.txtcantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcantidad_KeyDown);
            // 
            // lblCntIngOegr
            // 
            this.lblCntIngOegr.AutoSize = true;
            this.lblCntIngOegr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCntIngOegr.Location = new System.Drawing.Point(975, 37);
            this.lblCntIngOegr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCntIngOegr.Name = "lblCntIngOegr";
            this.lblCntIngOegr.Size = new System.Drawing.Size(102, 25);
            this.lblCntIngOegr.TabIndex = 43;
            this.lblCntIngOegr.Text = "Cantidad :";
            // 
            // lblNomProducto
            // 
            this.lblNomProducto.AutoSize = true;
            this.lblNomProducto.Location = new System.Drawing.Point(7, 42);
            this.lblNomProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomProducto.Name = "lblNomProducto";
            this.lblNomProducto.Size = new System.Drawing.Size(90, 25);
            this.lblNomProducto.TabIndex = 41;
            this.lblNomProducto.Text = "Producto";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.LblDesprov);
            this.groupBox2.Controls.Add(this.btnBuscarProv);
            this.groupBox2.Controls.Add(this.cbTipoComprobante);
            this.groupBox2.Controls.Add(this.ChRegistrar);
            this.groupBox2.Controls.Add(this.txtProveedor);
            this.groupBox2.Controls.Add(this.lblTComprobante);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblCorrelativa);
            this.groupBox2.Controls.Add(this.lblSerie);
            this.groupBox2.Controls.Add(this.txtCorrelativa);
            this.groupBox2.Controls.Add(this.txtSerie);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(10, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1355, 64);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registrar comprobante";
            // 
            // LblDesprov
            // 
            this.LblDesprov.Location = new System.Drawing.Point(364, 23);
            this.LblDesprov.Name = "LblDesprov";
            this.LblDesprov.Size = new System.Drawing.Size(154, 26);
            this.LblDesprov.TabIndex = 45;
            this.LblDesprov.Text = "...";
            // 
            // btnBuscarProv
            // 
            this.btnBuscarProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProv.Image = global::Capa_Presentacion.Properties.Resources.Search_15px;
            this.btnBuscarProv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarProv.Location = new System.Drawing.Point(321, 24);
            this.btnBuscarProv.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnBuscarProv.Name = "btnBuscarProv";
            this.btnBuscarProv.Size = new System.Drawing.Size(35, 30);
            this.btnBuscarProv.TabIndex = 44;
            this.btnBuscarProv.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscarProv.UseVisualStyleBackColor = true;
            this.btnBuscarProv.Click += new System.EventHandler(this.btnBuscarProv_Click);
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
            this.cbTipoComprobante.Location = new System.Drawing.Point(765, 20);
            this.cbTipoComprobante.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipoComprobante.Name = "cbTipoComprobante";
            this.cbTipoComprobante.Size = new System.Drawing.Size(160, 33);
            this.cbTipoComprobante.TabIndex = 38;
            // 
            // ChRegistrar
            // 
            this.ChRegistrar.AutoSize = true;
            this.ChRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChRegistrar.Location = new System.Drawing.Point(5, 34);
            this.ChRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.ChRegistrar.Name = "ChRegistrar";
            this.ChRegistrar.Size = new System.Drawing.Size(14, 13);
            this.ChRegistrar.TabIndex = 37;
            this.ChRegistrar.UseVisualStyleBackColor = true;
            this.ChRegistrar.CheckedChanged += new System.EventHandler(this.ChRegistrar_CheckedChanged);
            // 
            // txtProveedor
            // 
            this.txtProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProveedor.Enabled = false;
            this.txtProveedor.Location = new System.Drawing.Point(149, 24);
            this.txtProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtProveedor.Multiline = true;
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(163, 30);
            this.txtProveedor.TabIndex = 33;
            this.txtProveedor.TextChanged += new System.EventHandler(this.txtProveedor_TextChanged);
            this.txtProveedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProveedor_KeyDown);
            // 
            // lblTComprobante
            // 
            this.lblTComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTComprobante.Location = new System.Drawing.Point(654, 22);
            this.lblTComprobante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTComprobante.Name = "lblTComprobante";
            this.lblTComprobante.Size = new System.Drawing.Size(112, 30);
            this.lblTComprobante.TabIndex = 43;
            this.lblTComprobante.Text = "Tipo Com.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Proveedor";
            // 
            // lblCorrelativa
            // 
            this.lblCorrelativa.AutoSize = true;
            this.lblCorrelativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrelativa.Location = new System.Drawing.Point(1090, 22);
            this.lblCorrelativa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorrelativa.Name = "lblCorrelativa";
            this.lblCorrelativa.Size = new System.Drawing.Size(106, 25);
            this.lblCorrelativa.TabIndex = 42;
            this.lblCorrelativa.Text = "Correlativa";
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.Location = new System.Drawing.Point(933, 20);
            this.lblSerie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(58, 25);
            this.lblSerie.TabIndex = 41;
            this.lblSerie.Text = "Serie";
            // 
            // txtCorrelativa
            // 
            this.txtCorrelativa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorrelativa.Enabled = false;
            this.txtCorrelativa.Location = new System.Drawing.Point(1204, 21);
            this.txtCorrelativa.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorrelativa.MaxLength = 8;
            this.txtCorrelativa.Multiline = true;
            this.txtCorrelativa.Name = "txtCorrelativa";
            this.txtCorrelativa.Size = new System.Drawing.Size(123, 30);
            this.txtCorrelativa.TabIndex = 40;
            // 
            // txtSerie
            // 
            this.txtSerie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSerie.Enabled = false;
            this.txtSerie.Location = new System.Drawing.Point(999, 19);
            this.txtSerie.Margin = new System.Windows.Forms.Padding(4);
            this.txtSerie.MaxLength = 4;
            this.txtSerie.Multiline = true;
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(83, 30);
            this.txtSerie.TabIndex = 39;
            // 
            // rdbIngreso
            // 
            this.rdbIngreso.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbIngreso.Checked = true;
            this.rdbIngreso.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rdbIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbIngreso.Location = new System.Drawing.Point(19, 18);
            this.rdbIngreso.Name = "rdbIngreso";
            this.rdbIngreso.Size = new System.Drawing.Size(150, 45);
            this.rdbIngreso.TabIndex = 11;
            this.rdbIngreso.TabStop = true;
            this.rdbIngreso.Text = "Ingreso";
            this.rdbIngreso.UseVisualStyleBackColor = true;
            // 
            // rdbEgreso
            // 
            this.rdbEgreso.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbEgreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEgreso.Location = new System.Drawing.Point(192, 18);
            this.rdbEgreso.Name = "rdbEgreso";
            this.rdbEgreso.Size = new System.Drawing.Size(150, 45);
            this.rdbEgreso.TabIndex = 12;
            this.rdbEgreso.TabStop = true;
            this.rdbEgreso.Text = "Egreso";
            this.rdbEgreso.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataListaMov.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataListaMov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListaMov.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo1,
            this.Nombre,
            this.Preciocompra,
            this.PrecioVenta1,
            this.Cantidad1,
            this.StockActual1});
            this.dataListaMov.EnableHeadersVisualStyles = false;
            this.dataListaMov.Location = new System.Drawing.Point(10, 238);
            this.dataListaMov.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.dataListaMov.MultiSelect = false;
            this.dataListaMov.Name = "dataListaMov";
            this.dataListaMov.RowHeadersWidth = 38;
            this.dataListaMov.Size = new System.Drawing.Size(1350, 557);
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
            this.panelHorizontal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(170)))));
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
            this.panelHorizontal.Size = new System.Drawing.Size(1398, 45);
            this.panelHorizontal.TabIndex = 64;
            this.panelHorizontal.DoubleClick += new System.EventHandler(this.panelHorizontal_DoubleClick);
            this.panelHorizontal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHorizontal_MouseMove);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackgroundImage = global::Capa_Presentacion.Properties.Resources.maximize_Checkbox_16px;
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMaximizar.Location = new System.Drawing.Point(1319, 6);
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
            this.btnRestaurar.Location = new System.Drawing.Point(1319, 6);
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
            this.btnMinimizar.Location = new System.Drawing.Point(1275, 6);
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
            this.btnCerrar.Location = new System.Drawing.Point(1363, 6);
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
            // FrmMovStock1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 900);
            this.Controls.Add(this.panelHorizontal);
            this.Controls.Add(this.tabControl1);
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
            this.tabLista.ResumeLayout(false);
            this.tabLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabGenerar.ResumeLayout(false);
            this.tabGenerar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtproducto)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtproveedor)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaMov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.panelHorizontal.ResumeLayout(false);
            this.panelHorizontal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLista;
        private System.Windows.Forms.DataGridView dataLista;
        private System.Windows.Forms.Label lblTotal;
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
        private System.Windows.Forms.TabPage tabGenerar;
        private System.Windows.Forms.RadioButton rdbIngreso;
        private System.Windows.Forms.RadioButton rdbEgreso;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LblDesprov;
        private System.Windows.Forms.Button btnBuscarProv;
        private System.Windows.Forms.ComboBox cbTipoComprobante;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label lblTComprobante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCorrelativa;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.TextBox txtCorrelativa;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.CheckBox ChRegistrar;
        private System.Windows.Forms.DataGridView Dtproveedor;
        private System.Windows.Forms.GroupBox groupBox3;
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox TxtcambioDv;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.DataGridView dataGridView1;

    }
}