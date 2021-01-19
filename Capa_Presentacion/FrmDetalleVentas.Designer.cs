namespace Capa_Presentacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblFechaVenta = new System.Windows.Forms.Label();
            this.txtFechaVenta = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.gbDetalleMovimento = new System.Windows.Forms.GroupBox();
            this.BtnVerMultipagoPadre = new XanderUI.XUISuperButton();
            this.DataVentaMultipago = new Guna.UI.WinForms.GunaDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formadepago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLista = new Guna.UI.WinForms.GunaDataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btncredito = new XanderUI.XUISuperButton();
            this.BtnVentaMultipago = new XanderUI.XUISuperButton();
            this.btnPagarMovimiento = new XanderUI.XUISuperButton();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcuit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxHerramientas = new System.Windows.Forms.GroupBox();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.btnCalculadora = new System.Windows.Forms.Button();
            this.LblNroReferencia = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.TxtNroReferencia = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.lblTipo_comprobante = new System.Windows.Forms.Label();
            this.txtTipoComprobante = new System.Windows.Forms.TextBox();
            this.TxtFPago = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelHorizontal = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lblSistemaVenta = new System.Windows.Forms.Label();
            this.gbDetalleMovimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataVentaMultipago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).BeginInit();
            this.gbxHerramientas.SuspendLayout();
            this.panelHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtTotal.Location = new System.Drawing.Point(765, 614);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(229, 52);
            this.txtTotal.TabIndex = 43;
            this.txtTotal.Text = "0,00";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(653, 622);
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
            this.lblCodigo.Size = new System.Drawing.Size(86, 25);
            this.lblCodigo.TabIndex = 34;
            this.lblCodigo.Text = "Codigo :";
            // 
            // lblFechaVenta
            // 
            this.lblFechaVenta.AutoSize = true;
            this.lblFechaVenta.Location = new System.Drawing.Point(11, 79);
            this.lblFechaVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaVenta.Name = "lblFechaVenta";
            this.lblFechaVenta.Size = new System.Drawing.Size(162, 25);
            this.lblFechaVenta.TabIndex = 28;
            this.lblFechaVenta.Text = "Fecha de Venta :";
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
            this.lblEstado.Location = new System.Drawing.Point(9, 125);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(84, 25);
            this.lblEstado.TabIndex = 31;
            this.lblEstado.Text = "Estado :";
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
            this.gbDetalleMovimento.Controls.Add(this.BtnVerMultipagoPadre);
            this.gbDetalleMovimento.Controls.Add(this.DataVentaMultipago);
            this.gbDetalleMovimento.Controls.Add(this.dataLista);
            this.gbDetalleMovimento.Controls.Add(this.btncredito);
            this.gbDetalleMovimento.Controls.Add(this.BtnVentaMultipago);
            this.gbDetalleMovimento.Controls.Add(this.btnPagarMovimiento);
            this.gbDetalleMovimento.Controls.Add(this.cbxCategoria);
            this.gbDetalleMovimento.Controls.Add(this.label3);
            this.gbDetalleMovimento.Controls.Add(this.txtcuit);
            this.gbDetalleMovimento.Controls.Add(this.label2);
            this.gbDetalleMovimento.Controls.Add(this.gbxHerramientas);
            this.gbDetalleMovimento.Controls.Add(this.LblNroReferencia);
            this.gbDetalleMovimento.Controls.Add(this.lblRazonSocial);
            this.gbDetalleMovimento.Controls.Add(this.TxtNroReferencia);
            this.gbDetalleMovimento.Controls.Add(this.txtRazonSocial);
            this.gbDetalleMovimento.Controls.Add(this.lblTipo_comprobante);
            this.gbDetalleMovimento.Controls.Add(this.txtTipoComprobante);
            this.gbDetalleMovimento.Controls.Add(this.txtTotal);
            this.gbDetalleMovimento.Controls.Add(this.lblTotal);
            this.gbDetalleMovimento.Controls.Add(this.lblCodigo);
            this.gbDetalleMovimento.Controls.Add(this.lblFechaVenta);
            this.gbDetalleMovimento.Controls.Add(this.txtCodigo);
            this.gbDetalleMovimento.Controls.Add(this.txtFechaVenta);
            this.gbDetalleMovimento.Controls.Add(this.TxtFPago);
            this.gbDetalleMovimento.Controls.Add(this.label4);
            this.gbDetalleMovimento.Controls.Add(this.txtEstado);
            this.gbDetalleMovimento.Controls.Add(this.lblEstado);
            this.gbDetalleMovimento.Location = new System.Drawing.Point(5, 40);
            this.gbDetalleMovimento.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gbDetalleMovimento.Name = "gbDetalleMovimento";
            this.gbDetalleMovimento.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gbDetalleMovimento.Size = new System.Drawing.Size(1003, 678);
            this.gbDetalleMovimento.TabIndex = 42;
            this.gbDetalleMovimento.TabStop = false;
            this.gbDetalleMovimento.Text = "Detalles ";
            this.gbDetalleMovimento.Enter += new System.EventHandler(this.gbDetalleMovimento_Enter);
            // 
            // BtnVerMultipagoPadre
            // 
            this.BtnVerMultipagoPadre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnVerMultipagoPadre.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(247)))));
            this.BtnVerMultipagoPadre.ButtonImage = null;
            this.BtnVerMultipagoPadre.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.BtnVerMultipagoPadre.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.BtnVerMultipagoPadre.ButtonText = "Ver";
            this.BtnVerMultipagoPadre.CornerRadius = 5;
            this.BtnVerMultipagoPadre.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnVerMultipagoPadre.HoverBackgroundColor = System.Drawing.Color.IndianRed;
            this.BtnVerMultipagoPadre.HoverTextColor = System.Drawing.Color.Yellow;
            this.BtnVerMultipagoPadre.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.BtnVerMultipagoPadre.Location = new System.Drawing.Point(659, 159);
            this.BtnVerMultipagoPadre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnVerMultipagoPadre.Name = "BtnVerMultipagoPadre";
            this.BtnVerMultipagoPadre.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.BtnVerMultipagoPadre.SelectedTextColor = System.Drawing.Color.White;
            this.BtnVerMultipagoPadre.Size = new System.Drawing.Size(60, 33);
            this.BtnVerMultipagoPadre.SuperSelected = false;
            this.BtnVerMultipagoPadre.TabIndex = 139;
            this.BtnVerMultipagoPadre.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.BtnVerMultipagoPadre.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnVerMultipagoPadre.Visible = false;
            this.BtnVerMultipagoPadre.Click += new System.EventHandler(this.BtnVerMultipagoPadre_Click);
            // 
            // DataVentaMultipago
            // 
            this.DataVentaMultipago.AllowUserToAddRows = false;
            this.DataVentaMultipago.AllowUserToDeleteRows = false;
            this.DataVentaMultipago.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.DataVentaMultipago.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DataVentaMultipago.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataVentaMultipago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataVentaMultipago.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataVentaMultipago.BackgroundColor = System.Drawing.Color.White;
            this.DataVentaMultipago.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataVentaMultipago.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataVentaMultipago.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataVentaMultipago.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DataVentaMultipago.ColumnHeadersHeight = 38;
            this.DataVentaMultipago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.formadepago,
            this.Total});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataVentaMultipago.DefaultCellStyle = dataGridViewCellStyle9;
            this.DataVentaMultipago.EnableHeadersVisualStyles = false;
            this.DataVentaMultipago.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataVentaMultipago.Location = new System.Drawing.Point(12, 204);
            this.DataVentaMultipago.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataVentaMultipago.MultiSelect = false;
            this.DataVentaMultipago.Name = "DataVentaMultipago";
            this.DataVentaMultipago.RowHeadersVisible = false;
            this.DataVentaMultipago.RowHeadersWidth = 51;
            this.DataVentaMultipago.RowTemplate.Height = 24;
            this.DataVentaMultipago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataVentaMultipago.Size = new System.Drawing.Size(991, 361);
            this.DataVentaMultipago.StandardTab = true;
            this.DataVentaMultipago.TabIndex = 138;
            this.DataVentaMultipago.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DataVentaMultipago.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataVentaMultipago.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataVentaMultipago.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataVentaMultipago.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataVentaMultipago.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataVentaMultipago.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataVentaMultipago.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataVentaMultipago.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataVentaMultipago.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DataVentaMultipago.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataVentaMultipago.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataVentaMultipago.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataVentaMultipago.ThemeStyle.HeaderStyle.Height = 38;
            this.DataVentaMultipago.ThemeStyle.ReadOnly = false;
            this.DataVentaMultipago.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataVentaMultipago.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataVentaMultipago.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataVentaMultipago.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataVentaMultipago.ThemeStyle.RowsStyle.Height = 24;
            this.DataVentaMultipago.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataVentaMultipago.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataVentaMultipago.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.FillWeight = 61.54822F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 104;
            // 
            // formadepago
            // 
            this.formadepago.HeaderText = "Forma de pago";
            this.formadepago.MinimumWidth = 6;
            this.formadepago.Name = "formadepago";
            // 
            // Total
            // 
            this.Total.FillWeight = 61.54822F;
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            // 
            // dataLista
            // 
            this.dataLista.AllowUserToAddRows = false;
            this.dataLista.AllowUserToDeleteRows = false;
            this.dataLista.AllowUserToOrderColumns = true;
            this.dataLista.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dataLista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataLista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataLista.BackgroundColor = System.Drawing.Color.White;
            this.dataLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataLista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataLista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataLista.ColumnHeadersHeight = 38;
            this.dataLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Producto,
            this.Precio,
            this.Descuento,
            this.Cantidad,
            this.Importe});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataLista.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataLista.EnableHeadersVisualStyles = false;
            this.dataLista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataLista.Location = new System.Drawing.Point(12, 204);
            this.dataLista.MultiSelect = false;
            this.dataLista.Name = "dataLista";
            this.dataLista.RowHeadersVisible = false;
            this.dataLista.RowHeadersWidth = 51;
            this.dataLista.RowTemplate.Height = 24;
            this.dataLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataLista.Size = new System.Drawing.Size(981, 386);
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
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            // 
            // Producto
            // 
            this.Producto.FillWeight = 253.8071F;
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.MinimumWidth = 6;
            this.Descuento.Name = "Descuento";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.MinimumWidth = 6;
            this.Importe.Name = "Importe";
            // 
            // btncredito
            // 
            this.btncredito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btncredito.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(247)))));
            this.btncredito.ButtonImage = null;
            this.btncredito.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btncredito.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btncredito.ButtonText = "Nota de credito";
            this.btncredito.CornerRadius = 5;
            this.btncredito.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btncredito.HoverBackgroundColor = System.Drawing.Color.IndianRed;
            this.btncredito.HoverTextColor = System.Drawing.Color.Yellow;
            this.btncredito.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btncredito.Location = new System.Drawing.Point(274, 605);
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
            // BtnVentaMultipago
            // 
            this.BtnVentaMultipago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnVentaMultipago.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(247)))));
            this.BtnVentaMultipago.ButtonImage = null;
            this.BtnVentaMultipago.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.BtnVentaMultipago.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.BtnVentaMultipago.ButtonText = "Ver venta multipago";
            this.BtnVentaMultipago.CornerRadius = 5;
            this.BtnVentaMultipago.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnVentaMultipago.HoverBackgroundColor = System.Drawing.Color.IndianRed;
            this.BtnVentaMultipago.HoverTextColor = System.Drawing.Color.Yellow;
            this.BtnVentaMultipago.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.BtnVentaMultipago.Location = new System.Drawing.Point(775, 160);
            this.BtnVentaMultipago.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnVentaMultipago.Name = "BtnVentaMultipago";
            this.BtnVentaMultipago.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.BtnVentaMultipago.SelectedTextColor = System.Drawing.Color.White;
            this.BtnVentaMultipago.Size = new System.Drawing.Size(213, 33);
            this.BtnVentaMultipago.SuperSelected = false;
            this.BtnVentaMultipago.TabIndex = 135;
            this.BtnVentaMultipago.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.BtnVentaMultipago.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnVentaMultipago.Visible = false;
            this.BtnVentaMultipago.Click += new System.EventHandler(this.BtnVentaMultipago_Click);
            // 
            // btnPagarMovimiento
            // 
            this.btnPagarMovimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.btnPagarMovimiento.Location = new System.Drawing.Point(7, 605);
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
            this.txtcuit.Location = new System.Drawing.Point(554, 76);
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
            // LblNroReferencia
            // 
            this.LblNroReferencia.AutoSize = true;
            this.LblNroReferencia.Location = new System.Drawing.Point(396, 160);
            this.LblNroReferencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNroReferencia.Name = "LblNroReferencia";
            this.LblNroReferencia.Size = new System.Drawing.Size(152, 25);
            this.LblNroReferencia.TabIndex = 47;
            this.LblNroReferencia.Text = "Nro Referencia :";
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
            // TxtNroReferencia
            // 
            this.TxtNroReferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNroReferencia.Enabled = false;
            this.TxtNroReferencia.Location = new System.Drawing.Point(554, 160);
            this.TxtNroReferencia.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TxtNroReferencia.Name = "TxtNroReferencia";
            this.TxtNroReferencia.Size = new System.Drawing.Size(95, 30);
            this.TxtNroReferencia.TabIndex = 46;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRazonSocial.Enabled = false;
            this.txtRazonSocial.Location = new System.Drawing.Point(554, 118);
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
            this.txtTipoComprobante.Location = new System.Drawing.Point(554, 38);
            this.txtTipoComprobante.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTipoComprobante.Name = "txtTipoComprobante";
            this.txtTipoComprobante.Size = new System.Drawing.Size(156, 30);
            this.txtTipoComprobante.TabIndex = 44;
            // 
            // TxtFPago
            // 
            this.TxtFPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtFPago.Enabled = false;
            this.TxtFPago.Location = new System.Drawing.Point(177, 162);
            this.TxtFPago.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TxtFPago.Name = "TxtFPago";
            this.TxtFPago.Size = new System.Drawing.Size(209, 30);
            this.TxtFPago.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "Forma de pago :";
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
            ((System.ComponentModel.ISupportInitialize)(this.DataVentaMultipago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).EndInit();
            this.gbxHerramientas.ResumeLayout(false);
            this.panelHorizontal.ResumeLayout(false);
            this.panelHorizontal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
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
        private System.Windows.Forms.TextBox TxtFPago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblNroReferencia;
        private System.Windows.Forms.TextBox TxtNroReferencia;
        private XanderUI.XUISuperButton BtnVentaMultipago;
        private Guna.UI.WinForms.GunaDataGridView DataVentaMultipago;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn formadepago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private XanderUI.XUISuperButton BtnVerMultipagoPadre;
    }
}