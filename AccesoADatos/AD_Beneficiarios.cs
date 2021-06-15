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
    public class AD_Beneficiarios
    {
        public static DataTable buscarBeneficiarioReducido(string cuil)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = $"SELECT NombreBeneficiario, ApellidoBeneficiario, Cuil_Beneficiario FROM Beneficiarios WHERE Cuil_Beneficiario LIKE '{cuil}'";
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

        public static DataTable ObtenerEstadisticaEnfermedades()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "select c.NombreBeneficiario , Count (pc.Id_Enfermedad) as Cantidad from Enfermedades pc inner join Beneficiarios c on pc.Id_Enfermedad = c.Id_Enfermedad group by c.NombreBeneficiario";

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

        public static DataTable obtenerListaBeneficiariosBarrio()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Barrios";
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

        public static DataTable buscarCiudadCombo(string tipo)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = $"SELECT * FROM Barrios WHERE Id_Ciudad LIKE '{tipo}%'";
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

        public static DataTable obtenerListaBeneficiarios()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT Cuil_Beneficiario, NombreBeneficiario, ApellidoBeneficiario, Fecha_Nacimiento, NroCalle, NombreCalle FROM Beneficiarios";
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

        public static DataTable buscarBeneficiarioLetra(string letra)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = $"SELECT NombreBeneficiario, ApellidoBeneficiario, Cuil_Beneficiario, Fecha_Nacimiento FROM Beneficiarios WHERE ApellidoBeneficiario LIKE '{letra}%'";
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

        public static DataTable obtenerEstadisticaBeneficiariosBarrio()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT c.NombreBarrio, COUNT(pc.Id_Barrio) AS CantidadBeneficiarios FROM Beneficiarios pc INNER JOIN Barrios c ON pc.Id_Barrio = c.Id_Barrio GROUP BY c.NombreBarrio";
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

        public static DataTable CargarGrillaEstadisticaBarrioBene()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT c.NombreBarrio, COUNT(pc.Id_Barrio) AS CantidadBeneficiarios FROM Beneficiarios pc INNER JOIN Barrios c ON pc.Id_Barrio = c.Id_Barrio GROUP BY c.NombreBarrio";
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

        public static DataTable CargarGrillaEstadisticaBene()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT s.NombreSexo AS 'Sexo', COUNT(b.Id_Sexo) AS 'Cantidaddebeneficiarios' FROM Beneficiarios b INNER JOIN Sexos s ON b.Id_Sexo = s.Id_Sexo GROUP BY s.NombreSexo";
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

        public static DataTable obtenerEstadisticaBeneficiarios()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT s.NombreSexo AS Sexo, COUNT(b.Id_Sexo) AS Cantidaddebeneficiarios FROM Beneficiarios b INNER JOIN Sexos s ON b.Id_Sexo = s.Id_Sexo GROUP BY s.NombreSexo";
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

        public static DataTable ObtenerEstadisticaBeneficiarios()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT c.NombreCiudad, COUNT(c.Id_Ciudad) as Cantidad FROM Beneficiarios b Inner Join Barrios bar ON b.Id_Barrio = bar.Id_Barrio INNER JOIN  Ciudades c ON bar.Id_Ciudad = c.Id_Ciudad GROUP BY c.NombreCiudad";

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

        //public static bool ExisteBeneficiarioEnBD(int cuil)
        //{
        //    string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
        //    SqlConnection cn = new SqlConnection(cadenaConexion);
        //    try
        //    {
        //        bool resultado = false;

        //        SqlCommand cmd = new SqlCommand();

        //        string consulta = "SELECT Cuil_Beneficiario FROM Beneficiarios WHERE Cuil_Beneficiario LIKE @cuilBeneficiario";
        //        cmd.Parameters.Clear();
        //        cmd.Parameters.AddWithValue("@cuilBeneficiario", cuil);
        //        cmd.CommandType = CommandType.Text;
        //        cmd.CommandText = consulta;

        //        cn.Open();
        //        cmd.Connection = cn;

        //        DataTable tabla = new DataTable();

        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        da.Fill(tabla);

        //        if (tabla.Rows.Count != 0)
        //        {
        //            resultado = true;
        //        }
        //        else
        //        {
        //            resultado = false;
        //        }

        //        return resultado;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        cn.Close();
        //    }
        //}

        public static DataTable obtenerListadoBeneficiarios()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT Cuil_Beneficiario, NombreBeneficiario, ApellidoBeneficiario, Id_Enfermedad, Id_EstadoSalud FROM Beneficiarios";
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

        public static DataTable obtenerListadoBeneficiariosReducido()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT Cuil_Beneficiario, NombreBeneficiario, ApellidoBeneficiario FROM Beneficiarios";
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

        public static bool AgregarBeneficiarioABD(Beneficiario benef)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Beneficiarios (Cuil_Beneficiario, NombreBeneficiario, ApellidoBeneficiario, Id_Sexo, Fecha_Nacimiento, Id_Situacion, Id_Enfermedad, NroCalle, NombreCalle, Id_Barrio, Id_CategoriaFamiliar, Id_EstadoSalud) VALUES(@cuil, @nombre, @apellido, @sexo, @fechaNac, @situacion, @enfermedad, @numCalle, @nombreCalle, @barrio, @categoria, @estado)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cuil", benef.Cuil);
                cmd.Parameters.AddWithValue("@nombre", benef.Nombre);
                cmd.Parameters.AddWithValue("@apellido", benef.Apellido);
                cmd.Parameters.AddWithValue("@sexo", benef.Sexo);
                cmd.Parameters.AddWithValue("@fechaNac", benef.Fecha);
                cmd.Parameters.AddWithValue("@situacion", benef.Situacion);
                cmd.Parameters.AddWithValue("@enfermedad", benef.Enfermedad);
                cmd.Parameters.AddWithValue("@numCalle", benef.NumCalle);
                cmd.Parameters.AddWithValue("@nombreCalle", benef.NombreCalle);
                cmd.Parameters.AddWithValue("@barrio", benef.Barrio);
                cmd.Parameters.AddWithValue("@categoria", benef.Categoria);
                cmd.Parameters.AddWithValue("@estado", benef.Estado);
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

        public static DataTable buscarBeneficiario(string cuil)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = $"SELECT Cuil_Beneficiario, NombreBeneficiario, ApellidoBeneficiario, Id_Enfermedad, Id_EstadoSalud FROM Beneficiarios WHERE Cuil_Beneficiario LIKE '{cuil}'";
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

        public static bool ActualizarBeneficiarioABD(Beneficiario b)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Beneficiarios SET Cuil_Beneficiario = @cuil, NombreBeneficiario = @nombre, ApellidoBeneficiario = @apellido, Id_Sexo = @sexo, Fecha_Nacimiento = @fecha, Id_Situacion = @situacion, Id_Enfermedad = @enfermedad, NroCalle = @numCalle, NombreCalle = @nombreCalle, Id_Barrio = @barrio, Id_CategoriaFamiliar = @categoria, Id_EstadoSalud = @estado WHERE Cuil_Beneficiario LIKE @cuil";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cuil", b.Cuil);
                cmd.Parameters.AddWithValue("@nombre", b.Nombre);
                cmd.Parameters.AddWithValue("@apellido", b.Apellido);
                cmd.Parameters.AddWithValue("@sexo", b.Sexo);
                cmd.Parameters.AddWithValue("@fecha", b.Fecha);
                cmd.Parameters.AddWithValue("@situacion", b.Situacion);
                cmd.Parameters.AddWithValue("@enfermedad", b.Enfermedad);
                cmd.Parameters.AddWithValue("@numCalle", b.NumCalle);
                cmd.Parameters.AddWithValue("@nombreCalle", b.NombreCalle);
                cmd.Parameters.AddWithValue("@barrio", b.Barrio);
                cmd.Parameters.AddWithValue("@categoria", b.Categoria);
                cmd.Parameters.AddWithValue("@estado", b.Estado);



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

        public static bool ExisteBeneficiarioEnBD(string cuil)
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
        public static Beneficiario ObtenerBeneficiario(int id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Beneficiario p = new Beneficiario();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Beneficiarios where Id_Beneficiario like @id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {
                    p.IdBeneficiario = int.Parse(dr["Id_Beneficiario"].ToString());
                    p.Nombre = dr["NombreBeneficiario"].ToString();
                    p.Apellido = dr["ApellidoBeneficiario"].ToString();
                    p.Cuil = dr["Cuil_Beneficiario"].ToString();
                   
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

            return p;
        }

        public static bool EliminarBeneficiarioEnBD(Beneficiario b)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "DELETE FROM Beneficiarios WHERE Cuil_beneficiario = @cuil";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cuil", b.Cuil);

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
    }
}
