using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAWorkersLocal_Bono_Resumen
	{

		#region [ Consultas ]

		ObservableCollection<WorkersLocal_Bono_Resumen> GetAll();
		WorkersLocal_Bono_Resumen GetOne(String RUT, String DIVISION, String EMPRESA);

		#endregion

		#region [ Métodos ]

		bool Save(ref WorkersLocal_Bono_Resumen Item);

		#endregion

	}
}