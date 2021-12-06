using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDADotacion_Servicios_Ost
	{

		#region [ Consultas ]

		ObservableCollection<Dotacion_Servicios_Ost> GetAllServiciosOST_Mdte(string OST, string MANDANTE, string USUARIO);

		#endregion

		#region [ Metodos ]

		bool SaveDotacionServiciosOST_Mdte(ref Dotacion_Servicios_Ost Item);

		#endregion

	}
}
