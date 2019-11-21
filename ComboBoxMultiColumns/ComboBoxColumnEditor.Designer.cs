namespace ComboBoxMultiColumns
{
    partial class ComboBoxColumnEditor
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.bAgregar = new System.Windows.Forms.Button();
            this.bRemover = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bBajar = new System.Windows.Forms.Button();
            this.bSubir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(14, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(260, 274);
            this.listBox1.TabIndex = 0;
            this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid1.CommandsVisibleIfAvailable = false;
            this.propertyGrid1.HelpVisible = false;
            this.propertyGrid1.Location = new System.Drawing.Point(310, 13);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(275, 314);
            this.propertyGrid1.TabIndex = 5;
            this.propertyGrid1.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGrid1_PropertyValueChanged);
            // 
            // bAgregar
            // 
            this.bAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bAgregar.Location = new System.Drawing.Point(31, 294);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(111, 33);
            this.bAgregar.TabIndex = 1;
            this.bAgregar.Text = "Add";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // bRemover
            // 
            this.bRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bRemover.Location = new System.Drawing.Point(149, 294);
            this.bRemover.Name = "bRemover";
            this.bRemover.Size = new System.Drawing.Size(111, 33);
            this.bRemover.TabIndex = 2;
            this.bRemover.Text = "Remove";
            this.bRemover.UseVisualStyleBackColor = true;
            this.bRemover.Click += new System.EventHandler(this.bRemover_Click);
            // 
            // bAceptar
            // 
            this.bAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bAceptar.Location = new System.Drawing.Point(417, 334);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(80, 31);
            this.bAceptar.TabIndex = 6;
            this.bAceptar.Text = "Ok";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancelar.Location = new System.Drawing.Point(504, 334);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(80, 31);
            this.bCancelar.TabIndex = 7;
            this.bCancelar.Text = "Cancel";
            this.bCancelar.UseVisualStyleBackColor = true;
            // 
            // bBajar
            // 
            this.bBajar.Image = global::ComboBoxMultiColumns.Properties.Resources.Down;
            this.bBajar.Location = new System.Drawing.Point(280, 43);
            this.bBajar.Name = "bBajar";
            this.bBajar.Size = new System.Drawing.Size(24, 24);
            this.bBajar.TabIndex = 4;
            this.bBajar.UseVisualStyleBackColor = true;
            this.bBajar.Click += new System.EventHandler(this.bBajar_Click);
            // 
            // bSubir
            // 
            this.bSubir.Image = global::ComboBoxMultiColumns.Properties.Resources.Up;
            this.bSubir.Location = new System.Drawing.Point(280, 13);
            this.bSubir.Name = "bSubir";
            this.bSubir.Size = new System.Drawing.Size(24, 24);
            this.bSubir.TabIndex = 3;
            this.bSubir.UseVisualStyleBackColor = true;
            this.bSubir.Click += new System.EventHandler(this.bSubir_Click);
            // 
            // ComboBoxColumnEditor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.bCancelar;
            this.ClientSize = new System.Drawing.Size(599, 375);
            this.Controls.Add(this.bBajar);
            this.Controls.Add(this.bSubir);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.bRemover);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ComboBoxColumnEditor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Columns";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.Button bRemover;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bSubir;
        private System.Windows.Forms.Button bBajar;
    }
}