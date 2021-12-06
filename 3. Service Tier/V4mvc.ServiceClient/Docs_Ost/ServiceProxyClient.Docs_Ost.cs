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
		public IBLDocs_Ost BL_Docs_Ost { get; set; }

		#endregion

		#region [ Constructor]

		public ServiceProxyClient(IBLDocs_Ost BL_Docs_Ost)
		{
			this.BL_Docs_Ost = BL_Docs_Ost;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<Docs_Ost> GetAllDocs_Ost()
		{
			try
			{
				return this.BL_Docs_Ost.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public Docs_Ost GetOneDocs_Ost(string OST)
		{
			try
			{
				return this.BL_Docs_Ost.GetOne(OST);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
		
		#region [ Metodos ]

		public bool SaveDocs_Ost(ref Docs_Ost item)
		{
			try
			{
				return this.BL_Docs_Ost.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool SaveDocs_Ost(ref ObservableCollection<Docs_Ost> items)
		{
			try
			{
				return this.BL_Docs_Ost.Save(ref items);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
	}
}
