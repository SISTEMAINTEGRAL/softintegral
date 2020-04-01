namespace Capa_Presentacion
{
    partial class FrmOrdenPedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHorizontal = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lblSistemaVenta = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CbTipopedido = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblNomProducto = new System.Windows.Forms.Label();
            this.DGProductos = new System.Windows.Forms.DataGridView();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.DGDetalleitems = new Guna.UI.WinForms.GunaDataGridView();
            this.CCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.TxtCuit = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtRazonsocial = new System.Windows.Forms.TextBox();
            this.BtnBuscarcliente = new XanderUI.XUISuperButton();
            this.BtnBuscarProducto = new XanderUI.XUISuperButton();
            this.BtnGuardar = new XanderUI.XUISuperButton();
            this.DGCliente = new System.Windows.Forms.DataGridView();
            this.panelHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGDetalleitems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGCliente)).BeginInit();
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
            this.panelHorizontal.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panelHorizontal.Name = "panelHorizontal";
            this.panelHorizontal.Size = new System.Drawing.Size(1678, 37);
            this.panelHorizontal.TabIndex = 69;
            this.panelHorizontal.TabStop = true;
            this.panelHorizontal.DoubleClick += new System.EventHandler(this.panelHorizontal_DoubleClick);
            this.panelHorizontal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHorizontal_MouseMove);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(22, 9);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(222, 28);
            this.label16.TabIndex = 7;
            this.label16.Text = "ORDEN DE PEDIDO";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackgroundImage = global::Capa_Presentacion.Properties.Resources.maximize_Checkbox_16px;
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMaximizar.Location = new System.Drawing.Point(1618, 5);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.btnRestaurar.Location = new System.Drawing.Point(1618, 5);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(22, 25);
            this.btnRestaurar.TabIndex = 2;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            this.btnRestaurar.MouseLeave += new System.EventHandler(this.btnRestaurar_MouseLeave);
            this.btnRestaurar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnRestaurar_MouseMove);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackgroundImage = global::Capa_Presentacion.Properties.Resources.Minus_20px;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimizar.Location = new System.Drawing.Point(1585, 5);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.btnCerrar.Location = new System.Drawing.Point(1651, 5);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
            this.lblSistemaVenta.Size = new System.Drawing.Size(200, 44);
            this.lblSistemaVenta.TabIndex = 6;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdCliente.Location = new System.Drawing.Point(148, 117);
            this.txtIdCliente.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(224, 30);
            this.txtIdCliente.TabIndex = 70;
            this.txtIdCliente.TextChanged += new System.EventHandler(this.txtIdCliente_TextChanged);
            this.txtIdCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIdCliente_KeyDown);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(18, 120);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(84, 25);
            this.bunifuCustomLabel2.TabIndex = 95;
            this.bunifuCustomLabel2.Text = "Cliente :";
            // 
            // CbTipopedido
            // 
            this.CbTipopedido.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.CbTipopedido.FormattingEnabled = true;
            this.CbTipopedido.Items.AddRange(new object[] {
            "Licitacion",
            "Licitacion publica",
            "Concurso de precio"});
            this.CbTipopedido.Location = new System.Drawing.Point(1329, 120);
            this.CbTipopedido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbTipopedido.Name = "CbTipopedido";
            this.CbTipopedido.Size = new System.Drawing.Size(332, 33);
            this.CbTipopedido.TabIndex = 96;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(1130, 128);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(153, 25);
            this.bunifuCustomLabel1.TabIndex = 97;
            this.bunifuCustomLabel1.Text = "Tipo de pedido :";
            // 
            // lblNomProducto
            // 
            this.lblNomProducto.AutoSize = true;
            this.lblNomProducto.Location = new System.Drawing.Point(8, 186);
            this.lblNomProducto.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNomProducto.Name = "lblNomProducto";
            this.lblNomProducto.Size = new System.Drawing.Size(90, 25);
            this.lblNomProducto.TabIndex = 101;
            this.lblNomProducto.Text = "Producto";
            // 
            // DGProductos
            // 
            this.DGProductos.AllowUserToAddRows = false;
            this.DGProductos.AllowUserToDeleteRows = false;
            this.DGProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGProductos.Location = new System.Drawing.Point(613, 152);
            this.DGProductos.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.DGProductos.MultiSelect = false;
            this.DGProductos.Name = "DGProductos";
            this.DGProductos.ReadOnly = true;
            this.DGProductos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGProductos.Size = new System.Drawing.Size(609, 141);
            this.DGProductos.TabIndex = 100;
            this.DGProductos.Visible = false;
            this.DGProductos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DGProductos_KeyDown);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreProducto.Location = new System.Drawing.Point(148, 181);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(408, 30);
            this.txtNombreProducto.TabIndex = 98;
            this.txtNombreProducto.TextChanged += new System.EventHandler(this.txtNombreProducto_TextChanged);
            this.txtNombreProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombreProducto_KeyDown);
            // 
            // DGDetalleitems
            // 
            this.DGDetalleitems.AllowUserToAddRows = false;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.White;
            this.DGDetalleitems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            this.DGDetalleitems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGDetalleitems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGDetalleitems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGDetalleitems.BackgroundColor = System.Drawing.Color.White;
            this.DGDetalleitems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGDetalleitems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGDetalleitems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGDetalleitems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.DGDetalleitems.ColumnHeadersHeight = 38;
            this.DGDetalleitems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CCodigo,
            this.CDetalle,
            this.CPrecio,
            this.CCantidad,
            this.CImporte});
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGDetalleitems.DefaultCellStyle = dataGridViewCellStyle33;
            this.DGDetalleitems.EnableHeadersVisualStyles = false;
            this.DGDetalleitems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGDetalleitems.Location = new System.Drawing.Point(6, 286);
            this.DGDetalleitems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGDetalleitems.Name = "DGDetalleitems";
            this.DGDetalleitems.RowHeadersVisible = false;
            this.DGDetalleitems.RowTemplate.Height = 24;
            this.DGDetalleitems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGDetalleitems.Size = new System.Drawing.Size(1660, 368);
            this.DGDetalleitems.TabIndex = 105;
            this.DGDetalleitems.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DGDetalleitems.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGDetalleitems.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGDetalleitems.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGDetalleitems.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGDetalleitems.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGDetalleitems.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGDetalleitems.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGDetalleitems.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGDetalleitems.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DGDetalleitems.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGDetalleitems.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGDetalleitems.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGDetalleitems.ThemeStyle.HeaderStyle.Height = 38;
            this.DGDetalleitems.ThemeStyle.ReadOnly = false;
            this.DGDetalleitems.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGDetalleitems.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGDetalleitems.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGDetalleitems.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGDetalleitems.ThemeStyle.RowsStyle.Height = 24;
            this.DGDetalleitems.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGDetalleitems.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // CCodigo
            // 
            this.CCodigo.FillWeight = 61.54822F;
            this.CCodigo.HeaderText = "Codigo";
            this.CCodigo.Name = "CCodigo";
            // 
            // CDetalle
            // 
            this.CDetalle.FillWeight = 253.8071F;
            this.CDetalle.HeaderText = "Detalle";
            this.CDetalle.Name = "CDetalle";
            // 
            // CPrecio
            // 
            this.CPrecio.FillWeight = 61.54822F;
            this.CPrecio.HeaderText = "Precio";
            this.CPrecio.Name = "CPrecio";
            // 
            // CCantidad
            // 
            this.CCantidad.FillWeight = 61.54822F;
            this.CCantidad.HeaderText = "Cantidad";
            this.CCantidad.Name = "CCantidad";
            // 
            // CImporte
            // 
            this.CImporte.FillWeight = 61.54822F;
            this.CImporte.HeaderText = "Importe";
            this.CImporte.Name = "CImporte";
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(247)))));
            this.txtTotalPagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalPagar.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.txtTotalPagar.Location = new System.Drawing.Point(1402, 723);
            this.txtTotalPagar.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.ReadOnly = true;
            this.txtTotalPagar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotalPagar.Size = new System.Drawing.Size(221, 48);
            this.txtTotalPagar.TabIndex = 103;
            this.txtTotalPagar.Text = "0,00";
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagar.Location = new System.Drawing.Point(1235, 739);
            this.lblTotalPagar.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(96, 23);
            this.lblTotalPagar.TabIndex = 102;
            this.lblTotalPagar.Text = "TOTAL $ :";
            // 
            // TxtCuit
            // 
            this.TxtCuit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCuit.Location = new System.Drawing.Point(540, 122);
            this.TxtCuit.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.TxtCuit.Name = "TxtCuit";
            this.TxtCuit.Size = new System.Drawing.Size(209, 30);
            this.TxtCuit.TabIndex = 106;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(470, 125);
            this.bunifuCustomLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(58, 25);
            this.bunifuCustomLabel3.TabIndex = 107;
            this.bunifuCustomLabel3.Text = "Cuit :";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(760, 128);
            this.bunifuCustomLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(134, 25);
            this.bunifuCustomLabel4.TabIndex = 109;
            this.bunifuCustomLabel4.Text = "Razon social :";
            // 
            // TxtRazonsocial
            // 
            this.TxtRazonsocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtRazonsocial.Location = new System.Drawing.Point(897, 127);
            this.TxtRazonsocial.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.TxtRazonsocial.Name = "TxtRazonsocial";
            this.TxtRazonsocial.Size = new System.Drawing.Size(209, 30);
            this.TxtRazonsocial.TabIndex = 108;
            // 
            // BtnBuscarcliente
            // 
            this.BtnBuscarcliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(247)))));
            this.BtnBuscarcliente.ButtonImage = global::Capa_Presentacion.Properties.Resources.search_magnifier_interface_symbol;
            this.BtnBuscarcliente.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.BtnBuscarcliente.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.BtnBuscarcliente.ButtonText = "";
            this.BtnBuscarcliente.CornerRadius = 5;
            this.BtnBuscarcliente.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnBuscarcliente.HoverBackgroundColor = System.Drawing.Color.IndianRed;
            this.BtnBuscarcliente.HoverTextColor = System.Drawing.Color.Yellow;
            this.BtnBuscarcliente.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.BtnBuscarcliente.Location = new System.Drawing.Point(385, 113);
            this.BtnBuscarcliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnBuscarcliente.Name = "BtnBuscarcliente";
            this.BtnBuscarcliente.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.BtnBuscarcliente.SelectedTextColor = System.Drawing.Color.White;
            this.BtnBuscarcliente.Size = new System.Drawing.Size(45, 34);
            this.BtnBuscarcliente.SuperSelected = false;
            this.BtnBuscarcliente.TabIndex = 111;
            this.BtnBuscarcliente.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.BtnBuscarcliente.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnBuscarcliente.Click += new System.EventHandler(this.BtnBuscarcliente_Click);
            // 
            // BtnBuscarProducto
            // 
            this.BtnBuscarProducto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(247)))));
            this.BtnBuscarProducto.ButtonImage = global::Capa_Presentacion.Properties.Resources.search_magnifier_interface_symbol;
            this.BtnBuscarProducto.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.BtnBuscarProducto.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.BtnBuscarProducto.ButtonText = "Buscar";
            this.BtnBuscarProducto.CornerRadius = 5;
            this.BtnBuscarProducto.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnBuscarProducto.HoverBackgroundColor = System.Drawing.Color.IndianRed;
            this.BtnBuscarProducto.HoverTextColor = System.Drawing.Color.Yellow;
            this.BtnBuscarProducto.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.BtnBuscarProducto.Location = new System.Drawing.Point(579, 176);
            this.BtnBuscarProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnBuscarProducto.Name = "BtnBuscarProducto";
            this.BtnBuscarProducto.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.BtnBuscarProducto.SelectedTextColor = System.Drawing.Color.White;
            this.BtnBuscarProducto.Size = new System.Drawing.Size(121, 37);
            this.BtnBuscarProducto.SuperSelected = false;
            this.BtnBuscarProducto.TabIndex = 110;
            this.BtnBuscarProducto.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.BtnBuscarProducto.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnBuscarProducto.Click += new System.EventHandler(this.BtnBuscarProducto_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnGuardar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(247)))));
            this.BtnGuardar.ButtonImage = global::Capa_Presentacion.Properties.Resources.Save_20px;
            this.BtnGuardar.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.BtnGuardar.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.BtnGuardar.ButtonText = "Guardar";
            this.BtnGuardar.CornerRadius = 5;
            this.BtnGuardar.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnGuardar.HoverBackgroundColor = System.Drawing.Color.IndianRed;
            this.BtnGuardar.HoverTextColor = System.Drawing.Color.Yellow;
            this.BtnGuardar.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.BtnGuardar.Location = new System.Drawing.Point(38, 686);
            this.BtnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.BtnGuardar.SelectedTextColor = System.Drawing.Color.White;
            this.BtnGuardar.Size = new System.Drawing.Size(224, 63);
            this.BtnGuardar.SuperSelected = false;
            this.BtnGuardar.TabIndex = 104;
            this.BtnGuardar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.BtnGuardar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // DGCliente
            // 
            this.DGCliente.AllowUserToAddRows = false;
            this.DGCliente.AllowUserToDeleteRows = false;
            this.DGCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGCliente.Location = new System.Drawing.Point(148, 142);
            this.DGCliente.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.DGCliente.MultiSelect = false;
            this.DGCliente.Name = "DGCliente";
            this.DGCliente.ReadOnly = true;
            this.DGCliente.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGCliente.Size = new System.Drawing.Size(609, 141);
            this.DGCliente.TabIndex = 112;
            this.DGCliente.Visible = false;
            this.DGCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DGCliente_KeyDown);
            // 
            // FrmOrdenPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1678, 790);
            this.ControlBox = false;
            this.Controls.Add(this.DGCliente);
            this.Controls.Add(this.DGProductos);
            this.Controls.Add(this.BtnBuscarcliente);
            this.Controls.Add(this.BtnBuscarProducto);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.TxtRazonsocial);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.TxtCuit);
            this.Controls.Add(this.DGDetalleitems);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.lblTotalPagar);
            this.Controls.Add(this.lblNomProducto);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.CbTipopedido);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.panelHorizontal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmOrdenPedido";
            this.Text = "FrmOrdenPedido";
            this.panelHorizontal.ResumeLayout(false);
            this.panelHorizontal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGDetalleitems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHorizontal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label lblSistemaVenta;
        private System.Windows.Forms.TextBox txtIdCliente;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.ComboBox CbTipopedido;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Label lblNomProducto;
        private System.Windows.Forms.DataGridView DGProductos;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private Guna.UI.WinForms.GunaDataGridView DGDetalleitems;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CImporte;
        private XanderUI.XUISuperButton BtnGuardar;
        public System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.TextBox TxtCuit;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.TextBox TxtRazonsocial;
        private XanderUI.XUISuperButton BtnBuscarProducto;
        private XanderUI.XUISuperButton BtnBuscarcliente;
        private System.Windows.Forms.DataGridView DGCliente;
    }
}