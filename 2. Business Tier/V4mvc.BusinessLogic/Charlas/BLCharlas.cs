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
	public partial class BLCharlas : IBLCharlas
	{
		
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		
		[Dependency]
		public IDACharlas Repository { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLCharlas(IDACharlas x_container)
		{ Repository = x_container; }
		#endregion
		
		#region [ Consultas ]
		public ObservableCollection<Charlas> GetAll()
		{
			try
			{
				return this.Repository.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Charlas GetOne(Int32 IDCHARLA)
		{
			try
			{
				return this.Repository.GetOne(IDCHARLA);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean Save(ref Charlas Item)
		{
			try
			{
				return this.Repository.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean Save(ref ObservableCollection<Charlas> Items)
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
