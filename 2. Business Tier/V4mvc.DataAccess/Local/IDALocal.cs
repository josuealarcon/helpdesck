using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDALocal
	{
		
		#region [ Consultas ]
		ObservableCollection<Local> GetAll();
		Local GetOne(String LOCAL, String EMPRESAL, String LOCALL);
		#endregion
		
		#region [ Metodos ]
		bool Save(ref Local Item);
		#endregion
		
	}
}
