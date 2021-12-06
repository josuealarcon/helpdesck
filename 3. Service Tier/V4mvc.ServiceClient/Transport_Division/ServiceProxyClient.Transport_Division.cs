using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;
using Unity;

namespace V4mvc
{
	public partial class ServiceProxyClient : IServiceProxyClient
	{
		
		#region [ Propiedades ]
		[Dependency]
		public IBLTransport_Division BL_Transport_Division { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLTransport_Division BL_Transport_Division)
        {
            this.BL_Transport_Division = BL_Transport_Division;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Transport_Division> GetAllTransport_Division()
		{
			try
			{
				return this.BL_Transport_Division.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Transport_Division GetOneTransport_Division()
		{
			try
			{
                return null;// this.BL_Transport_Division.GetOne();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveTransport_Division(ref Transport_Division Item)
		{
			try
			{
				return this.BL_Transport_Division.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveTransport_Division(ref ObservableCollection<Transport_Division> Items)
		{
			try
			{
				return this.BL_Transport_Division.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
