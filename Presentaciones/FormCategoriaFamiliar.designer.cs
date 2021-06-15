namespace TPI.Presentaciones
{
    partial class FormCategoriaFamiliar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategoriaFamiliar));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCategoriaFamiliar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOtro = new System.Windows.Forms.TextBox();
            this.rbOtro = new System.Windows.Forms.RadioButton();
            this.btnGuardarCategoria = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Categoria Familiar";
            // 
            // cmbCategoriaFamiliar
            // 
            this.cmbCategoriaFamiliar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoriaFamiliar.FormattingEnabled = true;
            this.cmbCategoriaFamiliar.Location = new System.Drawing.Point(225, 107);
            this.cmbCategoriaFamiliar.Name = "cmbCategoriaFamiliar";
            this.cmbCategoriaFamiliar.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoriaFamiliar.TabIndex = 1;
            this.cmbCategoriaFamiliar.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Seleccionar Categoria";
            // 
            // txtOtro
            // 
            this.txtOtro.Location = new System.Drawing.Point(225, 146);
            this.txtOtro.Name = "txtOtro";
            this.txtOtro.Size = new System.Drawing.Size(121, 20);
            this.txtOtro.TabIndex = 3;
            this.txtOtro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rbOtro
            // 
            this.rbOtro.AutoSize = true;
            this.rbOtro.BackColor = System.Drawing.Color.Transparent;
            this.rbOtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOtro.Location = new System.Drawing.Point(25, 144);
            this.rbOtro.Name = "rbOtro";
            this.rbOtro.Size = new System.Drawing.Size(194, 22);
            this.rbOtro.TabIndex = 2;
            this.rbOtro.Text = "Agregar otra categoria";
            this.rbOtro.UseVisualStyleBackColor = false;
            this.rbOtro.CheckedChanged += new System.EventHandler(this.rbOtro_CheckedChanged);
            // 
            // btnGuardarCategoria
            // 
            this.btnGuardarCategoria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardarCategoria.BackgroundImage")));
            this.btnGuardarCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuardarCategoria.Location = new System.Drawing.Point(383, 199);
            this.btnGuardarCategoria.Name = "btnGuardarCategoria";
            this.btnGuardarCategoria.Size = new System.Drawing.Size(45, 34);
            this.btnGuardarCategoria.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnGuardarCategoria, "Agregar nueva categoria familiar");
            this.btnGuardarCategoria.UseVisualStyleBackColor = true;
            this.btnGuardarCategoria.Click += new System.EventHandler(this.btnGuardarCategoria_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.BackgroundImage")));
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpiar.Location = new System.Drawing.Point(320, 199);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(45, 34);
            this.btnLimpiar.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnLimpiar, "Limpiar campos");
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FormCategoriaFamiliar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::TPI.Properties.Resources.fondo_degradado_tonos_verdes_23_2148373476;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(476, 253);
            this.Controls.Add(this.btnGuardarCategoria);
            this.Controls.Add(this.rbOtro);
            this.Controls.Add(this.txtOtro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCategoriaFamiliar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpiar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCategoriaFamiliar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categoria Familiar";
            this.Load += new System.EventHandler(this.FormCategoriaFamiliar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCategoriaFamiliar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOtro;
        private System.Windows.Forms.RadioButton rbOtro;
        private System.Windows.Forms.Button btnGuardarCategoria;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
    }
}