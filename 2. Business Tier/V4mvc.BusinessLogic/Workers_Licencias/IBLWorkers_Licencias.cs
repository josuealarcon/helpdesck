using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLWorkers_Licencias
	{
		
		#region [ Consultas ]
		ObservableCollection<Workers_Licencias> GetAll();
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Workers_Licencias Item);
		Boolean Save(ref ObservableCollection<Workers_Licencias> Items);
		#endregion
		
	}
}
