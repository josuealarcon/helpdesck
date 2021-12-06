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
	public partial class BLDocs_ControlAcceso_Laboral_Disputa : IBLDocs_ControlAcceso_Laboral_Disputa
	{
		
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		
		[Dependency]
		public IDADocs_ControlAcceso_Laboral_Disputa Repository { get; set; }
		#endregion
		
		#region [ Constructores ]
		public BLDocs_ControlAcceso_Laboral_Disputa(IDADocs_ControlAcceso_Laboral_Disputa x_container)
		{ Repository = x_container; }
		#endregion
		
		#region [ Consultas ]
		public ObservableCollection<Docs_ControlAcceso_Laboral_Disputa> GetAll()
		{
			try
			{
				return this.Repository.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Docs_ControlAcceso_Laboral_Disputa GetOne()
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
		public Boolean Save(ref Docs_ControlAcceso_Laboral_Disputa Item)
		{
			try
			{
				return this.Repository.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean Save(ref ObservableCollection<Docs_ControlAcceso_Laboral_Disputa> Items)
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
