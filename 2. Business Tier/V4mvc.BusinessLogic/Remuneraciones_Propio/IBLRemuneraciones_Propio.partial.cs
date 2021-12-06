
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial interface IBLRemuneraciones_Propio
    {
        #region [ Consultas ]
        ObservableCollection<Remuneraciones_Propio> GetAllRemuneracionesPropio_ControlLaboralCtta(string IDEMPRESA);

        Remuneraciones_Propio GetOneRemPropio_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO, string DIVISION, string OST);

        Remuneraciones_Propio GetOneRemPropio_v2_ControlLaboralCtta(string EMPRESA, string PERIODO, string DIVISION, string OST);

        Remuneraciones_Propio GetOneRemPropio_v3_ControlLaboralCtta(int ID_DOC, string EMPRESA, string PERIODO, string DIVISION, string OST);
        #endregion

        #region [ Metodos ]

        bool SaveRemPropio_ControlLaboralCtta(ref Archivos archivo, Remuneraciones_Propio model, out int RET_CODE);
        bool DelRemPropio_ControlLaboralCtta(ref Remuneraciones_Propio modelo);

        bool DelRemuneracionPropioDispFile_ControlLaboralCtta(ref Remuneraciones_Propio modelo);
        #endregion
    }
}
	