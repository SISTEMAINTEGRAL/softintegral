﻿namespace Capa_Presentacion
{
    partial class FrmUnidades
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
            this.ttMensajeAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.btnNuevo = new System.Windows.Forms.Button();
            this.tabLista = new System.Windows.Forms.TabPage();
            this.dataLista = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.chkEliminar = new System.Windows.Forms.CheckBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNombreConfig = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.grpboxCategoria = new System.Windows.Forms.GroupBox();
            this.tabConfiguracion = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblUnidades = new System.Windows.Forms.Label();
            this.tabLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).BeginInit();
            this.grpboxCategoria.SuspendLayout();
            this.tabConfiguracion.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // ttMensajeAyuda
            // 
            this.ttMensajeAyuda.AutomaticDelay = 90;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(51, 178);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(100, 28);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // tabLista
            // 
            this.tabLista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabLista.Controls.Add(this.dataLista);
            this.tabLista.Controls.Add(this.lblTotal);
            this.tabLista.Controls.Add(this.chkEliminar);
            this.tabLista.Controls.Add(this.txtNombre);
            this.tabLista.Controls.Add(this.lblNombre);
            this.tabLista.Controls.Add(this.btnImprimir);
            this.tabLista.Controls.Add(this.btnEliminar);
            this.tabLista.Controls.Add(this.btnBuscar);
            this.tabLista.Location = new System.Drawing.Point(4, 29);
            this.tabLista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabLista.Name = "tabLista";
            this.tabLista.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabLista.Size = new System.Drawing.Size(893, 314);
            this.tabLista.TabIndex = 0;
            this.tabLista.Text = "Lista";
            this.tabLista.UseVisualStyleBackColor = true;
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
            this.dataLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataLista.Location = new System.Drawing.Point(9, 102);
            this.dataLista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataLista.MultiSelect = false;
            this.dataLista.Name = "dataLista";
            this.dataLista.ReadOnly = true;
            this.dataLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataLista.Size = new System.Drawing.Size(833, 207);
            this.dataLista.TabIndex = 11;
            this.dataLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataLista_CellContentClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(743, 75);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(16, 17);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "0";
            // 
            // chkEliminar
            // 
            this.chkEliminar.AutoSize = true;
            this.chkEliminar.Location = new System.Drawing.Point(33, 74);
            this.chkEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkEliminar.Name = "chkEliminar";
            this.chkEliminar.Size = new System.Drawing.Size(124, 21);
            this.chkEliminar.TabIndex = 9;
            this.chkEliminar.Text = "Eliminar Varios";
            this.chkEliminar.UseVisualStyleBackColor = true;
            this.chkEliminar.CheckedChanged += new System.EventHandler(this.chkEliminar_CheckedChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(96, 41);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(232, 22);
            this.txtNombre.TabIndex = 8;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(29, 42);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(676, 37);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(100, 28);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(531, 37);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(385, 37);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 28);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNombreConfig
            // 
            this.txtNombreConfig.Enabled = false;
            this.txtNombreConfig.Location = new System.Drawing.Point(153, 85);
            this.txtNombreConfig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreConfig.Name = "txtNombreConfig";
            this.txtNombreConfig.Size = new System.Drawing.Size(429, 22);
            this.txtNombreConfig.TabIndex = 14;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(153, 28);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(255, 22);
            this.txtCodigo.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Código";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(585, 178);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(400, 178);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 28);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(228, 178);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 28);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // grpboxCategoria
            // 
            this.grpboxCategoria.Controls.Add(this.txtNombreConfig);
            this.grpboxCategoria.Controls.Add(this.txtCodigo);
            this.grpboxCategoria.Controls.Add(this.label3);
            this.grpboxCategoria.Controls.Add(this.label2);
            this.grpboxCategoria.Controls.Add(this.btnCancelar);
            this.grpboxCategoria.Controls.Add(this.btnGuardar);
            this.grpboxCategoria.Controls.Add(this.btnEditar);
            this.grpboxCategoria.Controls.Add(this.btnNuevo);
            this.grpboxCategoria.Location = new System.Drawing.Point(27, 32);
            this.grpboxCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpboxCategoria.Name = "grpboxCategoria";
            this.grpboxCategoria.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpboxCategoria.Size = new System.Drawing.Size(832, 242);
            this.grpboxCategoria.TabIndex = 0;
            this.grpboxCategoria.TabStop = false;
            this.grpboxCategoria.Text = "Unidades";
            // 
            // tabConfiguracion
            // 
            this.tabConfiguracion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabConfiguracion.Controls.Add(this.grpboxCategoria);
            this.tabConfiguracion.Location = new System.Drawing.Point(4, 29);
            this.tabConfiguracion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabConfiguracion.Name = "tabConfiguracion";
            this.tabConfiguracion.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabConfiguracion.Size = new System.Drawing.Size(893, 314);
            this.tabConfiguracion.TabIndex = 1;
            this.tabConfiguracion.Text = "Configuración";
            this.tabConfiguracion.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabLista);
            this.tabControl1.Controls.Add(this.tabConfiguracion);
            this.tabControl1.ItemSize = new System.Drawing.Size(45, 25);
            this.tabControl1.Location = new System.Drawing.Point(31, 81);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.MaximumSize = new System.Drawing.Size(2000, 1108);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(901, 347);
            this.tabControl1.TabIndex = 3;
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // lblUnidades
            // 
            this.lblUnidades.AutoSize = true;
            this.lblUnidades.BackColor = System.Drawing.Color.Blue;
            this.lblUnidades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUnidades.Font = new System.Drawing.Font("Onyx", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidades.ForeColor = System.Drawing.Color.Tomato;
            this.lblUnidades.Image = global::Capa_Presentacion.Properties.Resources.fondo;
            this.lblUnidades.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblUnidades.Location = new System.Drawing.Point(31, 11);
            this.lblUnidades.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnidades.Name = "lblUnidades";
            this.lblUnidades.Size = new System.Drawing.Size(133, 57);
            this.lblUnidades.TabIndex = 2;
            this.lblUnidades.Text = "Unidades";
            // 
            // FrmUnidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Capa_Presentacion.Properties.Resources.fondo1;
            this.ClientSize = new System.Drawing.Size(965, 475);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblUnidades);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmUnidades";
            this.Text = "FrmUnidades";
            this.Load += new System.EventHandler(this.FrmUnidades_Load);
            this.tabLista.ResumeLayout(false);
            this.tabLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLista)).EndInit();
            this.grpboxCategoria.ResumeLayout(false);
            this.grpboxCategoria.PerformLayout();
            this.tabConfiguracion.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip ttMensajeAyuda;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TabPage tabLista;
        private System.Windows.Forms.DataGridView dataLista;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox chkEliminar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNombreConfig;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox grpboxCategoria;
        private System.Windows.Forms.TabPage tabConfiguracion;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.Label lblUnidades;
    }
}