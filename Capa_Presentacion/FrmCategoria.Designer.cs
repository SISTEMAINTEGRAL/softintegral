namespace Capa_Presentacion
{
    partial class FrmCategoria
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
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttMensajeAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.panelHorizontal = new System.Windows.Forms.Panel();
            this.lblSistemaVentas = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lblSistemaVenta = new System.Windows.Forms.Label();
            this.xuiCustomGroupbox1 = new XanderUI.XUICustomGroupbox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoCategoria = new System.Windows.Forms.TextBox();
            this.BtnEditarCategoria = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAgregarcategoria = new System.Windows.Forms.Button();
            this.txtNombreCategoria = new System.Windows.Forms.TextBox();
            this.dataLista = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BtnEditarSubcategoria = new System.Windows.Forms.Button();
            this.BtnAgregarSubcategoria = new System.Windows.Forms.Button();
            this.txtNombreSubcategoria = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigoSubcategoria = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DGSubcategoria = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.xuiCustomGroupbox2 = new XanderUI.XUICustomGroupbox();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.panelHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.xuiCustomGroupbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGSubcategoria)).BeginInit();
            this.xuiCustomGroupbox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // ttMensajeAyuda
            // 
            this.ttMensajeAyuda.AutomaticDelay = 90;
            // 
            // panelHorizontal
            // 
            this.panelHorizontal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.panelHorizontal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHorizontal.Controls.Add(this.lblSistemaVentas);
            this.panelHorizontal.Controls.Add(this.btnCerrar);
            this.panelHorizontal.Controls.Add(this.lblSistemaVenta);
            this.panelHorizontal.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHorizontal.Location = new System.Drawing.Point(0, 0);
            this.panelHorizontal.Margin = new System.Windows.Forms.Padding(4);
            this.panelHorizontal.Name = "panelHorizontal";
            this.panelHorizontal.Size = new System.Drawing.Size(1006, 45);
            this.panelHorizontal.TabIndex = 65;
            this.panelHorizontal.DoubleClick += new System.EventHandler(this.panelHorizontal_DoubleClick);
            this.panelHorizontal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHorizontal_MouseMove);
            // 
            // lblSistemaVentas
            // 
            this.lblSistemaVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSistemaVentas.AutoSize = true;
            this.lblSistemaVentas.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistemaVentas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSistemaVentas.Location = new System.Drawing.Point(15, 6);
            this.lblSistemaVentas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSistemaVentas.Name = "lblSistemaVentas";
            this.lblSistemaVentas.Size = new System.Drawing.Size(130, 28);
            this.lblSistemaVentas.TabIndex = 7;
            this.lblSistemaVentas.Text = "Categoria";
            this.lblSistemaVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackgroundImage = global::Capa_Presentacion.Properties.Resources.Delete_20px;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCerrar.ErrorImage = null;
            this.btnCerrar.Location = new System.Drawing.Point(971, 6);
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
            this.lblSistemaVenta.Location = new System.Drawing.Point(0, 0);
            this.lblSistemaVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSistemaVenta.Name = "lblSistemaVenta";
            this.lblSistemaVenta.Size = new System.Drawing.Size(133, 28);
            this.lblSistemaVenta.TabIndex = 6;
            // 
            // xuiCustomGroupbox1
            // 
            this.xuiCustomGroupbox1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.xuiCustomGroupbox1.BorderWidth = 1;
            this.xuiCustomGroupbox1.Controls.Add(this.label2);
            this.xuiCustomGroupbox1.Controls.Add(this.txtCodigoCategoria);
            this.xuiCustomGroupbox1.Controls.Add(this.BtnEditarCategoria);
            this.xuiCustomGroupbox1.Controls.Add(this.label3);
            this.xuiCustomGroupbox1.Controls.Add(this.BtnAgregarcategoria);
            this.xuiCustomGroupbox1.Controls.Add(this.txtNombreCategoria);
            this.xuiCustomGroupbox1.Controls.Add(this.dataLista);
            this.xuiCustomGroupbox1.Location = new System.Drawing.Point(15, 60);
            this.xuiCustomGroupbox1.Name = "xuiCustomGroupbox1";
            this.xuiCustomGroupbox1.ShowText = true;
            this.xuiCustomGroupbox1.Size = new System.Drawing.Size(986, 321);
            this.xuiCustomGroupbox1.TabIndex = 66;
            this.xuiCustomGroupbox1.TabStop = false;
            this.xuiCustomGroupbox1.Text = "Categoria";
            this.xuiCustomGroupbox1.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 30);
            this.label2.TabIndex = 106;
            this.label2.Text = "Código";
            // 
            // txtCodigoCategoria
            // 
            this.txtCodigoCategoria.Location = new System.Drawing.Point(136, 43);
            this.txtCodigoCategoria.Name = "txtCodigoCategoria";
            this.txtCodigoCategoria.ReadOnly = true;
            this.txtCodigoCategoria.Size = new System.Drawing.Size(138, 37);
            this.txtCodigoCategoria.TabIndex = 107;
            // 
            // BtnEditarCategoria
            // 
            this.BtnEditarCategoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditarCategoria.Location = new System.Drawing.Point(774, 40);
            this.BtnEditarCategoria.Name = "BtnEditarCategoria";
            this.BtnEditarCategoria.Size = new System.Drawing.Size(105, 40);
            this.BtnEditarCategoria.TabIndex = 117;
            this.BtnEditarCategoria.Text = "Editar";
            this.BtnEditarCategoria.UseVisualStyleBackColor = true;
            this.BtnEditarCategoria.Click += new System.EventHandler(this.BtnEditarCategoria_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 30);
            this.label3.TabIndex = 108;
            this.label3.Text = "Nombre";
            // 
            // BtnAgregarcategoria
            // 
            this.BtnAgregarcategoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarcategoria.Location = new System.Drawing.Point(663, 40);
            this.BtnAgregarcategoria.Name = "BtnAgregarcategoria";
            this.BtnAgregarcategoria.Size = new System.Drawing.Size(105, 40);
            this.BtnAgregarcategoria.TabIndex = 116;
            this.BtnAgregarcategoria.Text = "Agregar";
            this.BtnAgregarcategoria.UseVisualStyleBackColor = true;
            this.BtnAgregarcategoria.Click += new System.EventHandler(this.BtnAgregarcategoria_Click);
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.Location = new System.Drawing.Point(406, 43);
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.Size = new System.Drawing.Size(251, 37);
            this.txtNombreCategoria.TabIndex = 109;
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
            this.Eliminar});
            this.dataLista.Location = new System.Drawing.Point(12, 95);
            this.dataLista.MultiSelect = false;
            this.dataLista.Name = "dataLista";
            this.dataLista.ReadOnly = true;
            this.dataLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataLista.Size = new System.Drawing.Size(966, 213);
            this.dataLista.TabIndex = 104;
            this.dataLista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLista_CellClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // BtnEditarSubcategoria
            // 
            this.BtnEditarSubcategoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditarSubcategoria.Location = new System.Drawing.Point(786, 36);
            this.BtnEditarSubcategoria.Name = "BtnEditarSubcategoria";
            this.BtnEditarSubcategoria.Size = new System.Drawing.Size(105, 40);
            this.BtnEditarSubcategoria.TabIndex = 119;
            this.BtnEditarSubcategoria.Text = "Editar";
            this.BtnEditarSubcategoria.UseVisualStyleBackColor = true;
            this.BtnEditarSubcategoria.Click += new System.EventHandler(this.BtnEditarSubcategoria_Click);
            // 
            // BtnAgregarSubcategoria
            // 
            this.BtnAgregarSubcategoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarSubcategoria.Location = new System.Drawing.Point(675, 36);
            this.BtnAgregarSubcategoria.Name = "BtnAgregarSubcategoria";
            this.BtnAgregarSubcategoria.Size = new System.Drawing.Size(105, 40);
            this.BtnAgregarSubcategoria.TabIndex = 118;
            this.BtnAgregarSubcategoria.Text = "Agregar";
            this.BtnAgregarSubcategoria.UseVisualStyleBackColor = true;
            this.BtnAgregarSubcategoria.Click += new System.EventHandler(this.BtnAgregarSubcategoria_Click);
            // 
            // txtNombreSubcategoria
            // 
            this.txtNombreSubcategoria.Location = new System.Drawing.Point(416, 37);
            this.txtNombreSubcategoria.Name = "txtNombreSubcategoria";
            this.txtNombreSubcategoria.Size = new System.Drawing.Size(251, 37);
            this.txtNombreSubcategoria.TabIndex = 115;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(297, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 30);
            this.label8.TabIndex = 114;
            this.label8.Text = "Nombre";
            // 
            // txtCodigoSubcategoria
            // 
            this.txtCodigoSubcategoria.Location = new System.Drawing.Point(146, 37);
            this.txtCodigoSubcategoria.Name = "txtCodigoSubcategoria";
            this.txtCodigoSubcategoria.ReadOnly = true;
            this.txtCodigoSubcategoria.Size = new System.Drawing.Size(138, 37);
            this.txtCodigoSubcategoria.TabIndex = 113;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 30);
            this.label9.TabIndex = 112;
            this.label9.Text = "Código";
            // 
            // DGSubcategoria
            // 
            this.DGSubcategoria.AllowUserToAddRows = false;
            this.DGSubcategoria.AllowUserToDeleteRows = false;
            this.DGSubcategoria.AllowUserToOrderColumns = true;
            this.DGSubcategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGSubcategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGSubcategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGSubcategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1});
            this.DGSubcategoria.Location = new System.Drawing.Point(11, 84);
            this.DGSubcategoria.MultiSelect = false;
            this.DGSubcategoria.Name = "DGSubcategoria";
            this.DGSubcategoria.ReadOnly = true;
            this.DGSubcategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGSubcategoria.Size = new System.Drawing.Size(960, 259);
            this.DGSubcategoria.TabIndex = 105;
            this.DGSubcategoria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGSubcategoria_CellClick);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Eliminar";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // xuiCustomGroupbox2
            // 
            this.xuiCustomGroupbox2.BorderColor = System.Drawing.Color.DodgerBlue;
            this.xuiCustomGroupbox2.BorderWidth = 1;
            this.xuiCustomGroupbox2.Controls.Add(this.label9);
            this.xuiCustomGroupbox2.Controls.Add(this.DGSubcategoria);
            this.xuiCustomGroupbox2.Controls.Add(this.BtnEditarSubcategoria);
            this.xuiCustomGroupbox2.Controls.Add(this.txtCodigoSubcategoria);
            this.xuiCustomGroupbox2.Controls.Add(this.BtnAgregarSubcategoria);
            this.xuiCustomGroupbox2.Controls.Add(this.label8);
            this.xuiCustomGroupbox2.Controls.Add(this.txtNombreSubcategoria);
            this.xuiCustomGroupbox2.Location = new System.Drawing.Point(15, 397);
            this.xuiCustomGroupbox2.Name = "xuiCustomGroupbox2";
            this.xuiCustomGroupbox2.ShowText = true;
            this.xuiCustomGroupbox2.Size = new System.Drawing.Size(979, 354);
            this.xuiCustomGroupbox2.TabIndex = 118;
            this.xuiCustomGroupbox2.TabStop = false;
            this.xuiCustomGroupbox2.Text = "Subcategoria";
            this.xuiCustomGroupbox2.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1006, 763);
            this.Controls.Add(this.xuiCustomGroupbox2);
            this.Controls.Add(this.xuiCustomGroupbox1);
            this.Controls.Add(this.panelHorizontal);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.FrmCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.panelHorizontal.ResumeLayout(false);
            this.panelHorizontal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.xuiCustomGroupbox1.ResumeLayout(false);
            this.xuiCustomGroupbox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGSubcategoria)).EndInit();
            this.xuiCustomGroupbox2.ResumeLayout(false);
            this.xuiCustomGroupbox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.ToolTip ttMensajeAyuda;
        private System.Windows.Forms.Panel panelHorizontal;
        private System.Windows.Forms.Label lblSistemaVentas;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label lblSistemaVenta;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView DGSubcategoria;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button BtnEditarSubcategoria;
        private System.Windows.Forms.TextBox txtCodigoSubcategoria;
        private System.Windows.Forms.Button BtnAgregarSubcategoria;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombreSubcategoria;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoCategoria;
        private System.Windows.Forms.Button BtnEditarCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnAgregarcategoria;
        private System.Windows.Forms.TextBox txtNombreCategoria;
        private System.Windows.Forms.DataGridView dataLista;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
    }
}