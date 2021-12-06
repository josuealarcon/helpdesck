using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLDotacion_Servicios_Ost
	{

		#region [ Consultas ]

		ObservableCollection<Dotacion_Servicios_Ost> GetAllServiciosOST_Mdte(string OST, string MANDANTE, string USUARIO);

		#endregion

		#region [ Metodos ]

		bool SaveDotacionServiciosOST_Mdte(ref Dotacion_Servicios_Ost Item);
		bool SaveDotacionServiciosOST_Mdte(ObservableCollection<Dotacion_Servicios_Ost> Items);

		#endregion

	}
}
