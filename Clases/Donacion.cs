using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Clases
{
    public class Donacion
    {
        private int IdBenefactor;
        private int CuilBeneficiario;
        private int LegajoEmpleadoRecibio;
        private int LegajoEmpleadoEntrego;
        private DateTime Fecha;
        private int IdTipoMercaderia;
        private DateTime FechaVencimiento;
        private int IdEstadoMercaderia;
        private int IdCampaña;
        private int IdTipoDonacion;

        public Donacion()
        {

        }

        public int IdBenefactorDonacion
        {
            get => IdBenefactor;
            set => IdBenefactor = value;
        }

        public int CuildBeneficiarioDonacion
        {
            get => CuilBeneficiario;
            set => CuilBeneficiario = value;
        }

        public int LegajoEmpRecibioDonacion
        {
            get => LegajoEmpleadoRecibio;
            set => LegajoEmpleadoRecibio = value;
        }

        public int LegajoEmpEntregoDonacion
        {
            get => LegajoEmpleadoEntrego;
            set => LegajoEmpleadoEntrego = value;
        }

        public DateTime FechaDonacion
        {
            get => Fecha;
            set => Fecha = value;
        }

        public int IdTipoMercaderiaDonacion
        {
            get => IdTipoMercaderia;
            set => IdTipoMercaderia = value;
        }

        public DateTime FechaVencimientoMercaderiaDonada
        {
            get => FechaVencimiento;
            set => FechaVencimiento = value;
        }

        public int IdEstadoMercaderiaDonada
        {
            get => IdEstadoMercaderia;
            set => IdEstadoMercaderia = value;
        }

        public int IdCampañaDonacion
        {
            get => IdCampaña;
            set => IdCampaña = value;
        }

        public int IdTipoDonac
        {
            get => IdTipoDonacion;
            set => IdTipoDonacion = value;
        }
    }
}
