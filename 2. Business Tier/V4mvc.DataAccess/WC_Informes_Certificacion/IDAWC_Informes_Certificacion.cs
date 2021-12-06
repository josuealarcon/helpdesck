using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAWC_Informes_Certificacion
	{

		#region [ Consultas ]
		ObservableCollection<WC_Informes_Certificacion> GetAll();

		WC_Informes_Certificacion GetOne(Decimal CODMENU);
		#endregion

		#region [ Metodos ]
		#endregion

	}
}