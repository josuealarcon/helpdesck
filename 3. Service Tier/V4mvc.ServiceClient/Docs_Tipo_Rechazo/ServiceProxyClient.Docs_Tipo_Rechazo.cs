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
		public IBLDocs_Tipo_Rechazo BL_Docs_Tipo_Rechazo { get; set; }
        #endregion

        #region [ Contructor ]

        public ServiceProxyClient(IBLDocs_Tipo_Rechazo BL_Docs_Tipo_Rechazo)
        {
            this.BL_Docs_Tipo_Rechazo = BL_Docs_Tipo_Rechazo;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Docs_Tipo_Rechazo> GetAllDocs_Tipo_Rechazo()
		{
			try
			{
				return this.BL_Docs_Tipo_Rechazo.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Docs_Tipo_Rechazo GetOneDocs_Tipo_Rechazo()
		{
			try
			{
                return null; //this.BL_Docs_Tipo_Rechazo.GetOne();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveDocs_Tipo_Rechazo(ref Docs_Tipo_Rechazo Item)
		{
			try
			{
				return this.BL_Docs_Tipo_Rechazo.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveDocs_Tipo_Rechazo(ref ObservableCollection<Docs_Tipo_Rechazo> Items)
		{
			try
			{
				return this.BL_Docs_Tipo_Rechazo.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
