namespace TPI.Presentaciones
{
    partial class FormEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpleados));
            this.label1 = new System.Windows.Forms.Label();
            this.txtDocumentoEmpleado = new System.Windows.Forms.TextBox();
            this.gdrEmpleados = new System.Windows.Forms.DataGridView();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnAgregarEmpleado = new System.Windows.Forms.Button();
            this.btnBuscarEmpleado = new System.Windows.Forms.Button();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.helpProvider2 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.gdrEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Buscar empleado por numero de documento:";
            // 
            // txtDocumentoEmpleado
            // 
            this.txtDocumentoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumentoEmpleado.Location = new System.Drawing.Point(274, 65);
            this.txtDocumentoEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.txtDocumentoEmpleado.Name = "txtDocumentoEmpleado";
            this.txtDocumentoEmpleado.Size = new System.Drawing.Size(127, 21);
            this.txtDocumentoEmpleado.TabIndex = 1;
            // 
            // gdrEmpleados
            // 
            this.gdrEmpleados.AllowUserToAddRows = false;
            this.gdrEmpleados.AllowUserToDeleteRows = false;
            this.gdrEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Legajo,
            this.Nombre,
            this.Apellido,
            this.nroDocumento});
            this.gdrEmpleados.Location = new System.Drawing.Point(28, 90);
            this.gdrEmpleados.Margin = new System.Windows.Forms.Padding(2);
            this.gdrEmpleados.Name = "gdrEmpleados";
            this.gdrEmpleados.ReadOnly = true;
            this.gdrEmpleados.RowHeadersWidth = 51;
            this.gdrEmpleados.RowTemplate.Height = 24;
            this.gdrEmpleados.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gdrEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdrEmpleados.Size = new System.Drawing.Size(511, 110);
            this.gdrEmpleados.TabIndex = 3;
            this.toolTip1.SetToolTip(this.gdrEmpleados, "Grilla que contiene los datos del empleado que busco ingresando su numero de docu" +
        "mento.");
            this.gdrEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrEmpleados_CellClick_1);
            this.gdrEmpleados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdrEmpleados_CellDoubleClick);
            // 
            // Legajo
            // 
            this.Legajo.DataPropertyName = "Legajo_Empleado";
            this.Legajo.HeaderText = "Legajo";
            this.Legajo.MinimumWidth = 6;
            this.Legajo.Name = "Legajo";
            this.Legajo.ReadOnly = true;
            this.Legajo.Width = 80;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "NombreEmpleado";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 130;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "ApellidoEmpleado";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            this.Apellido.Width = 130;
            // 
            // nroDocumento
            // 
            this.nroDocumento.DataPropertyName = "NroDocumento";
            this.nroDocumento.HeaderText = "Documento";
            this.nroDocumento.MinimumWidth = 6;
            this.nroDocumento.Name = "nroDocumento";
            this.nroDocumento.ReadOnly = true;
            this.nroDocumento.Width = 130;
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminarEmpleado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarEmpleado.BackgroundImage")));
            this.btnEliminarEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarEmpleado.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(493, 11);
            this.btnEliminarEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(46, 28);
            this.btnEliminarEmpleado.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnEliminarEmpleado, "Eliminar empleado");
            this.btnEliminarEmpleado.UseVisualStyleBackColor = false;
            this.btnEliminarEmpleado.Visible = false;
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminarEmpleado_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarCampos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiarCampos.BackgroundImage")));
            this.btnLimpiarCampos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiarCampos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpiarCampos.Location = new System.Drawing.Point(449, 220);
            this.btnLimpiarCampos.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(39, 36);
            this.btnLimpiarCampos.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnLimpiarCampos, "Limpiar campos");
            this.btnLimpiarCampos.UseVisualStyleBackColor = false;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarEmpleado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarEmpleado.BackgroundImage")));
            this.btnAgregarEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarEmpleado.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(500, 220);
            this.btnAgregarEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(39, 36);
            this.btnAgregarEmpleado.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnAgregarEmpleado, "Agregar nuevo empleado");
            this.btnAgregarEmpleado.UseVisualStyleBackColor = false;
            this.btnAgregarEmpleado.Click += new System.EventHandler(this.btnAgregarEmpleado_Click);
            // 
            // btnBuscarEmpleado
            // 
            this.btnBuscarEmpleado.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscarEmpleado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarEmpleado.BackgroundImage")));
            this.btnBuscarEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscarEmpleado.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscarEmpleado.Location = new System.Drawing.Point(404, 65);
            this.btnBuscarEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
            this.btnBuscarEmpleado.Size = new System.Drawing.Size(26, 21);
            this.btnBuscarEmpleado.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnBuscarEmpleado, "Buscar empleado");
            this.btnBuscarEmpleado.UseVisualStyleBackColor = false;
            this.btnBuscarEmpleado.Click += new System.EventHandler(this.btnBuscarEmpleado_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.helpProvider1.SetHelpString(this.label3, "Seleccione, haciendo doble clic sobre la grilla,  al empleado al cual le actualiz" +
        "ara los datos.");
            this.label3.Location = new System.Drawing.Point(435, 66);
            this.label3.Name = "label3";
            this.helpProvider1.SetShowHelp(this.label3, true);
            this.label3.Size = new System.Drawing.Size(19, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "?";
            // 
            // txtEliminar
            // 
            this.txtEliminar.Enabled = false;
            this.txtEliminar.Location = new System.Drawing.Point(388, 19);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(100, 20);
            this.txtEliminar.TabIndex = 13;
            this.txtEliminar.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 31);
            this.label2.TabIndex = 14;
            this.label2.Text = "Empleado";
            // 
            // FormEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::TPI.Properties.Resources.fondo_degradado_tonos_verdes_23_2148373476;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(569, 267);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.btnEliminarEmpleado);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnAgregarEmpleado);
            this.Controls.Add(this.btnBuscarEmpleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDocumentoEmpleado);
            this.Controls.Add(this.gdrEmpleados);
            this.HelpButton = true;
            this.helpProvider1.SetHelpKeyword(this, "");
            this.helpProvider1.SetHelpString(this, "Seleccione, haciendo doble clic sobre la grilla,  al empleado al cual le actualiz" +
        "ara los datos.");
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEmpleados";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.FormEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdrEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnAgregarEmpleado;
        private System.Windows.Forms.Button btnBuscarEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDocumentoEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroDocumento;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.Button btnEliminarEmpleado;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.HelpProvider helpProvider1;
        public System.Windows.Forms.DataGridView gdrEmpleados;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.HelpProvider helpProvider2;
    }
}