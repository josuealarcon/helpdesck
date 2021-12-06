using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLLocal
	{

		#region [ Consultas ]
		ObservableCollection<Local> GetAllLocal_PasesCtta(string DIVCOD);
		ObservableCollection<Local> GetAllLocalesPorDiv_Informe(string DIVCOD, string LOCALL);

		ObservableCollection<Local> GetAllLocal_v2_PasesCtta(string RUT, string DIVISION, int IDPASE, string ID_EMPRESA);
		ObservableCollection<Local> GetLocalDivisionCtta(string DIVCOD);
		#endregion

		#region [ Metodos ]

		#endregion

	}
}
