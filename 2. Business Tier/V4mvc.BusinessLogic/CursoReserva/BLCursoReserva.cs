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
	public partial class BLCursoReserva : IBLCursoReserva
	{
		
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		
		[Dependency]
		public IDACursoReserva Repository { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLCursoReserva(IDACursoReserva x_container)
		{ Repository = x_container; }
		#endregion
		
		#region [ Consultas ]
		public ObservableCollection<CursoReserva> GetAll(Int32 CODIGO)
		{
			try
			{
				return this.Repository.GetAll(CODIGO);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public CursoReserva GetOne(Int32 CODIGO, String RUT)
		{
			try
			{
				return this.Repository.GetOne(CODIGO, RUT);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean Save(ref CursoReserva Item)
		{
			try
			{
				return this.Repository.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean Save(ref ObservableCollection<CursoReserva> Items)
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
