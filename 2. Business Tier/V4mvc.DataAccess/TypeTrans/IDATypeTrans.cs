using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDATypeTrans
	{
		
		#region [ Consultas ]
		ObservableCollection<TypeTrans> GetAll();
		#endregion
		
		#region [ Metodos ]
		bool Save(ref TypeTrans Item);
		#endregion
		
	}
}
