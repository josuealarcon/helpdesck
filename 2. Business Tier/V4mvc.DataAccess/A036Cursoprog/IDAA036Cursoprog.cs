using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAA036Cursoprog
	{
		#region [ Consultas ]

		ObservableCollection<A036Cursoprog> GetAll();

		A036Cursoprog GetOne(Int32 CODIGO);

		#endregion

		#region [ Metodos ]

		bool Save(ref A036Cursoprog item);

		bool Delete(ref A036Cursoprog item);

		#endregion
	}
}
