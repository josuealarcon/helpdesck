using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial interface IDADestinatarios
    {

        #region [ Consultas ]
        ObservableCollection<Destinatarios> GetAll(string MODULO);
        Destinatarios GetOne(String MODULO);
        #endregion

        #region
        bool Save(ref Destinatarios Item);
        #endregion
    }
}
