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
	public partial class ServiceProxyClient
	{

		#region [ Consultas ]

		public ObservableCollection<CursosSalas> GetSalasMdteSearcherMdte(ref CursosSalas model)
		{
			try
			{
				return this.BL_CursosSalas.GetSalasMdteSearcherMdte(ref model);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Metodos ]

		#endregion
	}
}
