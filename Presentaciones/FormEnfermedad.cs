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
    public partial class FormEnfermedad : Form
    {
        public FormEnfermedad()
        {
            InitializeComponent();
            CargarGrillaNecesidad();
            gbAgregarActualizarEnfermedad.Enabled = false;

        }

        private void CargarGrillaNecesidad()
        {
            try
            {
                GrillaEnfermedades.DataSource = AD_Varios.ObtenerTabla("Enfermedades");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al Obtener Tabla");
                throw;
            }
        }

        private void LimpiarCampos()
        {
            txtEnfermedadBuscar.Text = "";
            txtNombreEnfermedad.Text = "";
            txtDescripcion.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtEnfermedadBuscar.Text.Equals(""))
            {
                MessageBox.Show("Porfavor Ingrese Nombre");

            }
            else
            {
                string Nombre = txtEnfermedadBuscar.Text;
                bool existe = AD_Enfermedad.ExisteEnfermedadEnBD(Nombre);

                if (existe)
                {
                    GrillaEnfermedades.DataSource = AD_Enfermedad.BuscarEnfermedad(Nombre);

                }
                else
                {
                    MessageBox.Show("No se encontro Ninguna Enfermedad con Ese Nombre");
                    string mensaje = "";
                    mensaje = "¿Desea registrar Nueva Enfermedad?";
                    DialogResult resultado = MessageBox.Show(mensaje, "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        gbAgregarActualizarEnfermedad.Enabled = true;
                    }
                    else
                    {
                        txtEnfermedadBuscar.Text = "";
                        txtEnfermedadBuscar.Focus();
                    }

                   
                }
            }
        }


        private Enfermedad ObtenerDatosEnfermedad()
        {
            Enfermedad enf = new Enfermedad();
            enf.NombreEnf = txtNombreEnfermedad.Text.Trim();
            enf.DescipcionEnf = txtDescripcion.Text.Trim();
            return enf;

        }

        private void btnAgregarEnfermedad_Click(object sender, EventArgs e)
        {
            gbAgregarActualizarEnfermedad.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombreEnfermedad.Text.Equals(""))
            {
                MessageBox.Show("Porfavor rellene los campos para porder realizar el alta");
            }

            else
            {
                string Nombre = txtNombreEnfermedad.Text;
                Enfermedad Enf = ObtenerDatosEnfermedad();
                bool existe = AD_Enfermedad.ExisteEnfermedadEnBD(Nombre);


                if (existe)
                {
                    MessageBox.Show("La Enfermedad ya esta cargada por favor cargue otra");

                }
                else
                {
                    bool resultado = AD_Enfermedad.AgregarEnfermedadABD(Enf);
                    if (resultado)
                    {
                        MessageBox.Show("Enfermedad registrada con exito");
                        LimpiarCampos();
                        gbAgregarActualizarEnfermedad.Enabled = false;
                        CargarGrillaNecesidad();
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar enfermedad");
                    }
                }

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnActualizarEnfermedad_Click(object sender, EventArgs e)
        {
            FormActualizarEnfermedad ventana = new FormActualizarEnfermedad();
            ventana.Show();
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormPrincipal ventana = new FormPrincipal();
            ventana.Show();
            this.Hide();
        }
    }

}