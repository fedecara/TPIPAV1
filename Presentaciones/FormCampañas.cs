using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI.AccesoADatos;
using TPI.Clases;

namespace TPI.Presentaciones
{
	public partial class FormCampañas : Form
	{
		public FormCampañas()
		{
			InitializeComponent();
		}

		private void FormCampañas_Load(object sender, EventArgs e)
		{
			btnEliminarCampaña.Enabled = false;
			btnActualizarCampaña.Enabled = false;
			LimpiarCampos();
			CargarGrillaCampañas();
			//gdrCampaña.Enabled = false;
		}

		private void LimpiarCampos()
		{
			txtFechaFin.Text = "";
			txtFechaInicio.Text = "";
			txtNombreCampaña.Text = "";
			txtLemaCampaña.Text = "";
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			LimpiarCampos();
			txtFechaInicio.Enabled = true;
			btnActualizarCampaña.Enabled = false;
			btnGuardar.Enabled = true;
		}

		public void CargarGrillaCampañas()
		{
			try
			{
				gdrCampaña.DataSource = AD_Campañas.ObtenerCampañas();
			}
			catch (Exception)
			{
				MessageBox.Show("No se pudieron cargar las campañas!!!");
			}
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			DateTime fechaDesde = DateTime.Parse(txtFechaInicio.Text);
			DateTime fechaHasta = DateTime.Parse(txtFechaFin.Text);

			if ((fechaDesde > fechaHasta) || (txtNombreCampaña.Text == "" || txtFechaInicio.Text == "" || txtFechaFin.Text == ""))
			{
				MessageBox.Show("Datos mal ingresados. Ingrese nuevamente");
				LimpiarCampos();
				txtFechaInicio.Focus();
			}
			else
			{
				string nombre = txtNombreCampaña.Text;
				Campaña camp = ObtenerDatosCampaña();
				bool existe = AD_Campañas.ExisteCampañaEnBD(nombre);
				if (existe)
				{
					MessageBox.Show("El nombre ingresado ya existe. Por favor ingrese un nombre distinto");
					txtNombreCampaña.Text = "";
					txtNombreCampaña.Focus();
				}
				else
				{
					bool resultado = AD_Campañas.AgregarCampañaABD(camp);
					if (resultado)
					{
						MessageBox.Show("Campaña agregada con éxito!");
						LimpiarCampos();
						CargarGrillaCampañas();
					}
					else
					{
						MessageBox.Show("No se pudo agregar la campaña!");
					}
				}
			}
		}

		private Campaña ObtenerDatosCampaña()
		{
			Campaña camp = new Campaña();
			camp.FechaIni = DateTime.Parse(txtFechaInicio.Text);
			camp.FechaFin = DateTime.Parse(txtFechaFin.Text);
			camp.Nombre = txtNombreCampaña.Text;
			camp.Lema = txtLemaCampaña.Text;

			return camp;
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			//string nombre = txtBusqueda.Text;
			//gdrCampaña.DataSource = BuscarCampañaReducido(nombre);
			btnGuardar.Enabled = false;
			btnActualizarCampaña.Enabled = false;
			if (txtBusqueda.Text.Equals(""))
			{
				MessageBox.Show("Ingrese algun nombre");
			}
			else
			{
				string nombre = txtBusqueda.Text;
				if (txtBusqueda.Text.Equals(""))
				{
					MessageBox.Show("Debe ingresar el nombre de la campaña!");
					btnBuscar.Focus();
					txtBusqueda.Text = "";
				}
				else
				{
					gdrCampaña.DataSource = AD_Campañas.buscarCampaña(nombre);
					btnActualizarCampaña.Enabled = false;
					//gdrCampaña.Enabled = true;
				}
			}
		}
		
		private void gdrCampaña_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			btnGuardar.Enabled = false;
			btnActualizarCampaña.Enabled = true;
			int indice = e.RowIndex;
			DataGridViewRow filaSeleccionada = gdrCampaña.Rows[indice];
			string nombre = filaSeleccionada.Cells["Nombre"].Value.ToString();
			Campaña cam = ObtenerCampañaActualizada(nombre);
			LimpiarCampos();
			CargarCamposAct(cam);
			btnEliminarCampaña.Enabled = true;
			txtFechaInicio.Enabled = false;
		}

