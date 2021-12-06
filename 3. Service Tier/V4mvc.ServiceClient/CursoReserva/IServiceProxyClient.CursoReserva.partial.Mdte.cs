using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{

		#region [ Consultas ]

		ObservableCollection<CursoReserva> GetList_A142_RESERVAS_Mdte(int CODIGO);
		ObservableCollection<CursoReserva> GetList_A142_RESULTADOS_Mdte(int CODIGO);
		string ValidarReserva_Mdte(int CURSO, string RUT, int CODIGO);

		#endregion

		#region [ Metodos ]
		Boolean SaveCursoReserva_Mdte(ref CursoReserva Item);
		#endregion

	}
}
