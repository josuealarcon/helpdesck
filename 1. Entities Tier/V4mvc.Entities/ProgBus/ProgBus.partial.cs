using System;
using System.Text;
using System.Linq;
using System.Globalization;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.Serialization;

namespace V4mvc.Entities
{
	public partial class ProgBus
	{
		public string  DIAS { get; set; }
		public int DISPONIBLES { get; set; }
		public int RESERVAS { get; set; }
		public string FLOTA { get; set; }
		public string DESCRIPCION { get; set; }
		public int CAPACIDAD_LIBERA { get; set; }
		public int PERMITIDO { get; set; }
		public string EMPRESA { get; set; }
		public string MARCA { get; set; }
		public string MODELO { get; set; }
		public string TIPO { get; set; }
		public int ASIENTOS { get; set; }
		public int TIEMPO_CANCELA { get; set; }
		public string REALIZADO { get; set; }
		public string RUT { get; set; }
		public string NOMBRES { get; set; }
		public string APELLIDOS { get; set; }
		public string ACRONIMO { get; set; }
		public int ROWNUMBER { get; set; }
		public string USUARIO { get; set; }
		public string OST { get; set; }

		public bool EXITOSO { get; set; }
		public string MENSAJE { get; set; }
		public string TABLA { get; set; }
		public string RECORRIDOS { get; set; }
		public string FUNCIONARIOS { get; set; }

		public string FECHA_LETRA
		{
			get
			{
				return (Utils.Fec_User(FECHA, Utils.Formato_Fecha.GuionMesLetras));
			}
		}
		public string PATENTE_FORMATO
		{
			get
			{
				return (Utils.FormatoPatente(PATENTE));
			}
		}

		public string EMPRESA_FORMATO
		{
			get
			{
				return (Utils.strRut(EMPRESA));
			}
		}
		public List<ProgBus> RESERVAS_EXITOSAS { get; set; }

	}
}
