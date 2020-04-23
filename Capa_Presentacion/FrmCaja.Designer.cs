namespace Capa_Presentacion
{
    partial class FrmCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCaja));
            this.ttMensajeAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.lblNomProducto = new System.Windows.Forms.Label();
            this.gbMovimento = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsaldoinicial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtConcepto = new System.Windows.Forms.TextBox();
            this.cbTipoMov = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.rbEgreso = new System.Windows.Forms.RadioButton();
            this.rbIngreso = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cbxPlanCuenta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotalIngreso = new System.Windows.Forms.TextBox();
            this.txtToltaEgreso = new System.Windows.Forms.TextBox();
            this.lblTotalEgreso = new System.Windows.Forms.Label();
            this.lblTotalIngreso = new System.Windows.Forms.Label();
            this.dataLista = new System.Windows.Forms.DataGridView();
            this.grpboxConsulta = new System.Windows.Forms.GroupBox();
            this.BtnInformecaja = new System.Windows.Forms.Button();
            this.BtnCerrarCaja = new System.Windows.Forms.Button();
            this.BtnApertura = new System.Windows.Forms.Button();
            this.dtpFechaCaja = new System.Windows.Forms.DateTimePicker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Menudelete = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCaja = new System.Windows.Forms.Label();
            this.pnlSeparacion = new System.Windows.Forms.Panel();
            this.panelHorizontal = new System.Windows.Forms.Panel();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.gbMovimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).BeginInit();
            this.grpboxConsulta.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panelHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomProducto
            // 
            this.lblNomProducto.AutoSize = true;
            this.lblNomProducto.Location = new System.Drawing.Point(44, 37);
            this.lblNomProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomProducto.Name = "lblNomProducto";
            this.lblNomProducto.Size = new System.Drawing.Size(67, 25);
            this.lblNomProducto.TabIndex = 26;
            this.lblNomProducto.Text = "Fecha";
            // 
            // gbMovimento
            // 
            this.gbMovimento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMovimento.Controls.Add(this.label5);
            this.gbMovimento.Controls.Add(this.txtsaldoinicial);
            this.gbMovimento.Controls.Add(this.label4);
            this.gbMovimento.Controls.Add(this.label3);
            this.gbMovimento.Controls.Add(this.TxtConcepto);
            this.gbMovimento.Controls.Add(this.cbTipoMov);
            this.gbMovimento.Controls.Add(this.btnAgregar);
            this.gbMovimento.Controls.Add(this.rbEgreso);
            this.gbMovimento.Controls.Add(this.rbIngreso);
            this.gbMovimento.Controls.Add(this.label2);
            this.gbMovimento.Controls.Add(this.textBox2);
            this.gbMovimento.Controls.Add(this.cbxPlanCuenta);
            this.gbMovimento.Controls.Add(this.label1);
            this.gbMovimento.Controls.Add(this.txtTotal);
            this.gbMovimento.Controls.Add(this.lblTotal);
            this.gbMovimento.Controls.Add(this.txtTotalIngreso);
            this.gbMovimento.Controls.Add(this.txtToltaEgreso);
            this.gbMovimento.Controls.Add(this.lblTotalEgreso);
            this.gbMovimento.Controls.Add(this.lblTotalIngreso);
            this.gbMovimento.Controls.Add(this.dataLista);
            this.gbMovimento.Location = new System.Drawing.Point(26, 68);
            this.gbMovimento.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gbMovimento.Name = "gbMovimento";
            this.gbMovimento.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.gbMovimento.Size = new System.Drawing.Size(1037, 570);
            this.gbMovimento.TabIndex = 40;
            this.gbMovimento.TabStop = false;
            this.gbMovimento.Text = "Movimientos de Caja";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 482);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 29);
            this.label5.TabIndex = 74;
            this.label5.Text = "Saldo Inicial :";
            // 
            // txtsaldoinicial
            // 
            this.txtsaldoinicial.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtsaldoinicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsaldoinicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsaldoinicial.Location = new System.Drawing.Point(68, 524);
            this.txtsaldoinicial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtsaldoinicial.Name = "txtsaldoinicial";
            this.txtsaldoinicial.Size = new System.Drawing.Size(168, 34);
            this.txtsaldoinicial.TabIndex = 73;
            this.txtsaldoinicial.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 25);
            this.label4.TabIndex = 72;
            this.label4.Text = "Tipo de movimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 72;
            this.label3.Text = "Concepto";
            // 
            // TxtConcepto
            // 
            this.TxtConcepto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtConcepto.Location = new System.Drawing.Point(193, 152);
            this.TxtConcepto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtConcepto.Name = "TxtConcepto";
            this.TxtConcepto.Size = new System.Drawing.Size(241, 30);
            this.TxtConcepto.TabIndex = 71;
            // 
            // cbTipoMov
            // 
            this.cbTipoMov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbTipoMov.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTipoMov.FormattingEnabled = true;
            this.cbTipoMov.Location = new System.Drawing.Point(193, 72);
            this.cbTipoMov.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbTipoMov.Name = "cbTipoMov";
            this.cbTipoMov.Size = new System.Drawing.Size(327, 33);
            this.cbTipoMov.TabIndex = 70;
            this.cbTipoMov.SelectedIndexChanged += new System.EventHandler(this.cbTipoMov_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = global::Capa_Presentacion.Properties.Resources.Add_List_20px1;
            this.btnAgregar.Location = new System.Drawing.Point(315, 191);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(28, 26);
            this.btnAgregar.TabIndex = 69;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // rbEgreso
            // 
            this.rbEgreso.AutoSize = true;
            this.rbEgreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbEgreso.Location = new System.Drawing.Point(172, 35);
            this.rbEgreso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbEgreso.Name = "rbEgreso";
            this.rbEgreso.Size = new System.Drawing.Size(116, 29);
            this.rbEgreso.TabIndex = 68;
            this.rbEgreso.Text = "EGRESO";
            this.rbEgreso.UseVisualStyleBackColor = true;
            this.rbEgreso.CheckedChanged += new System.EventHandler(this.rbEgreso_CheckedChanged);
            // 
            // rbIngreso
            // 
            this.rbIngreso.AutoSize = true;
            this.rbIngreso.Checked = true;
            this.rbIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbIngreso.Location = new System.Drawing.Point(45, 35);
            this.rbIngreso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbIngreso.Name = "rbIngreso";
            this.rbIngreso.Size = new System.Drawing.Size(122, 29);
            this.rbIngreso.TabIndex = 67;
            this.rbIngreso.TabStop = true;
            this.rbIngreso.Text = "INGRESO";
            this.rbIngreso.UseVisualStyleBackColor = true;
            this.rbIngreso.CheckedChanged += new System.EventHandler(this.rbIngreso_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 66;
            this.label2.Text = "Valor";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(192, 192);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(110, 30);
            this.textBox2.TabIndex = 65;
            // 
            // cbxPlanCuenta
            // 
            this.cbxPlanCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbxPlanCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxPlanCuenta.FormattingEnabled = true;
            this.cbxPlanCuenta.Location = new System.Drawing.Point(193, 114);
            this.cbxPlanCuenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxPlanCuenta.Name = "cbxPlanCuenta";
            this.cbxPlanCuenta.Size = new System.Drawing.Size(327, 33);
            this.cbxPlanCuenta.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 61;
            this.label1.Text = "Plan de Cuenta";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtTotal.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(752, 524);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(215, 34);
            this.txtTotal.TabIndex = 60;
            this.txtTotal.Text = "0";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(748, 495);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(87, 29);
            this.lblTotal.TabIndex = 59;
            this.lblTotal.Text = "Total $";
            // 
            // txtTotalIngreso
            // 
            this.txtTotalIngreso.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtTotalIngreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalIngreso.Location = new System.Drawing.Point(517, 524);
            this.txtTotalIngreso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalIngreso.Name = "txtTotalIngreso";
            this.txtTotalIngreso.Size = new System.Drawing.Size(168, 34);
            this.txtTotalIngreso.TabIndex = 58;
            this.txtTotalIngreso.Text = "0";
            // 
            // txtToltaEgreso
            // 
            this.txtToltaEgreso.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtToltaEgreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtToltaEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToltaEgreso.Location = new System.Drawing.Point(293, 524);
            this.txtToltaEgreso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtToltaEgreso.Name = "txtToltaEgreso";
            this.txtToltaEgreso.Size = new System.Drawing.Size(168, 34);
            this.txtToltaEgreso.TabIndex = 57;
            this.txtToltaEgreso.Text = "0";
            // 
            // lblTotalEgreso
            // 
            this.lblTotalEgreso.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTotalEgreso.AutoSize = true;
            this.lblTotalEgreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEgreso.Location = new System.Drawing.Point(514, 483);
            this.lblTotalEgreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalEgreso.Name = "lblTotalEgreso";
            this.lblTotalEgreso.Size = new System.Drawing.Size(164, 29);
            this.lblTotalEgreso.TabIndex = 56;
            this.lblTotalEgreso.Text = "Total Egreso :";
            // 
            // lblTotalIngreso
            // 
            this.lblTotalIngreso.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTotalIngreso.AutoSize = true;
            this.lblTotalIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIngreso.Location = new System.Drawing.Point(293, 480);
            this.lblTotalIngreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalIngreso.Name = "lblTotalIngreso";
            this.lblTotalIngreso.Size = new System.Drawing.Size(167, 29);
            this.lblTotalIngreso.TabIndex = 55;
            this.lblTotalIngreso.Text = "Total Ingreso :";
            // 
            // dataLista
            // 
            this.dataLista.AllowUserToAddRows = false;
            this.dataLista.AllowUserToDeleteRows = false;
            this.dataLista.AllowUserToOrderColumns = true;
            this.dataLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLista.Location = new System.Drawing.Point(20, 233);
            this.dataLista.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dataLista.MultiSelect = false;
            this.dataLista.Name = "dataLista";
            this.dataLista.ReadOnly = true;
            this.dataLista.RowHeadersWidth = 38;
            this.dataLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataLista.Size = new System.Drawing.Size(999, 232);
            this.dataLista.TabIndex = 46;
            this.dataLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLista_CellContentClick);
            this.dataLista.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataLista_MouseClick);
            // 
            // grpboxConsulta
            // 
            this.grpboxConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpboxConsulta.BackColor = System.Drawing.Color.White;
            this.grpboxConsulta.Controls.Add(this.BtnInformecaja);
            this.grpboxConsulta.Controls.Add(this.BtnCerrarCaja);
            this.grpboxConsulta.Controls.Add(this.BtnApertura);
            this.grpboxConsulta.Controls.Add(this.gbMovimento);
            this.grpboxConsulta.Controls.Add(this.dtpFechaCaja);
            this.grpboxConsulta.Controls.Add(this.lblNomProducto);
            this.grpboxConsulta.Location = new System.Drawing.Point(5, 43);
            this.grpboxConsulta.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.grpboxConsulta.Name = "grpboxConsulta";
            this.grpboxConsulta.Padding = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.grpboxConsulta.Size = new System.Drawing.Size(1088, 675);
            this.grpboxConsulta.TabIndex = 63;
            this.grpboxConsulta.TabStop = false;
            this.grpboxConsulta.Text = "Caja";
            this.grpboxConsulta.Enter += new System.EventHandler(this.grpboxConsulta_Enter);
            // 
            // BtnInformecaja
            // 
            this.BtnInformecaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInformecaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInformecaja.Location = new System.Drawing.Point(842, 14);
            this.BtnInformecaja.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnInformecaja.Name = "BtnInformecaja";
            this.BtnInformecaja.Size = new System.Drawing.Size(135, 52);
            this.BtnInformecaja.TabIndex = 72;
            this.BtnInformecaja.Text = "Informe";
            this.BtnInformecaja.UseVisualStyleBackColor = true;
            this.BtnInformecaja.Click += new System.EventHandler(this.BtnInformecaja_Click);
            // 
            // BtnCerrarCaja
            // 
            this.BtnCerrarCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrarCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarCaja.Location = new System.Drawing.Point(662, 14);
            this.BtnCerrarCaja.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCerrarCaja.Name = "BtnCerrarCaja";
            this.BtnCerrarCaja.Size = new System.Drawing.Size(135, 52);
            this.BtnCerrarCaja.TabIndex = 71;
            this.BtnCerrarCaja.Text = "Cerrar caja";
            this.BtnCerrarCaja.UseVisualStyleBackColor = true;
            this.BtnCerrarCaja.Click += new System.EventHandler(this.BtnCerrarCaja_Click);
            // 
            // BtnApertura
            // 
            this.BtnApertura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnApertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnApertura.Location = new System.Drawing.Point(484, 15);
            this.BtnApertura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnApertura.Name = "BtnApertura";
            this.BtnApertura.Size = new System.Drawing.Size(135, 52);
            this.BtnApertura.TabIndex = 70;
            this.BtnApertura.Text = "Abrir caja";
            this.BtnApertura.UseVisualStyleBackColor = true;
            this.BtnApertura.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpFechaCaja
            // 
            this.dtpFechaCaja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCaja.Location = new System.Drawing.Point(172, 31);
            this.dtpFechaCaja.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaCaja.MinDate = new System.DateTime(1969, 12, 29, 0, 0, 0, 0);
            this.dtpFechaCaja.Name = "dtpFechaCaja";
            this.dtpFechaCaja.Size = new System.Drawing.Size(240, 30);
            this.dtpFechaCaja.TabIndex = 53;
            this.dtpFechaCaja.ValueChanged += new System.EventHandler(this.dtpFechaCaja_ValueChanged);
            this.dtpFechaCaja.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpFechaCaja_KeyDown);
            this.dtpFechaCaja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFechaCaja_KeyPress);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menudelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(217, 28);
            // 
            // Menudelete
            // 
            this.Menudelete.Name = "Menudelete";
            this.Menudelete.Size = new System.Drawing.Size(216, 24);
            this.Menudelete.Text = "Eliminar movimiento";
            this.Menudelete.Click += new System.EventHandler(this.Menudelete_Click);
            // 
            // lblCaja
            // 
            this.lblCaja.AutoSize = true;
            this.lblCaja.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaja.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCaja.Location = new System.Drawing.Point(0, 0);
            this.lblCaja.Name = "lblCaja";
            this.lblCaja.Size = new System.Drawing.Size(76, 29);
            this.lblCaja.TabIndex = 3;
            this.lblCaja.Text = "CAJA";
            // 
            // pnlSeparacion
            // 
            this.pnlSeparacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSeparacion.BackColor = System.Drawing.Color.Thistle;
            this.pnlSeparacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSeparacion.Location = new System.Drawing.Point(1, 36);
            this.pnlSeparacion.Name = "pnlSeparacion";
            this.pnlSeparacion.Size = new System.Drawing.Size(1096, 2);
            this.pnlSeparacion.TabIndex = 0;
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
            this.panelHorizontal.Name = "panelHorizontal";
            this.panelHorizontal.Size = new System.Drawing.Size(1098, 37);
            this.panelHorizontal.TabIndex = 64;
            this.panelHorizontal.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHorizontal_Paint);
            this.panelHorizontal.DoubleClick += new System.EventHandler(this.panelHorizontal_DoubleClick);
            this.panelHorizontal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHorizontal_MouseMove);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackgroundImage = global::Capa_Presentacion.Properties.Resources.maximize_Checkbox_16px;
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMaximizar.Location = new System.Drawing.Point(1038, 5);
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
            this.btnRestaurar.Location = new System.Drawing.Point(1038, 5);
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
            this.btnMinimizar.Location = new System.Drawing.Point(1005, 5);
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
            this.btnCerrar.Location = new System.Drawing.Point(1071, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(22, 25);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            this.btnCerrar.MouseLeave += new System.EventHandler(this.btnCerrar_MouseLeave);
            this.btnCerrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCerrar_MouseMove);
            // 
            // FrmCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1098, 733);
            this.Controls.Add(this.panelHorizontal);
            this.Controls.Add(this.grpboxConsulta);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caja";
            this.Load += new System.EventHandler(this.FrmCaja_Load);
            this.gbMovimento.ResumeLayout(false);
            this.gbMovimento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).EndInit();
            this.grpboxConsulta.ResumeLayout(false);
            this.grpboxConsulta.PerformLayout();
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

        private System.Windows.Forms.ToolTip ttMensajeAyuda;
        private System.Windows.Forms.Label lblNomProducto;
        private System.Windows.Forms.GroupBox gbMovimento;
        private System.Windows.Forms.Label lblTotalEgreso;
        private System.Windows.Forms.Label lblTotalIngreso;
        private System.Windows.Forms.DateTimePicker dtpFechaCaja;
        private System.Windows.Forms.DataGridView dataLista;
        private System.Windows.Forms.GroupBox grpboxConsulta;
        private System.Windows.Forms.TextBox txtTotalIngreso;
        private System.Windows.Forms.TextBox txtToltaEgreso;
        private System.Windows.Forms.ComboBox cbxPlanCuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.RadioButton rbEgreso;
        private System.Windows.Forms.RadioButton rbIngreso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button BtnCerrarCaja;
        private System.Windows.Forms.Button BtnApertura;
        private System.Windows.Forms.ComboBox cbTipoMov;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtConcepto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menudelete;
        private System.Windows.Forms.Label lblCaja;
        private System.Windows.Forms.Panel pnlSeparacion;
        private System.Windows.Forms.Panel panelHorizontal;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsaldoinicial;
        private System.Windows.Forms.Button BtnInformecaja;

    }
}