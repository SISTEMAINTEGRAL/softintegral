namespace Capa_Presentacion
{
    partial class frmPventa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPventa));
            this.grpboxProveedor = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.TxtcambioDv = new System.Windows.Forms.TextBox();
            this.Lblvendedor = new System.Windows.Forms.Label();
            this.DGVenta = new Guna.UI.WinForms.GunaDataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.P_Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cprecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dpesable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preciopormayor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidadpormayor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciounidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Civa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preciocantidad2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Oferta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock_Actual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock_Minimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PopupMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PopupCero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtItems = new System.Windows.Forms.TextBox();
            this.txtIva105 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNeto105 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNeto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTComprobante = new System.Windows.Forms.Label();
            this.cbTipoComprobante = new System.Windows.Forms.ComboBox();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.btnCliente = new System.Windows.Forms.Button();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblIdProveedor = new System.Windows.Forms.Label();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.gbDetalleMovimento = new System.Windows.Forms.GroupBox();
            this.DGCliente = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Txtcuota = new System.Windows.Forms.TextBox();
            this.rctacte = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMCuota = new ComboBoxMultiColumns.ComboBoxMultiColumns();
            this.cbTarjeta = new System.Windows.Forms.ComboBox();
            this.rTarjeta = new System.Windows.Forms.RadioButton();
            this.rContado = new System.Windows.Forms.RadioButton();
            this.RBPreciomayorista2 = new System.Windows.Forms.RadioButton();
            this.RBPrecioOferta = new System.Windows.Forms.RadioButton();
            this.RBPreciomayorista1 = new System.Windows.Forms.RadioButton();
            this.RBPrecioNormal = new System.Windows.Forms.RadioButton();
            this.CHKPendientestock = new System.Windows.Forms.CheckBox();
            this.CHKHabilitarbalanza = new System.Windows.Forms.CheckBox();
            this.chkporcantidad = new System.Windows.Forms.CheckBox();
            this.lblNomProducto = new System.Windows.Forms.Label();
            this.btnProducto = new System.Windows.Forms.Button();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtcant = new System.Windows.Forms.TextBox();
            this.lblcant = new System.Windows.Forms.Label();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttMensajeAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.lblSistemaVenta = new System.Windows.Forms.Label();
            this.panelHorizontal = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Menudeleteselect = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnAgregarPesable = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.btnCalculadora = new System.Windows.Forms.Button();
            this.grpboxProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVenta)).BeginInit();
            this.gbDetalleMovimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.panelHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpboxProveedor
            // 
            this.grpboxProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpboxProveedor.Controls.Add(this.btnCancelar);
            this.grpboxProveedor.Controls.Add(this.btnGuardar);
            this.grpboxProveedor.Controls.Add(this.TxtcambioDv);
            this.grpboxProveedor.Controls.Add(this.Lblvendedor);
            this.grpboxProveedor.Controls.Add(this.DGVenta);
            this.grpboxProveedor.Controls.Add(this.label3);
            this.grpboxProveedor.Controls.Add(this.txtItems);
            this.grpboxProveedor.Controls.Add(this.txtIva105);
            this.grpboxProveedor.Controls.Add(this.label9);
            this.grpboxProveedor.Controls.Add(this.label8);
            this.grpboxProveedor.Controls.Add(this.txtNeto105);
            this.grpboxProveedor.Controls.Add(this.label7);
            this.grpboxProveedor.Controls.Add(this.txtIVA);
            this.grpboxProveedor.Controls.Add(this.label5);
            this.grpboxProveedor.Controls.Add(this.txtNeto);
            this.grpboxProveedor.Controls.Add(this.label4);
            this.grpboxProveedor.Controls.Add(this.cbxCategoria);
            this.grpboxProveedor.Controls.Add(this.label2);
            this.grpboxProveedor.Controls.Add(this.lblTComprobante);
            this.grpboxProveedor.Controls.Add(this.cbTipoComprobante);
            this.grpboxProveedor.Controls.Add(this.txtTotalPagar);
            this.grpboxProveedor.Controls.Add(this.btnCliente);
            this.grpboxProveedor.Controls.Add(this.txtIdCliente);
            this.grpboxProveedor.Controls.Add(this.txtRazonSocial);
            this.grpboxProveedor.Controls.Add(this.lblRazonSocial);
            this.grpboxProveedor.Controls.Add(this.lblIdProveedor);
            this.grpboxProveedor.Controls.Add(this.lblTotalPagar);
            this.grpboxProveedor.Controls.Add(this.gbDetalleMovimento);
            this.grpboxProveedor.Location = new System.Drawing.Point(7, 41);
            this.grpboxProveedor.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.grpboxProveedor.Name = "grpboxProveedor";
            this.grpboxProveedor.Padding = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.grpboxProveedor.Size = new System.Drawing.Size(1272, 768);
            this.grpboxProveedor.TabIndex = 42;
            this.grpboxProveedor.TabStop = false;
            this.grpboxProveedor.Text = "Punto de venta";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Location = new System.Drawing.Point(9, 721);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(172, 40);
            this.btnCancelar.TabIndex = 109;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGuardar.Location = new System.Drawing.Point(10, 677);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(171, 40);
            this.btnGuardar.TabIndex = 108;
            this.btnGuardar.Text = "Guardar(F2)";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // TxtcambioDv
            // 
            this.TxtcambioDv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtcambioDv.Location = new System.Drawing.Point(601, 313);
            this.TxtcambioDv.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.TxtcambioDv.MaxLength = 10;
            this.TxtcambioDv.Name = "TxtcambioDv";
            this.TxtcambioDv.Size = new System.Drawing.Size(135, 30);
            this.TxtcambioDv.TabIndex = 70;
            this.TxtcambioDv.Text = "0";
            this.TxtcambioDv.Visible = false;
            this.TxtcambioDv.TextChanged += new System.EventHandler(this.TxtcambioDv_TextChanged);
            this.TxtcambioDv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtcambioDv_KeyDown);
            this.TxtcambioDv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtcambioDv_KeyPress);
            this.TxtcambioDv.Leave += new System.EventHandler(this.TxtcambioDv_Leave);
            // 
            // Lblvendedor
            // 
            this.Lblvendedor.AutoSize = true;
            this.Lblvendedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblvendedor.Location = new System.Drawing.Point(1109, 35);
            this.Lblvendedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lblvendedor.Name = "Lblvendedor";
            this.Lblvendedor.Size = new System.Drawing.Size(28, 23);
            this.Lblvendedor.TabIndex = 66;
            this.Lblvendedor.Text = "...";
            // 
            // DGVenta
            // 
            this.DGVenta.AllowUserToAddRows = false;
            this.DGVenta.AllowUserToDeleteRows = false;
            this.DGVenta.AllowUserToOrderColumns = true;
            this.DGVenta.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGVenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVenta.BackgroundColor = System.Drawing.Color.White;
            this.DGVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVenta.ColumnHeadersHeight = 38;
            this.DGVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Producto,
            this.P_Unidad,
            this.Lista,
            this.Cprecio,
            this.Cantidad,
            this.Subtotal,
            this.Descuento,
            this.Importe,
            this.Dpesable,
            this.Calculo,
            this.Preciopormayor,
            this.Cantidadpormayor,
            this.preciounidad,
            this.Civa,
            this.Manual,
            this.Preciocantidad2,
            this.Precio2,
            this.Precio_Oferta,
            this.Stock_Actual,
            this.Stock_Minimo,
            this.PopupMinimo,
            this.PopupCero});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVenta.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVenta.EnableHeadersVisualStyles = false;
            this.DGVenta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVenta.Location = new System.Drawing.Point(6, 253);
            this.DGVenta.MultiSelect = false;
            this.DGVenta.Name = "DGVenta";
            this.DGVenta.RowHeadersVisible = false;
            this.DGVenta.RowTemplate.Height = 24;
            this.DGVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVenta.Size = new System.Drawing.Size(1254, 414);
            this.DGVenta.StandardTab = true;
            this.DGVenta.TabIndex = 107;
            this.DGVenta.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DGVenta.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVenta.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVenta.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVenta.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVenta.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVenta.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGVenta.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVenta.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGVenta.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DGVenta.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVenta.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVenta.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVenta.ThemeStyle.HeaderStyle.Height = 38;
            this.DGVenta.ThemeStyle.ReadOnly = false;
            this.DGVenta.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVenta.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVenta.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVenta.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVenta.ThemeStyle.RowsStyle.Height = 24;
            this.DGVenta.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGVenta.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGVenta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVenta_CellDoubleClick);
            this.DGVenta.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVenta_CellEndEdit);
            this.DGVenta.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DGVenta_CellFormatting);
            this.DGVenta.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DGVenta_RowsAdded);
            this.DGVenta.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DGVenta_RowsRemoved);
            this.DGVenta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DGVenta_KeyDown);
            this.DGVenta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DGVenta_MouseClick);
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
            // P_Unidad
            // 
            this.P_Unidad.FillWeight = 80F;
            this.P_Unidad.HeaderText = "P.Minorista";
            this.P_Unidad.Name = "P_Unidad";
            // 
            // Lista
            // 
            this.Lista.FillWeight = 50F;
            this.Lista.HeaderText = "Lista";
            this.Lista.Name = "Lista";
            // 
            // Cprecio
            // 
            this.Cprecio.FillWeight = 61.54822F;
            this.Cprecio.HeaderText = "Precio";
            this.Cprecio.Name = "Cprecio";
            // 
            // Cantidad
            // 
            this.Cantidad.FillWeight = 61.54822F;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Subtotal
            // 
            this.Subtotal.FillWeight = 61.54822F;
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            this.Descuento.Visible = false;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            // 
            // Dpesable
            // 
            this.Dpesable.HeaderText = "Pesable";
            this.Dpesable.Name = "Dpesable";
            this.Dpesable.Visible = false;
            // 
            // Calculo
            // 
            this.Calculo.HeaderText = "Calculo";
            this.Calculo.Name = "Calculo";
            this.Calculo.Visible = false;
            // 
            // Preciopormayor
            // 
            this.Preciopormayor.HeaderText = "Preciopormayor";
            this.Preciopormayor.Name = "Preciopormayor";
            this.Preciopormayor.Visible = false;
            // 
            // Cantidadpormayor
            // 
            this.Cantidadpormayor.HeaderText = "Cantidadpormayor";
            this.Cantidadpormayor.Name = "Cantidadpormayor";
            this.Cantidadpormayor.Visible = false;
            // 
            // preciounidad
            // 
            this.preciounidad.HeaderText = "preciounidad";
            this.preciounidad.Name = "preciounidad";
            this.preciounidad.Visible = false;
            // 
            // Civa
            // 
            this.Civa.HeaderText = "iva";
            this.Civa.Name = "Civa";
            this.Civa.Visible = false;
            // 
            // Manual
            // 
            this.Manual.HeaderText = "Manual";
            this.Manual.Name = "Manual";
            this.Manual.Visible = false;
            // 
            // Preciocantidad2
            // 
            this.Preciocantidad2.HeaderText = "Preciocantidad2";
            this.Preciocantidad2.Name = "Preciocantidad2";
            this.Preciocantidad2.Visible = false;
            // 
            // Precio2
            // 
            this.Precio2.HeaderText = "Precio2";
            this.Precio2.Name = "Precio2";
            this.Precio2.Visible = false;
            // 
            // Precio_Oferta
            // 
            this.Precio_Oferta.HeaderText = "Precio oferta";
            this.Precio_Oferta.Name = "Precio_Oferta";
            this.Precio_Oferta.Visible = false;
            // 
            // Stock_Actual
            // 
            this.Stock_Actual.HeaderText = "Stock_Actual";
            this.Stock_Actual.Name = "Stock_Actual";
            this.Stock_Actual.Visible = false;
            // 
            // Stock_Minimo
            // 
            this.Stock_Minimo.HeaderText = "Stock_Minimo";
            this.Stock_Minimo.Name = "Stock_Minimo";
            this.Stock_Minimo.Visible = false;
            // 
            // PopupMinimo
            // 
            this.PopupMinimo.HeaderText = "PopupMinimo";
            this.PopupMinimo.Name = "PopupMinimo";
            this.PopupMinimo.Visible = false;
            // 
            // PopupCero
            // 
            this.PopupCero.HeaderText = "PopupCero";
            this.PopupCero.Name = "PopupCero";
            this.PopupCero.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(987, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 37;
            this.label3.Text = "Vendedor :";
            // 
            // txtItems
            // 
            this.txtItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(247)))));
            this.txtItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItems.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItems.Location = new System.Drawing.Point(901, 709);
            this.txtItems.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.txtItems.Name = "txtItems";
            this.txtItems.ReadOnly = true;
            this.txtItems.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtItems.Size = new System.Drawing.Size(54, 32);
            this.txtItems.TabIndex = 78;
            this.txtItems.Text = "0";
            // 
            // txtIva105
            // 
            this.txtIva105.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIva105.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(247)))));
            this.txtIva105.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIva105.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIva105.Location = new System.Drawing.Point(692, 692);
            this.txtIva105.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.txtIva105.Name = "txtIva105";
            this.txtIva105.ReadOnly = true;
            this.txtIva105.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIva105.Size = new System.Drawing.Size(98, 32);
            this.txtIva105.TabIndex = 78;
            this.txtIva105.Text = "0,00";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(809, 711);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 23);
            this.label9.TabIndex = 77;
            this.label9.Text = "ITEMS :";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(560, 694);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 23);
            this.label8.TabIndex = 77;
            this.label8.Text = "IVA 10,5 :";
            // 
            // txtNeto105
            // 
            this.txtNeto105.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNeto105.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(247)))));
            this.txtNeto105.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNeto105.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNeto105.Location = new System.Drawing.Point(430, 688);
            this.txtNeto105.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.txtNeto105.Name = "txtNeto105";
            this.txtNeto105.ReadOnly = true;
            this.txtNeto105.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNeto105.Size = new System.Drawing.Size(98, 32);
            this.txtNeto105.TabIndex = 76;
            this.txtNeto105.Text = "0,00";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(275, 690);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 23);
            this.label7.TabIndex = 75;
            this.label7.Text = "NETO 10,5 :";
            // 
            // txtIVA
            // 
            this.txtIVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIVA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(247)))));
            this.txtIVA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIVA.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIVA.Location = new System.Drawing.Point(692, 728);
            this.txtIVA.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.ReadOnly = true;
            this.txtIVA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIVA.Size = new System.Drawing.Size(99, 32);
            this.txtIVA.TabIndex = 74;
            this.txtIVA.Text = "0,00";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(580, 730);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 73;
            this.label5.Text = "IVA 21 :";
            // 
            // txtNeto
            // 
            this.txtNeto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNeto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(247)))));
            this.txtNeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNeto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNeto.Location = new System.Drawing.Point(430, 725);
            this.txtNeto.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.txtNeto.Name = "txtNeto";
            this.txtNeto.ReadOnly = true;
            this.txtNeto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNeto.Size = new System.Drawing.Size(97, 32);
            this.txtNeto.TabIndex = 72;
            this.txtNeto.Text = "0,00";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(292, 728);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 71;
            this.label4.Text = "NETO 21 :";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.Enabled = false;
            this.cbxCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(919, 27);
            this.cbxCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(60, 33);
            this.cbxCategoria.TabIndex = 62;
            this.cbxCategoria.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxCategoria_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(861, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 61;
            this.label2.Text = "Tipo";
            // 
            // lblTComprobante
            // 
            this.lblTComprobante.AutoSize = true;
            this.lblTComprobante.Location = new System.Drawing.Point(577, 29);
            this.lblTComprobante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTComprobante.Name = "lblTComprobante";
            this.lblTComprobante.Size = new System.Drawing.Size(114, 25);
            this.lblTComprobante.TabIndex = 44;
            this.lblTComprobante.Text = "Tipo Comp.";
            // 
            // cbTipoComprobante
            // 
            this.cbTipoComprobante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbTipoComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoComprobante.Enabled = false;
            this.cbTipoComprobante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTipoComprobante.FormattingEnabled = true;
            this.cbTipoComprobante.Location = new System.Drawing.Point(692, 26);
            this.cbTipoComprobante.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipoComprobante.Name = "cbTipoComprobante";
            this.cbTipoComprobante.Size = new System.Drawing.Size(162, 33);
            this.cbTipoComprobante.TabIndex = 43;
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(247)))));
            this.txtTotalPagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalPagar.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPagar.Location = new System.Drawing.Point(1111, 704);
            this.txtTotalPagar.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.ReadOnly = true;
            this.txtTotalPagar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotalPagar.Size = new System.Drawing.Size(148, 48);
            this.txtTotalPagar.TabIndex = 59;
            this.txtTotalPagar.Text = "0,00";
            // 
            // btnCliente
            // 
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(230, 29);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(26, 28);
            this.btnCliente.TabIndex = 57;
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdCliente.Location = new System.Drawing.Point(107, 28);
            this.txtIdCliente.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(120, 30);
            this.txtIdCliente.TabIndex = 1;
            this.txtIdCliente.TextChanged += new System.EventHandler(this.txtIdCliente_TextChanged);
            this.txtIdCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIdCliente_KeyDown);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRazonSocial.Location = new System.Drawing.Point(390, 26);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.ReadOnly = true;
            this.txtRazonSocial.Size = new System.Drawing.Size(181, 30);
            this.txtRazonSocial.TabIndex = 60;
            this.txtRazonSocial.TextChanged += new System.EventHandler(this.txtRazonSocial_TextChanged);
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(259, 30);
            this.lblRazonSocial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(123, 25);
            this.lblRazonSocial.TabIndex = 54;
            this.lblRazonSocial.Text = "Razon social";
            // 
            // lblIdProveedor
            // 
            this.lblIdProveedor.AutoSize = true;
            this.lblIdProveedor.Location = new System.Drawing.Point(8, 29);
            this.lblIdProveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdProveedor.Name = "lblIdProveedor";
            this.lblIdProveedor.Size = new System.Drawing.Size(99, 25);
            this.lblIdProveedor.TabIndex = 52;
            this.lblIdProveedor.Text = "Nº Cliente";
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagar.Location = new System.Drawing.Point(1006, 718);
            this.lblTotalPagar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(96, 23);
            this.lblTotalPagar.TabIndex = 36;
            this.lblTotalPagar.Text = "TOTAL $ :";
            // 
            // gbDetalleMovimento
            // 
            this.gbDetalleMovimento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDetalleMovimento.Controls.Add(this.DGCliente);
            this.gbDetalleMovimento.Controls.Add(this.groupBox1);
            this.gbDetalleMovimento.Controls.Add(this.RBPreciomayorista2);
            this.gbDetalleMovimento.Controls.Add(this.RBPrecioOferta);
            this.gbDetalleMovimento.Controls.Add(this.RBPreciomayorista1);
            this.gbDetalleMovimento.Controls.Add(this.RBPrecioNormal);
            this.gbDetalleMovimento.Controls.Add(this.CHKPendientestock);
            this.gbDetalleMovimento.Controls.Add(this.CHKHabilitarbalanza);
            this.gbDetalleMovimento.Controls.Add(this.chkporcantidad);
            this.gbDetalleMovimento.Controls.Add(this.lblNomProducto);
            this.gbDetalleMovimento.Controls.Add(this.btnProducto);
            this.gbDetalleMovimento.Controls.Add(this.txtNombreProducto);
            this.gbDetalleMovimento.Location = new System.Drawing.Point(7, 56);
            this.gbDetalleMovimento.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.gbDetalleMovimento.Name = "gbDetalleMovimento";
            this.gbDetalleMovimento.Padding = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.gbDetalleMovimento.Size = new System.Drawing.Size(1258, 187);
            this.gbDetalleMovimento.TabIndex = 40;
            this.gbDetalleMovimento.TabStop = false;
            this.gbDetalleMovimento.Text = "Detalles ";
            // 
            // DGCliente
            // 
            this.DGCliente.AllowUserToAddRows = false;
            this.DGCliente.AllowUserToDeleteRows = false;
            this.DGCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGCliente.Location = new System.Drawing.Point(100, 2);
            this.DGCliente.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.DGCliente.MultiSelect = false;
            this.DGCliente.Name = "DGCliente";
            this.DGCliente.ReadOnly = true;
            this.DGCliente.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGCliente.Size = new System.Drawing.Size(406, 90);
            this.DGCliente.TabIndex = 36;
            this.DGCliente.Visible = false;
            this.DGCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGCliente_CellContentClick);
            this.DGCliente.DoubleClick += new System.EventHandler(this.DGCliente_DoubleClick);
            this.DGCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DGCliente_KeyDown);
            this.DGCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DGCliente_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.Txtcuota);
            this.groupBox1.Controls.Add(this.rctacte);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbMCuota);
            this.groupBox1.Controls.Add(this.cbTarjeta);
            this.groupBox1.Controls.Add(this.rTarjeta);
            this.groupBox1.Controls.Add(this.rContado);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(2, 80);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1253, 103);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forma de pago";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(94, 3);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(576, 90);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.Visible = false;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            this.dataGridView1.Enter += new System.EventHandler(this.dataGridView1_Enter);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            // 
            // Txtcuota
            // 
            this.Txtcuota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(247)))));
            this.Txtcuota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txtcuota.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.Txtcuota.Location = new System.Drawing.Point(617, 67);
            this.Txtcuota.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.Txtcuota.Name = "Txtcuota";
            this.Txtcuota.ReadOnly = true;
            this.Txtcuota.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txtcuota.Size = new System.Drawing.Size(62, 32);
            this.Txtcuota.TabIndex = 76;
            this.Txtcuota.Text = "0,00";
            // 
            // rctacte
            // 
            this.rctacte.Appearance = System.Windows.Forms.Appearance.Button;
            this.rctacte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(247)))));
            this.rctacte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rctacte.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rctacte.Location = new System.Drawing.Point(155, 23);
            this.rctacte.Margin = new System.Windows.Forms.Padding(2);
            this.rctacte.Name = "rctacte";
            this.rctacte.Size = new System.Drawing.Size(113, 30);
            this.rctacte.TabIndex = 80;
            this.rctacte.Text = "CTA CTE";
            this.rctacte.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(508, 72);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 23);
            this.label6.TabIndex = 75;
            this.label6.Text = "CUOTAS :";
            // 
            // cbMCuota
            // 
            this.cbMCuota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbMCuota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMCuota.Location = new System.Drawing.Point(378, 68);
            this.cbMCuota.Margin = new System.Windows.Forms.Padding(2);
            this.cbMCuota.Name = "cbMCuota";
            this.cbMCuota.Size = new System.Drawing.Size(120, 33);
            this.cbMCuota.TabIndex = 79;
            this.cbMCuota.SelectedIndexChanged += new System.EventHandler(this.cbMCuota_SelectedIndexChanged);
            this.cbMCuota.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbMCuota_KeyDown);
            // 
            // cbTarjeta
            // 
            this.cbTarjeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbTarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTarjeta.Enabled = false;
            this.cbTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTarjeta.FormattingEnabled = true;
            this.cbTarjeta.Location = new System.Drawing.Point(155, 66);
            this.cbTarjeta.Margin = new System.Windows.Forms.Padding(2);
            this.cbTarjeta.Name = "cbTarjeta";
            this.cbTarjeta.Size = new System.Drawing.Size(210, 33);
            this.cbTarjeta.TabIndex = 77;
            this.cbTarjeta.SelectedIndexChanged += new System.EventHandler(this.cbTarjeta_SelectedIndexChanged);
            this.cbTarjeta.SelectedValueChanged += new System.EventHandler(this.cbTarjeta_SelectedValueChanged);
            this.cbTarjeta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbTarjeta_KeyDown);
            // 
            // rTarjeta
            // 
            this.rTarjeta.Appearance = System.Windows.Forms.Appearance.Button;
            this.rTarjeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(247)))));
            this.rTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rTarjeta.Location = new System.Drawing.Point(9, 69);
            this.rTarjeta.Margin = new System.Windows.Forms.Padding(2);
            this.rTarjeta.Name = "rTarjeta";
            this.rTarjeta.Size = new System.Drawing.Size(125, 30);
            this.rTarjeta.TabIndex = 76;
            this.rTarjeta.Text = "TARJETA";
            this.rTarjeta.UseVisualStyleBackColor = false;
            this.rTarjeta.CheckedChanged += new System.EventHandler(this.rTarjeta_CheckedChanged);
            // 
            // rContado
            // 
            this.rContado.Appearance = System.Windows.Forms.Appearance.Button;
            this.rContado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(247)))));
            this.rContado.Checked = true;
            this.rContado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rContado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rContado.Location = new System.Drawing.Point(8, 22);
            this.rContado.Margin = new System.Windows.Forms.Padding(2);
            this.rContado.Name = "rContado";
            this.rContado.Size = new System.Drawing.Size(126, 31);
            this.rContado.TabIndex = 75;
            this.rContado.TabStop = true;
            this.rContado.Text = "CONTADO";
            this.rContado.UseVisualStyleBackColor = false;
            this.rContado.CheckedChanged += new System.EventHandler(this.rContado_CheckedChanged);
            // 
            // RBPreciomayorista2
            // 
            this.RBPreciomayorista2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RBPreciomayorista2.Appearance = System.Windows.Forms.Appearance.Button;
            this.RBPreciomayorista2.AutoSize = true;
            this.RBPreciomayorista2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(247)))));
            this.RBPreciomayorista2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RBPreciomayorista2.Location = new System.Drawing.Point(1024, 25);
            this.RBPreciomayorista2.Name = "RBPreciomayorista2";
            this.RBPreciomayorista2.Size = new System.Drawing.Size(105, 37);
            this.RBPreciomayorista2.TabIndex = 67;
            this.RBPreciomayorista2.Text = "F8 - Caja";
            this.RBPreciomayorista2.UseVisualStyleBackColor = false;
            // 
            // RBPrecioOferta
            // 
            this.RBPrecioOferta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RBPrecioOferta.Appearance = System.Windows.Forms.Appearance.Button;
            this.RBPrecioOferta.AutoSize = true;
            this.RBPrecioOferta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(247)))));
            this.RBPrecioOferta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RBPrecioOferta.Location = new System.Drawing.Point(1128, 25);
            this.RBPrecioOferta.Name = "RBPrecioOferta";
            this.RBPrecioOferta.Size = new System.Drawing.Size(123, 37);
            this.RBPrecioOferta.TabIndex = 67;
            this.RBPrecioOferta.Text = "F9 - Distrib.";
            this.RBPrecioOferta.UseVisualStyleBackColor = false;
            // 
            // RBPreciomayorista1
            // 
            this.RBPreciomayorista1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RBPreciomayorista1.Appearance = System.Windows.Forms.Appearance.Button;
            this.RBPreciomayorista1.AutoSize = true;
            this.RBPreciomayorista1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(247)))));
            this.RBPreciomayorista1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RBPreciomayorista1.Location = new System.Drawing.Point(861, 25);
            this.RBPreciomayorista1.Name = "RBPreciomayorista1";
            this.RBPreciomayorista1.Size = new System.Drawing.Size(160, 37);
            this.RBPreciomayorista1.TabIndex = 67;
            this.RBPreciomayorista1.Text = "F7 - 6 unidades";
            this.RBPreciomayorista1.UseVisualStyleBackColor = false;
            // 
            // RBPrecioNormal
            // 
            this.RBPrecioNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RBPrecioNormal.Appearance = System.Windows.Forms.Appearance.Button;
            this.RBPrecioNormal.AutoSize = true;
            this.RBPrecioNormal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(247)))));
            this.RBPrecioNormal.Checked = true;
            this.RBPrecioNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RBPrecioNormal.Location = new System.Drawing.Point(710, 25);
            this.RBPrecioNormal.Name = "RBPrecioNormal";
            this.RBPrecioNormal.Size = new System.Drawing.Size(148, 37);
            this.RBPrecioNormal.TabIndex = 67;
            this.RBPrecioNormal.TabStop = true;
            this.RBPrecioNormal.Text = "F6 - P.Unitario";
            this.RBPrecioNormal.UseVisualStyleBackColor = false;
            // 
            // CHKPendientestock
            // 
            this.CHKPendientestock.AutoSize = true;
            this.CHKPendientestock.Checked = true;
            this.CHKPendientestock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHKPendientestock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CHKPendientestock.Location = new System.Drawing.Point(518, 20);
            this.CHKPendientestock.Margin = new System.Windows.Forms.Padding(2);
            this.CHKPendientestock.Name = "CHKPendientestock";
            this.CHKPendientestock.Size = new System.Drawing.Size(196, 29);
            this.CHKPendientestock.TabIndex = 81;
            this.CHKPendientestock.Text = "Pendiente de stock";
            this.CHKPendientestock.UseVisualStyleBackColor = true;
            this.CHKPendientestock.Visible = false;
            // 
            // CHKHabilitarbalanza
            // 
            this.CHKHabilitarbalanza.AutoSize = true;
            this.CHKHabilitarbalanza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CHKHabilitarbalanza.Location = new System.Drawing.Point(361, 52);
            this.CHKHabilitarbalanza.Margin = new System.Windows.Forms.Padding(2);
            this.CHKHabilitarbalanza.Name = "CHKHabilitarbalanza";
            this.CHKHabilitarbalanza.Size = new System.Drawing.Size(217, 29);
            this.CHKHabilitarbalanza.TabIndex = 68;
            this.CHKHabilitarbalanza.Text = "F11-Habilitar Balanza";
            this.CHKHabilitarbalanza.UseVisualStyleBackColor = true;
            this.CHKHabilitarbalanza.CheckedChanged += new System.EventHandler(this.chkporcantidad_CheckedChanged);
            this.CHKHabilitarbalanza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chkporcantidad_KeyPress);
            // 
            // chkporcantidad
            // 
            this.chkporcantidad.AutoSize = true;
            this.chkporcantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkporcantidad.Location = new System.Drawing.Point(361, 19);
            this.chkporcantidad.Margin = new System.Windows.Forms.Padding(2);
            this.chkporcantidad.Name = "chkporcantidad";
            this.chkporcantidad.Size = new System.Drawing.Size(160, 29);
            this.chkporcantidad.TabIndex = 68;
            this.chkporcantidad.Text = "F10 - Cantidad";
            this.chkporcantidad.UseVisualStyleBackColor = true;
            this.chkporcantidad.CheckedChanged += new System.EventHandler(this.chkporcantidad_CheckedChanged);
            this.chkporcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chkporcantidad_KeyPress);
            // 
            // lblNomProducto
            // 
            this.lblNomProducto.AutoSize = true;
            this.lblNomProducto.Location = new System.Drawing.Point(3, 39);
            this.lblNomProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomProducto.Name = "lblNomProducto";
            this.lblNomProducto.Size = new System.Drawing.Size(90, 25);
            this.lblNomProducto.TabIndex = 61;
            this.lblNomProducto.Text = "Producto";
            // 
            // btnProducto
            // 
            this.btnProducto.Enabled = false;
            this.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnProducto.Image")));
            this.btnProducto.Location = new System.Drawing.Point(323, 38);
            this.btnProducto.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(26, 29);
            this.btnProducto.TabIndex = 3;
            this.btnProducto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreProducto.Enabled = false;
            this.txtNombreProducto.Location = new System.Drawing.Point(97, 38);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(225, 30);
            this.txtNombreProducto.TabIndex = 2;
            this.txtNombreProducto.LocationChanged += new System.EventHandler(this.txtNombreProducto_LocationChanged);
            this.txtNombreProducto.TextChanged += new System.EventHandler(this.txtNombreProducto_TextChanged_1);
            this.txtNombreProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombreProducto_KeyDown);
            // 
            // txtcant
            // 
            this.txtcant.Location = new System.Drawing.Point(1185, 40);
            this.txtcant.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.txtcant.MaxLength = 10;
            this.txtcant.Name = "txtcant";
            this.txtcant.Size = new System.Drawing.Size(54, 30);
            this.txtcant.TabIndex = 66;
            this.txtcant.Text = "0";
            this.txtcant.Visible = false;
            this.txtcant.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtcant_MouseClick);
            this.txtcant.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtcant.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcant_KeyDown);
            this.txtcant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.txtcant.Validated += new System.EventHandler(this.txtcant_Validated);
            // 
            // lblcant
            // 
            this.lblcant.AutoSize = true;
            this.lblcant.Location = new System.Drawing.Point(1075, 40);
            this.lblcant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcant.Name = "lblcant";
            this.lblcant.Size = new System.Drawing.Size(102, 25);
            this.lblcant.TabIndex = 67;
            this.lblcant.Text = "Cantidad :";
            this.lblcant.Visible = false;
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
            this.lblSistemaVenta.Location = new System.Drawing.Point(0, 0);
            this.lblSistemaVenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSistemaVenta.Name = "lblSistemaVenta";
            this.lblSistemaVenta.Size = new System.Drawing.Size(100, 22);
            this.lblSistemaVenta.TabIndex = 6;
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
            this.panelHorizontal.Margin = new System.Windows.Forms.Padding(2);
            this.panelHorizontal.Name = "panelHorizontal";
            this.panelHorizontal.Size = new System.Drawing.Size(1284, 37);
            this.panelHorizontal.TabIndex = 64;
            this.panelHorizontal.DoubleClick += new System.EventHandler(this.panelHorizontal_DoubleClick);
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
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "VENTAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.BackgroundImage")));
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMaximizar.Location = new System.Drawing.Point(1224, 5);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnRestaurar.Location = new System.Drawing.Point(1224, 5);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnMinimizar.Location = new System.Drawing.Point(1190, 5);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2);
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
            this.btnCerrar.ErrorImage = null;
            this.btnCerrar.Location = new System.Drawing.Point(1256, 5);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(22, 25);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            this.btnCerrar.MouseLeave += new System.EventHandler(this.btnCerrar_MouseLeave);
            this.btnCerrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCerrar_MouseMove);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1472, 42);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 28);
            this.button1.TabIndex = 65;
            this.button1.Text = "Cerrar turno";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menudeleteselect});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(198, 28);
            // 
            // Menudeleteselect
            // 
            this.Menudeleteselect.Name = "Menudeleteselect";
            this.Menudeleteselect.Size = new System.Drawing.Size(197, 24);
            this.Menudeleteselect.Text = "Eliminar seleccion";
            this.Menudeleteselect.Click += new System.EventHandler(this.Menudeleteselect_Click);
            // 
            // btnAgregarPesable
            // 
            this.btnAgregarPesable.Enabled = false;
            this.btnAgregarPesable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPesable.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarPesable.Image")));
            this.btnAgregarPesable.Location = new System.Drawing.Point(1041, 42);
            this.btnAgregarPesable.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarPesable.Name = "btnAgregarPesable";
            this.btnAgregarPesable.Size = new System.Drawing.Size(28, 28);
            this.btnAgregarPesable.TabIndex = 65;
            this.btnAgregarPesable.UseVisualStyleBackColor = true;
            this.btnAgregarPesable.Visible = false;
            this.btnAgregarPesable.Click += new System.EventHandler(this.btnAgregarPesable_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultas.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultas.Image")));
            this.btnConsultas.Location = new System.Drawing.Point(1645, 42);
            this.btnConsultas.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(28, 28);
            this.btnConsultas.TabIndex = 60;
            this.btnConsultas.UseVisualStyleBackColor = true;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculadora.Image = ((System.Drawing.Image)(resources.GetObject("btnCalculadora.Image")));
            this.btnCalculadora.Location = new System.Drawing.Point(1610, 42);
            this.btnCalculadora.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(28, 28);
            this.btnCalculadora.TabIndex = 58;
            this.btnCalculadora.UseVisualStyleBackColor = true;
            this.btnCalculadora.Click += new System.EventHandler(this.btnCalculadora_Click);
            // 
            // frmPventa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 813);
            this.Controls.Add(this.txtcant);
            this.Controls.Add(this.lblcant);
            this.Controls.Add(this.btnAgregarPesable);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnConsultas);
            this.Controls.Add(this.btnCalculadora);
            this.Controls.Add(this.panelHorizontal);
            this.Controls.Add(this.grpboxProveedor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.Name = "frmPventa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPventa_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPventa_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPventa_MouseMove);
            this.grpboxProveedor.ResumeLayout(false);
            this.grpboxProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVenta)).EndInit();
            this.gbDetalleMovimento.ResumeLayout(false);
            this.gbDetalleMovimento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGCliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.panelHorizontal.ResumeLayout(false);
            this.panelHorizontal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxProveedor;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblIdProveedor;
        private System.Windows.Forms.GroupBox gbDetalleMovimento;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.ComboBox cbTipoComprobante;
        private System.Windows.Forms.Label lblTComprobante;
        public System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.Label lblNomProducto;
        private System.Windows.Forms.Button btnCalculadora;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.ToolTip ttMensajeAyuda;
        private System.Windows.Forms.Panel panelHorizontal;
        private System.Windows.Forms.Label lblSistemaVenta;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Button btnAgregarPesable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Lblvendedor;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtcant;
        private System.Windows.Forms.Label lblcant;
        private System.Windows.Forms.CheckBox chkporcantidad;
        public System.Windows.Forms.TextBox TxtcambioDv;
        public System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtNeto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menudeleteselect;
        private System.Windows.Forms.RadioButton rTarjeta;
        private System.Windows.Forms.RadioButton rContado;
        private System.Windows.Forms.ComboBox cbTarjeta;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox Txtcuota;
        private System.Windows.Forms.Label label6;
        private ComboBoxMultiColumns.ComboBoxMultiColumns cbMCuota;
        private System.Windows.Forms.RadioButton rctacte;
        public System.Windows.Forms.TextBox txtIva105;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtNeto105;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaDataGridView DGVenta;
        private System.Windows.Forms.CheckBox CHKPendientestock;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.RadioButton RBPrecioOferta;
        private System.Windows.Forms.RadioButton RBPreciomayorista2;
        private System.Windows.Forms.RadioButton RBPreciomayorista1;
        private System.Windows.Forms.RadioButton RBPrecioNormal;
        private System.Windows.Forms.CheckBox CHKHabilitarbalanza;
        private System.Windows.Forms.DataGridView DGCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.TextBox txtItems;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn P_Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cprecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dpesable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preciopormayor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidadpormayor;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciounidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Civa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preciocantidad2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Oferta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock_Actual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock_Minimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PopupMinimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PopupCero;
    }
}