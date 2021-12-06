using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLWorkerscasino
	{
		#region [ Consultas ]

		#endregion

		#region [ Metodos ]
		bool SaveWorkercasino_Ctta(ObservableCollection<Local> LOCALES, ObservableCollection<Servicio> SERVICIOS, string RUT);
		bool DeleteWorkerCasino_Ctta(string rut);
		#endregion
	}
}
