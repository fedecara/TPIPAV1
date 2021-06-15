namespace TPI.Presentaciones
{
    partial class FormFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFactura));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtNombreServicio = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btbBuscarServicio = new System.Windows.Forms.Button();
            this.txtServicio = new System.Windows.Forms.TextBox();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgrDetalles = new System.Windows.Forms.DataGridView();
            this.Id_Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtNroFactura = new System.Windows.Forms.TextBox();
            this.grpBeneficiario = new System.Windows.Forms.GroupBox();
            this.txtCuilBeneficiario = new System.Windows.Forms.TextBox();
            this.txtApellidoBeneficiario = new System.Windows.Forms.TextBox();
            this.txtNombreBeneficiario = new System.Windows.Forms.TextBox();
            this.txtIdBeneficiario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgrBeneficiarios = new System.Windows.Forms.DataGridView();
            this.Id_Beneficiario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreBeneficiario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoBeneficiario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CuilBeneficiario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDetalles)).BeginInit();
            this.grpBeneficiario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrBeneficiarios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtFecha);
            this.groupBox1.Controls.Add(this.txtNroFactura);
            this.groupBox1.Controls.Add(this.grpBeneficiario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(755, 558);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nueva Factura";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCalcular);
            this.groupBox2.Controls.Add(this.txtNombreServicio);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btbBuscarServicio);
            this.groupBox2.Controls.Add(this.txtServicio);
            this.groupBox2.Controls.Add(this.txtPrecioUnitario);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dgrDetalles);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.txtPrecio);
            this.groupBox2.Controls.Add(this.txtCantidad);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(0, 295);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(744, 269);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(380, 82);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(178, 27);
            this.btnCalcular.TabIndex = 23;
            this.btnCalcular.Text = "Calcular precio total";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtNombreServicio
            // 
            this.txtNombreServicio.Enabled = false;
            this.txtNombreServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreServicio.Location = new System.Drawing.Point(380, 35);
            this.txtNombreServicio.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreServicio.Name = "txtNombreServicio";
            this.txtNombreServicio.Size = new System.Drawing.Size(165, 26);
            this.txtNombreServicio.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(206, 38);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Nombre del servicio:";
            // 
            // btbBuscarServicio
            // 
            this.btbBuscarServicio.BackgroundImage = global::TPI.Properties.Resources.Buscar;
            this.btbBuscarServicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btbBuscarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbBuscarServicio.Location = new System.Drawing.Point(135, 35);
            this.btbBuscarServicio.Margin = new System.Windows.Forms.Padding(2);
            this.btbBuscarServicio.Name = "btbBuscarServicio";
            this.btbBuscarServicio.Size = new System.Drawing.Size(32, 26);
            this.btbBuscarServicio.TabIndex = 20;
            this.btbBuscarServicio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btbBuscarServicio, "Buscar servicio");
            this.btbBuscarServicio.UseVisualStyleBackColor = true;
            this.btbBuscarServicio.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtServicio
            // 
            this.txtServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServicio.Location = new System.Drawing.Point(91, 35);
            this.txtServicio.Margin = new System.Windows.Forms.Padding(2);
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.Size = new System.Drawing.Size(40, 26);
            this.txtServicio.TabIndex = 19;
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Enabled = false;
            this.txtPrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioUnitario.Location = new System.Drawing.Point(144, 84);
            this.txtPrecioUnitario.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(56, 26);
            this.txtPrecioUnitario.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 87);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Precio unitario:";
            // 
            // dgrDetalles
            // 
            this.dgrDetalles.AllowUserToAddRows = false;
            this.dgrDetalles.AllowUserToDeleteRows = false;
            this.dgrDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Servicio,
            this.NombreServicio,
            this.Cantidad,
            this.PrecioTotal});
            this.dgrDetalles.Location = new System.Drawing.Point(22, 123);
            this.dgrDetalles.Margin = new System.Windows.Forms.Padding(2);
            this.dgrDetalles.Name = "dgrDetalles";
            this.dgrDetalles.ReadOnly = true;
            this.dgrDetalles.RowHeadersWidth = 51;
            this.dgrDetalles.RowTemplate.Height = 24;
            this.dgrDetalles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgrDetalles.Size = new System.Drawing.Size(705, 124);
            this.dgrDetalles.TabIndex = 12;
            // 
            // Id_Servicio
            // 
            this.Id_Servicio.HeaderText = "Id";
            this.Id_Servicio.MinimumWidth = 6;
            this.Id_Servicio.Name = "Id_Servicio";
            this.Id_Servicio.ReadOnly = true;
            this.Id_Servicio.Width = 125;
            // 
            // NombreServicio
            // 
            this.NombreServicio.HeaderText = "Nombre";
            this.NombreServicio.MinimumWidth = 6;
            this.NombreServicio.Name = "NombreServicio";
            this.NombreServicio.ReadOnly = true;
            this.NombreServicio.Width = 200;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 125;
            // 
            // PrecioTotal
            // 
            this.PrecioTotal.HeaderText = "Precio Total";
            this.PrecioTotal.MinimumWidth = 6;
            this.PrecioTotal.Name = "PrecioTotal";
            this.PrecioTotal.ReadOnly = true;
            this.PrecioTotal.Width = 200;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::TPI.Properties.Resources.Agregar;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(681, 20);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(46, 41);
            this.btnAgregar.TabIndex = 16;
            this.toolTip1.SetToolTip(this.btnAgregar, "Agregar a grilla");
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(565, 83);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(162, 26);
            this.txtPrecio.TabIndex = 15;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(304, 83);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(61, 26);
            this.txtCantidad.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(220, 87);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Cantidad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Servicio:";
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(418, 39);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(2);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(92, 26);
            this.txtFecha.TabIndex = 7;
            // 
            // txtNroFactura
            // 
            this.txtNroFactura.Enabled = false;
            this.txtNroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroFactura.Location = new System.Drawing.Point(194, 40);
            this.txtNroFactura.Margin = new System.Windows.Forms.Padding(2);
            this.txtNroFactura.Name = "txtNroFactura";
            this.txtNroFactura.Size = new System.Drawing.Size(119, 26);
            this.txtNroFactura.TabIndex = 6;
            // 
            // grpBeneficiario
            // 
            this.grpBeneficiario.Controls.Add(this.txtCuilBeneficiario);
            this.grpBeneficiario.Controls.Add(this.txtApellidoBeneficiario);
            this.grpBeneficiario.Controls.Add(this.txtNombreBeneficiario);
            this.grpBeneficiario.Controls.Add(this.txtIdBeneficiario);
            this.grpBeneficiario.Controls.Add(this.label6);
            this.grpBeneficiario.Controls.Add(this.label5);
            this.grpBeneficiario.Controls.Add(this.label3);
            this.grpBeneficiario.Controls.Add(this.dgrBeneficiarios);
            this.grpBeneficiario.Controls.Add(this.label4);
            this.grpBeneficiario.Location = new System.Drawing.Point(0, 87);
            this.grpBeneficiario.Margin = new System.Windows.Forms.Padding(2);
            this.grpBeneficiario.Name = "grpBeneficiario";
            this.grpBeneficiario.Padding = new System.Windows.Forms.Padding(2);
            this.grpBeneficiario.Size = new System.Drawing.Size(744, 203);
            this.grpBeneficiario.TabIndex = 5;
            this.grpBeneficiario.TabStop = false;
            this.grpBeneficiario.Text = "Beneficiario";
            // 
            // txtCuilBeneficiario
            // 
            this.txtCuilBeneficiario.Enabled = false;
            this.txtCuilBeneficiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuilBeneficiario.Location = new System.Drawing.Point(171, 31);
            this.txtCuilBeneficiario.Margin = new System.Windows.Forms.Padding(2);
            this.txtCuilBeneficiario.Name = "txtCuilBeneficiario";
            this.txtCuilBeneficiario.Size = new System.Drawing.Size(138, 26);
            this.txtCuilBeneficiario.TabIndex = 11;
            // 
            // txtApellidoBeneficiario
            // 
            this.txtApellidoBeneficiario.Enabled = false;
            this.txtApellidoBeneficiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoBeneficiario.Location = new System.Drawing.Point(608, 31);
            this.txtApellidoBeneficiario.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellidoBeneficiario.Name = "txtApellidoBeneficiario";
            this.txtApellidoBeneficiario.Size = new System.Drawing.Size(119, 26);
            this.txtApellidoBeneficiario.TabIndex = 10;
            // 
            // txtNombreBeneficiario
            // 
            this.txtNombreBeneficiario.Enabled = false;
            this.txtNombreBeneficiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreBeneficiario.Location = new System.Drawing.Point(396, 31);
            this.txtNombreBeneficiario.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreBeneficiario.Name = "txtNombreBeneficiario";
            this.txtNombreBeneficiario.Size = new System.Drawing.Size(119, 26);
            this.txtNombreBeneficiario.TabIndex = 9;
            // 
            // txtIdBeneficiario
            // 
            this.txtIdBeneficiario.Enabled = false;
            this.txtIdBeneficiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdBeneficiario.Location = new System.Drawing.Point(52, 31);
            this.txtIdBeneficiario.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdBeneficiario.Name = "txtIdBeneficiario";
            this.txtIdBeneficiario.Size = new System.Drawing.Size(56, 26);
            this.txtIdBeneficiario.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Id:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(123, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cuil:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(527, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellido:";
            // 
            // dgrBeneficiarios
            // 
            this.dgrBeneficiarios.AllowUserToAddRows = false;
            this.dgrBeneficiarios.AllowUserToDeleteRows = false;
            this.dgrBeneficiarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrBeneficiarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Beneficiario,
            this.NombreBeneficiario,
            this.ApellidoBeneficiario,
            this.CuilBeneficiario});
            this.dgrBeneficiarios.Location = new System.Drawing.Point(23, 81);
            this.dgrBeneficiarios.Margin = new System.Windows.Forms.Padding(2);
            this.dgrBeneficiarios.Name = "dgrBeneficiarios";
            this.dgrBeneficiarios.ReadOnly = true;
            this.dgrBeneficiarios.RowHeadersWidth = 51;
            this.dgrBeneficiarios.RowTemplate.Height = 24;
            this.dgrBeneficiarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgrBeneficiarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrBeneficiarios.Size = new System.Drawing.Size(705, 108);
            this.dgrBeneficiarios.TabIndex = 3;
            this.dgrBeneficiarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrBeneficiarios_CellContentClick);
            // 
            // Id_Beneficiario
            // 
            this.Id_Beneficiario.DataPropertyName = "Id_Beneficiario";
            this.Id_Beneficiario.HeaderText = "Id";
            this.Id_Beneficiario.MinimumWidth = 6;
            this.Id_Beneficiario.Name = "Id_Beneficiario";
            this.Id_Beneficiario.ReadOnly = true;
            this.Id_Beneficiario.Width = 80;
            // 
            // NombreBeneficiario
            // 
            this.NombreBeneficiario.DataPropertyName = "NombreBeneficiario";
            this.NombreBeneficiario.HeaderText = "Nombre";
            this.NombreBeneficiario.MinimumWidth = 6;
            this.NombreBeneficiario.Name = "NombreBeneficiario";
            this.NombreBeneficiario.ReadOnly = true;
            this.NombreBeneficiario.Width = 195;
            // 
            // ApellidoBeneficiario
            // 
            this.ApellidoBeneficiario.DataPropertyName = "ApellidoBeneficiario";
            this.ApellidoBeneficiario.HeaderText = "Apellido";
            this.ApellidoBeneficiario.MinimumWidth = 6;
            this.ApellidoBeneficiario.Name = "ApellidoBeneficiario";
            this.ApellidoBeneficiario.ReadOnly = true;
            this.ApellidoBeneficiario.Width = 195;
            // 
            // CuilBeneficiario
            // 
            this.CuilBeneficiario.DataPropertyName = "Cuil_Beneficiario";
            this.CuilBeneficiario.HeaderText = "Cuil";
            this.CuilBeneficiario.MinimumWidth = 6;
            this.CuilBeneficiario.Name = "CuilBeneficiario";
            this.CuilBeneficiario.ReadOnly = true;
            this.CuilBeneficiario.Width = 180;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(316, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(348, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nro de factura:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::TPI.Properties.Resources.Guardar;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(692, 579);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(46, 41);
            this.btnGuardar.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnGuardar, "Guardar factura");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FormFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TPI.Properties.Resources.fondo_degradado_tonos_verdes_23_2148373476;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(777, 624);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.FormFactura_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrDetalles)).EndInit();
            this.grpBeneficiario.ResumeLayout(false);
            this.grpBeneficiario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrBeneficiarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgrBeneficiarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBeneficiario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtNroFactura;
        private System.Windows.Forms.TextBox txtCuilBeneficiario;
        private System.Windows.Forms.TextBox txtApellidoBeneficiario;
        private System.Windows.Forms.TextBox txtNombreBeneficiario;
        private System.Windows.Forms.TextBox txtIdBeneficiario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgrDetalles;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Beneficiario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreBeneficiario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoBeneficiario;
        private System.Windows.Forms.DataGridViewTextBoxColumn CuilBeneficiario;
        private System.Windows.Forms.TextBox txtPrecioUnitario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btbBuscarServicio;
        private System.Windows.Forms.TextBox txtServicio;
        private System.Windows.Forms.TextBox txtNombreServicio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioTotal;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
    }
}