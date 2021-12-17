using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDASolicitud
	{
		#region [ Consultas ]

		ObservableCollection<Solicitud> GetAll();

		Solicitud GetOne(Int32 ID_SOLICITUD);

		#endregion

		#region [ Metodos ]

		bool Save(ref Solicitud item);

		bool Delete(ref Solicitud item);

		#endregion
	}
}
