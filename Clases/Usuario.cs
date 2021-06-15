using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Clases
{
    public class Usuario
    {
        private string nombreUsuario;
        private string pass;

        public Usuario()
        {

        }

        public Usuario(string nombreUsuario, string pass)
        {
            this.nombreUsuario = nombreUsuario;
            this.pass = pass;

        }

        public string NOMBREDEUSUARIO
        {
            get => nombreUsuario;
            set => nombreUsuario = value;
        }

        public string PASSWORD
        {
            get => pass;
            set => pass = value;

        }
    }
}
