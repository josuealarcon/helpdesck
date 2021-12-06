using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{
		
		#region [ Consultas ]
		ObservableCollection<WorkersLocal> GetAllWorkersLocal();
        WorkersLocal GetOneWorkersLocal(String RUT, String DIVISION, String EMPRESA);

        #endregion

        #region [ Metodos ]
        Boolean SaveWorkersLocal(ref WorkersLocal Item);
		Boolean SaveWorkersLocal(ref ObservableCollection<WorkersLocal> Items);
		#endregion
		
	}
}
