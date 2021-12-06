using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDACursoProg
	{
		
		#region [ Consultas ]
		ObservableCollection<CursoProg> GetAll();
		CursoProg GetOne(Int32 CODIGO);
		#endregion
		
		#region [ Metodos ]
		bool Save(ref CursoProg Item);
		#endregion
		
	}
}
