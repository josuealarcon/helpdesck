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
		public IBLDocs_Workers_Data BL_Docs_Workers_Data { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLDocs_Workers_Data BL_Docs_Workers_Data)
        {
            this.BL_Docs_Workers_Data = BL_Docs_Workers_Data;
        }
        #endregion

        #region [ Consultas ]
        public ObservableCollection<Docs_Workers_Data> GetAllDocs_Workers_Data()
		{
			try
			{
				return this.BL_Docs_Workers_Data.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Docs_Workers_Data GetOneDocs_Workers_Data()
		{
			try
			{
                //if () { return null; }
                return null;// this.BL_Docs_Workers_Data.GetOne();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveDocs_Workers_Data(ref Docs_Workers_Data Item)
		{
			try
			{
				return this.BL_Docs_Workers_Data.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveDocs_Workers_Data(ref ObservableCollection<Docs_Workers_Data> Items)
		{
			try
			{
				return this.BL_Docs_Workers_Data.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
