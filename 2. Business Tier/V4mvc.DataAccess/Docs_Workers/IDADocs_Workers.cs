using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDADocs_Workers
	{
		
		#region [ Consultas ]
		ObservableCollection<Docs_Workers> GetAll();
        Docs_Workers GetOne();
        #endregion

        #region [ Metodos ]
        bool Save(ref Docs_Workers Item);
		#endregion
		
	}
}
