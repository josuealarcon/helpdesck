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

		public ObservableCollection<Charlas> GetAllCharlasDivisionCtta(string DIVCOD)
		{
			try
			{
				return this.BL_Charlas.GetAllCharlasDivisionCtta(DIVCOD);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public ObservableCollection<Charlas> GetInformeCapacitacionesCtta(ref Charlas model)
		{
			try
			{
				return this.BL_Charlas.GetInformeCapacitacionesCtta(ref model);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public ObservableCollection<Charlas> GetInformeCapacitacionesDetalleCtta(ref Charlas model)
		{
			try
			{
				return this.BL_Charlas.GetInformeCapacitacionesDetalleCtta(ref model);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Metodos ]
		public ObservableCollection<Charlas> GetCursosSearcherCtta(ref Charlas model)
		{
			try
			{
				return this.BL_Charlas.GetCursosSearcherCtta(ref model);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

	}
}
