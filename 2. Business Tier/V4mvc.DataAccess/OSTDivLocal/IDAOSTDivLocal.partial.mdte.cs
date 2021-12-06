using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial interface IDAOSTDivLocal
    {

        #region [ Consultas ]

        ObservableCollection<OSTDivLocal> GetAllOSTDivLocal_Mdte(string NROOST, string MANDANTE, string EMPRESA);

        #endregion

        #region [ Metodos ]

        bool SaveOstDivLocalOST_Mdte(ref OSTDivLocal Item);

        #endregion

    }
}
