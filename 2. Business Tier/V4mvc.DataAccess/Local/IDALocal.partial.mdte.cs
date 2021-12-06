using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDALocal
	{

		#region [ Consultas ]
		ObservableCollection<Local> GetAllLocal_v2_PasesMdte(string RUT, string DIVISION, int IDPASE, string ID_EMPRESA);

		ObservableCollection<Local> GetAllLocal_PasesMdte(string DIVCOD);

		#endregion

		#region [ Metodos ]

		#endregion
	}
}
