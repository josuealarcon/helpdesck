using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDALicencias
	{
		
		#region [ Consultas ]
		ObservableCollection<Licencias> GetAll();
		#endregion
		
		#region [ Metodos ]
		bool Save(ref Licencias Item);
		#endregion
		
	}
}
