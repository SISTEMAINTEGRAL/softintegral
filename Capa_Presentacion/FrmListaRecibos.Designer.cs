namespace Capa_Presentacion
{
    partial class FrmListaRecibos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaRecibos));
            this.TxtNroRecibo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnBuscarRecibo = new XanderUI.XUISuperButton();
            this.label9 = new System.Windows.Forms.Label();
            this.DTHastaRec = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.DTDesdeRec = new System.Windows.Forms.DateTimePicker();
            this.DgRecibos = new Guna.UI.WinForms.GunaDataGridView();
            this.xuiCustomGroupbox1 = new XanderUI.XUICustomGroupbox();
            this.Chkcaja = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Menureimprimir = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConfRecibo = new System.Windows.Forms.ToolStripMenuItem();
            this.panelHorizontal = new System.Windows.Forms.Panel();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lblSistemaVenta = new System.Windows.Forms.Label();
            this.loginCMSService1 = new Capa_negocio.AFIP.WSAA.LoginCMSService();
            ((System.ComponentModel.ISupportInitialize)(this.DgRecibos)).BeginInit();
            this.xuiCustomGroupbox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panelHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNroRecibo
            // 
            this.TxtNroRecibo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNroRecibo.Location = new System.Drawing.Point(242, 86);
            this.TxtNroRecibo.Margin = new System.Windows.Forms.Padding(6, 12, 6, 12);
            this.TxtNroRecibo.Name = "TxtNroRecibo";
            this.TxtNroRecibo.Size = new System.Drawing.Size(118, 30);
            this.TxtNroRecibo.TabIndex = 135;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(81, 88);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 25);
            this.label11.TabIndex = 134;
            this.label11.Text = "Nº Recibo :";
            // 
            // BtnBuscarRecibo
            // 
            this.BtnBuscarRecibo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnBuscarRecibo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(144)))), ((int)(((byte)(247)))));
            this.BtnBuscarRecibo.ButtonImage = null;
            this.BtnBuscarRecibo.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.BtnBuscarRecibo.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.BtnBuscarRecibo.ButtonText = "Buscar";
            this.BtnBuscarRecibo.CornerRadius = 5;
            this.BtnBuscarRecibo.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnBuscarRecibo.HoverBackgroundColor = System.Drawing.Color.IndianRed;
            this.BtnBuscarRecibo.HoverTextColor = System.Drawing.Color.Yellow;
            this.BtnBuscarRecibo.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.BtnBuscarRecibo.Location = new System.Drawing.Point(700, 25);
            this.BtnBuscarRecibo.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.BtnBuscarRecibo.Name = "BtnBuscarRecibo";
            this.BtnBuscarRecibo.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.BtnBuscarRecibo.SelectedTextColor = System.Drawing.Color.White;
            this.BtnBuscarRecibo.Size = new System.Drawing.Size(139, 43);
            this.BtnBuscarRecibo.SuperSelected = false;
            this.BtnBuscarRecibo.TabIndex = 133;
            this.BtnBuscarRecibo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.BtnBuscarRecibo.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.BtnBuscarRecibo.Click += new System.EventHandler(this.BtnBuscarRecibo_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 31);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 30);
            this.label9.TabIndex = 131;
            this.label9.Text = "Fecha Inicio :";
            // 
            // DTHastaRec
            // 
            this.DTHastaRec.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTHastaRec.Location = new System.Drawing.Point(517, 31);
            this.DTHastaRec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DTHastaRec.Name = "DTHastaRec";
            this.DTHastaRec.Size = new System.Drawing.Size(173, 30);
            this.DTHastaRec.TabIndex = 129;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(374, 33);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 30);
            this.label10.TabIndex = 132;
            this.label10.Text = "Fecha Fin :";
            // 
            // DTDesdeRec
            // 
            this.DTDesdeRec.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTDesdeRec.Location = new System.Drawing.Point(187, 33);
            this.DTDesdeRec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DTDesdeRec.Name = "DTDesdeRec";
            this.DTDesdeRec.Size = new System.Drawing.Size(173, 30);
            this.DTDesdeRec.TabIndex = 130;
            // 
            // DgRecibos
            // 
            this.DgRecibos.AllowUserToAddRows = false;
            this.DgRecibos.AllowUserToDeleteRows = false;
            this.DgRecibos.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DgRecibos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgRecibos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgRecibos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgRecibos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgRecibos.BackgroundColor = System.Drawing.Color.White;
            this.DgRecibos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgRecibos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgRecibos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgRecibos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgRecibos.ColumnHeadersHeight = 38;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgRecibos.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgRecibos.EnableHeadersVisualStyles = false;
            this.DgRecibos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgRecibos.Location = new System.Drawing.Point(12, 203);
            this.DgRecibos.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.DgRecibos.MultiSelect = false;
            this.DgRecibos.Name = "DgRecibos";
            this.DgRecibos.RowHeadersVisible = false;
            this.DgRecibos.RowHeadersWidth = 51;
            this.DgRecibos.RowTemplate.Height = 24;
            this.DgRecibos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgRecibos.Size = new System.Drawing.Size(930, 374);
            this.DgRecibos.StandardTab = true;
            this.DgRecibos.TabIndex = 128;
            this.DgRecibos.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DgRecibos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DgRecibos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DgRecibos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DgRecibos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DgRecibos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DgRecibos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DgRecibos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgRecibos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DgRecibos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DgRecibos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgRecibos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DgRecibos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DgRecibos.ThemeStyle.HeaderStyle.Height = 38;
            this.DgRecibos.ThemeStyle.ReadOnly = false;
            this.DgRecibos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DgRecibos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgRecibos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DgRecibos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DgRecibos.ThemeStyle.RowsStyle.Height = 24;
            this.DgRecibos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DgRecibos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DgRecibos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DgRecibos_MouseClick);
            // 
            // xuiCustomGroupbox1
            // 
            this.xuiCustomGroupbox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xuiCustomGroupbox1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.xuiCustomGroupbox1.BorderWidth = 1;
            this.xuiCustomGroupbox1.Controls.Add(this.Chkcaja);
            this.xuiCustomGroupbox1.Controls.Add(this.BtnBuscarRecibo);
            this.xuiCustomGroupbox1.Controls.Add(this.TxtNroRecibo);
            this.xuiCustomGroupbox1.Controls.Add(this.DTHastaRec);
            this.xuiCustomGroupbox1.Controls.Add(this.label11);
            this.xuiCustomGroupbox1.Controls.Add(this.label9);
            this.xuiCustomGroupbox1.Controls.Add(this.DTDesdeRec);
            this.xuiCustomGroupbox1.Controls.Add(this.label10);
            this.xuiCustomGroupbox1.Location = new System.Drawing.Point(5, 50);
            this.xuiCustomGroupbox1.Name = "xuiCustomGroupbox1";
            this.xuiCustomGroupbox1.ShowText = true;
            this.xuiCustomGroupbox1.Size = new System.Drawing.Size(945, 135);
            this.xuiCustomGroupbox1.TabIndex = 136;
            this.xuiCustomGroupbox1.TabStop = false;
            this.xuiCustomGroupbox1.Text = "Busqueda :";
            this.xuiCustomGroupbox1.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // Chkcaja
            // 
            this.Chkcaja.AutoSize = true;
            this.Chkcaja.Checked = true;
            this.Chkcaja.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Chkcaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Chkcaja.Location = new System.Drawing.Point(436, 84);
            this.Chkcaja.Name = "Chkcaja";
            this.Chkcaja.Size = new System.Drawing.Size(186, 29);
            this.Chkcaja.TabIndex = 136;
            this.Chkcaja.Text = "Pendiente de caja";
            this.Chkcaja.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menureimprimir,
            this.MenuConfRecibo});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(191, 52);
            // 
            // Menureimprimir
            // 
            this.Menureimprimir.Name = "Menureimprimir";
            this.Menureimprimir.Size = new System.Drawing.Size(190, 24);
            this.Menureimprimir.Text = "Re-Imprimir";
            this.Menureimprimir.Click += new System.EventHandler(this.Menureimprimir_Click);
            // 
            // MenuConfRecibo
            // 
            this.MenuConfRecibo.Name = "MenuConfRecibo";
            this.MenuConfRecibo.Size = new System.Drawing.Size(190, 24);
            this.MenuConfRecibo.Text = "Confirmar recibo";
            this.MenuConfRecibo.Visible = false;
            this.MenuConfRecibo.Click += new System.EventHandler(this.MenuConfRecibo_Click);
            // 
            // panelHorizontal
            // 
            this.panelHorizontal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.panelHorizontal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHorizontal.Controls.Add(this.btnMaximizar);
            this.panelHorizontal.Controls.Add(this.btnRestaurar);
            this.panelHorizontal.Controls.Add(this.btnMinimizar);
            this.panelHorizontal.Controls.Add(this.btnCerrar);
            this.panelHorizontal.Controls.Add(this.lblSistemaVenta);
            this.panelHorizontal.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHorizontal.Location = new System.Drawing.Point(0, 0);
            this.panelHorizontal.Name = "panelHorizontal";
            this.panelHorizontal.Size = new System.Drawing.Size(962, 44);
            this.panelHorizontal.TabIndex = 138;
            this.panelHorizontal.DoubleClick += new System.EventHandler(this.panelHorizontal_DoubleClick);
            this.panelHorizontal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHorizontal_MouseMove);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackgroundImage = global::Capa_Presentacion.Properties.Resources.maximize_Checkbox_16px;
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMaximizar.Location = new System.Drawing.Point(902, 5);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(22, 25);
            this.btnMaximizar.TabIndex = 5;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            this.btnMaximizar.MouseLeave += new System.EventHandler(this.btnMaximizar_MouseLeave);
            this.btnMaximizar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnMaximizar_MouseMove);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.BackgroundImage = global::Capa_Presentacion.Properties.Resources.Restore_Window_20px;
            this.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRestaurar.Location = new System.Drawing.Point(902, 5);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(22, 25);
            this.btnRestaurar.TabIndex = 2;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            this.btnRestaurar.MouseLeave += new System.EventHandler(this.btnRestaurar_MouseLeave);
            this.btnRestaurar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnRestaurar_MouseMove);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackgroundImage = global::Capa_Presentacion.Properties.Resources.Minus_20px;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimizar.Location = new System.Drawing.Point(869, 5);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(22, 25);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            this.btnMinimizar.MouseLeave += new System.EventHandler(this.btnMinimizar_MouseLeave);
            this.btnMinimizar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnMinimizar_MouseMove);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackgroundImage = global::Capa_Presentacion.Properties.Resources.Delete_20px;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCerrar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.ErrorImage")));
            this.btnCerrar.Location = new System.Drawing.Point(935, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(22, 25);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            this.btnCerrar.MouseLeave += new System.EventHandler(this.btnCerrar_MouseLeave);
            this.btnCerrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCerrar_MouseMove);
            // 
            // lblSistemaVenta
            // 
            this.lblSistemaVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSistemaVenta.AutoSize = true;
            this.lblSistemaVenta.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistemaVenta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSistemaVenta.Location = new System.Drawing.Point(4, 6);
            this.lblSistemaVenta.Name = "lblSistemaVenta";
            this.lblSistemaVenta.Size = new System.Drawing.Size(199, 28);
            this.lblSistemaVenta.TabIndex = 3;
            this.lblSistemaVenta.Text = "LISTA DE RECIBO";
            this.lblSistemaVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginCMSService1
            // 
            this.loginCMSService1.Credentials = null;
            this.loginCMSService1.Url = "https://wsaahomo.afip.gov.ar/ws/services/LoginCms";
            this.loginCMSService1.UseDefaultCredentials = false;
            // 
            // FrmListaRecibos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 605);
            this.Controls.Add(this.panelHorizontal);
            this.Controls.Add(this.xuiCustomGroupbox1);
            this.Controls.Add(this.DgRecibos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmListaRecibos";
            this.Text = "Recibo";
            ((System.ComponentModel.ISupportInitialize)(this.DgRecibos)).EndInit();
            this.xuiCustomGroupbox1.ResumeLayout(false);
            this.xuiCustomGroupbox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panelHorizontal.ResumeLayout(false);
            this.panelHorizontal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNroRecibo;
        private System.Windows.Forms.Label label11;
        private XanderUI.XUISuperButton BtnBuscarRecibo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker DTHastaRec;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker DTDesdeRec;
        private Guna.UI.WinForms.GunaDataGridView DgRecibos;
        private Capa_negocio.AFIP.WSAA.LoginCMSService loginCMSService1;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox1;
        private System.Windows.Forms.CheckBox Chkcaja;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menureimprimir;
        private System.Windows.Forms.ToolStripMenuItem MenuConfRecibo;
        private System.Windows.Forms.Panel panelHorizontal;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label lblSistemaVenta;
    }
}