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
		public IBLDocs_Transport BL_Docs_Transport { get; set; }
        #endregion

        #region [ Contructor ]

        public ServiceProxyClient(IBLDocs_Transport BL_Docs_Transport)
        {
            this.BL_Docs_Transport = BL_Docs_Transport;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Docs_Transport> GetAllDocs_Transport()
		{
			try
			{
				return this.BL_Docs_Transport.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Docs_Transport GetOneDocs_Transport(Int32 ID_DOCS_VEH)
		{
			try
			{
				return this.BL_Docs_Transport.GetOne(ID_DOCS_VEH);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveDocs_Transport(ref Docs_Transport Item)
		{
			try
			{
				return this.BL_Docs_Transport.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveDocs_Transport(ref ObservableCollection<Docs_Transport> Items)
		{
			try
			{
				return this.BL_Docs_Transport.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
