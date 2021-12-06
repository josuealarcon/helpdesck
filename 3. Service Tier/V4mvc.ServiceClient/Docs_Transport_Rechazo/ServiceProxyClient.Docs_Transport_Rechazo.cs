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
		public IBLDocs_Transport_Rechazo BL_Docs_Transport_Rechazo { get; set; }
        #endregion

        #region [ Contructor ]

        public ServiceProxyClient(IBLDocs_Transport_Rechazo BL_Docs_Transport_Rechazo)
        {
            this.BL_Docs_Transport_Rechazo = BL_Docs_Transport_Rechazo;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Docs_Transport_Rechazo> GetAllDocs_Transport_Rechazo()
		{
			try
			{
				return this.BL_Docs_Transport_Rechazo.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Docs_Transport_Rechazo GetOneDocs_Transport_Rechazo(String PATENTE, Guid ID, Int32 ID_TIPO_RECHAZO)
		{
			try
			{
				return this.BL_Docs_Transport_Rechazo.GetOne(PATENTE, ID, ID_TIPO_RECHAZO);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveDocs_Transport_Rechazo(ref Docs_Transport_Rechazo Item)
		{
			try
			{
				return this.BL_Docs_Transport_Rechazo.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveDocs_Transport_Rechazo(ref ObservableCollection<Docs_Transport_Rechazo> Items)
		{
			try
			{
				return this.BL_Docs_Transport_Rechazo.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
