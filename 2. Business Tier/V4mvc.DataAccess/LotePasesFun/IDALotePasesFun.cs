using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDALotePasesFun
	{
		
		#region [ Consultas ]
		ObservableCollection<LotePasesFun> GetAll();
		#endregion
		
		#region [ Metodos ]
		bool Save(ref LotePasesFun Item);
		#endregion
		
	}
}
