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
		public IBLA025Area BL_A025Area { get; set; }

		#endregion

		#region [ Constructor]

		public ServiceProxyClient(IBLA025Area BL_A025Area)
		{
			this.BL_A025Area = BL_A025Area;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<A025Area> GetAllA025Areas()
		{
			try
			{
				return this.BL_A025Area.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public A025Area GetOneA025Area(Int32 ID_AREA)
		{
			try
			{
				return this.BL_A025Area.GetOne(ID_AREA);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
		
		#region [ Metodos ]

		public bool SaveA025Area(ref A025Area item)
		{
			try
			{
				return this.BL_A025Area.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool DeleteA025Area(ref A025Area item)
		{
			try
			{
				return this.BL_A025Area.Delete(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool SaveA025Areas(ref ObservableCollection<A025Area> items)
		{
			try
			{
				return this.BL_A025Area.Save(ref items);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
	}
}
