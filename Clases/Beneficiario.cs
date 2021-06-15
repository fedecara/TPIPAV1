using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Clases
{
    public class Beneficiario
    {
		private int idBene;
		private string cuilBene;
		private string nombreBene;
		private string apellidoBene;
		private int sexo;
		private DateTime fechaNac;
		private int situacion;
		private int enfermedad;
		private int numeroCalle;
		private string nombreCalle;
		private int barrio;
		private int categoria;
		private int estado;


		public Beneficiario()
		{

		}

		public int IdBeneficiario
		{
			get => idBene;
			set => idBene = value;
		}
		public string Cuil
		{
			get => cuilBene;
			set => cuilBene = value;
		}

		public string Nombre
		{
			get => nombreBene;
			set => nombreBene = value;
		}
		public string Apellido
		{
			get => apellidoBene;
			set => apellidoBene = value;
		}
		public int Sexo
		{
			get => sexo;
			set => sexo = value;
		}

		public DateTime Fecha
		{
			get => fechaNac;
			set => fechaNac = value;
		}
		public int Situacion
		{
			get => situacion;
			set => situacion = value;
		}
		public int Enfermedad
		{
			get => enfermedad;
			set => enfermedad = value;
		}
		public int NumCalle
		{
			get => numeroCalle;
			set => numeroCalle = value;
		}
		public string NombreCalle
		{
			get => nombreCalle;
			set => nombreCalle = value;
		}
		public int Barrio
		{
			get => barrio;
			set => barrio = value;
		}
		public int Categoria
		{
			get => categoria;
			set => categoria = value;
		}
		public int Estado
		{
			get => estado;
			set => estado = value;
		}
	}
}
