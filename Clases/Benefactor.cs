using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Clases
{
    public class Benefactor
    {
        private int idbenefactor;
        private string nombrebenefactor;
        private string apellidobenefactor;
        private string nombrecalle;
        private int nrocalle;
        private int idbarrio;
        private string nrotelefono;
        private int idtipotelefono;


        public Benefactor()
        {

        }

        public int IDBENEFACTOR
        {
            get => idbenefactor;
            set => idbenefactor = value;
        }

        public int TIPOTELEFONO
        {
            get => idtipotelefono;
            set => idtipotelefono = value;
        }
        public string NROTELEFONOBENEFACTOR
        {
            get => nrotelefono;
            set => nrotelefono = value;
        }
        public string NOMBREBENEFACTOR
        {
            get => nombrebenefactor;
            set => nombrebenefactor = value;
        }
        public string APELLIDOBENEFACTOR
        {
            get => apellidobenefactor;
            set => apellidobenefactor = value;
        }
        public string NOMBRECALLE
        {
            get => nombrecalle;
            set => nombrecalle = value;
        }
        public int NROCALLE      
        {
            get => nrocalle;
            set => nrocalle = value;
        }
        public int IDBARRIO
        {
            get => idbarrio;
            set => idbarrio = value;
        }

    }

}
