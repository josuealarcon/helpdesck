using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{

		#region [ Consultas ]

		ObservableCollection<WorkersLocal_Bono_Resumen> GetAllWorkersLocal_Bono_Resumen();
		WorkersLocal_Bono_Resumen GetOneWorkersLocal_Bono_Resumen(String RUT, String DIVISION, String EMPRESA);

		#endregion

		#region [ Métodos ]

		Boolean SaveWorkersLocal_Bono_Resumen(ref WorkersLocal_Bono_Resumen Item);
		Boolean SaveWorkersLocal_Bono_Resumen(ref ObservableCollection<WorkersLocal_Bono_Resumen> Items);

		#endregion

	}
}
