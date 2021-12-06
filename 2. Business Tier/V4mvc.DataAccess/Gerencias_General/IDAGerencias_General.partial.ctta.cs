using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAGerencias_General
	{
		#region [ Consultas ]
		ObservableCollection<Gerencias_General> GetGGeneralPorDivision(Gerencias_General gerencias_General);
		#endregion

		#region [ Metodos ]

		#endregion
	}
}
