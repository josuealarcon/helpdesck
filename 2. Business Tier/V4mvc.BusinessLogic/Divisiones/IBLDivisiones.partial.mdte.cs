using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial interface IBLDivisiones
    {
        #region[ Consultas ]
        ObservableCollection<Divisiones> GetListDivision_Mdte( string DIVISIONES);
        ObservableCollection<Divisiones> GetListDivisiones_Mdte();
        #endregion
    }
}
