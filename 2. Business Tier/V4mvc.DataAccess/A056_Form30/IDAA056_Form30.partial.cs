
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial interface IDAA056_Form30
    {
        #region [ Consultas ]
        ObservableCollection<A056_Form30> GetAllFormF30_ControlLaboralCtta(string IDEMPRESA);

        A056_Form30 GetOneFormF30_ControlLaboralCtta(int ID_DOC, string EMPRESA, int ID_CERTIFICADO);

        A056_Form30 GetOneFormF30_v2_ControlLaboralCtta(int ID_CERTIFICADO);

        A056_Form30 GetOneFormF30_v3_ControlLaboralCtta(Guid ID);

        A056_Form30 GetOneFormF30_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, int CERTIFICADO_ID);
        #endregion

        #region [ Metodos ] 
        List<int> InsertFormF30_ControlLaboralCtta(A056_Form30 model, out int RET_CODE,out int ID_CERTIFICADO);

        List<int> UpdateFormF30_ControlLaboralCtta(A056_Form30 model, out int RET_CODE, out int ID_CERTIFICADO);

        bool UpdateFormF30_v3_ControlLaboralCtta(A056_Form30 model);

        bool DelFormF30DispFile_ControlLaboralCtta(ref A056_Form30 modelo);

        bool DelFormF30_ControlLaboralCtta(ref A056_Form30 modelo);
        #endregion
    }
}
	