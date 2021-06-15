namespace TPI.Presentaciones
{
    partial class FormActualizarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormActualizarEmpleado));
            this.btnGuardarEmpleadoActualizado = new System.Windows.Forms.Button();
            this.btnLimpiarEmpleado = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbCiudades = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbBarrios = new System.Windows.Forms.ComboBox();
            this.txtNroCalleEmpleado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCalleEmpleado = new System.Windows.Forms.TextBox();
            this.txtNroTelefonoEmpleado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellidoEmpleado = new System.Windows.Forms.TextBox();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.lblCrear = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTipoDocumentoEmpleado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNroDocumentoEmpleado = new System.Windows.Forms.MaskedTextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardarEmpleadoActualizado
            // 
            this.btnGuardarEmpleadoActualizado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardarEmpleadoActualizado.BackgroundImage")));
            this.btnGuardarEmpleadoActualizado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarEmpleadoActualizado.Location = new System.Drawing.Point(395, 453);
            this.btnGuardarEmpleadoActualizado.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardarEmpleadoActualizado.Name = "btnGuardarEmpleadoActualizado";
            this.btnGuardarEmpleadoActualizado.Size = new System.Drawing.Size(46, 38);
            this.btnGuardarEmpleadoActualizado.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnGuardarEmpleadoActualizado, "Actualizar datos");
            this.btnGuardarEmpleadoActualizado.UseVisualStyleBackColor = true;
            this.btnGuardarEmpleadoActualizado.Click += new System.EventHandler(this.btnGuardarEmpleadoActualizado_Click);
            // 
            // btnLimpiarEmpleado
            // 
            this.btnLimpiarEmpleado.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpiarEmpleado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiarEmpleado.BackgroundImage")));
            this.btnLimpiarEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiarEmpleado.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpiarEmpleado.Location = new System.Drawing.Point(330, 453);
            this.btnLimpiarEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarEmpleado.Name = "btnLimpiarEmpleado";
            this.btnLimpiarEmpleado.Size = new System.Drawing.Size(46, 38);
            this.btnLimpiarEmpleado.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnLimpiarEmpleado, "Limpiar campos");
            this.btnLimpiarEmpleado.UseVisualStyleBackColor = false;
            this.btnLimpiarEmpleado.Click += new System.EventHandler(this.btnLimpiarEmpleado_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cmbCiudades);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cmbBarrios);
            this.groupBox1.Controls.Add(this.txtNroCalleEmpleado);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCalleEmpleado);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(55, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 165);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Domicilio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(87, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 24;
            this.label7.Text = "Ciudad:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(101, 92);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Calle:";
            // 
            // cmbCiudades
            // 
            this.cmbCiudades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiudades.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCiudades.FormattingEnabled = true;
            this.cmbCiudades.Location = new System.Drawing.Point(159, 29);
            this.cmbCiudades.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCiudades.Name = "cmbCiudades";
            this.cmbCiudades.Size = new System.Drawing.Size(155, 24);
            this.cmbCiudades.Sorted = true;
            this.cmbCiudades.TabIndex = 6;
            this.cmbCiudades.SelectedIndexChanged += new System.EventHandler(this.cmbCiudades_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(79, 128);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Numero:";
            // 
            // cmbBarrios
            // 
            this.cmbBarrios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBarrios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBarrios.FormattingEnabled = true;
            this.cmbBarrios.Location = new System.Drawing.Point(159, 62);
            this.cmbBarrios.Margin = new System.Windows.Forms.Padding(2);
            this.cmbBarrios.Name = "cmbBarrios";
            this.cmbBarrios.Size = new System.Drawing.Size(155, 24);
            this.cmbBarrios.Sorted = true;
            this.cmbBarrios.TabIndex = 7;
            // 
            // txtNroCalleEmpleado
            // 
            this.txtNroCalleEmpleado.Location = new System.Drawing.Point(159, 128);
            this.txtNroCalleEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.txtNroCalleEmpleado.Name = "txtNroCalleEmpleado";
            this.txtNroCalleEmpleado.Size = new System.Drawing.Size(57, 23);
            this.txtNroCalleEmpleado.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(96, 62);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Barrio:";
            // 
            // txtCalleEmpleado
            // 
            this.txtCalleEmpleado.Location = new System.Drawing.Point(159, 92);
            this.txtCalleEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.txtCalleEmpleado.Name = "txtCalleEmpleado";
            this.txtCalleEmpleado.Size = new System.Drawing.Size(126, 23);
            this.txtCalleEmpleado.TabIndex = 8;
            // 
            // txtNroTelefonoEmpleado
            // 
            this.txtNroTelefonoEmpleado.Location = new System.Drawing.Point(217, 230);
            this.txtNroTelefonoEmpleado.Name = "txtNroTelefonoEmpleado";
            this.txtNroTelefonoEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtNroTelefonoEmpleado.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 231);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Nro de telefono:";
            // 
            // txtApellidoEmpleado
            // 
            this.txtApellidoEmpleado.Location = new System.Drawing.Point(218, 117);
            this.txtApellidoEmpleado.Name = "txtApellidoEmpleado";
            this.txtApellidoEmpleado.Size = new System.Drawing.Size(189, 20);
            this.txtApellidoEmpleado.TabIndex = 2;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(218, 79);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(189, 20);
            this.txtNombreEmpleado.TabIndex = 1;
            // 
            // lblCrear
            // 
            this.lblCrear.AutoSize = true;
            this.lblCrear.BackColor = System.Drawing.Color.Transparent;
            this.lblCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrear.Location = new System.Drawing.Point(101, 22);
            this.lblCrear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCrear.Name = "lblCrear";
            this.lblCrear.Size = new System.Drawing.Size(366, 31);
            this.lblCrear.TabIndex = 36;
            this.lblCrear.Text = "Actualizar Datos Empleado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Tipo de documento:";
            // 
            // cmbTipoDocumentoEmpleado
            // 
            this.cmbTipoDocumentoEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumentoEmpleado.FormattingEnabled = true;
            this.cmbTipoDocumentoEmpleado.Location = new System.Drawing.Point(218, 156);
            this.cmbTipoDocumentoEmpleado.Name = "cmbTipoDocumentoEmpleado";
            this.cmbTipoDocumentoEmpleado.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoDocumentoEmpleado.Sorted = true;
            this.cmbTipoDocumentoEmpleado.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Nro de documento:";
            // 
            // txtNroDocumentoEmpleado
            // 
            this.txtNroDocumentoEmpleado.Enabled = false;
            this.txtNroDocumentoEmpleado.Location = new System.Drawing.Point(217, 196);
            this.txtNroDocumentoEmpleado.Mask = "99999999";
            this.txtNroDocumentoEmpleado.Name = "txtNroDocumentoEmpleado";
            this.txtNroDocumentoEmpleado.Size = new System.Drawing.Size(55, 20);
            this.txtNroDocumentoEmpleado.TabIndex = 4;
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
            this.btnVolver.TabIndex = 42;
            this.toolTip1.SetToolTip(this.btnVolver, "Volver");
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FormActualizarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::TPI.Properties.Resources.fondo_degradado_tonos_verdes_23_2148373476;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(489, 500);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnGuardarEmpleadoActualizado);
            this.Controls.Add(this.btnLimpiarEmpleado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNroTelefonoEmpleado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNroDocumentoEmpleado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTipoDocumentoEmpleado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApellidoEmpleado);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.lblCrear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormActualizarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar Datos empleado";
            this.Load += new System.EventHandler(this.FormActualizarEmpleado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarEmpleadoActualizado;
        private System.Windows.Forms.Button btnLimpiarEmpleado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbCiudades;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbBarrios;
        private System.Windows.Forms.TextBox txtNroCalleEmpleado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCalleEmpleado;
        private System.Windows.Forms.TextBox txtNroTelefonoEmpleado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellidoEmpleado;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.Label lblCrear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTipoDocumentoEmpleado;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.MaskedTextBox txtNroDocumentoEmpleado;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ToolTip toolTip3;
    }
}