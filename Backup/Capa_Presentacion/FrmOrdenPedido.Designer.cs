namespace Capa_Presentacion
{
    partial class FrmOrdenAdjudicacion
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
            this.DGCliente = new System.Windows.Forms.DataGridView();
            this.BtnBuscarcliente = new XanderUI.XUISuperButton();
            this.BtnBuscarProducto = new XanderUI.XUISuperButton();
            this.BtnGuardar = new XanderUI.XUISuperButton();
            this.xuiCustomGroupbox1 = new XanderUI.XUICustomGroupbox();
            this.DGBeneficiaria = new System.Windows.Forms.DataGridView();
            this.TxtRazonsocialBen = new System.Windows.Forms.TextBox();
            this.xuiSuperButton1 = new XanderUI.XUISuperButton();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.TxtCuitBeneficio = new System.Windows.Forms.TextBox();
            this.TxtEmpresabeneficiaria = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chkporcantidad = new System.Windows.Forms.CheckBox();
            this.TxtcambioDv = new System.Windows.Forms.TextBox();
            this.panelHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGDetalleitems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGCliente)).BeginInit();
            this.xuiCustomGroupbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGBeneficiaria)).BeginInit();
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
            this.panelHorizontal.Margin = new System.Windows.Forms.Padding(6);
            this.panelHorizontal.Name = "panelHorizontal";
            this.panelHorizontal.Size = new System.Drawing.Size(1248, 37);
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
            this.label16.Location = new System.Drawing.Point(6, 4);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(308, 28);
            this.label16.TabIndex = 7;
            this.label16.Text = "ORDEN DE ADJUDICADOS";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackgroundImage = global::Capa_Presentacion.Properties.Resources.maximize_Checkbox_16px;
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMaximizar.Location = new System.Drawing.Point(1184, 4);
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
            this.btnRestaurar.BackgroundImage = global::Capa_Presentacion.Properties.Resources.Restore_Window_20px;
            this.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRestaurar.Location = new System.Drawing.Point(1184, 2);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(6);
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
            this.btnMinimizar.Location = new System.Drawing.Point(1157, 4);
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
            this.btnCerrar.BackgroundImage = global::Capa_Presentacion.Properties.Resources.Delete_20px;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCerrar.ErrorImage = null;
            this.btnCerrar.Location = new System.Drawing.Point(1213, 4);
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
            this.lblSistemaVenta.Location = new System.Drawing.Point(0, 0);
            this.lblSistemaVenta.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSistemaVenta.Name = "lblSistemaVenta";
            this.lblSistemaVenta.Size = new System.Drawing.Size(200, 44);
            this.lblSistemaVenta.TabIndex = 6;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdCliente.Location = new System.Drawing.Point(215, 17);
            this.txtIdCliente.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(155, 30);
            this.txtIdCliente.TabIndex = 70;
            this.txtIdCliente.TextChanged += new System.EventHandler(this.txtIdCliente_TextChanged);
            this.txtIdCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIdCliente_KeyDown);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(6, 18);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(199, 25);
            this.bunifuCustomLabel2.TabIndex = 95;
            this.bunifuCustomLabel2.Text = "Empresa de entrega :";
            // 
            // CbTipopedido
            // 
            this.CbTipopedido.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.CbTipopedido.FormattingEnabled = true;
            this.CbTipopedido.Items.AddRange(new object[] {
            "LICITACION",
            "LICITACION PUBLICA",
            "CONCURSO DE PRECIO"});
            this.CbTipopedido.Location = new System.Drawing.Point(773, 105);
            this.CbTipopedido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbTipopedido.Name = "CbTipopedido";
            this.CbTipopedido.Size = new System.Drawing.Size(212, 33);
            this.CbTipopedido.TabIndex = 96;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(621, 110);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(132, 25);
            this.bunifuCustomLabel1.TabIndex = 97;
            this.bunifuCustomLabel1.Text = "T. de pedido :";
            // 
            // lblNomProducto
            // 
            this.lblNomProducto.AutoSize = true;
            this.lblNomProducto.Location = new System.Drawing.Point(14, 111);
            this.lblNomProducto.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNomProducto.Name = "lblNomProducto";
            this.lblNomProducto.Size = new System.Drawing.Size(101, 25);
            this.lblNomProducto.TabIndex = 101;
            this.lblNomProducto.Text = "Producto :";
            // 
            // DGProductos
            // 
            this.DGProductos.AllowUserToAddRows = false;
            this.DGProductos.AllowUserToDeleteRows = false;
            this.DGProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGProductos.Location = new System.Drawing.Point(139, 178);
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
            this.txtNombreProducto.Location = new System.Drawing.Point(133, 110);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(253, 30);
            this.txtNombreProducto.TabIndex = 98;
            this.txtNombreProducto.TextChanged += new System.EventHandler(this.txtNombreProducto_TextChanged);
            this.txtNombreProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombreProducto_KeyDown);
            // 
            // DGDetalleitems
            // 
            this.DGDetalleitems.AllowUserToAddRows = false;
            this.DGDetalleitems.AllowUserToDeleteRows = false;
            this.DGDetalleitems.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGDetalleitems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGDetalleitems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGDetalleitems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGDetalleitems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGDetalleitems.BackgroundColor = System.Drawing.Color.White;
            this.DGDetalleitems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGDetalleitems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGDetalleitems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGDetalleitems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGDetalleitems.ColumnHeadersHeight = 38;
            this.DGDetalleitems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CCodigo,
            this.CDetalle,
            this.CPrecio,
            this.CCantidad,
            this.CImporte});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGDetalleitems.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGDetalleitems.EnableHeadersVisualStyles = false;
            this.DGDetalleitems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGDetalleitems.Location = new System.Drawing.Point(6, 214);
            this.DGDetalleitems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGDetalleitems.MultiSelect = false;
            this.DGDetalleitems.Name = "DGDetalleitems";
            this.DGDetalleitems.RowHeadersVisible = false;
            this.DGDetalleitems.RowTemplate.Height = 24;
            this.DGDetalleitems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGDetalleitems.Size = new System.Drawing.Size(1222, 445);
            this.DGDetalleitems.StandardTab = true;
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
            this.DGDetalleitems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGDetalleitems_CellDoubleClick);
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
            this.txtTotalPagar.Location = new System.Drawing.Point(972, 723);
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
            this.lblTotalPagar.Location = new System.Drawing.Point(805, 739);
            this.lblTotalPagar.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(96, 23);
            this.lblTotalPagar.TabIndex = 102;
            this.lblTotalPagar.Text = "TOTAL $ :";
            // 
            // TxtCuit
            // 
            this.TxtCuit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCuit.Location = new System.Drawing.Point(541, 20);
            this.TxtCuit.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.TxtCuit.Name = "TxtCuit";
            this.TxtCuit.Size = new System.Drawing.Size(168, 30);
            this.TxtCuit.TabIndex = 106;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(455, 20);
            this.bunifuCustomLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(58, 25);
            this.bunifuCustomLabel3.TabIndex = 107;
            this.bunifuCustomLabel3.Text = "Cuit :";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(736, 22);
            this.bunifuCustomLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(134, 25);
            this.bunifuCustomLabel4.TabIndex = 109;
            this.bunifuCustomLabel4.Text = "Razon social :";
            // 
            // TxtRazonsocial
            // 
            this.TxtRazonsocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtRazonsocial.Location = new System.Drawing.Point(906, 20);
            this.TxtRazonsocial.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.TxtRazonsocial.Name = "TxtRazonsocial";
            this.TxtRazonsocial.Size = new System.Drawing.Size(173, 30);
            this.TxtRazonsocial.TabIndex = 108;
            // 
            // DGCliente
            // 
            this.DGCliente.AllowUserToAddRows = false;
            this.DGCliente.AllowUserToDeleteRows = false;
            this.DGCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGCliente.Location = new System.Drawing.Point(245, 49);
            this.DGCliente.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.DGCliente.MultiSelect = false;
            this.DGCliente.Name = "DGCliente";
            this.DGCliente.ReadOnly = true;
            this.DGCliente.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGCliente.Size = new System.Drawing.Size(609, 108);
            this.DGCliente.TabIndex = 112;
            this.DGCliente.Visible = false;
            this.DGCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGCliente_CellContentClick);
            this.DGCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DGCliente_KeyDown);
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
            this.BtnBuscarcliente.Location = new System.Drawing.Point(390, 18);
            this.BtnBuscarcliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnBuscarcliente.Name = "BtnBuscarcliente";
            this.BtnBuscarcliente.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.BtnBuscarcliente.SelectedTextColor = System.Drawing.Color.White;
            this.BtnBuscarcliente.Size = new System.Drawing.Size(42, 30);
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
            this.BtnBuscarProducto.Location = new System.Drawing.Point(409, 109);
            this.BtnBuscarProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnBuscarProducto.Name = "BtnBuscarProducto";
            this.BtnBuscarProducto.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.BtnBuscarProducto.SelectedTextColor = System.Drawing.Color.White;
            this.BtnBuscarProducto.Size = new System.Drawing.Size(109, 31);
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
            // xuiCustomGroupbox1
            // 
            this.xuiCustomGroupbox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xuiCustomGroupbox1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.xuiCustomGroupbox1.BorderWidth = 1;
            this.xuiCustomGroupbox1.Controls.Add(this.DGCliente);
            this.xuiCustomGroupbox1.Controls.Add(this.DGBeneficiaria);
            this.xuiCustomGroupbox1.Controls.Add(this.TxtRazonsocialBen);
            this.xuiCustomGroupbox1.Controls.Add(this.xuiSuperButton1);
            this.xuiCustomGroupbox1.Controls.Add(this.bunifuCustomLabel6);
            this.xuiCustomGroupbox1.Controls.Add(this.bunifuCustomLabel7);
            this.xuiCustomGroupbox1.Controls.Add(this.TxtCuitBeneficio);
            this.xuiCustomGroupbox1.Controls.Add(this.TxtEmpresabeneficiaria);
            this.xuiCustomGroupbox1.Controls.Add(this.bunifuCustomLabel5);
            this.xuiCustomGroupbox1.Controls.Add(this.CbTipopedido);
            this.xuiCustomGroupbox1.Controls.Add(this.bunifuCustomLabel1);
            this.xuiCustomGroupbox1.Controls.Add(this.TxtRazonsocial);
            this.xuiCustomGroupbox1.Controls.Add(this.BtnBuscarcliente);
            this.xuiCustomGroupbox1.Controls.Add(this.bunifuCustomLabel4);
            this.xuiCustomGroupbox1.Controls.Add(this.bunifuCustomLabel3);
            this.xuiCustomGroupbox1.Controls.Add(this.BtnBuscarProducto);
            this.xuiCustomGroupbox1.Controls.Add(this.lblNomProducto);
            this.xuiCustomGroupbox1.Controls.Add(this.TxtCuit);
            this.xuiCustomGroupbox1.Controls.Add(this.bunifuCustomLabel2);
            this.xuiCustomGroupbox1.Controls.Add(this.txtNombreProducto);
            this.xuiCustomGroupbox1.Controls.Add(this.txtIdCliente);
            this.xuiCustomGroupbox1.Controls.Add(this.chkporcantidad);
            this.xuiCustomGroupbox1.Location = new System.Drawing.Point(6, 41);
            this.xuiCustomGroupbox1.Name = "xuiCustomGroupbox1";
            this.xuiCustomGroupbox1.ShowText = true;
            this.xuiCustomGroupbox1.Size = new System.Drawing.Size(1230, 165);
            this.xuiCustomGroupbox1.TabIndex = 113;
            this.xuiCustomGroupbox1.TabStop = false;
            this.xuiCustomGroupbox1.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // DGBeneficiaria
            // 
            this.DGBeneficiaria.AllowUserToAddRows = false;
            this.DGBeneficiaria.AllowUserToDeleteRows = false;
            this.DGBeneficiaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGBeneficiaria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGBeneficiaria.Location = new System.Drawing.Point(222, 83);
            this.DGBeneficiaria.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.DGBeneficiaria.MultiSelect = false;
            this.DGBeneficiaria.Name = "DGBeneficiaria";
            this.DGBeneficiaria.ReadOnly = true;
            this.DGBeneficiaria.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGBeneficiaria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGBeneficiaria.Size = new System.Drawing.Size(609, 74);
            this.DGBeneficiaria.TabIndex = 115;
            this.DGBeneficiaria.Visible = false;
            this.DGBeneficiaria.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DGBeneficiaria_KeyDown);
            // 
            // TxtRazonsocialBen
            // 
            this.TxtRazonsocialBen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtRazonsocialBen.Location = new System.Drawing.Point(906, 65);
            this.TxtRazonsocialBen.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.TxtRazonsocialBen.Name = "TxtRazonsocialBen";
            this.TxtRazonsocialBen.Size = new System.Drawing.Size(173, 30);
            this.TxtRazonsocialBen.TabIndex = 120;
            // 
            // xuiSuperButton1
            // 
            this.xuiSuperButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(247)))));
            this.xuiSuperButton1.ButtonImage = global::Capa_Presentacion.Properties.Resources.search_magnifier_interface_symbol;
            this.xuiSuperButton1.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.xuiSuperButton1.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.xuiSuperButton1.ButtonText = "";
            this.xuiSuperButton1.CornerRadius = 5;
            this.xuiSuperButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiSuperButton1.HoverBackgroundColor = System.Drawing.Color.IndianRed;
            this.xuiSuperButton1.HoverTextColor = System.Drawing.Color.Yellow;
            this.xuiSuperButton1.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.xuiSuperButton1.Location = new System.Drawing.Point(390, 63);
            this.xuiSuperButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xuiSuperButton1.Name = "xuiSuperButton1";
            this.xuiSuperButton1.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.xuiSuperButton1.SelectedTextColor = System.Drawing.Color.White;
            this.xuiSuperButton1.Size = new System.Drawing.Size(42, 30);
            this.xuiSuperButton1.SuperSelected = false;
            this.xuiSuperButton1.TabIndex = 122;
            this.xuiSuperButton1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.xuiSuperButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiSuperButton1.Click += new System.EventHandler(this.xuiSuperButton1_Click);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(736, 67);
            this.bunifuCustomLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(134, 25);
            this.bunifuCustomLabel6.TabIndex = 121;
            this.bunifuCustomLabel6.Text = "Razon social :";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(455, 65);
            this.bunifuCustomLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(58, 25);
            this.bunifuCustomLabel7.TabIndex = 119;
            this.bunifuCustomLabel7.Text = "Cuit :";
            // 
            // TxtCuitBeneficio
            // 
            this.TxtCuitBeneficio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCuitBeneficio.Location = new System.Drawing.Point(541, 65);
            this.TxtCuitBeneficio.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.TxtCuitBeneficio.Name = "TxtCuitBeneficio";
            this.TxtCuitBeneficio.Size = new System.Drawing.Size(168, 30);
            this.TxtCuitBeneficio.TabIndex = 118;
            // 
            // TxtEmpresabeneficiaria
            // 
            this.TxtEmpresabeneficiaria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtEmpresabeneficiaria.Location = new System.Drawing.Point(215, 62);
            this.TxtEmpresabeneficiaria.Margin = new System.Windows.Forms.Padding(6, 11, 6, 11);
            this.TxtEmpresabeneficiaria.Name = "TxtEmpresabeneficiaria";
            this.TxtEmpresabeneficiaria.Size = new System.Drawing.Size(155, 30);
            this.TxtEmpresabeneficiaria.TabIndex = 117;
            this.TxtEmpresabeneficiaria.TextChanged += new System.EventHandler(this.TxtEmpresabeneficiaria_TextChanged);
            this.TxtEmpresabeneficiaria.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtEmpresabeneficiaria_KeyDown);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(7, 67);
            this.bunifuCustomLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(205, 25);
            this.bunifuCustomLabel5.TabIndex = 116;
            this.bunifuCustomLabel5.Text = "Empresa beneficiaria :";
            // 
            // chkporcantidad
            // 
            this.chkporcantidad.AutoSize = true;
            this.chkporcantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkporcantidad.Location = new System.Drawing.Point(546, 107);
            this.chkporcantidad.Margin = new System.Windows.Forms.Padding(2);
            this.chkporcantidad.Name = "chkporcantidad";
            this.chkporcantidad.Size = new System.Drawing.Size(64, 29);
            this.chkporcantidad.TabIndex = 114;
            this.chkporcantidad.Text = "F10";
            this.chkporcantidad.UseVisualStyleBackColor = true;
            // 
            // TxtcambioDv
            // 
            this.TxtcambioDv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtcambioDv.Location = new System.Drawing.Point(889, 261);
            this.TxtcambioDv.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.TxtcambioDv.MaxLength = 10;
            this.TxtcambioDv.Name = "TxtcambioDv";
            this.TxtcambioDv.Size = new System.Drawing.Size(135, 30);
            this.TxtcambioDv.TabIndex = 114;
            this.TxtcambioDv.Text = "0";
            this.TxtcambioDv.Visible = false;
            this.TxtcambioDv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtcambioDv_KeyDown);
            // 
            // FrmOrdenAdjudicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 790);
            this.ControlBox = false;
            this.Controls.Add(this.DGProductos);
            this.Controls.Add(this.TxtcambioDv);
            this.Controls.Add(this.xuiCustomGroupbox1);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.lblTotalPagar);
            this.Controls.Add(this.panelHorizontal);
            this.Controls.Add(this.DGDetalleitems);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmOrdenAdjudicacion";
            this.Text = "FrmOrdenPedido";
            this.Load += new System.EventHandler(this.FrmOrdenAdjudicacion_Load);
            this.panelHorizontal.ResumeLayout(false);
            this.panelHorizontal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGDetalleitems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGCliente)).EndInit();
            this.xuiCustomGroupbox1.ResumeLayout(false);
            this.xuiCustomGroupbox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGBeneficiaria)).EndInit();
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
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox1;
        private System.Windows.Forms.CheckBox chkporcantidad;
        public System.Windows.Forms.TextBox TxtcambioDv;
        private System.Windows.Forms.TextBox TxtRazonsocialBen;
        private XanderUI.XUISuperButton xuiSuperButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private System.Windows.Forms.TextBox TxtCuitBeneficio;
        private System.Windows.Forms.TextBox TxtEmpresabeneficiaria;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.DataGridView DGBeneficiaria;
    }
}