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
		ObservableCollection<Turno_Disputa> GetAll();
		Turno_Disputa GetOne(int ID_DISPUTA);
		#endregion

		#region [ Metodos ]
		#endregion

	}
}
