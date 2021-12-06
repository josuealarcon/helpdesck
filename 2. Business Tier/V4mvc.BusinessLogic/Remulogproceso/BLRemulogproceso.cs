using System;
using System.Linq;
using System.Transactions;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using Unity;

namespace V4mvc.BusinessLogic
{
	public partial class BLRemulogproceso : IBLRemulogproceso
	{
		
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		
		[Dependency]
		public IDARemulogproceso Repository { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLRemulogproceso(IDARemulogproceso x_container)
		{ Repository = x_container; }
		#endregion
		
		#region [ Consultas ]
		public ObservableCollection<Remulogproceso> GetAll()
		{
			try
			{
				return this.Repository.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Remulogproceso GetOne(Decimal IDPROG)
		{
			try
			{
				return this.Repository.GetOne(IDPROG);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean Save(ref Remulogproceso Item)
		{
			try
			{
				return this.Repository.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean Save(ref ObservableCollection<Remulogproceso> Items)
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
