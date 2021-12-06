using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLDocs
	{
		
		#region [ Consultas ]
		ObservableCollection<Docs> GetAll();
        Docs GetOne(int ID_DOC);
        #endregion

        #region [ Metodos ]
        Boolean Save(ref Docs Item);
		Boolean Save(ref ObservableCollection<Docs> Items);
		#endregion
		
	}
}
