namespace Capa_Presentacion
{
    partial class FrmEtiquetas
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
            this.dataListaCodigoBarra = new System.Windows.Forms.DataGridView();
            this.idArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoDeBarra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnProducto = new System.Windows.Forms.Button();
            this.btnGenerarEtiqueta = new System.Windows.Forms.Button();
            this.btnLimpiarG = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxCantidad = new System.Windows.Forms.ComboBox();
            this.lbCodigoBarra = new System.Windows.Forms.Label();
            this.txtCodigoBarra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaCodigoBarra)).BeginInit();
            this.SuspendLayout();
            // 
            // dataListaCodigoBarra
            // 
            this.dataListaCodigoBarra.AllowUserToAddRows = false;
            this.dataListaCodigoBarra.AllowUserToDeleteRows = false;
            this.dataListaCodigoBarra.AllowUserToOrderColumns = true;
            this.dataListaCodigoBarra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataListaCodigoBarra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListaCodigoBarra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idArticulo,
            this.CodigoDeBarra,
            this.Nombre,
            this.Categoria});
            this.dataListaCodigoBarra.Location = new System.Drawing.Point(6, 159);
            this.dataListaCodigoBarra.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.dataListaCodigoBarra.MultiSelect = false;
            this.dataListaCodigoBarra.Name = "dataListaCodigoBarra";
            this.dataListaCodigoBarra.ReadOnly = true;
            this.dataListaCodigoBarra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListaCodigoBarra.Size = new System.Drawing.Size(1008, 487);
            this.dataListaCodigoBarra.TabIndex = 15;
            // 
            // idArticulo
            // 
            this.idArticulo.HeaderText = "idArticulo";
            this.idArticulo.Name = "idArticulo";
            this.idArticulo.ReadOnly = true;
            this.idArticulo.Width = 285;
            // 
            // CodigoDeBarra
            // 
            this.CodigoDeBarra.HeaderText = "Codigo de Barra";
            this.CodigoDeBarra.Name = "CodigoDeBarra";
            this.CodigoDeBarra.ReadOnly = true;
            this.CodigoDeBarra.Width = 285;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 285;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 285;
            // 
            // btnProducto
            // 
            this.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducto.Image = global::Capa_Presentacion.Properties.Resources.search_magnifier_interface_symbol;
            this.btnProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducto.Location = new System.Drawing.Point(468, 12);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(273, 72);
            this.btnProducto.TabIndex = 16;
            this.btnProducto.Text = "Seleccionar Producto";
            this.btnProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // btnGenerarEtiqueta
            // 
            this.btnGenerarEtiqueta.Enabled = false;
            this.btnGenerarEtiqueta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarEtiqueta.Image = global::Capa_Presentacion.Properties.Resources.printer;
            this.btnGenerarEtiqueta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarEtiqueta.Location = new System.Drawing.Point(219, 48);
            this.btnGenerarEtiqueta.Name = "btnGenerarEtiqueta";
            this.btnGenerarEtiqueta.Size = new System.Drawing.Size(243, 72);
            this.btnGenerarEtiqueta.TabIndex = 17;
            this.btnGenerarEtiqueta.Text = "Imprimir Etiquetas";
            this.btnGenerarEtiqueta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerarEtiqueta.UseVisualStyleBackColor = true;
            this.btnGenerarEtiqueta.Click += new System.EventHandler(this.btnGenerarEtiqueta_Click);
            // 
            // btnLimpiarG
            // 
            this.btnLimpiarG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarG.Image = global::Capa_Presentacion.Properties.Resources.sweep;
            this.btnLimpiarG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarG.Location = new System.Drawing.Point(747, 12);
            this.btnLimpiarG.Name = "btnLimpiarG";
            this.btnLimpiarG.Size = new System.Drawing.Size(253, 72);
            this.btnLimpiarG.TabIndex = 18;
            this.btnLimpiarG.Text = "Limpiar Grilla";
            this.btnLimpiarG.UseVisualStyleBackColor = true;
            this.btnLimpiarG.Click += new System.EventHandler(this.btnLimpiarG_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Cantidad de Etiquetas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbxCantidad
            // 
            this.cbxCantidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCantidad.Enabled = false;
            this.cbxCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxCantidad.FormattingEnabled = true;
            this.cbxCantidad.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            ""});
            this.cbxCantidad.Location = new System.Drawing.Point(219, 12);
            this.cbxCantidad.Name = "cbxCantidad";
            this.cbxCantidad.Size = new System.Drawing.Size(243, 30);
            this.cbxCantidad.TabIndex = 21;
            this.cbxCantidad.SelectedIndexChanged += new System.EventHandler(this.cbxCantidad_SelectedIndexChanged);
            // 
            // lbCodigoBarra
            // 
            this.lbCodigoBarra.AutoSize = true;
            this.lbCodigoBarra.BackColor = System.Drawing.Color.Transparent;
            this.lbCodigoBarra.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoBarra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCodigoBarra.Location = new System.Drawing.Point(607, 98);
            this.lbCodigoBarra.Name = "lbCodigoBarra";
            this.lbCodigoBarra.Size = new System.Drawing.Size(134, 23);
            this.lbCodigoBarra.TabIndex = 26;
            this.lbCodigoBarra.Text = "Codigo Barra";
            this.lbCodigoBarra.Click += new System.EventHandler(this.lbCodigoBarra_Click);
            // 
            // txtCodigoBarra
            // 
            this.txtCodigoBarra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoBarra.Location = new System.Drawing.Point(747, 95);
            this.txtCodigoBarra.Name = "txtCodigoBarra";
            this.txtCodigoBarra.ReadOnly = true;
            this.txtCodigoBarra.Size = new System.Drawing.Size(253, 31);
            this.txtCodigoBarra.TabIndex = 25;
            this.txtCodigoBarra.TextChanged += new System.EventHandler(this.txtCodigoBarra_TextChanged);
            // 
            // FrmEtiquetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Capa_Presentacion.Properties.Resources.fondo1;
            this.ClientSize = new System.Drawing.Size(1020, 741);
            this.Controls.Add(this.lbCodigoBarra);
            this.Controls.Add(this.txtCodigoBarra);
            this.Controls.Add(this.cbxCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpiarG);
            this.Controls.Add(this.btnGenerarEtiqueta);
            this.Controls.Add(this.btnProducto);
            this.Controls.Add(this.dataListaCodigoBarra);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEtiquetas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Etiquetas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataListaCodigoBarra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataListaCodigoBarra;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Button btnGenerarEtiqueta;
        private System.Windows.Forms.Button btnLimpiarG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCantidad;
        private System.Windows.Forms.Label lbCodigoBarra;
        private System.Windows.Forms.TextBox txtCodigoBarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoDeBarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;

    }
}