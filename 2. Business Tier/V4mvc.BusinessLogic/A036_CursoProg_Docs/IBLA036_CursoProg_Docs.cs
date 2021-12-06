using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLA036_CursoProg_Docs
	{

		#region [ Consultas ]

		A036_CursoProg_Docs GetOne(Guid Codigo);
		ObservableCollection<A036_CursoProg_Docs> GetAll();

		#endregion

		#region [ Metodos ]
		Boolean Save(ref A036_CursoProg_Docs Item);
		Boolean Save(ref ObservableCollection<A036_CursoProg_Docs> Items);
		#endregion

	}
}
