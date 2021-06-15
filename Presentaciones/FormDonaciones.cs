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
    public partial class FormDonaciones : Form
    {
        public FormDonaciones()
        {
            InitializeComponent();
        }
        
        private void btnBuscarBenefactorDonacion_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreBen.Text;
            bool existe = AD_Donacion.ExisteBenefactorEnBD(nombre);
            if(existe)
            {
                gdrDatosBenefactor.DataSource = AD_Benefactores.buscarBenefactorReducido(nombre);
                txtNombreBen.Text = "";
            }
            else
            {
                MessageBox.Show("El benefactor no esta cargado en la base de datos.");
                string mensaje = "";
                mensaje = "¿Desea registrar un nuevo benefactor?";
                DialogResult resultado = MessageBox.Show(mensaje, "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(resultado == DialogResult.Yes)
                {
                    LimpiarCampos();
                    FormAltaBenefactor ventana = new FormAltaBenefactor();
                    ventana.Show();
                }
                else
                {
                    txtNombreBen.Text = "";
                    txtNombreBen.Focus();
                }

            }
        }

        private void FormDonaciones_Load(object sender, EventArgs e)
        {
            gdrDonaciones.Enabled = false;
            btnActualizarDonacion.Enabled = false;
            btnGuardarDonacion.Enabled = false;
            CargarComboTipoMercaderia();
            CargarComboTipoDonacion();
            CargarComboEstadoMercaderia();
            CargarGrillaEmpleados();
            CargarGrillaDonaciones();
            CargarGrillaBenefactores();
            CargarGrillaBeneficiarios();
            CargarGrillaCampañas();
        }

        private void CargarComboEstadoMercaderia()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                cmbEstadoMercaderia.DataSource = AD_Varios.ObtenerTabla("Estado_Mercaderia");
                cmbEstadoMercaderia.DisplayMember = "Nombre";
                cmbEstadoMercaderia.ValueMember = "Id_EstadoMercaderia";
                cmbEstadoMercaderia.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combo");
            }
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
                MessageBox.Show("Error al cargar combo");
            }
        }

        private void CargarComboTipoMercaderia()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                cmbTipoMercaderia.DataSource = AD_Varios.ObtenerTabla("Tipo_Mercaderia");
                cmbTipoMercaderia.DisplayMember = "NombreTipoMercaderia";
                cmbTipoMercaderia.ValueMember = "Id_TipoMercaderia";
                cmbTipoMercaderia.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combo de mercaderia");
            }
        }
            
        private void CargarCampos(Benefactor ben)
        {
            txtNombreBenefactorDonacion.Text = ben.NOMBREBENEFACTOR;
            txtApellidoBenefactorDonacion.Text = ben.APELLIDOBENEFACTOR;
            txtIdBenefactor.Text = ben.IDBENEFACTOR.ToString();
        }

        private Benefactor ObtenerBenefactorActualizado(string nombre)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Benefactor ben = new Benefactor();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = $"SELECT Id_Benefactor, NombreBenefactor, ApellidoBenefactor FROM Benefactores WHERE NombreBenefactor LIKE '{nombre}%'";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreBenefactor", nombre);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    ben.NOMBREBENEFACTOR = dr["NombreBenefactor"].ToString();
                    ben.APELLIDOBENEFACTOR = dr["ApellidoBenefactor"].ToString();
                    ben.IDBENEFACTOR = int.Parse(dr["Id_Benefactor"].ToString());
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

            return ben;
        }

        public void CargarGrillaEmpleados()
        {
            try
            {
                gdrEmpleadosDonacion.DataSource = AD_Empleados.ObtenerEmpleadoReducido();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudieron cargar los empleados");
            }
        }

        public void CargarGrillaBenefactores()
        {
            try
            {
                gdrDatosBenefactor.DataSource = AD_Benefactores.obtenerListadoBenefactoresAcotado();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudieron cargar los benefactores");
            }
        }

        public void CargarGrillaBeneficiarios()
        {
            try
            {
                gdrBeneficiarioCampaña.DataSource = AD_Beneficiarios.obtenerListadoBeneficiariosReducido();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudieron cargar los beneficiarios");
            }
        }

        public void CargarGrillaCampañas()
        {
            try
            {
                gdrCampaña.DataSource = AD_Campañas.ObtenerListadoCampañasReducido();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudieron cargar los beneficiarios");
            }
        }

        private void gdrDatosBenefactor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //btnEliminarEmpleado.Enabled = true;
            int indice = e.RowIndex;
            //btnActualizarPersona.Enabled = true;
            DataGridViewRow filaSeleccionada = gdrDatosBenefactor.Rows[indice];
            string nombre = filaSeleccionada.Cells["Nombre"].Value.ToString();
            Benefactor ben = ObtenerBenefactorActualizado(nombre);
            //LimpiarCampos();
            CargarCampos(ben);
        }

        private void CargarCamposAct(Campaña ca)
        {
            DateTime fechaInicio = ca.FechaIni;
            //txtFechaInicio.Text = ca.FechaIni.Date.ToShortDateString();
            //txtFechaFin.Text = ca.FechaFin.Date.ToShortDateString();
            txtNombreCampaña.Text = ca.Nombre;
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
            txtIdCampaña.Text = ca.IdCampaña.ToString();
        }
   
        private Campaña ObtenerCampañaActualizada(string nombre)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Campaña c = new Campaña();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = $"SELECT Id_Campaña, FechaInicio, FechaFin, NombreCampaña FROM Campañas WHERE NombreCampaña LIKE '{nombre}%'";
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

        private void btnBuscarCampañaDonacion_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscarNombreCampaña.Text;
            bool existe = AD_Campañas.ExisteCampañaEnBD(nombre);
            if (existe)
            {
                gdrCampaña.DataSource = AD_Donacion.BuscarCampaña(nombre);
                txtBuscarNombreCampaña.Text = "";
            }
            else
            {
                MessageBox.Show("La campaña que ingreso no esta cargado en la base de datos.");
                string mensaje = "";
                mensaje = "¿Desea registrar una nueva campaña?";
                DialogResult resultado = MessageBox.Show(mensaje, "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    LimpiarCampos();
                    FormCampañas ventana = new FormCampañas();
                    ventana.Show();
                }
                else
                {
                    txtBuscarNombreCampaña.Text = "";
                    txtBuscarNombreCampaña.Focus();
                }

            }
            
        }

        private void gdrCampaña_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //btnGuardar.Enabled = false;
            //btnActualizarCampaña.Enabled = true;
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = gdrCampaña.Rows[indice];
            string nombre = filaSeleccionada.Cells["NombreCampaña"].Value.ToString();
            Campaña cam = ObtenerCampañaActualizada(nombre);
            //LimpiarCampos();
            CargarCamposAct(cam);
            //btnEliminarCampaña.Enabled = true;
        }

        private void btnBuscarBeneficiarioDonacion_Click(object sender, EventArgs e)
        {
            string cuil = txtCuilBeneficiarioDonacion.Text;
            bool existe = AD_Donacion.ExisteBeniciarioEnBD(cuil);
            if (existe)
            {
                gdrBeneficiarioCampaña.DataSource = AD_Beneficiarios.buscarBeneficiarioReducido(cuil);
                txtCuilBeneficiarioDonacion.Text = "";
            }
            else
            {
                MessageBox.Show("El beneficiario no esta cargado en la base de datos.");
                string mensaje = "";
                mensaje = "¿Desea registrar un nuevo beneficiario?";
                DialogResult resultado = MessageBox.Show(mensaje, "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    LimpiarCampos();
                    FormBeneficiarios ventana = new FormBeneficiarios();
                    ventana.Show();
                }
                else
                {
                    txtCuilBeneficiarioDonacion.Text = "";
                    txtCuilBeneficiarioDonacion.Focus();
                }

            }
        }

        private void gdrBeneficiarioCampaña_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //btnGuardar.Enabled = false;
            //btnActualizarCampaña.Enabled = true;
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = gdrBeneficiarioCampaña.Rows[indice];
            string cuil = filaSeleccionada.Cells["CuilBeneficiario"].Value.ToString();
            Beneficiario ben = ObtenerBeneficiarioActualizado(cuil);
            //int id = int.Parse(filaSeleccionada.Cells["Id"].Value.ToString());
            //Beneficiario ben = ObtenerBeneficiarioActualizado(id);
            //LimpiarCampos();
            CargarCamposBeneficiario(ben);
            //btnEliminarCampaña.Enabled = true;
        }

        private Beneficiario ObtenerBeneficiarioActualizado(string cuil)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Beneficiario b = new Beneficiario();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = $"SELECT Id_Beneficiario ,NombreBeneficiario, ApellidoBeneficiario, Cuil_Beneficiario FROM Beneficiarios WHERE Cuil_Beneficiario LIKE '{cuil}%'";
                cmd.Parameters.Clear();
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
                    b.IdBeneficiario = int.Parse(dr["Id_Beneficiario"].ToString());
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

        private void CargarCamposBeneficiario(Beneficiario ben)
        {
            txtCuilBeneficiario.Text = ben.Cuil.ToString();
            txtNombreBeneficiario.Text = ben.Nombre;
            txtApellidoBeneficiario.Text = ben.Apellido;
            txtIdBeneficiario.Text = ben.IdBeneficiario.ToString();
        }
                
        private void gdrEmpleadosDonacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //btnGuardar.Enabled = false;
            //btnActualizarCampaña.Enabled = true;
            int indice = e.RowIndex;
            DataGridViewRow filaSeleccionada = gdrEmpleadosDonacion.Rows[indice];
            int legajo = int.Parse(filaSeleccionada.Cells["Legajo"].Value.ToString());
            Empleado emp = ObtenerEmpleadoActualizado(legajo);
            //LimpiarCampos();
            bool existe = AD_Empleados.ExisteLegajoEnBD(legajo);
            if (existe && txtLegajoRecibio.Text.Equals(""))
            {
                CargarCamposEmpleadoRecibido(emp);
                int fila = this.gdrEmpleadosDonacion.CurrentRow.Index;
                this.gdrEmpleadosDonacion.CurrentCell = null;
                this.gdrEmpleadosDonacion.Rows[fila].Visible = false;
            }
            else
            {
                if (existe && txtLegajoEntrego.Text.Equals(""))
                {
                    CargarCampoEmpleadoEntrego(emp);
                    int fila = this.gdrEmpleadosDonacion.CurrentRow.Index;
                    this.gdrEmpleadosDonacion.CurrentCell = null;
                    this.gdrEmpleadosDonacion.Rows[fila].Visible = false;
                } 
            }
        }
        
        private void CargarCamposEmpleadoRecibido(Empleado emp)
        {
            txtLegajoRecibio.Text = emp.LegajoEmpleado.ToString();
        }

        private void CargarCampoEmpleadoEntrego(Empleado emp)
        {
            txtLegajoEntrego.Text = emp.LegajoEmpleado.ToString();
        }

        private Empleado ObtenerEmpleadoActualizado(int legajo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Empleado emp = new Empleado();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT Legajo_Empleado FROM Empleados WHERE Legajo_Empleado LIKE @legajo";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@legajo", legajo);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    emp.LegajoEmpleado = int.Parse(dr["Legajo_Empleado"].ToString());
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

        private void btnLimpiarDonacion_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtFechaDonacion.Text = "";
            cmbTipoDonacion.SelectedIndex = -1;
            cmbTipoMercaderia.SelectedIndex = -1;
            cmbEstadoMercaderia.SelectedIndex = -1;
            txtNombreBen.Text = "";
            txtNombreBenefactorDonacion.Text = "";
            txtApellidoBenefactorDonacion.Text = "";
            txtLegajoRecibio.Text = "";
            txtLegajoEntrego.Text = "";
            txtCuilBeneficiarioDonacion.Text = "";
            txtCuilBeneficiario.Text = "";
            txtNombreBeneficiario.Text = "";
            txtApellidoBeneficiario.Text = "";
            txtBuscarNombreCampaña.Text = "";
            txtNombreCampaña.Text = "";
            txtFechaInicio.Text = "";
            txtFechaFin.Text = "";
            
        }

        private void btnGuardarDonacion_Click(object sender, EventArgs e)
        {
            if(txtFechaDonacion.Text.Equals("") || cmbTipoDonacion.SelectedItem == null || cmbTipoMercaderia.SelectedItem == null || cmbEstadoMercaderia.SelectedItem == null || txtNombreBenefactorDonacion.Text.Equals("") || txtApellidoBenefactorDonacion.Text.Equals("") || txtLegajoRecibio.Text.Equals("") || txtLegajoEntrego.Text.Equals(""))
            {
                MessageBox.Show("Faltan datos por completar");
            }
            else
            {
                Donacion d = ObtenerDatosDonacion();
                bool resultado = AD_Donacion.AgregarDonacionABD(d);
                if (resultado)
                {
                    MessageBox.Show("Donacion registrada con exito");
                    CargarComboEstadoMercaderia();
                    CargarComboTipoDonacion();
                    CargarComboTipoMercaderia();
                    CargarGrillaDonaciones();
                    LimpiarCampos();
                    btnGuardarDonacion.Enabled = false;
                    btnActualizarDonacion.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Error al registrar donacion");
                }
            }
        }

        private Donacion ObtenerDatosDonacion()
        {
            Donacion d = new Donacion();
            d.IdBenefactorDonacion = int.Parse(txtIdBenefactor.Text);
            d.CuildBeneficiarioDonacion = int.Parse(txtIdBeneficiario.Text);
            d.LegajoEmpRecibioDonacion = int.Parse(txtLegajoRecibio.Text);
            d.LegajoEmpEntregoDonacion = int.Parse(txtLegajoEntrego.Text);
            d.FechaDonacion = DateTime.Parse(txtFechaDonacion.Text);
            d.IdTipoMercaderiaDonacion = (int)cmbTipoMercaderia.SelectedValue;
            d.IdEstadoMercaderiaDonada = (int)cmbEstadoMercaderia.SelectedValue;
            d.IdCampañaDonacion = int.Parse(txtIdCampaña.Text);
            d.IdTipoDonac = (int)cmbTipoDonacion.SelectedValue;

            return d;
        }
        
        private void btnActualizarDonacion_Click(object sender, EventArgs e)
        {
            if (txtFechaDonacion.Text.Equals("") || cmbTipoDonacion.SelectedItem == null || cmbTipoMercaderia.SelectedItem == null || cmbEstadoMercaderia.SelectedItem == null || txtNombreBenefactorDonacion.Text.Equals("") || txtApellidoBenefactorDonacion.Text.Equals("") || txtLegajoRecibio.Text.Equals("") || txtLegajoEntrego.Text.Equals(""))
            {
                MessageBox.Show("Faltan datos por completar");
            }
            else
            {
                Donacion d = ObtenerDatosDonacion();
                bool resultado = ActualizarDonacion(d);
                if (resultado == true)
                {
                    MessageBox.Show("Donacion actualizada con exito");
                    //
                    //CargarCamposBeneficiario();
                    CargarGrillaEmpleados();
                    CargarGrillaDonaciones();
                    CargarComboEstadoMercaderia();
                    CargarComboTipoDonacion();
                    CargarComboTipoMercaderia();
                    gdrDonaciones.Enabled = true;
                    LimpiarCampos();
                    txtFechaDonacion.Enabled = true;
                    btnActualizarDonacion.Enabled = false;
                    btnGuardarDonacion.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Error al actualizar empleado");
                }
            }
        }

        private bool ActualizarDonacion(Donacion d)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Donaciones SET id_Benefactor = @idBenefactor, Id_Beneficiario = @idBeneficiario, Legajo_EmpleadoRecibio = @legajoRecibio, Legajo_EmpleadoEntrego = @legajoEntrego, Fecha = @fecha, Id_TipoMercaderia = @idTipoMercaderia, Id_EstadoMercaderia = @idEstadoMercaderia, Id_Campaña = @idCampaña, Id_TipoDonacion = @idTipoDonacion WHERE Fecha LIKE @fecha";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@idBenefactor", d.IdBenefactorDonacion);
                cmd.Parameters.AddWithValue("@idBeneficiario", d.CuildBeneficiarioDonacion);
                cmd.Parameters.AddWithValue("@legajoRecibio", d.LegajoEmpRecibioDonacion);
                cmd.Parameters.AddWithValue("@legajoEntrego", d.LegajoEmpEntregoDonacion);
                cmd.Parameters.AddWithValue("@fecha", d.FechaDonacion);
                cmd.Parameters.AddWithValue("@idTipoMercaderia", d.IdTipoMercaderiaDonacion);
                cmd.Parameters.AddWithValue("@idEstadoMercaderia", d.IdEstadoMercaderiaDonada);
                cmd.Parameters.AddWithValue("@idCampaña", d.IdCampañaDonacion);
                cmd.Parameters.AddWithValue("@idTipoDonacion", d.IdTipoDonac);
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

        public void CargarGrillaDonaciones()
        {
            try
            {
                gdrDonaciones.DataSource = AD_Donacion.ObtenerDonacionReducido();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudieron cargar los empleados");
            }
        }

        private void gdrDonaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnGuardarDonacion.Enabled = false;
            txtFechaDonacion.Enabled = false;
            int indice = e.RowIndex;
            btnActualizarDonacion.Enabled = true;
            DataGridViewRow filaSeleccionada = gdrDonaciones.Rows[indice];
            DateTime fecha = DateTime.Parse(filaSeleccionada.Cells["FechaDonacion"].Value.ToString());
            Donacion d = ObtenerDonacion(fecha);
            LimpiarCampos();
            CargarCamposDonacion(d);
            txtLegajoEntrego.Text = "";
            txtLegajoRecibio.Text = "";

            CargarGrillaEmpleados();
        }

        private Donacion ObtenerDonacion(DateTime fecha)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Donacion d = new Donacion();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT Legajo_EmpleadoRecibio, Legajo_EmpleadoEntrego, Fecha, Id_TipoMercaderia, Id_TipoDonacion, Id_EstadoMercaderia FROM Donaciones WHERE Fecha LIKE @fecha";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    //d.IdBenefactorDonacion = int.Parse(dr["id_Benefactor"].ToString());
                    //d.CuildBeneficiarioDonacion = int.Parse(dr["Id_Beneficiario"].ToString());
                    d.LegajoEmpRecibioDonacion = int.Parse(dr["Legajo_EmpleadoRecibio"].ToString());
                    d.LegajoEmpEntregoDonacion = int.Parse(dr["Legajo_EmpleadoEntrego"].ToString());
                    d.FechaDonacion = DateTime.Parse(dr["Fecha"].ToString());
                    d.IdTipoMercaderiaDonacion = int.Parse(dr["Id_TipoMercaderia"].ToString());
                    d.IdEstadoMercaderiaDonada = int.Parse(dr["Id_EstadoMercaderia"].ToString());
                    //d.IdCampañaDonacion = int.Parse(dr["Id_Campaña"].ToString());
                    d.IdTipoDonac = int.Parse(dr["Id_TipoDonacion"].ToString());
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

            return d;
        }

        private void CargarCamposDonacion(Donacion d)
        {
            DateTime fecha = d.FechaDonacion;
            string dia = "";
            string mes = "";
            string año = "";
            dia = fecha.Date.Day.ToString();
            if (dia.Length == 1)
            {
                dia = "0" + dia;
            }
            mes = fecha.Date.Month.ToString();
            if (mes.Length == 1)
            {
                mes = "0" + mes;
            }
            año = fecha.Date.Year.ToString();
            txtFechaDonacion.Text = dia + mes + año;
            //cmbEstadoMercaderia.SelectedValue = d.IdEstadoMercaderiaDonada;
            //cmbTipoDonacion.SelectedValue = d.IdTipoDonac;
            //cmbTipoMercaderia.SelectedValue = d.IdTipoMercaderiaDonacion;
            //txtNombreBen.Text = d.CuildBeneficiarioDonacion.ToString();
            //txtLegajoRecibio.Text = d.LegajoEmpRecibioDonacion.ToString();
            //txtLegajoEntrego.Text = d.LegajoEmpEntregoDonacion.ToString();
            //txtCuilBeneficiarioDonacion.Text = d.IdBenefactorDonacion.ToString();
            //txtBuscarNombreCampaña.Text = d.IdCampañaDonacion.ToString();
        }

        private void btnActivarGrilla_Click(object sender, EventArgs e)
        {
            btnGuardarDonacion.Enabled = false;
            gdrDonaciones.Enabled = true;
            LimpiarCampos();
        }

        private void btnActivarGuardar_Click(object sender, EventArgs e)
        {
            txtFechaDonacion.Enabled = true;
            gdrDonaciones.Enabled = false;
            btnGuardarDonacion.Enabled = true;
            btnActualizarDonacion.Enabled = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormPrincipal ventana = new FormPrincipal();
            ventana.Show();
            this.Hide();
        }
    }
}
