
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial interface IBLA056_Form30_1
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

        bool SaveFormF301_ControlLaboralCtta(ref Archivos archivo, A056_Form30_1 model, out int RET_CODE);

        bool DelFormF301_ControlLaboralCtta(ref A056_Form30_1 modelo);

        bool DelFormF301DispFile_ControlLaboralCtta(ref A056_Form30_1 modelo);
        #endregion
    }
}
	