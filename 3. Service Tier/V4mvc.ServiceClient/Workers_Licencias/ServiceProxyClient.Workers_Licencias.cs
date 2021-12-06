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
		public IBLWorkers_Licencias BL_Workers_Licencias { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLWorkers_Licencias BL_Workers_Licencias)
        {
            this.BL_Workers_Licencias = BL_Workers_Licencias;
        }
        #endregion

        #region [ Consultas ]
        public ObservableCollection<Workers_Licencias> GetAllWorkers_Licencias()
		{
			try
			{
				return this.BL_Workers_Licencias.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Workers_Licencias GetOneWorkers_Licencias()
		{
			try
			{
                return null;// this.BL_Workers_Licencias.GetOne();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveWorkers_Licencias(ref Workers_Licencias Item)
		{
			try
			{
				return this.BL_Workers_Licencias.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveWorkers_Licencias(ref ObservableCollection<Workers_Licencias> Items)
		{
			try
			{
				return this.BL_Workers_Licencias.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
