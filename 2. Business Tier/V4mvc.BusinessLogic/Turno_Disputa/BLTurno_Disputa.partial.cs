using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLTurno_Disputa
	{

		#region [ Consultas ]
		public Turno_Disputa GetOneTurnoDisputa(int ID_TURNO, int ID_DISPUTA)
		{
			try
			{
				return this.Repository.GetOneTurnoDisputa(ID_TURNO, ID_DISPUTA);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]
		public bool SaveTurnoDisputa(ref Turno_Disputa item)
		{
			try
			{
				return this.Repository.SaveTurnoDisputa(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

	}
}
