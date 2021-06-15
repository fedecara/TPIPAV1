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
    public class AD_Benefactores
    {

        public static DataTable obtenerListadoBenefactores()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Benefactores";
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

        public static DataTable ObtenerEstadisticaEstadoDeSalud()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "select c.Nombre , Count (pc.Id_EstadoSalud) as Cantidad from Beneficiarios pc inner join Estado_Salud c on pc.Id_EstadoSalud = c.Id_EstadoSalud group by c.Nombre";

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

        public static DataTable obtenerListadoBenefactoresAcotado()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT Id_Benefactor,NombreBenefactor,ApellidoBenefactor FROM Benefactores";
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

        public static DataTable ObtenerBarrios(int ciudad)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Barrios WHERE Id_Ciudad LIKE " + ciudad;
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
            catch (Exception)
            {
                throw;
            }
            finally
            {
                cn.Close();
            }
        }

        public static bool AgregarBenefactorABD(Benefactor ben)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Benefactores (NombreBenefactor, ApellidoBenefactor, NroCalle, NombreCalle, Id_Barrio) VALUES(@nombre,@apellido,@nrocalle,@calle, @idbarrio)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", ben.NOMBREBENEFACTOR);
                cmd.Parameters.AddWithValue("@apellido", ben.APELLIDOBENEFACTOR);
                cmd.Parameters.AddWithValue("@nrocalle", ben.NROCALLE);
                cmd.Parameters.AddWithValue("@calle", ben.NOMBRECALLE);
                
                cmd.Parameters.AddWithValue("@idbarrio", ben.IDBARRIO);
                
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

        public static DataTable buscarBenefactor(string nombre)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = $"SELECT * FROM Benefactores WHERE NombreBenefactor LIKE '%{nombre}%'";
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

        public static bool actualizarBenefactor(Benefactor ben  )
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {

                //UPDATE table_name
                //SET column1 = value1, column2 = value2, ...
                //WHERE condition;

                SqlCommand cmd = new SqlCommand();
                string consulta = "UPDATE Benefactores SET NombreBenefactor = @nombre, ApellidoBenefactor = @apellido,NombreCalle = @calle, NroCalle = @nroCalle, Id_Barrio = @idbarrio WHERE NombreBenefactor like @nombre";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", ben.NOMBREBENEFACTOR);
                cmd.Parameters.AddWithValue("@apellido", ben.APELLIDOBENEFACTOR);
                cmd.Parameters.AddWithValue("@calle", ben.NOMBRECALLE);
                cmd.Parameters.AddWithValue("@nroCalle", ben.NROCALLE);
                cmd.Parameters.AddWithValue("@idbarrio", ben.IDBARRIO);
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

        public static bool actualizarBenefactor(Benefactor ben, int id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {

                SqlCommand cmd = new SqlCommand();
                //string consulta = "UPDATE Benefactores SET NombreBenefactor = @nombre, ApellidoBenefactor = @apellido, NombreCalle = @nombrecalle , NroCalle = @nrocalle , Id_Barrio = @barrio Where Id_Benefactor like @id";
                string consulta = "UPDATE Benefactores SET NombreBenefactor = @nombre ,ApellidoBenefactor = @apellido, NombreCalle = @nombrecalle , NroCalle = @nrocalle , Id_Barrio = @barrio Where Id_Benefactor like " + id;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nombre", ben.NOMBREBENEFACTOR);
                cmd.Parameters.AddWithValue("@apellido", ben.APELLIDOBENEFACTOR);
                cmd.Parameters.AddWithValue("@nombrecalle", ben.NOMBRECALLE);
                cmd.Parameters.AddWithValue("@nrocalle", ben.NROCALLE);
                cmd.Parameters.AddWithValue("@barrio", ben.IDBARRIO);
                //cmd.Parameters.AddWithValue("@id", id);
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

        public static Benefactor obtenerBenefactor(int id)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Benefactor b = new Benefactor();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = $"SELECT * FROM Benefactores WHERE Id_Benefactor like '{id}'";
                cmd.Parameters.Clear();
                //cmd.Parameters.AddWithValue("@id", id);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {

                    b.NOMBREBENEFACTOR = dr["NombreBenefactor"].ToString();
                    b.APELLIDOBENEFACTOR = dr["ApellidoBenefactor"].ToString();
                    b.NOMBRECALLE = dr["NombreCalle"].ToString();
                    b.NROCALLE = int.Parse(dr["NroCalle"].ToString());
                    b.IDBARRIO = int.Parse(dr["Id_Barrio"].ToString());
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

        public static DataTable buscarBenefactorReducido(string nombre)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();
                string consulta = $"SELECT Id_Benefactor, NombreBenefactor, ApellidoBenefactor FROM Benefactores WHERE NombreBenefactor LIKE '{nombre}'";
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

        public static bool ExisteNombreEnBD(string nombre)
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

        public static DataTable ObtenerEstadisticaBenefactores()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT c.NombreCiudad, COUNT(c.Id_Ciudad) as Cantidad FROM Benefactores b Inner Join Barrios bar ON b.Id_Barrio = bar.Id_Barrio INNER JOIN  Ciudades c ON bar.Id_Ciudad = c.Id_Ciudad GROUP BY c.NombreCiudad";

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
