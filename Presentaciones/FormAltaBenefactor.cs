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
    public partial class FormAltaBenefactor : Form
    {
        public FormAltaBenefactor()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            txtNombreBenefactor.Focus();
        }

        private void limpiarCampos()
        {
            txtNombreBenefactor.Text = "";
            txtApellidoBenefactor.Text = "";
            txtCalleBenefactor.Text = "";
            txtNumeroBenefactor.Text = "";
            cmbBarrios.SelectedIndex = -1;
            cmbCiudades.SelectedIndex = -1;
            cmbBarrios.SelectedIndex = -1;
            //txtTelefonoBenefactor.Text = "";
            //cmbTipoTelefono.SelectedIndex = -1;
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
        //private void CargarComboBarrios()
        //{
        //    string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
        //    SqlConnection cn = new SqlConnection(cadenaConexion);
        //    try
        //    {

        //        cmbBarrios.DataSource = AD_Varios.ObtenerTabla("Barrios");
        //        cmbBarrios.DisplayMember = "NombreBarrio";
        //        cmbBarrios.ValueMember = "Id_Barrio";
        //        cmbBarrios.SelectedIndex = -1;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al cargar combo barrios");
        //    }
        //}
        

        private void cargarComboCiudades()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                cmbCiudades.DataSource = AD_Varios.ObtenerTabla("Ciudades");
                cmbCiudades.DisplayMember = "NombreCiudad";
                cmbCiudades.ValueMember = "Id_Ciudad";
                cmbCiudades.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combo de ciudades");
            }
        }

        //private void CargarComboTipoTelefono()
        //{
        //    string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
        //    SqlConnection cn = new SqlConnection(cadenaConexion);
        //    try
        //    {
        //        cmbTipoTelefono.DataSource = AD_Varios.ObtenerTabla("Tipo_Telefono");
        //        cmbTipoTelefono.DisplayMember = "NombreTipoTelefono";
        //        cmbTipoTelefono.ValueMember = "Id_TipoTelefono";
        //        cmbTipoTelefono.SelectedIndex = -1;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al cargar combo de tipo de telefono");
        //    }
        //}
        private void FormAltaBenefactor_Load(object sender, EventArgs e)
        {
            limpiarCampos();
            cargarComboCiudades();
            //CargarComboTipoTelefono();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if ( cmbBarrios.SelectedItem == null || txtApellidoBenefactor.Text.Equals("") || txtCalleBenefactor.Text.Equals("") || txtNombreBenefactor.Text.Equals(""))
            {
                MessageBox.Show("Faltan datos por completar");
            }
            else
            {
                string nombre = txtNombreBenefactor.Text;
                Benefactor ben = obtenerDatosBenefactor();
                bool existe = AD_Benefactores.ExisteNombreEnBD(nombre);
                if (existe)
                {
                    MessageBox.Show("El benefactor ingresado ya existe. Por favor ingrese un benefactor que no exista");
                    txtNombreBenefactor.Text = "";
                    txtNombreBenefactor.Focus();
                }
                else
                {
                    bool resultado = AD_Benefactores.AgregarBenefactorABD(ben);
                    if (resultado)
                    {
                        MessageBox.Show("Benefactor agregado con éxito");
                        limpiarCampos();
                        cargarComboCiudades();
                        FormBenefactores ventana = new FormBenefactores();
                        ventana.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar al benefactor");
                        FormBenefactores ventana = new FormBenefactores();
                        ventana.Show();
                        this.Hide();
                    }
                }
            }
        }

        //Benefactor b = obtenerDatosBenefactor();
        //bool resultado = AD_Benefactores.AgregarBenefactorABD(b);
        //if (resultado)
        //{
        //    MessageBox.Show("Benefactor agregado con éxito");
        //    limpiarCampos();
        //    cargarComboCiudades();

        //}
        //else
        //{
        //    MessageBox.Show("Error al agregar la persona");
        //}
        //FormBenefactores ventana = new FormBenefactores();
        //ventana.Show();
        //this.Hide();
        //}

        private Benefactor obtenerDatosBenefactor()
        {
            Benefactor b = new Benefactor();
            b.NOMBREBENEFACTOR = txtNombreBenefactor.Text.Trim();
            b.APELLIDOBENEFACTOR = txtApellidoBenefactor.Text.Trim();
            b.NOMBRECALLE = txtCalleBenefactor.Text.Trim();
            b.NROCALLE = int.Parse(txtNumeroBenefactor.Text.Trim());
            b.IDBARRIO = (int)cmbBarrios.SelectedValue;
            //b.NROTELEFONOBENEFACTOR = txtTelefonoBenefactor.Text.Trim();
            //b.TIPOTELEFONO = (int)cmbTipoTelefono.SelectedValue;

            return b;
        }

        private void cmbCiudades_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ciudad = cmbCiudades.SelectedIndex +1;
            cargarComboBarrios(ciudad);
        }

        private void FormAltaBenefactor_FormClosed(object sender, FormClosedEventArgs e)
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
