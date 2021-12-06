using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLAAQ_Regimen
	{
        #region [ Consultas ]



        ObservableCollection<AAQ_Regimen> GetListAAQ_Regimens_Mdte();




		AAQ_Regimen GetOne(Int32 IDREGIMEN);

		#endregion

		#region [ Metodos ]

		bool Save(ref AAQ_Regimen item);

		bool Delete(ref AAQ_Regimen item);

		bool Save(ref ObservableCollection<AAQ_Regimen> items);

		#endregion
	}
}
