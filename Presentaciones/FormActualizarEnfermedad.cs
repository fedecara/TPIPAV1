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
    public partial class FormActualizarEnfermedad : Form
    {
        public FormActualizarEnfermedad()
        {
            InitializeComponent();
            gbActualizarEnfermedad.Enabled = false;
            CargarGrillaNecesidad();
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
                    //menaje con los botones
                }
            }
        }

        private void CargarComposEnfermedad(Enfermedad Enf)
        {
            
            txtNombreEnfermedad.Text = Enf.NombreEnf;
            txtDescripcion.Text = Enf.DescipcionEnf;
        }

        private void GrillaEnfermedades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            

            DataGridViewRow FilaSeleccionada = GrillaEnfermedades.Rows[indice];
            string Nombre = FilaSeleccionada.Cells["NombreEnfermedad"].Value.ToString();
            gbActualizarEnfermedad.Enabled = true;
            txtNombreEnfermedad.Enabled = false;
            Enfermedad Enf = AD_Enfermedad.ObtenerEnfermedad(Nombre);
            CargarComposEnfermedad(Enf);
        }
        private Enfermedad ObtenerDatosEnfermedad()
        {
            Enfermedad enf = new Enfermedad();
           
            enf.NombreEnf = txtNombreEnfermedad.Text.Trim();
            enf.DescipcionEnf = txtDescripcion.Text.Trim();
            return enf;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Enfermedad Enf = ObtenerDatosEnfermedad();
                bool resultado = AD_Enfermedad.ActualizarEnfermedadBD(Enf);
                if (resultado)
                {
                    MessageBox.Show("Enfermedad Actualizada Con Exito");
                    LimpiarCampos();
                    CargarGrillaNecesidad();
                    gbActualizarEnfermedad.Enabled = false;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("error al Actualizar Enfermedad");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
            string mensaje = "";
            mensaje = "¿Esta seguro que quiere salir de la ventana?";
            DialogResult resultado = MessageBox.Show(mensaje, "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                FormEnfermedad ventana = new FormEnfermedad();
                ventana.Show();
                this.Hide();
            }
            else
            {
                
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormEnfermedad ventana = new FormEnfermedad();
            ventana.Show();
            this.Hide();
        }
    }
}
