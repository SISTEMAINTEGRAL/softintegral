namespace Capa_Presentacion
{
    partial class FrmBusquedaAvaCliente
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
            this.dataLista = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.rdbCuit = new System.Windows.Forms.RadioButton();
            this.rdbRazonSocial = new System.Windows.Forms.RadioButton();
            this.rdbCodigo = new System.Windows.Forms.RadioButton();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLista
            // 
            this.dataLista.AllowUserToAddRows = false;
            this.dataLista.AllowUserToDeleteRows = false;
            this.dataLista.AllowUserToOrderColumns = true;
            this.dataLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLista.Location = new System.Drawing.Point(15, 142);
            this.dataLista.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dataLista.Name = "dataLista";
            this.dataLista.ReadOnly = true;
            this.dataLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataLista.Size = new System.Drawing.Size(844, 239);
            this.dataLista.TabIndex = 0;
            this.dataLista.DoubleClick += new System.EventHandler(this.dataLista_DoubleClick);
            this.dataLista.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataLista_KeyDown);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(15, 66);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(759, 37);
            this.txtBuscar.TabIndex = 24;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // rdbCuit
            // 
            this.rdbCuit.AutoSize = true;
            this.rdbCuit.Location = new System.Drawing.Point(321, 30);
            this.rdbCuit.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rdbCuit.Name = "rdbCuit";
            this.rdbCuit.Size = new System.Drawing.Size(87, 34);
            this.rdbCuit.TabIndex = 23;
            this.rdbCuit.Text = "CUIT";
            this.rdbCuit.UseVisualStyleBackColor = true;
            // 
            // rdbRazonSocial
            // 
            this.rdbRazonSocial.AutoSize = true;
            this.rdbRazonSocial.Checked = true;
            this.rdbRazonSocial.Location = new System.Drawing.Point(145, 30);
            this.rdbRazonSocial.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rdbRazonSocial.Name = "rdbRazonSocial";
            this.rdbRazonSocial.Size = new System.Drawing.Size(185, 34);
            this.rdbRazonSocial.TabIndex = 22;
            this.rdbRazonSocial.TabStop = true;
            this.rdbRazonSocial.Text = "Razon Social";
            this.rdbRazonSocial.UseVisualStyleBackColor = true;
            // 
            // rdbCodigo
            // 
            this.rdbCodigo.AutoSize = true;
            this.rdbCodigo.Location = new System.Drawing.Point(15, 30);
            this.rdbCodigo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rdbCodigo.Name = "rdbCodigo";
            this.rdbCodigo.Size = new System.Drawing.Size(124, 34);
            this.rdbCodigo.TabIndex = 21;
            this.rdbCodigo.Text = "Codigo";
            this.rdbCodigo.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(673, 108);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(26, 30);
            this.lblTotal.TabIndex = 25;
            this.lblTotal.Text = "0";
            // 
            // FrmBusquedaAvaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 395);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.rdbCuit);
            this.Controls.Add(this.rdbRazonSocial);
            this.Controls.Add(this.rdbCodigo);
            this.Controls.Add(this.dataLista);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBusquedaAvaCliente";
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

        private System.Windows.Forms.DataGridView dataLista;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.RadioButton rdbCuit;
        private System.Windows.Forms.RadioButton rdbRazonSocial;
        private System.Windows.Forms.RadioButton rdbCodigo;
        private System.Windows.Forms.Label lblTotal;
    }
}