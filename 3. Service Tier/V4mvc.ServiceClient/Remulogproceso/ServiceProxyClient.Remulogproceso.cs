using System;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;
using Unity;

namespace V4mvc
{
	public partial class ServiceProxyClient : IServiceProxyClient
	{		
		#region [ Propiedades ]
		[Dependency]
		public IBLRemulogproceso BL_Remulogproceso { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLRemulogproceso BL_Remulogproceso)
        {
            this.BL_Remulogproceso = BL_Remulogproceso;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Remulogproceso> GetAllRemulogproceso()
		{
			try
			{
				return this.BL_Remulogproceso.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Remulogproceso GetOneRemulogproceso(Decimal IDPROG)
		{
			try
			{
				return this.BL_Remulogproceso.GetOne(IDPROG);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveRemulogproceso(ref Remulogproceso Item)
		{
			try
			{
				return this.BL_Remulogproceso.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveRemulogproceso(ref ObservableCollection<Remulogproceso> Items)
		{
			try
			{
				return this.BL_Remulogproceso.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
