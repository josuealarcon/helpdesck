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

		ObservableCollection<CursoClasificaciones> GetAllCursoClasificaciones();

		CursoClasificaciones GetOneCursoClasificacion(Int32 ID);
		
		#endregion

		#region [ Metodos ]
		
		bool SaveCursoClasificacion(ref CursoClasificaciones item);
		
		bool DeleteCursoClasificacion(ref CursoClasificaciones item);
		
		bool SaveCursoClasificaciones(ref ObservableCollection<CursoClasificaciones> items);
		
		#endregion

	}
}
