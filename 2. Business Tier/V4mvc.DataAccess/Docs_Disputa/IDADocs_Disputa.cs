using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDADocs_Disputa
	{
		
		#region [ Consultas ]
		ObservableCollection<Docs_Disputa> GetAll();
        Docs_Disputa GetOne();
        #endregion

        #region [ Metodos ]
        bool Save(ref Docs_Disputa Item);
		#endregion
		
	}
}
