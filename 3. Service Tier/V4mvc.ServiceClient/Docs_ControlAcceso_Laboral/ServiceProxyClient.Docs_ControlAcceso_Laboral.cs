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
		public IBLDocs_ControlAcceso_Laboral BL_Docs_ControlAcceso_Laboral { get; set; }
        #endregion

        #region [ Contructor ]

        public ServiceProxyClient(IBLDocs_ControlAcceso_Laboral BL_Docs_ControlAcceso_Laboral)
        {
            this.BL_Docs_ControlAcceso_Laboral = BL_Docs_ControlAcceso_Laboral;
        }

        #endregion

        #region [ Consultas ]
        public ObservableCollection<Docs_ControlAcceso_Laboral> GetAllDocs_ControlAcceso_Laboral()
		{
			try
			{
				return this.BL_Docs_ControlAcceso_Laboral.GetAll();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Docs_ControlAcceso_Laboral GetOneDocs_ControlAcceso_Laboral()
		{
			try
			{
                return null;// this.BL_Docs_ControlAcceso_Laboral.GetOne();
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
		#region [ Metodos ]
		public Boolean SaveDocs_ControlAcceso_Laboral(ref Docs_ControlAcceso_Laboral Item)
		{
			try
			{
				return this.BL_Docs_ControlAcceso_Laboral.Save(ref Item);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public Boolean SaveDocs_ControlAcceso_Laboral(ref ObservableCollection<Docs_ControlAcceso_Laboral> Items)
		{
			try
			{
				return this.BL_Docs_ControlAcceso_Laboral.Save(ref Items);
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
		
	}
}
