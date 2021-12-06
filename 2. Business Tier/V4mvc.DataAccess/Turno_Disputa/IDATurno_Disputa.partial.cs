using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDATurno_Disputa
	{

		#region [ Consultas ]
		Turno_Disputa GetOneTurnoDisputa(int ID_TURNO, int ID_DISPUTA);
		#endregion

		#region [ Metodos ]
		bool SaveTurnoDisputa(ref Turno_Disputa Item);
		#endregion
	}
}
