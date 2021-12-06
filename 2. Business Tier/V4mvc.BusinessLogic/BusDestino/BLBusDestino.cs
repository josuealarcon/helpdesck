using System;
using System.Linq;
using System.Transactions;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using Unity;

namespace V4mvc.BusinessLogic
{
	public partial class BLBusDestino : IBLBusDestino
	{
		
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		
		[Dependency]
		public IDABusDestino Repository { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLBusDestino(IDABusDestino x_container)
		{ Repository = x_container; }
		#endregion
		
		#region [ Consultas ]
		public ObservableCollection<BusDestino> GetAll()
		{
			try
			{
				return this.Repository.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public BusDestino GetOne()
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
		public Boolean Save(ref BusDestino Item)
		{
			try
			{
				return this.Repository.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean Save(ref ObservableCollection<BusDestino> Items)
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
