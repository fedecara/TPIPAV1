namespace TPI.Presentaciones
{
    partial class FormActualizarEnfermedad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormActualizarEnfermedad));
            this.gbActualizarEnfermedad = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombreEnfermedad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtEnfermedadBuscar = new System.Windows.Forms.TextBox();
            this.GrillaEnfermedades = new System.Windows.Forms.DataGridView();
            this.IdEnfermedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEnfermedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lbActualizarEnfermedad = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.gbActualizarEnfermedad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaEnfermedades)).BeginInit();
            this.SuspendLayout();
            // 
            // gbActualizarEnfermedad
            // 
            this.gbActualizarEnfermedad.BackColor = System.Drawing.Color.Transparent;
            this.gbActualizarEnfermedad.Controls.Add(this.btnGuardar);
            this.gbActualizarEnfermedad.Controls.Add(this.txtDescripcion);
            this.gbActualizarEnfermedad.Controls.Add(this.txtNombreEnfermedad);
            this.gbActualizarEnfermedad.Controls.Add(this.label2);
            this.gbActualizarEnfermedad.Controls.Add(this.label1);
            this.gbActualizarEnfermedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbActualizarEnfermedad.Location = new System.Drawing.Point(431, 78);
            this.gbActualizarEnfermedad.Margin = new System.Windows.Forms.Padding(2);
            this.gbActualizarEnfermedad.Name = "gbActualizarEnfermedad";
            this.gbActualizarEnfermedad.Padding = new System.Windows.Forms.Padding(2);
            this.gbActualizarEnfermedad.Size = new System.Drawing.Size(315, 191);
            this.gbActualizarEnfermedad.TabIndex = 16;
            this.gbActualizarEnfermedad.TabStop = false;
            this.gbActualizarEnfermedad.Text = "Datos Enfermedad";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardar.Location = new System.Drawing.Point(268, 146);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(34, 33);
            this.btnGuardar.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnGuardar, "Guardar");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(116, 71);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(114, 82);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtNombreEnfermedad
            // 
            this.txtNombreEnfermedad.Location = new System.Drawing.Point(116, 32);
            this.txtNombreEnfermedad.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreEnfermedad.Name = "txtNombreEnfermedad";
            this.txtNombreEnfermedad.Size = new System.Drawing.Size(114, 23);
            this.txtNombreEnfermedad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enfermedad";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.BackColor = System.Drawing.Color.Transparent;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(5, 79);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(112, 20);
            this.lbNombre.TabIndex = 15;
            this.lbNombre.Text = "Enfermedad:";
            // 
            // txtEnfermedadBuscar
            // 
            this.txtEnfermedadBuscar.Location = new System.Drawing.Point(121, 79);
            this.txtEnfermedadBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtEnfermedadBuscar.Name = "txtEnfermedadBuscar";
            this.txtEnfermedadBuscar.Size = new System.Drawing.Size(112, 20);
            this.txtEnfermedadBuscar.TabIndex = 4;
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
            this.GrillaEnfermedades.Location = new System.Drawing.Point(9, 111);
            this.GrillaEnfermedades.Margin = new System.Windows.Forms.Padding(2);
            this.GrillaEnfermedades.Name = "GrillaEnfermedades";
            this.GrillaEnfermedades.ReadOnly = true;
            this.GrillaEnfermedades.RowHeadersWidth = 51;
            this.GrillaEnfermedades.RowTemplate.Height = 24;
            this.GrillaEnfermedades.Size = new System.Drawing.Size(359, 122);
            this.GrillaEnfermedades.TabIndex = 6;
            this.GrillaEnfermedades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrillaEnfermedades_CellContentClick);
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
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.BackgroundImage")));
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpiar.Location = new System.Drawing.Point(325, 254);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(43, 38);
            this.btnLimpiar.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnLimpiar, "Limpiar campos");
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.Location = new System.Drawing.Point(237, 78);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(23, 20);
            this.btnBuscar.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnBuscar, "Buscar enfermedad por nombre");
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lbActualizarEnfermedad
            // 
            this.lbActualizarEnfermedad.AutoSize = true;
            this.lbActualizarEnfermedad.BackColor = System.Drawing.Color.Transparent;
            this.lbActualizarEnfermedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActualizarEnfermedad.ForeColor = System.Drawing.Color.Black;
            this.lbActualizarEnfermedad.Location = new System.Drawing.Point(262, 7);
            this.lbActualizarEnfermedad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbActualizarEnfermedad.Name = "lbActualizarEnfermedad";
            this.lbActualizarEnfermedad.Size = new System.Drawing.Size(309, 31);
            this.lbActualizarEnfermedad.TabIndex = 17;
            this.lbActualizarEnfermedad.Text = "Actualizar Enfermedad";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Location = new System.Drawing.Point(268, 254);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(46, 38);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.UseVisualStyleBackColor = true;
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
            this.btnVolver.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(38, 39);
            this.btnVolver.TabIndex = 18;
            this.toolTip1.SetToolTip(this.btnVolver, "Volver");
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FormActualizarEnfermedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::TPI.Properties.Resources.fondo_degradado_tonos_verdes_23_2148373476;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(770, 298);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lbActualizarEnfermedad);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.gbActualizarEnfermedad);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.txtEnfermedadBuscar);
            this.Controls.Add(this.GrillaEnfermedades);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormActualizarEnfermedad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Enfermedad";
            this.gbActualizarEnfermedad.ResumeLayout(false);
            this.gbActualizarEnfermedad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaEnfermedades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbActualizarEnfermedad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombreEnfermedad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txtEnfermedadBuscar;
        private System.Windows.Forms.DataGridView GrillaEnfermedades;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEnfermedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEnfermedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.Label lbActualizarEnfermedad;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
    }
}