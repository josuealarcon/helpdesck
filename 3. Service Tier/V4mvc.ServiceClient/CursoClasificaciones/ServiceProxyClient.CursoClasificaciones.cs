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
		public IBLCursoClasificaciones BL_CursoClasificaciones { get; set; }

		#endregion

		#region [ Constructor]

		public ServiceProxyClient(IBLCursoClasificaciones BL_CursoClasificaciones)
		{
			this.BL_CursoClasificaciones = BL_CursoClasificaciones;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<CursoClasificaciones> GetAllCursoClasificaciones()
		{
			try
			{
				return this.BL_CursoClasificaciones.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public CursoClasificaciones GetOneCursoClasificacion(Int32 ID)
		{
			try
			{
				return this.BL_CursoClasificaciones.GetOne(ID);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
		
		#region [ Metodos ]

		public bool SaveCursoClasificacion(ref CursoClasificaciones item)
		{
			try
			{
				return this.BL_CursoClasificaciones.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool DeleteCursoClasificacion(ref CursoClasificaciones item)
		{
			try
			{
				return this.BL_CursoClasificaciones.Delete(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool SaveCursoClasificaciones(ref ObservableCollection<CursoClasificaciones> items)
		{
			try
			{
				return this.BL_CursoClasificaciones.Save(ref items);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
	}
}
