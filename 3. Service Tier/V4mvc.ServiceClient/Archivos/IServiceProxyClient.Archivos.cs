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
		ObservableCollection<Archivos> GetAllArchivos();
        Archivos GetOneArchivos(Guid ID);
        #endregion

        #region [ Metodos ]
        Boolean SaveArchivos(ref Archivos Item);
		Boolean SaveArchivos(ref ObservableCollection<Archivos> Items);
		#endregion
		
	}
}
