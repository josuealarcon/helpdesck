using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLE200_Datos
	{
		#region [ Consultas ]

		ObservableCollection<E200_Datos> GetAll();

		E200_Datos GetOne(Guid? ID);

		#endregion

		#region [ Metodos ]

		bool Save(ref E200_Datos item);

		bool Delete(ref E200_Datos item);

		bool Save(ref ObservableCollection<E200_Datos> items);

		#endregion
	}
}
