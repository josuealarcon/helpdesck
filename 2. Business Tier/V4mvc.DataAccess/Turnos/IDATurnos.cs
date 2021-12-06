using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDATurnos
	{
		
		#region [ Consultas ]
		ObservableCollection<Turnos> GetAll();
        Turnos GetOne(int IDTURNO);
        #endregion

        #region [ Metodos ]
        bool Save(ref Turnos Item);
		#endregion
		
	}
}
