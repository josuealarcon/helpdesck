using System;
using System.Collections.ObjectModel;
namespace V4mvc.Entities
{
	public partial class Local
	{

		#region [ Variables Validación ]
		#endregion

		#region [ Propiedades Validación ]
		public Boolean CHECKED { get; set; }

		public Boolean DISABLED { get; set; }
		public string SERVICIO { get; set; }
		public string DESCRIPCION { get; set; }
		public string CLAVE { get; set; }
		public Boolean EXISTE { get; set; }
		public string IDEMPRESA { get; set; }
		public string RUT { get; set; }
        public ObservableCollection<Local> listServiciosChecked { get; set; }
		public int EXISTE_SERVICIO { get; set; }

		#endregion


	}
}
