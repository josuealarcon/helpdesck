using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLCharlas_Division
	{
		#region [ Consultas ]
		ObservableCollection<Charlas_Division> GetListDivisionesCharlas_Mdte(int IDCHARLA);
		#endregion

		#region [ Metodos ]

		#endregion
	}
}
