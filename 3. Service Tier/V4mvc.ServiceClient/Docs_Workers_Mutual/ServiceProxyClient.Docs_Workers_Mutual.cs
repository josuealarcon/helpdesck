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
		public IBLDocs_Workers_Mutual BL_Docs_Workers_Mutual { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLDocs_Workers_Mutual BL_Docs_Workers_Mutual)
        {
            this.BL_Docs_Workers_Mutual = BL_Docs_Workers_Mutual;
        }
        #endregion

        #region [ Consultas ]
        public ObservableCollection<Docs_Workers_Mutual> GetAllDocs_Workers_Mutual()
		{
			try
			{
				return this.BL_Docs_Workers_Mutual.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Docs_Workers_Mutual GetOneDocs_Workers_Mutual()
		{
			try
			{
                return null;// this.BL_Docs_Workers_Mutual.GetOne();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveDocs_Workers_Mutual(ref Docs_Workers_Mutual Item)
		{
			try
			{
				return this.BL_Docs_Workers_Mutual.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveDocs_Workers_Mutual(ref ObservableCollection<Docs_Workers_Mutual> Items)
		{
			try
			{
				return this.BL_Docs_Workers_Mutual.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
