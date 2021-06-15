using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Clases
{
    public class Enfermedad
    {
        private int Id_Enfermedad;
        private string NombreEnfermedad;
        private string Descripcion;

        public Enfermedad()
        {

        }

        public int IdEnf
        {
            get => Id_Enfermedad;
            set => Id_Enfermedad = value;
        }
        public string NombreEnf
        {
            get => NombreEnfermedad;
            set => NombreEnfermedad = value;
        }

        public string DescipcionEnf
        {
            get => Descripcion;
            set => Descripcion = value;
        }
    }
}
