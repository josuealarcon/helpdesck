
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial interface IDAComprobante_Sueldo
    {
        #region [ Consultas ]
        ObservableCollection<Comprobante_Sueldo> GetAllComprobanteSueldo_ControlLaboralCtta(string IDEMPRESA);

        Comprobante_Sueldo GetOneComprobanteSueldo_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO);

        Comprobante_Sueldo GetOneComprobanteSueldo_v2_ControlLaboralCtta(string EMPRESA, string PERIODO);

        Comprobante_Sueldo GetOneComprobanteSueldo_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO);
        #endregion

        #region [ Metodos ]
        bool InsertComprobanteSueldo_ControlLaboralCtta(Comprobante_Sueldo model, out int RET_CODE);

        bool UpdateComprobanteSueldo_ControlLaboralCtta(Comprobante_Sueldo model, out int RET_CODE);

        bool UpdateComprobanteSueldo_v3_ControlLaboralCtta(Comprobante_Sueldo model);


        bool DelComprobanteSueldoDispFile_ControlLaboralCtta(ref Comprobante_Sueldo modelo);

        bool DelComprobanteSueldo_ControlLaboralCtta(ref Comprobante_Sueldo modelo);
        #endregion
    }
}
	