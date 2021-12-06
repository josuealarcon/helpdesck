using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLDocs_Fec
	{
		
		#region [ Consultas ]
		ObservableCollection<Docs_Fec> GetAll();
        Docs_Fec GetOne();
        #endregion

        #region [ Metodos ]
        Boolean Save(ref Docs_Fec Item);
		Boolean Save(ref ObservableCollection<Docs_Fec> Items);
		#endregion
		
	}
}
