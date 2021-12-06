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
		public IBLTransport BL_Transport { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLTransport BL_Transport)
        {
            this.BL_Transport = BL_Transport;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Transport> GetAllTransport()
		{
			try
			{
				return this.BL_Transport.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Transport GetOneTransport(string PATENTE)
		{
			try
			{
                return this.BL_Transport.GetOne(PATENTE);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]
		public Boolean SaveTransport(ref Transport Item)
		{
			try
			{
				return this.BL_Transport.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveTransport(ref ObservableCollection<Transport> Items)
		{
			try
			{
				return this.BL_Transport.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
