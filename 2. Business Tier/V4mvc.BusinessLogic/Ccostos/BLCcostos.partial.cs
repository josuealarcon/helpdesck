using System;
using System.Linq;
using System.Transactions;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLCcostos
	{

		#region [ Consultas ]
		public ObservableCollection<Ccostos> GetCCostosSearcherCtta(ref Ccostos model)
		{
			try
			{
				return this.Repository.GetCCostosSearcherCtta(ref model);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public ObservableCollection<Ccostos> GetAllCcostosEnterpriseCtta(string EMPRESA)
		{
			try
			{
				return this.Repository.GetAllCcostosEnterpriseCtta(EMPRESA);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public Ccostos GetOneCcostoEnterpriseCtta(string EMPRESA, string CCOSTO)
		{
			try
			{
				return this.Repository.GetOneCcostoEnterpriseCtta(EMPRESA, CCOSTO);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion

		#region [ Métodos ]

		public bool ValidateCcosto_Ctta(string IDEMPRESA, string CCOSTO)
		{
			try
			{
				return this.Repository.ValidateCcosto_Ctta(IDEMPRESA, CCOSTO);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public Boolean SaveCcostoEntepriseCtta(ref Ccostos Item)
		{
			try
			{
				return this.Repository.SaveCcostoEntepriseCtta(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public Boolean SaveCcostoEntepriseCtta(ref ObservableCollection<Ccostos> Items)
		{
			try
			{
				using (TransactionScope tran = new TransactionScope())
				{
					for (int i = 0; i < Items.Count; i++)
					{
						var item = Items.ElementAt(i);
						this.Repository.SaveCcostoEntepriseCtta(ref item);
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
