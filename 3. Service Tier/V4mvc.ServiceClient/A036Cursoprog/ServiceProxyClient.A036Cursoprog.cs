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
		public IBLA036Cursoprog BL_A036Cursoprog { get; set; }

		#endregion

		#region [ Constructor]

		public ServiceProxyClient(IBLA036Cursoprog BL_A036Cursoprog)
		{
			this.BL_A036Cursoprog = BL_A036Cursoprog;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<A036Cursoprog> GetAllA036Cursosprogs()
		{
			try
			{
				return this.BL_A036Cursoprog.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public A036Cursoprog GetOneA036Cursoprog(Int32 CODIGO)
		{
			try
			{
				return this.BL_A036Cursoprog.GetOne(CODIGO);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
		
		#region [ Metodos ]

		public bool SaveA036Cursoprog(ref A036Cursoprog item)
		{
			try
			{
				return this.BL_A036Cursoprog.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool DeleteA036Cursoprog(ref A036Cursoprog item)
		{
			try
			{
				return this.BL_A036Cursoprog.Delete(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool SaveA036Cursosprogs(ref ObservableCollection<A036Cursoprog> items)
		{
			try
			{
				return this.BL_A036Cursoprog.Save(ref items);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
	}
}
