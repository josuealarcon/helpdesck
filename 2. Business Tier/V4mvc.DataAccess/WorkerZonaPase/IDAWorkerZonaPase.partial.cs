
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
        bool SaveWorkerZonaPase_PasesCtta(WorkerZonaPase zona);
        bool SaveWorkerZonaPaseAcceso_PasesCtta(WorkerZonaPase zona);

        bool DelWorkerZonaPase_PasesCtta(int IDPASE, string RUT, string concat_locales, string ESTAVACIO);
        bool DelWorkerZonaPaseAccesos_PasesCtta(int IDPASE, string RUT, string concat_locales, string ESTAVACIO);
        #endregion
    }
}
	