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

		ObservableCollection<Gerencias_General> GetAll();

		Gerencias_General GetOne(decimal IDGENERAL);

		#endregion

		#region [ Metodos ]

		bool Save(ref Gerencias_General item);

		bool Delete(ref Gerencias_General item);

		#endregion
	}
}
