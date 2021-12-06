using System;
using System.Linq;
using System.Text;
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
		public IBLDocs_Manuales BL_Docs_Manuales { get; set; }

		#endregion

		#region [ Constructor]

		public ServiceProxyClient(IBLDocs_Manuales BL_Docs_Manuales)
		{
			this.BL_Docs_Manuales = BL_Docs_Manuales;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<Docs_Manuales> GetAllDocs_Manuales()
		{
			try
			{
				return this.BL_Docs_Manuales.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public Docs_Manuales GetOneDocs_Manual(int ID_DOC)
		{
			try
			{
				return this.BL_Docs_Manuales.GetOne(ID_DOC);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
		
		#region [ Metodos ]

		public bool SaveDocs_Manual(ref Docs_Manuales item)
		{
			try
			{
				return this.BL_Docs_Manuales.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool SaveDocs_Manuales(ref ObservableCollection<Docs_Manuales> items)
		{
			try
			{
				return this.BL_Docs_Manuales.Save(ref items);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool DeleteDocs_Manual(ref Docs_Manuales item)
		{
			try
			{
				return this.BL_Docs_Manuales.Delete(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
	}
}
