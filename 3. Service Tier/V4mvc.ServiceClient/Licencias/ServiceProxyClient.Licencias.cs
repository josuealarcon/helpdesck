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
		public IBLLicencias BL_Licencias { get; set; }
        #endregion

        #region [ Contructor ]

        public ServiceProxyClient(IBLLicencias BL_Licencias)
        {
            this.BL_Licencias = BL_Licencias;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Licencias> GetAllLicencias()
		{
			try
			{
				return this.BL_Licencias.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Licencias GetOneLicencias()
		{
			try
			{
                return null;//this.BL_Licencias.GetOne();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveLicencias(ref Licencias Item)
		{
			try
			{
				return this.BL_Licencias.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveLicencias(ref ObservableCollection<Licencias> Items)
		{
			try
			{
				return this.BL_Licencias.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
