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
		Turno_Disputa GetOneTurnoDisputa(int ID_TURNO, int ID_DISPUTA);
		#endregion

		#region [ Metodos ]
		bool SaveTurnoDisputa(ref Turno_Disputa item);
		#endregion

	}
}
