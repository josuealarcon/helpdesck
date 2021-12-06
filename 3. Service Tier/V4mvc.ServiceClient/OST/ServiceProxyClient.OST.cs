using System;
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
		public IBLOST BL_OST { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLOST BL_OST)
        {
            this.BL_OST = BL_OST;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<OST> GetAllOST()
		{
			try
			{
				return this.BL_OST.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public OST GetOneOST(String NROOST, String IDEMPRESA)
		{
			try
			{
				if (NROOST == null || IDEMPRESA == null) { return null; }
				return this.BL_OST.GetOne(NROOST, IDEMPRESA);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveOST(ref OST Item)
		{
			try
			{
				return this.BL_OST.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveOST(ref ObservableCollection<OST> Items)
		{
			try
			{
				return this.BL_OST.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
