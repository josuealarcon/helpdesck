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
		public IBLDocs_Fec BL_Docs_Fec { get; set; }
        #endregion

        #region [ Contructor ]

        public ServiceProxyClient(IBLDocs_Fec container)
        {
            this.BL_Docs_Fec = container;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Docs_Fec> GetAllDocs_Fec()
		{
			try
			{
				return this.BL_Docs_Fec.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Docs_Fec GetOneDocs_Fec()
		{
			try
			{
				
				return this.BL_Docs_Fec.GetOne();
			}
			catch (Exception ex)
			{ throw ex; }
		}
        #endregion


        #region [ Metodos ]
        public Boolean SaveDocs_Fec(ref Docs_Fec Item)
		{
			try
			{
				return this.BL_Docs_Fec.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveDocs_Fec(ref ObservableCollection<Docs_Fec> Items)
		{
			try
			{
				return this.BL_Docs_Fec.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
