namespace TPI.Presentaciones
{
    partial class FormAltaDonacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAltaDonacion));
            this.txtFechaDonacion = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLegajoEmpleadoRecibio = new System.Windows.Forms.TextBox();
            this.txtLegajoEmpleadoEntrego = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoDonacion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardarDonacion = new System.Windows.Forms.Button();
            this.btnLimpiarDonacion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscarNombreCampaña = new System.Windows.Forms.TextBox();
            this.gdrCampaña = new System.Windows.Forms.DataGridView();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCampaña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarCampañaDonacion = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNombreCampaña = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFechaInicio = new System.Windows.Forms.MaskedTextBox();
            this.txtFechaFin = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gdrCampaña)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFechaDonacion
            // 
            this.txtFechaDonacion.Location = new System.Drawing.Point(80, 9);
            this.txtFechaDonacion.Mask = "00/00/0000";
            this.txtFechaDonacion.Name = "txtFechaDonacion";
            this.txtFechaDonacion.Size = new System.Drawing.Size(67, 20);
            this.txtFechaDonacion.TabIndex = 36;
            this.txtFechaDonacion.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Fecha:";
            // 
            // txtLegajoEmpleadoRecibio
            // 
            this.txtLegajoEmpleadoRecibio.AcceptsTab = true;
            this.txtLegajoEmpleadoRecibio.Location = new System.Drawing.Point(303, 324);
            this.txtLegajoEmpleadoRecibio.Name = "txtLegajoEmpleadoRecibio";
            this.txtLegajoEmpleadoRecibio.Size = new System.Drawing.Size(220, 20);
            this.txtLegajoEmpleadoRecibio.TabIndex = 34;
            // 
            // txtLegajoEmpleadoEntrego
            // 
            this.txtLegajoEmpleadoEntrego.AcceptsTab = true;
            this.txtLegajoEmpleadoEntrego.Location = new System.Drawing.Point(343, 374);
            this.txtLegajoEmpleadoEntrego.Name = "txtLegajoEmpleadoEntrego";
            this.txtLegajoEmpleadoEntrego.Size = new System.Drawing.Size(220, 20);
            this.txtLegajoEmpleadoEntrego.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 374);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(337, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Legajo empleado entrego al Beneficiario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 322);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Legajo empleado recibio en la ONG:";
            // 
            // cmbTipoDonacion
            // 
            this.cmbTipoDonacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDonacion.FormattingEnabled = true;
            this.cmbTipoDonacion.Location = new System.Drawing.Point(167, 264);
            this.cmbTipoDonacion.Name = "cmbTipoDonacion";
            this.cmbTipoDonacion.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoDonacion.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 266);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Tipo de donacion:";
            // 
            // btnGuardarDonacion
            // 
            this.btnGuardarDonacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardarDonacion.BackgroundImage")));
            this.btnGuardarDonacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarDonacion.Location = new System.Drawing.Point(370, 403);
            this.btnGuardarDonacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarDonacion.Name = "btnGuardarDonacion";
            this.btnGuardarDonacion.Size = new System.Drawing.Size(46, 38);
            this.btnGuardarDonacion.TabIndex = 37;
            this.btnGuardarDonacion.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarDonacion
            // 
            this.btnLimpiarDonacion.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpiarDonacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiarDonacion.BackgroundImage")));
            this.btnLimpiarDonacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiarDonacion.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpiarDonacion.Location = new System.Drawing.Point(242, 403);
            this.btnLimpiarDonacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarDonacion.Name = "btnLimpiarDonacion";
            this.btnLimpiarDonacion.Size = new System.Drawing.Size(46, 38);
            this.btnLimpiarDonacion.TabIndex = 38;
            this.btnLimpiarDonacion.UseVisualStyleBackColor = false;
            this.btnLimpiarDonacion.Click += new System.EventHandler(this.btnLimpiarDonacion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Campaña:";
            // 
            // txtBuscarNombreCampaña
            // 
            this.txtBuscarNombreCampaña.AcceptsTab = true;
            this.txtBuscarNombreCampaña.Location = new System.Drawing.Point(152, 79);
            this.txtBuscarNombreCampaña.Name = "txtBuscarNombreCampaña";
            this.txtBuscarNombreCampaña.Size = new System.Drawing.Size(238, 20);
            this.txtBuscarNombreCampaña.TabIndex = 40;
            // 
            // gdrCampaña
            // 
            this.gdrCampaña.AllowUserToAddRows = false;
            this.gdrCampaña.AllowUserToDeleteRows = false;
            this.gdrCampaña.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrCampaña.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaInicio,
            this.FechaFin,
            this.NombreCampaña});
            this.gdrCampaña.Location = new System.Drawing.Point(474, 35);
            this.gdrCampaña.Name = "gdrCampaña";
            this.gdrCampaña.ReadOnly = true;
            this.gdrCampaña.Size = new System.Drawing.Size(404, 64);
            this.gdrCampaña.TabIndex = 41;
            this.gdrCampaña.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrCampaña_CellClick);
            // 
            // FechaInicio
            // 
            this.FechaInicio.DataPropertyName = "FechaInicio";
            this.FechaInicio.HeaderText = "Fecha de inicio";
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            this.FechaInicio.Width = 70;
            // 
            // FechaFin
            // 
            this.FechaFin.DataPropertyName = "FechaFin";
            this.FechaFin.HeaderText = "Fecha de finalizacion";
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.ReadOnly = true;
            this.FechaFin.Width = 70;
            // 
            // NombreCampaña
            // 
            this.NombreCampaña.DataPropertyName = "NombreCampaña";
            this.NombreCampaña.HeaderText = "Nombre";
            this.NombreCampaña.Name = "NombreCampaña";
            this.NombreCampaña.ReadOnly = true;
            this.NombreCampaña.Width = 220;
            // 
            // btnBuscarCampañaDonacion
            // 
            this.btnBuscarCampañaDonacion.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscarCampañaDonacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarCampañaDonacion.BackgroundImage")));
            this.btnBuscarCampañaDonacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarCampañaDonacion.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscarCampañaDonacion.Location = new System.Drawing.Point(404, 68);
            this.btnBuscarCampañaDonacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarCampañaDonacion.Name = "btnBuscarCampañaDonacion";
            this.btnBuscarCampañaDonacion.Size = new System.Drawing.Size(31, 31);
            this.btnBuscarCampañaDonacion.TabIndex = 42;
            this.btnBuscarCampañaDonacion.UseVisualStyleBackColor = false;
            this.btnBuscarCampañaDonacion.Click += new System.EventHandler(this.btnBuscarCampañaDonacion_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFechaFin);
            this.groupBox1.Controls.Add(this.txtFechaInicio);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNombreCampaña);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(474, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 153);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la campaña";
            // 
            // txtNombreCampaña
            // 
            this.txtNombreCampaña.AcceptsTab = true;
            this.txtNombreCampaña.Enabled = false;
            this.txtNombreCampaña.Location = new System.Drawing.Point(72, 29);
            this.txtNombreCampaña.Name = "txtNombreCampaña";
            this.txtNombreCampaña.Size = new System.Drawing.Size(219, 24);
            this.txtNombreCampaña.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 43;
            this.label6.Text = "Nombre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 73);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 15);
            this.label7.TabIndex = 45;
            this.label7.Text = "Fecha Inicio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 102);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 15);
            this.label8.TabIndex = 47;
            this.label8.Text = "Fecha Fin:";
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.Enabled = false;
            this.txtFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaInicio.Location = new System.Drawing.Point(94, 68);
            this.txtFechaInicio.Mask = "00/00/0000";
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.Size = new System.Drawing.Size(68, 20);
            this.txtFechaInicio.TabIndex = 48;
            this.txtFechaInicio.ValidatingType = typeof(System.DateTime);
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.Enabled = false;
            this.txtFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaFin.Location = new System.Drawing.Point(94, 101);
            this.txtFechaFin.Mask = "00/00/0000";
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.Size = new System.Drawing.Size(68, 20);
            this.txtFechaFin.TabIndex = 49;
            this.txtFechaFin.ValidatingType = typeof(System.DateTime);
            // 
            // FormAltaDonacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 452);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscarCampañaDonacion);
            this.Controls.Add(this.gdrCampaña);
            this.Controls.Add(this.txtBuscarNombreCampaña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGuardarDonacion);
            this.Controls.Add(this.btnLimpiarDonacion);
            this.Controls.Add(this.txtFechaDonacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLegajoEmpleadoRecibio);
            this.Controls.Add(this.txtLegajoEmpleadoEntrego);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTipoDonacion);
            this.Controls.Add(this.label1);
            this.Name = "FormAltaDonacion";
            this.Text = "FormAltaDonacion";
            this.Load += new System.EventHandler(this.FormAltaDonacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdrCampaña)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtFechaDonacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLegajoEmpleadoRecibio;
        private System.Windows.Forms.TextBox txtLegajoEmpleadoEntrego;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoDonacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardarDonacion;
        private System.Windows.Forms.Button btnLimpiarDonacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscarNombreCampaña;
        private System.Windows.Forms.DataGridView gdrCampaña;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCampaña;
        private System.Windows.Forms.Button btnBuscarCampañaDonacion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtFechaFin;
        private System.Windows.Forms.MaskedTextBox txtFechaInicio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreCampaña;
    }
}