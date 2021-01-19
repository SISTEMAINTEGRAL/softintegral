namespace Capa_Presentacion
{
    partial class FrmBusquedaAvaArticulo
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.rdbCategoria = new System.Windows.Forms.RadioButton();
            this.rdbCodigoBarra = new System.Windows.Forms.RadioButton();
            this.rdbNombre = new System.Windows.Forms.RadioButton();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnProducto = new System.Windows.Forms.Button();
            this.rdbCodigo = new System.Windows.Forms.RadioButton();
            this.dataLista = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoDeBarra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(15, 66);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(759, 31);
            this.txtBuscar.TabIndex = 24;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // rdbCategoria
            // 
            this.rdbCategoria.AutoSize = true;
            this.rdbCategoria.Location = new System.Drawing.Point(453, 30);
            this.rdbCategoria.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rdbCategoria.Name = "rdbCategoria";
            this.rdbCategoria.Size = new System.Drawing.Size(122, 26);
            this.rdbCategoria.TabIndex = 23;
            this.rdbCategoria.Text = "Categoría";
            this.rdbCategoria.UseVisualStyleBackColor = true;
            // 
            // rdbCodigoBarra
            // 
            this.rdbCodigoBarra.AutoSize = true;
            this.rdbCodigoBarra.Checked = true;
            this.rdbCodigoBarra.Location = new System.Drawing.Point(253, 30);
            this.rdbCodigoBarra.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rdbCodigoBarra.Name = "rdbCodigoBarra";
            this.rdbCodigoBarra.Size = new System.Drawing.Size(180, 26);
            this.rdbCodigoBarra.TabIndex = 22;
            this.rdbCodigoBarra.TabStop = true;
            this.rdbCodigoBarra.Text = "Codigo de Barra";
            this.rdbCodigoBarra.UseVisualStyleBackColor = true;
            // 
            // rdbNombre
            // 
            this.rdbNombre.AutoSize = true;
            this.rdbNombre.Location = new System.Drawing.Point(15, 30);
            this.rdbNombre.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rdbNombre.Name = "rdbNombre";
            this.rdbNombre.Size = new System.Drawing.Size(102, 26);
            this.rdbNombre.TabIndex = 21;
            this.rdbNombre.Text = "Nombre";
            this.rdbNombre.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(605, 107);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(21, 22);
            this.lblTotal.TabIndex = 25;
            this.lblTotal.Text = "0";
            // 
            // btnProducto
            // 
            this.btnProducto.Image = global::Capa_Presentacion.Properties.Resources.Search_15px;
            this.btnProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducto.Location = new System.Drawing.Point(784, 66);
            this.btnProducto.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(26, 28);
            this.btnProducto.TabIndex = 26;
            this.btnProducto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // rdbCodigo
            // 
            this.rdbCodigo.AutoSize = true;
            this.rdbCodigo.Location = new System.Drawing.Point(137, 30);
            this.rdbCodigo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rdbCodigo.Name = "rdbCodigo";
            this.rdbCodigo.Size = new System.Drawing.Size(96, 26);
            this.rdbCodigo.TabIndex = 27;
            this.rdbCodigo.Text = "Codigo";
            this.rdbCodigo.UseVisualStyleBackColor = true;
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
            this.Codigo,
            this.CodigoDeBarra,
            this.Producto,
            this.Categoria});
            this.dataLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataLista.Location = new System.Drawing.Point(15, 147);
            this.dataLista.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dataLista.Name = "dataLista";
            this.dataLista.ReadOnly = true;
            this.dataLista.RowHeadersWidth = 38;
            this.dataLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataLista.Size = new System.Drawing.Size(846, 283);
            this.dataLista.TabIndex = 47;
            // 
            // Codigo
            // 
            this.Codigo.FillWeight = 80F;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MaxInputLength = 100;
            this.Codigo.MinimumWidth = 50;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // CodigoDeBarra
            // 
            this.CodigoDeBarra.HeaderText = "Codigo De Barra";
            this.CodigoDeBarra.MaxInputLength = 100;
            this.CodigoDeBarra.Name = "CodigoDeBarra";
            this.CodigoDeBarra.ReadOnly = true;
            // 
            // Producto
            // 
            this.Producto.FillWeight = 150F;
            this.Producto.HeaderText = "Producto";
            this.Producto.MaxInputLength = 100;
            this.Producto.MinimumWidth = 100;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.FillWeight = 80F;
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.MaxInputLength = 100;
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // FrmBusquedaAvaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 396);
            this.Controls.Add(this.dataLista);
            this.Controls.Add(this.rdbCodigo);
            this.Controls.Add(this.btnProducto);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.rdbCategoria);
            this.Controls.Add(this.rdbCodigoBarra);
            this.Controls.Add(this.rdbNombre);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBusquedaAvaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda Avanzada";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBusquedaAvaArticulo_FormClosing);
            this.Load += new System.EventHandler(this.FrmBusquedaAvaArticulo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmBusquedaAvaArticulo_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.RadioButton rdbCategoria;
        private System.Windows.Forms.RadioButton rdbCodigoBarra;
        private System.Windows.Forms.RadioButton rdbNombre;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.RadioButton rdbCodigo;
        private System.Windows.Forms.DataGridView dataLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoDeBarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
    }
}