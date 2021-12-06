using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Unity;

using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial class ServiceProxyClient : IServiceProxyClient
	{

		#region [ Propiedades ]

		[Dependency]
		public IBLDocs_E200 BL_Docs_E200 { get; set; }

		#endregion

		#region [ Constructor]

		public ServiceProxyClient(IBLDocs_E200 BL_Docs_E200)
		{
			this.BL_Docs_E200 = BL_Docs_E200;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<Docs_E200> GetAllDocs_E200s()
		{
			try
			{
				return this.BL_Docs_E200.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public Docs_E200 GetOneDocs_E200(Guid ID)
		{
			try
			{
				return this.BL_Docs_E200.GetOne(ID);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
		
		#region [ Metodos ]

		public bool SaveDocs_E200(ref Docs_E200 item)
		{
			try
			{
				return this.BL_Docs_E200.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool DeleteDocs_E200(ref Docs_E200 item)
		{
			try
			{
				return this.BL_Docs_E200.Delete(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool SaveDocs_E200s(ref ObservableCollection<Docs_E200> items)
		{
			try
			{
				return this.BL_Docs_E200.Save(ref items);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
	}
}
