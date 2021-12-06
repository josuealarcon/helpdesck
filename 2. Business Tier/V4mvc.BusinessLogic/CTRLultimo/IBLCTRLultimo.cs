using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLCTRLultimo
	{

		#region [ Consultas ]
		ObservableCollection<CTRLultimo> GetAll(String DIVISIONES);
		CTRLultimo GetOne();

		#endregion

		#region [ Metodos ]
		#endregion

	}
}