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
		public IBLCursosProgramados BL_CursosProgramados { get; set; }

		#endregion

		#region [ Constructor]

		public ServiceProxyClient(IBLCursosProgramados BL_CursosProgramados)
		{
			this.BL_CursosProgramados = BL_CursosProgramados;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<CursosProgramados> GetAllCursosProgramados(ref CursosProgramados cursosProgramados)
		{
			try
			{
				return this.BL_CursosProgramados.GetAll(ref cursosProgramados);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public CursosProgramados GetOneCursoProgramado(Int32 CODIGO)
		{
			try
			{
				return this.BL_CursosProgramados.GetOne(CODIGO);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]

		public bool SaveCursoProgramado(ref CursosProgramados item)
		{
			try
			{
				return this.BL_CursosProgramados.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool DeleteCursoProgramado(ref CursosProgramados item)
		{
			try
			{
				return this.BL_CursosProgramados.Delete(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool SaveCursosProgramados(ref ObservableCollection<CursosProgramados> items)
		{
			try
			{
				return this.BL_CursosProgramados.Save(ref items);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
	}
}
