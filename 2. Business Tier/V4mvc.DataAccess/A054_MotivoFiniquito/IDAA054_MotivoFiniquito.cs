using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAA054_MotivoFiniquito
	{
		
		#region [ Consultas ]
		ObservableCollection<A054_MotivoFiniquito> GetAll();
		#endregion
		
		#region [ Metodos ]
		bool Save(ref A054_MotivoFiniquito Item);
		#endregion
		
	}
}
