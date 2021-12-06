using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Unity;

using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial class ServiceProxyClient : IServiceProxyClient
	{

		#region [ Propiedades ]

		[Dependency]
		public IBLCharlas_Division BL_Charlas_Division { get; set; }

		#endregion

		#region [ Constructor]

		public ServiceProxyClient(IBLCharlas_Division BL_Charlas_Division)
		{
			this.BL_Charlas_Division = BL_Charlas_Division;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<Charlas_Division> GetAllCharlas_Divisiones()
		{
			try
			{
				return this.BL_Charlas_Division.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public Charlas_Division GetOneCharlas_Division(Int32 ID_CHARLA_DIVISION)
		{
			try
			{
				return this.BL_Charlas_Division.GetOne(ID_CHARLA_DIVISION);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
		
		#region [ Metodos ]

		public bool SaveCharlas_Division(ref Charlas_Division item)
		{
			try
			{
				return this.BL_Charlas_Division.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool DeleteCharlas_Division(ref Charlas_Division item)
		{
			try
			{
				return this.BL_Charlas_Division.Delete(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool SaveCharlas_Divisiones(ref ObservableCollection<Charlas_Division> items)
		{
			try
			{
				return this.BL_Charlas_Division.Save(ref items);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
	}
}
