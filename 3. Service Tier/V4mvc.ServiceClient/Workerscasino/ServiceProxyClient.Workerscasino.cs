using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Unity;

using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial class ServiceProxyClient : IServiceProxyClient
	{

		#region [ Propiedades ]

		[Dependency]
		public IBLWorkerscasino BL_Workerscasino { get; set; }

		#endregion

		#region [ Constructor]

		public ServiceProxyClient(IBLWorkerscasino BL_Workerscasino)
		{
			this.BL_Workerscasino = BL_Workerscasino;
		}

		#endregion

		#region [ Consultas ]

		public ObservableCollection<Workerscasino> GetAllWorkerscasinos()
		{
			try
			{
				return this.BL_Workerscasino.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public Workerscasino GetOneWorkerscasino(string RUT)
		{
			try
			{
				return this.BL_Workerscasino.GetOne(RUT);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
		
		#region [ Metodos ]

		public bool SaveWorkerscasino(ref Workerscasino item)
		{
			try
			{
				return this.BL_Workerscasino.Save(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool DeleteWorkerscasino(ref Workerscasino item)
		{
			try
			{
				return this.BL_Workerscasino.Delete(ref item);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public bool SaveWorkerscasinos(ref ObservableCollection<Workerscasino> items)
		{
			try
			{
				return this.BL_Workerscasino.Save(ref items);
			}
			catch (Exception ex)
			{ throw ex; }
		}

		#endregion
	}
}
