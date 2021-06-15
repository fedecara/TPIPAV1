using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Clases
{
    public class Empleado
    {
        private string Nombre;
        private string Apellido;
        private int IdTipoDocumento;
        private string NroDocumento;
        private string NroCalle;
        private string NombreCalle;
        private int IdBarrio;
        private DateTime FechaIngreso;
        private string NroTelefono;
        private int Legajo;
        
        public Empleado(string documento)
        {
            NroDocumento = documento;
        }

        public Empleado()
        {

        }

        public int LegajoEmpleado
        {
            get => Legajo;
            set => Legajo = value;
        }

        public string NombreEmpleado
        {
            get => Nombre;
            set => Nombre = value;
        }

        public string ApellidoEmpleado
        {
            get => Apellido;
            set => Apellido = value;
        }

        public int TipoDocumentoEmpleado
        {
            get => IdTipoDocumento;
            set => IdTipoDocumento = value;
        }

        public string DocumentoEmpleado
        {
            get => NroDocumento;
            set => NroDocumento = value;
        }

        public string NroCalleEmpleado
        {
            get => NroCalle;
            set => NroCalle = value;
        }

        public string CalleEmpleado
        {
            get => NombreCalle;
            set => NombreCalle = value;
        }

        public int BarrioEmpleado
        {
            get => IdBarrio;
            set => IdBarrio = value;
        }

        public DateTime FechaIngresoEmpleado
        {
            get => FechaIngreso;
            set => FechaIngreso = value;
        }

        public string TelefonoEmpleado
        {
            get => NroTelefono;
            set => NroTelefono = value;
        }
    }
}
