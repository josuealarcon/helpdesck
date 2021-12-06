using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLCursoReserva
	{
		
		#region [ Consultas ]
		ObservableCollection<CursoReserva> GetAll(Int32 CODIGO);
		CursoReserva GetOne(Int32 CODIGO, String RUT);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref CursoReserva Item);
		Boolean Save(ref ObservableCollection<CursoReserva> Items);
		#endregion
		
	}
}
