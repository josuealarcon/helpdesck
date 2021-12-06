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
	public partial class BLDocs_ControlAcceso_Laboral : IBLDocs_ControlAcceso_Laboral
	{
		
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		
		[Dependency]
		public IDADocs_ControlAcceso_Laboral Repository { get; set; }
		public IDAArchivos RepositoryArchivos { get; set; }
		public IDADocs_ControlAcceso_Laboral_Disputa RepositoryDocs_ControlAcceso_Laboral_Disputa { get; set; }
		public IDADocs_Tipo_Rechazo RepositoryDocs_Tipo_Rechazo { get; set; }

		#endregion

		#region [ Constructores ]
		public BLDocs_ControlAcceso_Laboral(IDADocs_ControlAcceso_Laboral x_container
			                              , IDAArchivos x_container1
			                              , IDADocs_ControlAcceso_Laboral_Disputa x_container2
			                              , IDADocs_Tipo_Rechazo x_container3)
		{ Repository = x_container;
			RepositoryArchivos = x_container1;
			RepositoryDocs_ControlAcceso_Laboral_Disputa = x_container2;
			RepositoryDocs_Tipo_Rechazo = x_container3;
		}
		#endregion
		
		#region [ Consultas ]
		public ObservableCollection<Docs_ControlAcceso_Laboral> GetAll()
		{
			try
			{
				return this.Repository.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Docs_ControlAcceso_Laboral GetOne()
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
		public Boolean Save(ref Docs_ControlAcceso_Laboral Item)
		{
			try
			{
				return this.Repository.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean Save(ref ObservableCollection<Docs_ControlAcceso_Laboral> Items)
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
