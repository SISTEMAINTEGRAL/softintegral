namespace Capa_Presentacion
{
    partial class FrmConfig
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
            this.gbxTareas = new System.Windows.Forms.GroupBox();
            this.btnEliminarLogo = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbxCondicionFrenteIVA = new System.Windows.Forms.ComboBox();
            this.lblCondicion_frenteIva = new System.Windows.Forms.Label();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.lblCuit = new System.Windows.Forms.Label();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblClientes = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEmpresa = new System.Windows.Forms.TabPage();
            this.tabBackup = new System.Windows.Forms.TabPage();
            this.gbxCopiaSeguridad = new System.Windows.Forms.GroupBox();
            this.pbxBaseDatos = new System.Windows.Forms.PictureBox();
            this.lblSincronizacion = new System.Windows.Forms.Label();
            this.lblUltimaVez = new System.Windows.Forms.Label();
            this.btnSincronizar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.lblGuardarComo = new System.Windows.Forms.Label();
            this.tabTarjetas = new System.Windows.Forms.TabPage();
            this.gbxAgregarTarjetas = new System.Windows.Forms.GroupBox();
            this.btnGuardarTarjeta = new System.Windows.Forms.Button();
            this.cbxTipoTarjeta = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtNombTarjeta = new System.Windows.Forms.TextBox();
            this.lblNombreTarjeta = new System.Windows.Forms.Label();
            this.pbxTarjetas = new System.Windows.Forms.PictureBox();
            this.gbxTareas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabEmpresa.SuspendLayout();
            this.tabBackup.SuspendLayout();
            this.gbxCopiaSeguridad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBaseDatos)).BeginInit();
            this.tabTarjetas.SuspendLayout();
            this.gbxAgregarTarjetas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTarjetas)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxTareas
            // 
            this.gbxTareas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxTareas.Controls.Add(this.btnEliminarLogo);
            this.gbxTareas.Controls.Add(this.pbxLogo);
            this.gbxTareas.Controls.Add(this.btnEditar);
            this.gbxTareas.Controls.Add(this.btnCancelar);
            this.gbxTareas.Controls.Add(this.btnGuardar);
            this.gbxTareas.Controls.Add(this.cbxCondicionFrenteIVA);
            this.gbxTareas.Controls.Add(this.lblCondicion_frenteIva);
            this.gbxTareas.Controls.Add(this.txtCuit);
            this.gbxTareas.Controls.Add(this.lblCuit);
            this.gbxTareas.Controls.Add(this.btnAgregarImagen);
            this.gbxTareas.Controls.Add(this.label2);
            this.gbxTareas.Controls.Add(this.txtRazonSocial);
            this.gbxTareas.Controls.Add(this.lblNombre);
            this.gbxTareas.Location = new System.Drawing.Point(10, 27);
            this.gbxTareas.Name = "gbxTareas";
            this.gbxTareas.Size = new System.Drawing.Size(568, 401);
            this.gbxTareas.TabIndex = 35;
            this.gbxTareas.TabStop = false;
            this.gbxTareas.Text = "Datos de Empresa";
            // 
            // btnEliminarLogo
            // 
            this.btnEliminarLogo.BackgroundImage = global::Capa_Presentacion.Properties.Resources.Remove_Image_20px;
            this.btnEliminarLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminarLogo.Enabled = false;
            this.btnEliminarLogo.Location = new System.Drawing.Point(240, 283);
            this.btnEliminarLogo.Name = "btnEliminarLogo";
            this.btnEliminarLogo.Size = new System.Drawing.Size(30, 28);
            this.btnEliminarLogo.TabIndex = 64;
            this.btnEliminarLogo.UseVisualStyleBackColor = true;
            this.btnEliminarLogo.Click += new System.EventHandler(this.btnEliminarLogo_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxLogo.Location = new System.Drawing.Point(197, 197);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(80, 80);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 63;
            this.pbxLogo.TabStop = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Image = global::Capa_Presentacion.Properties.Resources.Edit_Property_20px;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(253, 340);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(96, 38);
            this.btnEditar.TabIndex = 62;
            this.btnEditar.Text = "Modificar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = global::Capa_Presentacion.Properties.Resources.Delete_File_20px;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(458, 340);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 38);
            this.btnCancelar.TabIndex = 60;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Image = global::Capa_Presentacion.Properties.Resources.Save_20px;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(355, 340);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 38);
            this.btnGuardar.TabIndex = 59;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbxCondicionFrenteIVA
            // 
            this.cbxCondicionFrenteIVA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxCondicionFrenteIVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCondicionFrenteIVA.Enabled = false;
            this.cbxCondicionFrenteIVA.FormattingEnabled = true;
            this.cbxCondicionFrenteIVA.Items.AddRange(new object[] {
            "IVA Responsable Inscripto",
            "IVA Responsable no Inscripto",
            "IVA no Responsable",
            "IVA Sujeto Exento",
            "Consumidor Final",
            "Responsable Monotributo",
            "Sujeto no Categorizado",
            "Proveedor del Exterior",
            "Cliente del Exterior",
            "IVA Liberado – Ley Nº 19.640",
            "IVA Responsable Inscripto – Agente de Percepción",
            "Pequeño Contribuyente Eventual",
            "Monotributista Social",
            "Pequeño Contribuyente Eventual Social"});
            this.cbxCondicionFrenteIVA.Location = new System.Drawing.Point(197, 142);
            this.cbxCondicionFrenteIVA.Name = "cbxCondicionFrenteIVA";
            this.cbxCondicionFrenteIVA.Size = new System.Drawing.Size(279, 28);
            this.cbxCondicionFrenteIVA.TabIndex = 56;
            // 
            // lblCondicion_frenteIva
            // 
            this.lblCondicion_frenteIva.AutoSize = true;
            this.lblCondicion_frenteIva.Location = new System.Drawing.Point(14, 146);
            this.lblCondicion_frenteIva.Name = "lblCondicion_frenteIva";
            this.lblCondicion_frenteIva.Size = new System.Drawing.Size(177, 20);
            this.lblCondicion_frenteIva.TabIndex = 55;
            this.lblCondicion_frenteIva.Text = "Condicion Frente al IVA";
            // 
            // txtCuit
            // 
            this.txtCuit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCuit.Location = new System.Drawing.Point(197, 89);
            this.txtCuit.MaxLength = 13;
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.ReadOnly = true;
            this.txtCuit.Size = new System.Drawing.Size(279, 26);
            this.txtCuit.TabIndex = 55;
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(145, 92);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(46, 20);
            this.lblCuit.TabIndex = 56;
            this.lblCuit.Text = "CUIT";
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.BackgroundImage = global::Capa_Presentacion.Properties.Resources.Add_Image_20px;
            this.btnAgregarImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAgregarImagen.Enabled = false;
            this.btnAgregarImagen.Location = new System.Drawing.Point(204, 283);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(30, 28);
            this.btnAgregarImagen.TabIndex = 48;
            this.btnAgregarImagen.UseVisualStyleBackColor = true;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Logo";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRazonSocial.Location = new System.Drawing.Point(197, 36);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.ReadOnly = true;
            this.txtRazonSocial.Size = new System.Drawing.Size(279, 26);
            this.txtRazonSocial.TabIndex = 46;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(91, 39);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(100, 20);
            this.lblNombre.TabIndex = 47;
            this.lblNombre.Text = "Razon social";
            // 
            // lblClientes
            // 
            this.lblClientes.AutoSize = true;
            this.lblClientes.BackColor = System.Drawing.Color.Black;
            this.lblClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblClientes.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.Color.Snow;
            this.lblClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblClientes.Location = new System.Drawing.Point(24, 18);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(301, 49);
            this.lblClientes.TabIndex = 36;
            this.lblClientes.Text = "Configuración";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabEmpresa);
            this.tabControl1.Controls.Add(this.tabBackup);
            this.tabControl1.Controls.Add(this.tabTarjetas);
            this.tabControl1.Location = new System.Drawing.Point(24, 82);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(603, 482);
            this.tabControl1.TabIndex = 66;
            // 
            // tabEmpresa
            // 
            this.tabEmpresa.Controls.Add(this.gbxTareas);
            this.tabEmpresa.Location = new System.Drawing.Point(4, 29);
            this.tabEmpresa.Name = "tabEmpresa";
            this.tabEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmpresa.Size = new System.Drawing.Size(595, 449);
            this.tabEmpresa.TabIndex = 0;
            this.tabEmpresa.Text = "Empresa";
            this.tabEmpresa.UseVisualStyleBackColor = true;
            // 
            // tabBackup
            // 
            this.tabBackup.Controls.Add(this.gbxCopiaSeguridad);
            this.tabBackup.Location = new System.Drawing.Point(4, 29);
            this.tabBackup.Name = "tabBackup";
            this.tabBackup.Padding = new System.Windows.Forms.Padding(3);
            this.tabBackup.Size = new System.Drawing.Size(595, 449);
            this.tabBackup.TabIndex = 1;
            this.tabBackup.Text = "Backup";
            this.tabBackup.UseVisualStyleBackColor = true;
            // 
            // gbxCopiaSeguridad
            // 
            this.gbxCopiaSeguridad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxCopiaSeguridad.Controls.Add(this.pbxBaseDatos);
            this.gbxCopiaSeguridad.Controls.Add(this.lblSincronizacion);
            this.gbxCopiaSeguridad.Controls.Add(this.lblUltimaVez);
            this.gbxCopiaSeguridad.Controls.Add(this.btnSincronizar);
            this.gbxCopiaSeguridad.Controls.Add(this.btnBuscar);
            this.gbxCopiaSeguridad.Controls.Add(this.txtRuta);
            this.gbxCopiaSeguridad.Controls.Add(this.lblGuardarComo);
            this.gbxCopiaSeguridad.Location = new System.Drawing.Point(13, 24);
            this.gbxCopiaSeguridad.Name = "gbxCopiaSeguridad";
            this.gbxCopiaSeguridad.Size = new System.Drawing.Size(568, 401);
            this.gbxCopiaSeguridad.TabIndex = 36;
            this.gbxCopiaSeguridad.TabStop = false;
            this.gbxCopiaSeguridad.Text = "Copia de Seguridad";
            // 
            // pbxBaseDatos
            // 
            this.pbxBaseDatos.Image = global::Capa_Presentacion.Properties.Resources.Database_Backup_100px;
            this.pbxBaseDatos.Location = new System.Drawing.Point(21, 45);
            this.pbxBaseDatos.Name = "pbxBaseDatos";
            this.pbxBaseDatos.Size = new System.Drawing.Size(107, 113);
            this.pbxBaseDatos.TabIndex = 52;
            this.pbxBaseDatos.TabStop = false;
            // 
            // lblSincronizacion
            // 
            this.lblSincronizacion.AutoSize = true;
            this.lblSincronizacion.Location = new System.Drawing.Point(244, 239);
            this.lblSincronizacion.Name = "lblSincronizacion";
            this.lblSincronizacion.Size = new System.Drawing.Size(55, 20);
            this.lblSincronizacion.TabIndex = 51;
            this.lblSincronizacion.Text = "Nunca";
            this.lblSincronizacion.Visible = false;
            // 
            // lblUltimaVez
            // 
            this.lblUltimaVez.AutoSize = true;
            this.lblUltimaVez.Location = new System.Drawing.Point(53, 239);
            this.lblUltimaVez.Name = "lblUltimaVez";
            this.lblUltimaVez.Size = new System.Drawing.Size(191, 20);
            this.lblUltimaVez.TabIndex = 50;
            this.lblUltimaVez.Text = "Ultima vez sincronizado ...";
            // 
            // btnSincronizar
            // 
            this.btnSincronizar.Enabled = false;
            this.btnSincronizar.Image = global::Capa_Presentacion.Properties.Resources.Synchronize_20px;
            this.btnSincronizar.Location = new System.Drawing.Point(496, 189);
            this.btnSincronizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSincronizar.Name = "btnSincronizar";
            this.btnSincronizar.Size = new System.Drawing.Size(27, 28);
            this.btnSincronizar.TabIndex = 49;
            this.btnSincronizar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSincronizar.UseVisualStyleBackColor = true;
            this.btnSincronizar.Click += new System.EventHandler(this.btnSincronizar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::Capa_Presentacion.Properties.Resources.Search_15px;
            this.btnBuscar.Location = new System.Drawing.Point(465, 189);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(26, 28);
            this.btnBuscar.TabIndex = 48;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(181, 190);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.ReadOnly = true;
            this.txtRuta.Size = new System.Drawing.Size(279, 26);
            this.txtRuta.TabIndex = 46;
            this.txtRuta.TextChanged += new System.EventHandler(this.txtRuta_TextChanged);
            // 
            // lblGuardarComo
            // 
            this.lblGuardarComo.AutoSize = true;
            this.lblGuardarComo.Location = new System.Drawing.Point(53, 193);
            this.lblGuardarComo.Name = "lblGuardarComo";
            this.lblGuardarComo.Size = new System.Drawing.Size(111, 20);
            this.lblGuardarComo.TabIndex = 47;
            this.lblGuardarComo.Text = "Guardar como";
            // 
            // tabTarjetas
            // 
            this.tabTarjetas.Controls.Add(this.gbxAgregarTarjetas);
            this.tabTarjetas.Location = new System.Drawing.Point(4, 29);
            this.tabTarjetas.Name = "tabTarjetas";
            this.tabTarjetas.Padding = new System.Windows.Forms.Padding(3);
            this.tabTarjetas.Size = new System.Drawing.Size(595, 449);
            this.tabTarjetas.TabIndex = 2;
            this.tabTarjetas.Text = "Tarjetas";
            this.tabTarjetas.UseVisualStyleBackColor = true;
            // 
            // gbxAgregarTarjetas
            // 
            this.gbxAgregarTarjetas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxAgregarTarjetas.Controls.Add(this.btnGuardarTarjeta);
            this.gbxAgregarTarjetas.Controls.Add(this.cbxTipoTarjeta);
            this.gbxAgregarTarjetas.Controls.Add(this.lblTipo);
            this.gbxAgregarTarjetas.Controls.Add(this.txtNombTarjeta);
            this.gbxAgregarTarjetas.Controls.Add(this.lblNombreTarjeta);
            this.gbxAgregarTarjetas.Controls.Add(this.pbxTarjetas);
            this.gbxAgregarTarjetas.Location = new System.Drawing.Point(13, 24);
            this.gbxAgregarTarjetas.Name = "gbxAgregarTarjetas";
            this.gbxAgregarTarjetas.Size = new System.Drawing.Size(568, 401);
            this.gbxAgregarTarjetas.TabIndex = 37;
            this.gbxAgregarTarjetas.TabStop = false;
            this.gbxAgregarTarjetas.Text = "Agregar Tarjetas";
            // 
            // btnGuardarTarjeta
            // 
            this.btnGuardarTarjeta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarTarjeta.Enabled = false;
            this.btnGuardarTarjeta.Image = global::Capa_Presentacion.Properties.Resources.Save_20px;
            this.btnGuardarTarjeta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarTarjeta.Location = new System.Drawing.Point(403, 340);
            this.btnGuardarTarjeta.Name = "btnGuardarTarjeta";
            this.btnGuardarTarjeta.Size = new System.Drawing.Size(96, 38);
            this.btnGuardarTarjeta.TabIndex = 61;
            this.btnGuardarTarjeta.Text = "Guardar";
            this.btnGuardarTarjeta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarTarjeta.UseVisualStyleBackColor = true;
            this.btnGuardarTarjeta.Click += new System.EventHandler(this.btnGuardarTarjeta_Click);
            // 
            // cbxTipoTarjeta
            // 
            this.cbxTipoTarjeta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxTipoTarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoTarjeta.FormattingEnabled = true;
            this.cbxTipoTarjeta.Items.AddRange(new object[] {
            "Debito",
            "Credito"});
            this.cbxTipoTarjeta.Location = new System.Drawing.Point(220, 178);
            this.cbxTipoTarjeta.Name = "cbxTipoTarjeta";
            this.cbxTipoTarjeta.Size = new System.Drawing.Size(279, 28);
            this.cbxTipoTarjeta.TabIndex = 60;
            this.cbxTipoTarjeta.SelectedIndexChanged += new System.EventHandler(this.cbxTipoTarjeta_SelectedIndexChanged);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(88, 181);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(114, 20);
            this.lblTipo.TabIndex = 59;
            this.lblTipo.Text = "Tipo de Tarjeta";
            // 
            // txtNombTarjeta
            // 
            this.txtNombTarjeta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombTarjeta.Enabled = false;
            this.txtNombTarjeta.Location = new System.Drawing.Point(220, 230);
            this.txtNombTarjeta.Name = "txtNombTarjeta";
            this.txtNombTarjeta.Size = new System.Drawing.Size(279, 26);
            this.txtNombTarjeta.TabIndex = 57;
            this.txtNombTarjeta.TextChanged += new System.EventHandler(this.txtNombTarjeta_TextChanged);
            this.txtNombTarjeta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombTarjeta_KeyDown);
            // 
            // lblNombreTarjeta
            // 
            this.lblNombreTarjeta.AutoSize = true;
            this.lblNombreTarjeta.Location = new System.Drawing.Point(61, 233);
            this.lblNombreTarjeta.Name = "lblNombreTarjeta";
            this.lblNombreTarjeta.Size = new System.Drawing.Size(140, 20);
            this.lblNombreTarjeta.TabIndex = 58;
            this.lblNombreTarjeta.Text = "Nombre de Tarjeta";
            // 
            // pbxTarjetas
            // 
            this.pbxTarjetas.BackgroundImage = global::Capa_Presentacion.Properties.Resources.Credit_Card_96px;
            this.pbxTarjetas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbxTarjetas.Location = new System.Drawing.Point(21, 45);
            this.pbxTarjetas.Name = "pbxTarjetas";
            this.pbxTarjetas.Size = new System.Drawing.Size(107, 113);
            this.pbxTarjetas.TabIndex = 52;
            this.pbxTarjetas.TabStop = false;
            // 
            // FrmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 589);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblClientes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConfig";
            this.Load += new System.EventHandler(this.FrmConfig_Load);
            this.gbxTareas.ResumeLayout(false);
            this.gbxTareas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabEmpresa.ResumeLayout(false);
            this.tabBackup.ResumeLayout(false);
            this.gbxCopiaSeguridad.ResumeLayout(false);
            this.gbxCopiaSeguridad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBaseDatos)).EndInit();
            this.tabTarjetas.ResumeLayout(false);
            this.gbxAgregarTarjetas.ResumeLayout(false);
            this.gbxAgregarTarjetas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTarjetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxTareas;
        private System.Windows.Forms.ComboBox cbxCondicionFrenteIVA;
        private System.Windows.Forms.Label lblCondicion_frenteIva;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminarLogo;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEmpresa;
        private System.Windows.Forms.TabPage tabBackup;
        private System.Windows.Forms.GroupBox gbxCopiaSeguridad;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Label lblGuardarComo;
        private System.Windows.Forms.Button btnSincronizar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblSincronizacion;
        private System.Windows.Forms.Label lblUltimaVez;
        private System.Windows.Forms.PictureBox pbxBaseDatos;
        private System.Windows.Forms.TabPage tabTarjetas;
        private System.Windows.Forms.GroupBox gbxAgregarTarjetas;
        private System.Windows.Forms.ComboBox cbxTipoTarjeta;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtNombTarjeta;
        private System.Windows.Forms.Label lblNombreTarjeta;
        private System.Windows.Forms.PictureBox pbxTarjetas;
        private System.Windows.Forms.Button btnGuardarTarjeta;

    }
}