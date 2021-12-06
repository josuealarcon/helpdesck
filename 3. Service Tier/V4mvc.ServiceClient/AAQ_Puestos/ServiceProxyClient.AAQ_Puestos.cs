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
		public IBLAAQ_Puestos BL_AAQ_Puestos { get; set; }

		#endregion

		#region [ Constructor]

		public ServiceProxyClient(IBLAAQ_Puestos BL_AAQ_Puestos)
		{
			this.BL_AAQ_Puestos = BL_AAQ_Puestos;
		}

		#endregion

		#region [ Consultas ]

		//añadido
		public ObservableCollection<AAQ_Puestos> GetAllPuestos_Mdte(ref AAQ_Puestos item)
		{
			try
			{
				return this.BL_AAQ_Puestos.GetAllPuestos_Mdte(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		//

		public AAQ_Puestos GetOnePuestos_Mdte(Int32 IDPUESTO)
		{
			try
			{
				return this.BL_AAQ_Puestos.GetOnePuestos_Mdte(IDPUESTO);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Metodos ]


		public bool DeletePuestos_Mdte(string IDPUESTO)
		{
			try
			{
				return this.BL_AAQ_Puestos.DeletePuestos_Mdte(IDPUESTO);
			}
			catch (Exception ex)
			{ throw ex; }
		}


		#endregion
	}
}
