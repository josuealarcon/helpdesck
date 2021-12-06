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

		ObservableCollection<Charlas> GetAllCharlasDivisionCtta(string DIVCOD);
		ObservableCollection<Charlas> GetInformeCapacitacionesCtta(ref Charlas model);
		ObservableCollection<Charlas> GetInformeCapacitacionesDetalleCtta(ref Charlas model);

		#endregion

		#region [ Metodos ]
		ObservableCollection<Charlas> GetCursosSearcherCtta(ref Charlas model);
		#endregion

	}
}
