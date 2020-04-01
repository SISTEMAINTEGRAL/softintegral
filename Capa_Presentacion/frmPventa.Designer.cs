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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPventa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpboxProveedor = new System.Windows.Forms.GroupBox();
            this.Txtcuota = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNeto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtcambioDv = new System.Windows.Forms.TextBox();
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.DGVenta = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dpesable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDetalleMovimento = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMCuota = new ComboBoxMultiColumns.ComboBoxMultiColumns();
            this.cbTarjeta = new System.Windows.Forms.ComboBox();
            this.rTarjeta = new System.Windows.Forms.RadioButton();
            this.rContado = new System.Windows.Forms.RadioButton();
            this.chkPreciomanual = new System.Windows.Forms.CheckBox();
            this.chkporcantidad = new System.Windows.Forms.CheckBox();
            this.btnAgregarPesable = new System.Windows.Forms.Button();
            this.lblNomProducto = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.TxtDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.TxtDetalle = new System.Windows.Forms.TextBox();
            this.lblPrecioCompra = new System.Windows.Forms.Label();
            this.btnProducto = new System.Windows.Forms.Button();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtcant = new System.Windows.Forms.TextBox();
            this.lblcant = new System.Windows.Forms.Label();
            this.lblTotalPagar = new System.Windows.Forms.Label();
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
            this.label3 = new System.Windows.Forms.Label();
            this.Lblvendedor = new System.Windows.Forms.Label();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.btnCalculadora = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Menudeleteselect = new System.Windows.Forms.ToolStripMenuItem();
            this.grpboxProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVenta)).BeginInit();
            this.gbDetalleMovimento.SuspendLayout();
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
            this.grpboxProveedor.Controls.Add(this.Txtcuota);
            this.grpboxProveedor.Controls.Add(this.label6);
            this.grpboxProveedor.Controls.Add(this.txtIVA);
            this.grpboxProveedor.Controls.Add(this.label5);
            this.grpboxProveedor.Controls.Add(this.txtNeto);
            this.grpboxProveedor.Controls.Add(this.label4);
            this.grpboxProveedor.Controls.Add(this.TxtcambioDv);
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
            this.grpboxProveedor.Controls.Add(this.btnCancelar);
            this.grpboxProveedor.Controls.Add(this.btnGuardar);
            this.grpboxProveedor.Controls.Add(this.DGVenta);
            this.grpboxProveedor.Controls.Add(this.gbDetalleMovimento);
            this.grpboxProveedor.Controls.Add(this.lblTotalPagar);
            this.grpboxProveedor.Location = new System.Drawing.Point(13, 70);
            this.grpboxProveedor.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.grpboxProveedor.Name = "grpboxProveedor";
            this.grpboxProveedor.Padding = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.grpboxProveedor.Size = new System.Drawing.Size(1660, 706);
            this.grpboxProveedor.TabIndex = 42;
            this.grpboxProveedor.TabStop = false;
            this.grpboxProveedor.Text = "Punto de venta";
            // 
            // Txtcuota
            // 
            this.Txtcuota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Txtcuota.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Txtcuota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txtcuota.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.Txtcuota.Location = new System.Drawing.Point(811, 644);
            this.Txtcuota.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Txtcuota.Name = "Txtcuota";
            this.Txtcuota.ReadOnly = true;
            this.Txtcuota.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txtcuota.Size = new System.Drawing.Size(121, 48);
            this.Txtcuota.TabIndex = 76;
            this.Txtcuota.Text = "0,00";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(691, 656);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 23);
            this.label6.TabIndex = 75;
            this.label6.Text = "CUOTAS :";
            // 
            // txtIVA
            // 
            this.txtIVA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIVA.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.txtIVA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIVA.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.txtIVA.Location = new System.Drawing.Point(1271, 646);
            this.txtIVA.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.ReadOnly = true;
            this.txtIVA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtIVA.Size = new System.Drawing.Size(121, 48);
            this.txtIVA.TabIndex = 74;
            this.txtIVA.Text = "0,00";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1180, 659);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 73;
            this.label5.Text = "IVA 21 :";
            // 
            // txtNeto
            // 
            this.txtNeto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNeto.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.txtNeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNeto.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.txtNeto.Location = new System.Drawing.Point(1058, 646);
            this.txtNeto.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtNeto.Name = "txtNeto";
            this.txtNeto.ReadOnly = true;
            this.txtNeto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNeto.Size = new System.Drawing.Size(121, 48);
            this.txtNeto.TabIndex = 72;
            this.txtNeto.Text = "0,00";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(982, 659);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 23);
            this.label4.TabIndex = 71;
            this.label4.Text = "NETO :";
            // 
            // TxtcambioDv
            // 
            this.TxtcambioDv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtcambioDv.Location = new System.Drawing.Point(557, 318);
            this.TxtcambioDv.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
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
            // cbxCategoria
            // 
            this.cbxCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.Enabled = false;
            this.cbxCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(1002, 43);
            this.cbxCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(61, 33);
            this.cbxCategoria.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(955, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 61;
            this.label2.Text = "Tipo";
            // 
            // lblTComprobante
            // 
            this.lblTComprobante.AutoSize = true;
            this.lblTComprobante.Location = new System.Drawing.Point(641, 46);
            this.lblTComprobante.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTComprobante.Name = "lblTComprobante";
            this.lblTComprobante.Size = new System.Drawing.Size(175, 25);
            this.lblTComprobante.TabIndex = 44;
            this.lblTComprobante.Text = "Tipo Comprobante";
            // 
            // cbTipoComprobante
            // 
            this.cbTipoComprobante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbTipoComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoComprobante.Enabled = false;
            this.cbTipoComprobante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTipoComprobante.FormattingEnabled = true;
            this.cbTipoComprobante.Location = new System.Drawing.Point(783, 42);
            this.cbTipoComprobante.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipoComprobante.Name = "cbTipoComprobante";
            this.cbTipoComprobante.Size = new System.Drawing.Size(163, 33);
            this.cbTipoComprobante.TabIndex = 43;
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotalPagar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.txtTotalPagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalPagar.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.txtTotalPagar.Location = new System.Drawing.Point(1501, 646);
            this.txtTotalPagar.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
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
            this.btnCliente.Location = new System.Drawing.Point(309, 42);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
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
            this.txtIdCliente.Location = new System.Drawing.Point(147, 43);
            this.txtIdCliente.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(154, 30);
            this.txtIdCliente.TabIndex = 1;
            this.txtIdCliente.TextChanged += new System.EventHandler(this.txtIdCliente_TextChanged);
            this.txtIdCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIdCliente_KeyDown);
            this.txtIdCliente.Leave += new System.EventHandler(this.txtIdCliente_Leave);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRazonSocial.Location = new System.Drawing.Point(451, 42);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.ReadOnly = true;
            this.txtRazonSocial.Size = new System.Drawing.Size(187, 30);
            this.txtRazonSocial.TabIndex = 60;
            this.txtRazonSocial.TextChanged += new System.EventHandler(this.txtRazonSocial_TextChanged);
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(343, 45);
            this.lblRazonSocial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(123, 25);
            this.lblRazonSocial.TabIndex = 54;
            this.lblRazonSocial.Text = "Razon social";
            // 
            // lblIdProveedor
            // 
            this.lblIdProveedor.AutoSize = true;
            this.lblIdProveedor.Location = new System.Drawing.Point(9, 43);
            this.lblIdProveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdProveedor.Name = "lblIdProveedor";
            this.lblIdProveedor.Size = new System.Drawing.Size(163, 25);
            this.lblIdProveedor.TabIndex = 52;
            this.lblIdProveedor.Text = "Código de cliente";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(132, 646);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(113, 40);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(9, 646);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(113, 40);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar(F2)";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            this.DGVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Producto,
            this.Precio,
            this.Cantidad,
            this.subtotal,
            this.Descuento,
            this.Importe,
            this.Dpesable,
            this.Calculo});
            this.DGVenta.EnableHeadersVisualStyles = false;
            this.DGVenta.Location = new System.Drawing.Point(8, 287);
            this.DGVenta.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.DGVenta.MultiSelect = false;
            this.DGVenta.Name = "DGVenta";
            this.DGVenta.ReadOnly = true;
            this.DGVenta.RowHeadersWidth = 38;
            this.DGVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVenta.Size = new System.Drawing.Size(1642, 345);
            this.DGVenta.TabIndex = 6;
            this.DGVenta.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.DGVenta_CellBeginEdit);
            this.DGVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVenta_CellContentClick);
            this.DGVenta.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVenta_CellContentDoubleClick);
            this.DGVenta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVenta_CellDoubleClick);
            this.DGVenta.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVenta_CellEndEdit);
            this.DGVenta.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DGVenta_EditingControlShowing);
            this.DGVenta.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DGVenta_RowsAdded);
            this.DGVenta.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DGVenta_RowsRemoved);
            this.DGVenta.Click += new System.EventHandler(this.DGVenta_Click);
            this.DGVenta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DGVenta_KeyDown);
            this.DGVenta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DGVenta_MouseClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            this.Descuento.ReadOnly = true;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // Dpesable
            // 
            this.Dpesable.HeaderText = "Pesable";
            this.Dpesable.Name = "Dpesable";
            this.Dpesable.ReadOnly = true;
            this.Dpesable.Visible = false;
            // 
            // Calculo
            // 
            this.Calculo.HeaderText = "Calculo";
            this.Calculo.Name = "Calculo";
            this.Calculo.ReadOnly = true;
            this.Calculo.Visible = false;
            // 
            // gbDetalleMovimento
            // 
            this.gbDetalleMovimento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDetalleMovimento.Controls.Add(this.groupBox1);
            this.gbDetalleMovimento.Controls.Add(this.chkPreciomanual);
            this.gbDetalleMovimento.Controls.Add(this.chkporcantidad);
            this.gbDetalleMovimento.Controls.Add(this.btnAgregarPesable);
            this.gbDetalleMovimento.Controls.Add(this.lblNomProducto);
            this.gbDetalleMovimento.Controls.Add(this.dataGridView1);
            this.gbDetalleMovimento.Controls.Add(this.TxtCodigo);
            this.gbDetalleMovimento.Controls.Add(this.lblCodigo);
            this.gbDetalleMovimento.Controls.Add(this.TxtPrecio);
            this.gbDetalleMovimento.Controls.Add(this.lblPrecio);
            this.gbDetalleMovimento.Controls.Add(this.TxtDesc);
            this.gbDetalleMovimento.Controls.Add(this.lblDesc);
            this.gbDetalleMovimento.Controls.Add(this.TxtDetalle);
            this.gbDetalleMovimento.Controls.Add(this.lblPrecioCompra);
            this.gbDetalleMovimento.Controls.Add(this.btnProducto);
            this.gbDetalleMovimento.Controls.Add(this.txtNombreProducto);
            this.gbDetalleMovimento.Controls.Add(this.txtcant);
            this.gbDetalleMovimento.Controls.Add(this.lblcant);
            this.gbDetalleMovimento.Location = new System.Drawing.Point(8, 73);
            this.gbDetalleMovimento.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.gbDetalleMovimento.Name = "gbDetalleMovimento";
            this.gbDetalleMovimento.Padding = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.gbDetalleMovimento.Size = new System.Drawing.Size(1640, 218);
            this.gbDetalleMovimento.TabIndex = 40;
            this.gbDetalleMovimento.TabStop = false;
            this.gbDetalleMovimento.Text = "Detalles ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbMCuota);
            this.groupBox1.Controls.Add(this.cbTarjeta);
            this.groupBox1.Controls.Add(this.rTarjeta);
            this.groupBox1.Controls.Add(this.rContado);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(3, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1622, 71);
            this.groupBox1.TabIndex = 80;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forma de pago";
            // 
            // cbMCuota
            // 
            this.cbMCuota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbMCuota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMCuota.Location = new System.Drawing.Point(543, 24);
            this.cbMCuota.Name = "cbMCuota";
            this.cbMCuota.Size = new System.Drawing.Size(121, 33);
            this.cbMCuota.TabIndex = 79;
            this.cbMCuota.SelectedIndexChanged += new System.EventHandler(this.cbMCuota_SelectedIndexChanged);
            // 
            // cbTarjeta
            // 
            this.cbTarjeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbTarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTarjeta.Enabled = false;
            this.cbTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTarjeta.FormattingEnabled = true;
            this.cbTarjeta.Location = new System.Drawing.Point(320, 23);
            this.cbTarjeta.Name = "cbTarjeta";
            this.cbTarjeta.Size = new System.Drawing.Size(210, 33);
            this.cbTarjeta.TabIndex = 77;
            this.cbTarjeta.SelectedIndexChanged += new System.EventHandler(this.cbTarjeta_SelectedIndexChanged);
            this.cbTarjeta.SelectedValueChanged += new System.EventHandler(this.cbTarjeta_SelectedValueChanged);
            // 
            // rTarjeta
            // 
            this.rTarjeta.Appearance = System.Windows.Forms.Appearance.Button;
            this.rTarjeta.BackColor = System.Drawing.Color.Silver;
            this.rTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rTarjeta.Location = new System.Drawing.Point(172, 23);
            this.rTarjeta.Name = "rTarjeta";
            this.rTarjeta.Size = new System.Drawing.Size(113, 30);
            this.rTarjeta.TabIndex = 76;
            this.rTarjeta.Text = "TARJETA";
            this.rTarjeta.UseVisualStyleBackColor = false;
            this.rTarjeta.CheckedChanged += new System.EventHandler(this.rTarjeta_CheckedChanged);
            // 
            // rContado
            // 
            this.rContado.Appearance = System.Windows.Forms.Appearance.Button;
            this.rContado.BackColor = System.Drawing.Color.Silver;
            this.rContado.Checked = true;
            this.rContado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rContado.Location = new System.Drawing.Point(9, 23);
            this.rContado.Name = "rContado";
            this.rContado.Size = new System.Drawing.Size(126, 31);
            this.rContado.TabIndex = 75;
            this.rContado.TabStop = true;
            this.rContado.Text = "CONTADO";
            this.rContado.UseVisualStyleBackColor = false;
            this.rContado.CheckedChanged += new System.EventHandler(this.rContado_CheckedChanged);
            // 
            // chkPreciomanual
            // 
            this.chkPreciomanual.AutoSize = true;
            this.chkPreciomanual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkPreciomanual.Location = new System.Drawing.Point(867, 66);
            this.chkPreciomanual.Name = "chkPreciomanual";
            this.chkPreciomanual.Size = new System.Drawing.Size(53, 29);
            this.chkPreciomanual.TabIndex = 69;
            this.chkPreciomanual.Text = "F3";
            this.chkPreciomanual.UseVisualStyleBackColor = true;
            this.chkPreciomanual.Visible = false;
            this.chkPreciomanual.CheckedChanged += new System.EventHandler(this.chkPreciomanual_CheckedChanged);
            // 
            // chkporcantidad
            // 
            this.chkporcantidad.AutoSize = true;
            this.chkporcantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkporcantidad.Location = new System.Drawing.Point(8, 113);
            this.chkporcantidad.Name = "chkporcantidad";
            this.chkporcantidad.Size = new System.Drawing.Size(64, 29);
            this.chkporcantidad.TabIndex = 68;
            this.chkporcantidad.Text = "F10";
            this.chkporcantidad.UseVisualStyleBackColor = true;
            this.chkporcantidad.CheckedChanged += new System.EventHandler(this.chkporcantidad_CheckedChanged);
            this.chkporcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chkporcantidad_KeyPress);
            // 
            // btnAgregarPesable
            // 
            this.btnAgregarPesable.Enabled = false;
            this.btnAgregarPesable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPesable.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarPesable.Image")));
            this.btnAgregarPesable.Location = new System.Drawing.Point(410, 22);
            this.btnAgregarPesable.Name = "btnAgregarPesable";
            this.btnAgregarPesable.Size = new System.Drawing.Size(28, 28);
            this.btnAgregarPesable.TabIndex = 65;
            this.btnAgregarPesable.UseVisualStyleBackColor = true;
            this.btnAgregarPesable.Click += new System.EventHandler(this.btnAgregarPesable_Click);
            // 
            // lblNomProducto
            // 
            this.lblNomProducto.AutoSize = true;
            this.lblNomProducto.Location = new System.Drawing.Point(6, 26);
            this.lblNomProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomProducto.Name = "lblNomProducto";
            this.lblNomProducto.Size = new System.Drawing.Size(90, 25);
            this.lblNomProducto.TabIndex = 61;
            this.lblNomProducto.Text = "Producto";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Location = new System.Drawing.Point(100, 51);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(406, 90);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCodigo.Location = new System.Drawing.Point(100, 67);
            this.TxtCodigo.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.ReadOnly = true;
            this.TxtCodigo.Size = new System.Drawing.Size(273, 30);
            this.TxtCodigo.TabIndex = 42;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(8, 70);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(75, 25);
            this.lblCodigo.TabIndex = 41;
            this.lblCodigo.Text = "Codigo";
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPrecio.Enabled = false;
            this.TxtPrecio.Location = new System.Drawing.Point(569, 66);
            this.TxtPrecio.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.ReadOnly = true;
            this.TxtPrecio.Size = new System.Drawing.Size(276, 30);
            this.TxtPrecio.TabIndex = 56;
            this.TxtPrecio.Text = "0,00";
            this.TxtPrecio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPrecio_KeyDown);
            this.TxtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecio_KeyPress);
            this.TxtPrecio.Leave += new System.EventHandler(this.TxtPrecio_Leave);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(486, 69);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(78, 25);
            this.lblPrecio.TabIndex = 39;
            this.lblPrecio.Text = "Precio :";
            // 
            // TxtDesc
            // 
            this.TxtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDesc.Enabled = false;
            this.TxtDesc.Location = new System.Drawing.Point(568, 110);
            this.TxtDesc.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.TxtDesc.MaxLength = 3;
            this.TxtDesc.Name = "TxtDesc";
            this.TxtDesc.Size = new System.Drawing.Size(55, 30);
            this.TxtDesc.TabIndex = 5;
            this.TxtDesc.Text = "0";
            this.TxtDesc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtDesc_MouseClick);
            this.TxtDesc.TextChanged += new System.EventHandler(this.TxtDesc_TextChanged);
            this.TxtDesc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtDesc_KeyDown);
            this.TxtDesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDesc_KeyPress);
            this.TxtDesc.Leave += new System.EventHandler(this.TxtDesc_Leave);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(486, 113);
            this.lblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(73, 25);
            this.lblDesc.TabIndex = 37;
            this.lblDesc.Text = "Desc. :";
            // 
            // TxtDetalle
            // 
            this.TxtDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDetalle.Location = new System.Drawing.Point(570, 22);
            this.TxtDetalle.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.TxtDetalle.MaxLength = 10;
            this.TxtDetalle.Name = "TxtDetalle";
            this.TxtDetalle.ReadOnly = true;
            this.TxtDetalle.Size = new System.Drawing.Size(369, 30);
            this.TxtDetalle.TabIndex = 55;
            this.TxtDetalle.TextChanged += new System.EventHandler(this.TxtDetalle_TextChanged);
            // 
            // lblPrecioCompra
            // 
            this.lblPrecioCompra.AutoSize = true;
            this.lblPrecioCompra.Location = new System.Drawing.Point(480, 25);
            this.lblPrecioCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioCompra.Name = "lblPrecioCompra";
            this.lblPrecioCompra.Size = new System.Drawing.Size(83, 25);
            this.lblPrecioCompra.TabIndex = 28;
            this.lblPrecioCompra.Text = "Detalle :";
            // 
            // btnProducto
            // 
            this.btnProducto.Enabled = false;
            this.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnProducto.Image")));
            this.btnProducto.Location = new System.Drawing.Point(378, 22);
            this.btnProducto.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(26, 28);
            this.btnProducto.TabIndex = 3;
            this.btnProducto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreProducto.Enabled = false;
            this.txtNombreProducto.Location = new System.Drawing.Point(100, 23);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(273, 30);
            this.txtNombreProducto.TabIndex = 2;
            this.txtNombreProducto.TextChanged += new System.EventHandler(this.txtNombreProducto_TextChanged_1);
            this.txtNombreProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombreProducto_KeyDown);
            // 
            // txtcant
            // 
            this.txtcant.Location = new System.Drawing.Point(186, 113);
            this.txtcant.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtcant.MaxLength = 10;
            this.txtcant.Name = "txtcant";
            this.txtcant.Size = new System.Drawing.Size(55, 30);
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
            this.lblcant.Location = new System.Drawing.Point(96, 116);
            this.lblcant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcant.Name = "lblcant";
            this.lblcant.Size = new System.Drawing.Size(102, 25);
            this.lblcant.TabIndex = 67;
            this.lblcant.Text = "Cantidad :";
            this.lblcant.Visible = false;
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagar.Location = new System.Drawing.Point(1396, 656);
            this.lblTotalPagar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(96, 23);
            this.lblTotalPagar.TabIndex = 36;
            this.lblTotalPagar.Text = "TOTAL $ :";
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
            this.lblSistemaVenta.Name = "lblSistemaVenta";
            this.lblSistemaVenta.Size = new System.Drawing.Size(100, 23);
            this.lblSistemaVenta.TabIndex = 6;
            // 
            // panelHorizontal
            // 
            this.panelHorizontal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(170)))));
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
            this.panelHorizontal.Size = new System.Drawing.Size(1678, 37);
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
            this.btnMaximizar.Location = new System.Drawing.Point(1618, 5);
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
            this.btnRestaurar.Location = new System.Drawing.Point(1618, 5);
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
            this.btnMinimizar.Location = new System.Drawing.Point(1585, 5);
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
            this.btnCerrar.Location = new System.Drawing.Point(1651, 5);
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
            this.button1.Location = new System.Drawing.Point(1473, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 28);
            this.button1.TabIndex = 65;
            this.button1.Text = "Cerrar turno";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 37;
            this.label3.Text = "Vendedor :";
            // 
            // Lblvendedor
            // 
            this.Lblvendedor.AutoSize = true;
            this.Lblvendedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblvendedor.Location = new System.Drawing.Point(127, 40);
            this.Lblvendedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lblvendedor.Name = "Lblvendedor";
            this.Lblvendedor.Size = new System.Drawing.Size(28, 23);
            this.Lblvendedor.TabIndex = 66;
            this.Lblvendedor.Text = "...";
            // 
            // btnConsultas
            // 
            this.btnConsultas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultas.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultas.Image")));
            this.btnConsultas.Location = new System.Drawing.Point(1645, 43);
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
            this.btnCalculadora.Location = new System.Drawing.Point(1611, 43);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(28, 28);
            this.btnCalculadora.TabIndex = 58;
            this.btnCalculadora.UseVisualStyleBackColor = true;
            this.btnCalculadora.Click += new System.EventHandler(this.btnCalculadora_Click);
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
            // frmPventa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1678, 790);
            this.Controls.Add(this.Lblvendedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnConsultas);
            this.Controls.Add(this.btnCalculadora);
            this.Controls.Add(this.panelHorizontal);
            this.Controls.Add(this.grpboxProveedor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
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
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView DGVenta;
        private System.Windows.Forms.GroupBox gbDetalleMovimento;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        public System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        public System.Windows.Forms.TextBox TxtDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox TxtDetalle;
        private System.Windows.Forms.Label lblPrecioCompra;
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
        private System.Windows.Forms.CheckBox chkPreciomanual;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dpesable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calculo;

    }
}