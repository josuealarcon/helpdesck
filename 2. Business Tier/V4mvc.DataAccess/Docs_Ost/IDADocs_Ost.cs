using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDADocs_Ost
	{
		#region [ Consultas ]

		ObservableCollection<Docs_Ost> GetAll();
		Docs_Ost GetOne(string OST);

		#endregion

		#region [ Metodos ]

		bool Save(ref Docs_Ost item);

		#endregion
	}
}
