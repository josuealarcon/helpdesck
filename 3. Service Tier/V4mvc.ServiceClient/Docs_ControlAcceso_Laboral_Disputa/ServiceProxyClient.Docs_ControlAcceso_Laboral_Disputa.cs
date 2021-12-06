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
		public IBLDocs_ControlAcceso_Laboral_Disputa BL_Docs_ControlAcceso_Laboral_Disputa { get; set; }
        #endregion

        #region [ Contructor ]

        public ServiceProxyClient(IBLDocs_ControlAcceso_Laboral_Disputa BL_Docs_ControlAcceso_Laboral_Disputa)
        {
            this.BL_Docs_ControlAcceso_Laboral_Disputa = BL_Docs_ControlAcceso_Laboral_Disputa;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Docs_ControlAcceso_Laboral_Disputa> GetAllDocs_ControlAcceso_Laboral_Disputa()
		{
			try
			{
				return this.BL_Docs_ControlAcceso_Laboral_Disputa.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Docs_ControlAcceso_Laboral_Disputa GetOneDocs_ControlAcceso_Laboral_Disputa()
		{
			try
			{
                return null;// this.BL_Docs_ControlAcceso_Laboral_Disputa.GetOne();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveDocs_ControlAcceso_Laboral_Disputa(ref Docs_ControlAcceso_Laboral_Disputa Item)
		{
			try
			{
				return this.BL_Docs_ControlAcceso_Laboral_Disputa.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveDocs_ControlAcceso_Laboral_Disputa(ref ObservableCollection<Docs_ControlAcceso_Laboral_Disputa> Items)
		{
			try
			{
				return this.BL_Docs_ControlAcceso_Laboral_Disputa.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
