using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLLotePases
	{

        #region [ Consultas ]

        public ObservableCollection<LotePases> GetAllLotePases_PasesMdte(ref LotePases modelo)
        {
            try
            {
                return this.Repository.GetAllLotePases_PasesMdte(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }


        public LotePases GetOneLotePases_PasesMdte(ref LotePases modelo)
        {
            try
            {
                return this.Repository.GetOneLotePases_PasesMdte(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public LotePases GetOneLotePase_CertificacionMdte(int IDPASE)
        {
            try
            {
                return this.Repository.GetOneLotePase_CertificacionMdte(IDPASE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public LotePases GetOneLotePase_Validacion_CertificacionMdte(int IDPASE)
        {
            try
            {
                return this.Repository.GetOneLotePase_Validacion_CertificacionMdte(IDPASE);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        #endregion

    }
}
