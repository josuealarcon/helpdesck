using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDACursoReserva
	{
		
		#region [ Consultas ]
		ObservableCollection<CursoReserva> GetAll(Int32 CODIGO);
		CursoReserva GetOne(Int32 CODIGO, String RUT);
		#endregion
		
		#region [ Metodos ]
		bool Save(ref CursoReserva Item);
		#endregion
		
	}
}
