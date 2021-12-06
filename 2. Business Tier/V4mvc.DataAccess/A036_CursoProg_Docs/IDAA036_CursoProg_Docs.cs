using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAA036_CursoProg_Docs
	{

		#region [ Consultas ]
		A036_CursoProg_Docs GetOne(Guid Codigo);
		ObservableCollection<A036_CursoProg_Docs> GetAll();
		#endregion

		#region [ Metodos ]
		bool Save(ref A036_CursoProg_Docs Item);
		#endregion

	}
}
