namespace Capa_Presentacion
{
    partial class FrmFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFactura));
            this.grpboxCategoria = new System.Windows.Forms.GroupBox();
            this.cbxPesable = new System.Windows.Forms.CheckBox();
            this.txtCantInicial = new System.Windows.Forms.TextBox();
            this.lblCantInicial = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.txtCodigoBarra = new System.Windows.Forms.TextBox();
            this.lblCodigoBar = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombreConfig = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNomArticulo = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevoCodBar = new System.Windows.Forms.Button();
            this.grpboxCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpboxCategoria
            // 
            this.grpboxCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpboxCategoria.Controls.Add(this.cbxPesable);
            this.grpboxCategoria.Controls.Add(this.btnNuevoCodBar);
            this.grpboxCategoria.Controls.Add(this.txtCantInicial);
            this.grpboxCategoria.Controls.Add(this.lblCantInicial);
            this.grpboxCategoria.Controls.Add(this.txtPrecio);
            this.grpboxCategoria.Controls.Add(this.lblPrecio);
            this.grpboxCategoria.Controls.Add(this.lblCategoria);
            this.grpboxCategoria.Controls.Add(this.cbxCategoria);
            this.grpboxCategoria.Controls.Add(this.txtCodigoBarra);
            this.grpboxCategoria.Controls.Add(this.lblCodigoBar);
            this.grpboxCategoria.Controls.Add(this.txtDescripcion);
            this.grpboxCategoria.Controls.Add(this.txtNombreConfig);
            this.grpboxCategoria.Controls.Add(this.txtCodigo);
            this.grpboxCategoria.Controls.Add(this.lblDescripcion);
            this.grpboxCategoria.Controls.Add(this.lblNomArticulo);
            this.grpboxCategoria.Controls.Add(this.lblCodigo);
            this.grpboxCategoria.Controls.Add(this.btnCancelar);
            this.grpboxCategoria.Controls.Add(this.btnGuardar);
            this.grpboxCategoria.Location = new System.Drawing.Point(12, 12);
            this.grpboxCategoria.Name = "grpboxCategoria";
            this.grpboxCategoria.Size = new System.Drawing.Size(915, 420);
            this.grpboxCategoria.TabIndex = 1;
            this.grpboxCategoria.TabStop = false;
            this.grpboxCategoria.Text = "Factura";
            // 
            // cbxPesable
            // 
            this.cbxPesable.AutoSize = true;
            this.cbxPesable.Enabled = false;
            this.cbxPesable.Location = new System.Drawing.Point(550, 247);
            this.cbxPesable.Name = "cbxPesable";
            this.cbxPesable.Size = new System.Drawing.Size(64, 17);
            this.cbxPesable.TabIndex = 26;
            this.cbxPesable.Text = "Pesable";
            this.cbxPesable.UseVisualStyleBackColor = true;
            // 
            // txtCantInicial
            // 
            this.txtCantInicial.Enabled = false;
            this.txtCantInicial.Location = new System.Drawing.Point(670, 175);
            this.txtCantInicial.MaxLength = 50;
            this.txtCantInicial.Name = "txtCantInicial";
            this.txtCantInicial.Size = new System.Drawing.Size(168, 20);
            this.txtCantInicial.TabIndex = 24;
            // 
            // lblCantInicial
            // 
            this.lblCantInicial.AutoSize = true;
            this.lblCantInicial.Location = new System.Drawing.Point(546, 179);
            this.lblCantInicial.Name = "lblCantInicial";
            this.lblCantInicial.Size = new System.Drawing.Size(62, 13);
            this.lblCantInicial.TabIndex = 23;
            this.lblCantInicial.Text = "Cant. Inicial";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(670, 106);
            this.txtPrecio.MaxLength = 60;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(182, 20);
            this.txtPrecio.TabIndex = 22;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(545, 110);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 21;
            this.lblPrecio.Text = "Precio";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(545, 43);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 20;
            this.lblCategoria.Text = "Categoria";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.Enabled = false;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(670, 39);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(182, 21);
            this.cbxCategoria.TabIndex = 16;
            // 
            // txtCodigoBarra
            // 
            this.txtCodigoBarra.Enabled = false;
            this.txtCodigoBarra.Location = new System.Drawing.Point(194, 106);
            this.txtCodigoBarra.MaxLength = 13;
            this.txtCodigoBarra.Name = "txtCodigoBarra";
            this.txtCodigoBarra.Size = new System.Drawing.Size(236, 20);
            this.txtCodigoBarra.TabIndex = 13;
            // 
            // lblCodigoBar
            // 
            this.lblCodigoBar.AutoSize = true;
            this.lblCodigoBar.Location = new System.Drawing.Point(18, 110);
            this.lblCodigoBar.Name = "lblCodigoBar";
            this.lblCodigoBar.Size = new System.Drawing.Size(83, 13);
            this.lblCodigoBar.TabIndex = 17;
            this.lblCodigoBar.Text = "Código de Barra";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(194, 247);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(323, 60);
            this.txtDescripcion.TabIndex = 15;
            // 
            // txtNombreConfig
            // 
            this.txtNombreConfig.Enabled = false;
            this.txtNombreConfig.Location = new System.Drawing.Point(194, 175);
            this.txtNombreConfig.MaxLength = 100;
            this.txtNombreConfig.Name = "txtNombreConfig";
            this.txtNombreConfig.Size = new System.Drawing.Size(323, 20);
            this.txtNombreConfig.TabIndex = 14;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(194, 39);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(196, 20);
            this.txtCodigo.TabIndex = 13;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(18, 249);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 12;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblNomArticulo
            // 
            this.lblNomArticulo.AutoSize = true;
            this.lblNomArticulo.Location = new System.Drawing.Point(18, 179);
            this.lblNomArticulo.Name = "lblNomArticulo";
            this.lblNomArticulo.Size = new System.Drawing.Size(44, 13);
            this.lblNomArticulo.TabIndex = 11;
            this.lblNomArticulo.Text = "Nombre";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(18, 42);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 10;
            this.lblCodigo.Text = "Código";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(183, 352);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 40);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(21, 352);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 40);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevoCodBar
            // 
            this.btnNuevoCodBar.Enabled = false;
            this.btnNuevoCodBar.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoCodBar.Image")));
            this.btnNuevoCodBar.Location = new System.Drawing.Point(436, 106);
            this.btnNuevoCodBar.Name = "btnNuevoCodBar";
            this.btnNuevoCodBar.Size = new System.Drawing.Size(27, 31);
            this.btnNuevoCodBar.TabIndex = 25;
            this.btnNuevoCodBar.UseVisualStyleBackColor = true;
            // 
            // FrmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 449);
            this.Controls.Add(this.grpboxCategoria);
            this.Name = "FrmFactura";
            this.Text = "Factura";
            this.grpboxCategoria.ResumeLayout(false);
            this.grpboxCategoria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxCategoria;
        private System.Windows.Forms.CheckBox cbxPesable;
        private System.Windows.Forms.Button btnNuevoCodBar;
        private System.Windows.Forms.TextBox txtCantInicial;
        private System.Windows.Forms.Label lblCantInicial;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.TextBox txtCodigoBarra;
        private System.Windows.Forms.Label lblCodigoBar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombreConfig;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNomArticulo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
    }
}