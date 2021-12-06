using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLCharlas
	{
		
		#region [ Consultas ]
		ObservableCollection<Charlas> GetAll();
		Charlas GetOne(Int32 IDCHARLA);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Charlas Item);
		Boolean Save(ref ObservableCollection<Charlas> Items);
		#endregion
		
	}
}
