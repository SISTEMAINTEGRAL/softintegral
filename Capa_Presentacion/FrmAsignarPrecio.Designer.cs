namespace Capa_Presentacion
{
    partial class FrmAsignarPrecio
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
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblNombreProd = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtKgReal = new System.Windows.Forms.TextBox();
            this.lblKg = new System.Windows.Forms.Label();
            this.txtPrecioxKg = new System.Windows.Forms.TextBox();
            this.lblPrecioXKg = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnProducto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(193, 32);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(433, 22);
            this.txtNombreProducto.TabIndex = 1;
            this.txtNombreProducto.TextChanged += new System.EventHandler(this.txtNombreProducto_TextChanged);
            this.txtNombreProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombreProducto_KeyDown);
            this.txtNombreProducto.Leave += new System.EventHandler(this.txtNombreProducto_Leave);
            // 
            // lblNombreProd
            // 
            this.lblNombreProd.AutoSize = true;
            this.lblNombreProd.Location = new System.Drawing.Point(45, 36);
            this.lblNombreProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreProd.Name = "lblNombreProd";
            this.lblNombreProd.Size = new System.Drawing.Size(114, 16);
            this.lblNombreProd.TabIndex = 13;
            this.lblNombreProd.Text = "Nombre Producto";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGuardar.Location = new System.Drawing.Point(0, 218);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(669, 59);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(112, 135);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(47, 16);
            this.lblPrecio.TabIndex = 22;
            this.lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(193, 131);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.MaxLength = 20;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(244, 22);
            this.txtPrecio.TabIndex = 3;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            this.txtPrecio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrecio_KeyDown);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            this.txtPrecio.Leave += new System.EventHandler(this.txtPrecio_Leave);
            // 
            // txtKgReal
            // 
            this.txtKgReal.Location = new System.Drawing.Point(193, 164);
            this.txtKgReal.Margin = new System.Windows.Forms.Padding(4);
            this.txtKgReal.MaxLength = 25;
            this.txtKgReal.Name = "txtKgReal";
            this.txtKgReal.ReadOnly = true;
            this.txtKgReal.Size = new System.Drawing.Size(244, 22);
            this.txtKgReal.TabIndex = 23;
            // 
            // lblKg
            // 
            this.lblKg.AutoSize = true;
            this.lblKg.Location = new System.Drawing.Point(103, 168);
            this.lblKg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKg.Name = "lblKg";
            this.lblKg.Size = new System.Drawing.Size(56, 16);
            this.lblKg.TabIndex = 24;
            this.lblKg.Text = "Kg Real";
            // 
            // txtPrecioxKg
            // 
            this.txtPrecioxKg.Enabled = false;
            this.txtPrecioxKg.Location = new System.Drawing.Point(193, 98);
            this.txtPrecioxKg.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioxKg.MaxLength = 25;
            this.txtPrecioxKg.Name = "txtPrecioxKg";
            this.txtPrecioxKg.ReadOnly = true;
            this.txtPrecioxKg.Size = new System.Drawing.Size(244, 22);
            this.txtPrecioxKg.TabIndex = 25;
            // 
            // lblPrecioXKg
            // 
            this.lblPrecioXKg.AutoSize = true;
            this.lblPrecioXKg.Location = new System.Drawing.Point(84, 102);
            this.lblPrecioXKg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioXKg.Name = "lblPrecioXKg";
            this.lblPrecioXKg.Size = new System.Drawing.Size(75, 16);
            this.lblPrecioXKg.TabIndex = 26;
            this.lblPrecioXKg.Text = "Precio x Kg";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(193, 65);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.MaxLength = 20;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(244, 22);
            this.txtCodigo.TabIndex = 27;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(107, 68);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(52, 16);
            this.lblCodigo.TabIndex = 28;
            this.lblCodigo.Text = "Codigo";
            // 
            // btnProducto
            // 
            this.btnProducto.Image = global::Capa_Presentacion.Properties.Resources.Search_15px;
            this.btnProducto.Location = new System.Drawing.Point(634, 29);
            this.btnProducto.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(26, 28);
            this.btnProducto.TabIndex = 2;
            this.btnProducto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // FrmAsignarPrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(669, 277);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnProducto);
            this.Controls.Add(this.txtPrecioxKg);
            this.Controls.Add(this.lblPrecioXKg);
            this.Controls.Add(this.txtKgReal);
            this.Controls.Add(this.lblKg);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.lblNombreProd);
            this.Controls.Add(this.btnGuardar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAsignarPrecio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignar Precio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAsignarPrecio_FormClosing);
            this.Load += new System.EventHandler(this.FrmAsignarPrecio_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmAsignarPrecio_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblNombreProd;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtKgReal;
        private System.Windows.Forms.Label lblKg;
        private System.Windows.Forms.TextBox txtPrecioxKg;
        private System.Windows.Forms.Label lblPrecioXKg;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
    }
}