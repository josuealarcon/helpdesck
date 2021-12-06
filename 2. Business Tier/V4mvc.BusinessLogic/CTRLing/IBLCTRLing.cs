using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLCTRLing
	{
		#region [ Consultas ]
		ObservableCollection<CTRLing> GetAll(String DIVISIONES);
		CTRLing GetOne();

		#endregion

		#region [ Metodos ]
		#endregion

	}
}