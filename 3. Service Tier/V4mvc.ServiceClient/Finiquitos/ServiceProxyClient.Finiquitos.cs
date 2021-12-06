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
		public IBLFiniquitos BL_Finiquitos { get; set; }
        #endregion
        #region [ Contructor ]

        public ServiceProxyClient(IBLFiniquitos container)
        {
            this.BL_Finiquitos = container;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Finiquitos> GetAllFiniquitos()
		{
			try
			{
				return this.BL_Finiquitos.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Finiquitos GetOneFiniquitos(String Rut, String FechaCambio)
		{
			try
			{
				return this.BL_Finiquitos.GetOne(Rut, FechaCambio);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveFiniquitos(ref Finiquitos Item)
		{
			try
			{
				return this.BL_Finiquitos.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveFiniquitos(ref ObservableCollection<Finiquitos> Items)
		{
			try
			{
				return this.BL_Finiquitos.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
