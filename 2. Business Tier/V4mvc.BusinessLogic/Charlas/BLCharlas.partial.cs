using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLCharlas
	{

		#region [ Consultas ]

		public ObservableCollection<Charlas> GetAllCharlasDivisionCtta(string DIVCOD)
		{
			try
			{
				return this.Repository.GetAllCharlasDivisionCtta(DIVCOD);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public ObservableCollection<Charlas> GetInformeCapacitacionesCtta(ref Charlas model)
		{
			try
			{
				return this.Repository.GetInformeCapacitacionesCtta(ref model);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public ObservableCollection<Charlas> GetInformeCapacitacionesDetalleCtta(ref Charlas model)
		{
			try
			{
				return this.Repository.GetInformeCapacitacionesDetalleCtta(ref model);
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
				return this.Repository.GetCursosSearcherCtta(ref model);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

	}
}
