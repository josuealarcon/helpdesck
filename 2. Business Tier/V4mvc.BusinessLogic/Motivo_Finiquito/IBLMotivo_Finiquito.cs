using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLMotivo_Finiquito
	{
		
		#region [ Consultas ]
		ObservableCollection<Motivo_Finiquito> GetAll();
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref Motivo_Finiquito Item);
		Boolean Save(ref ObservableCollection<Motivo_Finiquito> Items);
		#endregion
		
	}
}
