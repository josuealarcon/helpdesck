using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial interface IDAAdmin
    {
        #region [ Consultas ]
        ObservableCollection<Admin> GetAll();
        Admin GetOne(String ADMRUT);
        #endregion

        #region [ Metodos ]
        bool Save(ref Admin Item);
        #endregion
    }
}
