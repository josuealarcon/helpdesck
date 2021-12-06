using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLArchivos
	{
		
		#region [ Consultas ]
		ObservableCollection<Archivos> GetAll();
        Archivos GetOne(Guid ID);
        #endregion

        #region [ Metodos ]
        Boolean Save(ref Archivos Item);
		Boolean Save(ref ObservableCollection<Archivos> Items);
		#endregion
		
	}
}
