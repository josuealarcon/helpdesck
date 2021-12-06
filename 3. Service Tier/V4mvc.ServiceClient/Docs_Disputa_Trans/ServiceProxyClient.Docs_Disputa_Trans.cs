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
		public IBLDocs_Disputa_Trans BL_Docs_Disputa_Trans { get; set; }
        #endregion

        #region [ Contructor ]

        public ServiceProxyClient(IBLDocs_Disputa_Trans BL_Docs_Disputa_Trans)
        {
            this.BL_Docs_Disputa_Trans = BL_Docs_Disputa_Trans;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Docs_Disputa_Trans> GetAllDocs_Disputa_Trans()
		{
			try
			{
				return this.BL_Docs_Disputa_Trans.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Docs_Disputa_Trans GetOneDocs_Disputa_Trans(Int32 ID_DISPUTA)
		{
			try
			{
				return this.BL_Docs_Disputa_Trans.GetOne(ID_DISPUTA);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveDocs_Disputa_Trans(ref Docs_Disputa_Trans Item)
		{
			try
			{
				return this.BL_Docs_Disputa_Trans.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveDocs_Disputa_Trans(ref ObservableCollection<Docs_Disputa_Trans> Items)
		{
			try
			{
				return this.BL_Docs_Disputa_Trans.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
