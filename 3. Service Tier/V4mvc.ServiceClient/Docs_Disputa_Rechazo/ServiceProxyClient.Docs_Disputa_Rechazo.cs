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
		public IBLDocs_Disputa_Rechazo BL_Docs_Disputa_Rechazo { get; set; }
        #endregion

        #region [ Contructor ]

        public ServiceProxyClient(IBLDocs_Disputa_Rechazo BL_Docs_Disputa_Rechazo)
        {
            this.BL_Docs_Disputa_Rechazo = BL_Docs_Disputa_Rechazo;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Docs_Disputa_Rechazo> GetAllDocs_Disputa_Rechazo()
		{
			try
			{
				return this.BL_Docs_Disputa_Rechazo.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Docs_Disputa_Rechazo GetOneDocs_Disputa_Rechazo()
		{
			try
			{
                return null;// this.BL_Docs_Disputa_Rechazo.GetOne();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveDocs_Disputa_Rechazo(ref Docs_Disputa_Rechazo Item)
		{
			try
			{
				return this.BL_Docs_Disputa_Rechazo.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveDocs_Disputa_Rechazo(ref ObservableCollection<Docs_Disputa_Rechazo> Items)
		{
			try
			{
				return this.BL_Docs_Disputa_Rechazo.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
