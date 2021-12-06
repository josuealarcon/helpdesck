using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial interface IBLOSTCombust
    {

        #region [ Consultas ]

        ObservableCollection<OSTCombust> GetAllOSTCombust_Mdte(string NROOST, string IDEMPRESA);

        #endregion

        #region [ Metodos ]

        bool DeleteOstCombustOST_Mdte(ref OST Item);
        bool SaveOstCombustOST_Mdte(ref OSTCombust Item);
        bool SaveOstCombustOST_Mdte(ObservableCollection<OSTCombust> Items);

        #endregion
    }
}