		private Campaña ObtenerCampañaActualizada(string nombre)
		{
			string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
			SqlConnection cn = new SqlConnection(cadenaConexion);
			Campaña c = new Campaña();
			try
			{
				SqlCommand cmd = new SqlCommand();
				string consulta = $"SELECT * FROM Campañas WHERE NombreCampaña LIKE '{nombre}%'";
				cmd.Parameters.Clear();
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = consulta;

				cn.Open();
				cmd.Connection = cn;
				SqlDataReader dr = cmd.ExecuteReader();

				if (dr != null && dr.Read())
				{
					c.FechaIni = DateTime.Parse(dr["FechaInicio"].ToString());
					c.FechaFin = DateTime.Parse(dr["FechaFin"].ToString());
					c.Nombre = dr["NombreCampaña"].ToString();
					c.Lema = dr["LemaCampaña"].ToString();
					c.IdCampaña = int.Parse(dr["Id_Campaña"].ToString());
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

			return c;
		}

		private void CargarCamposAct(Campaña ca)
		{
			DateTime fechaInicio = ca.FechaIni;
			//txtFechaInicio.Text = ca.FechaIni.Date.ToShortDateString();
			//txtFechaFin.Text = ca.FechaFin.Date.ToShortDateString();
			txtNombreCampaña.Text = ca.Nombre;
			txtLemaCampaña.Text = ca.Lema;
			string dia1 = "";
			string mes1 = "";
			string año1 = "";

			dia1 = fechaInicio.Date.Day.ToString();
			if (dia1.Length == 1)
			{
				dia1 = "0" + dia1;
			}
			mes1 = fechaInicio.Date.Month.ToString();
			if (mes1.Length == 1)
			{
				mes1 = "0" + mes1;
			}
			año1 = fechaInicio.Date.Year.ToString();
			txtFechaInicio.Text = dia1 + mes1 + año1;

			string dia2 = "";
			string mes2 = "";
			string año2 = "";
			DateTime fechaFin = ca.FechaFin;
			dia2 = fechaFin.Date.Day.ToString();
			if (dia2.Length == 1)
			{
				dia2 = "0" + dia2;
			}
			mes2 = fechaFin.Date.Month.ToString();
			if (mes2.Length == 1)
			{
				mes2 = "0" + mes2;
			}
			año2 = fechaFin.Date.Year.ToString();
			txtFechaFin.Text = dia2 + mes2 + año2;
		}

		private void btnActualizarCampaña_Click(object sender, EventArgs e)
		{
			DateTime fechaDesde = DateTime.Parse(txtFechaInicio.Text);
			DateTime fechaHasta = DateTime.Parse(txtFechaFin.Text);

			if ((fechaDesde > fechaHasta) || (txtNombreCampaña.Text == "" || txtFechaInicio.Text == "" || txtFechaFin.Text == ""))
			{
				MessageBox.Show("Datos mal ingresados! Complete de nuevo los campos");
				LimpiarCampos();
				txtFechaInicio.Focus();
			}
			else
			{
				string nombre = txtNombreCampaña.Text;
				Campaña camp = ObtenerDatosCampaña();
				bool existe = AD_Campañas.ExisteCampañaEnBD(nombre);
				if (existe)
				{
					MessageBox.Show("El nombre ingresado ya existe. Por favor ingrese un nombre distinto");
					txtNombreCampaña.Text = "";
					txtNombreCampaña.Focus();
				}
				else
				{
					bool resultado = AD_Campañas.ActualizarCampañaABD(camp);
					if (resultado)
					{
						MessageBox.Show("Campaña actualizada con éxito!");
						LimpiarCampos();
						CargarGrillaCampañas();
						btnActualizarCampaña.Enabled = false;
						btnGuardar.Enabled = true;
						txtFechaInicio.Enabled = true;
					}
					else
					{
						MessageBox.Show("No se pudo actualizar la campaña!");
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

		private void btnEliminarEmpleado_Click(object sender, EventArgs e)
		{
			txtBusqueda.Focus();
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
					string nombre = txtEliminar.Text;
					Campaña cam = ObtenerCampaña(nombre);
					bool resultado3 = AD_Campañas.EliminarCampañaEnBD(cam);
					if (resultado3 == true)
					{
						MessageBox.Show("Campaña borrada con exito");
						LimpiarCampos();
					}
					else
					{
						MessageBox.Show("Error al borrar campaña");
					}
				}
			}
		}

		//private Campaña ObtenerDatosCampañaReducido()
		//{
		//	Campaña cam = new Campaña();
		//	cam.Nombre = txtBusqueda.Text;

		//	return cam;
		//}

		private Campaña ObtenerCampaña(string nombre)
		{
			string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
			SqlConnection cn = new SqlConnection(cadenaConexion);
			Campaña camp = new Campaña();
			try
			{
				SqlCommand cmd = new SqlCommand();
				string consulta = "SELECT * FROM Campañas WHERE NombreCampaña LIKE @nombreCampaña";
				cmd.Parameters.Clear();
				cmd.Parameters.AddWithValue("@nombreCampaña", nombre);
				cmd.CommandType = CommandType.Text;
				cmd.CommandText = consulta;

				cn.Open();
				cmd.Connection = cn;
				SqlDataReader dr = cmd.ExecuteReader();

				if (dr != null && dr.Read())
				{
					camp.Nombre = dr["NombreCampaña"].ToString();
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

			return camp;
		}

		private void CargarCampos(Campaña camp)
		{
			txtEliminar.Text = camp.Nombre;
		}

		private void gdrCampaña_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
		{
			btnEliminarCampaña.Enabled = true;
			int indice = e.RowIndex;
			DataGridViewRow filaSeleccionada = gdrCampaña.Rows[indice];
			string nombre = filaSeleccionada.Cells["Nombre"].Value.ToString();
			Campaña camp = ObtenerCampaña(nombre);
			LimpiarCampos();
			CargarCampos(camp);
		}
	}

}
