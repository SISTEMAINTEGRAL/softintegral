namespace Capa_Presentacion
{
    partial class FrmAvanzadoArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAvanzadoArticulo));
            this.gbDetalleMovimento = new System.Windows.Forms.GroupBox();
            this.dataLista = new System.Windows.Forms.DataGridView();
            this.CHEQUEO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Btntraer = new XanderUI.XUISuperButton();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.chkDescripcion = new System.Windows.Forms.CheckBox();
            this.chkcategoria = new System.Windows.Forms.CheckBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnProducto = new System.Windows.Forms.Button();
            this.lblNomProducto = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.panelHorizontal = new System.Windows.Forms.Panel();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lblSistemaVenta = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuDeleteall = new System.Windows.Forms.ToolStripMenuItem();
            this.chkFecha = new System.Windows.Forms.CheckBox();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtbFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.gbDetalleMovimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).BeginInit();
            this.panelHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDetalleMovimento
            // 
            this.gbDetalleMovimento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDetalleMovimento.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbDetalleMovimento.Controls.Add(this.dtbFechaHasta);
            this.gbDetalleMovimento.Controls.Add(this.dtpFechaDesde);
            this.gbDetalleMovimento.Controls.Add(this.dataLista);
            this.gbDetalleMovimento.Controls.Add(this.Btntraer);
            this.gbDetalleMovimento.Controls.Add(this.txtDes);
            this.gbDetalleMovimento.Controls.Add(this.chkDescripcion);
            this.gbDetalleMovimento.Controls.Add(this.chkFecha);
            this.gbDetalleMovimento.Controls.Add(this.chkcategoria);
            this.gbDetalleMovimento.Controls.Add(this.cbCategoria);
            this.gbDetalleMovimento.Controls.Add(this.btnLimpiar);
            this.gbDetalleMovimento.Controls.Add(this.btnProducto);
            this.gbDetalleMovimento.Controls.Add(this.label1);
            this.gbDetalleMovimento.Controls.Add(this.lblNomProducto);
            this.gbDetalleMovimento.Controls.Add(this.txtProducto);
            this.gbDetalleMovimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDetalleMovimento.Location = new System.Drawing.Point(-1, 36);
            this.gbDetalleMovimento.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gbDetalleMovimento.Name = "gbDetalleMovimento";
            this.gbDetalleMovimento.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gbDetalleMovimento.Size = new System.Drawing.Size(1008, 693);
            this.gbDetalleMovimento.TabIndex = 54;
            this.gbDetalleMovimento.TabStop = false;
            this.gbDetalleMovimento.Text = "Detalles ";
            this.gbDetalleMovimento.Enter += new System.EventHandler(this.gbDetalleMovimento_Enter);
            // 
            // dataLista
            // 
            this.dataLista.AllowUserToAddRows = false;
            this.dataLista.AllowUserToDeleteRows = false;
            this.dataLista.AllowUserToOrderColumns = true;
            this.dataLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataLista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CHEQUEO});
            this.dataLista.Location = new System.Drawing.Point(10, 193);
            this.dataLista.Name = "dataLista";
            this.dataLista.ReadOnly = true;
            this.dataLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataLista.Size = new System.Drawing.Size(991, 431);
            this.dataLista.TabIndex = 114;
            this.dataLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLista_CellContentClick_1);
            this.dataLista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLista_CellDoubleClick);
            this.dataLista.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLista_RowLeave);
            this.dataLista.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataLista_KeyDown);
            this.dataLista.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataLista_MouseClick);
            // 
            // CHEQUEO
            // 
            this.CHEQUEO.HeaderText = "*";
            this.CHEQUEO.Name = "CHEQUEO";
            this.CHEQUEO.ReadOnly = true;
            this.CHEQUEO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CHEQUEO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CHEQUEO.Width = 49;
            // 
            // Btntraer
            // 
            this.Btntraer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(247)))));
            this.Btntraer.ButtonImage = null;
            this.Btntraer.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.Btntraer.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.Btntraer.ButtonText = "Trasladar";
            this.Btntraer.CornerRadius = 5;
            this.Btntraer.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.Btntraer.HoverBackgroundColor = System.Drawing.Color.IndianRed;
            this.Btntraer.HoverTextColor = System.Drawing.Color.Yellow;
            this.Btntraer.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.Btntraer.Location = new System.Drawing.Point(10, 638);
            this.Btntraer.Name = "Btntraer";
            this.Btntraer.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.Btntraer.SelectedTextColor = System.Drawing.Color.White;
            this.Btntraer.Size = new System.Drawing.Size(150, 47);
            this.Btntraer.SuperSelected = false;
            this.Btntraer.TabIndex = 113;
            this.Btntraer.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.Btntraer.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.Btntraer.Click += new System.EventHandler(this.Btntraer_Click);
            // 
            // txtDes
            // 
            this.txtDes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDes.Enabled = false;
            this.txtDes.Location = new System.Drawing.Point(536, 79);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(225, 30);
            this.txtDes.TabIndex = 58;
            this.txtDes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDes_KeyDown);
            // 
            // chkDescripcion
            // 
            this.chkDescripcion.AutoSize = true;
            this.chkDescripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkDescripcion.Location = new System.Drawing.Point(362, 84);
            this.chkDescripcion.Name = "chkDescripcion";
            this.chkDescripcion.Size = new System.Drawing.Size(164, 29);
            this.chkDescripcion.TabIndex = 57;
            this.chkDescripcion.Text = "Por descripcion";
            this.chkDescripcion.UseVisualStyleBackColor = true;
            this.chkDescripcion.CheckedChanged += new System.EventHandler(this.chkDescripcion_CheckedChanged);
            // 
            // chkcategoria
            // 
            this.chkcategoria.AutoSize = true;
            this.chkcategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkcategoria.Location = new System.Drawing.Point(15, 83);
            this.chkcategoria.Name = "chkcategoria";
            this.chkcategoria.Size = new System.Drawing.Size(145, 29);
            this.chkcategoria.TabIndex = 56;
            this.chkcategoria.Text = "Por categoria";
            this.chkcategoria.UseVisualStyleBackColor = true;
            this.chkcategoria.CheckedChanged += new System.EventHandler(this.chkcategoria_CheckedChanged);
            // 
            // cbCategoria
            // 
            this.cbCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.Enabled = false;
            this.cbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(166, 82);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(182, 33);
            this.cbCategoria.TabIndex = 55;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Image = global::Capa_Presentacion.Properties.Resources.Broom_15px;
            this.btnLimpiar.Location = new System.Drawing.Point(578, 34);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(28, 28);
            this.btnLimpiar.TabIndex = 52;
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnProducto
            // 
            this.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducto.Image = global::Capa_Presentacion.Properties.Resources.Search_15px;
            this.btnProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducto.Location = new System.Drawing.Point(544, 34);
            this.btnProducto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(26, 28);
            this.btnProducto.TabIndex = 10;
            this.btnProducto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // lblNomProducto
            // 
            this.lblNomProducto.AutoSize = true;
            this.lblNomProducto.Location = new System.Drawing.Point(13, 37);
            this.lblNomProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomProducto.Name = "lblNomProducto";
            this.lblNomProducto.Size = new System.Drawing.Size(90, 25);
            this.lblNomProducto.TabIndex = 26;
            this.lblNomProducto.Text = "Producto";
            // 
            // txtProducto
            // 
            this.txtProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProducto.Location = new System.Drawing.Point(111, 35);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(412, 30);
            this.txtProducto.TabIndex = 1;
            this.txtProducto.TextChanged += new System.EventHandler(this.txtProducto_TextChanged);
            this.txtProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProducto_KeyDown);
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
            this.panelHorizontal.Size = new System.Drawing.Size(1012, 37);
            this.panelHorizontal.TabIndex = 65;
            this.panelHorizontal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHorizontal_MouseMove);
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
            this.btnRestaurar.MouseLeave += new System.EventHandler(this.btnRestaurar_MouseLeave);
            this.btnRestaurar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnRestaurar_MouseMove);
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
            this.btnCerrar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.ErrorImage")));
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
            this.lblSistemaVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSistemaVenta.AutoSize = true;
            this.lblSistemaVenta.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistemaVenta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSistemaVenta.Location = new System.Drawing.Point(3, 6);
            this.lblSistemaVenta.Name = "lblSistemaVenta";
            this.lblSistemaVenta.Size = new System.Drawing.Size(224, 28);
            this.lblSistemaVenta.TabIndex = 3;
            this.lblSistemaVenta.Text = "PRECIOS MASIVOS";
            this.lblSistemaVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuDeleteall});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(191, 28);
            // 
            // MenuDeleteall
            // 
            this.MenuDeleteall.Name = "MenuDeleteall";
            this.MenuDeleteall.Size = new System.Drawing.Size(190, 24);
            this.MenuDeleteall.Text = "Seleccionar todo";
            this.MenuDeleteall.Visible = false;
            this.MenuDeleteall.Click += new System.EventHandler(this.MenuDeleteall_Click);
            // 
            // chkFecha
            // 
            this.chkFecha.AutoSize = true;
            this.chkFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkFecha.Location = new System.Drawing.Point(13, 134);
            this.chkFecha.Name = "chkFecha";
            this.chkFecha.Size = new System.Drawing.Size(253, 29);
            this.chkFecha.TabIndex = 56;
            this.chkFecha.Text = "Por fecha de modificacion";
            this.chkFecha.UseVisualStyleBackColor = true;
            this.chkFecha.CheckedChanged += new System.EventHandler(this.chkFecha_CheckedChanged);
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(283, 134);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaDesde.MinDate = new System.DateTime(1969, 12, 29, 0, 0, 0, 0);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(240, 30);
            this.dtpFechaDesde.TabIndex = 115;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(531, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "-";
            // 
            // dtbFechaHasta
            // 
            this.dtbFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtbFechaHasta.Location = new System.Drawing.Point(558, 134);
            this.dtbFechaHasta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtbFechaHasta.MinDate = new System.DateTime(1969, 12, 29, 0, 0, 0, 0);
            this.dtbFechaHasta.Name = "dtbFechaHasta";
            this.dtbFechaHasta.Size = new System.Drawing.Size(240, 30);
            this.dtbFechaHasta.TabIndex = 115;
            // 
            // FrmAvanzadoArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1012, 733);
            this.ControlBox = false;
            this.Controls.Add(this.panelHorizontal);
            this.Controls.Add(this.gbDetalleMovimento);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAvanzadoArticulo";
            this.Text = "Seleccion de articulos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAvanzadoArticulo_FormClosing);
            this.Load += new System.EventHandler(this.FrmAvanzadoArticulo_Load);
            this.gbDetalleMovimento.ResumeLayout(false);
            this.gbDetalleMovimento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).EndInit();
            this.panelHorizontal.ResumeLayout(false);
            this.panelHorizontal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDetalleMovimento;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Label lblNomProducto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Panel panelHorizontal;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label lblSistemaVenta;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.CheckBox chkDescripcion;
        private System.Windows.Forms.CheckBox chkcategoria;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuDeleteall;
        private XanderUI.XUISuperButton Btntraer;
        private System.Windows.Forms.DataGridView dataLista;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CHEQUEO;
        private System.Windows.Forms.CheckBox chkFecha;
        private System.Windows.Forms.DateTimePicker dtbFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label label1;
    }
}