namespace Capa_Presentacion
{
    partial class FrmGuardarVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGuardarVenta));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblEfectivo = new System.Windows.Forms.Label();
            this.lblPrecioEfectivo = new System.Windows.Forms.Label();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalAPagar = new System.Windows.Forms.Label();
            this.txtTotalAPagar = new System.Windows.Forms.TextBox();
            this.tbEfectivo = new System.Windows.Forms.TabPage();
            this.gbxEfectivo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBonificacion = new System.Windows.Forms.TextBox();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.lblCambio = new System.Windows.Forms.Label();
            this.txtAbono = new System.Windows.Forms.TextBox();
            this.lblAbono = new System.Windows.Forms.Label();
            this.tabTarjeta = new System.Windows.Forms.TabControl();
            this.tbTarjeta = new System.Windows.Forms.TabPage();
            this.gbxTarjeta = new System.Windows.Forms.GroupBox();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCupon = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblntarjeta = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblImportecuota = new System.Windows.Forms.Label();
            this.lblCuota = new System.Windows.Forms.Label();
            this.lblTarjeta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblsubtotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.panelHorizontal = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.lblSistemaVenta = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tbEfectivo.SuspendLayout();
            this.gbxEfectivo.SuspendLayout();
            this.tabTarjeta.SuspendLayout();
            this.tbTarjeta.SuspendLayout();
            this.gbxTarjeta.SuspendLayout();
            this.panelHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(0, 402);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(960, 73);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar(F2)";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(4, 4);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(102, 23);
            this.lblTotal.TabIndex = 44;
            this.lblTotal.Text = "TOTAL  $ :";
            // 
            // lblEfectivo
            // 
            this.lblEfectivo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEfectivo.AutoSize = true;
            this.lblEfectivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEfectivo.Location = new System.Drawing.Point(560, 230);
            this.lblEfectivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEfectivo.Name = "lblEfectivo";
            this.lblEfectivo.Size = new System.Drawing.Size(130, 23);
            this.lblEfectivo.TabIndex = 46;
            this.lblEfectivo.Text = "EFECTIVO $ :";
            this.lblEfectivo.Visible = false;
            // 
            // lblPrecioEfectivo
            // 
            this.lblPrecioEfectivo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecioEfectivo.AutoSize = true;
            this.lblPrecioEfectivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioEfectivo.Location = new System.Drawing.Point(769, 227);
            this.lblPrecioEfectivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioEfectivo.Name = "lblPrecioEfectivo";
            this.lblPrecioEfectivo.Size = new System.Drawing.Size(38, 23);
            this.lblPrecioEfectivo.TabIndex = 47;
            this.lblPrecioEfectivo.Text = "0.0";
            this.lblPrecioEfectivo.Visible = false;
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioTotal.Location = new System.Drawing.Point(213, 4);
            this.lblPrecioTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(38, 23);
            this.lblPrecioTotal.TabIndex = 49;
            this.lblPrecioTotal.Text = "0.0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.lblPrecioTotal);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Location = new System.Drawing.Point(556, 346);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 46);
            this.panel1.TabIndex = 50;
            // 
            // lblTotalAPagar
            // 
            this.lblTotalAPagar.AutoSize = true;
            this.lblTotalAPagar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAPagar.Location = new System.Drawing.Point(584, 48);
            this.lblTotalAPagar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalAPagar.Name = "lblTotalAPagar";
            this.lblTotalAPagar.Size = new System.Drawing.Size(285, 37);
            this.lblTotalAPagar.TabIndex = 51;
            this.lblTotalAPagar.Text = "TOTAL A PAGAR $ :";
            // 
            // txtTotalAPagar
            // 
            this.txtTotalAPagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalAPagar.Enabled = false;
            this.txtTotalAPagar.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAPagar.Location = new System.Drawing.Point(591, 86);
            this.txtTotalAPagar.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalAPagar.Name = "txtTotalAPagar";
            this.txtTotalAPagar.ReadOnly = true;
            this.txtTotalAPagar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalAPagar.Size = new System.Drawing.Size(286, 44);
            this.txtTotalAPagar.TabIndex = 52;
            this.txtTotalAPagar.Text = "0.0";
            // 
            // tbEfectivo
            // 
            this.tbEfectivo.BackColor = System.Drawing.Color.MintCream;
            this.tbEfectivo.Controls.Add(this.gbxEfectivo);
            this.tbEfectivo.Location = new System.Drawing.Point(4, 4);
            this.tbEfectivo.Margin = new System.Windows.Forms.Padding(4);
            this.tbEfectivo.Name = "tbEfectivo";
            this.tbEfectivo.Padding = new System.Windows.Forms.Padding(4);
            this.tbEfectivo.Size = new System.Drawing.Size(465, 334);
            this.tbEfectivo.TabIndex = 0;
            this.tbEfectivo.Text = "EFECTIVO";
            // 
            // gbxEfectivo
            // 
            this.gbxEfectivo.Controls.Add(this.label1);
            this.gbxEfectivo.Controls.Add(this.txtBonificacion);
            this.gbxEfectivo.Controls.Add(this.txtCambio);
            this.gbxEfectivo.Controls.Add(this.lblCambio);
            this.gbxEfectivo.Controls.Add(this.txtAbono);
            this.gbxEfectivo.Controls.Add(this.lblAbono);
            this.gbxEfectivo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEfectivo.Location = new System.Drawing.Point(33, 10);
            this.gbxEfectivo.Margin = new System.Windows.Forms.Padding(4);
            this.gbxEfectivo.Name = "gbxEfectivo";
            this.gbxEfectivo.Padding = new System.Windows.Forms.Padding(4);
            this.gbxEfectivo.Size = new System.Drawing.Size(368, 311);
            this.gbxEfectivo.TabIndex = 0;
            this.gbxEfectivo.TabStop = false;
            this.gbxEfectivo.Text = "Efectivo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 37);
            this.label1.TabIndex = 57;
            this.label1.Text = "B. % :";
            // 
            // txtBonificacion
            // 
            this.txtBonificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBonificacion.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBonificacion.Location = new System.Drawing.Point(159, 135);
            this.txtBonificacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtBonificacion.Name = "txtBonificacion";
            this.txtBonificacion.Size = new System.Drawing.Size(158, 44);
            this.txtBonificacion.TabIndex = 1;
            this.txtBonificacion.Text = "0";
            this.txtBonificacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBonificacion_KeyDown);
            this.txtBonificacion.Layout += new System.Windows.Forms.LayoutEventHandler(this.txtBonificacion_Layout);
            this.txtBonificacion.Leave += new System.EventHandler(this.txtBonificacion_Leave);
            this.txtBonificacion.Validated += new System.EventHandler(this.txtBonificacion_Validated);
            // 
            // txtCambio
            // 
            this.txtCambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCambio.Enabled = false;
            this.txtCambio.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambio.Location = new System.Drawing.Point(36, 250);
            this.txtCambio.Margin = new System.Windows.Forms.Padding(4);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.ReadOnly = true;
            this.txtCambio.Size = new System.Drawing.Size(286, 44);
            this.txtCambio.TabIndex = 3;
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.Location = new System.Drawing.Point(85, 203);
            this.lblCambio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(175, 37);
            this.lblCambio.TabIndex = 55;
            this.lblCambio.Text = "Cambio $ :";
            // 
            // txtAbono
            // 
            this.txtAbono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAbono.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbono.Location = new System.Drawing.Point(36, 69);
            this.txtAbono.Margin = new System.Windows.Forms.Padding(4);
            this.txtAbono.Name = "txtAbono";
            this.txtAbono.Size = new System.Drawing.Size(286, 44);
            this.txtAbono.TabIndex = 0;
            this.txtAbono.Click += new System.EventHandler(this.txtAbono_Click);
            this.txtAbono.TextChanged += new System.EventHandler(this.txtAbono_TextChanged);
            this.txtAbono.DragLeave += new System.EventHandler(this.txtAbono_DragLeave);
            this.txtAbono.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAbono_KeyDown);
            this.txtAbono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAbono_KeyPress);
            // 
            // lblAbono
            // 
            this.lblAbono.AutoSize = true;
            this.lblAbono.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbono.Location = new System.Drawing.Point(61, 31);
            this.lblAbono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAbono.Name = "lblAbono";
            this.lblAbono.Size = new System.Drawing.Size(221, 37);
            this.lblAbono.TabIndex = 53;
            this.lblAbono.Text = "Abona con $ :";
            // 
            // tabTarjeta
            // 
            this.tabTarjeta.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabTarjeta.Controls.Add(this.tbEfectivo);
            this.tabTarjeta.Controls.Add(this.tbTarjeta);
            this.tabTarjeta.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTarjeta.Location = new System.Drawing.Point(9, 46);
            this.tabTarjeta.Margin = new System.Windows.Forms.Padding(4);
            this.tabTarjeta.Multiline = true;
            this.tabTarjeta.Name = "tabTarjeta";
            this.tabTarjeta.SelectedIndex = 0;
            this.tabTarjeta.Size = new System.Drawing.Size(503, 342);
            this.tabTarjeta.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabTarjeta.TabIndex = 1;
            // 
            // tbTarjeta
            // 
            this.tbTarjeta.BackColor = System.Drawing.Color.NavajoWhite;
            this.tbTarjeta.Controls.Add(this.gbxTarjeta);
            this.tbTarjeta.Location = new System.Drawing.Point(4, 4);
            this.tbTarjeta.Margin = new System.Windows.Forms.Padding(4);
            this.tbTarjeta.Name = "tbTarjeta";
            this.tbTarjeta.Padding = new System.Windows.Forms.Padding(4);
            this.tbTarjeta.Size = new System.Drawing.Size(443, 334);
            this.tbTarjeta.TabIndex = 1;
            this.tbTarjeta.Text = "TARJETA";
            // 
            // gbxTarjeta
            // 
            this.gbxTarjeta.Controls.Add(this.txtLote);
            this.gbxTarjeta.Controls.Add(this.label10);
            this.gbxTarjeta.Controls.Add(this.txtCupon);
            this.gbxTarjeta.Controls.Add(this.label9);
            this.gbxTarjeta.Controls.Add(this.lblntarjeta);
            this.gbxTarjeta.Controls.Add(this.label7);
            this.gbxTarjeta.Controls.Add(this.lblImportecuota);
            this.gbxTarjeta.Controls.Add(this.lblCuota);
            this.gbxTarjeta.Controls.Add(this.lblTarjeta);
            this.gbxTarjeta.Controls.Add(this.label2);
            this.gbxTarjeta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTarjeta.Location = new System.Drawing.Point(10, 10);
            this.gbxTarjeta.Margin = new System.Windows.Forms.Padding(4);
            this.gbxTarjeta.Name = "gbxTarjeta";
            this.gbxTarjeta.Padding = new System.Windows.Forms.Padding(4);
            this.gbxTarjeta.Size = new System.Drawing.Size(424, 315);
            this.gbxTarjeta.TabIndex = 1;
            this.gbxTarjeta.TabStop = false;
            this.gbxTarjeta.Text = "Tarjeta";
            // 
            // txtLote
            // 
            this.txtLote.Location = new System.Drawing.Point(142, 248);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(100, 30);
            this.txtLote.TabIndex = 64;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 241);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 37);
            this.label10.TabIndex = 63;
            this.label10.Text = "Lote :";
            // 
            // txtCupon
            // 
            this.txtCupon.Location = new System.Drawing.Point(142, 177);
            this.txtCupon.Name = "txtCupon";
            this.txtCupon.Size = new System.Drawing.Size(100, 30);
            this.txtCupon.TabIndex = 62;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 167);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 37);
            this.label9.TabIndex = 61;
            this.label9.Text = "Cupon :";
            // 
            // lblntarjeta
            // 
            this.lblntarjeta.AutoSize = true;
            this.lblntarjeta.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblntarjeta.Location = new System.Drawing.Point(142, 96);
            this.lblntarjeta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblntarjeta.Name = "lblntarjeta";
            this.lblntarjeta.Size = new System.Drawing.Size(33, 28);
            this.lblntarjeta.TabIndex = 60;
            this.lblntarjeta.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(251, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 28);
            this.label7.TabIndex = 59;
            this.label7.Text = "-    $";
            // 
            // lblImportecuota
            // 
            this.lblImportecuota.AutoSize = true;
            this.lblImportecuota.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImportecuota.Location = new System.Drawing.Point(336, 31);
            this.lblImportecuota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImportecuota.Name = "lblImportecuota";
            this.lblImportecuota.Size = new System.Drawing.Size(33, 28);
            this.lblImportecuota.TabIndex = 58;
            this.lblImportecuota.Text = "...";
            // 
            // lblCuota
            // 
            this.lblCuota.AutoSize = true;
            this.lblCuota.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuota.Location = new System.Drawing.Point(187, 31);
            this.lblCuota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCuota.Name = "lblCuota";
            this.lblCuota.Size = new System.Drawing.Size(33, 28);
            this.lblCuota.TabIndex = 57;
            this.lblCuota.Text = "...";
            // 
            // lblTarjeta
            // 
            this.lblTarjeta.AutoSize = true;
            this.lblTarjeta.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarjeta.Location = new System.Drawing.Point(9, 89);
            this.lblTarjeta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTarjeta.Name = "lblTarjeta";
            this.lblTarjeta.Size = new System.Drawing.Size(132, 37);
            this.lblTarjeta.TabIndex = 55;
            this.lblTarjeta.Text = "Tarjeta :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 37);
            this.label2.TabIndex = 53;
            this.label2.Text = "Cuotas $ :";
            // 
            // lblsubtotal
            // 
            this.lblsubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblsubtotal.AutoSize = true;
            this.lblsubtotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubtotal.Location = new System.Drawing.Point(769, 258);
            this.lblsubtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsubtotal.Name = "lblsubtotal";
            this.lblsubtotal.Size = new System.Drawing.Size(38, 23);
            this.lblsubtotal.TabIndex = 54;
            this.lblsubtotal.Text = "0.0";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(557, 263);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 23);
            this.label4.TabIndex = 53;
            this.label4.Text = "SubTotal $ :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(557, 301);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 23);
            this.label3.TabIndex = 55;
            this.label3.Text = "Descuento % :";
            // 
            // lblDescuento
            // 
            this.lblDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Location = new System.Drawing.Point(769, 301);
            this.lblDescuento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(38, 23);
            this.lblDescuento.TabIndex = 56;
            this.lblDescuento.Text = "0.0";
            // 
            // panelHorizontal
            // 
            this.panelHorizontal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.panelHorizontal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHorizontal.Controls.Add(this.btnCerrar);
            this.panelHorizontal.Controls.Add(this.lblSistemaVenta);
            this.panelHorizontal.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHorizontal.Location = new System.Drawing.Point(0, 0);
            this.panelHorizontal.Name = "panelHorizontal";
            this.panelHorizontal.Size = new System.Drawing.Size(960, 37);
            this.panelHorizontal.TabIndex = 65;
            this.panelHorizontal.DoubleClick += new System.EventHandler(this.panelHorizontal_DoubleClick);
            this.panelHorizontal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHorizontal_MouseMove);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackgroundImage = global::Capa_Presentacion.Properties.Resources.Delete_20px;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCerrar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.ErrorImage")));
            this.btnCerrar.Location = new System.Drawing.Point(933, 5);
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
            this.lblSistemaVenta.Location = new System.Drawing.Point(3, 6);
            this.lblSistemaVenta.Name = "lblSistemaVenta";
            this.lblSistemaVenta.Size = new System.Drawing.Size(210, 28);
            this.lblSistemaVenta.TabIndex = 3;
            this.lblSistemaVenta.Text = "GUARDAR VENTA";
            this.lblSistemaVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmGuardarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(960, 475);
            this.Controls.Add(this.panelHorizontal);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblsubtotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotalAPagar);
            this.Controls.Add(this.lblTotalAPagar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPrecioEfectivo);
            this.Controls.Add(this.lblEfectivo);
            this.Controls.Add(this.tabTarjeta);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGuardarVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guardar Venta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGuardarVenta_FormClosing);
            this.Load += new System.EventHandler(this.FrmGuardarVenta_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmGuardarVenta_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tbEfectivo.ResumeLayout(false);
            this.gbxEfectivo.ResumeLayout(false);
            this.gbxEfectivo.PerformLayout();
            this.tabTarjeta.ResumeLayout(false);
            this.tbTarjeta.ResumeLayout(false);
            this.gbxTarjeta.ResumeLayout(false);
            this.gbxTarjeta.PerformLayout();
            this.panelHorizontal.ResumeLayout(false);
            this.panelHorizontal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblEfectivo;
        private System.Windows.Forms.Label lblPrecioEfectivo;
        private System.Windows.Forms.Label lblPrecioTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalAPagar;
        private System.Windows.Forms.TextBox txtTotalAPagar;
        private System.Windows.Forms.TabPage tbEfectivo;
        private System.Windows.Forms.GroupBox gbxEfectivo;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.TextBox txtAbono;
        private System.Windows.Forms.Label lblAbono;
        private System.Windows.Forms.TabControl tabTarjeta;
        private System.Windows.Forms.TabPage tbTarjeta;
        private System.Windows.Forms.GroupBox gbxTarjeta;
        private System.Windows.Forms.Label lblTarjeta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBonificacion;
        private System.Windows.Forms.Label lblsubtotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblImportecuota;
        private System.Windows.Forms.Label lblCuota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCupon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblntarjeta;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Panel panelHorizontal;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label lblSistemaVenta;
    }
}