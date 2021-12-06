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

		ObservableCollection<Charlas> GetListCharlasDivision_Mdte(ref Charlas charlas);
		Charlas GetOneCharla_Mdte(int IDCHARLA);
		ObservableCollection<Charlas> GetCursosMdteSearcherMdte(ref Charlas model);

		#endregion

		#region [ Metodos ]
		bool SaveCharlas_Mdte(ref Charlas charla);
		#endregion

	}
}
