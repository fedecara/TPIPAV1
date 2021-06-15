using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPI.Clases;

namespace TPI.AccesoADatos
{
    public class AD_Donacion
    {
        public static DataTable BuscarCampaña(string nombre)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = $"SELECT FechaInicio, FechaFin, NombreCampaña FROM Campañas WHERE NombreCampaña LIKE '{nombre}'";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                return tabla;

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

        public static bool ExisteBenefactorEnBD(string nombre)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT NombreBenefactor FROM Benefactores WHERE NombreBenefactor LIKE @nombreBenefactor";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombreBenefactor", nombre);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                if (tabla.Rows.Count == 1)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }

                return resultado;
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

        public static bool ExisteBeniciarioEnBD(string cuil)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT Cuil_Beneficiario FROM Beneficiarios WHERE Cuil_Beneficiario LIKE @cuilBeneficiario";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cuilBeneficiario", cuil);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                if (tabla.Rows.Count == 1)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }

                return resultado;
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

        public static bool AgregarDonacionABD(Donacion d)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Donaciones (id_Benefactor, Id_Beneficiario, Legajo_EmpleadoRecibio, Legajo_EmpleadoEntrego, Fecha, Id_TipoMercaderia, Id_EstadoMercaderia, Id_Campaña, Id_TipoDonacion) VALUES(@idBenefactor, @idBeneficiario, @legajoRecibio, @legajoEntrego, @fecha, @idTipoMercaderia, @idEstadoMercaderia, @idCampaña, @idTipoDonacion)";
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

        public static DataTable ObtenerDonacionReducido()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT Fecha, Id_Beneficiario, Id_TipoMercaderia FROM Donaciones";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                return tabla;
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

    }    
}
