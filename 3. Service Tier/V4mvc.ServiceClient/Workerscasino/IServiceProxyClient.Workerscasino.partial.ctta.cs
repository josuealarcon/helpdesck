using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Unity;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{

		#region [ Consultas ]

		#endregion

		#region [ Metodos ]
		bool SaveWorkercasino_Ctta(ObservableCollection<Local> LOCALES, ObservableCollection<Servicio> SERVICIOS,string RUT);

		bool DeleteWorkerCasino_Ctta(string RUT);
		#endregion

	}
}
