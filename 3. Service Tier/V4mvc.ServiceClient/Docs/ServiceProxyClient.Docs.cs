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
		public IBLDocs BL_Docs { get; set; }
        #endregion

        #region [ Contructor ]

        public ServiceProxyClient(IBLDocs container)
        {
            this.BL_Docs = container;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Docs> GetAllDocs()
		{
			try
			{
				return this.BL_Docs.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Docs GetOneDocs(int ID_DOC)
		{
			try
			{
				
				return this.BL_Docs.GetOne(ID_DOC);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveDocs(ref Docs Item)
		{
			try
			{
				return this.BL_Docs.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveDocs(ref ObservableCollection<Docs> Items)
		{
			try
			{
				return this.BL_Docs.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
