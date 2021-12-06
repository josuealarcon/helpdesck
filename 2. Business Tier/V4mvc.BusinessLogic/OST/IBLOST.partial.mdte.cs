using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial interface IBLOST
    {

        #region [ Consultas ]

        OST GetOneOST_Mdte(string NROOST);
        bool ValidateOST(string NROOST);
        bool GetStatusOst_Mdte(string NROOST, string IDEMPRESA, string MADRE);

        #endregion

        #region [ Metodos ]

        bool UpdateStatusOst_Mdte(string NROOST, string IDEMPRESA, string MADRE);
        bool SaveContratoOST_Mdte(ref OST model);

        #endregion

    }
}
