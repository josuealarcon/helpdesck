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
		public IBLDocsGrupos BL_DocsGrupos { get; set; }

		#endregion

		#region [ Constructor]

		public ServiceProxyClient(IBLDocsGrupos BL_DocsGrupos)
		{
			this.BL_DocsGrupos = BL_DocsGrupos;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<DocsGrupos> GetAllDocsGrupos()
		{
			try
			{
				return this.BL_DocsGrupos.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public DocsGrupos GetOneDocsGrupo(Int32 ID)
		{
			try
			{
				return this.BL_DocsGrupos.GetOne(ID);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
		
		#region [ Metodos ]

		public bool SaveDocsGrupo(ref DocsGrupos item)
		{
			try
			{
				return this.BL_DocsGrupos.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool DeleteDocsGrupo(ref DocsGrupos item)
		{
			try
			{
				return this.BL_DocsGrupos.Delete(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool SaveDocsGrupos(ref ObservableCollection<DocsGrupos> items)
		{
			try
			{
				return this.BL_DocsGrupos.Save(ref items);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
	}
}
