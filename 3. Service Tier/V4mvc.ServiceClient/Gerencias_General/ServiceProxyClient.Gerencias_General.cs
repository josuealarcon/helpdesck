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
		public IBLGerencias_General BL_Gerencias_General { get; set; }

		#endregion

		#region [ Constructor]

		public ServiceProxyClient(IBLGerencias_General BL_Gerencias_General)
		{
			this.BL_Gerencias_General = BL_Gerencias_General;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<Gerencias_General> GetAllGerencias_Generales()
		{
			try
			{
				return this.BL_Gerencias_General.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public Gerencias_General GetOneGerencias_General(decimal IDGENERAL)
		{
			try
			{
				return this.BL_Gerencias_General.GetOne(IDGENERAL);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
		
		#region [ Metodos ]

		public bool SaveGerencias_General(ref Gerencias_General item)
		{
			try
			{
				return this.BL_Gerencias_General.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool DeleteGerencias_General(ref Gerencias_General item)
		{
			try
			{
				return this.BL_Gerencias_General.Delete(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool SaveGerencias_Generales(ref ObservableCollection<Gerencias_General> items)
		{
			try
			{
				return this.BL_Gerencias_General.Save(ref items);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
	}
}
