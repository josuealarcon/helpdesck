using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLSolicitud
	{
		#region [ Consultas ]

		ObservableCollection<Solicitud> GetAll();

		Solicitud GetOne(Int32 ID_SOLICITUD);

		#endregion

		#region [ Metodos ]

		bool Save(ref Solicitud item);

		bool Delete(ref Solicitud item);

		bool Save(ref ObservableCollection<Solicitud> items);

		#endregion
	}
}
