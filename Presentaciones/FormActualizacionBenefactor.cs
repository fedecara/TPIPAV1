using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI.AccesoADatos;
using TPI.Clases;

namespace TPI.Presentaciones
{
    public partial class FormActualizacionBenefactor : Form
    {
        private int IDBENEFACTORSELECCIONADO;
        public int id;
        public FormActualizacionBenefactor()
        {
            InitializeComponent();
        }
        //public FormActualizacionBenefactor(string nombre, string apellido , string calle , int nrocasa , int idbarrio)
        //{
        //    InitializeComponent();
        //    txtNombreBenefactor.Text = nombre;
        //    txtApellidoBenefactor.Text = apellido;
        //    txtCalleBenefactor.Text = calle;
        //    txtNumeroBenefactor.Text = nrocasa.ToString();
        //    cmbBarrios.SelectedIndex = idbarrio;
        //}
        public FormActualizacionBenefactor(int _id)
        {
            id = _id;
            InitializeComponent();
            //Benefactor b = AD_Benefactores.obtenerBenefactor(id);

            //txtNombreBenefactor.Text = b.NOMBREBENEFACTOR;
            //txtApellidoBenefactor.Text = b.APELLIDOBENEFACTOR;
            //txtCalleBenefactor.Text = b.NOMBRECALLE;
            //txtNumeroBenefactor.Text = b.NROCALLE.ToString();
            //cmbBarrios = b.IDBARRIO;
            
        }

        //public FormActualizacionBenefactor(Benefactor b)
        //{
        //    InitializeComponent();
        //    txtNombreBenefactor.Text = b.NOMBREBENEFACTOR;
        //    txtApellidoBenefactor.Text = b.APELLIDOBENEFACTOR;
        //    txtCalleBenefactor.Text = b.NOMBRECALLE;
        //    txtNumeroBenefactor.Text = b.NROCALLE.ToString();
        //    cmbBarrios.SelectedIndex = b.IDBARRIO;
            
        //}

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Benefactor b = obtenerDatosBenefactor();
            bool resultado = AD_Benefactores.actualizarBenefactor(b , id);
            if(resultado)
            {
                MessageBox.Show("El Benefactor se ha actualizado con exito");
                limpiarCampos();              
            }
            else
            {
                MessageBox.Show("Error al actualizar usuario");
            }
            FormBenefactores ven = new FormBenefactores();
            ven.Show();
            this.Hide();

        }
        private void limpiarCampos()
        {
            txtNombreBenefactor.Text = "";
            txtApellidoBenefactor.Text = "";
            txtCalleBenefactor.Text = "";
            txtNumeroBenefactor.Text = "";
            cmbCiudades.SelectedIndex = -1;
            cmbBarrios.SelectedIndex = -1;
        }
        private Benefactor obtenerDatosBenefactor()
        {
            Benefactor b = new Benefactor();
            b.NOMBREBENEFACTOR = txtNombreBenefactor.Text.Trim();
            b.APELLIDOBENEFACTOR = txtApellidoBenefactor.Text.Trim();
            b.NOMBRECALLE = txtCalleBenefactor.Text.Trim();
            b.NROCALLE = int.Parse(txtNumeroBenefactor.Text.Trim());
            b.IDBARRIO = (int)cmbBarrios.SelectedValue;

            return b;
        }

        public void FormActualizacionBenefactor_Load(object sender, EventArgs e)
        {
            cargarComboCiudades();
                        
            Benefactor b = AD_Benefactores.obtenerBenefactor(id);

            
            txtNombreBenefactor.Text = b.NOMBREBENEFACTOR;
            txtApellidoBenefactor.Text = b.APELLIDOBENEFACTOR;
            txtCalleBenefactor.Text = b.NOMBRECALLE;
            txtNumeroBenefactor.Text = b.NROCALLE.ToString();
        }
        private void cargarComboCiudades()
        {
            try
            {
                cmbCiudades.DataSource = AD_Varios.ObtenerTabla("Ciudades");
                cmbCiudades.DisplayMember = "NombreCiudad";
                cmbCiudades.ValueMember = "Id_Ciudad";
                cmbCiudades.SelectedIndex = -1;
                //int ciudad = cmbCiudades.SelectedIndex;
                //cargarComboBarrios(ciudad);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combo Ciudad");
            }

        }
        private void cargarComboBarrios(int ciudad)
        {
            try
            {
                //int c = ciudad;
                cmbBarrios.DataSource = AD_Benefactores.ObtenerBarrios(ciudad);
                cmbBarrios.DisplayMember = "NombreBarrio";
                cmbBarrios.ValueMember = "Id_Barrio";
                cmbBarrios.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combo Barrio");
            }

        }


        private void cmbCiudades_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int ciudad = cmbCiudades.SelectedIndex + 1;
            cargarComboBarrios(ciudad);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            cargarComboCiudades();
        }

        private void FormActualizacionBenefactor_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormBenefactores ventana = new FormBenefactores();
            ventana.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormBenefactores ventana = new FormBenefactores();
            ventana.Show();
            this.Hide();
        }
    }
}
