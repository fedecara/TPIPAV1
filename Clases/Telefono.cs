using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Clases
{
    public class Telefono
    {
        private string NumeroTelefono;
        private int IdBen;
        private int IdTipoTel;
        private string TipoTelefonos;

        public Telefono(string telefono)
        {
            NumeroTelefono = telefono;
           

        }
        public Telefono()
        {

        }

        public int IdBenefactor
        {
            get => IdBen;
            set => IdBen = value;
        }
        
        public int IdTipoTelefono
        {
            get => IdTipoTel;
            set => IdTipoTel = value;
        }

         public string NumTelefono
        {
            get => NumeroTelefono;
            set => NumeroTelefono = value;
        }
        public string TipodeTelefono
        {
            get => TipoTelefonos;
            set => TipoTelefonos = value;
        }
    }
}
