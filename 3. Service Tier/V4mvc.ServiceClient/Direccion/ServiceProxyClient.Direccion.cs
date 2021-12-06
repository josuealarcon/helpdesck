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
		public IBLDireccion BL_Direccion { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLDireccion BL_Direccion)
        {
            this.BL_Direccion = BL_Direccion;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Direccion> GetAllDireccion()
		{
			try
			{
				return this.BL_Direccion.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Direccion GetOneDireccion(String RUT)
		{
			try
			{
				return this.BL_Direccion.GetOne(RUT);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveDireccion(ref Direccion Item)
		{
			try
			{
				return this.BL_Direccion.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveDireccion(ref ObservableCollection<Direccion> Items)
		{
			try
			{
				return this.BL_Direccion.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
