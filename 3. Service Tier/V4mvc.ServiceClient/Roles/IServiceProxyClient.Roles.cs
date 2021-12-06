using System;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{
		
		#region [ Consultas ]
		ObservableCollection<Roles> GetAllRoles();
		Roles GetOneRoles(String ROL, String AREA, String PROCESO, String SUBPROCESO);
		#endregion
		
		#region [ Metodos ]
		Boolean SaveRoles(ref Roles Item);
		Boolean SaveRoles(ref ObservableCollection<Roles> Items);
		#endregion
		
	}
}
