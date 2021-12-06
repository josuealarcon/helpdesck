using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLGerencias_General
	{
		#region [ Consultas ]
		ObservableCollection<Gerencias_General> GetGGeneralPorDivision(Gerencias_General gerencias_General);
		#endregion

		#region [ Metodos ]

		#endregion
	}
}
