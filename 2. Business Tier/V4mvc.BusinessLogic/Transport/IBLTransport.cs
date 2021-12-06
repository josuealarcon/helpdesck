using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLTransport
	{
		
		#region [ Consultas ]
		ObservableCollection<Transport> GetAll();
        Transport GetOne(string PATENTE);
        #endregion

        #region [ Metodos ]
        Boolean Save(ref Transport Item);
		Boolean Save(ref ObservableCollection<Transport> Items);
		#endregion
		
	}
}
