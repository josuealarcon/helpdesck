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

        public ObservableCollection<LotePases> GetAllLotePases_PasesMdte(ref LotePases modelo)
        {
            try
            {
                return this.BL_LotePases.GetAllLotePases_PasesMdte(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public LotePases GetOneLotePases_PasesMdte(ref LotePases modelo)
        {
            try
            {
                return this.BL_LotePases.GetOneLotePases_PasesMdte(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public LotePases GetOneLotePase_CertificacionMdte(int IDPASE)
        {
            try
            {
                return this.BL_LotePases.GetOneLotePase_CertificacionMdte(IDPASE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public LotePases GetOneLotePase_Validacion_CertificacionMdte(int IDPASE)
        {
            try
            {
                return this.BL_LotePases.GetOneLotePase_Validacion_CertificacionMdte(IDPASE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        #endregion

    }
}
