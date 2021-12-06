using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial interface IDADivisiones
    {
        #region[ Consultas ]
        ObservableCollection<Divisiones> GetListDivision_Mdte( string DIVISIONES);
        ObservableCollection<Divisiones> GetListDivisiones_Mdte();

        #endregion
    }
}
