namespace tp_Carabelli_Farias_Federico
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LbTittle = new System.Windows.Forms.Label();
            this.LbMarca = new System.Windows.Forms.Label();
            this.LbNombre = new System.Windows.Forms.Label();
            this.CmbMarca = new System.Windows.Forms.ComboBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.GdrAuto = new System.Windows.Forms.DataGridView();
            this.IdMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GdrAuto)).BeginInit();
            this.SuspendLayout();
            // 
            // LbTittle
            // 
            this.LbTittle.AutoSize = true;
            this.LbTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTittle.Location = new System.Drawing.Point(227, 30);
            this.LbTittle.Name = "LbTittle";
            this.LbTittle.Size = new System.Drawing.Size(315, 29);
            this.LbTittle.TabIndex = 0;
            this.LbTittle.Text = "Alta de Nuevo Automovil";
            // 
            // LbMarca
            // 
            this.LbMarca.AutoSize = true;
            this.LbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMarca.Location = new System.Drawing.Point(153, 112);
            this.LbMarca.Name = "LbMarca";
            this.LbMarca.Size = new System.Drawing.Size(56, 20);
            this.LbMarca.TabIndex = 1;
            this.LbMarca.Text = "Marca";
            // 
            // LbNombre
            // 
            this.LbNombre.AutoSize = true;
            this.LbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNombre.Location = new System.Drawing.Point(153, 164);
            this.LbNombre.Name = "LbNombre";
            this.LbNombre.Size = new System.Drawing.Size(68, 20);
            this.LbNombre.TabIndex = 2;
            this.LbNombre.Text = "Nombre";
            // 
            // CmbMarca
            // 
            this.CmbMarca.FormattingEnabled = true;
            this.CmbMarca.Location = new System.Drawing.Point(232, 112);
            this.CmbMarca.Name = "CmbMarca";
            this.CmbMarca.Size = new System.Drawing.Size(157, 24);
            this.CmbMarca.TabIndex = 3;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(232, 164);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(163, 22);
            this.TxtNombre.TabIndex = 4;
            // 
            // GdrAuto
            // 
            this.GdrAuto.AllowUserToAddRows = false;
            this.GdrAuto.AllowUserToDeleteRows = false;
            this.GdrAuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GdrAuto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMarca,
            this.NombreMarca});
            this.GdrAuto.Location = new System.Drawing.Point(157, 242);
            this.GdrAuto.Name = "GdrAuto";
            this.GdrAuto.ReadOnly = true;
            this.GdrAuto.RowHeadersWidth = 51;
            this.GdrAuto.RowTemplate.Height = 24;
            this.GdrAuto.Size = new System.Drawing.Size(479, 150);
            this.GdrAuto.TabIndex = 5;
            // 
            // IdMarca
            // 
            this.IdMarca.DataPropertyName = "IdMarca";
            this.IdMarca.HeaderText = "Id";
            this.IdMarca.MinimumWidth = 6;
            this.IdMarca.Name = "IdMarca";
            this.IdMarca.ReadOnly = true;
            this.IdMarca.Width = 125;
            // 
            // NombreMarca
            // 
            this.NombreMarca.DataPropertyName = "Nombre";
            this.NombreMarca.HeaderText = "Nombre";
            this.NombreMarca.MinimumWidth = 6;
            this.NombreMarca.Name = "NombreMarca";
            this.NombreMarca.ReadOnly = true;
            this.NombreMarca.Width = 300;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(498, 138);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(98, 46);
            this.BtnGuardar.TabIndex = 6;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.GdrAuto);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.CmbMarca);
            this.Controls.Add(this.LbNombre);
            this.Controls.Add(this.LbMarca);
            this.Controls.Add(this.LbTittle);
            this.Name = "Form1";
            this.Text = "Automovil";
            ((System.ComponentModel.ISupportInitialize)(this.GdrAuto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbTittle;
        private System.Windows.Forms.Label LbMarca;
        private System.Windows.Forms.Label LbNombre;
        private System.Windows.Forms.ComboBox CmbMarca;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.DataGridView GdrAuto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMarca;
        private System.Windows.Forms.Button BtnGuardar;
    }
}

