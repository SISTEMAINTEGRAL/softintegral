﻿namespace Capa_Presentacion
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.REPORTE_VENTAPRODUCTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DVentaproducto = new Capa_Presentacion.DVentaproducto();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaIni = new System.Windows.Forms.DateTimePicker();
            this.dataLista = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razon_social = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_comprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFechaIni = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.gbxConsultasAvanzadas = new System.Windows.Forms.GroupBox();
            this.gbxHerramientas = new System.Windows.Forms.GroupBox();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.btnCalculadora = new System.Windows.Forms.Button();
            this.gbxVisualizar = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rdBVenta = new System.Windows.Forms.RadioButton();
            this.rdBPresupuesto = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.DTDetalleventa = new System.Windows.Forms.DataGridView();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.REPORTE_VENTAPRODUCTOTableAdapter = new Capa_Presentacion.DVentaproductoTableAdapters.REPORTE_VENTAPRODUCTOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.REPORTE_VENTAPRODUCTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DVentaproducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).BeginInit();
            this.gbxConsultasAvanzadas.SuspendLayout();
            this.gbxHerramientas.SuspendLayout();
            this.gbxVisualizar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.panelHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRankingVentas)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(201, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 30);
            this.label1.TabIndex = 23;
            this.label1.Text = "Fecha Fin";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(205, 59);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(157, 30);
            this.dtpFechaFin.TabIndex = 17;
            // 
            // dtpFechaIni
            // 
            this.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIni.Location = new System.Drawing.Point(14, 59);
            this.dtpFechaIni.Name = "dtpFechaIni";
            this.dtpFechaIni.Size = new System.Drawing.Size(157, 30);
            this.dtpFechaIni.TabIndex = 16;
            // 
            // dataLista
            // 
            this.dataLista.AllowUserToAddRows = false;
            this.dataLista.AllowUserToDeleteRows = false;
            this.dataLista.AllowUserToOrderColumns = true;
            this.dataLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.razon_social,
            this.Fecha,
            this.Tipo_comprobante,
            this.Total,
            this.Estado,
            this.caja,
            this.idcliente,
            this.cuit});
            this.dataLista.Location = new System.Drawing.Point(22, 142);
            this.dataLista.MultiSelect = false;
            this.dataLista.Name = "dataLista";
            this.dataLista.ReadOnly = true;
            this.dataLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataLista.Size = new System.Drawing.Size(1032, 348);
            this.dataLista.TabIndex = 21;
            this.dataLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLista_CellClick);
            this.dataLista.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataLista_CellMouseDoubleClick_1);
            this.dataLista.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLista_RowLeave);
            this.dataLista.SelectionChanged += new System.EventHandler(this.dataLista_SelectionChanged);
            this.dataLista.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataLista_KeyDown);
            this.dataLista.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataLista_MouseClick);
            // 
            // Codigo
            // 
            this.Codigo.FillWeight = 97.36993F;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // razon_social
            // 
            this.razon_social.FillWeight = 97.36993F;
            this.razon_social.HeaderText = "Razon_social";
            this.razon_social.Name = "razon_social";
            this.razon_social.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.FillWeight = 97.36993F;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Tipo_comprobante
            // 
            this.Tipo_comprobante.FillWeight = 97.36993F;
            this.Tipo_comprobante.HeaderText = "Tipo_comprobante";
            this.Tipo_comprobante.Name = "Tipo_comprobante";
            this.Tipo_comprobante.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.FillWeight = 97.36993F;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.FillWeight = 97.36993F;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // caja
            // 
            this.caja.FillWeight = 23.79567F;
            this.caja.HeaderText = "Caja";
            this.caja.Name = "caja";
            this.caja.ReadOnly = true;
            // 
            // idcliente
            // 
            this.idcliente.FillWeight = 40.6599F;
            this.idcliente.HeaderText = "Idcliente";
            this.idcliente.Name = "idcliente";
            this.idcliente.ReadOnly = true;
            // 
            // cuit
            // 
            this.cuit.FillWeight = 152.3249F;
            this.cuit.HeaderText = "Cuit";
            this.cuit.Name = "cuit";
            this.cuit.ReadOnly = true;
            // 
            // lblFechaIni
            // 
            this.lblFechaIni.AutoSize = true;
            this.lblFechaIni.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIni.Location = new System.Drawing.Point(16, 28);
            this.lblFechaIni.Name = "lblFechaIni";
            this.lblFechaIni.Size = new System.Drawing.Size(160, 30);
            this.lblFechaIni.TabIndex = 22;
            this.lblFechaIni.Text = "Fecha Inicio";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.txtTotal.Location = new System.Drawing.Point(773, 605);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotal.Size = new System.Drawing.Size(265, 48);
            this.txtTotal.TabIndex = 61;
            this.txtTotal.Text = "0,00";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(663, 618);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(96, 23);
            this.lblTotal.TabIndex = 60;
            this.lblTotal.Text = "TOTAL $ :";
            // 
            // gbxConsultasAvanzadas
            // 
            this.gbxConsultasAvanzadas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxConsultasAvanzadas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbxConsultasAvanzadas.Controls.Add(this.gbxHerramientas);
            this.gbxConsultasAvanzadas.Controls.Add(this.gbxVisualizar);
            this.gbxConsultasAvanzadas.Controls.Add(this.lblFechaIni);
            this.gbxConsultasAvanzadas.Controls.Add(this.dtpFechaIni);
            this.gbxConsultasAvanzadas.Controls.Add(this.dtpFechaFin);
            this.gbxConsultasAvanzadas.Controls.Add(this.btnTodos);
            this.gbxConsultasAvanzadas.Controls.Add(this.label1);
            this.gbxConsultasAvanzadas.Controls.Add(this.btnBuscar);
            this.gbxConsultasAvanzadas.Location = new System.Drawing.Point(9, 42);
            this.gbxConsultasAvanzadas.Name = "gbxConsultasAvanzadas";
            this.gbxConsultasAvanzadas.Size = new System.Drawing.Size(1047, 94);
            this.gbxConsultasAvanzadas.TabIndex = 62;
            this.gbxConsultasAvanzadas.TabStop = false;
            this.gbxConsultasAvanzadas.Text = "Consultas Avanzadas";
            // 
            // gbxHerramientas
            // 
            this.gbxHerramientas.Controls.Add(this.btnExportarExcel);
            this.gbxHerramientas.Controls.Add(this.btnCalculadora);
            this.gbxHerramientas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxHerramientas.Location = new System.Drawing.Point(462, 14);
            this.gbxHerramientas.Name = "gbxHerramientas";
            this.gbxHerramientas.Size = new System.Drawing.Size(127, 73);
            this.gbxHerramientas.TabIndex = 28;
            this.gbxHerramientas.TabStop = false;
            this.gbxHerramientas.Text = "herramientas";
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarExcel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarExcel.Image = global::Capa_Presentacion.Properties.Resources.Microsoft_Excel_20px;
            this.btnExportarExcel.Location = new System.Drawing.Point(42, 28);
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
            this.btnCalculadora.Location = new System.Drawing.Point(10, 28);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(26, 26);
            this.btnCalculadora.TabIndex = 28;
            this.btnCalculadora.UseVisualStyleBackColor = true;
            this.btnCalculadora.Click += new System.EventHandler(this.btnCalculadora_Click);
            // 
            // gbxVisualizar
            // 
            this.gbxVisualizar.Controls.Add(this.button1);
            this.gbxVisualizar.Controls.Add(this.rdBVenta);
            this.gbxVisualizar.Controls.Add(this.rdBPresupuesto);
            this.gbxVisualizar.Controls.Add(this.groupBox1);
            this.gbxVisualizar.Controls.Add(this.btnVisualizadorArea);
            this.gbxVisualizar.Controls.Add(this.btnVisualizadorTorta);
            this.gbxVisualizar.Controls.Add(this.btnVisualizarGrafico);
            this.gbxVisualizar.Controls.Add(this.btnVisualizarLista);
            this.gbxVisualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxVisualizar.Location = new System.Drawing.Point(595, 12);
            this.gbxVisualizar.Name = "gbxVisualizar";
            this.gbxVisualizar.Size = new System.Drawing.Size(445, 76);
            this.gbxVisualizar.TabIndex = 25;
            this.gbxVisualizar.TabStop = false;
            this.gbxVisualizar.Text = "visualizador";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Capa_Presentacion.Properties.Resources.Edit_Property_20px;
            this.button1.Location = new System.Drawing.Point(71, 28);
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
            this.rdBVenta.Location = new System.Drawing.Point(135, 46);
            this.rdBVenta.Name = "rdBVenta";
            this.rdBVenta.Size = new System.Drawing.Size(16, 15);
            this.rdBVenta.TabIndex = 35;
            this.rdBVenta.TabStop = true;
            this.rdBVenta.UseVisualStyleBackColor = true;
            this.rdBVenta.Click += new System.EventHandler(this.rdBVenta_Click);
            // 
            // rdBPresupuesto
            // 
            this.rdBPresupuesto.AutoSize = true;
            this.rdBPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdBPresupuesto.Location = new System.Drawing.Point(134, 12);
            this.rdBPresupuesto.Name = "rdBPresupuesto";
            this.rdBPresupuesto.Size = new System.Drawing.Size(188, 24);
            this.rdBPresupuesto.TabIndex = 34;
            this.rdBPresupuesto.Text = "             Presupuesto";
            this.rdBPresupuesto.UseVisualStyleBackColor = true;
            this.rdBPresupuesto.Click += new System.EventHandler(this.rdBPresupuesto_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChkFactura);
            this.groupBox1.Controls.Add(this.Chkcaja);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(163, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 40);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Venta";
            // 
            // ChkFactura
            // 
            this.ChkFactura.AutoSize = true;
            this.ChkFactura.Checked = true;
            this.ChkFactura.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChkFactura.Location = new System.Drawing.Point(7, 17);
            this.ChkFactura.Name = "ChkFactura";
            this.ChkFactura.Size = new System.Drawing.Size(122, 24);
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
            this.Chkcaja.Location = new System.Drawing.Point(134, 17);
            this.Chkcaja.Name = "Chkcaja";
            this.Chkcaja.Size = new System.Drawing.Size(101, 24);
            this.Chkcaja.TabIndex = 31;
            this.Chkcaja.Text = "P. de caja";
            this.Chkcaja.UseVisualStyleBackColor = true;
            // 
            // btnVisualizadorArea
            // 
            this.btnVisualizadorArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizadorArea.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizadorArea.Image = global::Capa_Presentacion.Properties.Resources.Area_Chart_20px;
            this.btnVisualizadorArea.Location = new System.Drawing.Point(7, 45);
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
            this.btnVisualizadorTorta.Location = new System.Drawing.Point(39, 18);
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
            this.btnVisualizarGrafico.Location = new System.Drawing.Point(7, 18);
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
            this.btnVisualizarLista.Location = new System.Drawing.Point(39, 45);
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
            this.btnTodos.Location = new System.Drawing.Point(412, 57);
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
            this.btnBuscar.Location = new System.Drawing.Point(380, 57);
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
            this.panelHorizontal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(170)))));
            this.panelHorizontal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHorizontal.Controls.Add(this.btnMaximizar);
            this.panelHorizontal.Controls.Add(this.btnRestaurar);
            this.panelHorizontal.Controls.Add(this.btnMinimizar);
            this.panelHorizontal.Controls.Add(this.btnCerrar);
            this.panelHorizontal.Controls.Add(this.lblSistemaVenta);
            this.panelHorizontal.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHorizontal.Location = new System.Drawing.Point(0, 0);
            this.panelHorizontal.Name = "panelHorizontal";
            this.panelHorizontal.Size = new System.Drawing.Size(1063, 37);
            this.panelHorizontal.TabIndex = 64;
            this.panelHorizontal.DoubleClick += new System.EventHandler(this.panelHorizontal_DoubleClick);
            this.panelHorizontal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHorizontal_MouseMove);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackgroundImage = global::Capa_Presentacion.Properties.Resources.maximize_Checkbox_16px;
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMaximizar.Location = new System.Drawing.Point(1003, 5);
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
            this.btnRestaurar.Location = new System.Drawing.Point(1003, 5);
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
            this.btnMinimizar.Location = new System.Drawing.Point(970, 5);
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
            this.btnCerrar.Location = new System.Drawing.Point(1036, 5);
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
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Name = "ChartArea1";
            this.chartRankingVentas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRankingVentas.Legends.Add(legend1);
            this.chartRankingVentas.Location = new System.Drawing.Point(25, 145);
            this.chartRankingVentas.Name = "chartRankingVentas";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Ventas";
            this.chartRankingVentas.Series.Add(series1);
            this.chartRankingVentas.Size = new System.Drawing.Size(1028, 345);
            this.chartRankingVentas.TabIndex = 65;
            title1.Name = "Ventas";
            this.chartRankingVentas.Titles.Add(title1);
            this.chartRankingVentas.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuconfventa,
            this.menureimpresion});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 52);
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
            // DTDetalleventa
            // 
            this.DTDetalleventa.AllowUserToAddRows = false;
            this.DTDetalleventa.AllowUserToDeleteRows = false;
            this.DTDetalleventa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DTDetalleventa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DTDetalleventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTDetalleventa.Location = new System.Drawing.Point(22, 497);
            this.DTDetalleventa.Name = "DTDetalleventa";
            this.DTDetalleventa.ReadOnly = true;
            this.DTDetalleventa.Size = new System.Drawing.Size(1030, 98);
            this.DTDetalleventa.TabIndex = 66;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "Dvproducto";
            reportDataSource1.Value = this.REPORTE_VENTAPRODUCTOBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Capa_Presentacion.Reporteproductoventa.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(24, 142);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1031, 350);
            this.reportViewer1.TabIndex = 67;
            this.reportViewer1.Visible = false;
            // 
            // REPORTE_VENTAPRODUCTOTableAdapter
            // 
            this.REPORTE_VENTAPRODUCTOTableAdapter.ClearBeforeFill = true;
            // 
            // FrmListadoVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1063, 697);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.DTDetalleventa);
            this.Controls.Add(this.chartRankingVentas);
            this.Controls.Add(this.panelHorizontal);
            this.Controls.Add(this.gbxConsultasAvanzadas);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dataLista);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmListadoVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Ventas";
            this.Load += new System.EventHandler(this.FrmListadoVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.REPORTE_VENTAPRODUCTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DVentaproducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).EndInit();
            this.gbxConsultasAvanzadas.ResumeLayout(false);
            this.gbxConsultasAvanzadas.PerformLayout();
            this.gbxHerramientas.ResumeLayout(false);
            this.gbxVisualizar.ResumeLayout(false);
            this.gbxVisualizar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.panelHorizontal.ResumeLayout(false);
            this.panelHorizontal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRankingVentas)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DTDetalleventa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaIni;
        private System.Windows.Forms.DataGridView dataLista;
        private System.Windows.Forms.Label lblFechaIni;
        private System.Windows.Forms.Button btnBuscar;
        public System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox gbxConsultasAvanzadas;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.ToolTip ttMensajeAyuda;
        private System.Windows.Forms.Panel panelHorizontal;
        private System.Windows.Forms.Panel pnlSeparacion;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.Label lblSistemaVenta;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.GroupBox gbxVisualizar;
        private System.Windows.Forms.Button btnVisualizarGrafico;
        private System.Windows.Forms.Button btnVisualizarLista;
        private System.Windows.Forms.GroupBox gbxHerramientas;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdBVenta;
        private System.Windows.Forms.RadioButton rdBPresupuesto;
        private System.Windows.Forms.DataGridView DTDetalleventa;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource REPORTE_VENTAPRODUCTOBindingSource;
        private DVentaproducto DVentaproducto;
        private DVentaproductoTableAdapters.REPORTE_VENTAPRODUCTOTableAdapter REPORTE_VENTAPRODUCTOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn razon_social;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_comprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn caja;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuit;

    }
}