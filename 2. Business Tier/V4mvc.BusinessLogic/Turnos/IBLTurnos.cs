using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLTurnos
	{
		
		#region [ Consultas ]
		ObservableCollection<Turnos> GetAll();
        Turnos GetOne(int IDTURNO);
        #endregion

        #region [ Metodos ]
        Boolean Save(ref Turnos Item);
		Boolean Save(ref ObservableCollection<Turnos> Items);
		#endregion
		
	}
}
