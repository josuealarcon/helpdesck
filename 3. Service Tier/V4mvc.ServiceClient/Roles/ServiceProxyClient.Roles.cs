
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;
using Unity;
using System;

namespace V4mvc
{
	public partial class ServiceProxyClient : IServiceProxyClient
	{
		
		#region [ Propiedades ]
		[Dependency]
		public IBLRoles BL_Roles { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLRoles BL_Roles)
        {
            this.BL_Roles = BL_Roles;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Roles> GetAllRoles()
		{
			try
			{
				return this.BL_Roles.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Roles GetOneRoles(String ROL, String AREA, String PROCESO, String SUBPROCESO)
		{
			try
			{
				if (ROL == null || AREA == null || PROCESO == null || SUBPROCESO == null) { return null; }
				return this.BL_Roles.GetOne(ROL, AREA, PROCESO, SUBPROCESO);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveRoles(ref Roles Item)
		{
			try
			{
				return this.BL_Roles.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveRoles(ref ObservableCollection<Roles> Items)
		{
			try
			{
				return this.BL_Roles.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
