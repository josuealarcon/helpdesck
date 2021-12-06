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
		public IBLDivisiones BL_Divisiones { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLDivisiones BL_Divisiones)
        {
            this.BL_Divisiones = BL_Divisiones;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Divisiones> GetAllDivisiones()
		{
			try
			{
				return this.BL_Divisiones.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Divisiones GetOneDivisiones(String DIVCOD)
		{
			try
			{
				if (DIVCOD == null) { return null; }
				return this.BL_Divisiones.GetOne(DIVCOD);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveDivisiones(ref Divisiones Item)
		{
			try
			{
				return this.BL_Divisiones.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveDivisiones(ref ObservableCollection<Divisiones> Items)
		{
			try
			{
				return this.BL_Divisiones.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
