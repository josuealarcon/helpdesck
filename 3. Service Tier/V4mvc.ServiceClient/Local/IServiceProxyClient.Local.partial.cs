using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{
		#region [ Consultas ]
		ObservableCollection<Local> GetAllLocal_PasesCtta(string DIVCOD);
		ObservableCollection<Local> GetAllLocalAcceso_PasesCtta(string DIVCOD);
		ObservableCollection<Local> GetAllLocalesPorDiv_Informe(string DIVCOD, string LOCALL);
		ObservableCollection<Local> GetLocalDivisionCtta(string DIVCOD);
		ObservableCollection<Local> GetLocalesCasinoCtta(string RUT);
		#endregion

		#region [ Metodos ]
		ObservableCollection<Local> GetListLocalesCasinoPermitidos_Ctta(string RUT);
		ObservableCollection<Local> GetListLocalesCasinoPermitidosAutorizaciones_Ctta(string RUT);

		#endregion

	}
}
