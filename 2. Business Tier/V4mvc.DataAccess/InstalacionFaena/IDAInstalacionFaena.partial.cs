
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial interface IDAInstalacionFaena
    {
        #region [ Consultas ]
        InstalacionFaena GetOneInstFaena_ContratOSTCtta(string NROOST);
        InstalacionFaena GetOneInstFaena_ContratOSTCtta(string NROOST, string IDEMPRESA, string MADRE, Int16 NIVEL);
        #endregion

        #region [ Metodos ]

        #endregion
    }
}
	