namespace TPI.Presentaciones
{
    partial class FormBenefactores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBenefactores));
            this.dgrBenefactores = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreBenefactor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoBenefactor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroCalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBenefactores = new System.Windows.Forms.Label();
            this.txtNombreBenefactor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregarBenefactor = new System.Windows.Forms.Button();
            this.btnActualizarBenefactor = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgrBenefactores)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrBenefactores
            // 
            this.dgrBenefactores.AllowUserToAddRows = false;
            this.dgrBenefactores.AllowUserToDeleteRows = false;
            this.dgrBenefactores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrBenefactores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NombreBenefactor,
            this.ApellidoBenefactor,
            this.NombreCalle,
            this.NroCalle,
            this.Barrio});
            this.dgrBenefactores.Location = new System.Drawing.Point(45, 128);
            this.dgrBenefactores.Margin = new System.Windows.Forms.Padding(2);
            this.dgrBenefactores.Name = "dgrBenefactores";
            this.dgrBenefactores.ReadOnly = true;
            this.dgrBenefactores.RowHeadersWidth = 51;
            this.dgrBenefactores.RowTemplate.Height = 24;
            this.dgrBenefactores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrBenefactores.Size = new System.Drawing.Size(604, 200);
            this.dgrBenefactores.TabIndex = 0;
            this.dgrBenefactores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrBenefactores_CellClick);
            this.dgrBenefactores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrBenefactores_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id_Benefactor";
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 125;
            // 
            // NombreBenefactor
            // 
            this.NombreBenefactor.DataPropertyName = "NombreBenefactor";
            this.NombreBenefactor.HeaderText = "Nombre";
            this.NombreBenefactor.MinimumWidth = 6;
            this.NombreBenefactor.Name = "NombreBenefactor";
            this.NombreBenefactor.ReadOnly = true;
            this.NombreBenefactor.Width = 125;
            // 
            // ApellidoBenefactor
            // 
            this.ApellidoBenefactor.DataPropertyName = "ApellidoBenefactor";
            this.ApellidoBenefactor.HeaderText = "Apellido";
            this.ApellidoBenefactor.MinimumWidth = 6;
            this.ApellidoBenefactor.Name = "ApellidoBenefactor";
            this.ApellidoBenefactor.ReadOnly = true;
            this.ApellidoBenefactor.Width = 125;
            // 
            // NombreCalle
            // 
            this.NombreCalle.DataPropertyName = "NombreCalle";
            this.NombreCalle.HeaderText = "Calle";
            this.NombreCalle.MinimumWidth = 6;
            this.NombreCalle.Name = "NombreCalle";
            this.NombreCalle.ReadOnly = true;
            this.NombreCalle.Width = 125;
            // 
            // NroCalle
            // 
            this.NroCalle.DataPropertyName = "NroCalle";
            this.NroCalle.HeaderText = "Nro";
            this.NroCalle.MinimumWidth = 6;
            this.NroCalle.Name = "NroCalle";
            this.NroCalle.ReadOnly = true;
            this.NroCalle.Width = 125;
            // 
            // Barrio
            // 
            this.Barrio.DataPropertyName = "Id_Barrio";
            this.Barrio.HeaderText = "Barrio";
            this.Barrio.MinimumWidth = 6;
            this.Barrio.Name = "Barrio";
            this.Barrio.ReadOnly = true;
            this.Barrio.Width = 125;
            // 
            // lblBenefactores
            // 
            this.lblBenefactores.AutoSize = true;
            this.lblBenefactores.BackColor = System.Drawing.Color.Transparent;
            this.lblBenefactores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenefactores.Location = new System.Drawing.Point(41, 69);
            this.lblBenefactores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBenefactores.Name = "lblBenefactores";
            this.lblBenefactores.Size = new System.Drawing.Size(159, 20);
            this.lblBenefactores.TabIndex = 1;
            this.lblBenefactores.Text = "Buscar Benefactor";
            // 
            // txtNombreBenefactor
            // 
            this.txtNombreBenefactor.Location = new System.Drawing.Point(121, 98);
            this.txtNombreBenefactor.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreBenefactor.Name = "txtNombreBenefactor";
            this.txtNombreBenefactor.Size = new System.Drawing.Size(127, 20);
            this.txtNombreBenefactor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.Location = new System.Drawing.Point(255, 98);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(25, 20);
            this.btnBuscar.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnBuscar, "Buscar por nombre");
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregarBenefactor
            // 
            this.btnAgregarBenefactor.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregarBenefactor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarBenefactor.BackgroundImage")));
            this.btnAgregarBenefactor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarBenefactor.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgregarBenefactor.Location = new System.Drawing.Point(478, 83);
            this.btnAgregarBenefactor.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarBenefactor.Name = "btnAgregarBenefactor";
            this.btnAgregarBenefactor.Size = new System.Drawing.Size(46, 28);
            this.btnAgregarBenefactor.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnAgregarBenefactor, "Agregar nuevo benefactor");
            this.btnAgregarBenefactor.UseVisualStyleBackColor = false;
            this.btnAgregarBenefactor.Click += new System.EventHandler(this.btnAgregarBenefactor_Click);
            // 
            // btnActualizarBenefactor
            // 
            this.btnActualizarBenefactor.BackColor = System.Drawing.SystemColors.Control;
            this.btnActualizarBenefactor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnActualizarBenefactor.BackgroundImage")));
            this.btnActualizarBenefactor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActualizarBenefactor.ForeColor = System.Drawing.SystemColors.Control;
            this.btnActualizarBenefactor.Location = new System.Drawing.Point(539, 83);
            this.btnActualizarBenefactor.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizarBenefactor.Name = "btnActualizarBenefactor";
            this.btnActualizarBenefactor.Size = new System.Drawing.Size(46, 28);
            this.btnActualizarBenefactor.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnActualizarBenefactor, "Actualizar datos de benefactor");
            this.btnActualizarBenefactor.UseVisualStyleBackColor = false;
            this.btnActualizarBenefactor.Click += new System.EventHandler(this.btnActualizarBenefactor_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.BackgroundImage")));
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpiar.Location = new System.Drawing.Point(603, 83);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(46, 28);
            this.btnLimpiar.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnLimpiar, "Limpiar el campo nombre");
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Buscar Benefactor";
            // 
            // FormBenefactores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::TPI.Properties.Resources.fondo_degradado_tonos_verdes_23_2148373476;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(687, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnActualizarBenefactor);
            this.Controls.Add(this.btnAgregarBenefactor);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreBenefactor);
            this.Controls.Add(this.lblBenefactores);
            this.Controls.Add(this.dgrBenefactores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormBenefactores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Benefactores";
            this.Load += new System.EventHandler(this.FormBenefactores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrBenefactores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBenefactores;
        private System.Windows.Forms.TextBox txtNombreBenefactor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreBenefactor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoBenefactor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroCalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barrio;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregarBenefactor;
        private System.Windows.Forms.Button btnActualizarBenefactor;
        private System.Windows.Forms.Button btnLimpiar;
        public System.Windows.Forms.DataGridView dgrBenefactores;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip5;
    }
}