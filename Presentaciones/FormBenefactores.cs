using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPI.AccesoADatos;
using TPI.Clases;

namespace TPI.Presentaciones
{
    public partial class FormBenefactores : Form
    {
        private int IDBENEFACTORSELECCIONADO;
        public FormBenefactores()
        {
            InitializeComponent();
        }

        private void FormBenefactores_Load(object sender, EventArgs e)
        {
            cargarGrillaBenefactores();
            btnActualizarBenefactor.Enabled = false;
        }

        public void cargarGrillaBenefactores()
        {
            try
            {
                dgrBenefactores.DataSource = AD_Benefactores.obtenerListadoBenefactores();
            }
            catch (Exception)
            {

                MessageBox.Show("Error al obtener benefactores");
            }
        }

        private void btnAgregarBenefactor_Click(object sender, EventArgs e)
        {
            FormAltaBenefactor ventana = new FormAltaBenefactor();
            ventana.ShowDialog();
            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreBenefactor.Text;
            dgrBenefactores.DataSource = AD_Benefactores.buscarBenefactor(nombre);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            cargarGrillaBenefactores();
        }

        private void limpiarCampos()
        {
            txtNombreBenefactor.Text = "";
           
        }

        private void btnActualizarBenefactor_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(dgrBenefactores.SelectedRows[0].Cells[0].Value.ToString());
            
            //int ID = int.Parse(filaSeleccionada.Cells["Id_Benefactor"].Value.ToString());
            FormActualizacionBenefactor ventana = new FormActualizacionBenefactor(ID);
            ventana.Show();
            this.Hide();

        }

        private void dgrBenefactores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgrBenefactores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int indice = e.RowIndex;
            //DataGridViewRow filaSeleccionada = dgrBenefactores.Rows[indice];
            //int nombre = int.Parse(filaSeleccionada.Cells["NombreBenefactor"].Value.ToString());
            //IDBENEFACTORSELECCIONADO = int.Parse(filaSeleccionada.Cells["Id_Benefactor"].Value.ToString());
           //Benefactor benef = AD_Benefactores.obtenerBenefactor(ID);
            btnActualizarBenefactor.Enabled = true;
            //btnAgregarBenefactor.Enabled = false;
            //btnLimpiar.Enabled = false;
            //cargarCampos(benef);
            
        }

        

        //txtNombreDeUsuario.Text = u.NOMBREDEUSUARIO;
        //txtPassword.Text = u.PASSWORD;


    }
}
