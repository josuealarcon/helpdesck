using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLLotePasesFun
	{
		
		#region [ Consultas ]
		ObservableCollection<LotePasesFun> GetAll();
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref LotePasesFun Item);
		Boolean Save(ref ObservableCollection<LotePasesFun> Items);
		#endregion
		
	}
}
