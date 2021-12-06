using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLCharlhist
	{

		#region [ Consultas ]

		ObservableCollection<Charlhist> GetAll();
		Charlhist GetOne(Int32 IDCHARLA);

		#endregion

		#region [ Metodos ]

		Boolean Save(ref Charlhist Item);
		Boolean Save(ref ObservableCollection<Charlhist> Items);

		#endregion

	}
}
