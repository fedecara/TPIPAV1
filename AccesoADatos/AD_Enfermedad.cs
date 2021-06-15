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
    public class AD_Enfermedad
    {
        public static bool ExisteEnfermedadEnBD(string Nombre)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                bool resultado = false;

                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT NombreEnfermedad FROM Enfermedades WHERE NombreEnfermedad LIKE @Nombre";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
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

        public static DataTable BuscarEnfermedad(string Enfermedad)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = $"SELECT*FROM Enfermedades WHERE NombreEnfermedad LIKE'{Enfermedad}'";

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

        public static Enfermedad ObtenerEnfermedad(string Nombre)
        {
            Enfermedad enf = new Enfermedad();
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "select*from Enfermedades where NombreEnfermedad like @Enf";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Enf", Nombre);



                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;


                SqlDataReader dr = cmd.ExecuteReader();
                if (dr != null && dr.Read())
                {

                    enf.NombreEnf = dr["NombreEnfermedad"].ToString();
                    enf.DescipcionEnf = dr["Descripcion"].ToString();
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
            return enf;

        }

        public static bool AgregarEnfermedadABD(Enfermedad Enf)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Enfermedades (NombreEnfermedad, Descripcion) VALUES(@Enfermedad, @Desc)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Enfermedad", Enf.NombreEnf);
                cmd.Parameters.AddWithValue("@Desc", Enf.DescipcionEnf);



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

        public static bool ActualizarEnfermedadBD(Enfermedad enf)
        {

            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "update Enfermedades set NombreEnfermedad = @Enfermedad, Descripcion = @Descripcion where NombreEnfermedad like @Enfermedad";


                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@Enfermedad", enf.NombreEnf);
                cmd.Parameters.AddWithValue("@Descripcion", enf.DescipcionEnf);




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

        public static DataTable buscarNombreEnfermedad(string nombre)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = $"SELECT * FROM Enfermedades WHERE NombreEnfermedad LIKE '{nombre}%'";
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
