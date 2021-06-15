namespace TPI.Presentaciones
{
    partial class FormAltaNecesidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAltaNecesidad));
            this.lbTittle = new System.Windows.Forms.Label();
            this.lbFechaDesde = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFechaDesde = new System.Windows.Forms.MaskedTextBox();
            this.txtFechaHasta = new System.Windows.Forms.MaskedTextBox();
            this.lbBeneficiario = new System.Windows.Forms.Label();
            this.cmbBeneficiario = new System.Windows.Forms.ComboBox();
            this.lbMotivo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMotivo = new System.Windows.Forms.ComboBox();
            this.cmbNivelPrioridad = new System.Windows.Forms.ComboBox();
            this.cmbTipoDonacion = new System.Windows.Forms.ComboBox();
            this.BtnAgregarBeneficiario = new System.Windows.Forms.Button();
            this.btnLimpiarNecesidad = new System.Windows.Forms.Button();
            this.btnGuardarDonacion = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lbTittle
            // 
            this.lbTittle.AutoSize = true;
            this.lbTittle.BackColor = System.Drawing.Color.Transparent;
            this.lbTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTittle.ForeColor = System.Drawing.Color.Black;
            this.lbTittle.Location = new System.Drawing.Point(96, 7);
            this.lbTittle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTittle.Name = "lbTittle";
            this.lbTittle.Size = new System.Drawing.Size(251, 31);
            this.lbTittle.TabIndex = 30;
            this.lbTittle.Text = "Alta de Necesidad";
            // 
            // lbFechaDesde
            // 
            this.lbFechaDesde.AutoSize = true;
            this.lbFechaDesde.BackColor = System.Drawing.Color.Transparent;
            this.lbFechaDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFechaDesde.Location = new System.Drawing.Point(31, 81);
            this.lbFechaDesde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFechaDesde.Name = "lbFechaDesde";
            this.lbFechaDesde.Size = new System.Drawing.Size(92, 17);
            this.lbFechaDesde.TabIndex = 31;
            this.lbFechaDesde.Text = "Fecha Desde";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Fecha Hasta";
            // 
            // txtFechaDesde
            // 
            this.txtFechaDesde.Location = new System.Drawing.Point(127, 78);
            this.txtFechaDesde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFechaDesde.Mask = "00/00/0000";
            this.txtFechaDesde.Name = "txtFechaDesde";
            this.txtFechaDesde.Size = new System.Drawing.Size(71, 20);
            this.txtFechaDesde.TabIndex = 1;
            this.txtFechaDesde.ValidatingType = typeof(System.DateTime);
            // 
            // txtFechaHasta
            // 
            this.txtFechaHasta.Location = new System.Drawing.Point(292, 77);
            this.txtFechaHasta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFechaHasta.Mask = "00/00/0000";
            this.txtFechaHasta.Name = "txtFechaHasta";
            this.txtFechaHasta.Size = new System.Drawing.Size(65, 20);
            this.txtFechaHasta.TabIndex = 2;
            this.txtFechaHasta.ValidatingType = typeof(System.DateTime);
            // 
            // lbBeneficiario
            // 
            this.lbBeneficiario.AutoSize = true;
            this.lbBeneficiario.BackColor = System.Drawing.Color.Transparent;
            this.lbBeneficiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBeneficiario.Location = new System.Drawing.Point(65, 136);
            this.lbBeneficiario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBeneficiario.Name = "lbBeneficiario";
            this.lbBeneficiario.Size = new System.Drawing.Size(82, 17);
            this.lbBeneficiario.TabIndex = 35;
            this.lbBeneficiario.Text = "Beneficiario";
            // 
            // cmbBeneficiario
            // 
            this.cmbBeneficiario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBeneficiario.FormattingEnabled = true;
            this.cmbBeneficiario.Location = new System.Drawing.Point(152, 133);
            this.cmbBeneficiario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbBeneficiario.Name = "cmbBeneficiario";
            this.cmbBeneficiario.Size = new System.Drawing.Size(119, 21);
            this.cmbBeneficiario.TabIndex = 3;
            // 
            // lbMotivo
            // 
            this.lbMotivo.AutoSize = true;
            this.lbMotivo.BackColor = System.Drawing.Color.Transparent;
            this.lbMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMotivo.Location = new System.Drawing.Point(98, 175);
            this.lbMotivo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMotivo.Name = "lbMotivo";
            this.lbMotivo.Size = new System.Drawing.Size(49, 17);
            this.lbMotivo.TabIndex = 37;
            this.lbMotivo.Text = "Motivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 216);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Nivel de Prioridad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 257);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Tipo de Donacion";
            // 
            // cmbMotivo
            // 
            this.cmbMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMotivo.FormattingEnabled = true;
            this.cmbMotivo.Location = new System.Drawing.Point(152, 175);
            this.cmbMotivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbMotivo.Name = "cmbMotivo";
            this.cmbMotivo.Size = new System.Drawing.Size(119, 21);
            this.cmbMotivo.TabIndex = 5;
            // 
            // cmbNivelPrioridad
            // 
            this.cmbNivelPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNivelPrioridad.FormattingEnabled = true;
            this.cmbNivelPrioridad.Location = new System.Drawing.Point(152, 216);
            this.cmbNivelPrioridad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbNivelPrioridad.Name = "cmbNivelPrioridad";
            this.cmbNivelPrioridad.Size = new System.Drawing.Size(119, 21);
            this.cmbNivelPrioridad.TabIndex = 6;
            // 
            // cmbTipoDonacion
            // 
            this.cmbTipoDonacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDonacion.FormattingEnabled = true;
            this.cmbTipoDonacion.Location = new System.Drawing.Point(152, 257);
            this.cmbTipoDonacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTipoDonacion.Name = "cmbTipoDonacion";
            this.cmbTipoDonacion.Size = new System.Drawing.Size(119, 21);
            this.cmbTipoDonacion.TabIndex = 7;
            // 
            // BtnAgregarBeneficiario
            // 
            this.BtnAgregarBeneficiario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAgregarBeneficiario.BackgroundImage")));
            this.BtnAgregarBeneficiario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAgregarBeneficiario.Location = new System.Drawing.Point(278, 134);
            this.BtnAgregarBeneficiario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAgregarBeneficiario.Name = "BtnAgregarBeneficiario";
            this.BtnAgregarBeneficiario.Size = new System.Drawing.Size(25, 20);
            this.BtnAgregarBeneficiario.TabIndex = 4;
            this.toolTip1.SetToolTip(this.BtnAgregarBeneficiario, "Crear un nuevo beneficiario");
            this.BtnAgregarBeneficiario.UseVisualStyleBackColor = true;
            this.BtnAgregarBeneficiario.Click += new System.EventHandler(this.BtnAgregarBeneficiario_Click);
            // 
            // btnLimpiarNecesidad
            // 
            this.btnLimpiarNecesidad.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpiarNecesidad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiarNecesidad.BackgroundImage")));
            this.btnLimpiarNecesidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiarNecesidad.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpiarNecesidad.Location = new System.Drawing.Point(311, 307);
            this.btnLimpiarNecesidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiarNecesidad.Name = "btnLimpiarNecesidad";
            this.btnLimpiarNecesidad.Size = new System.Drawing.Size(46, 38);
            this.btnLimpiarNecesidad.TabIndex = 43;
            this.toolTip1.SetToolTip(this.btnLimpiarNecesidad, "Limpiar campos");
            this.btnLimpiarNecesidad.UseVisualStyleBackColor = false;
            this.btnLimpiarNecesidad.Click += new System.EventHandler(this.btnLimpiarNecesidad_Click);
            // 
            // btnGuardarDonacion
            // 
            this.btnGuardarDonacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardarDonacion.BackgroundImage")));
            this.btnGuardarDonacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarDonacion.Location = new System.Drawing.Point(361, 307);
            this.btnGuardarDonacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardarDonacion.Name = "btnGuardarDonacion";
            this.btnGuardarDonacion.Size = new System.Drawing.Size(46, 38);
            this.btnGuardarDonacion.TabIndex = 29;
            this.toolTip1.SetToolTip(this.btnGuardarDonacion, "Guardar");
            this.btnGuardarDonacion.UseVisualStyleBackColor = true;
            this.btnGuardarDonacion.Click += new System.EventHandler(this.btnGuardarDonacion_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Location = new System.Drawing.Point(261, 307);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(46, 38);
            this.btnCancelar.TabIndex = 62;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Transparent;
            this.btnVolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVolver.BackgroundImage")));
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVolver.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVolver.Location = new System.Drawing.Point(9, 9);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(38, 39);
            this.btnVolver.TabIndex = 63;
            this.toolTip1.SetToolTip(this.btnVolver, "Volver");
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FormAltaNecesidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::TPI.Properties.Resources.fondo_degradado_tonos_verdes_23_2148373476;
            this.ClientSize = new System.Drawing.Size(418, 366);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.BtnAgregarBeneficiario);
            this.Controls.Add(this.btnLimpiarNecesidad);
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
            this.Controls.Add(this.btnGuardarDonacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAltaNecesidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Necesidad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarDonacion;
        private System.Windows.Forms.Label lbTittle;
        private System.Windows.Forms.Label lbFechaDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtFechaDesde;
        private System.Windows.Forms.MaskedTextBox txtFechaHasta;
        private System.Windows.Forms.Label lbBeneficiario;
        private System.Windows.Forms.ComboBox cmbBeneficiario;
        private System.Windows.Forms.Label lbMotivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMotivo;
        private System.Windows.Forms.ComboBox cmbNivelPrioridad;
        private System.Windows.Forms.ComboBox cmbTipoDonacion;
        private System.Windows.Forms.Button btnLimpiarNecesidad;
        private System.Windows.Forms.Button BtnAgregarBeneficiario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
    }
}