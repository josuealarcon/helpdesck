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
		public IBLCursoAmbitos BL_CursoAmbitos { get; set; }

		#endregion

		#region [ Constructor]

		public ServiceProxyClient(IBLCursoAmbitos BL_CursoAmbitos)
		{
			this.BL_CursoAmbitos = BL_CursoAmbitos;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<CursoAmbitos> GetAllCursoAmbitos()
		{
			try
			{
				return this.BL_CursoAmbitos.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public CursoAmbitos GetOneCursoAmbito(Int32 ID)
		{
			try
			{
				return this.BL_CursoAmbitos.GetOne(ID);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
		
		#region [ Metodos ]

		public bool SaveCursoAmbito(ref CursoAmbitos item)
		{
			try
			{
				return this.BL_CursoAmbitos.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool DeleteCursoAmbito(ref CursoAmbitos item)
		{
			try
			{
				return this.BL_CursoAmbitos.Delete(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool SaveCursoAmbitos(ref ObservableCollection<CursoAmbitos> items)
		{
			try
			{
				return this.BL_CursoAmbitos.Save(ref items);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
	}
}
