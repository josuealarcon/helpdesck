using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial interface IDAOSTCombust
    {

        #region [ Consultas ]

        ObservableCollection<OSTCombust> GetAllOSTCombust_Mdte(string NROOST, string IDEMPRESA);

        #endregion

        #region [ Metodos ]

        bool DeleteOstCombustOST_Mdte(ref OST Item);
        bool SaveOstCombustOST_Mdte(ref OSTCombust Item);

        #endregion

    }
}
