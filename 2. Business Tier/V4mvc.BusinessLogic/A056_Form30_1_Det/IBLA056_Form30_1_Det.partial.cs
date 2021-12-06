
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial interface IBLA056_Form30_1_Det
    {
        #region [ Consultas ]
        ObservableCollection<A056_Form30_1_Det> GetFormF30Detalles_ControlLaboralCtta(string EMPRESA, string ID_CERTIFICADO);
        #endregion

        #region [ Metodos ]
        bool SaveFormF301Detail_ControlLaboralCtta(A056_Form30_1_Det model);
        #endregion
    }
}
	