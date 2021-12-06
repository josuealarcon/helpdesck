using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLE200_Dothh
	{
		#region [ Consultas ]
		ObservableCollection<E200_Dothh> GetSubContratistasE200Dot_Ctta(string OST);
		#endregion

		#region [ Metodos ]
		bool Save_E200_Dothh_Ctta(ref ObservableCollection<E200_Dothh> items);
		ObservableCollection<E200_Dothh> GetAllE200_Datos_Dothh_SubcontratistaCtta(Guid ID);
		#endregion
	}
}
