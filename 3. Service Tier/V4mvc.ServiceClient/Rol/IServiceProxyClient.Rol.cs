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
		ObservableCollection<Rol> GetAllRol();
		Rol GetOneRol(Int32 ID_ROL);
		#endregion
		
		#region [ Metodos ]
		Boolean SaveRol(ref Rol Item);
		Boolean SaveRol(ref ObservableCollection<Rol> Items);
		#endregion
		
	}
}
