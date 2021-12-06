using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{

		#region [ Consultas ]
		ObservableCollection<Turno_Disputa> GetAll();
		Turno_Disputa GetOne(int ID_DISPUTA);
		#endregion

		#region [ Metodos ]

		#endregion

	}
}
