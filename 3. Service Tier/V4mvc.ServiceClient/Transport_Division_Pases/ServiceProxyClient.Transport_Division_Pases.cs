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
		public IBLTransport_Division_Pases BL_Transport_Division_Pases { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLTransport_Division_Pases BL_Transport_Division_Pases)
        {
            this.BL_Transport_Division_Pases = BL_Transport_Division_Pases;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Transport_Division_Pases> GetAllTransport_Division_Pases()
		{
			try
			{
				return this.BL_Transport_Division_Pases.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Transport_Division_Pases GetOneTransport_Division_Pases()
		{
			try
			{
                return null;// this.BL_Transport_Division_Pases.GetOne();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveTransport_Division_Pases(ref Transport_Division_Pases Item)
		{
			try
			{
				return this.BL_Transport_Division_Pases.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveTransport_Division_Pases(ref ObservableCollection<Transport_Division_Pases> Items)
		{
			try
			{
				return this.BL_Transport_Division_Pases.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
