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
    public partial class FormAltaEmpleado : Form
    {
        public FormAltaEmpleado()
        {
            InitializeComponent();
        }

        private void btnLimpiarEmpleado_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombreEmpleado.Text = "";
            txtApellidoEmpleado.Text = "";
            txtNroDocumentoEmpleado.Text = "";
            txtNroTelefonoEmpleado.Text = "";
            txtCalleEmpleado.Text = "";
            txtNroCalleEmpleado.Text = "";
            txtFechaIngreso.Text = "";
            cmbBarrios.SelectedIndex = -1;
            cmbCiudades.SelectedIndex = -1;
            cmbTipoDocumentoEmpleado.SelectedIndex = -1;
        }
                
        private void btnGuardarEmpleado_Click(object sender, EventArgs e)
        {
            if (cmbTipoDocumentoEmpleado.SelectedItem == null || cmbBarrios.SelectedItem == null || txtFechaIngreso.Text.Equals("") || txtNroTelefonoEmpleado.Text.Equals("") || txtApellidoEmpleado.Text.Equals("") || txtNombreEmpleado.Text.Equals("") || txtNroDocumentoEmpleado.Text.Equals("") || txtCalleEmpleado.Text.Equals("") || txtNroCalleEmpleado.Text.Equals(""))
            {
                MessageBox.Show("Faltan datos por completar");
            }
            else
            {
                string documento = txtNroDocumentoEmpleado.Text;
                Empleado emp = ObtenerDatosEmpleado();
                bool existe = AD_Empleados.ExisteDocumentoEnBD(documento);
                if (existe)
                {
                    MessageBox.Show("El numero de documento ingresado ya existe. Por favor ingrese un numero de documento distinto");
                    txtNroDocumentoEmpleado.Text = "";
                    txtNroDocumentoEmpleado.Focus();
                }
                else
                {
                    bool resultado = AD_Empleados.AgregarEmpleadoABD(emp);
                    if (resultado)
                    {
                        MessageBox.Show("Empleado registrado con exito");
                        LimpiarCampos();

                        AD_Varios.ObtenerTabla("Ciudades");
                        CargarComboTipoDocumentos();
                        CargarComboCiudades();
                        //CargarComboBarrios();
                        FormEmpleados ventana = new FormEmpleados();
                        ventana.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar empleado");
                    }
                }
            }
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

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarComboTipoDocumentos();
            CargarComboCiudades();
            //CargarComboBarrios();
        }

        private Empleado ObtenerDatosEmpleado()
        {
            Empleado emp = new Empleado();
            emp.FechaIngresoEmpleado = DateTime.Parse(txtFechaIngreso.Text);
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
            this.Hide();
        }

        private void cmbCiudades_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ciudad = cmbCiudades.SelectedIndex + 1;
            CargarComboBarrios(ciudad);
        }

        //private Empleado ObtenerEmpleado(string documento)
        //{
        //    string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
        //    SqlConnection cn = new SqlConnection(cadenaConexion);
        //    Empleado emp = new Empleado(documento);
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand();
        //        string consulta = "SELECT * FROM Empleados WHERE NroDocumento like @nroDocumento";
        //        cmd.Parameters.Clear();
        //        cmd.Parameters.AddWithValue("@NroDocumento", documento);
        //        cmd.CommandType = CommandType.Text;
        //        cmd.CommandText = consulta;

        //        cn.Open();
        //        cmd.Connection = cn;
        //        SqlDataReader dr = cmd.ExecuteReader();

        //        if (dr != null && dr.Read())
        //        {
        //            emp.DocumentoEmpleado = dr["NroDocumento"].ToString();
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        cn.Close();
        //    }

        //    return emp;
        //}
    }
}
