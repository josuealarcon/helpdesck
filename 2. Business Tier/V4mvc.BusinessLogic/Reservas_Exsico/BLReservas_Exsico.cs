using System;
using System.Linq;
using System.Transactions;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using Unity;

namespace V4mvc.BusinessLogic
{
	public partial class BLReservas_Exsico : IBLReservas_Exsico
	{

		#region [ Propiedades ]

		public IUnityContainer ContainerService { get; set; }

		[Dependency]
		public IDAReservas_Exsico Repository { get; set; }

		#endregion

		#region [ Constructores ]

		public BLReservas_Exsico(IDAReservas_Exsico x_container)
		{ Repository = x_container; }

		#endregion

		#region [ Consultas ]

		public ObservableCollection<Reservas_Exsico> GetAll()
		{
			try
			{
				return this.Repository.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public Reservas_Exsico GetOne(Decimal ID)
		{
			try
			{
				return this.Repository.GetOne(ID);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Métodos ]

		public Boolean Save(ref Reservas_Exsico Item)
		{
			try
			{
				return this.Repository.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public Boolean Save(ref ObservableCollection<Reservas_Exsico> Items)
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