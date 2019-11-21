namespace Capa_Presentacion
{
    partial class FrmPreciosmasivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPreciosmasivos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHorizontal = new System.Windows.Forms.Panel();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lblSistemaVenta = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnCambiar = new System.Windows.Forms.Button();
            this.btnLimpiarG = new System.Windows.Forms.Button();
            this.BtnRefrescar = new System.Windows.Forms.Button();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbcampoamodificar = new System.Windows.Forms.ComboBox();
            this.btnCliente = new System.Windows.Forms.Button();
            this.DGVenta = new System.Windows.Forms.DataGridView();
            this.menucodarticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menunombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menudescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menupreciocompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menutilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuflete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuprecioventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Menudelete = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtcambioDv = new System.Windows.Forms.TextBox();
            this.panelHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVenta)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.panelHorizontal.Size = new System.Drawing.Size(1205, 45);
            this.panelHorizontal.TabIndex = 65;
            this.panelHorizontal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHorizontal_MouseMove);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.BackgroundImage")));
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMaximizar.Location = new System.Drawing.Point(1125, 6);
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
            this.btnRestaurar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.BackgroundImage")));
            this.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRestaurar.Location = new System.Drawing.Point(1125, 6);
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
            this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimizar.Location = new System.Drawing.Point(1081, 6);
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
            this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCerrar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.ErrorImage")));
            this.btnCerrar.Location = new System.Drawing.Point(1169, 6);
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
            this.lblSistemaVenta.Location = new System.Drawing.Point(4, 6);
            this.lblSistemaVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSistemaVenta.Name = "lblSistemaVenta";
            this.lblSistemaVenta.Size = new System.Drawing.Size(224, 28);
            this.lblSistemaVenta.TabIndex = 3;
            this.lblSistemaVenta.Text = "PRECIOS MASIVOS";
            this.lblSistemaVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.BtnCambiar);
            this.groupBox1.Controls.Add(this.btnLimpiarG);
            this.groupBox1.Controls.Add(this.BtnRefrescar);
            this.groupBox1.Controls.Add(this.btnAplicar);
            this.groupBox1.Controls.Add(this.txtPorcentaje);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbcampoamodificar);
            this.groupBox1.Controls.Add(this.btnCliente);
            this.groupBox1.Location = new System.Drawing.Point(0, 610);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1200, 153);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Precios";
            // 
            // BtnCambiar
            // 
            this.BtnCambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCambiar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCambiar.Location = new System.Drawing.Point(681, 11);
            this.BtnCambiar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCambiar.Name = "BtnCambiar";
            this.BtnCambiar.Size = new System.Drawing.Size(124, 43);
            this.BtnCambiar.TabIndex = 70;
            this.BtnCambiar.Text = "Cambiar";
            this.BtnCambiar.UseVisualStyleBackColor = true;
            this.BtnCambiar.Click += new System.EventHandler(this.BtnCambiar_Click);
            // 
            // btnLimpiarG
            // 
            this.btnLimpiarG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarG.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarG.Image")));
            this.btnLimpiarG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarG.Location = new System.Drawing.Point(131, 34);
            this.btnLimpiarG.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiarG.Name = "btnLimpiarG";
            this.btnLimpiarG.Size = new System.Drawing.Size(111, 84);
            this.btnLimpiarG.TabIndex = 69;
            this.btnLimpiarG.UseVisualStyleBackColor = true;
            this.btnLimpiarG.Click += new System.EventHandler(this.btnLimpiarG_Click);
            // 
            // BtnRefrescar
            // 
            this.BtnRefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefrescar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefrescar.Location = new System.Drawing.Point(681, 62);
            this.BtnRefrescar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRefrescar.Name = "BtnRefrescar";
            this.BtnRefrescar.Size = new System.Drawing.Size(124, 43);
            this.BtnRefrescar.TabIndex = 68;
            this.BtnRefrescar.Text = "Refrescar";
            this.BtnRefrescar.UseVisualStyleBackColor = true;
            this.BtnRefrescar.Click += new System.EventHandler(this.BtnRefrescar_Click);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicar.Location = new System.Drawing.Point(947, 78);
            this.btnAplicar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(243, 68);
            this.btnAplicar.TabIndex = 63;
            this.btnAplicar.Text = "Aplicar cambios";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPorcentaje.Location = new System.Drawing.Point(399, 66);
            this.txtPorcentaje.Margin = new System.Windows.Forms.Padding(4);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(242, 22);
            this.txtPorcentaje.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 61;
            this.label1.Text = "Porcentaje % :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 60;
            this.label3.Text = "Campo a modificar :";
            // 
            // cbcampoamodificar
            // 
            this.cbcampoamodificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbcampoamodificar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcampoamodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbcampoamodificar.FormattingEnabled = true;
            this.cbcampoamodificar.Items.AddRange(new object[] {
            "Precio_compra",
            "Utilidad",
            "Precio_venta",
            "Flete"});
            this.cbcampoamodificar.Location = new System.Drawing.Point(399, 23);
            this.cbcampoamodificar.Margin = new System.Windows.Forms.Padding(4);
            this.cbcampoamodificar.Name = "cbcampoamodificar";
            this.cbcampoamodificar.Size = new System.Drawing.Size(241, 24);
            this.cbcampoamodificar.TabIndex = 59;
            // 
            // btnCliente
            // 
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(9, 34);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(112, 84);
            this.btnCliente.TabIndex = 58;
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
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
            this.DGVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
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
            this.menucodarticulo,
            this.menunombre,
            this.menudescripcion,
            this.menupreciocompra,
            this.menutilidad,
            this.menuflete,
            this.menuprecioventa});
            this.DGVenta.EnableHeadersVisualStyles = false;
            this.DGVenta.Location = new System.Drawing.Point(0, 50);
            this.DGVenta.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            this.DGVenta.MultiSelect = false;
            this.DGVenta.Name = "DGVenta";
            this.DGVenta.RowHeadersWidth = 38;
            this.DGVenta.Size = new System.Drawing.Size(1200, 559);
            this.DGVenta.TabIndex = 67;
            this.DGVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVenta_CellContentClick);
            this.DGVenta.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVenta_CellContentDoubleClick);
            this.DGVenta.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVenta_CellEndEdit);
            this.DGVenta.SelectionChanged += new System.EventHandler(this.DGVenta_SelectionChanged);
            this.DGVenta.Click += new System.EventHandler(this.DGVenta_Click);
            this.DGVenta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DGVenta_MouseClick);
            // 
            // menucodarticulo
            // 
            this.menucodarticulo.HeaderText = "Codigo";
            this.menucodarticulo.Name = "menucodarticulo";
            // 
            // menunombre
            // 
            this.menunombre.HeaderText = "Nombre";
            this.menunombre.Name = "menunombre";
            // 
            // menudescripcion
            // 
            this.menudescripcion.HeaderText = "Descripcion";
            this.menudescripcion.Name = "menudescripcion";
            // 
            // menupreciocompra
            // 
            this.menupreciocompra.HeaderText = "Preciocompra";
            this.menupreciocompra.Name = "menupreciocompra";
            // 
            // menutilidad
            // 
            this.menutilidad.HeaderText = "Utilidad";
            this.menutilidad.Name = "menutilidad";
            // 
            // menuflete
            // 
            this.menuflete.HeaderText = "Flete";
            this.menuflete.Name = "menuflete";
            // 
            // menuprecioventa
            // 
            this.menuprecioventa.HeaderText = "Precioventa";
            this.menuprecioventa.Name = "menuprecioventa";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menudelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(158, 28);
            // 
            // Menudelete
            // 
            this.Menudelete.Name = "Menudelete";
            this.Menudelete.Size = new System.Drawing.Size(157, 24);
            this.Menudelete.Text = "Eliminar fila";
            this.Menudelete.Click += new System.EventHandler(this.Menudelete_Click);
            // 
            // TxtcambioDv
            // 
            this.TxtcambioDv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtcambioDv.Location = new System.Drawing.Point(528, 140);
            this.TxtcambioDv.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            this.TxtcambioDv.MaxLength = 10;
            this.TxtcambioDv.Name = "TxtcambioDv";
            this.TxtcambioDv.Size = new System.Drawing.Size(179, 22);
            this.TxtcambioDv.TabIndex = 71;
            this.TxtcambioDv.Text = "0";
            this.TxtcambioDv.Visible = false;
            this.TxtcambioDv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtcambioDv_KeyDown);
            this.TxtcambioDv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtcambioDv_KeyPress);
            this.TxtcambioDv.Leave += new System.EventHandler(this.TxtcambioDv_Leave);
            // 
            // FrmPreciosmasivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 778);
            this.ControlBox = false;
            this.Controls.Add(this.TxtcambioDv);
            this.Controls.Add(this.DGVenta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelHorizontal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPreciosmasivos";
            this.Text = "FrmPreciosmasivos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPreciosmasivos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPreciosmasivos_KeyDown);
            this.panelHorizontal.ResumeLayout(false);
            this.panelHorizontal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVenta)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHorizontal;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label lblSistemaVenta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGVenta;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn menucodarticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn menunombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn menudescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn menupreciocompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn menutilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuflete;
        private System.Windows.Forms.DataGridViewTextBoxColumn menuprecioventa;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menudelete;
        private System.Windows.Forms.ComboBox cbcampoamodificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPorcentaje;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button BtnRefrescar;
        private System.Windows.Forms.Button btnLimpiarG;
        public System.Windows.Forms.TextBox TxtcambioDv;
        private System.Windows.Forms.Button BtnCambiar;
    }
}