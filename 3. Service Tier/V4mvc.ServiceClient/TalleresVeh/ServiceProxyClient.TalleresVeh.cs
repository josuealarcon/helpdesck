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
		public IBLTalleresVeh BL_TalleresVeh { get; set; }

		#endregion

		#region [ Constructor]

		public ServiceProxyClient(IBLTalleresVeh BL_TalleresVeh)
		{
			this.BL_TalleresVeh = BL_TalleresVeh;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<TalleresVeh> GetAllTalleresVehs()
		{
			try
			{
				return this.BL_TalleresVeh.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public TalleresVeh GetOneTalleresVeh(Int32 IDTALLER)
		{
			try
			{
				return this.BL_TalleresVeh.GetOne(IDTALLER);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
		
		#region [ Metodos ]

		public bool SaveTalleresVeh(ref TalleresVeh item)
		{
			try
			{
				return this.BL_TalleresVeh.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool DeleteTalleresVeh(ref TalleresVeh item)
		{
			try
			{
				return this.BL_TalleresVeh.Delete(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool SaveTalleresVehs(ref ObservableCollection<TalleresVeh> items)
		{
			try
			{
				return this.BL_TalleresVeh.Save(ref items);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
	}
}
