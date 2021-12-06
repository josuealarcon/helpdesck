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
		public IBLTab_Combustible BL_Tab_Combustible { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLTab_Combustible BL_Tab_Combustible)
        {
            this.BL_Tab_Combustible = BL_Tab_Combustible;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Tab_Combustible> GetAllTab_Combustible()
		{
			try
			{
				return this.BL_Tab_Combustible.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Tab_Combustible GetOneTab_Combustible(Int32 IDCOMBUSTIBLE)
		{
			try
			{
				return this.BL_Tab_Combustible.GetOne(IDCOMBUSTIBLE);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveTab_Combustible(ref Tab_Combustible Item)
		{
			try
			{
				return this.BL_Tab_Combustible.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveTab_Combustible(ref ObservableCollection<Tab_Combustible> Items)
		{
			try
			{
				return this.BL_Tab_Combustible.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
