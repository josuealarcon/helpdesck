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
		public IBLGerencias_Area BL_Gerencias_Area { get; set; }

		#endregion

		#region [ Constructor]

		public ServiceProxyClient(IBLGerencias_Area BL_Gerencias_Area)
		{
			this.BL_Gerencias_Area = BL_Gerencias_Area;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<Gerencias_Area> GetAllGerencias_Areas()
		{
			try
			{
				return this.BL_Gerencias_Area.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public Gerencias_Area GetOneGerencias_Area(decimal IDAREA)
		{
			try
			{
				return this.BL_Gerencias_Area.GetOne(IDAREA);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
		
		#region [ Metodos ]

		public bool SaveGerencias_Area(ref Gerencias_Area item)
		{
			try
			{
				return this.BL_Gerencias_Area.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool DeleteGerencias_Area(ref Gerencias_Area item)
		{
			try
			{
				return this.BL_Gerencias_Area.Delete(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool SaveGerencias_Areas(ref ObservableCollection<Gerencias_Area> items)
		{
			try
			{
				return this.BL_Gerencias_Area.Save(ref items);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
	}
}
