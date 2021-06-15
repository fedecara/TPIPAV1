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
    public partial class FormActualizarEmpleado : Form
    {
        public FormActualizarEmpleado()
        {
            InitializeComponent();
        }

        private void FormActualizarEmpleado_Load(object sender, EventArgs e)
        {      
            LimpiarCampos();
            //CargarComboBarrios();
            CargarComboCiudades();
            CargarComboTipoDocumentos();
        }

        private void LimpiarCampos()
        {
            txtNombreEmpleado.Text = "";
            txtApellidoEmpleado.Text = "";
            txtNroDocumentoEmpleado.Text = "";
            txtNroTelefonoEmpleado.Text = "";
            txtCalleEmpleado.Text = "";
            txtNroCalleEmpleado.Text = "";
            cmbBarrios.SelectedIndex = -1;
            cmbCiudades.SelectedIndex = -1;
            cmbTipoDocumentoEmpleado.SelectedIndex = -1;
        }

        private void btnLimpiarEmpleado_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void CargarComboBarrios(int ciudad)
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

        private void CargarComboTipoDocumentos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                cmbTipoDocumentoEmpleado.DataSource = AD_Varios.ObtenerTabla("Tipo_Documento");
                cmbTipoDocumentoEmpleado.DisplayMember = "NombreTipoDocumento";
                cmbTipoDocumentoEmpleado.ValueMember = "Id_TipoDocumento";
                cmbTipoDocumentoEmpleado.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combo Tipo de documento");
            }
        }

        private void CargarComboCiudades()
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

        private void btnGuardarEmpleadoActualizado_Click(object sender, EventArgs e)
        {
            if (cmbTipoDocumentoEmpleado.SelectedItem == null || cmbBarrios.SelectedItem == null || txtNroTelefonoEmpleado.Text.Equals("") || txtApellidoEmpleado.Text.Equals("") || txtNombreEmpleado.Text.Equals("") || txtNroDocumentoEmpleado.Text.Equals("") || txtCalleEmpleado.Text.Equals("") || txtNroCalleEmpleado.Text.Equals(""))
            {
                MessageBox.Show("Faltan datos por completar");
            }
            else
            {
                Empleado emp = ObtenerDatosEmpleado();
                bool resultado = ActualizarEmpleado(emp);
                if (resultado == true)
                {
                    MessageBox.Show("Empleado actualizado con exito");
                    LimpiarCampos();
                    //CargarComboBarrios();
                    CargarComboCiudades();
                    CargarComboTipoDocumentos();
                    FormEmpleados ventana = new FormEmpleados();
                    ventana.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar empleado");
                }
            }
        }
                
        private bool ActualizarEmpleado(Empleado emp)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Empleados SET NombreEmpleado = @nombre, ApellidoEmpleado = @apellido, Id_TipoDocumento = @idTipoDocumento, NroDocumento = @nroDocumento, NroTelefono = @nroTelefono, Id_Barrio = @idBarrio, NombreCalle = @calle, NroCalle = @nroCalle WHERE NroDocumento LIKE @nroDocumento";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", emp.NombreEmpleado);
                cmd.Parameters.AddWithValue("@apellido", emp.ApellidoEmpleado);
                cmd.Parameters.AddWithValue("@idTipoDocumento", emp.TipoDocumentoEmpleado);
                cmd.Parameters.AddWithValue("@nroDocumento", emp.DocumentoEmpleado);
                cmd.Parameters.AddWithValue("@nroTelefono", emp.TelefonoEmpleado);
                cmd.Parameters.AddWithValue("@idBarrio", emp.BarrioEmpleado);
                cmd.Parameters.AddWithValue("@calle", emp.CalleEmpleado);
                cmd.Parameters.AddWithValue("@nroCalle", emp.NroCalleEmpleado);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

            return resultado;
        }

        private Empleado ObtenerDatosEmpleado()
        {
            Empleado emp = new Empleado();
            emp.NombreEmpleado = txtNombreEmpleado.Text.Trim();
            emp.ApellidoEmpleado = txtApellidoEmpleado.Text.Trim();
            emp.TipoDocumentoEmpleado = (int)cmbTipoDocumentoEmpleado.SelectedValue;
            emp.DocumentoEmpleado = txtNroDocumentoEmpleado.Text;
            emp.TelefonoEmpleado = txtNroTelefonoEmpleado.Text;
            emp.BarrioEmpleado = (int)cmbBarrios.SelectedValue;
            emp.CalleEmpleado = txtCalleEmpleado.Text;
            emp.NroCalleEmpleado = txtNroCalleEmpleado.Text;

            return emp;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormEmpleados ventana = new FormEmpleados();
            ventana.Show();
            this.Close();
        }

        private void cmbCiudades_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ciudad = cmbCiudades.SelectedIndex + 1;
            CargarComboBarrios(ciudad);
        }
    }
}
