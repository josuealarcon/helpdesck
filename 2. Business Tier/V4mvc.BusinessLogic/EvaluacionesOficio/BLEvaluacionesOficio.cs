using System;
using System.Linq;
using System.Text;
using System.Transactions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Unity;
using V4mvc.Entities;
using V4mvc.DataAccess;
using System.Transactions;

namespace V4mvc.BusinessLogic
{
	public partial class BLEvaluacionesOficio : IBLEvaluacionesOficio
	{
		#region [ Propiedades ]

		public IUnityContainer ContainerService { get; set; }

		[Dependency]
		public IDAEvaluacionesOficio Repository { get; set; }
		public IDACharlas_Division RepositoryCharlasDivision { get; set; }

		#endregion

		#region [ Constructores ]

		public BLEvaluacionesOficio(IDAEvaluacionesOficio x_container, IDACharlas_Division x_container1)
		{
			Repository = x_container;
			RepositoryCharlasDivision = x_container1;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<EvaluacionesOficio> GetAll(ref EvaluacionesOficio evaluacionesOficio)
		{
			try
			{
				return this.Repository.GetAll(ref evaluacionesOficio);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public EvaluacionesOficio GetOne(Int32 IDCHARLA)
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

		public bool Save(ref EvaluacionesOficio item)
		{
			try
			{
				using (TransactionScope tran = new TransactionScope())
				{
					this.Repository.Save(ref item);
					if (item.Instance == InstanceEntity.Modify)
						this.RepositoryCharlasDivision.DeleteAll(item.IDCHARLA);
					if (item.ListCharlasDivisiones != null)
					{
						foreach (var _item in item.ListCharlasDivisiones.Where(var => var.CHECKED).ToList())
						{
							var charlasDivision = new Charlas_Division();
							charlasDivision.IDCHARLA = item.IDCHARLA;
							charlasDivision.DIVISION = _item.DIVISION;
							charlasDivision.Instance = InstanceEntity.New;
							this.RepositoryCharlasDivision.Save(ref charlasDivision);
						}
					}
					tran.Complete();
				}
				return true;
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool Delete(ref EvaluacionesOficio item)
		{
			try
			{
				return this.Repository.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool Save(ref ObservableCollection<EvaluacionesOficio> items)
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
