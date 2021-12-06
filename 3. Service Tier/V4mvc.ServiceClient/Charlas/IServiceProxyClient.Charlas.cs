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
		ObservableCollection<Charlas> GetAllCharlas();
		Charlas GetOneCharlas(Int32 IDCHARLA);
		#endregion
		
		#region [ Metodos ]
		Boolean SaveCharlas(ref Charlas Item);
		Boolean SaveCharlas(ref ObservableCollection<Charlas> Items);
		#endregion
		
	}
}
