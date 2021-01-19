namespace Capa_Presentacion
{
    partial class FrmCajaHistorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCajaHistorial));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHorizontal = new System.Windows.Forms.Panel();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pnlSeparacion = new System.Windows.Forms.Panel();
            this.lblCaja = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFechaIni = new System.Windows.Forms.Label();
            this.dtpFechaIni = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.DGCajaDiario = new Guna.UI.WinForms.GunaDataGridView();
            this.DGTurno = new Guna.UI.WinForms.GunaDataGridView();
            this.DGMovCaja = new Guna.UI.WinForms.GunaDataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.xuiCustomGroupbox2 = new XanderUI.XUICustomGroupbox();
            this.xuiCustomGroupbox1 = new XanderUI.XUICustomGroupbox();
            this.xuiCustomGroupbox3 = new XanderUI.XUICustomGroupbox();
            this.panelHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGCajaDiario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGTurno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGMovCaja)).BeginInit();
            this.xuiCustomGroupbox2.SuspendLayout();
            this.xuiCustomGroupbox1.SuspendLayout();
            this.xuiCustomGroupbox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHorizontal
            // 
            this.panelHorizontal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.panelHorizontal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHorizontal.Controls.Add(this.btnMaximizar);
            this.panelHorizontal.Controls.Add(this.btnRestaurar);
            this.panelHorizontal.Controls.Add(this.btnMinimizar);
            this.panelHorizontal.Controls.Add(this.btnCerrar);
            this.panelHorizontal.Controls.Add(this.pnlSeparacion);
            this.panelHorizontal.Controls.Add(this.lblCaja);
            this.panelHorizontal.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHorizontal.Location = new System.Drawing.Point(0, 0);
            this.panelHorizontal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelHorizontal.Name = "panelHorizontal";
            this.panelHorizontal.Size = new System.Drawing.Size(1174, 37);
            this.panelHorizontal.TabIndex = 65;
            this.panelHorizontal.DoubleClick += new System.EventHandler(this.panelHorizontal_DoubleClick);
            this.panelHorizontal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHorizontal_MouseMove);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackgroundImage = global::Capa_Presentacion.Properties.Resources.maximize_Checkbox_16px;
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMaximizar.Location = new System.Drawing.Point(1095, 1);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(33, 29);
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
            this.btnRestaurar.Location = new System.Drawing.Point(1095, 1);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(33, 29);
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
            this.btnMinimizar.Location = new System.Drawing.Point(1055, 1);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(33, 29);
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
            this.btnCerrar.Location = new System.Drawing.Point(1135, 1);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(33, 30);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            this.btnCerrar.MouseLeave += new System.EventHandler(this.btnCerrar_MouseLeave);
            this.btnCerrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCerrar_MouseMove);
            // 
            // pnlSeparacion
            // 
            this.pnlSeparacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSeparacion.BackColor = System.Drawing.Color.Thistle;
            this.pnlSeparacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSeparacion.Location = new System.Drawing.Point(2, 56);
            this.pnlSeparacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlSeparacion.Name = "pnlSeparacion";
            this.pnlSeparacion.Size = new System.Drawing.Size(1170, 0);
            this.pnlSeparacion.TabIndex = 0;
            // 
            // lblCaja
            // 
            this.lblCaja.AutoSize = true;
            this.lblCaja.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaja.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCaja.Location = new System.Drawing.Point(0, 0);
            this.lblCaja.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaja.Name = "lblCaja";
            this.lblCaja.Size = new System.Drawing.Size(266, 29);
            this.lblCaja.TabIndex = 3;
            this.lblCaja.Text = "HISTORIAL  DE CAJA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 30);
            this.label1.TabIndex = 69;
            this.label1.Text = "Fecha Fin";
            // 
            // lblFechaIni
            // 
            this.lblFechaIni.AutoSize = true;
            this.lblFechaIni.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaIni.Location = new System.Drawing.Point(15, 54);
            this.lblFechaIni.Name = "lblFechaIni";
            this.lblFechaIni.Size = new System.Drawing.Size(160, 30);
            this.lblFechaIni.TabIndex = 68;
            this.lblFechaIni.Text = "Fecha Inicio";
            // 
            // dtpFechaIni
            // 
            this.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIni.Location = new System.Drawing.Point(13, 85);
            this.dtpFechaIni.Name = "dtpFechaIni";
            this.dtpFechaIni.Size = new System.Drawing.Size(157, 30);
            this.dtpFechaIni.TabIndex = 66;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(204, 85);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(157, 30);
            this.dtpFechaFin.TabIndex = 67;
            // 
            // DGCajaDiario
            // 
            this.DGCajaDiario.AllowUserToAddRows = false;
            this.DGCajaDiario.AllowUserToDeleteRows = false;
            this.DGCajaDiario.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGCajaDiario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGCajaDiario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGCajaDiario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGCajaDiario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGCajaDiario.BackgroundColor = System.Drawing.Color.White;
            this.DGCajaDiario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGCajaDiario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGCajaDiario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGCajaDiario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGCajaDiario.ColumnHeadersHeight = 38;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGCajaDiario.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGCajaDiario.EnableHeadersVisualStyles = false;
            this.DGCajaDiario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGCajaDiario.Location = new System.Drawing.Point(15, 26);
            this.DGCajaDiario.MultiSelect = false;
            this.DGCajaDiario.Name = "DGCajaDiario";
            this.DGCajaDiario.RowHeadersVisible = false;
            this.DGCajaDiario.RowHeadersWidth = 62;
            this.DGCajaDiario.RowTemplate.Height = 24;
            this.DGCajaDiario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGCajaDiario.Size = new System.Drawing.Size(756, 78);
            this.DGCajaDiario.StandardTab = true;
            this.DGCajaDiario.TabIndex = 114;
            this.DGCajaDiario.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DGCajaDiario.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGCajaDiario.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGCajaDiario.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGCajaDiario.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGCajaDiario.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGCajaDiario.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGCajaDiario.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGCajaDiario.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGCajaDiario.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DGCajaDiario.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGCajaDiario.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGCajaDiario.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGCajaDiario.ThemeStyle.HeaderStyle.Height = 38;
            this.DGCajaDiario.ThemeStyle.ReadOnly = false;
            this.DGCajaDiario.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGCajaDiario.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGCajaDiario.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGCajaDiario.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGCajaDiario.ThemeStyle.RowsStyle.Height = 24;
            this.DGCajaDiario.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGCajaDiario.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGCajaDiario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGCajaDiario_CellClick);
            // 
            // DGTurno
            // 
            this.DGTurno.AllowUserToAddRows = false;
            this.DGTurno.AllowUserToDeleteRows = false;
            this.DGTurno.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DGTurno.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DGTurno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGTurno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGTurno.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGTurno.BackgroundColor = System.Drawing.Color.White;
            this.DGTurno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGTurno.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGTurno.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGTurno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGTurno.ColumnHeadersHeight = 38;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGTurno.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGTurno.EnableHeadersVisualStyles = false;
            this.DGTurno.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGTurno.Location = new System.Drawing.Point(11, 24);
            this.DGTurno.MultiSelect = false;
            this.DGTurno.Name = "DGTurno";
            this.DGTurno.RowHeadersVisible = false;
            this.DGTurno.RowHeadersWidth = 62;
            this.DGTurno.RowTemplate.Height = 24;
            this.DGTurno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGTurno.Size = new System.Drawing.Size(1100, 87);
            this.DGTurno.StandardTab = true;
            this.DGTurno.TabIndex = 114;
            this.DGTurno.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DGTurno.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGTurno.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGTurno.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGTurno.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGTurno.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGTurno.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGTurno.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGTurno.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGTurno.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DGTurno.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGTurno.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGTurno.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGTurno.ThemeStyle.HeaderStyle.Height = 38;
            this.DGTurno.ThemeStyle.ReadOnly = false;
            this.DGTurno.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGTurno.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGTurno.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGTurno.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGTurno.ThemeStyle.RowsStyle.Height = 24;
            this.DGTurno.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGTurno.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DGTurno.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGTurno_CellClick);
            // 
            // DGMovCaja
            // 
            this.DGMovCaja.AllowUserToAddRows = false;
            this.DGMovCaja.AllowUserToDeleteRows = false;
            this.DGMovCaja.AllowUserToOrderColumns = true;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.DGMovCaja.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.DGMovCaja.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGMovCaja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGMovCaja.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGMovCaja.BackgroundColor = System.Drawing.Color.White;
            this.DGMovCaja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGMovCaja.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGMovCaja.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGMovCaja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DGMovCaja.ColumnHeadersHeight = 38;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGMovCaja.DefaultCellStyle = dataGridViewCellStyle9;
            this.DGMovCaja.EnableHeadersVisualStyles = false;
            this.DGMovCaja.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGMovCaja.Location = new System.Drawing.Point(11, 28);
            this.DGMovCaja.MultiSelect = false;
            this.DGMovCaja.Name = "DGMovCaja";
            this.DGMovCaja.RowHeadersVisible = false;
            this.DGMovCaja.RowHeadersWidth = 62;
            this.DGMovCaja.RowTemplate.Height = 24;
            this.DGMovCaja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGMovCaja.Size = new System.Drawing.Size(1093, 175);
            this.DGMovCaja.StandardTab = true;
            this.DGMovCaja.TabIndex = 114;
            this.DGMovCaja.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DGMovCaja.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DGMovCaja.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGMovCaja.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGMovCaja.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGMovCaja.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGMovCaja.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGMovCaja.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGMovCaja.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DGMovCaja.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DGMovCaja.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGMovCaja.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGMovCaja.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGMovCaja.ThemeStyle.HeaderStyle.Height = 38;
            this.DGMovCaja.ThemeStyle.ReadOnly = false;
            this.DGMovCaja.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGMovCaja.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGMovCaja.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGMovCaja.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGMovCaja.ThemeStyle.RowsStyle.Height = 24;
            this.DGMovCaja.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGMovCaja.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::Capa_Presentacion.Properties.Resources.Search_15px;
            this.btnBuscar.Location = new System.Drawing.Point(392, 74);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(62, 41);
            this.btnBuscar.TabIndex = 115;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // xuiCustomGroupbox2
            // 
            this.xuiCustomGroupbox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xuiCustomGroupbox2.BorderColor = System.Drawing.Color.DodgerBlue;
            this.xuiCustomGroupbox2.BorderWidth = 1;
            this.xuiCustomGroupbox2.Controls.Add(this.DGCajaDiario);
            this.xuiCustomGroupbox2.Location = new System.Drawing.Point(18, 127);
            this.xuiCustomGroupbox2.Name = "xuiCustomGroupbox2";
            this.xuiCustomGroupbox2.ShowText = true;
            this.xuiCustomGroupbox2.Size = new System.Drawing.Size(1127, 118);
            this.xuiCustomGroupbox2.TabIndex = 117;
            this.xuiCustomGroupbox2.TabStop = false;
            this.xuiCustomGroupbox2.Text = "Caja diaria :";
            this.xuiCustomGroupbox2.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // xuiCustomGroupbox1
            // 
            this.xuiCustomGroupbox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xuiCustomGroupbox1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.xuiCustomGroupbox1.BorderWidth = 1;
            this.xuiCustomGroupbox1.Controls.Add(this.DGTurno);
            this.xuiCustomGroupbox1.Location = new System.Drawing.Point(20, 251);
            this.xuiCustomGroupbox1.Name = "xuiCustomGroupbox1";
            this.xuiCustomGroupbox1.ShowText = true;
            this.xuiCustomGroupbox1.Size = new System.Drawing.Size(1125, 119);
            this.xuiCustomGroupbox1.TabIndex = 118;
            this.xuiCustomGroupbox1.TabStop = false;
            this.xuiCustomGroupbox1.Text = "Turnos :";
            this.xuiCustomGroupbox1.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // xuiCustomGroupbox3
            // 
            this.xuiCustomGroupbox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xuiCustomGroupbox3.BorderColor = System.Drawing.Color.DodgerBlue;
            this.xuiCustomGroupbox3.BorderWidth = 1;
            this.xuiCustomGroupbox3.Controls.Add(this.DGMovCaja);
            this.xuiCustomGroupbox3.Location = new System.Drawing.Point(21, 376);
            this.xuiCustomGroupbox3.Name = "xuiCustomGroupbox3";
            this.xuiCustomGroupbox3.ShowText = true;
            this.xuiCustomGroupbox3.Size = new System.Drawing.Size(1120, 217);
            this.xuiCustomGroupbox3.TabIndex = 119;
            this.xuiCustomGroupbox3.TabStop = false;
            this.xuiCustomGroupbox3.Text = "Movimiento de caja :";
            this.xuiCustomGroupbox3.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // FrmCajaHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 624);
            this.Controls.Add(this.xuiCustomGroupbox3);
            this.Controls.Add(this.xuiCustomGroupbox1);
            this.Controls.Add(this.xuiCustomGroupbox2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFechaIni);
            this.Controls.Add(this.dtpFechaIni);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.panelHorizontal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCajaHistorial";
            this.Text = "FrmCajaHistorial";
            this.panelHorizontal.ResumeLayout(false);
            this.panelHorizontal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGCajaDiario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGTurno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGMovCaja)).EndInit();
            this.xuiCustomGroupbox2.ResumeLayout(false);
            this.xuiCustomGroupbox2.PerformLayout();
            this.xuiCustomGroupbox1.ResumeLayout(false);
            this.xuiCustomGroupbox1.PerformLayout();
            this.xuiCustomGroupbox3.ResumeLayout(false);
            this.xuiCustomGroupbox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHorizontal;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel pnlSeparacion;
        private System.Windows.Forms.Label lblCaja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFechaIni;
        private System.Windows.Forms.DateTimePicker dtpFechaIni;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private Guna.UI.WinForms.GunaDataGridView DGCajaDiario;
        private Guna.UI.WinForms.GunaDataGridView DGTurno;
        private Guna.UI.WinForms.GunaDataGridView DGMovCaja;
        private System.Windows.Forms.Button btnBuscar;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox2;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox1;
        private XanderUI.XUICustomGroupbox xuiCustomGroupbox3;
    }
}