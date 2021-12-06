
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial interface IDAA056_Form30_1
    {
        #region [ Consultas ]
        ObservableCollection<A056_Form30_1> GetAllF301_ControlLaboralCtta(string IDEMPRESA);

        A056_Form30_1 GetOneFormF301_ControlLaboralCtta(int ID_DOC, string EMPRESA, int ID_CERTIFICADO);

        A056_Form30_1 GetOneFormF301_v2_ControlLaboralCtta(int ID_CERTIFICADO);

        A056_Form30_1 GetOneFormF301_v3_ControlLaboralCtta(Guid ID);

        A056_Form30_1 GetOneFormF301_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, int ID_CERTIFICADO);

        A056_Form30_1 GetOneFormF301_v4_ControlLaboralCtta(string PERIODO, string EMPRESA);

        A056_Form30_1 GetOneFormF301_v5_ControlLaboralCtta(string PERIODO, string EMPRESA);

        #endregion

        #region [ Metodos ]

        List<int> InsertFormF301_ControlLaboralCtta(A056_Form30_1 model, out int RET_CODE, out int ID_CERTIFICADO_);

        List<int> UpdateFormF301_ControlLaboralCtta(A056_Form30_1 model, out int RET_CODE, out int ID_CERTIFICADO_);

        bool UpdateFormF301_v3_ControlLaboralCtta(A056_Form30_1 model);
        bool DelFormF301_ControlLaboralCtta(ref A056_Form30_1 modelo);


        bool DelFormF301DispFile_ControlLaboralCtta(ref A056_Form30_1 modelo);
        #endregion
    }
}
	