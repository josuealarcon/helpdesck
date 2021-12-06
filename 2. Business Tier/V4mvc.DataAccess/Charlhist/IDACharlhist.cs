using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDACharlhist
	{

		#region [ Consultas ]
		ObservableCollection<Charlhist> GetAll();
		Charlhist GetOne(Int32 IDCHARLA);
		#endregion

		#region [ Metodos ]
		bool Save(ref Charlhist Item);
		#endregion

	}
}
