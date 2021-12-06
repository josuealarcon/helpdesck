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
		public IBLCharlhist BL_Charlhist { get; set; }
		#endregion

		#region [ Constructor]
		public ServiceProxyClient(IBLCharlhist BL_Charlhist)
		{
			this.BL_Charlhist = BL_Charlhist;
		}

		#endregion

		#region [ Consultas ]
		public ObservableCollection<Charlhist> GetAllCharlhist()
		{
			try
			{
				return this.BL_Charlhist.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Charlhist GetOneCharlhist(Int32 IDCHARLA)
		{
			try
			{
				return this.BL_Charlhist.GetOne(IDCHARLA);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]
		public Boolean SaveCharlhist(ref Charlhist Item)
		{
			try
			{
				return this.BL_Charlhist.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveCharlhist(ref ObservableCollection<Charlhist> Items)
		{
			try
			{
				return this.BL_Charlhist.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

	}
}
