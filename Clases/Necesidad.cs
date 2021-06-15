using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Clases
{
    public class Necesidad
    {
        private DateTime FechaDesde;
        private DateTime FechaHasta;
        private int IdBeneficiario;
        private int IdMotivo;
        private int IdNivelPrioridad;
        private int IdTipoDonacion;


        public Necesidad()
        {

        }

        public DateTime FechaDesdeNecesidad
        {
            get => FechaDesde;
            set => FechaDesde = value;
        }

        public DateTime FechaHastaNecesidad
        {
            get => FechaHasta;
            set => FechaHasta = value;
        }

        public int Beneficiario
        {
            get => IdBeneficiario;
            set => IdBeneficiario = value;
        }
        public int Motivo
        {
            get => IdMotivo;
            set => IdMotivo = value;
        }
        public int NivelPrioridad
        {
            get => IdNivelPrioridad;
            set => IdNivelPrioridad = value;
        }

        public int TipoDonacion
        {
            get => IdTipoDonacion;
            set => IdTipoDonacion = value;
        }
    }
}
