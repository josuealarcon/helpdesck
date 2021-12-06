using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using Unity;
using System.Transactions;

namespace V4mvc.BusinessLogic
{
	public partial class BLDocs_Workers_Mutual : IBLDocs_Workers_Mutual
	{
		
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		
		[Dependency]
		public IDADocs_Workers_Mutual Repository { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLDocs_Workers_Mutual(IDADocs_Workers_Mutual x_container)
		{ Repository = x_container; }
		#endregion
		
		#region [ Consultas ]
		public ObservableCollection<Docs_Workers_Mutual> GetAll()
		{
			try
			{
				return this.Repository.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Docs_Workers_Mutual GetOne()
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
		public Boolean Save(ref Docs_Workers_Mutual Item)
		{
			try
			{
				return this.Repository.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean Save(ref ObservableCollection<Docs_Workers_Mutual> Items)
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
