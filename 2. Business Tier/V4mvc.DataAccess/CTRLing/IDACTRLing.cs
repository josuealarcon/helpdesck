using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDACTRLing
	{

		#region [ Consultas ]
		ObservableCollection<CTRLing> GetAll(String DIVISIONES);
		CTRLing GetOne();
		#endregion

		#region [ Metodos ]
		#endregion

	}
}
