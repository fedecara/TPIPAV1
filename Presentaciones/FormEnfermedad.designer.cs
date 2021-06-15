namespace TPI.Presentaciones
{
    partial class FormEnfermedad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEnfermedad));
            this.lbTittle = new System.Windows.Forms.Label();
            this.GrillaEnfermedades = new System.Windows.Forms.DataGridView();
            this.IdEnfermedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEnfermedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtEnfermedadBuscar = new System.Windows.Forms.TextBox();
            this.gbAgregarActualizarEnfermedad = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombreEnfermedad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActualizarEnfermedad = new System.Windows.Forms.Button();
            this.btnAgregarEnfermedad = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaEnfermedades)).BeginInit();
            this.gbAgregarActualizarEnfermedad.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTittle
            // 
            this.lbTittle.AutoSize = true;
            this.lbTittle.BackColor = System.Drawing.Color.Transparent;
            this.lbTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTittle.ForeColor = System.Drawing.Color.Black;
            this.lbTittle.Location = new System.Drawing.Point(328, 15);
            this.lbTittle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTittle.Name = "lbTittle";
            this.lbTittle.Size = new System.Drawing.Size(202, 31);
            this.lbTittle.TabIndex = 0;
            this.lbTittle.Text = "Enfermedades";
            // 
            // GrillaEnfermedades
            // 
            this.GrillaEnfermedades.AllowUserToAddRows = false;
            this.GrillaEnfermedades.AllowUserToDeleteRows = false;
            this.GrillaEnfermedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrillaEnfermedades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEnfermedad,
            this.NombreEnfermedad,
            this.Descripcion});
            this.GrillaEnfermedades.Location = new System.Drawing.Point(35, 106);
            this.GrillaEnfermedades.Margin = new System.Windows.Forms.Padding(2);
            this.GrillaEnfermedades.Name = "GrillaEnfermedades";
            this.GrillaEnfermedades.ReadOnly = true;
            this.GrillaEnfermedades.RowHeadersWidth = 51;
            this.GrillaEnfermedades.RowTemplate.Height = 24;
            this.GrillaEnfermedades.Size = new System.Drawing.Size(358, 122);
            this.GrillaEnfermedades.TabIndex = 7;
            // 
            // IdEnfermedad
            // 
            this.IdEnfermedad.DataPropertyName = "Id_Enfermedad";
            this.IdEnfermedad.HeaderText = "Id";
            this.IdEnfermedad.MinimumWidth = 6;
            this.IdEnfermedad.Name = "IdEnfermedad";
            this.IdEnfermedad.ReadOnly = true;
            this.IdEnfermedad.Width = 125;
            // 
            // NombreEnfermedad
            // 
            this.NombreEnfermedad.DataPropertyName = "NombreEnfermedad";
            this.NombreEnfermedad.HeaderText = "Enfermedad";
            this.NombreEnfermedad.MinimumWidth = 6;
            this.NombreEnfermedad.Name = "NombreEnfermedad";
            this.NombreEnfermedad.ReadOnly = true;
            this.NombreEnfermedad.Width = 150;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 150;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.BackColor = System.Drawing.Color.Transparent;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(10, 74);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(112, 20);
            this.lbNombre.TabIndex = 9;
            this.lbNombre.Text = "Enfermedad:";
            // 
            // txtEnfermedadBuscar
            // 
            this.txtEnfermedadBuscar.Location = new System.Drawing.Point(122, 76);
            this.txtEnfermedadBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtEnfermedadBuscar.Name = "txtEnfermedadBuscar";
            this.txtEnfermedadBuscar.Size = new System.Drawing.Size(112, 20);
            this.txtEnfermedadBuscar.TabIndex = 5;
            // 
            // gbAgregarActualizarEnfermedad
            // 
            this.gbAgregarActualizarEnfermedad.BackColor = System.Drawing.Color.Transparent;
            this.gbAgregarActualizarEnfermedad.Controls.Add(this.btnGuardar);
            this.gbAgregarActualizarEnfermedad.Controls.Add(this.btnLimpiar);
            this.gbAgregarActualizarEnfermedad.Controls.Add(this.txtDescripcion);
            this.gbAgregarActualizarEnfermedad.Controls.Add(this.txtNombreEnfermedad);
            this.gbAgregarActualizarEnfermedad.Controls.Add(this.label2);
            this.gbAgregarActualizarEnfermedad.Controls.Add(this.label1);
            this.gbAgregarActualizarEnfermedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAgregarActualizarEnfermedad.Location = new System.Drawing.Point(451, 74);
            this.gbAgregarActualizarEnfermedad.Margin = new System.Windows.Forms.Padding(2);
            this.gbAgregarActualizarEnfermedad.Name = "gbAgregarActualizarEnfermedad";
            this.gbAgregarActualizarEnfermedad.Padding = new System.Windows.Forms.Padding(2);
            this.gbAgregarActualizarEnfermedad.Size = new System.Drawing.Size(315, 173);
            this.gbAgregarActualizarEnfermedad.TabIndex = 11;
            this.gbAgregarActualizarEnfermedad.TabStop = false;
            this.gbAgregarActualizarEnfermedad.Text = "Agregar Enfermedad";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Location = new System.Drawing.Point(277, 143);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(33, 26);
            this.btnGuardar.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnGuardar, "Guardar enfermedad");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.BackgroundImage")));
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpiar.Location = new System.Drawing.Point(240, 143);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(33, 27);
            this.btnLimpiar.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnLimpiar, "Eliminar enfermedad");
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Visible = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtDescripcion.Location = new System.Drawing.Point(112, 68);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(114, 82);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtNombreEnfermedad
            // 
            this.txtNombreEnfermedad.Location = new System.Drawing.Point(112, 29);
            this.txtNombreEnfermedad.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreEnfermedad.Name = "txtNombreEnfermedad";
            this.txtNombreEnfermedad.Size = new System.Drawing.Size(114, 23);
            this.txtNombreEnfermedad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enfermedad";
            // 
            // btnActualizarEnfermedad
            // 
            this.btnActualizarEnfermedad.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizarEnfermedad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizarEnfermedad.BackgroundImage")));
            this.btnActualizarEnfermedad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizarEnfermedad.ForeColor = System.Drawing.SystemColors.Control;
            this.btnActualizarEnfermedad.Location = new System.Drawing.Point(347, 69);
            this.btnActualizarEnfermedad.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizarEnfermedad.Name = "btnActualizarEnfermedad";
            this.btnActualizarEnfermedad.Size = new System.Drawing.Size(46, 28);
            this.btnActualizarEnfermedad.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnActualizarEnfermedad, "Actualizar enfermedad");
            this.btnActualizarEnfermedad.UseVisualStyleBackColor = false;
            this.btnActualizarEnfermedad.Click += new System.EventHandler(this.btnActualizarEnfermedad_Click);
            // 
            // btnAgregarEnfermedad
            // 
            this.btnAgregarEnfermedad.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarEnfermedad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarEnfermedad.BackgroundImage")));
            this.btnAgregarEnfermedad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarEnfermedad.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregarEnfermedad.Location = new System.Drawing.Point(297, 69);
            this.btnAgregarEnfermedad.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarEnfermedad.Name = "btnAgregarEnfermedad";
            this.btnAgregarEnfermedad.Size = new System.Drawing.Size(46, 28);
            this.btnAgregarEnfermedad.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnAgregarEnfermedad, "Agregar nueva enfermedad");
            this.btnAgregarEnfermedad.UseVisualStyleBackColor = false;
            this.btnAgregarEnfermedad.Click += new System.EventHandler(this.btnAgregarEnfermedad_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.Location = new System.Drawing.Point(238, 76);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(23, 20);
            this.btnBuscar.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnBuscar, "Buscar enfermedad por nombre");
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FormEnfermedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::TPI.Properties.Resources.fondo_degradado_tonos_verdes_23_2148373476;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(806, 266);
            this.Controls.Add(this.gbAgregarActualizarEnfermedad);
            this.Controls.Add(this.btnActualizarEnfermedad);
            this.Controls.Add(this.btnAgregarEnfermedad);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.txtEnfermedadBuscar);
            this.Controls.Add(this.GrillaEnfermedades);
            this.Controls.Add(this.lbTittle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormEnfermedad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enfermedad";
            ((System.ComponentModel.ISupportInitialize)(this.GrillaEnfermedades)).EndInit();
            this.gbAgregarActualizarEnfermedad.ResumeLayout(false);
            this.gbAgregarActualizarEnfermedad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTittle;
        private System.Windows.Forms.DataGridView GrillaEnfermedades;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEnfermedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEnfermedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnActualizarEnfermedad;
        private System.Windows.Forms.Button btnAgregarEnfermedad;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txtEnfermedadBuscar;
        private System.Windows.Forms.GroupBox gbAgregarActualizarEnfermedad;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombreEnfermedad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.ToolTip toolTip6;
    }
}