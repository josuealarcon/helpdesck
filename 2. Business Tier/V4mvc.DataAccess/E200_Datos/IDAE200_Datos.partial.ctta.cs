using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAE200_Datos
	{
		#region [ Consultas ]
		ObservableCollection<E200_Datos> GetAllE200_DatosCtta(ref E200_Datos e200_Datos);
		
		#endregion

		#region [ Metodos ]

		#endregion
	}
}
