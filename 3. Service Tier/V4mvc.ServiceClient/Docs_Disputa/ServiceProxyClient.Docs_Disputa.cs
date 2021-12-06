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
		public IBLDocs_Disputa BL_Docs_Disputa { get; set; }
        #endregion

        #region [ Contructor ]

        public ServiceProxyClient(IBLDocs_Disputa container)
        {
            this.BL_Docs_Disputa = container;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Docs_Disputa> GetAllDocs_Disputa()
		{
			try
			{
				return this.BL_Docs_Disputa.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Docs_Disputa GetOneDocs_Disputa()
		{
			try
			{
				
				return this.BL_Docs_Disputa.GetOne();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveDocs_Disputa(ref Docs_Disputa Item)
		{
			try
			{
				return this.BL_Docs_Disputa.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveDocs_Disputa(ref ObservableCollection<Docs_Disputa> Items)
		{
			try
			{
				return this.BL_Docs_Disputa.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
