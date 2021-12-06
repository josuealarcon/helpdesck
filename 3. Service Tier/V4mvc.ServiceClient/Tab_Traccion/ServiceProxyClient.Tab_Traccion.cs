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
		public IBLTab_Traccion BL_Tab_Traccion { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLTab_Traccion BL_Tab_Traccion)
        {
            this.BL_Tab_Traccion = BL_Tab_Traccion;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Tab_Traccion> GetAllTab_Traccion()
		{
			try
			{
				return this.BL_Tab_Traccion.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Tab_Traccion GetOneTab_Traccion(Int32 IDTRACCION)
		{
			try
			{
				return this.BL_Tab_Traccion.GetOne(IDTRACCION);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveTab_Traccion(ref Tab_Traccion Item)
		{
			try
			{
				return this.BL_Tab_Traccion.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveTab_Traccion(ref ObservableCollection<Tab_Traccion> Items)
		{
			try
			{
				return this.BL_Tab_Traccion.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
