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
		public IBLDocs_Fec_Workers BL_Docs_Fec_Workers { get; set; }
        #endregion

        #region [ Contructor ]

        public ServiceProxyClient(IBLDocs_Fec_Workers BL_Docs_Fec_Workers)
        {
            this.BL_Docs_Fec_Workers = BL_Docs_Fec_Workers;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Docs_Fec_Workers> GetAllDocs_Fec_Workers()
		{
			try
			{
				return this.BL_Docs_Fec_Workers.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Docs_Fec_Workers GetOneDocs_Fec_Workers()
		{
			try
			{
                return null;// this.BL_Docs_Fec_Workers.GetOne();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveDocs_Fec_Workers(ref Docs_Fec_Workers Item)
		{
			try
			{
				return this.BL_Docs_Fec_Workers.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveDocs_Fec_Workers(ref ObservableCollection<Docs_Fec_Workers> Items)
		{
			try
			{
				return this.BL_Docs_Fec_Workers.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
