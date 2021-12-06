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
		public IBLDocs_TipoPase BL_Docs_TipoPase { get; set; }
        #endregion

        #region [ Contructor ]

        public ServiceProxyClient(IBLDocs_TipoPase container)
        {
            this.BL_Docs_TipoPase = container;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Docs_TipoPase> GetAllDocs_TipoPase()
		{
			try
			{
				return this.BL_Docs_TipoPase.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Docs_TipoPase GetOneDocs_TipoPase()
		{
			try
			{
				
				return this.BL_Docs_TipoPase.GetOne();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveDocs_TipoPase(ref Docs_TipoPase Item)
		{
			try
			{
				return this.BL_Docs_TipoPase.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveDocs_TipoPase(ref ObservableCollection<Docs_TipoPase> Items)
		{
			try
			{
				return this.BL_Docs_TipoPase.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
