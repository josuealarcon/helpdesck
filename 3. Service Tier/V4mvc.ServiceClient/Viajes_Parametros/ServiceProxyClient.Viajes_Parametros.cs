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
		public IBLViajes_Parametros BL_Viajes_Parametros { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLViajes_Parametros BL_Viajes_Parametros)
        {
            this.BL_Viajes_Parametros = BL_Viajes_Parametros;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Viajes_Parametros> GetAllViajes_Parametros()
		{
			try
			{
				return this.BL_Viajes_Parametros.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Viajes_Parametros GetOneViajes_Parametros()
		{
			try
			{
                return null;// this.BL_Viajes_Parametros.GetOne();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveViajes_Parametros(ref Viajes_Parametros Item)
		{
			try
			{
				return this.BL_Viajes_Parametros.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveViajes_Parametros(ref ObservableCollection<Viajes_Parametros> Items)
		{
			try
			{
				return this.BL_Viajes_Parametros.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
