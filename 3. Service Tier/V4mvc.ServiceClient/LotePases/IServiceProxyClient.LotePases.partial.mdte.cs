using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
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
