namespace Capa_Presentacion
{
    partial class FrmListadoVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoVentas));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.REPORTE_VENTAPRODUCTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DVentaproducto = new Capa_Presentacion.DVentaproducto();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaIni = new System.Windows.Forms.DateTimePicker();
            this.lblFechaIni = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.btnCalculadora = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rdBVenta = new System.Windows.Forms.RadioButton();
            this.rdBPresupuesto = new System.Windows.Forms.RadioButton();
            this.ChkFactura = new System.Windows.Forms.CheckBox();
            this.Chkcaja = new System.Windows.Forms.CheckBox();
            this.btnVisualizadorArea = new System.Windows.Forms.Button();
            this.btnVisualizadorTorta = new System.Windows.Forms.Button();
            this.btnVisualizarGrafico = new System.Windows.Forms.Button();
            this.btnVisualizarLista = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttMensajeAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.lblSistemaVenta = new System.Windows.Forms.Label();
            this.panelHorizontal = new System.Windows.Forms.Panel();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pnlSeparacion = new System.Windows.Forms.Panel();
            this.chartRankingVentas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuconfventa = new System.Windows.Forms.ToolStripMenuItem();
            this.menureimpresion = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAnular = new System.Windows.Forms.ToolStripMenuItem();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.REPORTE_VENTAPRODUCTOTableAdapter = new Capa_Presentacion.DVentaproductoTableAdapters.REPORTE_VENTAPRODUCTOTableAdapter();
            this.xuiCustomGroupbox1 = new XanderUI.XUICustomGroupbox();
            this.txtPuntoventa = new System.Windows.Forms.TextBox();
            this.txtIdVenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFormapago = new System.Windows.Forms.ComboBox();
            this.xuiCustomGroupbox2 = new XanderUI.XUICustomGroupbox();
            this.xuiCustomGroupbox3 = new XanderUI.XUICustomGroupbox();
            this.dataLista = new Guna.UI.WinForms.GunaDataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razon_social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_comprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nrocomprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Letra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Neto21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totaliva21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_neto105 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totaliva105 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAE_Fechavencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formadepago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTDetalleventa = new Guna.UI.WinForms.GunaDataGridView();
            this.RdNc = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.REPORTE_VENTAPRODUCTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DVentaproducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.panelHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRankingVentas)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.xuiCustomGroupbox1.SuspendLayout();
            this.xuiCustomGroupbox2.SuspendLayout();
            this.xuiCustomGroupbox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTDetalleventa)).BeginInit();
            this.SuspendLayout();
            // 
            // REPORTE_VENTAPRODUCTOBindingSource
            // 
            this.REPORTE_VENTAPRODUCTOBindingSource.DataMember = "REPORTE_VENTAPRODUCTO";
            this.REPORTE_VENTAPRODUCTOBindingSource.DataSource = this.DVentaproducto;
            // 
            // DVentaproducto
            // 
            this.DVentaproducto.DataSetName = "DVentaproducto";
            this.DVentaproducto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 30);
            this.label1.TabIndex = 23;
            this.label1.Text = "Fecha Fin";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(204, 57);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(157, 30);
            this.dtpFechaFin.TabIndex = 17;
            // 
            // dtpFechaIni
            // 
            this.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIni.Location = new System.Drawing.Point(13, 57);
            this.dtpFechaIni.Name = "dtpFechaIni";
            this.dtpFechaIni.Size = new System.Drawing.Size(157, 30);
            this.dtpFechaIni.TabIndex = 16;
            // 
            // lblFechaIni
            // 
            this.lblFechaIni.AutoSize = true;
            this.lblFechaIni.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIni.Location = new System.Drawing.Point(15, 26);
            this.lblFechaIni.Name = "lblFechaIni";
            this.lblFechaIni.Size = new System.Drawing.Size(160, 30);
            this.lblFechaIni.TabIndex = 22;
            this.lblFechaIni.Text = "Fecha Inicio";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(247)))));
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.txtTotal.Location = new System.Drawing.Point(1032, 722);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotal.Size = new System.Drawing.Size(235, 48);
            this.txtTotal.TabIndex = 61;
            this.txtTotal.Text = "0,00";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(892, 738);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(96, 23);
            this.lblTotal.TabIndex = 60;
            this.lblTotal.Text = "TOTAL $ :";
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarExcel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarExcel.Image = global::Capa_Presentacion.Properties.Resources.Microsoft_Excel_20px;
            this.btnExportarExcel.Location = new System.Drawing.Point(49, 27);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(26, 26);
            this.btnExportarExcel.TabIndex = 29;
            this.btnExportarExcel.UseVisualStyleBackColor = true;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCalculadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculadora.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculadora.Image = global::Capa_Presentacion.Properties.Resources.Calculator_20px;
            this.btnCalculadora.Location = new System.Drawing.Point(17, 27);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(26, 26);
            this.btnCalculadora.TabIndex = 28;
            this.btnCalculadora.UseVisualStyleBackColor = true;
            this.btnCalculadora.Click += new System.EventHandler(this.btnCalculadora_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Capa_Presentacion.Properties.Resources.Edit_Property_20px;
            this.button1.Location = new System.Drawing.Point(78, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 26);
            this.button1.TabIndex = 36;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdBVenta
            // 
            this.rdBVenta.AutoSize = true;
            this.rdBVenta.Checked = true;
            this.rdBVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdBVenta.Location = new System.Drawing.Point(458, 29);
            this.rdBVenta.Name = "rdBVenta";
            this.rdBVenta.Size = new System.Drawing.Size(95, 29);
            this.rdBVenta.TabIndex = 35;
            this.rdBVenta.TabStop = true;
            this.rdBVenta.Text = "Venta :";
            this.rdBVenta.UseVisualStyleBackColor = true;
            this.rdBVenta.Click += new System.EventHandler(this.rdBVenta_Click);
            // 
            // rdBPresupuesto
            // 
            this.rdBPresupuesto.AutoSize = true;
            this.rdBPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdBPresupuesto.Location = new System.Drawing.Point(636, 62);
            this.rdBPresupuesto.Name = "rdBPresupuesto";
            this.rdBPresupuesto.Size = new System.Drawing.Size(152, 29);
            this.rdBPresupuesto.TabIndex = 34;
            this.rdBPresupuesto.Text = "  Presupuesto";
            this.rdBPresupuesto.UseVisualStyleBackColor = true;
            this.rdBPresupuesto.Click += new System.EventHandler(this.rdBPresupuesto_Click);
            // 
            // ChkFactura
            // 
            this.ChkFactura.AutoSize = true;
            this.ChkFactura.Checked = true;
            this.ChkFactura.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChkFactura.Location = new System.Drawing.Point(714, 29);
            this.ChkFactura.Name = "ChkFactura";
            this.ChkFactura.Size = new System.Drawing.Size(139, 29);
            this.ChkFactura.TabIndex = 32;
            this.ChkFactura.Text = "P. de factura";
            this.ChkFactura.UseVisualStyleBackColor = true;
            // 
            // Chkcaja
            // 
            this.Chkcaja.AutoSize = true;
            this.Chkcaja.Checked = true;
            this.Chkcaja.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Chkcaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Chkcaja.Location = new System.Drawing.Point(565, 29);
            this.Chkcaja.Name = "Chkcaja";
            this.Chkcaja.Size = new System.Drawing.Size(116, 29);
            this.Chkcaja.TabIndex = 31;
            this.Chkcaja.Text = "P. de caja";
            this.Chkcaja.UseVisualStyleBackColor = true;
            // 
            // btnVisualizadorArea
            // 
            this.btnVisualizadorArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizadorArea.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizadorArea.Image = global::Capa_Presentacion.Properties.Resources.Area_Chart_20px;
            this.btnVisualizadorArea.Location = new System.Drawing.Point(14, 56);
            this.btnVisualizadorArea.Name = "btnVisualizadorArea";
            this.btnVisualizadorArea.Size = new System.Drawing.Size(26, 26);
            this.btnVisualizadorArea.TabIndex = 30;
            this.btnVisualizadorArea.UseVisualStyleBackColor = true;
            this.btnVisualizadorArea.Click += new System.EventHandler(this.btnVisualizadorArea_Click);
            // 
            // btnVisualizadorTorta
            // 
            this.btnVisualizadorTorta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizadorTorta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizadorTorta.Image = global::Capa_Presentacion.Properties.Resources.Chart_20px;
            this.btnVisualizadorTorta.Location = new System.Drawing.Point(46, 29);
            this.btnVisualizadorTorta.Name = "btnVisualizadorTorta";
            this.btnVisualizadorTorta.Size = new System.Drawing.Size(26, 26);
            this.btnVisualizadorTorta.TabIndex = 29;
            this.btnVisualizadorTorta.UseVisualStyleBackColor = true;
            this.btnVisualizadorTorta.Click += new System.EventHandler(this.btnVisualizadorTorta_Click);
            // 
            // btnVisualizarGrafico
            // 
            this.btnVisualizarGrafico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVisualizarGrafico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizarGrafico.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarGrafico.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizarGrafico.Image")));
            this.btnVisualizarGrafico.Location = new System.Drawing.Point(14, 29);
            this.btnVisualizarGrafico.Name = "btnVisualizarGrafico";
            this.btnVisualizarGrafico.Size = new System.Drawing.Size(26, 26);
            this.btnVisualizarGrafico.TabIndex = 27;
            this.btnVisualizarGrafico.UseVisualStyleBackColor = true;
            this.btnVisualizarGrafico.Click += new System.EventHandler(this.btnVisualizarGrafico_Click);
            // 
            // btnVisualizarLista
            // 
            this.btnVisualizarLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizarLista.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizarLista.Image = global::Capa_Presentacion.Properties.Resources.List_20px;
            this.btnVisualizarLista.Location = new System.Drawing.Point(46, 56);
            this.btnVisualizarLista.Name = "btnVisualizarLista";
            this.btnVisualizarLista.Size = new System.Drawing.Size(26, 26);
            this.btnVisualizarLista.TabIndex = 26;
            this.btnVisualizarLista.UseVisualStyleBackColor = true;
            this.btnVisualizarLista.Click += new System.EventHandler(this.btnVisualizarLista_Click);
            // 
            // btnTodos
            // 
            this.btnTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodos.Image = global::Capa_Presentacion.Properties.Resources.Select_All_20px;
            this.btnTodos.Location = new System.Drawing.Point(411, 55);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(26, 28);
            this.btnTodos.TabIndex = 24;
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::Capa_Presentacion.Properties.Resources.Search_15px;
            this.btnBuscar.Location = new System.Drawing.Point(379, 55);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(26, 28);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // ttMensajeAyuda
            // 
            this.ttMensajeAyuda.AutomaticDelay = 90;
            // 
            // lblSistemaVenta
            // 
            this.lblSistemaVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSistemaVenta.AutoSize = true;
            this.lblSistemaVenta.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistemaVenta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSistemaVenta.Location = new System.Drawing.Point(3, 6);
            this.lblSistemaVenta.Name = "lblSistemaVenta";
            this.lblSistemaVenta.Size = new System.Drawing.Size(200, 28);
            this.lblSistemaVenta.TabIndex = 3;
            this.lblSistemaVenta.Text = "LISTA DE VENTAS";
            this.lblSistemaVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.panelHorizontal.Name = "panelHorizontal";
            this.panelHorizontal.Size = new System.Drawing.Size(1284, 37);
            this.panelHorizontal.TabIndex = 64;
            this.panelHorizontal.DoubleClick += new System.EventHandler(this.panelHorizontal_DoubleClick);
            this.panelHorizontal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHorizontal_MouseMove);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackgroundImage = global::Capa_Presentacion.Properties.Resources.maximize_Checkbox_16px;
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMaximizar.Location = new System.Drawing.Point(1224, 5);
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
            this.btnRestaurar.BackgroundImage = global::Capa_Presentacion.Properties.Resources.Restore_Window_20px;
            this.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRestaurar.Location = new System.Drawing.Point(1224, 5);
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
            this.btnMinimizar.BackgroundImage = global::Capa_Presentacion.Properties.Resources.Minus_20px;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimizar.Location = new System.Drawing.Point(1191, 5);
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
            this.btnCerrar.BackgroundImage = global::Capa_Presentacion.Properties.Resources.Delete_20px;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCerrar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.ErrorImage")));
            this.btnCerrar.Location = new System.Drawing.Point(1257, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(22, 25);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            this.btnCerrar.MouseLeave += new System.EventHandler(this.btnCerrar_MouseLeave);
            this.btnCerrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCerrar_MouseMove);
            // 
            // pnlSeparacion
            // 
            this.pnlSeparacion.Location = new System.Drawing.Point(0, 0);
            this.pnlSeparacion.Name = "pnlSeparacion";
            this.pnlSeparacion.Size = new System.Drawing.Size(200, 100);
            this.pnlSeparacion.TabIndex = 0;
            // 
            // chartRankingVentas
            // 
            this.chartRankingVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartRankingVentas.BackColor = System.Drawing.Color.Transparent;
            this.chartRankingVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.chartRankingVentas.BorderlineWidth = 3;
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.Name = "ChartArea1";
            this.chartRankingVentas.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartRankingVentas.Legends.Add(legend2);
            this.chartRankingVentas.Location = new System.Drawing.Point(11, 227);
            this.chartRankingVentas.Name = "chartRankingVentas";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Ventas";
            this.chartRankingVentas.Series.Add(series2);
            this.chartRankingVentas.Size = new System.Drawing.Size(1260, 365);
            this.chartRankingVentas.TabIndex = 65;
            title2.Name = "Ventas";
            this.chartRankingVentas.Titles.Add(title2);
            this.chartRankingVentas.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuconfventa,
            this.menureimpresion,
            this.MenuAnular});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 76);
            // 
            // menuconfventa
            // 
            this.menuconfventa.Name = "menuconfventa";
            this.menuconfventa.Size = new System.Drawing.Size(184, 24);
            this.menuconfventa.Text = "Confirmar venta";
            this.menuconfventa.Click += new System.EventHandler(this.menuconfventa_Click);
            // 
            // menureimpresion
            // 
            this.menureimpresion.Name = "menureimpresion";
            this.menureimpresion.Size = new System.Drawing.Size(184, 24);
            this.menureimpresion.Text = "Re-imprimir";
            this.menureimpresion.Click += new System.EventHandler(this.menureimpresion_Click);
            // 
            // MenuAnular
            // 
            this.MenuAnular.Name = "MenuAnular";
            this.MenuAnular.Size = new System.Drawing.Size(184, 24);
            this.MenuAnular.Text = "Anular";
            this.MenuAnular.Click += new System.EventHandler(this.MenuAnular_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "Dvproducto";
            reportDataSource2.Value = this.REPORTE_VENTAPRODUCTOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa_Presentacion.Reporteproductoventa.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(10, 216);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1263, 369);
            this.reportViewer1.TabIndex = 67;
            this.reportViewer1.Visible = false;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // REPORTE_VENTAPRODUCTOTableAdapter
            // 
            this.REPORTE_VENTAPRODUCTOTableAdapter.ClearBeforeFill = true;
            // 
            // xuiCustomGroupbox1
            // 
            this.xuiCustomGroupbox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xuiCustomGroupbox1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.xuiCustomGroupbox1.BorderWidth = 1;
            this.xuiCustomGroupbox1.Controls.Add(this.RdNc);
            this.xuiCustomGroupbox1.Controls.Add(this.txtPuntoventa);
            this.xuiCustomGroupbox1.Controls.Add(this.txtIdVenta);
            this.xuiCustomGroupbox1.Controls.Add(this.label4);
            this.xuiCustomGroupbox1.Controls.Add(this.label2);
            this.xuiCustomGroupbox1.Controls.Add(this.label3);
            this.xuiCustomGroupbox1.Controls.Add(this.cbFormapago);
            this.xuiCustomGroupbox1.Controls.Add(this.rdBVenta);
            this.xuiCustomGroupbox1.Controls.Add(this.Chkcaja);
            this.xuiCustomGroupbox1.Controls.Add(this.ChkFactura);
            this.xuiCustomGroupbox1.Controls.Add(this.label1);
            this.xuiCustomGroupbox1.Controls.Add(this.rdBPresupuesto);
            this.xuiCustomGroupbox1.Controls.Add(this.lblFechaIni);
            this.xuiCustomGroupbox1.Controls.Add(this.btnBuscar);
            this.xuiCustomGroupbox1.Controls.Add(this.dtpFechaIni);
            this.xuiCustomGroupbox1.Controls.Add(this.btnTodos);
            this.xuiCustomGroupbox1.Controls.Add(this.dtpFechaFin);
            this.xuiCustomGroupbox1.Location = new System.Drawing.Point(9, 43);
            this.xuiCustomGroupbox1.Name = "xuiCustomGroupbox1";
            this.xuiCustomGroupbox1.ShowText = true;
            this.xuiCustomGroupbox1.Size = new System.Drawing.Size(1113, 169);
            this.xuiCustomGroupbox1.TabIndex = 68;
            this.xuiCustomGroupbox1.TabStop = false;
            this.xuiCustomGroupbox1.Text = "Busqueda avanzada :";
            this.xuiCustomGroupbox1.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // txtPuntoventa
            // 
            this.txtPuntoventa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPuntoventa.Location = new System.Drawing.Point(424, 119);
            this.txtPuntoventa.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.txtPuntoventa.Name = "txtPuntoventa";
            this.txtPuntoventa.Size = new System.Drawing.Size(88, 30);
            this.txtPuntoventa.TabIndex = 39;
            this.txtPuntoventa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPuntoventa_KeyDown);
            // 
            // txtIdVenta
            // 
            this.txtIdVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdVenta.Location = new System.Drawing.Point(108, 118);
            this.txtIdVenta.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.txtIdVenta.Name = "txtIdVenta";
            this.txtIdVenta.Size = new System.Drawing.Size(120, 30);
            this.txtIdVenta.TabIndex = 39;
            this.txtIdVenta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIdVenta_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 38;
            this.label4.Text = "Nº Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "Nº Punto de venta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(542, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 38;
            this.label3.Text = "Forma de pago :";
            // 
            // cbFormapago
            // 
            this.cbFormapago.AutoCompleteCustomSource.AddRange(new string[] {
            "EFECTIVO",
            "TARJETA",
            "TODO"});
            this.cbFormapago.FormattingEnabled = true;
            this.cbFormapago.Items.AddRange(new object[] {
            "EFECTIVO",
            "TARJETA",
            "TODO",
            "CTACTE",
            "MULTIPLESPAGOS"});
            this.cbFormapago.Location = new System.Drawing.Point(714, 119);
            this.cbFormapago.Name = "cbFormapago";
            this.cbFormapago.Size = new System.Drawing.Size(197, 33);
            this.cbFormapago.TabIndex = 37;
            // 
            // xuiCustomGroupbox2
            // 
            this.xuiCustomGroupbox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xuiCustomGroupbox2.BorderColor = System.Drawing.Color.DodgerBlue;
            this.xuiCustomGroupbox2.BorderWidth = 1;
            this.xuiCustomGroupbox2.Controls.Add(this.button1);
            this.xuiCustomGroupbox2.Controls.Add(this.btnVisualizadorArea);
            this.xuiCustomGroupbox2.Controls.Add(this.btnVisualizarGrafico);
            this.xuiCustomGroupbox2.Controls.Add(this.btnVisualizadorTorta);
            this.xuiCustomGroupbox2.Controls.Add(this.btnVisualizarLista);
            this.xuiCustomGroupbox2.Location = new System.Drawing.Point(1128, 111);
            this.xuiCustomGroupbox2.Name = "xuiCustomGroupbox2";
            this.xuiCustomGroupbox2.ShowText = true;
            this.xuiCustomGroupbox2.Size = new System.Drawing.Size(144, 100);
            this.xuiCustomGroupbox2.TabIndex = 69;
            this.xuiCustomGroupbox2.TabStop = false;
            this.xuiCustomGroupbox2.Text = "Visualizador :";
            this.xuiCustomGroupbox2.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // xuiCustomGroupbox3
            // 
            this.xuiCustomGroupbox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xuiCustomGroupbox3.BorderColor = System.Drawing.Color.DodgerBlue;
            this.xuiCustomGroupbox3.BorderWidth = 1;
            this.xuiCustomGroupbox3.Controls.Add(this.btnExportarExcel);
            this.xuiCustomGroupbox3.Controls.Add(this.btnCalculadora);
            this.xuiCustomGroupbox3.Location = new System.Drawing.Point(1128, 44);
            this.xuiCustomGroupbox3.Name = "xuiCustomGroupbox3";
            this.xuiCustomGroupbox3.ShowText = true;
            this.xuiCustomGroupbox3.Size = new System.Drawing.Size(145, 61);
            this.xuiCustomGroupbox3.TabIndex = 70;
            this.xuiCustomGroupbox3.TabStop = false;
            this.xuiCustomGroupbox3.Text = "Herramientas :";
            this.xuiCustomGroupbox3.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // dataLista
            // 
            this.dataLista.AllowUserToAddRows = false;
            this.dataLista.AllowUserToDeleteRows = false;
            this.dataLista.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dataLista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataLista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataLista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataLista.BackgroundColor = System.Drawing.Color.White;
            this.dataLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataLista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataLista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataLista.ColumnHeadersHeight = 38;
            this.dataLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.razon_social,
            this.Fecha,
            this.Tipo_comprobante,
            this.Total,
            this.Estado,
            this.Caja,
            this.idcliente,
            this.Cuit,
            this.Nrocomprobante,
            this.Letra,
            this.Neto21,
            this.Totaliva21,
            this.Total_neto105,
            this.Totaliva105,
            this.CAE,
            this.CAE_Fechavencimiento,
            this.Stock,
            this.formadepago,
            this.Pago});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataLista.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataLista.EnableHeadersVisualStyles = false;
            this.dataLista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataLista.Location = new System.Drawing.Point(9, 215);
            this.dataLista.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataLista.MultiSelect = false;
            this.dataLista.Name = "dataLista";
            this.dataLista.RowHeadersVisible = false;
            this.dataLista.RowHeadersWidth = 51;
            this.dataLista.RowTemplate.Height = 24;
            this.dataLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataLista.Size = new System.Drawing.Size(1263, 361);
            this.dataLista.StandardTab = true;
            this.dataLista.TabIndex = 106;
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
            this.dataLista.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLista.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataLista.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataLista.ThemeStyle.HeaderStyle.Height = 38;
            this.dataLista.ThemeStyle.ReadOnly = false;
            this.dataLista.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataLista.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataLista.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataLista.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataLista.ThemeStyle.RowsStyle.Height = 24;
            this.dataLista.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataLista.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLista_CellClick);
            this.dataLista.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataLista_CellMouseDoubleClick_1);
            this.dataLista.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLista_RowLeave);
            this.dataLista.SelectionChanged += new System.EventHandler(this.dataLista_SelectionChanged);
            this.dataLista.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataLista_KeyDown);
            this.dataLista.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataLista_MouseClick);
            // 
            // Codigo
            // 
            this.Codigo.FillWeight = 61.54822F;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            // 
            // razon_social
            // 
            this.razon_social.FillWeight = 253.8071F;
            this.razon_social.HeaderText = "Razon_social";
            this.razon_social.MinimumWidth = 6;
            this.razon_social.Name = "razon_social";
            // 
            // Fecha
            // 
            this.Fecha.FillWeight = 61.54822F;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            // 
            // Tipo_comprobante
            // 
            this.Tipo_comprobante.FillWeight = 61.54822F;
            this.Tipo_comprobante.HeaderText = "Tipo_comprobante";
            this.Tipo_comprobante.MinimumWidth = 6;
            this.Tipo_comprobante.Name = "Tipo_comprobante";
            // 
            // Total
            // 
            this.Total.FillWeight = 61.54822F;
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            // 
            // Caja
            // 
            this.Caja.HeaderText = "caja";
            this.Caja.MinimumWidth = 6;
            this.Caja.Name = "Caja";
            // 
            // idcliente
            // 
            this.idcliente.HeaderText = "idcliente";
            this.idcliente.MinimumWidth = 6;
            this.idcliente.Name = "idcliente";
            // 
            // Cuit
            // 
            this.Cuit.HeaderText = "cuit";
            this.Cuit.MinimumWidth = 6;
            this.Cuit.Name = "Cuit";
            // 
            // Nrocomprobante
            // 
            this.Nrocomprobante.HeaderText = "Nrocomprobante";
            this.Nrocomprobante.MinimumWidth = 6;
            this.Nrocomprobante.Name = "Nrocomprobante";
            // 
            // Letra
            // 
            this.Letra.HeaderText = "Letra";
            this.Letra.MinimumWidth = 6;
            this.Letra.Name = "Letra";
            // 
            // Neto21
            // 
            this.Neto21.HeaderText = "Neto21";
            this.Neto21.MinimumWidth = 6;
            this.Neto21.Name = "Neto21";
            this.Neto21.Visible = false;
            // 
            // Totaliva21
            // 
            this.Totaliva21.HeaderText = "Totaliva21";
            this.Totaliva21.MinimumWidth = 6;
            this.Totaliva21.Name = "Totaliva21";
            this.Totaliva21.Visible = false;
            // 
            // Total_neto105
            // 
            this.Total_neto105.HeaderText = "Total_neto105";
            this.Total_neto105.MinimumWidth = 6;
            this.Total_neto105.Name = "Total_neto105";
            this.Total_neto105.Visible = false;
            // 
            // Totaliva105
            // 
            this.Totaliva105.HeaderText = "Totaliva105";
            this.Totaliva105.MinimumWidth = 6;
            this.Totaliva105.Name = "Totaliva105";
            this.Totaliva105.Visible = false;
            // 
            // CAE
            // 
            this.CAE.HeaderText = "CAE";
            this.CAE.MinimumWidth = 6;
            this.CAE.Name = "CAE";
            this.CAE.Visible = false;
            // 
            // CAE_Fechavencimiento
            // 
            this.CAE_Fechavencimiento.HeaderText = "Caefechavencimiento";
            this.CAE_Fechavencimiento.MinimumWidth = 6;
            this.CAE_Fechavencimiento.Name = "CAE_Fechavencimiento";
            this.CAE_Fechavencimiento.Visible = false;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "enstock";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            this.Stock.Visible = false;
            // 
            // formadepago
            // 
            this.formadepago.HeaderText = "Forma de pago";
            this.formadepago.MinimumWidth = 6;
            this.formadepago.Name = "formadepago";
            this.formadepago.Visible = false;
            // 
            // Pago
            // 
            this.Pago.HeaderText = "Pago";
            this.Pago.MinimumWidth = 6;
            this.Pago.Name = "Pago";
            // 
            // DTDetalleventa
            // 
            this.DTDetalleventa.AllowUserToAddRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.DTDetalleventa.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DTDetalleventa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DTDetalleventa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DTDetalleventa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DTDetalleventa.BackgroundColor = System.Drawing.Color.White;
            this.DTDetalleventa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DTDetalleventa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DTDetalleventa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTDetalleventa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.DTDetalleventa.ColumnHeadersHeight = 38;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DTDetalleventa.DefaultCellStyle = dataGridViewCellStyle12;
            this.DTDetalleventa.EnableHeadersVisualStyles = false;
            this.DTDetalleventa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DTDetalleventa.Location = new System.Drawing.Point(15, 602);
            this.DTDetalleventa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DTDetalleventa.Name = "DTDetalleventa";
            this.DTDetalleventa.ReadOnly = true;
            this.DTDetalleventa.RowHeadersVisible = false;
            this.DTDetalleventa.RowHeadersWidth = 51;
            this.DTDetalleventa.RowTemplate.Height = 24;
            this.DTDetalleventa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTDetalleventa.Size = new System.Drawing.Size(1249, 100);
            this.DTDetalleventa.TabIndex = 108;
            this.DTDetalleventa.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DTDetalleventa.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DTDetalleventa.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DTDetalleventa.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DTDetalleventa.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DTDetalleventa.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DTDetalleventa.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DTDetalleventa.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DTDetalleventa.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DTDetalleventa.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DTDetalleventa.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTDetalleventa.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DTDetalleventa.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DTDetalleventa.ThemeStyle.HeaderStyle.Height = 38;
            this.DTDetalleventa.ThemeStyle.ReadOnly = true;
            this.DTDetalleventa.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DTDetalleventa.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DTDetalleventa.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTDetalleventa.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DTDetalleventa.ThemeStyle.RowsStyle.Height = 24;
            this.DTDetalleventa.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DTDetalleventa.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // RdNc
            // 
            this.RdNc.AutoSize = true;
            this.RdNc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RdNc.Location = new System.Drawing.Point(459, 60);
            this.RdNc.Name = "RdNc";
            this.RdNc.Size = new System.Drawing.Size(163, 29);
            this.RdNc.TabIndex = 41;
            this.RdNc.Text = "Nota de credito";
            this.RdNc.UseVisualStyleBackColor = true;
            // 
            // FrmListadoVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1284, 790);
            this.Controls.Add(this.xuiCustomGroupbox3);
            this.Controls.Add(this.xuiCustomGroupbox2);
            this.Controls.Add(this.xuiCustomGroupbox1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.chartRankingVentas);
            this.Controls.Add(this.panelHorizontal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dataLista);
            this.Controls.Add(this.DTDetalleventa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmListadoVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Ventas";
            this.Load += new System.EventHandler(this.FrmListadoVentas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmListadoVentas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.REPORTE_VENTAPRODUCTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DVentaproducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.panelHorizontal.ResumeLayout(false);
            this.panelHorizontal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRankingVentas)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.xuiCustomGroupbox1.ResumeLayout(false);
            this.xuiCustomGroupbox1.PerformLayout();
            this.xuiCustomGroupbox2.ResumeLayout(false);
            this.xuiCustomGroupbox2.PerformLayout();
            this.xuiCustomGroupbox3.ResumeLayout(false);
            this.xuiCustomGroupbox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTDetalleventa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaIni;
        private System.Windows.Forms.Label lblFechaIni;
        private System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.ToolTip ttMensajeAyuda;
        private System.Windows.Forms.Panel panelHorizontal;
        private System.Windows.Forms.Panel pnlSeparacion;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.Label lblSistemaVenta;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Button btnVisualizarGrafico;
        private System.Windows.Forms.Button btnVisualizarLista;
        private System.Windows.Forms.Button btnCalculadora;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRankingVentas;
        private System.Windows.Forms.Button btnVisualizadorTorta;
        private System.Windows.Forms.Button btnVisualizadorArea;
        private System.Windows.Forms.CheckBox ChkFactura;
        private System.Windows.Forms.CheckBox Chkcaja;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuconfventa;
        private System.Windows.Forms.ToolStripMenuItem menureimpresion;
        private System.Windows.Forms.RadioButton rdBVenta;
        private System.Windows.Forms.RadioButton rdBPresupuesto;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource REPORTE_VENTAPRODUCTOBindingSource;
        private DVentaproducto DVentaproducto;
        private DVentaproductoTableAdapters.REPORTE_VENTAPRODUCTOTableAdapter REPORTE_VENTAPRODUCTOTableAdapter;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox1;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox3;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox2;
        private Guna.UI.WinForms.GunaDataGridView dataLista;
        private Guna.UI.WinForms.GunaDataGridView DTDetalleventa;
        private System.Windows.Forms.ToolStripMenuItem MenuAnular;
        private System.Windows.Forms.ComboBox cbFormapago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPuntoventa;
        private System.Windows.Forms.TextBox txtIdVenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn razon_social;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_comprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caja;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nrocomprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Letra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Neto21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Totaliva21;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_neto105;
        private System.Windows.Forms.DataGridViewTextBoxColumn Totaliva105;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAE_Fechavencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn formadepago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pago;
        private System.Windows.Forms.RadioButton RdNc;
    }
}