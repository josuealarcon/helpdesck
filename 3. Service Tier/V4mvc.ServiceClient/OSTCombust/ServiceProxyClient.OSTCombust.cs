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
		public IBLOSTCombust BL_OSTCombust { get; set; }

		#endregion

		#region [ Constructor]

		public ServiceProxyClient(IBLOSTCombust BL_OSTCombust)
		{
			this.BL_OSTCombust = BL_OSTCombust;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<OSTCombust> GetAllOSTCombusts()
		{
			try
			{
				return this.BL_OSTCombust.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public OSTCombust GetOneOSTCombust(string NROOST)
		{
			try
			{
				return this.BL_OSTCombust.GetOne(NROOST);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
		
		#region [ Metodos ]

		public bool SaveOSTCombust(ref OSTCombust item)
		{
			try
			{
				return this.BL_OSTCombust.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool SaveOSTCombusts(ref ObservableCollection<OSTCombust> items)
		{
			try
			{
				return this.BL_OSTCombust.Save(ref items);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
	}
}
