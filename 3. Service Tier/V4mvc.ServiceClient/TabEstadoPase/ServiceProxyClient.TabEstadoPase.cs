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
		public IBLTabEstadoPase BL_TabEstadoPase { get; set; }

		#endregion

		#region [ Constructor]

		public ServiceProxyClient(IBLTabEstadoPase BL_TabEstadoPase)
		{
			this.BL_TabEstadoPase = BL_TabEstadoPase;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<TabEstadoPase> GetAllTabEstadoPases()
		{
			try
			{
				return this.BL_TabEstadoPase.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public TabEstadoPase GetOneTabEstadoPase(string ESTADO_PASE)
		{
			try
			{
				return this.BL_TabEstadoPase.GetOne(ESTADO_PASE);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
		
		#region [ Metodos ]

		public bool SaveTabEstadoPase(ref TabEstadoPase item)
		{
			try
			{
				return this.BL_TabEstadoPase.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool DeleteTabEstadoPase(ref TabEstadoPase item)
		{
			try
			{
				return this.BL_TabEstadoPase.Delete(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool SaveTabEstadoPases(ref ObservableCollection<TabEstadoPase> items)
		{
			try
			{
				return this.BL_TabEstadoPase.Save(ref items);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
	}
}
