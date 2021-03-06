﻿namespace Capa_Presentacion
{
    partial class FrmDetalleVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblFechaVenta = new System.Windows.Forms.Label();
            this.txtFechaVenta = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.gbDetalleMovimento = new System.Windows.Forms.GroupBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcuit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxHerramientas = new System.Windows.Forms.GroupBox();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.btnCalculadora = new System.Windows.Forms.Button();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.lblTipo_comprobante = new System.Windows.Forms.Label();
            this.txtTipoComprobante = new System.Windows.Forms.TextBox();
            this.panelHorizontal = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lblSistemaVenta = new System.Windows.Forms.Label();
            this.btnPagarMovimiento = new XanderUI.XUISuperButton();
            this.btncredito = new XanderUI.XUISuperButton();
            this.dataLista = new Guna.UI.WinForms.GunaDataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDetalleMovimento.SuspendLayout();
            this.gbxHerramientas.SuspendLayout();
            this.panelHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtTotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtTotal.Location = new System.Drawing.Point(765, 597);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(229, 52);
            this.txtTotal.TabIndex = 43;
            this.txtTotal.Text = "0,00";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(653, 605);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(92, 32);
            this.lblTotal.TabIndex = 42;
            this.lblTotal.Text = "TOTAL";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(12, 39);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(75, 25);
            this.lblCodigo.TabIndex = 34;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblFechaVenta
            // 
            this.lblFechaVenta.AutoSize = true;
            this.lblFechaVenta.Location = new System.Drawing.Point(12, 78);
            this.lblFechaVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaVenta.Name = "lblFechaVenta";
            this.lblFechaVenta.Size = new System.Drawing.Size(151, 25);
            this.lblFechaVenta.TabIndex = 28;
            this.lblFechaVenta.Text = "Fecha de Venta";
            // 
            // txtFechaVenta
            // 
            this.txtFechaVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFechaVenta.Enabled = false;
            this.txtFechaVenta.Location = new System.Drawing.Point(177, 78);
            this.txtFechaVenta.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtFechaVenta.Name = "txtFechaVenta";
            this.txtFechaVenta.Size = new System.Drawing.Size(209, 30);
            this.txtFechaVenta.TabIndex = 27;
            // 
            // txtEstado
            // 
            this.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(177, 120);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(209, 30);
            this.txtEstado.TabIndex = 32;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(8, 125);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(73, 25);
            this.lblEstado.TabIndex = 31;
            this.lblEstado.Text = "Estado";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(177, 36);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(126, 30);
            this.txtCodigo.TabIndex = 33;
            // 
            // gbDetalleMovimento
            // 
            this.gbDetalleMovimento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDetalleMovimento.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbDetalleMovimento.Controls.Add(this.dataLista);
            this.gbDetalleMovimento.Controls.Add(this.btncredito);
            this.gbDetalleMovimento.Controls.Add(this.btnPagarMovimiento);
            this.gbDetalleMovimento.Controls.Add(this.cbxCategoria);
            this.gbDetalleMovimento.Controls.Add(this.label3);
            this.gbDetalleMovimento.Controls.Add(this.txtcuit);
            this.gbDetalleMovimento.Controls.Add(this.label2);
            this.gbDetalleMovimento.Controls.Add(this.gbxHerramientas);
            this.gbDetalleMovimento.Controls.Add(this.lblRazonSocial);
            this.gbDetalleMovimento.Controls.Add(this.txtRazonSocial);
            this.gbDetalleMovimento.Controls.Add(this.lblTipo_comprobante);
            this.gbDetalleMovimento.Controls.Add(this.txtTipoComprobante);
            this.gbDetalleMovimento.Controls.Add(this.txtTotal);
            this.gbDetalleMovimento.Controls.Add(this.lblTotal);
            this.gbDetalleMovimento.Controls.Add(this.lblCodigo);
            this.gbDetalleMovimento.Controls.Add(this.lblFechaVenta);
            this.gbDetalleMovimento.Controls.Add(this.txtCodigo);
            this.gbDetalleMovimento.Controls.Add(this.txtFechaVenta);
            this.gbDetalleMovimento.Controls.Add(this.txtEstado);
            this.gbDetalleMovimento.Controls.Add(this.lblEstado);
            this.gbDetalleMovimento.Location = new System.Drawing.Point(5, 40);
            this.gbDetalleMovimento.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gbDetalleMovimento.Name = "gbDetalleMovimento";
            this.gbDetalleMovimento.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gbDetalleMovimento.Size = new System.Drawing.Size(1003, 661);
            this.gbDetalleMovimento.TabIndex = 42;
            this.gbDetalleMovimento.TabStop = false;
            this.gbDetalleMovimento.Text = "Detalles ";
            this.gbDetalleMovimento.Enter += new System.EventHandler(this.gbDetalleMovimento_Enter);
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.Enabled = false;
            this.cbxCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(775, 35);
            this.cbxCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(60, 33);
            this.cbxCategoria.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(716, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 63;
            this.label3.Text = "Letra";
            // 
            // txtcuit
            // 
            this.txtcuit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcuit.Enabled = false;
            this.txtcuit.Location = new System.Drawing.Point(544, 76);
            this.txtcuit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtcuit.Name = "txtcuit";
            this.txtcuit.Size = new System.Drawing.Size(156, 30);
            this.txtcuit.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 50;
            this.label2.Text = "Cuit :";
            // 
            // gbxHerramientas
            // 
            this.gbxHerramientas.Controls.Add(this.btnExportarExcel);
            this.gbxHerramientas.Controls.Add(this.btnCalculadora);
            this.gbxHerramientas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxHerramientas.Location = new System.Drawing.Point(866, 17);
            this.gbxHerramientas.Name = "gbxHerramientas";
            this.gbxHerramientas.Size = new System.Drawing.Size(127, 64);
            this.gbxHerramientas.TabIndex = 48;
            this.gbxHerramientas.TabStop = false;
            this.gbxHerramientas.Text = "herramientas";
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarExcel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarExcel.Image = global::Capa_Presentacion.Properties.Resources.Microsoft_Excel_20px;
            this.btnExportarExcel.Location = new System.Drawing.Point(49, 28);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(26, 28);
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
            this.btnCalculadora.Location = new System.Drawing.Point(17, 28);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(26, 28);
            this.btnCalculadora.TabIndex = 28;
            this.btnCalculadora.UseVisualStyleBackColor = true;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(394, 118);
            this.lblRazonSocial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(138, 25);
            this.lblRazonSocial.TabIndex = 47;
            this.lblRazonSocial.Text = "Razon Social :";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRazonSocial.Enabled = false;
            this.txtRazonSocial.Location = new System.Drawing.Point(544, 118);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(325, 30);
            this.txtRazonSocial.TabIndex = 46;
            // 
            // lblTipo_comprobante
            // 
            this.lblTipo_comprobante.AutoSize = true;
            this.lblTipo_comprobante.Location = new System.Drawing.Point(337, 38);
            this.lblTipo_comprobante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo_comprobante.Name = "lblTipo_comprobante";
            this.lblTipo_comprobante.Size = new System.Drawing.Size(186, 25);
            this.lblTipo_comprobante.TabIndex = 45;
            this.lblTipo_comprobante.Text = "Tipo Comprobante :";
            // 
            // txtTipoComprobante
            // 
            this.txtTipoComprobante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTipoComprobante.Enabled = false;
            this.txtTipoComprobante.Location = new System.Drawing.Point(544, 38);
            this.txtTipoComprobante.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTipoComprobante.Name = "txtTipoComprobante";
            this.txtTipoComprobante.Size = new System.Drawing.Size(156, 30);
            this.txtTipoComprobante.TabIndex = 44;
            // 
            // panelHorizontal
            // 
            this.panelHorizontal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.panelHorizontal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHorizontal.Controls.Add(this.label1);
            this.panelHorizontal.Controls.Add(this.btnMaximizar);
            this.panelHorizontal.Controls.Add(this.btnRestaurar);
            this.panelHorizontal.Controls.Add(this.btnMinimizar);
            this.panelHorizontal.Controls.Add(this.btnCerrar);
            this.panelHorizontal.Controls.Add(this.lblSistemaVenta);
            this.panelHorizontal.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHorizontal.Location = new System.Drawing.Point(0, 0);
            this.panelHorizontal.Name = "panelHorizontal";
            this.panelHorizontal.Size = new System.Drawing.Size(1012, 37);
            this.panelHorizontal.TabIndex = 65;
            this.panelHorizontal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHorizontal_MouseMove);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(11, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "DETALLE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackgroundImage = global::Capa_Presentacion.Properties.Resources.maximize_Checkbox_16px;
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMaximizar.Location = new System.Drawing.Point(952, 5);
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
            this.btnRestaurar.Location = new System.Drawing.Point(952, 5);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(22, 25);
            this.btnRestaurar.TabIndex = 2;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackgroundImage = global::Capa_Presentacion.Properties.Resources.Minus_20px;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimizar.Location = new System.Drawing.Point(919, 5);
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
            this.btnCerrar.ErrorImage = null;
            this.btnCerrar.Location = new System.Drawing.Point(985, 5);
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
            this.lblSistemaVenta.Name = "lblSistemaVenta";
            this.lblSistemaVenta.Size = new System.Drawing.Size(100, 23);
            this.lblSistemaVenta.TabIndex = 6;
            // 
            // btnPagarMovimiento
            // 
            this.btnPagarMovimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPagarMovimiento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(247)))));
            this.btnPagarMovimiento.ButtonImage = null;
            this.btnPagarMovimiento.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnPagarMovimiento.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnPagarMovimiento.ButtonText = "Facturar";
            this.btnPagarMovimiento.CornerRadius = 5;
            this.btnPagarMovimiento.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPagarMovimiento.HoverBackgroundColor = System.Drawing.Color.IndianRed;
            this.btnPagarMovimiento.HoverTextColor = System.Drawing.Color.Yellow;
            this.btnPagarMovimiento.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnPagarMovimiento.Location = new System.Drawing.Point(7, 588);
            this.btnPagarMovimiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPagarMovimiento.Name = "btnPagarMovimiento";
            this.btnPagarMovimiento.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnPagarMovimiento.SelectedTextColor = System.Drawing.Color.White;
            this.btnPagarMovimiento.Size = new System.Drawing.Size(255, 61);
            this.btnPagarMovimiento.SuperSelected = false;
            this.btnPagarMovimiento.TabIndex = 135;
            this.btnPagarMovimiento.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btnPagarMovimiento.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPagarMovimiento.Click += new System.EventHandler(this.btnPagarMovimiento_Click);
            // 
            // btncredito
            // 
            this.btncredito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncredito.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(247)))));
            this.btncredito.ButtonImage = null;
            this.btncredito.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btncredito.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btncredito.ButtonText = "Nota de venta";
            this.btncredito.CornerRadius = 5;
            this.btncredito.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btncredito.HoverBackgroundColor = System.Drawing.Color.IndianRed;
            this.btncredito.HoverTextColor = System.Drawing.Color.Yellow;
            this.btncredito.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btncredito.Location = new System.Drawing.Point(274, 588);
            this.btncredito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncredito.Name = "btncredito";
            this.btncredito.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btncredito.SelectedTextColor = System.Drawing.Color.White;
            this.btncredito.Size = new System.Drawing.Size(255, 61);
            this.btncredito.SuperSelected = false;
            this.btncredito.TabIndex = 136;
            this.btncredito.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.btncredito.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btncredito.Click += new System.EventHandler(this.btncredito_Click);
            // 
            // dataLista
            // 
            this.dataLista.AllowUserToAddRows = false;
            this.dataLista.AllowUserToDeleteRows = false;
            this.dataLista.AllowUserToOrderColumns = true;
            this.dataLista.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataLista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataLista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataLista.BackgroundColor = System.Drawing.Color.White;
            this.dataLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataLista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataLista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataLista.ColumnHeadersHeight = 38;
            this.dataLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Producto,
            this.Precio,
            this.Descuento,
            this.Cantidad,
            this.Importe});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataLista.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataLista.EnableHeadersVisualStyles = false;
            this.dataLista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataLista.Location = new System.Drawing.Point(12, 159);
            this.dataLista.MultiSelect = false;
            this.dataLista.Name = "dataLista";
            this.dataLista.RowHeadersVisible = false;
            this.dataLista.RowTemplate.Height = 24;
            this.dataLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataLista.Size = new System.Drawing.Size(981, 414);
            this.dataLista.StandardTab = true;
            this.dataLista.TabIndex = 137;
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
            // 
            // Codigo
            // 
            this.Codigo.FillWeight = 61.54822F;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Producto
            // 
            this.Producto.FillWeight = 253.8071F;
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            // 
            // FrmDetalleVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 733);
            this.ControlBox = false;
            this.Controls.Add(this.panelHorizontal);
            this.Controls.Add(this.gbDetalleMovimento);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmDetalleVentas";
            this.Text = "Detalle de Ventas";
            this.Load += new System.EventHandler(this.FrmDetalleVentas_Load);
            this.gbDetalleMovimento.ResumeLayout(false);
            this.gbDetalleMovimento.PerformLayout();
            this.gbxHerramientas.ResumeLayout(false);
            this.panelHorizontal.ResumeLayout(false);
            this.panelHorizontal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblFechaVenta;
        private System.Windows.Forms.TextBox txtFechaVenta;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.GroupBox gbDetalleMovimento;
        private System.Windows.Forms.Label lblTipo_comprobante;
        private System.Windows.Forms.TextBox txtTipoComprobante;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.GroupBox gbxHerramientas;
        private System.Windows.Forms.Button btnExportarExcel;
        private System.Windows.Forms.Button btnCalculadora;
        private System.Windows.Forms.Panel panelHorizontal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label lblSistemaVenta;
        private System.Windows.Forms.TextBox txtcuit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Label label3;
        private XanderUI.XUISuperButton btncredito;
        private XanderUI.XUISuperButton btnPagarMovimiento;
        private Guna.UI.WinForms.GunaDataGridView dataLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
    }
}