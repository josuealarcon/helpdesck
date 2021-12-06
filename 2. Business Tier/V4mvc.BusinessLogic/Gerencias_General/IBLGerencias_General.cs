using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLGerencias_General
	{
		#region [ Consultas ]

		ObservableCollection<Gerencias_General> GetAll();

		Gerencias_General GetOne(decimal IDGENERAL);

		#endregion

		#region [ Metodos ]

		bool Save(ref Gerencias_General item);

		bool Delete(ref Gerencias_General item);

		bool Save(ref ObservableCollection<Gerencias_General> items);

		#endregion
	}
}
