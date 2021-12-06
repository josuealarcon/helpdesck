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
		public IBLAAQ_Regimen BL_AAQ_Regimen { get; set; }

		#endregion

		#region [ Constructor]

		public ServiceProxyClient(IBLAAQ_Regimen BL_AAQ_Regimen)
		{
			this.BL_AAQ_Regimen = BL_AAQ_Regimen;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<AAQ_Regimen> GetListAAQ_Regimens_Mdte()
		{
			try
			{
				return this.BL_AAQ_Regimen.GetListAAQ_Regimens_Mdte();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public AAQ_Regimen GetOneAAQ_Regimen(Int32 IDREGIMEN)
		{
			try
			{
				return this.BL_AAQ_Regimen.GetOne(IDREGIMEN);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
		
		#region [ Metodos ]

		public bool SaveAAQ_Regimen(ref AAQ_Regimen item)
		{
			try
			{
				return this.BL_AAQ_Regimen.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool DeleteAAQ_Regimen(ref AAQ_Regimen item)
		{
			try
			{
				return this.BL_AAQ_Regimen.Delete(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool SaveAAQ_Regimens(ref ObservableCollection<AAQ_Regimen> items)
		{
			try
			{
				return this.BL_AAQ_Regimen.Save(ref items);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
	}
}
