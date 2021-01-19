namespace Capa_Presentacion
{
    partial class FrmCambiarPrecioSel
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
            this.dgvProductosSeleccionados = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Utilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtUtilidad = new System.Windows.Forms.TextBox();
            this.lblUtilidad = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxListaDeProducto = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosSeleccionados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.gbxListaDeProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductosSeleccionados
            // 
            this.dgvProductosSeleccionados.AllowUserToAddRows = false;
            this.dgvProductosSeleccionados.AllowUserToDeleteRows = false;
            this.dgvProductosSeleccionados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductosSeleccionados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductosSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductosSeleccionados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Producto,
            this.Utilidad,
            this.PrecioCompra,
            this.PrecioVenta});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductosSeleccionados.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductosSeleccionados.Location = new System.Drawing.Point(31, 51);
            this.dgvProductosSeleccionados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvProductosSeleccionados.MultiSelect = false;
            this.dgvProductosSeleccionados.Name = "dgvProductosSeleccionados";
            this.dgvProductosSeleccionados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductosSeleccionados.Size = new System.Drawing.Size(740, 228);
            this.dgvProductosSeleccionados.TabIndex = 0;
            this.dgvProductosSeleccionados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductosSeleccionados_CellContentClick);
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
            // Utilidad
            // 
            this.Utilidad.HeaderText = "Utilidad";
            this.Utilidad.Name = "Utilidad";
            this.Utilidad.ReadOnly = true;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "PrecioCompra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "PrecioVenta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            // 
            // txtUtilidad
            // 
            this.txtUtilidad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtUtilidad.Location = new System.Drawing.Point(152, 403);
            this.txtUtilidad.Margin = new System.Windows.Forms.Padding(5);
            this.txtUtilidad.MaxLength = 4;
            this.txtUtilidad.Name = "txtUtilidad";
            this.txtUtilidad.Size = new System.Drawing.Size(154, 26);
            this.txtUtilidad.TabIndex = 24;
            this.txtUtilidad.Text = "0";
            this.txtUtilidad.TextChanged += new System.EventHandler(this.txtUtilidad_TextChanged);
            this.txtUtilidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUtilidad_KeyDown);
            this.txtUtilidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUtilidad_KeyPress);
            this.txtUtilidad.Leave += new System.EventHandler(this.txtUtilidad_Leave);
            // 
            // lblUtilidad
            // 
            this.lblUtilidad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblUtilidad.AutoSize = true;
            this.lblUtilidad.Location = new System.Drawing.Point(42, 406);
            this.lblUtilidad.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblUtilidad.Name = "lblUtilidad";
            this.lblUtilidad.Size = new System.Drawing.Size(84, 20);
            this.lblUtilidad.TabIndex = 30;
            this.lblUtilidad.Text = "Utilidad  %";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGuardar.Location = new System.Drawing.Point(332, 398);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(109, 36);
            this.btnGuardar.TabIndex = 26;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // gbxListaDeProducto
            // 
            this.gbxListaDeProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxListaDeProducto.Controls.Add(this.dgvProductosSeleccionados);
            this.gbxListaDeProducto.Location = new System.Drawing.Point(26, 40);
            this.gbxListaDeProducto.Name = "gbxListaDeProducto";
            this.gbxListaDeProducto.Size = new System.Drawing.Size(800, 320);
            this.gbxListaDeProducto.TabIndex = 31;
            this.gbxListaDeProducto.TabStop = false;
            this.gbxListaDeProducto.Text = "Productos Seleccionados";
            // 
            // FrmCambiarPrecioSel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 473);
            this.Controls.Add(this.gbxListaDeProducto);
            this.Controls.Add(this.txtUtilidad);
            this.Controls.Add(this.lblUtilidad);
            this.Controls.Add(this.btnGuardar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCambiarPrecioSel";
            this.Text = "Cambiar Precio X Productos";
            this.Load += new System.EventHandler(this.FrmCambiarPrecioSel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosSeleccionados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.gbxListaDeProducto.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductosSeleccionados;
        private System.Windows.Forms.TextBox txtUtilidad;
        private System.Windows.Forms.Label lblUtilidad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.GroupBox gbxListaDeProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Utilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
    }
}