using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLWorkers_MotivoFiniquito
	{
		
		#region [ Consultas ]
		ObservableCollection<Workers_MotivoFiniquito> GetAll();
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Workers_MotivoFiniquito Item);
		Boolean Save(ref ObservableCollection<Workers_MotivoFiniquito> Items);
		#endregion
		
	}
}
