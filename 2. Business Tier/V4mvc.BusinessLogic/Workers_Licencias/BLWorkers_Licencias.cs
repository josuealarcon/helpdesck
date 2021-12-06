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
	public partial class BLWorkers_Licencias : IBLWorkers_Licencias
	{
		
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		
		[Dependency]
		public IDAWorkers_Licencias Repository { get; set; }
		public IDAWorkers RepositoryWorkers { get; set; }
		#endregion

		#region [ Constructores ]
		public BLWorkers_Licencias(IDAWorkers_Licencias x_container, IDAWorkers y_container)
		{
			Repository = x_container;
			RepositoryWorkers = y_container;
		}
		#endregion

		#region [ Consultas ]
		public ObservableCollection<Workers_Licencias> GetAll()
		{
			try
			{
				return this.Repository.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Workers_Licencias GetOne()
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
		public Boolean Save(ref Workers_Licencias Item)
		{
			try
			{
				return this.Repository.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean Save(ref ObservableCollection<Workers_Licencias> Items)
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
