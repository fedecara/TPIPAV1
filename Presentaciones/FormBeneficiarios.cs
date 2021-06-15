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
	public partial class FormBeneficiarios : Form
	{
		public FormBeneficiarios()
		{
			InitializeComponent();
			btnEliminarBeneficiario.Enabled = false;
		}
		private void LimpiarCamposDatosPersonales()
		{
			txtFechaNacimiento.Text = "";
			txtCuil.Text = "";
			txtNombre.Text = "";
			txtApellido.Text = "";
			cmbCategoriaFamiliar.SelectedIndex = -1;
			cmbSexo.SelectedIndex = -1;
		}
		private void LimpiarDatosDomicilio()
		{
			txtNroCalle.Text = "";
			txtNombreCalle.Text = "";
			cmbBarrio.SelectedIndex = -1;
			cmbSituacion.SelectedIndex = -1;
		}

		private void btnLimpiarDatosPersonales_Click(object sender, EventArgs e)
		{
			LimpiarCamposDatosPersonales();
			
		}

		private void btnLimpiarDatosDomicilio_Click(object sender, EventArgs e)
		{
			LimpiarDatosDomicilio();
		}

		private void btnLimpiarSalud_Click(object sender, EventArgs e)
		{
			cmbEnfermedad.SelectedIndex = -1;
			cmbEstadoSalud.SelectedIndex = -1;
		}


		private void FormBeneficiarios_Load(object sender, EventArgs e)
		{
			cargarGrillaBeneficiarios();
			CargarCombos();
			txtFechaNacimiento.Focus();
			btnActualizarBeneficiario.Enabled = false;

		}
		public void cargarGrillaBeneficiarios()
		{
			try
			{
				dgrBeneficiaros.DataSource = AD_Beneficiarios.obtenerListadoBeneficiarios();
			}
			catch (Exception)
			{

				MessageBox.Show("Error al obtener benefactores");
			}
		}

		private void CargarComboCategoria()
		{
			string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
			SqlConnection cn = new SqlConnection(cadenaConexion);
			try
			{
				cmbCategoriaFamiliar.DataSource = AD_Varios.ObtenerTabla("Categoria_Familiar");
				cmbCategoriaFamiliar.DisplayMember = "NombreCategoriaFamiliar";
				cmbCategoriaFamiliar.ValueMember = "Id_CategoriaFamiliar";
				cmbCategoriaFamiliar.SelectedIndex = -1;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar categorias");
			}
		}
		private void CargarComboSexo()
		{
			string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
			SqlConnection cn = new SqlConnection(cadenaConexion);
			try
			{
				cmbSexo.DataSource = AD_Varios.ObtenerTabla("Sexos");
				cmbSexo.DisplayMember = "NombreSexo";
				cmbSexo.ValueMember = "Id_Sexo";
				cmbSexo.SelectedIndex = -1;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar sexos");
			}
		}
		private void CargarComboBarrio()
		{
			string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
			SqlConnection cn = new SqlConnection(cadenaConexion);
			try
			{
				cmbBarrio.DataSource = AD_Varios.ObtenerTabla("Barrios");
				cmbBarrio.DisplayMember = "NombreBarrio";
				cmbBarrio.ValueMember = "Id_Barrio";
				cmbBarrio.SelectedIndex = -1;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar barrios");
			}
		}
		private void CargarComboSituacion()
		{
			string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
			SqlConnection cn = new SqlConnection(cadenaConexion);
			try
			{
				cmbSituacion.DataSource = AD_Varios.ObtenerTabla("Tipo_Situacion");
				cmbSituacion.DisplayMember = "NombreTipoSituacion";
				cmbSituacion.ValueMember = "Id_TipoSituacion";
				cmbSituacion.SelectedIndex = -1;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar categorias");
			}
		}
		private void CargarComboEnfermedad()
		{
			string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
			SqlConnection cn = new SqlConnection(cadenaConexion);
			try
			{
				cmbEnfermedad.DataSource = AD_Varios.ObtenerTabla("Enfermedades");
				cmbEnfermedad.DisplayMember = "NombreEnfermedad";
				cmbEnfermedad.ValueMember = "Id_Enfermedad";
				cmbEnfermedad.SelectedIndex = -1;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar enfermedades");
			}
		}
		private void CargarComboEstadoSalud()
		{
			string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
			SqlConnection cn = new SqlConnection(cadenaConexion);
			try
			{
				cmbEstadoSalud.DataSource = AD_Varios.ObtenerTabla("Estado_Salud");
				cmbEstadoSalud.DisplayMember = "Nombre";
				cmbEstadoSalud.ValueMember = "Id_EstadoSalud";
				cmbEstadoSalud.SelectedIndex = -1;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar estados de salud");
			}
		}

		private Beneficiario ObtenerDatosBeneficiario()
		{
			Beneficiario bene = new Beneficiario();
			bene.Fecha = DateTime.Parse(txtFechaNacimiento.Text);
			bene.Cuil = txtCuil.Text;
			bene.Nombre = txtNombre.Text;
			bene.Apellido = txtApellido.Text;
			bene.Categoria = (int)cmbCategoriaFamiliar.SelectedValue;
			bene.Sexo = (int)cmbSexo.SelectedValue;
			bene.NumCalle = int.Parse(txtNroCalle.Text);
			bene.NombreCalle = txtNombreCalle.Text;
			bene.Barrio = (int)cmbBarrio.SelectedValue;
			bene.Situacion = (int)cmbSituacion.SelectedValue;
			bene.Enfermedad = (int)cmbEnfermedad.SelectedValue;
			bene.Estado = (int)cmbEstadoSalud.SelectedValue;
			return bene;
		}
		private void btnGuardar_Click(object sender, EventArgs e)
		{
			string cuil = txtCuil.Text;
			if (txtCuil.Text.Equals("") || txtFechaNacimiento.Text.Equals("") || txtNombre.Text.Equals("") || txtApellido.Text.Equals("") || cmbCategoriaFamiliar.SelectedIndex == -1 || cmbSexo.SelectedIndex == -1 || txtNombreCalle.Text.Equals("")|| txtNroCalle.Text.Equals("")||cmbBarrio.SelectedIndex == -1|| cmbSituacion.SelectedIndex == -1 || cmbEnfermedad.SelectedIndex == -1 || cmbEstadoSalud.SelectedIndex == -1)
			{
				MessageBox.Show("El ingreso de todos los datos es de carácter OBLIGATORIO...Ingrese nuevamente los datos");
			}
			else
			{
				bool resultados = AD_Beneficiarios.ExisteBeneficiarioEnBD(cuil);
				if (resultados)
				{
					MessageBox.Show("ERROR! El cuil ya existe en la base de datos!!");
					LimpiarCamposDatosPersonales();
					LimpiarDatosDomicilio();
					cmbEnfermedad.SelectedIndex = -1;
					cmbEstadoSalud.SelectedIndex = -1;
					cargarGrillaBeneficiarios();
				}
				else
				{
					Beneficiario benef = ObtenerDatosBeneficiario();
					bool resultado = AD_Beneficiarios.AgregarBeneficiarioABD(benef);
					if (resultado)
					{
						MessageBox.Show("Beneficiario agregado con éxito!");
						cargarGrillaBeneficiarios();
						CargarCombos();
						LimpiarCamposDatosPersonales();
						LimpiarDatosDomicilio();
						cmbEnfermedad.SelectedIndex = -1;
						cmbEstadoSalud.SelectedIndex = -1;
					}
					else
					{
						MessageBox.Show("Error al agregar beneficiario");
					}
				}
			
			}
			
		}

		private void CargarCombos()
		{
			CargarComboCategoria();
			CargarComboSexo();
			CargarComboBarrio();
			CargarComboSituacion();
			CargarComboEnfermedad();
			CargarComboEstadoSalud();
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			btnGuardar.Enabled = false;
			string cuil = txtBuscar.Text;
			dgrBeneficiaros.DataSource = AD_Beneficiarios.buscarBeneficiario(cuil);
		}

		private void dgrBeneficiaros_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			btnActualizarBeneficiario.Enabled = true;
			btnGuardar.Enabled = false;
			int indice = e.RowIndex;
			DataGridViewRow filaSeleccionada = dgrBeneficiaros.Rows[indice];
			string cuil = filaSeleccionada.Cells["Cuil"].Value.ToString();
			Beneficiario bene = ObtenerBeneficiarioActualizado(cuil);
			CargarCamposBene(bene);
			
		}
		private void CargarCamposBene(Beneficiario b)
		{
			DateTime fechaNac = b.Fecha;
			//txtFechaInicio.Text = ca.FechaIni.Date.ToShortDateString();
			//txtFechaFin.Text = ca.FechaFin.Date.ToShortDateString();

			string dia1 = "";
			string mes1 = "";
			string año1 = "";

			dia1 = fechaNac.Date.Day.ToString();
			if (dia1.Length == 1)
			{
				dia1 = "0" + dia1;
			}
			mes1 = fechaNac.Date.Month.ToString();
			if (mes1.Length == 1)
			{
				mes1 = "0" + mes1;
			}
			año1 = fechaNac.Date.Year.ToString();
			txtFechaNacimiento.Text = dia1 + mes1 + año1;

			txtCuil.Text = b.Cuil;
			txtNombre.Text = b.Nombre;
			txtApellido.Text = b.Apellido;
			cmbCategoriaFamiliar.SelectedValue = b.Categoria;
			cmbSexo.SelectedValue = b.Sexo;
			txtNroCalle.Text = b.NumCalle.ToString();
			txtNombreCalle.Text = b.NombreCalle;
			cmbBarrio.SelectedValue = b.Barrio;
			cmbSituacion.SelectedValue = b.Situacion;
			cmbEnfermedad.SelectedValue = b.Enfermedad;
			cmbEstadoSalud.SelectedValue = b.Estado;
		}

		private Beneficiario ObtenerBeneficiarioActualizado(string cuil)
		{
			string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
			SqlConnection cn = new SqlConnection(cadenaConexion);
			Beneficiario b = new Beneficiario();
			try
			{
				SqlCommand cmd = new SqlCommand();
				string consulta = "SELECT * FROM Beneficiarios WHERE Cuil_Beneficiario LIKE @cuil";
				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@cuil", cuil);
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = consulta;

				cn.Open();
				cmd.Connection = cn;
				SqlDataReader dr = cmd.ExecuteReader();
				if (dr != null && dr.Read())
				{
					b.Cuil = dr["Cuil_Beneficiario"].ToString();
					b.Nombre = dr["NombreBeneficiario"].ToString();
					b.Apellido = dr["ApellidoBeneficiario"].ToString();
					b.Sexo = int.Parse(dr["Id_Sexo"].ToString());
					b.Fecha = DateTime.Parse(dr["Fecha_Nacimiento"].ToString());
					b.Situacion = int.Parse(dr["Id_Situacion"].ToString());
					b.Enfermedad = int.Parse(dr["Id_Enfermedad"].ToString());
					b.NumCalle = int.Parse(dr["NroCalle"].ToString());
					b.NombreCalle = dr["NombreCalle"].ToString();
					b.Barrio = int.Parse(dr["Id_Barrio"].ToString());
					b.Categoria = int.Parse(dr["Id_CategoriaFamiliar"].ToString());
					b.Estado = int.Parse(dr["Id_EstadoSalud"].ToString());

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
			return b;

			
		}

		private void btnActualizarBeneficiario_Click(object sender, EventArgs e)
		{
			txtCuil.Enabled = false;
			Beneficiario bene = ObtenerDatosBeneficiario();
			bool resultado = AD_Beneficiarios.ActualizarBeneficiarioABD(bene);
			if (resultado)
			{
				MessageBox.Show("Beneficiario actualizado con éxito!");
				LimpiarCamposDatosPersonales();
				LimpiarDatosDomicilio();
				cmbEnfermedad.SelectedIndex = -1;
				cmbEstadoSalud.SelectedIndex = -1;
				cargarGrillaBeneficiarios();
			}
			else
			{
				MessageBox.Show("No se pudo actualizar el beneficiario!");
			}
		}

		private void btnEliminarBeneficiario_Click(object sender, EventArgs e)
		{
			txtBuscar.Focus();
			string mensaje = "";
			mensaje = "¿Desea borrar la campaña de la Base de Datos?";
			DialogResult resultado = MessageBox.Show(mensaje, "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (resultado == DialogResult.Yes)
			{
				string mensaje2 = "";
				mensaje2 = "¿Esta seguro? La campaña sera eliminada definitivamente de la Base de Datos.";
				DialogResult resultado2 = MessageBox.Show(mensaje2, "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (resultado2 == DialogResult.Yes)
				{
					Beneficiario bene = ObtenerDatosBeneficiario();
					bool resultado3 = AD_Beneficiarios.EliminarBeneficiarioEnBD(bene);
					if (resultado3 == true)
					{
						MessageBox.Show("Campaña borrada con exito");
						LimpiarCamposDatosPersonales();
						LimpiarDatosDomicilio();
						cmbEnfermedad.SelectedIndex = -1;
						cmbEstadoSalud.SelectedIndex = -1;
						cargarGrillaBeneficiarios();

					}
					else
					{
						MessageBox.Show("Error al borrar campaña");
					}
				}
			}
		}

		private void btnVolver_Click(object sender, EventArgs e)
		{
			FormPrincipal ventana = new FormPrincipal();
			ventana.Show();
			this.Hide();
		}

		private void txtBuscar_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{

		}
	}
}
