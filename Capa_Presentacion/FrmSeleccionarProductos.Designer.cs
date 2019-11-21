namespace Capa_Presentacion
{
    partial class FrmSeleccionarProductos
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
            this.Seleccionados = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rdbNombre = new System.Windows.Forms.RadioButton();
            this.rdbCodigoBarra = new System.Windows.Forms.RadioButton();
            this.btnAgregarAlaLista = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.chkSeleccionarTodo = new System.Windows.Forms.CheckBox();
            this.rdbCategoria = new System.Windows.Forms.RadioButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
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
            this.dataLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataLista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionados});
            this.dataLista.Location = new System.Drawing.Point(23, 141);
            this.dataLista.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dataLista.MultiSelect = false;
            this.dataLista.Name = "dataLista";
            this.dataLista.ReadOnly = true;
            this.dataLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataLista.Size = new System.Drawing.Size(833, 311);
            this.dataLista.TabIndex = 13;
            this.dataLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLista_CellContentClick);
            // 
            // Seleccionados
            // 
            this.Seleccionados.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Seleccionados.HeaderText = "Seleccionados";
            this.Seleccionados.Name = "Seleccionados";
            this.Seleccionados.ReadOnly = true;
            this.Seleccionados.Width = 148;
            // 
            // rdbNombre
            // 
            this.rdbNombre.AutoSize = true;
            this.rdbNombre.Checked = true;
            this.rdbNombre.Location = new System.Drawing.Point(440, 31);
            this.rdbNombre.Name = "rdbNombre";
            this.rdbNombre.Size = new System.Drawing.Size(102, 26);
            this.rdbNombre.TabIndex = 14;
            this.rdbNombre.TabStop = true;
            this.rdbNombre.Text = "Nombre";
            this.rdbNombre.UseVisualStyleBackColor = true;
            // 
            // rdbCodigoBarra
            // 
            this.rdbCodigoBarra.AutoSize = true;
            this.rdbCodigoBarra.Location = new System.Drawing.Point(548, 31);
            this.rdbCodigoBarra.Name = "rdbCodigoBarra";
            this.rdbCodigoBarra.Size = new System.Drawing.Size(180, 26);
            this.rdbCodigoBarra.TabIndex = 15;
            this.rdbCodigoBarra.Text = "Codigo de Barra";
            this.rdbCodigoBarra.UseVisualStyleBackColor = true;
            // 
            // btnAgregarAlaLista
            // 
            this.btnAgregarAlaLista.Enabled = false;
            this.btnAgregarAlaLista.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAlaLista.Location = new System.Drawing.Point(24, 29);
            this.btnAgregarAlaLista.Name = "btnAgregarAlaLista";
            this.btnAgregarAlaLista.Size = new System.Drawing.Size(157, 61);
            this.btnAgregarAlaLista.TabIndex = 16;
            this.btnAgregarAlaLista.Text = "Agregar a Lista";
            this.btnAgregarAlaLista.UseVisualStyleBackColor = true;
            this.btnAgregarAlaLista.Click += new System.EventHandler(this.btnAgregarAlaLista_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotal.Location = new System.Drawing.Point(655, 105);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(21, 23);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "0";
            // 
            // chkSeleccionarTodo
            // 
            this.chkSeleccionarTodo.AutoSize = true;
            this.chkSeleccionarTodo.BackColor = System.Drawing.Color.Transparent;
            this.chkSeleccionarTodo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSeleccionarTodo.ForeColor = System.Drawing.Color.Transparent;
            this.chkSeleccionarTodo.Location = new System.Drawing.Point(24, 102);
            this.chkSeleccionarTodo.Name = "chkSeleccionarTodo";
            this.chkSeleccionarTodo.Size = new System.Drawing.Size(197, 27);
            this.chkSeleccionarTodo.TabIndex = 18;
            this.chkSeleccionarTodo.Text = "Seleccionar Todos";
            this.chkSeleccionarTodo.UseVisualStyleBackColor = false;
            this.chkSeleccionarTodo.CheckedChanged += new System.EventHandler(this.chkSeleccionarTodo_CheckedChanged);
            // 
            // rdbCategoria
            // 
            this.rdbCategoria.AutoSize = true;
            this.rdbCategoria.Location = new System.Drawing.Point(734, 31);
            this.rdbCategoria.Name = "rdbCategoria";
            this.rdbCategoria.Size = new System.Drawing.Size(122, 26);
            this.rdbCategoria.TabIndex = 19;
            this.rdbCategoria.Text = "Categoría";
            this.rdbCategoria.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(440, 64);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(416, 31);
            this.txtBuscar.TabIndex = 20;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // FrmSeleccionarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Capa_Presentacion.Properties.Resources.fondo1;
            this.ClientSize = new System.Drawing.Size(871, 513);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.rdbCategoria);
            this.Controls.Add(this.chkSeleccionarTodo);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnAgregarAlaLista);
            this.Controls.Add(this.rdbCodigoBarra);
            this.Controls.Add(this.rdbNombre);
            this.Controls.Add(this.dataLista);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FrmSeleccionarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etiqueta Personalizada";
            this.Load += new System.EventHandler(this.FrmEtiquetaPersonalizada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataLista;
        private System.Windows.Forms.RadioButton rdbNombre;
        private System.Windows.Forms.RadioButton rdbCodigoBarra;
        private System.Windows.Forms.Button btnAgregarAlaLista;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionados;
        private System.Windows.Forms.CheckBox chkSeleccionarTodo;
        private System.Windows.Forms.RadioButton rdbCategoria;
        private System.Windows.Forms.TextBox txtBuscar;

    }
}