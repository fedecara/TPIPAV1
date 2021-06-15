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
    public class AD_Telefonos
    {

        public static bool actualizarTelefonos(Telefono tel)
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
                string consulta = "UPDATE Telefonos SET Nro_Telefono = @numero, Id_Benefactor = @benefactor,Id_TipoTelefono = @tipotel WHERE Nro_Telefono LIKE @numero";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@numero", tel.NumTelefono);
                cmd.Parameters.AddWithValue("@benefactor", tel.IdBenefactor);
                cmd.Parameters.AddWithValue("@tipotel", tel.IdTipoTelefono);
               
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
        public static Telefono obtenerTelefono(string Numero)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            Telefono t = new Telefono();
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Telefonos where Nro_Telefono like @numero";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@numero", Numero);

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr != null && dr.Read())
                {

                    t.NumTelefono = dr["Nro_Telefono"].ToString();
                    t.IdBenefactor = int.Parse(dr["Id_Benefactor"].ToString());
                    t.TipodeTelefono = dr["Id_TipoTelefono"].ToString();


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

            return t;
        }
        public static DataTable obtenerListadoTelefonos()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Telefonos";
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

        public static bool AgregarTelefono(Telefono tel)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Telefonos (Id_Benefactor,Nro_Telefono,Id_TipoTelefono) VALUES(@benefactor,@numero,@tipotelefono)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@benefactor", tel.IdBenefactor);
                cmd.Parameters.AddWithValue("@numero", tel.NumTelefono);
                cmd.Parameters.AddWithValue("@tipotelefono", tel.IdTipoTelefono);
                
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
        public static bool  existeBenefactor(int idBenefacor)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            bool resultado = false;
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Benefactores WHERE Id_Benefactor LIKE "+idBenefacor;
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable tabla = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
                 
                if(tabla.Rows.Count > 0)
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

    }
}
