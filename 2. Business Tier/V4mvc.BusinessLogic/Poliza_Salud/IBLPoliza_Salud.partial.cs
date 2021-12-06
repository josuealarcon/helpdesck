
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial interface IBLPoliza_Salud
    {
        #region [ Consultas ]
        ObservableCollection<Poliza_Salud> GetAllPolizaSalud_ControlLaboralCtta(string IDEMPRESA);

        Poliza_Salud GetOnePolizaSalud_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO);

        Poliza_Salud GetOnePolizaSalud_v2_ControlLaboralCtta(string EMPRESA, string PERIODO);

        Poliza_Salud GetOnePolizaSalud_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO);
        #endregion

        #region [ Metodos ]
        bool SavePolizaSalud_ControlLaboralCtta(ref Archivos archivo, Poliza_Salud model, out int RET_CODE);

        bool DelPolizaSaludDispFile_ControlLaboralCtta(ref Poliza_Salud modelo);

        bool DelPolizaSalud_ControlLaboralCtta(ref Poliza_Salud modelo);
        #endregion
    }
}
	