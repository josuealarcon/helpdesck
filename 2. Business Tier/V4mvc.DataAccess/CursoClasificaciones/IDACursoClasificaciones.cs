using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDACursoClasificaciones
	{
		#region [ Consultas ]

		ObservableCollection<CursoClasificaciones> GetAll();

		CursoClasificaciones GetOne(Int32 ID);

		#endregion

		#region [ Metodos ]

		bool Save(ref CursoClasificaciones item);

		bool Delete(ref CursoClasificaciones item);

		#endregion
	}
}
