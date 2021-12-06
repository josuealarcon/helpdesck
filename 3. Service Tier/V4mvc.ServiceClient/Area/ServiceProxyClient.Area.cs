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
		public IBLArea BL_Area { get; set; }

		#endregion

		#region [ Constructor]

		public ServiceProxyClient(IBLArea BL_Area)
		{
			this.BL_Area = BL_Area;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<Area> GetAllAreas()
		{
			try
			{
				return this.BL_Area.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public Area GetOneArea(string AREA)
		{
			try
			{
				return this.BL_Area.GetOne(AREA);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
		
		#region [ Metodos ]

		public bool SaveArea(ref Area item)
		{
			try
			{
				return this.BL_Area.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool DeleteArea(ref Area item)
		{
			try
			{
				return this.BL_Area.Delete(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool SaveAreas(ref ObservableCollection<Area> items)
		{
			try
			{
				return this.BL_Area.Save(ref items);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
	}
}
