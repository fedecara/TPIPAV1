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
using TPI.Presentaciones;

namespace TPI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtNombreUsuario.Text.Equals("") || txtContraseña.Text.Equals(""))
            {
                MessageBox.Show("Ingrese los datos necesarios");
            }
            else
            {
                string nombreusuario = txtNombreUsuario.Text;
                string password = txtContraseña.Text;
                bool resultado = false;

                try
                {
                    resultado = AD_Usuarios.validarUsuario(nombreusuario, password);
                    if (resultado == true)
                    {
                        Usuario usu = new Usuario(nombreusuario, password);
                        FormPrincipal ventana = new FormPrincipal();
                        ventana.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario/Contraseña incorrectos");
                    }

                }
                catch (Exception)
                {

                    throw;
                }
                
            }

        }

        //private bool validarUsuario(String nombreusuario, string password)
        //{
        //    string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["cadenaBD"];
        //    SqlConnection cn = new SqlConnection(cadenaConexion);
        //    try
        //    {
        //        bool resultado = false;

        //        SqlCommand cmd = new SqlCommand();


        //        string consulta = "SELECT * FROM Usuario WHERE NombreUsuario like @nombreUsu AND Contraseña like @pass";
        //        cmd.Parameters.Clear();
        //        cmd.Parameters.AddWithValue("@nombreUsu", nombreusuario);
        //        cmd.Parameters.AddWithValue("@pass", password);
        //        cmd.CommandType = CommandType.Text;
        //        cmd.CommandText = consulta;

        //        cn.Open();
        //        cmd.Connection = cn;

        //        DataTable tabla = new DataTable();

        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        da.Fill(tabla);

        //        if (tabla.Rows.Count == 1)
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
    }
}
