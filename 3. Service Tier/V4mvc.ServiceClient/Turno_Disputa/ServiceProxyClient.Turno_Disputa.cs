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
		public IBLTurno_Disputa BL_Turno_Disputa { get; set; }
        #endregion

        #region [ Contructor ]

        public ServiceProxyClient(IBLTurno_Disputa BL_Turno_Disputa)
        {
            this.BL_Turno_Disputa = BL_Turno_Disputa;
        }

		#endregion

		#region [ Consultas ]
		public ObservableCollection<Turno_Disputa> GetAll()
		{
			try
			{
				return this.BL_Turno_Disputa.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}

		public Turno_Disputa GetOne(int ID_DISPUTA)
		{
			try
			{
				return this.BL_Turno_Disputa.GetOne(ID_DISPUTA);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]

		#endregion

	}
}
