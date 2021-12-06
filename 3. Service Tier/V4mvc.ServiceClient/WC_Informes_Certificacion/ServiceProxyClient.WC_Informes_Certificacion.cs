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
		public IBLWC_Informes_Certificacion BL_WC_Informes_Certificacion { get; set; }
		#endregion


		#region [ Constructor]
		public ServiceProxyClient(IBLWC_Informes_Certificacion BL_WC_Menu)
		{
			this.BL_WC_Informes_Certificacion = BL_WC_Informes_Certificacion;
		}

		#endregion

		#region [ Consultas ]
		public ObservableCollection<WC_Informes_Certificacion> GetAllWC_Informes_Certificacion()
		{
			try
			{
				return this.BL_WC_Informes_Certificacion.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public WC_Informes_Certificacion GetOneWC_Informes_Certificacion(Decimal CODMENU)
		{
			try
			{
				return this.BL_WC_Informes_Certificacion.GetOne(CODMENU);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]

		#endregion

	}
}
