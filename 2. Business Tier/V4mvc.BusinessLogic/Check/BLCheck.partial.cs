using System;
using System.Collections.ObjectModel;
using System.Data;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLCheck
    {

        #region [ Consultas ]
        public ObservableCollection<Check> Get_Check_Combo(Check Item)
        {
            try
            {
                return Repository.Get_Check_Combo(Item);

            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

    }
}
