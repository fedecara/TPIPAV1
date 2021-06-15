using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_Carabelli_Farias_Federico.Entidades
{
    public class Auto
    {
        private int IdMarca;
        private string Nombre;
        public Auto()
        {

        }

        public int IdMarcaAuto
        {
            get => IdMarca;
            set => IdMarca = value;
        }

        public string NombreAuto
        {
            get => Nombre;
            set => Nombre = value;
        }
    }
        
}
