using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Clases
{
    public class CategoriaFamiliar
    {
        private string Categoria;

        public CategoriaFamiliar(string categoria)
        {
            Categoria = categoria;
        }
        public CategoriaFamiliar()
        {

        }
        public string CateFamiliar
        {
            get => Categoria;
            set => Categoria = value;
        }
    }
}
