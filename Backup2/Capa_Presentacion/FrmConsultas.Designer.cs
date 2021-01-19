namespace Capa_Presentacion
{
    partial class FrmConsultas
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
            this.gbDetalleMovimento = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.rbCategoria = new System.Windows.Forms.RadioButton();
            this.rdbCodigoBarra = new System.Windows.Forms.RadioButton();
            this.rdbNombre = new System.Windows.Forms.RadioButton();
            this.dataLista = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoDeBarra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnProducto = new System.Windows.Forms.Button();
            this.lblNomProducto = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.btnCalculadora = new System.Windows.Forms.Button();
            this.grpboxConsulta = new System.Windows.Forms.GroupBox();
            this.ttMensajeAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.gbDetalleMovimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).BeginInit();
            this.grpboxConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDetalleMovimento
            // 
            this.gbDetalleMovimento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDetalleMovimento.Controls.Add(this.btnLimpiar);
            this.gbDetalleMovimento.Controls.Add(this.rbCodigo);
            this.gbDetalleMovimento.Controls.Add(this.rbCategoria);
            this.gbDetalleMovimento.Controls.Add(this.rdbCodigoBarra);
            this.gbDetalleMovimento.Controls.Add(this.rdbNombre);
            this.gbDetalleMovimento.Controls.Add(this.dataLista);
            this.gbDetalleMovimento.Controls.Add(this.btnProducto);
            this.gbDetalleMovimento.Controls.Add(this.lblNomProducto);
            this.gbDetalleMovimento.Controls.Add(this.txtProducto);
            this.gbDetalleMovimento.Location = new System.Drawing.Point(20, 31);
            this.gbDetalleMovimento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDetalleMovimento.Name = "gbDetalleMovimento";
            this.gbDetalleMovimento.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbDetalleMovimento.Size = new System.Drawing.Size(938, 547);
            this.gbDetalleMovimento.TabIndex = 40;
            this.gbDetalleMovimento.TabStop = false;
            this.gbDetalleMovimento.Text = "Detalles ";
            this.gbDetalleMovimento.Enter += new System.EventHandler(this.gbDetalleMovimento_Enter);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = global::Capa_Presentacion.Properties.Resources.Broom_15px;
            this.btnLimpiar.Location = new System.Drawing.Point(420, 65);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(21, 21);
            this.btnLimpiar.TabIndex = 51;
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Location = new System.Drawing.Point(186, 26);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(58, 17);
            this.rbCodigo.TabIndex = 50;
            this.rbCodigo.Text = "Codigo";
            this.rbCodigo.UseVisualStyleBackColor = true;
            this.rbCodigo.CheckedChanged += new System.EventHandler(this.rbCodigo_CheckedChanged);
            // 
            // rbCategoria
            // 
            this.rbCategoria.AutoSize = true;
            this.rbCategoria.Location = new System.Drawing.Point(250, 26);
            this.rbCategoria.Name = "rbCategoria";
            this.rbCategoria.Size = new System.Drawing.Size(72, 17);
            this.rbCategoria.TabIndex = 49;
            this.rbCategoria.Text = "Categoría";
            this.rbCategoria.UseVisualStyleBackColor = true;
            this.rbCategoria.CheckedChanged += new System.EventHandler(this.rbCategoria_CheckedChanged);
            // 
            // rdbCodigoBarra
            // 
            this.rdbCodigoBarra.AutoSize = true;
            this.rdbCodigoBarra.Location = new System.Drawing.Point(79, 26);
            this.rdbCodigoBarra.Name = "rdbCodigoBarra";
            this.rdbCodigoBarra.Size = new System.Drawing.Size(101, 17);
            this.rdbCodigoBarra.TabIndex = 48;
            this.rdbCodigoBarra.Text = "Codigo de Barra";
            this.rdbCodigoBarra.UseVisualStyleBackColor = true;
            this.rdbCodigoBarra.CheckedChanged += new System.EventHandler(this.rdbCodigoBarra_CheckedChanged);
            // 
            // rdbNombre
            // 
            this.rdbNombre.AutoSize = true;
            this.rdbNombre.Checked = true;
            this.rdbNombre.Location = new System.Drawing.Point(11, 26);
            this.rdbNombre.Name = "rdbNombre";
            this.rdbNombre.Size = new System.Drawing.Size(62, 17);
            this.rdbNombre.TabIndex = 47;
            this.rdbNombre.TabStop = true;
            this.rdbNombre.Text = "Nombre";
            this.rdbNombre.UseVisualStyleBackColor = true;
            this.rdbNombre.CheckedChanged += new System.EventHandler(this.rdbNombre_CheckedChanged);
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
            this.Precio,
            this.Categoria});
            this.dataLista.Location = new System.Drawing.Point(12, 157);
            this.dataLista.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataLista.MultiSelect = false;
            this.dataLista.Name = "dataLista";
            this.dataLista.ReadOnly = true;
            this.dataLista.RowHeadersWidth = 38;
            this.dataLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataLista.Size = new System.Drawing.Size(899, 364);
            this.dataLista.TabIndex = 46;
            this.dataLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLista_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // CodigoDeBarra
            // 
            this.CodigoDeBarra.HeaderText = "Codigo De Barra";
            this.CodigoDeBarra.Name = "CodigoDeBarra";
            this.CodigoDeBarra.ReadOnly = true;
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
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // btnProducto
            // 
            this.btnProducto.Image = global::Capa_Presentacion.Properties.Resources.Search_15px;
            this.btnProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducto.Location = new System.Drawing.Point(393, 65);
            this.btnProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(21, 21);
            this.btnProducto.TabIndex = 10;
            this.btnProducto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // lblNomProducto
            // 
            this.lblNomProducto.AutoSize = true;
            this.lblNomProducto.Location = new System.Drawing.Point(9, 69);
            this.lblNomProducto.Name = "lblNomProducto";
            this.lblNomProducto.Size = new System.Drawing.Size(50, 13);
            this.lblNomProducto.TabIndex = 26;
            this.lblNomProducto.Text = "Producto";
            this.lblNomProducto.Click += new System.EventHandler(this.lblNomProducto_Click);
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(84, 66);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProducto.MaxLength = 100;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(294, 20);
            this.txtProducto.TabIndex = 1;
            this.txtProducto.TextChanged += new System.EventHandler(this.txtProducto_TextChanged);
            this.txtProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProducto_KeyDown);
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.Location = new System.Drawing.Point(879, 8);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(75, 19);
            this.btnCalculadora.TabIndex = 64;
            this.btnCalculadora.Text = "Calculadora";
            this.btnCalculadora.UseVisualStyleBackColor = true;
            this.btnCalculadora.Click += new System.EventHandler(this.btnCalculadora_Click);
            // 
            // grpboxConsulta
            // 
            this.grpboxConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpboxConsulta.Controls.Add(this.gbDetalleMovimento);
            this.grpboxConsulta.Location = new System.Drawing.Point(12, 20);
            this.grpboxConsulta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpboxConsulta.Name = "grpboxConsulta";
            this.grpboxConsulta.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpboxConsulta.Size = new System.Drawing.Size(991, 600);
            this.grpboxConsulta.TabIndex = 61;
            this.grpboxConsulta.TabStop = false;
            this.grpboxConsulta.Text = "Consulta de Precio";
            this.grpboxConsulta.Enter += new System.EventHandler(this.grpboxConsulta_Enter);
            // 
            // FrmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 673);
            this.Controls.Add(this.btnCalculadora);
            this.Controls.Add(this.grpboxConsulta);
            this.KeyPreview = true;
            this.Name = "FrmConsultas";
            this.Text = "Consulta de Precio";
            this.Load += new System.EventHandler(this.FrmConsultas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmConsultas_KeyDown);
            this.gbDetalleMovimento.ResumeLayout(false);
            this.gbDetalleMovimento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).EndInit();
            this.grpboxConsulta.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDetalleMovimento;
        private System.Windows.Forms.DataGridView dataLista;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Label lblNomProducto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Button btnCalculadora;
        private System.Windows.Forms.GroupBox grpboxConsulta;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.RadioButton rbCategoria;
        private System.Windows.Forms.RadioButton rdbCodigoBarra;
        private System.Windows.Forms.RadioButton rdbNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoDeBarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ToolTip ttMensajeAyuda;
    }
}