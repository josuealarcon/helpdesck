using System;
using System.Linq;
using System.Transactions;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using Unity;

namespace V4mvc.BusinessLogic
{
	public partial class BLCcostos : IBLCcostos
	{

		#region [ Propiedades ]

		public IUnityContainer ContainerService { get; set; }

		[Dependency]
		public IDACcostos Repository { get; set; }

		#endregion

		#region [ Constructores ]

		public BLCcostos(IDACcostos x_container)
		{ Repository = x_container; }

		#endregion

		#region [ Consultas ]

		public ObservableCollection<Ccostos> GetAll()
		{
			try
			{
				return this.Repository.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public Ccostos GetOne(string EMPRESA, string CCOSTO)
		{
			try
			{
				return this.Repository.GetOne(EMPRESA, CCOSTO);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Métodos ]

		public Boolean Save(ref Ccostos Item)
		{
			try
			{
				return this.Repository.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public Boolean Save(ref ObservableCollection<Ccostos> Items)
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
