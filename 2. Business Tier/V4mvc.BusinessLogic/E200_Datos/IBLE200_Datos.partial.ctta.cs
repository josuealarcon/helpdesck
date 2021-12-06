using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLE200_Datos
	{
		#region [ Consultas ]
		ObservableCollection<E200_Datos> GetAllE200_DatosCtta(ref E200_Datos e200_Datos);

		#endregion

		#region [ Metodos ]

		#endregion
	}
}
