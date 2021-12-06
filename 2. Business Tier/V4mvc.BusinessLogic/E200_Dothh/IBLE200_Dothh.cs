using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLE200_Dothh
	{
		#region [ Consultas ]

		ObservableCollection<E200_Dothh> GetAll();

		E200_Dothh GetOne(Guid ID);

		#endregion

		#region [ Metodos ]

		bool Save(ref E200_Dothh item);

		bool Delete(ref E200_Dothh item);

		bool Save(ref ObservableCollection<E200_Dothh> items);

		#endregion
	}
}
