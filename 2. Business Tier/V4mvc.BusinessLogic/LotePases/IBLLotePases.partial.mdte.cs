using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLLotePases
	{

        #region [ Consultas ]

        ObservableCollection<LotePases> GetAllLotePases_PasesMdte(ref LotePases modelo);

        LotePases GetOneLotePases_PasesMdte(ref LotePases modelo);

        LotePases GetOneLotePase_CertificacionMdte(int IDPASE);

        LotePases GetOneLotePase_Validacion_CertificacionMdte(int IDPASE);

        #endregion

        #region [ Metodos ]

        #endregion

    }
}
