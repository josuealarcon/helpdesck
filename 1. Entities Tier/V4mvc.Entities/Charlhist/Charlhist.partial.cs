using System.Collections.ObjectModel;

namespace V4mvc.Entities
{
	public partial class Charlhist
	{

		public string FECHAINI { get; set; }
		public string FECHAFIN { get; set; }
		public string DIVCOD { get; set; }
		public string NOMBRES { get; set; }
		public string APELLIDOS { get; set; }
		public string ACRONIMO { get; set; }
		public string FECHA_FORMATO
		{
			get
			{
				return Utils.Fec_User(FECHA, Utils.Formato_Fecha.GuionMesLetras);
			}
		}

	}
}