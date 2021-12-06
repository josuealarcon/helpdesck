using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using System.Data;

namespace V4mvc.DataAccess
{
    public partial interface IDACheck
    {

        #region [ Consultas ]
        ObservableCollection<Check> Get_Check_Combo(Check Item);
        #endregion

        #region [ Metodos ]
        #endregion
    }
}
