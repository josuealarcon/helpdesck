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
		public IBLAprobacion_SubContratos BL_Aprobacion_SubContratos { get; set; }
        #endregion

        #region [ Constructor]
        public ServiceProxyClient(IBLAprobacion_SubContratos BL_Aprobacion_SubContratos)
        {
            this.BL_Aprobacion_SubContratos = BL_Aprobacion_SubContratos;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Aprobacion_SubContratos> GetAllAprobacion_SubContratos()
		{
			try
			{
				return this.BL_Aprobacion_SubContratos.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Aprobacion_SubContratos GetOneAprobacion_SubContratos(Int32 ID)
		{
			try
			{
				return this.BL_Aprobacion_SubContratos.GetOne(ID);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveAprobacion_SubContratos(ref Aprobacion_SubContratos Item)
		{
			try
			{
				return this.BL_Aprobacion_SubContratos.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveAprobacion_SubContratos(ref ObservableCollection<Aprobacion_SubContratos> Items)
		{
			try
			{
				return this.BL_Aprobacion_SubContratos.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
