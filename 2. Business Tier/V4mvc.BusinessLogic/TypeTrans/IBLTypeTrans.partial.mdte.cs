using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLTypeTrans
	{

		#region [ Consultas ]
		
		ObservableCollection<TypeTrans> GetAllTypeTrans_CertificacionMdte();
		
		ObservableCollection<TypeTrans> GetListTypeTrans_Mdte();
		
		#endregion

		#region [ Metodos ]

		#endregion

	}
}
