using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial class ServiceProxyClient
	{

        #region [ Consultas ]

        public ObservableCollection<Aprobacion_SubContratos> GetAllAprobacion_SubContratosPendientes(string IDEMPRESA) {
            try
            {
                return this.BL_Aprobacion_SubContratos.GetAllAprobacion_SubContratosPendientes(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Aprobacion_SubContratos> GetAllAprobacion_SubContratosEnProceso(string IDEMPRESA)
        {
            try
            {
                return this.BL_Aprobacion_SubContratos.GetAllAprobacion_SubContratosEnProceso(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Aprobacion_SubContratos> GetAllAprobacion_SubContratosEnProcesadas(string IDEMPRESA)
        {
            try
            {
                return this.BL_Aprobacion_SubContratos.GetAllAprobacion_SubContratosEnProcesadas(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        public Boolean Save_Aprobacion_SubContratos( Aprobacion_SubContratos Item)
        {
            try
            {
                return this.BL_Aprobacion_SubContratos.Save_Aprobacion_SubContratos( Item);
            }
            catch (Exception ex)
            { throw ex; }
        
        }
        #endregion

    }
}
