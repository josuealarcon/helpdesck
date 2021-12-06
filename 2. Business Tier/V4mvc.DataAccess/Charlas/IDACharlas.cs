using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDACharlas
	{
		
		#region [ Consultas ]
		ObservableCollection<Charlas> GetAll();
		Charlas GetOne(Int32 IDCHARLA);
		#endregion
		
		#region [ Metodos ]
		bool Save(ref Charlas Item);
		#endregion
		
	}
}
