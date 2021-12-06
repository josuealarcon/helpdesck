using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAInformes_Certificacion
	{

		#region [ Consultas ]
		ObservableCollection<Informes_Certificacion> GetAll(String DIVCOD);
		Informes_Certificacion GetOne();
		#endregion

		#region [ Metodos ]
		#endregion

	}
}
