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
		public IBLRol BL_Rol { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLRol BL_Rol)
        {
            this.BL_Rol = BL_Rol;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Rol> GetAllRol()
		{
			try
			{
				return this.BL_Rol.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Rol GetOneRol(Int32 ID_ROL)
		{
			try
			{
				if (ID_ROL == null) { return null; }
				return this.BL_Rol.GetOne(ID_ROL);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveRol(ref Rol Item)
		{
			try
			{
				return this.BL_Rol.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveRol(ref ObservableCollection<Rol> Items)
		{
			try
			{
				return this.BL_Rol.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
