using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI.Clases
{
	public class Campaña
	{
		private int id;
		private DateTime fechaInicio;
		private DateTime fechaFin;
		private string nombreCampaña;
		private string lemaCampaña;

		public Campaña()
		{

		}

		public Campaña(int id)
		{
			this.id = id;
		}

		public DateTime FechaIni
		{
			get => fechaInicio;
			set => fechaInicio = value;
		}
		public DateTime FechaFin
		{
			get => fechaFin;
			set => fechaFin = value;
		}

		public string Nombre
		{
			get => nombreCampaña;
			set => nombreCampaña = value;
		}
		public string Lema
		{
			get => lemaCampaña;
			set => lemaCampaña = value;
		}
		public int IdCampaña
		{
			get => id;
			set => id = value;
		}
	}


}
