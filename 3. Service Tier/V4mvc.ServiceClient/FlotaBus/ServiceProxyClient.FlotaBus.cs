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
		public IBLFlotaBus BL_FlotaBus { get; set; }

		#endregion

		#region [ Constructor]

		public ServiceProxyClient(IBLFlotaBus BL_FlotaBus)
		{
			this.BL_FlotaBus = BL_FlotaBus;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<FlotaBus> GetAllFlotaBus()
		{
			try
			{
				return this.BL_FlotaBus.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public FlotaBus GetOneFlotaBu(Int32 IDFLOTA)
		{
			try
			{
				return this.BL_FlotaBus.GetOne(IDFLOTA);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
		
		#region [ Metodos ]

		public bool SaveFlotaBu(ref FlotaBus item)
		{
			try
			{
				return this.BL_FlotaBus.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool DeleteFlotaBu(ref FlotaBus item)
		{
			try
			{
				return this.BL_FlotaBus.Delete(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool SaveFlotaBus(ref ObservableCollection<FlotaBus> items)
		{
			try
			{
				return this.BL_FlotaBus.Save(ref items);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
	}
}
