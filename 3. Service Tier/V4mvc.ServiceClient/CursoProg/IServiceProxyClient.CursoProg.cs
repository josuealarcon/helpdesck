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
		ObservableCollection<CursoProg> GetAllCursoProg();
		CursoProg GetOneCursoProg(Int32 CODIGO);
		#endregion
		
		#region [ Metodos ]
		Boolean SaveCursoProg(ref CursoProg Item);
		Boolean SaveCursoProg(ref ObservableCollection<CursoProg> Items);
		#endregion
		
	}
}
