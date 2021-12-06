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
		public IBLMotivo_Finiquito BL_Motivo_Finiquito { get; set; }
        #endregion
        #region [ Contructor ]

        public ServiceProxyClient(IBLMotivo_Finiquito container)
        {
            this.BL_Motivo_Finiquito = container;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Motivo_Finiquito> GetAllMotivo_Finiquito()
		{
			try
			{
				return this.BL_Motivo_Finiquito.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Motivo_Finiquito GetOneMotivo_Finiquito()
		{
			try
			{
                return null;//this.BL_Motivo_Finiquito.GetOne();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveMotivo_Finiquito(ref Motivo_Finiquito Item)
		{
			try
			{
				return this.BL_Motivo_Finiquito.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveMotivo_Finiquito(ref ObservableCollection<Motivo_Finiquito> Items)
		{
			try
			{
				return this.BL_Motivo_Finiquito.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
