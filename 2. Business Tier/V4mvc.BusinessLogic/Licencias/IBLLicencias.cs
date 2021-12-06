using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLLicencias
	{
		
		#region [ Consultas ]
		ObservableCollection<Licencias> GetAll();
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Licencias Item);
		Boolean Save(ref ObservableCollection<Licencias> Items);
		#endregion
		
	}
}
