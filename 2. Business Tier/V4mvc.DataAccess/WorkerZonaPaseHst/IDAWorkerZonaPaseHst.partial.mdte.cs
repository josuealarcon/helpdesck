
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial interface IDAWorkerZonaPaseHst
    {
        #region [ Consultas ]

        #endregion

        #region [ Metodos ]
        bool SaveWorkerZonaPaseHst_PasesMdte(int IDPASE, string RUT, string ID_EMPRESA);
        #endregion
    }
}
	