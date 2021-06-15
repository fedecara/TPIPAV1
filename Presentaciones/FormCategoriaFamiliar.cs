using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI.AccesoADatos;
using TPI.Clases;

namespace TPI.Presentaciones
{
    public partial class FormCategoriaFamiliar : Form
    {
        public FormCategoriaFamiliar()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            {
                int categoria = cmbCategoriaFamiliar.SelectedIndex + 1;
                cargarComboCategoria();
            }
        }

        private void cargarComboCategoria()
        {
            try
            {
                cmbCategoriaFamiliar.DataSource = AD_Varios.ObtenerTabla("Categoria_Familiar");
                cmbCategoriaFamiliar.DisplayMember = "NombreCategoriaFamiliar";
                cmbCategoriaFamiliar.ValueMember = "Id_CategoriaFamiliar";
                cmbCategoriaFamiliar.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combo Categoria Familiar");
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            txtOtro.Enabled = false;
        }

        private void limpiarCampos()
        {
            cmbCategoriaFamiliar.SelectedIndex = -1;
            txtOtro.Text = "";
            rbOtro.Checked = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (rbOtro.Checked == true)
            {
                txtOtro.Enabled = true;

            }
            else
            {
                txtOtro.Enabled = false;
            }
        }

        public static bool AgregarCategoriaABD(CategoriaFamiliar cat)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];       
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Categoria_Familiar (NombreCategoriaFamiliar) VALUES(@nombre)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre",cat.CateFamiliar);
                

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();

                cmd.Connection = cn;
                cmd.ExecuteNonQuery(); 

                resultado = true;
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }

            return resultado;

        }
        private CategoriaFamiliar  ObtenerCategoriaFamiliar()
        {
            CategoriaFamiliar cat = new CategoriaFamiliar();

            cat.CateFamiliar = txtOtro.Text.Trim();
            return cat;
        }


        private void btnGuardarCategoria_Click(object sender, EventArgs e)
        {
            if (cmbCategoriaFamiliar.Enabled == false || txtOtro.Text.Equals(""))
            {
                MessageBox.Show("Debe seleccionar una categoria");
            }
            else
            {
                CategoriaFamiliar cat = ObtenerCategoriaFamiliar();

                bool resultado = AgregarCategoriaABD(cat);
                if (resultado)
                {
                    MessageBox.Show("Categoria agregada con exito");
                    cargarComboCategoria();
                    limpiarCampos();
                    rbOtro.Checked = false;
                    txtOtro.Enabled = false;
                }
                else
                {

                    MessageBox.Show("Error al agregar la categoria");
                }
            }

        }

        private void FormCategoriaFamiliar_Load(object sender, EventArgs e)
        {
            cargarComboCategoria();
            txtOtro.Enabled = false;
        }

        private void rbOtro_CheckedChanged(object sender, EventArgs e)
        {
            txtOtro.Enabled = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormPrincipal ventana = new FormPrincipal();
            ventana.Show();
            this.Hide();
        }
    }
}