using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAE200_Dothh
	{
		#region [ Consultas ]
		ObservableCollection<E200_Dothh> GetSubContratistasE200Dot_Ctta(string OST);
		ObservableCollection<E200_Dothh> GetAllE200_Datos_Dothh_SubcontratistaCtta(Guid ID);
		#endregion

		#region [ Metodos ]
		bool Save_E200_Dothh_Ctta(ref E200_Dothh item);
		#endregion
	}
}
