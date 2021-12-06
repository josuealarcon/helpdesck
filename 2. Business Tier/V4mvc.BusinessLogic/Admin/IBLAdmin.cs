using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial interface IBLAdmin
    {
        #region [ Consultas ]
        ObservableCollection<Admin> GetAll();
        Admin GetOne(String ADMRUT);
        #endregion

        #region [ Metodos ]
        Boolean Save(ref Admin Item);
        Boolean Save(ref ObservableCollection<Admin> Items);
        #endregion
    }
}
