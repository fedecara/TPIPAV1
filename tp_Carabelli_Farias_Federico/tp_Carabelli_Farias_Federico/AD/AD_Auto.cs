using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tp_Carabelli_Farias_Federico.Entidades;

namespace tp_Carabelli_Farias_Federico.AD
{
    public class AD_Auto
    {
        public static DataTable CargarGrillaAuto()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {

                SqlCommand cmd = new SqlCommand();

                string consulta = "select IdMarca, Nombre from Automovil";

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
                MessageBox.Show(ex.Message);
                throw;
            }

            finally
            {
                cn.Close();

            }
        }

        public static bool InsertarAuto(Auto au)
        {

            bool resultado = false;
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "insert into Automovil(IdMarca,Nombre) values (@Nombre,@Id)";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nombre", au.NombreAuto);
                cmd.Parameters.AddWithValue("@Id", au.IdMarcaAuto);



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



    }
    
       
}
