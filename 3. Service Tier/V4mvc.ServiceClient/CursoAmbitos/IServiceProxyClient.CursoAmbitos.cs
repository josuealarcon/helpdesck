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

		ObservableCollection<CursoAmbitos> GetAllCursoAmbitos();

		CursoAmbitos GetOneCursoAmbito(Int32 ID);
		
		#endregion

		#region [ Metodos ]
		
		bool SaveCursoAmbito(ref CursoAmbitos item);
		
		bool DeleteCursoAmbito(ref CursoAmbitos item);
		
		bool SaveCursoAmbitos(ref ObservableCollection<CursoAmbitos> items);
		
		#endregion

	}
}
