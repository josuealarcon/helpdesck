
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial interface IBLOSTDivLocal
    {
        #region [ Consultas ]
        ObservableCollection<OSTDivLocal> GetAllOSTDivLocal_ContratOSTCtta(string NROOST);
        #endregion

        #region [ Metodos ]

        #endregion
    }
}
	