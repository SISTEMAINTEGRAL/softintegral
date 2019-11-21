namespace Capa_Presentacion
{
    partial class FrmImpresora
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnZ = new System.Windows.Forms.Button();
            this.BtnX = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtHasta = new System.Windows.Forms.TextBox();
            this.TxtDesde = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RbtnZ = new System.Windows.Forms.RadioButton();
            this.RbtnFecha = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dtbFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnPeriodo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnZ);
            this.groupBox1.Controls.Add(this.BtnX);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cierre";
            // 
            // BtnZ
            // 
            this.BtnZ.Location = new System.Drawing.Point(174, 38);
            this.BtnZ.Name = "BtnZ";
            this.BtnZ.Size = new System.Drawing.Size(75, 23);
            this.BtnZ.TabIndex = 2;
            this.BtnZ.Text = "Z";
            this.BtnZ.UseVisualStyleBackColor = true;
            this.BtnZ.Click += new System.EventHandler(this.BtnZ_Click);
            // 
            // BtnX
            // 
            this.BtnX.Location = new System.Drawing.Point(17, 38);
            this.BtnX.Name = "BtnX";
            this.BtnX.Size = new System.Drawing.Size(75, 23);
            this.BtnX.TabIndex = 1;
            this.BtnX.Text = "X";
            this.BtnX.UseVisualStyleBackColor = true;
            this.BtnX.Click += new System.EventHandler(this.BtnX_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtHasta);
            this.groupBox2.Controls.Add(this.TxtDesde);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.RbtnZ);
            this.groupBox2.Controls.Add(this.RbtnFecha);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtbFechaHasta);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtpFechaDesde);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.BtnPeriodo);
            this.groupBox2.Location = new System.Drawing.Point(354, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(692, 186);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reportes";
            // 
            // TxtHasta
            // 
            this.TxtHasta.Location = new System.Drawing.Point(449, 82);
            this.TxtHasta.Name = "TxtHasta";
            this.TxtHasta.Size = new System.Drawing.Size(168, 22);
            this.TxtHasta.TabIndex = 63;
            // 
            // TxtDesde
            // 
            this.TxtDesde.Location = new System.Drawing.Point(202, 80);
            this.TxtDesde.Name = "TxtDesde";
            this.TxtDesde.Size = new System.Drawing.Size(166, 22);
            this.TxtDesde.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 61;
            this.label4.Text = "Hasta :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 60;
            this.label3.Text = "Desde :";
            // 
            // RbtnZ
            // 
            this.RbtnZ.AutoSize = true;
            this.RbtnZ.Location = new System.Drawing.Point(22, 75);
            this.RbtnZ.Name = "RbtnZ";
            this.RbtnZ.Size = new System.Drawing.Size(72, 21);
            this.RbtnZ.TabIndex = 59;
            this.RbtnZ.Text = "Por Z :";
            this.RbtnZ.UseVisualStyleBackColor = true;
            this.RbtnZ.CheckedChanged += new System.EventHandler(this.RbtnZ_CheckedChanged);
            // 
            // RbtnFecha
            // 
            this.RbtnFecha.AutoSize = true;
            this.RbtnFecha.Checked = true;
            this.RbtnFecha.Location = new System.Drawing.Point(22, 31);
            this.RbtnFecha.Name = "RbtnFecha";
            this.RbtnFecha.Size = new System.Drawing.Size(98, 21);
            this.RbtnFecha.TabIndex = 58;
            this.RbtnFecha.TabStop = true;
            this.RbtnFecha.Text = "Por fecha :";
            this.RbtnFecha.UseVisualStyleBackColor = true;
            this.RbtnFecha.CheckedChanged += new System.EventHandler(this.RbtnFecha_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 57;
            this.label2.Text = "Hasta :";
            // 
            // dtbFechaHasta
            // 
            this.dtbFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtbFechaHasta.Location = new System.Drawing.Point(449, 28);
            this.dtbFechaHasta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtbFechaHasta.MinDate = new System.DateTime(1969, 12, 29, 0, 0, 0, 0);
            this.dtbFechaHasta.Name = "dtbFechaHasta";
            this.dtbFechaHasta.Size = new System.Drawing.Size(168, 22);
            this.dtbFechaHasta.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 55;
            this.label1.Text = "Desde :";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(202, 28);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaDesde.MinDate = new System.DateTime(1969, 12, 29, 0, 0, 0, 0);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(168, 22);
            this.dtpFechaDesde.TabIndex = 54;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Descargar periodo ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnPeriodo
            // 
            this.BtnPeriodo.Location = new System.Drawing.Point(292, 125);
            this.BtnPeriodo.Name = "BtnPeriodo";
            this.BtnPeriodo.Size = new System.Drawing.Size(225, 32);
            this.BtnPeriodo.TabIndex = 4;
            this.BtnPeriodo.Text = "Consultar periodo";
            this.BtnPeriodo.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(209, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancelar documento abierto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmImpresora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 246);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmImpresora";
            this.Text = "FrmImpresora";
            this.Load += new System.EventHandler(this.FrmImpresora_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnZ;
        private System.Windows.Forms.Button BtnX;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnPeriodo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtbFechaHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.RadioButton RbtnFecha;
        private System.Windows.Forms.RadioButton RbtnZ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtHasta;
        private System.Windows.Forms.TextBox TxtDesde;
    }
}