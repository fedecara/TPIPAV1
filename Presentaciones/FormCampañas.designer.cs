namespace TPI.Presentaciones
{
	partial class FormCampañas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCampañas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gdrCampaña = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLemaCampaña = new System.Windows.Forms.TextBox();
            this.txtNombreCampaña = new System.Windows.Forms.TextBox();
            this.txtFechaFin = new System.Windows.Forms.MaskedTextBox();
            this.btnActualizarCampaña = new System.Windows.Forms.Button();
            this.txtFechaInicio = new System.Windows.Forms.MaskedTextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.ttGuardar = new System.Windows.Forms.ToolTip(this.components);
            this.ttLimpiar = new System.Windows.Forms.ToolTip(this.components);
            this.ttBuscar = new System.Windows.Forms.ToolTip(this.components);
            this.btnBuscar = new System.Windows.Forms.Button();
            this.ttActualizar = new System.Windows.Forms.ToolTip(this.components);
            this.btnEliminarCampaña = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ttVolver = new System.Windows.Forms.ToolTip(this.components);
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdrCampaña)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.gdrCampaña);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de campañas";
            // 
            // gdrCampaña
            // 
            this.gdrCampaña.AllowUserToAddRows = false;
            this.gdrCampaña.AllowUserToDeleteRows = false;
            this.gdrCampaña.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrCampaña.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FechaInicio,
            this.FechaFin,
            this.Nombre,
            this.Lema});
            this.gdrCampaña.Location = new System.Drawing.Point(0, 19);
            this.gdrCampaña.Name = "gdrCampaña";
            this.gdrCampaña.ReadOnly = true;
            this.gdrCampaña.RowHeadersWidth = 51;
            this.gdrCampaña.Size = new System.Drawing.Size(541, 147);
            this.gdrCampaña.TabIndex = 0;
            this.gdrCampaña.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrCampaña_CellClick);
            this.gdrCampaña.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrCampaña_CellDoubleClick_1);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id_Campaña";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // FechaInicio
            // 
            this.FechaInicio.DataPropertyName = "FechaInicio";
            this.FechaInicio.HeaderText = "Fecha de inicio";
            this.FechaInicio.MinimumWidth = 6;
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            this.FechaInicio.Width = 150;
            // 
            // FechaFin
            // 
            this.FechaFin.DataPropertyName = "FechaFin";
            this.FechaFin.HeaderText = "Fecha de fin";
            this.FechaFin.MinimumWidth = 6;
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.ReadOnly = true;
            this.FechaFin.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "NombreCampaña";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // Lema
            // 
            this.Lema.DataPropertyName = "LemaCampaña";
            this.Lema.HeaderText = "Lema";
            this.Lema.MinimumWidth = 6;
            this.Lema.Name = "Lema";
            this.Lema.ReadOnly = true;
            this.Lema.Width = 150;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtLemaCampaña);
            this.groupBox2.Controls.Add(this.txtNombreCampaña);
            this.groupBox2.Controls.Add(this.txtFechaFin);
            this.groupBox2.Controls.Add(this.btnActualizarCampaña);
            this.groupBox2.Controls.Add(this.txtFechaInicio);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Controls.Add(this.btnLimpiar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 177);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar campaña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Lema:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nombre de campaña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Fecha de fin:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Fecha de inicio: ";
            // 
            // txtLemaCampaña
            // 
            this.txtLemaCampaña.Location = new System.Drawing.Point(345, 94);
            this.txtLemaCampaña.Name = "txtLemaCampaña";
            this.txtLemaCampaña.Size = new System.Drawing.Size(100, 20);
            this.txtLemaCampaña.TabIndex = 18;
            // 
            // txtNombreCampaña
            // 
            this.txtNombreCampaña.Location = new System.Drawing.Point(140, 94);
            this.txtNombreCampaña.Name = "txtNombreCampaña";
            this.txtNombreCampaña.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCampaña.TabIndex = 17;
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.Location = new System.Drawing.Point(345, 35);
            this.txtFechaFin.Mask = "00/00/0000";
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.Size = new System.Drawing.Size(78, 20);
            this.txtFechaFin.TabIndex = 16;
            this.txtFechaFin.ValidatingType = typeof(System.DateTime);
            // 
            // btnActualizarCampaña
            // 
            this.btnActualizarCampaña.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizarCampaña.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizarCampaña.BackgroundImage")));
            this.btnActualizarCampaña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizarCampaña.ForeColor = System.Drawing.SystemColors.Control;
            this.btnActualizarCampaña.Location = new System.Drawing.Point(457, 134);
            this.btnActualizarCampaña.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizarCampaña.Name = "btnActualizarCampaña";
            this.btnActualizarCampaña.Size = new System.Drawing.Size(34, 38);
            this.btnActualizarCampaña.TabIndex = 16;
            this.ttActualizar.SetToolTip(this.btnActualizarCampaña, "Actualizar campaña");
            this.btnActualizarCampaña.UseVisualStyleBackColor = false;
            this.btnActualizarCampaña.Click += new System.EventHandler(this.btnActualizarCampaña_Click);
            // 
            // txtFechaInicio
            // 
            this.txtFechaInicio.Location = new System.Drawing.Point(140, 35);
            this.txtFechaInicio.Mask = "00/00/0000";
            this.txtFechaInicio.Name = "txtFechaInicio";
            this.txtFechaInicio.Size = new System.Drawing.Size(77, 20);
            this.txtFechaInicio.TabIndex = 15;
            this.txtFechaInicio.ValidatingType = typeof(System.DateTime);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Location = new System.Drawing.Point(495, 134);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(37, 38);
            this.btnGuardar.TabIndex = 13;
            this.ttGuardar.SetToolTip(this.btnGuardar, "Guardar");
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.BackgroundImage")));
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpiar.Location = new System.Drawing.Point(415, 134);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(38, 38);
            this.btnLimpiar.TabIndex = 14;
            this.ttLimpiar.SetToolTip(this.btnLimpiar, "Limpiar campos");
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // ttLimpiar
            // 
            this.ttLimpiar.AutoPopDelay = 5000;
            this.ttLimpiar.InitialDelay = 100;
            this.ttLimpiar.ReshowDelay = 100;
            // 
            // ttBuscar
            // 
            this.ttBuscar.AutoPopDelay = 5000;
            this.ttBuscar.InitialDelay = 100;
            this.ttBuscar.ReshowDelay = 100;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.Location = new System.Drawing.Point(293, 263);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(26, 23);
            this.btnBuscar.TabIndex = 15;
            this.ttBuscar.SetToolTip(this.btnBuscar, "Buscar campaña");
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // ttActualizar
            // 
            this.ttActualizar.AutoPopDelay = 5000;
            this.ttActualizar.InitialDelay = 100;
            this.ttActualizar.ReshowDelay = 100;
            // 
            // btnEliminarCampaña
            // 
            this.btnEliminarCampaña.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarCampaña.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarCampaña.BackgroundImage")));
            this.btnEliminarCampaña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarCampaña.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminarCampaña.Location = new System.Drawing.Point(531, 27);
            this.btnEliminarCampaña.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarCampaña.Name = "btnEliminarCampaña";
            this.btnEliminarCampaña.Size = new System.Drawing.Size(36, 28);
            this.btnEliminarCampaña.TabIndex = 8;
            this.ttActualizar.SetToolTip(this.btnEliminarCampaña, "Eliminar campaña");
            this.btnEliminarCampaña.UseVisualStyleBackColor = false;
            this.btnEliminarCampaña.Visible = false;
            this.btnEliminarCampaña.Click += new System.EventHandler(this.btnEliminarEmpleado_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(188, 265);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(100, 20);
            this.txtBusqueda.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Buscar Campaña por Nombre:";
            // 
            // ttVolver
            // 
            this.ttVolver.AutoPopDelay = 5000;
            this.ttVolver.InitialDelay = 100;
            this.ttVolver.ReshowDelay = 100;
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(427, 32);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(100, 20);
            this.txtEliminar.TabIndex = 21;
            this.txtEliminar.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(208, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 31);
            this.label6.TabIndex = 23;
            this.label6.Text = "Campañas";
            // 
            // FormCampañas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::TPI.Properties.Resources.fondo_degradado_tonos_verdes_23_2148373476;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(580, 479);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.btnEliminarCampaña);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCampañas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Campañas";
            this.Load += new System.EventHandler(this.FormCampañas_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdrCampaña)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button btnActualizarCampaña;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtLemaCampaña;
		private System.Windows.Forms.TextBox txtNombreCampaña;
		private System.Windows.Forms.MaskedTextBox txtFechaFin;
		private System.Windows.Forms.MaskedTextBox txtFechaInicio;
		private System.Windows.Forms.DataGridView gdrCampaña;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
		private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn Lema;
		private System.Windows.Forms.ToolTip ttGuardar;
		private System.Windows.Forms.ToolTip ttLimpiar;
		private System.Windows.Forms.ToolTip ttBuscar;
		private System.Windows.Forms.ToolTip ttActualizar;
		private System.Windows.Forms.TextBox txtBusqueda;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ToolTip ttVolver;
        private System.Windows.Forms.Button btnEliminarCampaña;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}