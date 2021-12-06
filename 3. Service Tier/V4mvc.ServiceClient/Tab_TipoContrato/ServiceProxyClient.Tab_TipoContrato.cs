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
		public IBLTab_TipoContrato BL_Tab_TipoContrato { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLTab_TipoContrato BL_Tab_TipoContrato)
        {
            this.BL_Tab_TipoContrato = BL_Tab_TipoContrato;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Tab_TipoContrato> GetAllTab_TipoContrato()
		{
			try
			{
				return this.BL_Tab_TipoContrato.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Tab_TipoContrato GetOneTab_TipoContrato(int ID_TIPOCONTRATO)
		{
			try
			{
				return this.BL_Tab_TipoContrato.GetOne(ID_TIPOCONTRATO);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveTab_TipoContrato(ref Tab_TipoContrato Item)
		{
			try
			{
				return this.BL_Tab_TipoContrato.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveTab_TipoContrato(ref ObservableCollection<Tab_TipoContrato> Items)
		{
			try
			{
				return this.BL_Tab_TipoContrato.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
