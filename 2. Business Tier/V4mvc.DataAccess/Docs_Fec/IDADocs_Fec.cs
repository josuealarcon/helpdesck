using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDADocs_Fec
	{
		
		#region [ Consultas ]
		ObservableCollection<Docs_Fec> GetAll();
        Docs_Fec GetOne();
        #endregion

        #region [ Metodos ]
        bool Save(ref Docs_Fec Item);
		#endregion
		
	}
}
