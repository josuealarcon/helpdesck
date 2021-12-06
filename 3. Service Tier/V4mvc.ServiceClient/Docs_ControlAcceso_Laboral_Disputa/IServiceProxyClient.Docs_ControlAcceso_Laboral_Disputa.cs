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
		ObservableCollection<Docs_ControlAcceso_Laboral_Disputa> GetAllDocs_ControlAcceso_Laboral_Disputa();
		#endregion
		
		#region [ Metodos ]
		Boolean SaveDocs_ControlAcceso_Laboral_Disputa(ref Docs_ControlAcceso_Laboral_Disputa Item);
		Boolean SaveDocs_ControlAcceso_Laboral_Disputa(ref ObservableCollection<Docs_ControlAcceso_Laboral_Disputa> Items);
		#endregion
		
	}
}
