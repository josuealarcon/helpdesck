using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial class ServiceProxyClient
	{

		#region [ Consultas ]

		public ObservableCollection<Charlas> GetListCharlasDivision_Mdte(ref Charlas charlas)
		{
			try
			{
				return this.BL_Charlas.GetListCharlasDivision_Mdte(ref charlas);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public Charlas GetOneCharla_Mdte(int IDCHARLA)
		{
			try
			{
				return this.BL_Charlas.GetOneCharla_Mdte(IDCHARLA);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public ObservableCollection<Charlas> GetCursosMdteSearcherMdte(ref Charlas model)
		{
			try
			{
				return this.BL_Charlas.GetCursosMdteSearcherMdte(ref model);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Metodos ]

		public bool SaveCharlas_Mdte(ref Charlas charla)
        {
			try
			{
				return this.BL_Charlas.SaveCharlas_Mdte(ref charla);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		
		#endregion

	}
}
