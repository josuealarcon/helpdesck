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
		public IBLDocs_Fec_TipoPase BL_Docs_Fec_TipoPase { get; set; }
        #endregion

        #region [ Contructor ]

        public ServiceProxyClient(IBLDocs_Fec_TipoPase container) {
            this.BL_Docs_Fec_TipoPase = container;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Docs_Fec_TipoPase> GetAllDocs_Fec_TipoPase()
		{
			try
			{
				return this.BL_Docs_Fec_TipoPase.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Docs_Fec_TipoPase GetOneDocs_Fec_TipoPase()
		{
			try
			{
				
				return this.BL_Docs_Fec_TipoPase.GetOne();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveDocs_Fec_TipoPase(ref Docs_Fec_TipoPase Item)
		{
			try
			{
				return this.BL_Docs_Fec_TipoPase.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveDocs_Fec_TipoPase(ref ObservableCollection<Docs_Fec_TipoPase> Items)
		{
			try
			{
				return this.BL_Docs_Fec_TipoPase.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
