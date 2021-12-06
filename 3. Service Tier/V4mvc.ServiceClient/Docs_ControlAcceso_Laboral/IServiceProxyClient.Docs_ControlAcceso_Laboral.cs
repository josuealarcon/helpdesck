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
		ObservableCollection<Docs_ControlAcceso_Laboral> GetAllDocs_ControlAcceso_Laboral();
		#endregion
		
		#region [ Metodos ]
		Boolean SaveDocs_ControlAcceso_Laboral(ref Docs_ControlAcceso_Laboral Item);
		Boolean SaveDocs_ControlAcceso_Laboral(ref ObservableCollection<Docs_ControlAcceso_Laboral> Items);
		#endregion
		
	}
}
