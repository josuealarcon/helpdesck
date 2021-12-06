using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLDocs_ControlAcceso_Laboral_Disputa
	{
		
		#region [ Consultas ]
		ObservableCollection<Docs_ControlAcceso_Laboral_Disputa> GetAll();
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Docs_ControlAcceso_Laboral_Disputa Item);
		Boolean Save(ref ObservableCollection<Docs_ControlAcceso_Laboral_Disputa> Items);
		#endregion
		
	}
}
