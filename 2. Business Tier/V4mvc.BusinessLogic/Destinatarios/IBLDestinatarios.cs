using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial interface IBLDestinatarios
    {

        #region [ Consultas ]
        ObservableCollection<Destinatarios> GetAll(String MODULO);
        Destinatarios GetOne(String MODULO);
        #endregion

        #region [ Metodos ]
        Boolean Save(ref Destinatarios Item);
        Boolean Save(ref ObservableCollection<Destinatarios> Items);
        #endregion
    }
}
