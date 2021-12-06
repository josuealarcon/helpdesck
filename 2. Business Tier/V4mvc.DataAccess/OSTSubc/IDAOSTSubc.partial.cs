
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial interface IDAOSTSubc
    {
        #region [ Consultas ]
        ObservableCollection<OSTSubc> GetAllOSTSubC_ContratOSTCtta(string IDEMPRESA);
        #endregion

        #region [ Metodos ]

        #endregion
    }
}
	