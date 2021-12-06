using System;
using System.Linq;
using System.Transactions;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using Unity;

namespace V4mvc.BusinessLogic
{
	public partial class BLBonosValor : IBLBonosValor
	{

		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }

		[Dependency]
		public IDABonosValor Repository { get; set; }
		#endregion

		#region [ Constructores ]
		public BLBonosValor(IDABonosValor x_container)
		{ Repository = x_container; }
		#endregion

		#region [ Consultas ]
		public ObservableCollection<BonosValor> GetAll()
		{
			try
			{
				return this.Repository.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public BonosValor GetOne()
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
		public Boolean Save(ref BonosValor Item)
		{
			try
			{
				return this.Repository.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean Save(ref ObservableCollection<BonosValor> Items)
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
