using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLInformes_Certificacion
	{

		#region [ Consultas ]
		ObservableCollection<Informes_Certificacion> GetAll(String DIVCOD);
		Informes_Certificacion GetOne();

		#endregion

		#region [ Metodos ]
		#endregion

	}
}