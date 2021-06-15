namespace TPI.Presentaciones
{
    partial class FormActualizarNecesidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormActualizarNecesidad));
            this.cmbTipoDonacion = new System.Windows.Forms.ComboBox();
            this.cmbNivelPrioridad = new System.Windows.Forms.ComboBox();
            this.cmbMotivo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMotivo = new System.Windows.Forms.Label();
            this.cmbBeneficiario = new System.Windows.Forms.ComboBox();
            this.lbBeneficiario = new System.Windows.Forms.Label();
            this.txtFechaHasta = new System.Windows.Forms.MaskedTextBox();
            this.txtFechaDesde = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFechaDesde = new System.Windows.Forms.Label();
            this.lbTittle = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardarNecesidad = new System.Windows.Forms.Button();
            this.gdrNecesidad = new System.Windows.Forms.DataGridView();
            this.IdNecesidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdBeneficiario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdMotivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdNivelPrioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTipoDeDonacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarFecha = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnLimpiarNecesidad = new System.Windows.Forms.Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gdrNecesidad)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTipoDonacion
            // 
            this.cmbTipoDonacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDonacion.FormattingEnabled = true;
            this.cmbTipoDonacion.Location = new System.Drawing.Point(137, 241);
            this.cmbTipoDonacion.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoDonacion.Name = "cmbTipoDonacion";
            this.cmbTipoDonacion.Size = new System.Drawing.Size(109, 21);
            this.cmbTipoDonacion.TabIndex = 5;
            // 
            // cmbNivelPrioridad
            // 
            this.cmbNivelPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNivelPrioridad.FormattingEnabled = true;
            this.cmbNivelPrioridad.Location = new System.Drawing.Point(137, 200);
            this.cmbNivelPrioridad.Margin = new System.Windows.Forms.Padding(2);
            this.cmbNivelPrioridad.Name = "cmbNivelPrioridad";
            this.cmbNivelPrioridad.Size = new System.Drawing.Size(109, 21);
            this.cmbNivelPrioridad.TabIndex = 4;
            // 
            // cmbMotivo
            // 
            this.cmbMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMotivo.FormattingEnabled = true;
            this.cmbMotivo.Location = new System.Drawing.Point(137, 161);
            this.cmbMotivo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMotivo.Name = "cmbMotivo";
            this.cmbMotivo.Size = new System.Drawing.Size(107, 21);
            this.cmbMotivo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 241);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 55;
            this.label4.Text = "Tipo de Donacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 200);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 54;
            this.label3.Text = "Nivel de Prioridad";
            // 
            // lbMotivo
            // 
            this.lbMotivo.AutoSize = true;
            this.lbMotivo.BackColor = System.Drawing.Color.Transparent;
            this.lbMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMotivo.Location = new System.Drawing.Point(82, 162);
            this.lbMotivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMotivo.Name = "lbMotivo";
            this.lbMotivo.Size = new System.Drawing.Size(49, 17);
            this.lbMotivo.TabIndex = 53;
            this.lbMotivo.Text = "Motivo";
            // 
            // cmbBeneficiario
            // 
            this.cmbBeneficiario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBeneficiario.FormattingEnabled = true;
            this.cmbBeneficiario.Location = new System.Drawing.Point(495, 78);
            this.cmbBeneficiario.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBeneficiario.Name = "cmbBeneficiario";
            this.cmbBeneficiario.Size = new System.Drawing.Size(138, 21);
            this.cmbBeneficiario.TabIndex = 8;
            // 
            // lbBeneficiario
            // 
            this.lbBeneficiario.AutoSize = true;
            this.lbBeneficiario.BackColor = System.Drawing.Color.Transparent;
            this.lbBeneficiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBeneficiario.Location = new System.Drawing.Point(417, 79);
            this.lbBeneficiario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBeneficiario.Name = "lbBeneficiario";
            this.lbBeneficiario.Size = new System.Drawing.Size(82, 17);
            this.lbBeneficiario.TabIndex = 51;
            this.lbBeneficiario.Text = "Beneficiario";
            // 
            // txtFechaHasta
            // 
            this.txtFechaHasta.Location = new System.Drawing.Point(173, 119);
            this.txtFechaHasta.Margin = new System.Windows.Forms.Padding(2);
            this.txtFechaHasta.Mask = "00/00/0000";
            this.txtFechaHasta.Name = "txtFechaHasta";
            this.txtFechaHasta.Size = new System.Drawing.Size(71, 20);
            this.txtFechaHasta.TabIndex = 2;
            this.txtFechaHasta.ValidatingType = typeof(System.DateTime);
            // 
            // txtFechaDesde
            // 
            this.txtFechaDesde.Location = new System.Drawing.Point(173, 82);
            this.txtFechaDesde.Margin = new System.Windows.Forms.Padding(2);
            this.txtFechaDesde.Mask = "00/00/0000";
            this.txtFechaDesde.Name = "txtFechaDesde";
            this.txtFechaDesde.Size = new System.Drawing.Size(71, 20);
            this.txtFechaDesde.TabIndex = 1;
            this.txtFechaDesde.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "Fecha Hasta";
            // 
            // lbFechaDesde
            // 
            this.lbFechaDesde.AutoSize = true;
            this.lbFechaDesde.BackColor = System.Drawing.Color.Transparent;
            this.lbFechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaDesde.Location = new System.Drawing.Point(82, 83);
            this.lbFechaDesde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFechaDesde.Name = "lbFechaDesde";
            this.lbFechaDesde.Size = new System.Drawing.Size(92, 17);
            this.lbFechaDesde.TabIndex = 47;
            this.lbFechaDesde.Text = "Fecha Desde";
            // 
            // lbTittle
            // 
            this.lbTittle.AutoSize = true;
            this.lbTittle.BackColor = System.Drawing.Color.Transparent;
            this.lbTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTittle.ForeColor = System.Drawing.Color.Black;
            this.lbTittle.Location = new System.Drawing.Point(416, 15);
            this.lbTittle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTittle.Name = "lbTittle";
            this.lbTittle.Size = new System.Drawing.Size(290, 31);
            this.lbTittle.TabIndex = 46;
            this.lbTittle.Text = "Actualizar Necesidad";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Location = new System.Drawing.Point(144, 286);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(46, 38);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardarNecesidad
            // 
            this.btnGuardarNecesidad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardarNecesidad.BackgroundImage")));
            this.btnGuardarNecesidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarNecesidad.Location = new System.Drawing.Point(212, 286);
            this.btnGuardarNecesidad.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarNecesidad.Name = "btnGuardarNecesidad";
            this.btnGuardarNecesidad.Size = new System.Drawing.Size(46, 38);
            this.btnGuardarNecesidad.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnGuardarNecesidad, "Guardar");
            this.btnGuardarNecesidad.UseVisualStyleBackColor = true;
            this.btnGuardarNecesidad.Click += new System.EventHandler(this.btnGuardarNecesidad_Click);
            // 
            // gdrNecesidad
            // 
            this.gdrNecesidad.AllowUserToAddRows = false;
            this.gdrNecesidad.AllowUserToDeleteRows = false;
            this.gdrNecesidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrNecesidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdNecesidad,
            this.FechaDesde,
            this.FechaHasta,
            this.IdBeneficiario,
            this.IdMotivo,
            this.IdNivelPrioridad,
            this.IdTipoDeDonacion});
            this.gdrNecesidad.Location = new System.Drawing.Point(288, 116);
            this.gdrNecesidad.Margin = new System.Windows.Forms.Padding(2);
            this.gdrNecesidad.Name = "gdrNecesidad";
            this.gdrNecesidad.ReadOnly = true;
            this.gdrNecesidad.RowHeadersWidth = 51;
            this.gdrNecesidad.RowTemplate.Height = 24;
            this.gdrNecesidad.Size = new System.Drawing.Size(663, 219);
            this.gdrNecesidad.TabIndex = 10;
            this.gdrNecesidad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrNecesidad_CellContentClick);
            // 
            // IdNecesidad
            // 
            this.IdNecesidad.DataPropertyName = "Id_Necesidad";
            this.IdNecesidad.HeaderText = "Id";
            this.IdNecesidad.MinimumWidth = 6;
            this.IdNecesidad.Name = "IdNecesidad";
            this.IdNecesidad.ReadOnly = true;
            this.IdNecesidad.Width = 50;
            // 
            // FechaDesde
            // 
            this.FechaDesde.DataPropertyName = "FechaDesde";
            this.FechaDesde.HeaderText = "FechaDesde";
            this.FechaDesde.MinimumWidth = 6;
            this.FechaDesde.Name = "FechaDesde";
            this.FechaDesde.ReadOnly = true;
            this.FechaDesde.Width = 125;
            // 
            // FechaHasta
            // 
            this.FechaHasta.DataPropertyName = "FechaHasta";
            this.FechaHasta.HeaderText = "FechaHasta";
            this.FechaHasta.MinimumWidth = 6;
            this.FechaHasta.Name = "FechaHasta";
            this.FechaHasta.ReadOnly = true;
            this.FechaHasta.Width = 125;
            // 
            // IdBeneficiario
            // 
            this.IdBeneficiario.DataPropertyName = "Id_Beneficiario";
            this.IdBeneficiario.HeaderText = "Beneficiario";
            this.IdBeneficiario.MinimumWidth = 6;
            this.IdBeneficiario.Name = "IdBeneficiario";
            this.IdBeneficiario.ReadOnly = true;
            this.IdBeneficiario.Width = 125;
            // 
            // IdMotivo
            // 
            this.IdMotivo.DataPropertyName = "Id_Motivo";
            this.IdMotivo.HeaderText = "Motivo";
            this.IdMotivo.MinimumWidth = 6;
            this.IdMotivo.Name = "IdMotivo";
            this.IdMotivo.ReadOnly = true;
            this.IdMotivo.Width = 125;
            // 
            // IdNivelPrioridad
            // 
            this.IdNivelPrioridad.DataPropertyName = "Id_NivelPrioridad";
            this.IdNivelPrioridad.HeaderText = "Nivel de Prioridad";
            this.IdNivelPrioridad.MinimumWidth = 6;
            this.IdNivelPrioridad.Name = "IdNivelPrioridad";
            this.IdNivelPrioridad.ReadOnly = true;
            this.IdNivelPrioridad.Width = 150;
            // 
            // IdTipoDeDonacion
            // 
            this.IdTipoDeDonacion.DataPropertyName = "Id_TipoDonacion";
            this.IdTipoDeDonacion.HeaderText = "Tipo de Donacion";
            this.IdTipoDeDonacion.MinimumWidth = 6;
            this.IdTipoDeDonacion.Name = "IdTipoDeDonacion";
            this.IdTipoDeDonacion.ReadOnly = true;
            this.IdTipoDeDonacion.Width = 150;
            // 
            // btnBuscarFecha
            // 
            this.btnBuscarFecha.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarFecha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarFecha.BackgroundImage")));
            this.btnBuscarFecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarFecha.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscarFecha.Location = new System.Drawing.Point(637, 79);
            this.btnBuscarFecha.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarFecha.Name = "btnBuscarFecha";
            this.btnBuscarFecha.Size = new System.Drawing.Size(26, 20);
            this.btnBuscarFecha.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnBuscarFecha, "Buscar");
            this.btnBuscarFecha.UseVisualStyleBackColor = false;
            this.btnBuscarFecha.Click += new System.EventHandler(this.btnBuscarFecha_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVolver.BackgroundImage")));
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVolver.Location = new System.Drawing.Point(9, 9);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(38, 39);
            this.btnVolver.TabIndex = 64;
            this.toolTip1.SetToolTip(this.btnVolver, "Volver");
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnLimpiarNecesidad
            // 
            this.btnLimpiarNecesidad.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarNecesidad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiarNecesidad.BackgroundImage")));
            this.btnLimpiarNecesidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiarNecesidad.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpiarNecesidad.Location = new System.Drawing.Point(74, 286);
            this.btnLimpiarNecesidad.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarNecesidad.Name = "btnLimpiarNecesidad";
            this.btnLimpiarNecesidad.Size = new System.Drawing.Size(46, 38);
            this.btnLimpiarNecesidad.TabIndex = 65;
            this.toolTip1.SetToolTip(this.btnLimpiarNecesidad, "Limpiar campos");
            this.btnLimpiarNecesidad.UseVisualStyleBackColor = false;
            this.btnLimpiarNecesidad.Click += new System.EventHandler(this.btnLimpiarNecesidad_Click_1);
            // 
            // FormActualizarNecesidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::TPI.Properties.Resources.fondo_degradado_tonos_verdes_23_2148373476;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(964, 366);
            this.Controls.Add(this.btnLimpiarNecesidad);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnBuscarFecha);
            this.Controls.Add(this.gdrNecesidad);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cmbTipoDonacion);
            this.Controls.Add(this.cmbNivelPrioridad);
            this.Controls.Add(this.cmbMotivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbMotivo);
            this.Controls.Add(this.cmbBeneficiario);
            this.Controls.Add(this.lbBeneficiario);
            this.Controls.Add(this.txtFechaHasta);
            this.Controls.Add(this.txtFechaDesde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbFechaDesde);
            this.Controls.Add(this.lbTittle);
            this.Controls.Add(this.btnGuardarNecesidad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormActualizarNecesidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Necesidad";
            this.Load += new System.EventHandler(this.FormActualizarNecesidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdrNecesidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbTipoDonacion;
        private System.Windows.Forms.ComboBox cmbNivelPrioridad;
        private System.Windows.Forms.ComboBox cmbMotivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbMotivo;
        private System.Windows.Forms.ComboBox cmbBeneficiario;
        private System.Windows.Forms.Label lbBeneficiario;
        private System.Windows.Forms.MaskedTextBox txtFechaHasta;
        private System.Windows.Forms.MaskedTextBox txtFechaDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbFechaDesde;
        private System.Windows.Forms.Label lbTittle;
        private System.Windows.Forms.Button btnGuardarNecesidad;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView gdrNecesidad;
        private System.Windows.Forms.Button btnBuscarFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdNecesidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBeneficiario;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMotivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdNivelPrioridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTipoDeDonacion;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.Button btnLimpiarNecesidad;
    }
}