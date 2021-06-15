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
    public partial class FormAltaNecesidad : Form
    {
        public FormAltaNecesidad()
        {
            InitializeComponent();
            CargarComboBeneficiario();
            CargarComboMotivo();
            CargarComboNiveldePrioridad();
            CargarComboTipodeDonacion();

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
                MessageBox.Show(ex.Message);
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
            txtFechaDesde.Text = "";
            txtFechaHasta.Text = "";
            cmbBeneficiario.SelectedIndex = -1;
            cmbMotivo.SelectedIndex = -1;
            cmbNivelPrioridad.SelectedIndex = -1;
            cmbTipoDonacion.SelectedIndex = -1;
        }

        private void btnGuardarDonacion_Click(object sender, EventArgs e)
        {
            if (cmbBeneficiario.SelectedItem == null || cmbNivelPrioridad.SelectedItem == null || cmbMotivo.SelectedItem == null || cmbTipoDonacion.SelectedItem == null || txtFechaDesde.Text.Equals("") || txtFechaHasta.Text.Equals(""))
            {
                MessageBox.Show("Faltan datos por completar");
            }
            else
            {

                DateTime Desde = DateTime.Parse(txtFechaDesde.Text);
                DateTime Hasta = DateTime.Parse(txtFechaHasta.Text);
                string Id_Bene = cmbBeneficiario.SelectedValue.ToString();
                string Donacion = cmbTipoDonacion.SelectedValue.ToString();
                Necesidad nec = ObtenerDatosNecesidad();
                bool existe = AD_Necesidad.ExisteEnBD(Desde, Hasta,Id_Bene,Donacion);
                
                
                if (existe)
                {
                    MessageBox.Show("La Necesidad Ya Esta Cargada Por Favor Cargue Otra");
                    
                }
                else
                {
                    bool resultado = AD_Necesidad.AgregarNecesiadABD(nec);
                    if (resultado)
                    {
                        MessageBox.Show("Necesidad registrada con exito");
                        LimpiarCampos();
                        FormNecesidades ven = new FormNecesidades();
                        ven.Show();
                        this.Hide();
                        CargarComboBeneficiario();
                        CargarComboMotivo();
                        CargarComboNiveldePrioridad();
                        CargarComboTipodeDonacion();
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar empleado");
                    }
                }
            }
        }

        private void btnLimpiarNecesidad_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BtnAgregarBeneficiario_Click(object sender, EventArgs e)
        {
            
            string mensaje = "";
            mensaje = "¿Desea registrar un nuevo Beneficiario";
            DialogResult resultado = MessageBox.Show(mensaje, "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Usted va a Realizar un alta del Beneficiario");
                FormBeneficiarios Ventana = new FormBeneficiarios();
                Ventana.Show();
                this.Hide();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
            string mensaje = "";
            mensaje = "Desea Cancelar La Operacion";
            DialogResult resultado = MessageBox.Show(mensaje, "ALERTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                LimpiarCampos();
                FormNecesidades ventana = new FormNecesidades();
                ventana.Show();
                this.Hide();
            }
            else
            {

            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FormNecesidades ventana = new FormNecesidades();
            ventana.Show();
            this.Hide();
        }
    }

    
}
