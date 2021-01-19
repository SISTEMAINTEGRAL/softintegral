namespace Capa_Presentacion
{
    partial class FrmCambiarPrecio
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblNombreProd = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtPrecioAnterior = new System.Windows.Forms.TextBox();
            this.lblPrecioAnterior = new System.Windows.Forms.Label();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.lblPrecioNuevo = new System.Windows.Forms.Label();
            this.txtUtilidad = new System.Windows.Forms.TextBox();
            this.lblUtilidad = new System.Windows.Forms.Label();
            this.cbxPrecioFinal = new System.Windows.Forms.CheckBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(15, 341);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(127, 48);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblNombreProd
            // 
            this.lblNombreProd.AutoSize = true;
            this.lblNombreProd.Location = new System.Drawing.Point(12, 42);
            this.lblNombreProd.Name = "lblNombreProd";
            this.lblNombreProd.Size = new System.Drawing.Size(174, 22);
            this.lblNombreProd.TabIndex = 1;
            this.lblNombreProd.Text = "Nombre Producto";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(206, 38);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.ReadOnly = true;
            this.txtNombreProducto.Size = new System.Drawing.Size(336, 31);
            this.txtNombreProducto.TabIndex = 4;
            // 
            // txtPrecioAnterior
            // 
            this.txtPrecioAnterior.Location = new System.Drawing.Point(206, 82);
            this.txtPrecioAnterior.Name = "txtPrecioAnterior";
            this.txtPrecioAnterior.ReadOnly = true;
            this.txtPrecioAnterior.Size = new System.Drawing.Size(184, 31);
            this.txtPrecioAnterior.TabIndex = 3;
            // 
            // lblPrecioAnterior
            // 
            this.lblPrecioAnterior.AutoSize = true;
            this.lblPrecioAnterior.Location = new System.Drawing.Point(12, 86);
            this.lblPrecioAnterior.Name = "lblPrecioAnterior";
            this.lblPrecioAnterior.Size = new System.Drawing.Size(144, 22);
            this.lblPrecioAnterior.TabIndex = 3;
            this.lblPrecioAnterior.Text = "Precio Anterior";
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPrecioCompra.Location = new System.Drawing.Point(206, 125);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(184, 31);
            this.txtPrecioCompra.TabIndex = 0;
            this.txtPrecioCompra.TextChanged += new System.EventHandler(this.txtPrecioCompra_TextChanged);
            this.txtPrecioCompra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrecioCompra_KeyDown);
            this.txtPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCompra_KeyPress);
            // 
            // lblPrecioNuevo
            // 
            this.lblPrecioNuevo.AutoSize = true;
            this.lblPrecioNuevo.Location = new System.Drawing.Point(12, 129);
            this.lblPrecioNuevo.Name = "lblPrecioNuevo";
            this.lblPrecioNuevo.Size = new System.Drawing.Size(147, 22);
            this.lblPrecioNuevo.TabIndex = 5;
            this.lblPrecioNuevo.Text = "Precio Compra";
            // 
            // txtUtilidad
            // 
            this.txtUtilidad.Location = new System.Drawing.Point(206, 170);
            this.txtUtilidad.MaxLength = 3;
            this.txtUtilidad.Name = "txtUtilidad";
            this.txtUtilidad.Size = new System.Drawing.Size(184, 31);
            this.txtUtilidad.TabIndex = 1;
            this.txtUtilidad.Text = "0";
            this.txtUtilidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUtilidad_KeyDown);
            this.txtUtilidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUtilidad_KeyPress);
            // 
            // lblUtilidad
            // 
            this.lblUtilidad.AutoSize = true;
            this.lblUtilidad.Location = new System.Drawing.Point(12, 174);
            this.lblUtilidad.Name = "lblUtilidad";
            this.lblUtilidad.Size = new System.Drawing.Size(102, 22);
            this.lblUtilidad.TabIndex = 7;
            this.lblUtilidad.Text = "Utilidad  %";
            // 
            // cbxPrecioFinal
            // 
            this.cbxPrecioFinal.AutoSize = true;
            this.cbxPrecioFinal.Location = new System.Drawing.Point(16, 220);
            this.cbxPrecioFinal.Name = "cbxPrecioFinal";
            this.cbxPrecioFinal.Size = new System.Drawing.Size(245, 26);
            this.cbxPrecioFinal.TabIndex = 8;
            this.cbxPrecioFinal.Text = "Cambiar Precio Manual";
            this.cbxPrecioFinal.UseVisualStyleBackColor = true;
            this.cbxPrecioFinal.CheckedChanged += new System.EventHandler(this.cbxPrecioFinal_CheckedChanged);
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Enabled = false;
            this.txtPrecioVenta.Location = new System.Drawing.Point(206, 261);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(184, 31);
            this.txtPrecioVenta.TabIndex = 9;
            this.txtPrecioVenta.TextChanged += new System.EventHandler(this.txtPrecioVenta_TextChanged);
            this.txtPrecioVenta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrecioVenta_KeyDown);
            this.txtPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVenta_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Precio Venta";
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // FrmCambiarPrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 403);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxPrecioFinal);
            this.Controls.Add(this.txtUtilidad);
            this.Controls.Add(this.lblUtilidad);
            this.Controls.Add(this.txtPrecioCompra);
            this.Controls.Add(this.lblPrecioNuevo);
            this.Controls.Add(this.txtPrecioAnterior);
            this.Controls.Add(this.lblPrecioAnterior);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.lblNombreProd);
            this.Controls.Add(this.btnGuardar);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCambiarPrecio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Precio";
            this.Load += new System.EventHandler(this.FrmCambiarPrecio_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCambiarPrecio_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblNombreProd;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtPrecioAnterior;
        private System.Windows.Forms.Label lblPrecioAnterior;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.Label lblPrecioNuevo;
        private System.Windows.Forms.TextBox txtUtilidad;
        private System.Windows.Forms.Label lblUtilidad;
        private System.Windows.Forms.CheckBox cbxPrecioFinal;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorIcono;
    }
}