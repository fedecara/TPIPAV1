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
    public partial class FormActualizarNecesidad : Form
    {
        public FormActualizarNecesidad()
        {
            InitializeComponent();
            CargarGrillaNecesidad();
            CargarComboBeneficiario();
            CargarComboNiveldePrioridad();
            CargarComboMotivo();
            CargarComboTipodeDonacion();
        }

        private void CargarGrillaNecesidad()
        {
            try
            {
                gdrNecesidad.DataSource = AD_Varios.ObtenerTabla("Necesidades");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al obtener tabla");
                throw;
            }
        }

        private void CargarComboBeneficiario()
        {
            try
            {
                cmbBeneficiario.DataSource = AD_Necesidad.ObtenerTablaBeneficiario("Beneficiarios");
                cmbBeneficiario.DisplayMember = "Beneficiario";
                cmbBeneficiario.ValueMember = "Id_Beneficiario";
                cmbBeneficiario.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void CargarComboMotivo()
        {
            try
            {
                cmbMotivo.DataSource = AD_Varios.ObtenerTabla("Motivos");
                cmbMotivo.DisplayMember = "NombreMotivo";
                cmbMotivo.ValueMember = "Id_Motivo";
                cmbMotivo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar combo");
            }

        }

        private void CargarComboNiveldePrioridad()
        {
            try
            {
                cmbNivelPrioridad.DataSource = AD_Varios.ObtenerTabla("Nivel_Prioridad");
                cmbNivelPrioridad.DisplayMember = "Descripcion";
                cmbNivelPrioridad.ValueMember = "Id_NivelPrioridad";
                cmbNivelPrioridad.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Error al cargar combo");
            }

        }

        private void CargarComboTipodeDonacion()
        {
            try
            {
                cmbTipoDonacion.DataSource = AD_Varios.ObtenerTabla("Tipo_Donacion");
                cmbTipoDonacion.DisplayMember = "NombreTipoDonacion";
                cmbTipoDonacion.ValueMember = "Id_TipoDonacion";
                cmbTipoDonacion.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combo");
            }

        }

        private void btnBuscarFecha_Click(object sender, EventArgs e)
        {
            if (cmbBeneficiario.SelectedItem == null)
            {
                MessageBox.Show("Porfavor seleccione un campo");

            }
            else
            {
                string Beneficiario = cmbBeneficiario.SelectedValue.ToString();
                bool existe = AD_Necesidad.ExisteBeneficiaroEnBD(Beneficiario);
                if (existe)
                {
                    gdrNecesidad.DataSource = AD_Necesidad.BuscarBeneficiario(Beneficiario);

                }
                else
                {
                    MessageBox.Show("No se encontro ninguna necesidad relacionada a ese beneficiario");
                    string mensaje = "";
                    mensaje = "¿Desea registrar Una Nueva Necesidad?";
                    DialogResult resultado = MessageBox.Show(mensaje, "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        FormAltaNecesidad ventana = new FormAltaNecesidad();
                        ventana.Show();
                        this.Hide();
                    }
                    else
                    {
                        cmbBeneficiario.SelectedValue = -1;
                    }
                }
            }
        }

        private void CargarCombosNecesidad(Necesidad nec)
        {
            DateTime fechaDesde = nec.FechaDesdeNecesidad;
            string dia1 = "";
            string mes1 = "";
            string año1 = "";
            dia1 = fechaDesde.Date.Day.ToString();
            if (dia1.Length == 1)
            {
                dia1 = "0" + dia1;
            }
            mes1 = fechaDesde.Date.Month.ToString();
            if (mes1.Length == 1)
            {
                mes1 = "0" + mes1;
            }
            año1 = fechaDesde.Date.Year.ToString();
            txtFechaDesde.Text = dia1 + mes1 + año1;

            DateTime fechaHasta = nec.FechaHastaNecesidad;
            string dia2 = "";
            string mes2 = "";
            string año2 = "";
            dia2 = fechaHasta.Date.Day.ToString();
            if (dia2.Length == 1)
            {
                dia2 = "0" + dia2;
            }
            mes2 = fechaDesde.Date.Month.ToString();
            if (mes2.Length == 1)
            {
                mes2 = "0" + mes2;
            }
            año2 = fechaDesde.Date.Year.ToString();
            txtFechaHasta.Text = dia2 + mes2 + año2;

            //txtFechaDesde.Text= nec.FechaDesdeNecesidad.Date.ToShortDateString();
            //txtFechaHasta.Text = nec.FechaHastaNecesidad.Date.ToShortDateString();
            cmbBeneficiario.SelectedValue = nec.Beneficiario;
            cmbMotivo.SelectedValue = nec.Motivo;
            cmbNivelPrioridad.SelectedValue = nec.NivelPrioridad;
            cmbTipoDonacion.SelectedValue = nec.TipoDonacion;
        }

        
        private void gdrNecesidad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int indice = e.RowIndex;
        
            DataGridViewRow FilaSeleccionada = gdrNecesidad.Rows[indice];
            string id = FilaSeleccionada.Cells["IdNecesidad"].Value.ToString();
            Necesidad nec = AD_Necesidad.ObtenerNecesidad(id);
            CargarCombosNecesidad(nec);
            txtFechaDesde.Enabled = false;
            txtFechaHasta.Enabled = false;
            cmbBeneficiario.Enabled = false;
            
        }

        private Necesidad ObtenerDatosNecesidad()
        {
            Necesidad nec = new Necesidad();
            nec.FechaDesdeNecesidad = DateTime.Parse(txtFechaDesde.Text);
            nec.FechaHastaNecesidad = DateTime.Parse(txtFechaHasta.Text);
            nec.Beneficiario = (int)cmbBeneficiario.SelectedValue;
            nec.NivelPrioridad = (int)cmbNivelPrioridad.SelectedValue;
            nec.TipoDonacion = (int)cmbTipoDonacion.SelectedValue;
            nec.Motivo = (int)cmbMotivo.SelectedValue;
            return nec;

        }
        private void LimpiarCampos()
        {
            cmbBeneficiario.Enabled = true;
            txtFechaDesde.Text = "";
            txtFechaHasta.Text = "";
            cmbMotivo.SelectedIndex = -1;
            cmbNivelPrioridad.SelectedIndex = -1;
            cmbTipoDonacion.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string mensaje = "";
            mensaje = "¿Quiere ancelar la operacion?";
            DialogResult resultado = MessageBox.Show(mensaje, "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                FormNecesidades ventana = new FormNecesidades();
                ventana.Show();
                this.Hide();
            }
            else
            {

            }
           
        }

        private void btnGuardarNecesidad_Click(object sender, EventArgs e)
        {
            try
            {
                Necesidad Nec = ObtenerDatosNecesidad();
                bool resultado = AD_Necesidad.ActualizarNecesidadBD(Nec);
                if(resultado)
                {
                    MessageBox.Show("Necesidad actualizada con exito");
                    LimpiarCampos();
                    CargarComboBeneficiario();
                    CargarComboMotivo();
                    CargarComboNiveldePrioridad();
                    CargarComboTipodeDonacion();
                    CargarGrillaNecesidad();
                }
            }
            catch (Exception)
            {
               MessageBox.Show("Error al actualizar necesidad");
            }
        }

        private void FormActualizarNecesidad_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormNecesidades ventana = new FormNecesidades();
            ventana.Show();
            this.Hide();
        }

        private void btnLimpiarNecesidad_Click_1(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
    
}
