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
    public partial class FormEmpleados : Form
    {
        public FormEmpleados()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            txtDocumentoEmpleado.Text = "";
            txtEliminar.Text = "";
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            string documento = txtDocumentoEmpleado.Text;
            gdrEmpleados.DataSource = AD_Empleados.BuscarEmpleado(documento);
            LimpiarCampos();
        }

        //private void CargarGrillaEmpleado()
        //{
        //    string documento = txtDocumentoEmpleado.Text;

        //    try
        //    {
        //        gdrEmpleados.DataSource = AD_Empleados.BuscarEmpleado(documento);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al obtener empleado");
        //    }
        //}

        private void gdrEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminarEmpleado.Enabled = true;
        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            txtDocumentoEmpleado.Focus();
            LimpiarCampos();
            btnEliminarEmpleado.Enabled = false;
            CargarGrillaEmpleados();
        }

        public void CargarGrillaEmpleados()
        {
            try
            {
                gdrEmpleados.DataSource = AD_Empleados.ObtenerEmpleadoReducidoDocumento();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudieron cargar los empleados");
            }
        }

        private void gdrEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminarEmpleado.Enabled = true;
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            txtDocumentoEmpleado.Focus();
            string mensaje = "";
            mensaje = "¿Desea borrar el empleado de la Base de Datos?";
            DialogResult resultado = MessageBox.Show(mensaje, "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(resultado == DialogResult.Yes)
            {
                string mensaje2 = "";
                mensaje2 = "¿Esta seguro? El empleado sera eliminado definitivamente de la Base de Datos.";
                DialogResult resultado2 = MessageBox.Show(mensaje2, "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(resultado2 == DialogResult.Yes)
                {
                    string documento = txtEliminar.Text;
                    Empleado emp = ObtenerEmpleado(documento);
                    bool resultado3 = AD_Empleados.EliminarEmpleadoEnBD(emp);
                    if(resultado3 == true)
                    {
                        MessageBox.Show("Empleado borrado con exito");
                        LimpiarCampos();
                        //
                        gdrEmpleados.DataSource = AD_Empleados.BuscarEmpleado(documento);
                        txtDocumentoEmpleado.Focus();

                    }
                    else
                    {
                        MessageBox.Show("Error al borrar empleado");
                    }
                }
            }
        }

        //private Empleado ObtenerDatosEmpleado()
        //{
        //    Empleado emp = new Empleado();
        //    emp.DocumentoEmpleado = txtDocumentoEmpleado.Text;

        //    return emp;
        //}

        private Empleado ObtenerEmpleado(string documento)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Empleado emp = new Empleado();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Empleados WHERE NroDocumento LIKE @nroDocumento";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@NroDocumento", documento);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    emp.DocumentoEmpleado = dr["NroDocumento"].ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }

            return emp;
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            txtDocumentoEmpleado.Focus();
            FormAltaEmpleado ventana = new FormAltaEmpleado();
            ventana.Show();
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormPrincipal ventana = new FormPrincipal();
            ventana.Show();
            this.Hide();
        }

        private void gdrEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtDocumentoEmpleado.Focus();
                FormActualizarEmpleado ventana = new FormActualizarEmpleado();
                ventana.Show();
                this.Hide();
                FormActualizarEmpleado ventana2 = new FormActualizarEmpleado();
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name == "FormActualizarEmpleado")
                    {
                        ventana2 = (FormActualizarEmpleado)frm;
                        ventana2.txtNroDocumentoEmpleado.Text = gdrEmpleados.CurrentRow.Cells[3].Value.ToString();
                        //this.Close();
                        break;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        //private void gdrEmpleados_CellClick_2(object sender, DataGridViewCellEventArgs e)
        //{
        //    btnEliminarEmpleado.Enabled = true;
        //    int indice = e.RowIndex;
        //    //btnActualizarPersona.Enabled = true;
        //    DataGridViewRow filaSeleccionada = gdrEmpleados.Rows[indice];
        //    string documento = filaSeleccionada.Cells["NroDocumento"].Value.ToString();
        //    Empleado emp = ObtenerEmpleado(documento);
        //    LimpiarCampos();
        //    CargarCampos(emp);
        //}

        private void CargarCampos(Empleado emp)
        {
            txtEliminar.Text = emp.DocumentoEmpleado;
        }

        private void gdrEmpleados_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
                btnEliminarEmpleado.Enabled = true;
                int indice = e.RowIndex;
                //btnActualizarPersona.Enabled = true;
                DataGridViewRow filaSeleccionada = gdrEmpleados.Rows[indice];
                string documento = filaSeleccionada.Cells["NroDocumento"].Value.ToString();
                Empleado emp = ObtenerEmpleado(documento);
                LimpiarCampos();
                CargarCampos(emp);
        }
    }
}
