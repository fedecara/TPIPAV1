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
    public partial class FormAltaDonacion : Form
    {
        public FormAltaDonacion()
        {
            InitializeComponent();
        }

        private void btnLimpiarDonacion_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void CargarComboTipoDonacion()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                cmbTipoDonacion.DataSource = AD_Varios.ObtenerTabla("Tipo_Donacion");
                cmbTipoDonacion.DisplayMember = "NombreTipoDonacion";
                cmbTipoDonacion.ValueMember = "Id_TipoDonacion";
                cmbTipoDonacion.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combo tipo de donacion");
            }
        }

        private void FormAltaDonacion_Load(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarComboTipoDonacion();
        }

        private void btnBuscarCampañaDonacion_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscarNombreCampaña.Text;
            gdrCampaña.DataSource = AD_Donacion.BuscarCampaña(nombre);
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtBuscarNombreCampaña.Text = "";
            txtFechaDonacion.Text = "";
            txtLegajoEmpleadoEntrego.Text = "";
            txtLegajoEmpleadoRecibio.Text = "";
            txtFechaFin.Text = "";
            txtFechaInicio.Text = "";
            cmbTipoDonacion.SelectedIndex = -1;
        }

        private void CargarCampos(Donacion d)
        {
            txtBuscarNombreCampaña.Text = d.IdCampañaDonacion.ToString();
            //txtApellido.Text = p.ApellidoPersona;
            //DateTime fecha = p.FechaNacimientoPersona;
            //string dia = "";
            //string mes = "";
            //string año = "";
            //dia = fecha.Date.Day.ToString();
            //if (dia.Length == 1)
            //{
            //    dia = "0" + dia;
            //}
            //mes = fecha.Date.Month.ToString();
            //if (mes.Length == 1)
            //{
            //    mes = "0" + mes;
            //}
            //año = fecha.Date.Year.ToString();
            //txtFechaNacimiento.Text = dia + mes + año;

            //if (p.SexoPersona == 1)
            //{
            //    rdMasculino.Checked = true;
            //}
            //else if (p.SexoPersona == 2)
            //{
            //    rdFemenino.Checked = true;
            //}
            //else
            //{
            //    rdOtro.Checked = true;
            //}

            //cmbTipoDocumento.SelectedValue = p.TipoDocumentoPersona;
            //txtNumeroDocumento.Text = p.DocumentoPersona;
            //txtCalle.Text = p.CallePersona;
            //txtNumeroCasa.Text = p.NroCasaPersona.ToString();
            //if (p.SolteroPersona)
            //{
            //    chkSoltero.Checked = true;
            //}
            //else
            //{
            //    chkSoltero.Checked = false;
            //}

            //if (p.CasadoPersona)
            //{
            //    chkCasado.Checked = true;
            //}
            //else
            //{
            //    chkCasado.Checked = false;
            //}

            //if (p.HijosPersona)
            //{
            //    chkHijos.Checked = true;
            //}
            //else
            //{
            //    chkHijos.Checked = false;
            //}

            //if (p.CantidadHijosPersona > 0)
            //{
            //    txtCantidadHijos.Text = p.CantidadHijosPersona.ToString();
            //}
            //else
            //{
            //    txtCantidadHijos.Text = "";
            //}

            //cmbCarrera.SelectedValue = p.CarreraPersona;
        }

        private void gdrCampaña_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            //btnActualizarPersona.Enabled = true;
            DataGridViewRow filaSeleccionada = gdrCampaña.Rows[indice];
            string nombre = filaSeleccionada.Cells["NombreCampaña"].Value.ToString();
            //Campaña c = ObtenerCampaña(nombre);
            LimpiarCampos();
            //CargarCampos(c);
        }

        //private Campaña ObtenerCampaña(string nombre)
        //{
        //    string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
        //    SqlConnection cn = new SqlConnection(cadenaConexion);
        //    Campaña p = new Campaña();
        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand();
        //        string consulta = "SELECT * FROM personas where NumeroDocumento like @documento";
        //        cmd.Parameters.Clear();
        //        cmd.Parameters.AddWithValue("@documento", documento);
        //        cmd.CommandType = CommandType.Text;
        //        cmd.CommandText = consulta;

        //        cn.Open();
        //        cmd.Connection = cn;
        //        SqlDataReader dr = cmd.ExecuteReader();

        //        if (dr != null && dr.Read())
        //        {
        //            p.NombrePersona = dr["Nombre"].ToString();
        //            p.ApellidoPersona = dr["Apellido"].ToString();
        //            p.FechaNacimientoPersona = DateTime.Parse(dr["FechaNacimiento"].ToString());
        //            p.SexoPersona = int.Parse(dr["IdSexo"].ToString());
        //            p.TipoDocumentoPersona = int.Parse(dr["IdTipoDocumento"].ToString());
        //            p.DocumentoPersona = dr["NumeroDocumento"].ToString();
        //            p.CallePersona = dr["Calle"].ToString();
        //            p.NroCasaPersona = dr["NroCasa"].ToString();
        //            p.SolteroPersona = bool.Parse(dr["Soltero"].ToString());
        //            p.CasadoPersona = bool.Parse(dr["Casado"].ToString());
        //            p.HijosPersona = bool.Parse(dr["Hijos"].ToString());
        //            p.CantidadHijosPersona = int.Parse(dr["CantidadHijos"].ToString());
        //            p.CarreraPersona = int.Parse(dr["IdCarrera"].ToString());
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

        //    return p;
        //}
    }
}
