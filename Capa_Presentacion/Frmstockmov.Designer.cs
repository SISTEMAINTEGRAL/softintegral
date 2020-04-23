namespace Capa_Presentacion
{
    partial class Frmstockmov
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.xuiFormDesign1 = new XanderUI.XUIFormDesign();
            this.xuiFlatTab1 = new XanderUI.XUIFlatTab();
            this.TabLista = new System.Windows.Forms.TabPage();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.DTStock = new Guna.UI.WinForms.GunaDataGridView();
            this.BtnBuscar = new Guna.UI.WinForms.GunaAdvenceButton();
            this.TPfin = new Guna.UI.WinForms.GunaDateTimePicker();
            this.TPinicio = new Guna.UI.WinForms.GunaDateTimePicker();
            this.TabVenta = new System.Windows.Forms.TabPage();
            this.gunaRadioButton1 = new Guna.UI.WinForms.GunaRadioButton();
            this.xuiFormDesign1.WorkingArea.SuspendLayout();
            this.xuiFormDesign1.SuspendLayout();
            this.xuiFlatTab1.SuspendLayout();
            this.TabLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTStock)).BeginInit();
            this.TabVenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // xuiFormDesign1
            // 
            this.xuiFormDesign1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.xuiFormDesign1.BackColor = System.Drawing.Color.White;
            this.xuiFormDesign1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.xuiFormDesign1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFormDesign1.ExitApplication = true;
            this.xuiFormDesign1.FormStyle = XanderUI.XUIFormDesign.Style.Material;
            this.xuiFormDesign1.Location = new System.Drawing.Point(0, 0);
            this.xuiFormDesign1.MaterialBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(170)))));
            this.xuiFormDesign1.MaterialForeColor = System.Drawing.Color.White;
            this.xuiFormDesign1.Name = "xuiFormDesign1";
            this.xuiFormDesign1.ShowMaximize = true;
            this.xuiFormDesign1.ShowMinimize = true;
            this.xuiFormDesign1.Size = new System.Drawing.Size(1242, 624);
            this.xuiFormDesign1.TabIndex = 0;
            this.xuiFormDesign1.TitleText = "STOCK";
            // 
            // xuiFormDesign1.WorkingArea
            // 
            this.xuiFormDesign1.WorkingArea.BackColor = System.Drawing.Color.White;
            this.xuiFormDesign1.WorkingArea.Controls.Add(this.xuiFlatTab1);
            this.xuiFormDesign1.WorkingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xuiFormDesign1.WorkingArea.Location = new System.Drawing.Point(0, 74);
            this.xuiFormDesign1.WorkingArea.Name = "WorkingArea";
            this.xuiFormDesign1.WorkingArea.Size = new System.Drawing.Size(1242, 550);
            this.xuiFormDesign1.WorkingArea.TabIndex = 0;
            // 
            // xuiFlatTab1
            // 
            this.xuiFlatTab1.ActiveHeaderColor = System.Drawing.Color.DodgerBlue;
            this.xuiFlatTab1.ActiveTextColor = System.Drawing.Color.White;
            this.xuiFlatTab1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xuiFlatTab1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.xuiFlatTab1.Controls.Add(this.TabLista);
            this.xuiFlatTab1.Controls.Add(this.TabVenta);
            this.xuiFlatTab1.HeaderBackgroundColor = System.Drawing.Color.White;
            this.xuiFlatTab1.InActiveHeaderColor = System.Drawing.Color.RoyalBlue;
            this.xuiFlatTab1.InActiveTextColor = System.Drawing.Color.White;
            this.xuiFlatTab1.ItemSize = new System.Drawing.Size(240, 16);
            this.xuiFlatTab1.Location = new System.Drawing.Point(0, 1);
            this.xuiFlatTab1.Name = "xuiFlatTab1";
            this.xuiFlatTab1.PageColor = System.Drawing.Color.White;
            this.xuiFlatTab1.SelectedIndex = 0;
            this.xuiFlatTab1.ShowBorder = true;
            this.xuiFlatTab1.Size = new System.Drawing.Size(1242, 546);
            this.xuiFlatTab1.TabIndex = 0;
            // 
            // TabLista
            // 
            this.TabLista.BackColor = System.Drawing.Color.White;
            this.TabLista.Controls.Add(this.gunaTextBox1);
            this.TabLista.Controls.Add(this.DTStock);
            this.TabLista.Controls.Add(this.BtnBuscar);
            this.TabLista.Controls.Add(this.TPfin);
            this.TabLista.Controls.Add(this.TPinicio);
            this.TabLista.Location = new System.Drawing.Point(4, 20);
            this.TabLista.Name = "TabLista";
            this.TabLista.Padding = new System.Windows.Forms.Padding(3);
            this.TabLista.Size = new System.Drawing.Size(1234, 522);
            this.TabLista.TabIndex = 0;
            this.TabLista.Text = "Lista";
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gunaTextBox1.Location = new System.Drawing.Point(875, 13);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Size = new System.Drawing.Size(160, 32);
            this.gunaTextBox1.TabIndex = 5;
            // 
            // DTStock
            // 
            this.DTStock.AllowUserToAddRows = false;
            this.DTStock.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.DTStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DTStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DTStock.BackgroundColor = System.Drawing.Color.White;
            this.DTStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DTStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DTStock.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DTStock.DefaultCellStyle = dataGridViewCellStyle6;
            this.DTStock.EnableHeadersVisualStyles = false;
            this.DTStock.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.DTStock.Location = new System.Drawing.Point(8, 74);
            this.DTStock.Name = "DTStock";
            this.DTStock.ReadOnly = true;
            this.DTStock.RowHeadersVisible = false;
            this.DTStock.RowTemplate.Height = 24;
            this.DTStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTStock.Size = new System.Drawing.Size(1218, 433);
            this.DTStock.TabIndex = 4;
            this.DTStock.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.LightBlue;
            this.DTStock.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(251)))));
            this.DTStock.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DTStock.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DTStock.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DTStock.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DTStock.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DTStock.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(230)))), ((int)(((byte)(251)))));
            this.DTStock.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(243)))));
            this.DTStock.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.DTStock.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DTStock.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DTStock.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DTStock.ThemeStyle.HeaderStyle.Height = 4;
            this.DTStock.ThemeStyle.ReadOnly = true;
            this.DTStock.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(237)))), ((int)(((byte)(252)))));
            this.DTStock.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DTStock.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DTStock.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DTStock.ThemeStyle.RowsStyle.Height = 24;
            this.DTStock.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(197)))), ((int)(((byte)(247)))));
            this.DTStock.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.AnimationHoverSpeed = 0.07F;
            this.BtnBuscar.AnimationSpeed = 0.03F;
            this.BtnBuscar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(170)))));
            this.BtnBuscar.BorderColor = System.Drawing.Color.Black;
            this.BtnBuscar.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BtnBuscar.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnBuscar.CheckedForeColor = System.Drawing.Color.White;
            this.BtnBuscar.CheckedImage = null;
            this.BtnBuscar.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BtnBuscar.FocusedColor = System.Drawing.Color.Empty;
            this.BtnBuscar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.Image = null;
            this.BtnBuscar.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnBuscar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnBuscar.Location = new System.Drawing.Point(617, 13);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.BtnBuscar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnBuscar.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnBuscar.OnHoverImage = null;
            this.BtnBuscar.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.BtnBuscar.OnPressedColor = System.Drawing.Color.Black;
            this.BtnBuscar.Size = new System.Drawing.Size(180, 42);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TPfin
            // 
            this.TPfin.BaseColor = System.Drawing.Color.White;
            this.TPfin.BorderColor = System.Drawing.Color.Silver;
            this.TPfin.CustomFormat = "dd/MM/yy";
            this.TPfin.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.TPfin.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TPfin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TPfin.ForeColor = System.Drawing.Color.Black;
            this.TPfin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TPfin.Location = new System.Drawing.Point(289, 13);
            this.TPfin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.TPfin.MinDate = new System.DateTime(2019, 10, 31, 0, 0, 0, 0);
            this.TPfin.Name = "TPfin";
            this.TPfin.OnHoverBaseColor = System.Drawing.Color.White;
            this.TPfin.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TPfin.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TPfin.OnPressedColor = System.Drawing.Color.Black;
            this.TPfin.Size = new System.Drawing.Size(273, 42);
            this.TPfin.TabIndex = 1;
            this.TPfin.Text = "31/10/19";
            this.TPfin.Value = new System.DateTime(2019, 10, 31, 15, 27, 5, 57);
            // 
            // TPinicio
            // 
            this.TPinicio.BaseColor = System.Drawing.Color.White;
            this.TPinicio.BorderColor = System.Drawing.Color.Silver;
            this.TPinicio.CustomFormat = "dd/MM/yy";
            this.TPinicio.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.TPinicio.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TPinicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TPinicio.ForeColor = System.Drawing.Color.Black;
            this.TPinicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TPinicio.Location = new System.Drawing.Point(8, 13);
            this.TPinicio.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.TPinicio.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.TPinicio.Name = "TPinicio";
            this.TPinicio.OnHoverBaseColor = System.Drawing.Color.White;
            this.TPinicio.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TPinicio.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TPinicio.OnPressedColor = System.Drawing.Color.Black;
            this.TPinicio.Size = new System.Drawing.Size(266, 42);
            this.TPinicio.TabIndex = 0;
            this.TPinicio.Text = "31/10/19";
            this.TPinicio.Value = new System.DateTime(2019, 10, 31, 15, 26, 27, 409);
            // 
            // TabVenta
            // 
            this.TabVenta.BackColor = System.Drawing.Color.White;
            this.TabVenta.Controls.Add(this.gunaRadioButton1);
            this.TabVenta.Location = new System.Drawing.Point(4, 20);
            this.TabVenta.Name = "TabVenta";
            this.TabVenta.Padding = new System.Windows.Forms.Padding(3);
            this.TabVenta.Size = new System.Drawing.Size(1234, 522);
            this.TabVenta.TabIndex = 1;
            this.TabVenta.Text = "Venta";
            // 
            // gunaRadioButton1
            // 
            this.gunaRadioButton1.BaseColor = System.Drawing.SystemColors.Control;
            this.gunaRadioButton1.CheckedOffColor = System.Drawing.Color.Gray;
            this.gunaRadioButton1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaRadioButton1.FillColor = System.Drawing.Color.White;
            this.gunaRadioButton1.Location = new System.Drawing.Point(21, 35);
            this.gunaRadioButton1.Name = "gunaRadioButton1";
            this.gunaRadioButton1.Size = new System.Drawing.Size(141, 20);
            this.gunaRadioButton1.TabIndex = 3;
            this.gunaRadioButton1.Text = "gunaRadioButton1";
            // 
            // Frmstockmov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1242, 624);
            this.Controls.Add(this.xuiFormDesign1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmstockmov";
            this.Text = "Frmstockmov";
            this.xuiFormDesign1.WorkingArea.ResumeLayout(false);
            this.xuiFormDesign1.ResumeLayout(false);
            this.xuiFlatTab1.ResumeLayout(false);
            this.TabLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DTStock)).EndInit();
            this.TabVenta.ResumeLayout(false);
            this.TabVenta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIFormDesign xuiFormDesign1;
        private XanderUI.XUIFlatTab xuiFlatTab1;
        private System.Windows.Forms.TabPage TabLista;
        private System.Windows.Forms.TabPage TabVenta;
        private Guna.UI.WinForms.GunaDateTimePicker TPfin;
        private Guna.UI.WinForms.GunaDateTimePicker TPinicio;
        private Guna.UI.WinForms.GunaDataGridView DTStock;
        private Guna.UI.WinForms.GunaAdvenceButton BtnBuscar;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private Guna.UI.WinForms.GunaRadioButton gunaRadioButton1;


    }
}