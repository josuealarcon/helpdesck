using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLA054_MotivoFiniquito
	{
		
		#region [ Consultas ]
		ObservableCollection<A054_MotivoFiniquito> GetAll();
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref A054_MotivoFiniquito Item);
		Boolean Save(ref ObservableCollection<A054_MotivoFiniquito> Items);
		#endregion
		
	}
}
