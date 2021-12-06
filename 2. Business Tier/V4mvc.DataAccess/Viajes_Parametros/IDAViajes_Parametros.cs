using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAViajes_Parametros
	{
		
		#region [ Consultas ]
		ObservableCollection<Viajes_Parametros> GetAll();
		#endregion
		
		#region [ Metodos ]
		bool Save(ref Viajes_Parametros Item);
		#endregion
		
	}
}
