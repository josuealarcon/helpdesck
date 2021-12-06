using System;
using System.Linq;
using System.Text;
using System.Transactions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Unity;
using V4mvc.Entities;
using V4mvc.DataAccess;

namespace V4mvc.BusinessLogic
{
	public partial class BLAAQ_Puestos : IBLAAQ_Puestos
	{
		#region [ Propiedades ]

		public IUnityContainer ContainerService { get; set; }

		[Dependency]
		public IDAAAQ_Puestos Repository { get; set; }

		#endregion

		#region [ Constructores ]

		public BLAAQ_Puestos(IDAAAQ_Puestos x_container)
		{
			Repository = x_container;
		}

		#endregion

		#region [ Consultas ]

		//Añadido
		public ObservableCollection<AAQ_Puestos> GetAllPuestos_Mdte(ref AAQ_Puestos item)
		{
			try
			{
				return this.Repository.GetAllPuestos_Mdte(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		//


		public AAQ_Puestos GetOnePuestos_Mdte(Int32 IDPUESTO)
		{
			try
			{
				return this.Repository.GetOnePuestos_Mdte(IDPUESTO);
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
				return this.Repository.DeletePuestos_Mdte(IDPUESTO);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
	}
}
