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
		public IBLE200_Dothh BL_E200_Dothh { get; set; }

		#endregion

		#region [ Constructor]

		public ServiceProxyClient(IBLE200_Dothh BL_E200_Dothh)
		{
			this.BL_E200_Dothh = BL_E200_Dothh;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<E200_Dothh> GetAllE200_Dothhs()
		{
			try
			{
				return this.BL_E200_Dothh.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public E200_Dothh GetOneE200_Dothh(Guid ID)
		{
			try
			{
				return this.BL_E200_Dothh.GetOne(ID);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
		
		#region [ Metodos ]

		public bool SaveE200_Dothh(ref E200_Dothh item)
		{
			try
			{
				return this.BL_E200_Dothh.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool DeleteE200_Dothh(ref E200_Dothh item)
		{
			try
			{
				return this.BL_E200_Dothh.Delete(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool SaveE200_Dothhs(ref ObservableCollection<E200_Dothh> items)
		{
			try
			{
				return this.BL_E200_Dothh.Save(ref items);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
	}
}
