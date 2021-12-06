using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLProgBus
	{
		
		#region [ Consultas ]
		ObservableCollection<ProgBus> GetAll();
		ProgBus GetOne(Decimal IDPROG);
		#endregion
		
		#region [ Metodos ]
		Boolean Save(ref ProgBus Item);
		Boolean Save(ref ObservableCollection<ProgBus> Items);
		#endregion
		
	}
}
