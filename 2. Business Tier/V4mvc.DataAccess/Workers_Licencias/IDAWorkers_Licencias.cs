using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAWorkers_Licencias
	{
		
		#region [ Consultas ]
		ObservableCollection<Workers_Licencias> GetAll();
		#endregion
		
		#region [ Metodos ]
		bool Save(ref Workers_Licencias Item);
		#endregion
		
	}
}
