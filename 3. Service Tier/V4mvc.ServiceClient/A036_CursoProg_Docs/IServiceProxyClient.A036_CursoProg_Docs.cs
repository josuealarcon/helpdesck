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
		ObservableCollection<A036_CursoProg_Docs> GetAllA036_CursoProg_Docs();
		A036_CursoProg_Docs GetOneA036_CursoProg_Docs(Guid Codigo);
		#endregion

		#region [ Metodos ]
		Boolean SaveA036_CursoProg_Docs(ref A036_CursoProg_Docs Item);
		Boolean SaveA036_CursoProg_Docs(ref ObservableCollection<A036_CursoProg_Docs> Items);
		#endregion

	}
}
