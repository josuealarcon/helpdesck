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
		public IBLDocs_Workers_Rechazo BL_Docs_Workers_Rechazo { get; set; }
        #endregion

        #region [ Contructor ]

        public ServiceProxyClient(IBLDocs_Workers_Rechazo container)
        {
            this.BL_Docs_Workers_Rechazo = container;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Docs_Workers_Rechazo> GetAllDocs_Workers_Rechazo()
		{
			try
			{
				return this.BL_Docs_Workers_Rechazo.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Docs_Workers_Rechazo GetOneDocs_Workers_Rechazo(String RUT, Guid ID, Int32 ID_TIPO_RECHAZO)
		{
			try
			{
				return this.BL_Docs_Workers_Rechazo.GetOne(RUT, ID, ID_TIPO_RECHAZO);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveDocs_Workers_Rechazo(ref Docs_Workers_Rechazo Item)
		{
			try
			{
				return this.BL_Docs_Workers_Rechazo.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveDocs_Workers_Rechazo(ref ObservableCollection<Docs_Workers_Rechazo> Items)
		{
			try
			{
				return this.BL_Docs_Workers_Rechazo.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
