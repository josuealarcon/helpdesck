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
		public IBLEvaluacionesOficio BL_EvaluacionesOficio { get; set; }

		#endregion

		#region [ Constructor]

		public ServiceProxyClient(IBLEvaluacionesOficio BL_EvaluacionesOficio)
		{
			this.BL_EvaluacionesOficio = BL_EvaluacionesOficio;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<EvaluacionesOficio> GetAllEvaluacionesOficio(ref EvaluacionesOficio evaluacionesOficio)
		{
			try
			{
				return this.BL_EvaluacionesOficio.GetAll(ref evaluacionesOficio);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public EvaluacionesOficio GetOneEvaluacionOficio(Int32 IDCHARLA)
		{
			try
			{
				return this.BL_EvaluacionesOficio.GetOne(IDCHARLA);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
		
		#region [ Metodos ]

		public bool SaveEvaluacionOficio(ref EvaluacionesOficio item)
		{
			try
			{
				return this.BL_EvaluacionesOficio.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool DeleteEvaluacionOficio(ref EvaluacionesOficio item)
		{
			try
			{
				return this.BL_EvaluacionesOficio.Delete(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool SaveEvaluacionesOficio(ref ObservableCollection<EvaluacionesOficio> items)
		{
			try
			{
				return this.BL_EvaluacionesOficio.Save(ref items);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
	}
}
