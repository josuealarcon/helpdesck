using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using System.Data;

namespace V4mvc.BusinessLogic
{
    public partial interface IBLCheck
    {

        #region [ Consultas ]
        ObservableCollection<Check> Get_Check_Combo(Check Item);
        #endregion

        #region [ Metodos ]
        #endregion

    }
}

