namespace Capa_Presentacion
{
    partial class FrmBusquedaAvaProveedor
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.rdbCuit = new System.Windows.Forms.RadioButton();
            this.rdbNumDocum = new System.Windows.Forms.RadioButton();
            this.rdbNombre = new System.Windows.Forms.RadioButton();
            this.dataLista = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(597, 126);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(21, 22);
            this.lblTotal.TabIndex = 31;
            this.lblTotal.Text = "0";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(15, 75);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(663, 31);
            this.txtBuscar.TabIndex = 30;
            // 
            // rdbCuit
            // 
            this.rdbCuit.AutoSize = true;
            this.rdbCuit.Location = new System.Drawing.Point(387, 39);
            this.rdbCuit.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rdbCuit.Name = "rdbCuit";
            this.rdbCuit.Size = new System.Drawing.Size(65, 26);
            this.rdbCuit.TabIndex = 29;
            this.rdbCuit.Text = "Cuit";
            this.rdbCuit.UseVisualStyleBackColor = true;
            // 
            // rdbNumDocum
            // 
            this.rdbNumDocum.AutoSize = true;
            this.rdbNumDocum.Checked = true;
            this.rdbNumDocum.Location = new System.Drawing.Point(129, 39);
            this.rdbNumDocum.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rdbNumDocum.Name = "rdbNumDocum";
            this.rdbNumDocum.Size = new System.Drawing.Size(246, 26);
            this.rdbNumDocum.TabIndex = 28;
            this.rdbNumDocum.TabStop = true;
            this.rdbNumDocum.Text = "Numero de Documento";
            this.rdbNumDocum.UseVisualStyleBackColor = true;
            // 
            // rdbNombre
            // 
            this.rdbNombre.AutoSize = true;
            this.rdbNombre.Location = new System.Drawing.Point(15, 39);
            this.rdbNombre.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.rdbNombre.Name = "rdbNombre";
            this.rdbNombre.Size = new System.Drawing.Size(102, 26);
            this.rdbNombre.TabIndex = 27;
            this.rdbNombre.Text = "Nombre";
            this.rdbNombre.UseVisualStyleBackColor = true;
            // 
            // dataLista
            // 
            this.dataLista.AllowUserToAddRows = false;
            this.dataLista.AllowUserToDeleteRows = false;
            this.dataLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLista.Location = new System.Drawing.Point(15, 158);
            this.dataLista.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dataLista.Name = "dataLista";
            this.dataLista.ReadOnly = true;
            this.dataLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataLista.Size = new System.Drawing.Size(763, 163);
            this.dataLista.TabIndex = 26;
            this.dataLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLista_CellContentClick);
            this.dataLista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLista_CellDoubleClick);
            this.dataLista.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataLista_KeyDown);
            // 
            // FrmBusquedaAvaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 335);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.rdbCuit);
            this.Controls.Add(this.rdbNumDocum);
            this.Controls.Add(this.rdbNombre);
            this.Controls.Add(this.dataLista);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBusquedaAvaProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda Avanzada";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBusquedaAvaProveedor_FormClosing);
            this.Load += new System.EventHandler(this.FrmBusquedaAvaProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.RadioButton rdbCuit;
        private System.Windows.Forms.RadioButton rdbNumDocum;
        private System.Windows.Forms.RadioButton rdbNombre;
        private System.Windows.Forms.DataGridView dataLista;
    }
}