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
	public partial class BLLiquidacion : IBLLiquidacion
	{
		
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		
		[Dependency]
		public IDALiquidacion Repository { get; set; }

		public IDAArchivos RepositoryArchivos { get; set; }
		public IDALiquidacion_Disputa RepositoryLiquidacion_Disputa { get; set; }
		public IDADocs_Tipo_Rechazo RepositoryDocs_Tipo_Rechazo { get; set; }
		#endregion

		#region [ Constructores ]
		public BLLiquidacion(IDALiquidacion x_container
			               , IDAArchivos x_container1
			               , IDALiquidacion_Disputa x_container2
			               , IDADocs_Tipo_Rechazo x_container3)
		{   Repository = x_container;
			RepositoryArchivos = x_container1;
			RepositoryLiquidacion_Disputa = x_container2;
			RepositoryDocs_Tipo_Rechazo = x_container3;
		}
		#endregion
		
		#region [ Consultas ]
		public ObservableCollection<Liquidacion> GetAll()
		{
			try
			{
				return this.Repository.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Liquidacion GetOne()
		{
			try
			{
                return null;// this.Repository.GetOne();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean Save(ref Liquidacion Item)
		{
			try
			{
				return this.Repository.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean Save(ref ObservableCollection<Liquidacion> Items)
		{
			try
			{
				using (TransactionScope tran = new TransactionScope())
				{
					for (int i = 0; i < Items.Count; i++)
					{
						var item = Items.ElementAt(i);
						this.Repository.Save(ref item);
					}
					tran.Complete();
				}
				return true;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
