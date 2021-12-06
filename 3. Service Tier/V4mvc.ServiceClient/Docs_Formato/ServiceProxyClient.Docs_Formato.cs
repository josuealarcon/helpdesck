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
		public IBLDocs_Formato BL_Docs_Formato { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLDocs_Formato BL_Docs_Formato)
        {
            this.BL_Docs_Formato = BL_Docs_Formato;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Docs_Formato> GetAllDocs_Formato()
		{
			try
			{
				return this.BL_Docs_Formato.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Docs_Formato GetOneDocs_Formato(int ID_DOC_EXT)
		{
			try
			{
				return this.BL_Docs_Formato.GetOne(ID_DOC_EXT);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveDocs_Formato(ref Docs_Formato Item)
		{
			try
			{
				return this.BL_Docs_Formato.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveDocs_Formato(ref ObservableCollection<Docs_Formato> Items)
		{
			try
			{
				return this.BL_Docs_Formato.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
