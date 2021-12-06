using System;
using System.Linq;
using System.Text;
using System.Transactions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using Unity;

namespace V4mvc.BusinessLogic
{
	public partial class BLTurno_Disputa : IBLTurno_Disputa
	{
		
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		
		[Dependency]
		public IDATurno_Disputa Repository { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLTurno_Disputa(IDATurno_Disputa x_container)
		{ Repository = x_container; }
		#endregion

		#region [ Consultas ]
		public ObservableCollection<Turno_Disputa> GetAll()
		{
			try
			{
				return this.Repository.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Turno_Disputa GetOne(int ID_DISPUTA)
		{
			try
			{
				return this.Repository.GetOne(ID_DISPUTA);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]
		#endregion

	}
}
