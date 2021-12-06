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
		public IBLGerencias BL_Gerencias { get; set; }

		#endregion

		#region [ Constructor]

		public ServiceProxyClient(IBLGerencias BL_Gerencias)
		{
			this.BL_Gerencias = BL_Gerencias;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<Gerencias> GetAllGerencias()
		{
			try
			{
				return this.BL_Gerencias.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public Gerencias GetOneGerencia(Int32 IDGERENCIA)
		{
			try
			{
				return this.BL_Gerencias.GetOne(IDGERENCIA);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
		
		#region [ Metodos ]

		public bool SaveGerencia(ref Gerencias item)
		{
			try
			{
				return this.BL_Gerencias.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool DeleteGerencia(ref Gerencias item)
		{
			try
			{
				return this.BL_Gerencias.Delete(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool SaveGerencias(ref ObservableCollection<Gerencias> items)
		{
			try
			{
				return this.BL_Gerencias.Save(ref items);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
	}
}
