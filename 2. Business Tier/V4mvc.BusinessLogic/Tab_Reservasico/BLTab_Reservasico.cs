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
	public partial class BLTab_Reservasico : IBLTab_Reservasico
	{

		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }

		[Dependency]
		public IDATab_Reservasico Repository { get; set; }
		#endregion

		#region [ Constructores ]
		public BLTab_Reservasico(IDATab_Reservasico x_container)
		{ Repository = x_container; }
		#endregion

		#region [ Consultas ]
		public ObservableCollection<Tab_Reservasico> GetAll()
		{
			try
			{
				return this.Repository.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Tab_Reservasico GetOne(Decimal ID)
		{
			try
			{
				return this.Repository.GetOne(ID);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]
		public Boolean Save(ref Tab_Reservasico Item)
		{
			try
			{
				return this.Repository.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean Save(ref ObservableCollection<Tab_Reservasico> Items)
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