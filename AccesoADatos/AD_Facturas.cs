using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.AccesoADatos
{
    class AD_Facturas
    {
        public static int ObtenerUltimiNroFacura()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT MAX(Nro_Factura) FROM Factura ";

                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                int resultado = (int)cmd.ExecuteScalar();
                return resultado;
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                cn.Close();
            }
        }
        public static bool altaNuevaFactura(int nrofactura,int idbeneficiario, List<int> listadetalles, List<int> listacantidades, List<float> listaprecios)
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlTransaction objtransaccion = null;
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "INSERT INTO Factura VALUES(@fecha,@beneficiario) ";

                cmd.Parameters.Clear();
                //cmd.Parameters.AddWithValue("@numero", nrofactura);
                cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                cmd.Parameters.AddWithValue("@beneficiario", idbeneficiario);
                
                
                

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;


                cn.Open();
                objtransaccion = cn.BeginTransaction("AltaDeFactura");
                cmd.Connection = cn;
                cmd.Transaction = objtransaccion;

                cmd.ExecuteNonQuery();
                int i = 0;
                foreach (var Id_Servicio in listadetalles)
                {
                    
                    string consultadetallefactura = "INSERT INTO Detalle_Factura values(@nrofactura,@idservicio,@cantidad,@precio)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@idservicio", Id_Servicio);
                    cmd.Parameters.AddWithValue("@nrofactura", nrofactura);
                    //HACEMOS ESTO SI QUEREMOS AGREGAR LOS DATOS DE UNA LISTA EN UNA TABLA DE LA BASE DE DATOS.
                    cmd.Parameters.AddWithValue("@cantidad", listacantidades[i]);
                    cmd.Parameters.AddWithValue("@precio", listaprecios[i]);
                    
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = consultadetallefactura;
                    cmd.ExecuteNonQuery();
                    i += 1;
                }

                
                objtransaccion.Commit();
                return true;

            }
            catch (Exception ex)
            {
                objtransaccion.Rollback();
                return false;
            }
            finally
            {
                cn.Close();
            }
        }
        public static DataTable ObtenerListadoBeneficiariosReducido()
        {
            string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
            SqlConnection cn = new SqlConnection(cadenaConexion);
            try
            {
                SqlCommand cmd = new SqlCommand();

                string consulta = "SELECT Id_Beneficiario,NombreBeneficiario, ApellidoBeneficiario, Cuil_Beneficiario FROM Beneficiarios";

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
