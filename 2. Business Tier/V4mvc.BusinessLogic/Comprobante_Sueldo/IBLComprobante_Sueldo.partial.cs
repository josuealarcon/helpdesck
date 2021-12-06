
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial interface IBLComprobante_Sueldo
    {
        #region [ Consultas ]
        ObservableCollection<Comprobante_Sueldo> GetAllComprobanteSueldo_ControlLaboralCtta(string IDEMPRESA);

        Comprobante_Sueldo GetOneComprobanteSueldo_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO);

        Comprobante_Sueldo GetOneComprobanteSueldo_v2_ControlLaboralCtta(string EMPRESA, string PERIODO);

        Comprobante_Sueldo GetOneComprobanteSueldo_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO);
        #endregion

        #region [ Metodos ]
        bool SaveComprobanteSueldo_ControlLaboralCtta(ref Archivos archivo, Comprobante_Sueldo model, out int RET_CODE);

        bool DelComprobanteSueldoDispFile_ControlLaboralCtta(ref Comprobante_Sueldo modelo);

        bool DelComprobanteSueldo_ControlLaboralCtta(ref Comprobante_Sueldo model);
        #endregion
    }
}
	