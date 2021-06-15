using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI.Clases;

namespace TPI.AccesoADatos
{
    public class AD_Necesidad
    {
        public static DataTable BuscarNivel(string Id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = $"SELECT*FROM Necesidades WHERE Id_NivelPrioridad LIKE'{Id}'";

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

        public static DataTable BuscarBeneficiario(string Beneficiario)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = $"SELECT*FROM Necesidades WHERE Id_Beneficiario LIKE'{Beneficiario}'";

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

        public static bool ExisteNivelEnBD(string Nivel)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT Id_NivelPrioridad FROM Necesidades WHERE Id_NivelPrioridad LIKE @Nivel";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nivel", Nivel);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                if (tabla.Rows.Count != 0)
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

        public static bool ExisteBeneficiaroEnBD(string Beneficiario)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT Id_Beneficiario FROM Necesidades WHERE Id_Beneficiario LIKE @Beneficiario";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Beneficiario", Beneficiario);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                if (tabla.Rows.Count != 0)
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


        public static DataTable ObtenerTablaBeneficiario(string nombreTabla)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT Id_Beneficiario, (' ' + NombreBeneficiario +' ' + ApellidoBeneficiario ) as Beneficiario FROM " + nombreTabla;

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


        public static bool ExisteEnBD(DateTime FechaDesde, DateTime FechaHasta, string IdBene, String IdDonacion)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT FechaDesde, FechaHasta,Id_Beneficiario FROM Necesidades WHERE FechaDesde like @FechaDesde and FechaHasta like @FechaHasta and Id_Beneficiario like @Id_Beneficiario and Id_TipoDonacion like @Id_Donacion";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@FechaDesde", FechaDesde);
                cmd.Parameters.AddWithValue("@FechaHasta", FechaHasta);
                cmd.Parameters.AddWithValue("@Id_Beneficiario", IdBene);
                cmd.Parameters.AddWithValue("@Id_Donacion", IdDonacion);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);

                if (tabla.Rows.Count != 0)
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
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static bool AgregarNecesiadABD(Necesidad Nec)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Necesidades (FechaDesde, FechaHasta, Id_Beneficiario, Id_Motivo, Id_NivelPrioridad, Id_TipoDonacion) VALUES(@FechaD, @FechaH, @Id_Bene, @Id_Mot, @Id_Nivel, @Id_Donacion)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@FechaD", Nec.FechaDesdeNecesidad);
                cmd.Parameters.AddWithValue("@FechaH", Nec.FechaHastaNecesidad);
                cmd.Parameters.AddWithValue("@Id_Bene", Nec.Beneficiario);
                cmd.Parameters.AddWithValue("@Id_Mot", Nec.Motivo);
                cmd.Parameters.AddWithValue("@Id_Nivel", Nec.NivelPrioridad);
                cmd.Parameters.AddWithValue("@Id_Donacion", Nec.TipoDonacion);


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

        public static Necesidad ObtenerNecesidad(string Id)
        {
            Necesidad nec = new Necesidad();
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "select * from Necesidades where Id_Necesidad like @Id";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;


                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {
                    nec.FechaDesdeNecesidad = DateTime.Parse(dr["FechaDesde"].ToString());
                    nec.FechaHastaNecesidad = DateTime.Parse(dr["FechaHasta"].ToString());
                    nec.Beneficiario = int.Parse(dr["Id_Beneficiario"].ToString());
                    nec.Motivo = int.Parse(dr["Id_Motivo"].ToString());
                    nec.NivelPrioridad = int.Parse(dr["Id_NivelPrioridad"].ToString());
                    nec.TipoDonacion = int.Parse(dr["Id_TipoDonacion"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            finally
            {
                cn.Close();

            }
            return nec;

        }

        public static bool ActualizarNecesidadBD(Necesidad Nec)
        {

            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Necesidades SET FechaDesde = @FechaD, FechaHasta = @FechaH, Id_Beneficiario = @Id_Bene, Id_Motivo = @Id_Mot, Id_NivelPrioridad = @Id_Nivel, Id_TipoDonacion = @Id_Donacion WHERE FechaDesde LIKE @FechaD";


                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@FechaD", Nec.FechaDesdeNecesidad);
                cmd.Parameters.AddWithValue("@FechaH", Nec.FechaHastaNecesidad);
                cmd.Parameters.AddWithValue("@Id_Bene", Nec.Beneficiario);
                cmd.Parameters.AddWithValue("@Id_Mot", Nec.Motivo);
                cmd.Parameters.AddWithValue("@Id_Nivel", Nec.NivelPrioridad);
                cmd.Parameters.AddWithValue("@Id_Donacion", Nec.TipoDonacion);



                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                resultado = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            finally
            {
                cn.Close();

            }
            return resultado;

        }

        public static DataTable ObtenerEstadisticaNecesidad()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT c.Descripcion, COUNT(pc.Id_Necesidad) AS Cantidad FROM Necesidades pc INNER JOIN Nivel_Prioridad c ON pc.Id_NivelPrioridad = c.Id_NivelPrioridad GROUP BY c.Descripcion";


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
        public static DataTable ObtenerNivelesReducido()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT NombreNivelPrioridad, Descripcion FROM Nivel_Prioridad";
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
        public static DataTable ObtenerEstadisticaNecesidadXBene()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT (c.NombreBeneficiario+' '+c.ApellidoBeneficiario) as NombreBeneficiario, COUNT(pc.Id_Necesidad) AS Cantidad FROM Necesidades pc INNER JOIN Beneficiarios c ON pc.Id_Beneficiario = c.Id_Beneficiario  GROUP BY c.NombreBeneficiario+' '+c.ApellidoBeneficiario";

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

