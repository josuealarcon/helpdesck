
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial interface IDA_F29
    {
        #region [ Consultas ]
        ObservableCollection<_F29> GetAllF29_ControlLaboralCtta(string IDEMPRESA);

        _F29 GetOneFormF29_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO);

        _F29 GetOneFormF29_v2_ControlLaboralCtta(string EMPRESA, string PERIODO);

        _F29 GetOneFormF29_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO);
        #endregion

        #region [ Metodos ]
        bool InsertFormF29_ControlLaboralCtta(_F29 model, out int RET_CODE);

        bool UpdateFormF29_ControlLaboralCtta(_F29 model, out int RET_CODE);

        bool UpdateFormF29_v3_ControlLaboralCtta(_F29 model);

        bool DelFormF29DispFile_ControlLaboralCtta(ref _F29 modelo);

        bool DelFormF29_ControlLaboralCtta(ref _F29 modelo);
        #endregion
    }
}
	