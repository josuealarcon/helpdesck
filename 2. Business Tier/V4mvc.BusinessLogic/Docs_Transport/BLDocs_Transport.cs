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
	public partial class BLDocs_Transport : IBLDocs_Transport
	{
		
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		
		[Dependency]
		public IDADocs_Transport Repository { get; set; }
		public DADocs_Transport_Rechazo RepositoryDocs_Transport_Rechazo { get; set; }
		public IDAArchivos RepositoryArchivos { get; set; }
		public IDATransport RepositoryTransport { get; set; }
		public IDADocs_Fec_Workers RepositoryDocsFecWorkers { get; set; }

		#endregion

		#region [ Constructores ]
		public BLDocs_Transport(IDADocs_Transport x_container
			                    , DADocs_Transport_Rechazo x_container1
			                    , IDAArchivos x_container2
			                    , IDATransport x_container3
			                    , IDADocs_Fec_Workers x_container4)
		{ 
			Repository = x_container;
			RepositoryDocs_Transport_Rechazo = x_container1;
			RepositoryArchivos = x_container2;
			RepositoryTransport = x_container3;
			RepositoryDocsFecWorkers = x_container4;
		}
		#endregion
		
		#region [ Consultas ]
		public ObservableCollection<Docs_Transport> GetAll()
		{
			try
			{
				return this.Repository.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Docs_Transport GetOne(Int32 ID_DOCS_VEH)
		{
			try
			{
				return this.Repository.GetOne(ID_DOCS_VEH);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]

		public Boolean Save(ref Docs_Transport Item)
		{
			try
			{
				return this.Repository.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }

		}
		
		public Boolean Save(ref ObservableCollection<Docs_Transport> Items)
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
