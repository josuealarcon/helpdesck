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
		public IBLArchivos BL_Archivos { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLArchivos BL_Archivos)
        {
            this.BL_Archivos = BL_Archivos;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Archivos> GetAllArchivos()
		{
			try
			{
				return this.BL_Archivos.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Archivos GetOneArchivos(Guid ID)
		{
			try
			{
				return this.BL_Archivos.GetOne(ID);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveArchivos(ref Archivos Item)
		{
			try
			{
				return this.BL_Archivos.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveArchivos(ref ObservableCollection<Archivos> Items)
		{
			try
			{
				return this.BL_Archivos.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
