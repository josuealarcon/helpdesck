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

		ObservableCollection<CursosProgramados> GetAllCursosProgramados(ref CursosProgramados cursosProgramado);

		CursosProgramados GetOneCursoProgramado(Int32 CODIGO);

		#endregion

		#region [ Metodos ]

		bool SaveCursoProgramado(ref CursosProgramados item);
		
		bool DeleteCursoProgramado(ref CursosProgramados item);
		
		bool SaveCursosProgramados(ref ObservableCollection<CursosProgramados> items);
		
		#endregion

	}
}
