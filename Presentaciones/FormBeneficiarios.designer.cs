namespace TPI.Presentaciones
{
	partial class FormBeneficiarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBeneficiarios));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCuil = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpiarDatosPersonales = new System.Windows.Forms.Button();
            this.txtFechaNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.cmbCategoriaFamiliar = new System.Windows.Forms.ComboBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLimpiarDatosDomicilio = new System.Windows.Forms.Button();
            this.cmbSituacion = new System.Windows.Forms.ComboBox();
            this.cmbBarrio = new System.Windows.Forms.ComboBox();
            this.txtNombreCalle = new System.Windows.Forms.TextBox();
            this.txtNroCalle = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLimpiarSalud = new System.Windows.Forms.Button();
            this.cmbEstadoSalud = new System.Windows.Forms.ComboBox();
            this.cmbEnfermedad = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgrBeneficiaros = new System.Windows.Forms.DataGridView();
            this.Cuil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Enfermedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoSalud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminarBeneficiario = new System.Windows.Forms.Button();
            this.btnActualizarBeneficiario = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrBeneficiaros)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtCuil);
            this.groupBox1.Controls.Add(this.btnLimpiarDatosPersonales);
            this.groupBox1.Controls.Add(this.txtFechaNacimiento);
            this.groupBox1.Controls.Add(this.cmbCategoriaFamiliar);
            this.groupBox1.Controls.Add(this.cmbSexo);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(8, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // txtCuil
            // 
            this.txtCuil.Location = new System.Drawing.Point(120, 57);
            this.txtCuil.Mask = "99-99999999-9";
            this.txtCuil.Name = "txtCuil";
            this.txtCuil.Size = new System.Drawing.Size(100, 20);
            this.txtCuil.TabIndex = 2;
            // 
            // btnLimpiarDatosPersonales
            // 
            this.btnLimpiarDatosPersonales.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarDatosPersonales.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiarDatosPersonales.BackgroundImage")));
            this.btnLimpiarDatosPersonales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiarDatosPersonales.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpiarDatosPersonales.Location = new System.Drawing.Point(258, 177);
            this.btnLimpiarDatosPersonales.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarDatosPersonales.Name = "btnLimpiarDatosPersonales";
            this.btnLimpiarDatosPersonales.Size = new System.Drawing.Size(30, 28);
            this.btnLimpiarDatosPersonales.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnLimpiarDatosPersonales, "Limpiar campos");
            this.btnLimpiarDatosPersonales.UseVisualStyleBackColor = false;
            this.btnLimpiarDatosPersonales.Click += new System.EventHandler(this.btnLimpiarDatosPersonales_Click);
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(120, 25);
            this.txtFechaNacimiento.Mask = "00/00/0000";
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(99, 20);
            this.txtFechaNacimiento.TabIndex = 1;
            this.txtFechaNacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // cmbCategoriaFamiliar
            // 
            this.cmbCategoriaFamiliar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaFamiliar.FormattingEnabled = true;
            this.cmbCategoriaFamiliar.Location = new System.Drawing.Point(120, 152);
            this.cmbCategoriaFamiliar.Name = "cmbCategoriaFamiliar";
            this.cmbCategoriaFamiliar.Size = new System.Drawing.Size(100, 21);
            this.cmbCategoriaFamiliar.TabIndex = 5;
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(120, 182);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(100, 21);
            this.cmbSexo.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(120, 116);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(120, 85);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Fecha de nacimiento:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(67, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sexo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cuil:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Categoria familiar:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Situacion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nombre de calle:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Barrio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Estado de salud:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(41, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Enfermedad:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Numero de calle:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnLimpiarDatosDomicilio);
            this.groupBox2.Controls.Add(this.cmbSituacion);
            this.groupBox2.Controls.Add(this.cmbBarrio);
            this.groupBox2.Controls.Add(this.txtNombreCalle);
            this.groupBox2.Controls.Add(this.txtNroCalle);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(8, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 161);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de domicilio";
            // 
            // btnLimpiarDatosDomicilio
            // 
            this.btnLimpiarDatosDomicilio.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarDatosDomicilio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiarDatosDomicilio.BackgroundImage")));
            this.btnLimpiarDatosDomicilio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiarDatosDomicilio.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpiarDatosDomicilio.Location = new System.Drawing.Point(258, 133);
            this.btnLimpiarDatosDomicilio.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarDatosDomicilio.Name = "btnLimpiarDatosDomicilio";
            this.btnLimpiarDatosDomicilio.Size = new System.Drawing.Size(30, 28);
            this.btnLimpiarDatosDomicilio.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnLimpiarDatosDomicilio, "Limpiar campos");
            this.btnLimpiarDatosDomicilio.UseVisualStyleBackColor = false;
            this.btnLimpiarDatosDomicilio.Click += new System.EventHandler(this.btnLimpiarDatosDomicilio_Click);
            // 
            // cmbSituacion
            // 
            this.cmbSituacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSituacion.FormattingEnabled = true;
            this.cmbSituacion.Location = new System.Drawing.Point(120, 138);
            this.cmbSituacion.Name = "cmbSituacion";
            this.cmbSituacion.Size = new System.Drawing.Size(100, 21);
            this.cmbSituacion.TabIndex = 11;
            // 
            // cmbBarrio
            // 
            this.cmbBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBarrio.FormattingEnabled = true;
            this.cmbBarrio.Location = new System.Drawing.Point(119, 106);
            this.cmbBarrio.Name = "cmbBarrio";
            this.cmbBarrio.Size = new System.Drawing.Size(100, 21);
            this.cmbBarrio.TabIndex = 10;
            // 
            // txtNombreCalle
            // 
            this.txtNombreCalle.Location = new System.Drawing.Point(120, 68);
            this.txtNombreCalle.Name = "txtNombreCalle";
            this.txtNombreCalle.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCalle.TabIndex = 9;
            // 
            // txtNroCalle
            // 
            this.txtNroCalle.Location = new System.Drawing.Point(120, 31);
            this.txtNroCalle.Name = "txtNroCalle";
            this.txtNroCalle.Size = new System.Drawing.Size(100, 20);
            this.txtNroCalle.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnLimpiarSalud);
            this.groupBox3.Controls.Add(this.cmbEstadoSalud);
            this.groupBox3.Controls.Add(this.cmbEnfermedad);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(8, 462);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(288, 102);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Salud";
            // 
            // btnLimpiarSalud
            // 
            this.btnLimpiarSalud.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpiarSalud.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiarSalud.BackgroundImage")));
            this.btnLimpiarSalud.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiarSalud.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpiarSalud.Location = new System.Drawing.Point(258, 74);
            this.btnLimpiarSalud.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarSalud.Name = "btnLimpiarSalud";
            this.btnLimpiarSalud.Size = new System.Drawing.Size(30, 28);
            this.btnLimpiarSalud.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btnLimpiarSalud, "Limpiar campos");
            this.btnLimpiarSalud.UseVisualStyleBackColor = false;
            this.btnLimpiarSalud.Click += new System.EventHandler(this.btnLimpiarSalud_Click);
            // 
            // cmbEstadoSalud
            // 
            this.cmbEstadoSalud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoSalud.FormattingEnabled = true;
            this.cmbEstadoSalud.Location = new System.Drawing.Point(119, 67);
            this.cmbEstadoSalud.Name = "cmbEstadoSalud";
            this.cmbEstadoSalud.Size = new System.Drawing.Size(100, 21);
            this.cmbEstadoSalud.TabIndex = 14;
            // 
            // cmbEnfermedad
            // 
            this.cmbEnfermedad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEnfermedad.FormattingEnabled = true;
            this.cmbEnfermedad.Location = new System.Drawing.Point(119, 31);
            this.cmbEnfermedad.Name = "cmbEnfermedad";
            this.cmbEnfermedad.Size = new System.Drawing.Size(100, 21);
            this.cmbEnfermedad.TabIndex = 13;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.dgrBeneficiaros);
            this.groupBox4.Location = new System.Drawing.Point(338, 121);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(521, 498);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Listado de beneficiaros";
            // 
            // dgrBeneficiaros
            // 
            this.dgrBeneficiaros.AllowUserToAddRows = false;
            this.dgrBeneficiaros.AllowUserToDeleteRows = false;
            this.dgrBeneficiaros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrBeneficiaros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cuil,
            this.Nombre,
            this.Apellido,
            this.Enfermedad,
            this.EstadoSalud});
            this.dgrBeneficiaros.Location = new System.Drawing.Point(0, 19);
            this.dgrBeneficiaros.Name = "dgrBeneficiaros";
            this.dgrBeneficiaros.ReadOnly = true;
            this.dgrBeneficiaros.RowHeadersWidth = 51;
            this.dgrBeneficiaros.Size = new System.Drawing.Size(509, 473);
            this.dgrBeneficiaros.TabIndex = 0;
            this.dgrBeneficiaros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrBeneficiaros_CellClick);
            // 
            // Cuil
            // 
            this.Cuil.DataPropertyName = "Cuil_Beneficiario";
            this.Cuil.HeaderText = "Cuil";
            this.Cuil.MinimumWidth = 6;
            this.Cuil.Name = "Cuil";
            this.Cuil.ReadOnly = true;
            this.Cuil.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "NombreBeneficiario";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "ApellidoBeneficiario";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 125;
            // 
            // Enfermedad
            // 
            this.Enfermedad.DataPropertyName = "Id_Enfermedad";
            this.Enfermedad.HeaderText = "Enfermedad";
            this.Enfermedad.MinimumWidth = 6;
            this.Enfermedad.Name = "Enfermedad";
            this.Enfermedad.ReadOnly = true;
            this.Enfermedad.Width = 125;
            // 
            // EstadoSalud
            // 
            this.EstadoSalud.DataPropertyName = "Id_EstadoSalud";
            this.EstadoSalud.HeaderText = "Estado";
            this.EstadoSalud.MinimumWidth = 6;
            this.EstadoSalud.Name = "EstadoSalud";
            this.EstadoSalud.ReadOnly = true;
            this.EstadoSalud.Width = 125;
            // 
            // btnEliminarBeneficiario
            // 
            this.btnEliminarBeneficiario.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminarBeneficiario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarBeneficiario.BackgroundImage")));
            this.btnEliminarBeneficiario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarBeneficiario.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminarBeneficiario.Location = new System.Drawing.Point(151, 585);
            this.btnEliminarBeneficiario.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarBeneficiario.Name = "btnEliminarBeneficiario";
            this.btnEliminarBeneficiario.Size = new System.Drawing.Size(43, 34);
            this.btnEliminarBeneficiario.TabIndex = 17;
            this.toolTip1.SetToolTip(this.btnEliminarBeneficiario, "Eliminar beneficiario");
            this.btnEliminarBeneficiario.UseVisualStyleBackColor = false;
            this.btnEliminarBeneficiario.Visible = false;
            this.btnEliminarBeneficiario.Click += new System.EventHandler(this.btnEliminarBeneficiario_Click);
            // 
            // btnActualizarBeneficiario
            // 
            this.btnActualizarBeneficiario.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizarBeneficiario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizarBeneficiario.BackgroundImage")));
            this.btnActualizarBeneficiario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizarBeneficiario.ForeColor = System.Drawing.SystemColors.Control;
            this.btnActualizarBeneficiario.Location = new System.Drawing.Point(211, 585);
            this.btnActualizarBeneficiario.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizarBeneficiario.Name = "btnActualizarBeneficiario";
            this.btnActualizarBeneficiario.Size = new System.Drawing.Size(41, 34);
            this.btnActualizarBeneficiario.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btnActualizarBeneficiario, "Actualizar beneficiario");
            this.btnActualizarBeneficiario.UseVisualStyleBackColor = false;
            this.btnActualizarBeneficiario.Click += new System.EventHandler(this.btnActualizarBeneficiario_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.Location = new System.Drawing.Point(586, 85);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(28, 23);
            this.btnBuscar.TabIndex = 19;
            this.toolTip1.SetToolTip(this.btnBuscar, "Buscar beneficiario por CUIL");
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Location = new System.Drawing.Point(266, 585);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(43, 34);
            this.btnGuardar.TabIndex = 16;
            this.toolTip1.SetToolTip(this.btnGuardar, "Guardar nuevo beneficiario");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(336, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Ingrese CUIL a ser buscado:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(482, 88);
            this.txtBuscar.Mask = "99-99999999-9";
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(84, 20);
            this.txtBuscar.TabIndex = 23;
            this.txtBuscar.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtBuscar_MaskInputRejected);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(506, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(183, 31);
            this.label14.TabIndex = 24;
            this.label14.Text = "Beneficiarios";
            // 
            // FormBeneficiarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::TPI.Properties.Resources.fondo_degradado_tonos_verdes_23_2148373476;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 635);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnEliminarBeneficiario);
            this.Controls.Add(this.btnActualizarBeneficiario);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBeneficiarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beneficiarios";
            this.Load += new System.EventHandler(this.FormBeneficiarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrBeneficiaros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cmbCategoriaFamiliar;
		private System.Windows.Forms.ComboBox cmbSexo;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox cmbSituacion;
		private System.Windows.Forms.ComboBox cmbBarrio;
		private System.Windows.Forms.TextBox txtNombreCalle;
		private System.Windows.Forms.TextBox txtNroCalle;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ComboBox cmbEstadoSalud;
		private System.Windows.Forms.ComboBox cmbEnfermedad;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.DataGridView dgrBeneficiaros;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cuil;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
		private System.Windows.Forms.DataGridViewTextBoxColumn Enfermedad;
		private System.Windows.Forms.DataGridViewTextBoxColumn EstadoSalud;
		private System.Windows.Forms.Button btnLimpiarDatosPersonales;
		private System.Windows.Forms.Button btnLimpiarDatosDomicilio;
		private System.Windows.Forms.Button btnLimpiarSalud;
		private System.Windows.Forms.Button btnEliminarBeneficiario;
		private System.Windows.Forms.Button btnActualizarBeneficiario;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.MaskedTextBox txtFechaNacimiento;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.MaskedTextBox txtCuil;
		private System.Windows.Forms.MaskedTextBox txtBuscar;
		private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip6;
    }
}