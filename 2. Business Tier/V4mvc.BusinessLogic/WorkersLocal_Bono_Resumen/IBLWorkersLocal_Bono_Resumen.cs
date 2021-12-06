using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLWorkersLocal_Bono_Resumen
	{

		#region [ Consultas ]

		ObservableCollection<WorkersLocal_Bono_Resumen> GetAll();
		WorkersLocal_Bono_Resumen GetOne(String RUT, String DIVISION, String EMPRESA);

		#endregion

		#region [ Métodos ]

		Boolean Save(ref WorkersLocal_Bono_Resumen Item);
		Boolean Save(ref ObservableCollection<WorkersLocal_Bono_Resumen> Items);

		#endregion

	}
}
