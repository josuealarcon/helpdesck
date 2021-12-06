using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDADocs
	{
		
		#region [ Consultas ]
		ObservableCollection<Docs> GetAll();
        Docs GetOne(int ID_DOC);
        #endregion

        #region [ Metodos ]
        bool Save(ref Docs Item);
		#endregion
		
	}
}
