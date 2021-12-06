using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLCursoProg
	{
		
		#region [ Consultas ]
		ObservableCollection<CursoProg> GetAll();
		CursoProg GetOne(Int32 CODIGO);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref CursoProg Item);
		Boolean Save(ref ObservableCollection<CursoProg> Items);
		#endregion
		
	}
}
