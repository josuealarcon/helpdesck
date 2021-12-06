
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial interface IDAWorkerZonaPase
    {
        #region [ Consultas ]

        #endregion

        #region [ Metodos ]
        bool SaveWorkerZonaPase_PasesMdte(WorkerZonaPase zona);

        bool DelWorkerZonaPase_PasesMdte(int IDPASE, string RUT, string concat_locales);
        #endregion
    }
}
	