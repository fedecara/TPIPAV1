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
using tp_Carabelli_Farias_Federico.AD;
using tp_Carabelli_Farias_Federico.Entidades;

namespace tp_Carabelli_Farias_Federico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CargarGrilla();
            CargarComboAuto();
        }

        private void CargarGrilla()
        {
            try
            {
                GdrAuto.DataSource = AD_Auto.CargarGrillaAuto();
            }
            catch (Exception ex)
            {

            }
        }

        private void CargarComboAuto()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "select * from Marca_Automovil";

                cmd.Parameters.Clear();


                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                CmbMarca.DataSource = tabla;
                CmbMarca.DisplayMember = "Nombre";
                CmbMarca.ValueMember = "Id_Marca";
                CmbMarca.SelectedIndex = -1;

            }
            catch (Exception ex)
            {

                throw;
            }

            finally
            {
                cn.Close();

            }

        }

        private Auto ObtenerDatosAuto()
        {
            Auto au = new Auto();
            au.IdMarcaAuto = (int)CmbMarca.SelectedValue;
            au.NombreAuto = TxtNombre.Text;
            return au;
        }

        
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Auto au = ObtenerDatosAuto();
            bool resultado = AD_Auto.InsertarAuto(au);
            if (resultado)
            {
                CargarComboAuto();
                CargarGrilla();
            }
            else
            {

            }

        }
    }
}

