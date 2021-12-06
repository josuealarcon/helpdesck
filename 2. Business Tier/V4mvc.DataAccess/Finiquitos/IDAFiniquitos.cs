using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAFiniquitos
	{
		
		#region [ Consultas ]
		ObservableCollection<Finiquitos> GetAll();
		Finiquitos GetOne(String Rut, String FechaCambio);
		#endregion
		
		#region [ Metodos ]
		bool Save(ref Finiquitos Item);
		#endregion
		
	}
}
