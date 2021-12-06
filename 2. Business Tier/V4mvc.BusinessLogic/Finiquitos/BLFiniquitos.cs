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
	public partial class BLFiniquitos : IBLFiniquitos
	{
		
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		
		[Dependency]
		public IDAFiniquitos Repository { get; set; }
		public IDAArchivos ArchivoRepository { get; set; }

		public IDADocs_Workers DocWorkersRepository { get; set; }

		public IDAWorkers WorkersRepository { get; set; }

		public IDADocs_Fec DocFecsRepository { get; set; }

		public IDADivisiones DivisionesRepository { get; set; }

		public IDAA054_MotivoFiniquito MotivFiniqRepo { get; set; }

		public IDAWorkers_MotivoFiniquito WMotivFiniqRepo { get; set; }

		public IDADocs_Fec_Workers DFWorkersRepo { get; set; }

		public IDAWorkers_MotivoFiniquito WorkerMotFiniqRepo { get; set; }

		#endregion

		#region [ Constructores ]
		public BLFiniquitos(
			IDAFiniquitos x_container,
			IDAArchivos y_container,
			IDADocs_Workers z_container,
			IDAWorkers w_container,
			IDADocs_Fec a_container,
			IDADivisiones b_container,
			IDAA054_MotivoFiniquito c_container,
			IDAWorkers_MotivoFiniquito d_container,
			IDADocs_Fec_Workers e_container,
			IDAWorkers_MotivoFiniquito f_container
			)
		{ 
			Repository = x_container;
			ArchivoRepository = y_container;
			DocWorkersRepository = z_container;
			WorkersRepository = w_container;
			DocFecsRepository = a_container;
			DivisionesRepository = b_container;
			MotivFiniqRepo = c_container;
			WMotivFiniqRepo = d_container;
			DFWorkersRepo = e_container;
			WorkerMotFiniqRepo = f_container;
		}
		#endregion
		
		#region [ Consultas ]
		public ObservableCollection<Finiquitos> GetAll()
		{
			try
			{
				return this.Repository.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Finiquitos GetOne(String Rut, String FechaCambio)
		{
			try
			{
				return this.Repository.GetOne(Rut, FechaCambio);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean Save(ref Finiquitos Item)
		{
			try
			{
				return this.Repository.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean Save(ref ObservableCollection<Finiquitos> Items)
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
