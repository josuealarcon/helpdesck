using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLWorkersLocal
	{
		
		#region [ Consultas ]
		ObservableCollection<WorkersLocal> GetAll();
        WorkersLocal GetOne(String RUT, String DIVISION, String EMPRESA);

        #endregion

        #region [ Metodos ]
        Boolean Save(ref WorkersLocal Item);
		Boolean Save(ref ObservableCollection<WorkersLocal> Items);
		#endregion
		
	}
}
