using System;
using System.Linq;
using System.Text;
using System.Transactions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Unity;
using V4mvc.Entities;
using V4mvc.DataAccess;

namespace V4mvc.BusinessLogic
{
	public partial class BLWorkerscasino : IBLWorkerscasino
	{
		#region [ Propiedades ]

		public IUnityContainer ContainerService { get; set; }

		[Dependency]
		public IDAWorkerscasino Repository { get; set; }

		#endregion

		#region [ Constructores ]

		public BLWorkerscasino(IDAWorkerscasino x_container)
		{
			Repository = x_container;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<Workerscasino> GetAll()
		{
			try
			{
				return this.Repository.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public Workerscasino GetOne(string RUT)
		{
			try
			{
				return this.Repository.GetOne(RUT);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Metodos ]

		public bool Save(ref Workerscasino item)
		{
			try
			{
				return this.Repository.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool Delete(ref Workerscasino item)
		{
			try
			{
				return this.Repository.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool Save(ref ObservableCollection<Workerscasino> items)
		{
			try
			{
				for (int i = 0; i < items.Count; ++i)
				{
					var item = items.ElementAt(i);
					this.Repository.Save(ref item);
				}
				return true;
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
	}
}
