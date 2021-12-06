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
		public IBLCheckDetail BL_CheckDetail { get; set; }

		#endregion

		#region [ Constructor]

		public ServiceProxyClient(IBLCheckDetail BL_CheckDetail)
		{
			this.BL_CheckDetail = BL_CheckDetail;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<CheckDetail> GetAllCheckDetails()
		{
			try
			{
				return this.BL_CheckDetail.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public CheckDetail GetOneCheckDetail(Int32 ID_CHECK)
		{
			try
			{
				return this.BL_CheckDetail.GetOne(ID_CHECK);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
		
		#region [ Metodos ]

		public bool SaveCheckDetail(ref CheckDetail item)
		{
			try
			{
				return this.BL_CheckDetail.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool DeleteCheckDetail(ref CheckDetail item)
		{
			try
			{
				return this.BL_CheckDetail.Delete(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool SaveCheckDetails(ref ObservableCollection<CheckDetail> items)
		{
			try
			{
				return this.BL_CheckDetail.Save(ref items);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
	}
}
