using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
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
		public IBLMutualidad BL_Mutualidad { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLMutualidad BL_Mutualidad)
        {
            this.BL_Mutualidad = BL_Mutualidad;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Mutualidad> GetAllMutualidad()
		{
			try
			{
				return this.BL_Mutualidad.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Mutualidad GetOneMutualidad(int IDMUTUAL)
		{
			try
			{
				return this.BL_Mutualidad.GetOne(IDMUTUAL);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveMutualidad(ref Mutualidad Item)
		{
			try
			{
				return this.BL_Mutualidad.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveMutualidad(ref ObservableCollection<Mutualidad> Items)
		{
			try
			{
				return this.BL_Mutualidad.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
