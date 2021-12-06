
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial interface IDAV_Ctrl_Lab_Ultimo
    {
        #region [ Consultas ]
        ObservableCollection<V_Ctrl_Lab_Ultimo> GetControlesUltimos_ControlLaboralCtta(string IDEMPRESA, int ID_DOC);
        #endregion

        #region [ Metodos ]

        #endregion
    }
}
	