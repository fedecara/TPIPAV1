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
    public partial class FormFactura : Form
    {
        public FormFactura()
        {
            InitializeComponent();
        }

        private void FormFactura_Load(object sender, EventArgs e)
        {
            cargarFecha();
            obtenerUltimaFactura();
            cargarGrillaBeneficiario();


        }

        //private void cargarComboServicios()
        //{
        //    try
        //    {
        //        cmbServicios.DataSource = AD_Varios.ObtenerTabla("Servicios");
        //        cmbServicios.DisplayMember = "NombreServicio";
        //        cmbServicios.ValueMember = "Id_Servicio";
        //        cmbServicios.SelectedIndex = -1;

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al cargar combo tipo de documentos");
        //    }

        //}

        private void cargarFecha()
        {
            txtFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void obtenerUltimaFactura()
        {
            int nro = AD_Facturas.ObtenerUltimiNroFacura();
            txtNroFactura.Text = (nro + 1).ToString();
        }

        private void cargarGrillaBeneficiario()
        {
            try
            {
                dgrBeneficiarios.DataSource = AD_Facturas.ObtenerListadoBeneficiariosReducido();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener personas");
            }
        }

        private void dgrBeneficiarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;

            DataGridViewRow filaSeleccionada = dgrBeneficiarios.Rows[indice];
            int id = int.Parse(filaSeleccionada.Cells["Id_Beneficiario"].Value.ToString());
            Beneficiario p = AD_Beneficiarios.ObtenerBeneficiario(id);

            CargarCampos(p);
        }

        private void CargarCampos(Beneficiario b)
        {
            txtNombreBeneficiario.Text = b.Nombre;
            txtApellidoBeneficiario.Text = b.Apellido;
            txtCuilBeneficiario.Text = b.Cuil;
            txtIdBeneficiario.Text = b.IdBeneficiario.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tablaResultado = AD_Servicios.obtenerServiciosXId(int.Parse(txtServicio.Text.Trim()));
                if (tablaResultado.Rows.Count > 0)
                {
                    txtNombreServicio.Text = tablaResultado.Rows[0][1].ToString();
                    txtPrecioUnitario.Text = tablaResultado.Rows[0][2].ToString();

                }
                else
                {
                    MessageBox.Show("Servicio no encontrado");
                    txtServicio.Text = "";
                    txtPrecioUnitario.Text = "";
                    txtNombreServicio.Text = "";
                    txtServicio.Focus();

                }
            }
            catch
            {
                MessageBox.Show("Error al obtener servicio");
            }
        }

        private void calcularPrecioTotal(float precioUnitario, int cantidad)
        {
            txtPrecio.Text = (precioUnitario * cantidad).ToString();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "" || txtPrecioUnitario.Text == "" )
            {
                MessageBox.Show("Ingrese una cantidad");
                txtCantidad.Focus();
            }
            else
            {
                if(int.Parse(txtCantidad.Text) > 0)
                {
                    txtCantidad.Visible = true;
                    calcularPrecioTotal(float.Parse(txtPrecioUnitario.Text), int.Parse(txtCantidad.Text));
                }
                else
                {
                    MessageBox.Show("La cantidad ingresada no es correcta");
                    txtCantidad.Focus();
                }  
            }
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "" || txtPrecioUnitario.Text == "" || txtIdBeneficiario.Text == "")
            {
                MessageBox.Show("Complete todos los campos");
                //txtCantidad.Focus();
            }
            else
            {
                if (int.Parse(txtCantidad.Text) > 0)
                {
                    txtCantidad.Visible = true;
                    calcularPrecioTotal(float.Parse(txtPrecioUnitario.Text), int.Parse(txtCantidad.Text));
                    dgrDetalles.Rows.Add(txtServicio.Text, txtNombreServicio.Text, txtCantidad.Text, txtPrecio.Text);
                }
                else
                {
                    MessageBox.Show("La cantidad ingresada no es correcta");
                    txtCantidad.Focus();
                }

            }
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            List<int> ListaDetalles = new List<int>();
            List<int> ListaCantidades = new List<int>();
            List<float> ListaPrecios = new List<float>();
            for (int i = 0; i < dgrDetalles.Rows.Count; i++)
            {
                ListaDetalles.Add(int.Parse(dgrDetalles.Rows[i].Cells[0].Value.ToString()));
                ListaCantidades.Add(int.Parse(dgrDetalles.Rows[i].Cells[2].Value.ToString()));
                ListaPrecios.Add(float.Parse(dgrDetalles.Rows[i].Cells[3].Value.ToString()));
            }
            bool resultado = AD_Facturas.altaNuevaFactura(int.Parse(txtNroFactura.Text),int.Parse(txtIdBeneficiario.Text), ListaDetalles , ListaCantidades , ListaPrecios);
            if (resultado)
            {
                MessageBox.Show("Factura dada de alta con exito");
            }
            else
            {
                MessageBox.Show("Error al dar de alta la nueva factura");
            }
        }
    }
}

