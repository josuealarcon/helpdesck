
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial interface IDAA056_Form30_1_Det
    {
        #region [ Consultas ]
        ObservableCollection<A056_Form30_1_Det> GetFormF30Detalles_ControlLaboralCtta(string EMPRESA, string ID_CERTIFICADO);
        #endregion

        #region [ Metodos ]
        bool SaveFormF301Detail_ControlLaboralCtta(A056_Form30_1_Det model);
        #endregion
    }
}
	