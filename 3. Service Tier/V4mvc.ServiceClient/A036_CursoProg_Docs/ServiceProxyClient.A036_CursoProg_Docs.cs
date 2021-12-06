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
		public IBLA036_CursoProg_Docs BL_A036_CursoProg_Docs { get; set; }
		#endregion

		#region [ Constructor]
		public ServiceProxyClient(IBLA036_CursoProg_Docs BL_A036_CursoProg_Docs)
		{
			this.BL_A036_CursoProg_Docs = BL_A036_CursoProg_Docs;
		}

		#endregion

		#region [ Consultas ]
		public ObservableCollection<A036_CursoProg_Docs> GetAllA036_CursoProg_Docs()
		{
			try
			{
				return this.BL_A036_CursoProg_Docs.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public A036_CursoProg_Docs GetOneA036_CursoProg_Docs(Guid Codigo)
		{
			try
			{
				return this.BL_A036_CursoProg_Docs.GetOne(Codigo);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]
		public Boolean SaveA036_CursoProg_Docs(ref A036_CursoProg_Docs Item)
		{
			try
			{
				return this.BL_A036_CursoProg_Docs.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveA036_CursoProg_Docs(ref ObservableCollection<A036_CursoProg_Docs> Items)
		{
			try
			{
				return this.BL_A036_CursoProg_Docs.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

	}
}
