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
		ObservableCollection<CursoReserva> GetAllCursoReserva(Int32 CODIGO);
		CursoReserva GetOneCursoReserva(Int32 CODIGO, String RUT);
		#endregion
		
		#region [ Metodos ]
		Boolean SaveCursoReserva(ref CursoReserva Item);
		Boolean SaveCursoReserva(ref ObservableCollection<CursoReserva> Items);
		#endregion
		
	}
}
