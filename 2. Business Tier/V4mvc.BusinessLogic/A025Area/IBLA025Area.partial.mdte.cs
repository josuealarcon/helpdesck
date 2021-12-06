using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLA025Area
	{
		#region [ Consultas ]
		ObservableCollection<A025Area> GetAllAreas_Mdte();
		#endregion

		#region [ Metodos ]

		#endregion
	}
}
