using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using System.Data;

namespace V4mvc.BusinessLogic
{
    public partial interface IBLCTRLing
    {

        #region [ Consultas ]
        ObservableCollection<CTRLing> Get_WC3_Vista_Ctrling_Informe_Ctrlaccesoresumen(CTRLing Item);
        ObservableCollection<CTRLing> Get_WC3_Vista_Ctrling_Informe_Ctrlaccesoresumen_diatotal(CTRLing Item);
        ObservableCollection<CTRLing> Get_WC3_Vista_Ctrling_Informe_CensoAccesos(CTRLing Item);
        DataSet Get_WC3_Vista_Ctrling_Informe_CensoAccesos_Detalle(CTRLing Item);
        ObservableCollection<CTRLing> Get_WC3_Vista_Ctrling_Informe_AccesosZonasControladas(CTRLing Item);
        ObservableCollection<CTRLing> Get_WC3_Vista_Ctrling_InformeAccesosZonasControladas_diatotal(CTRLing Item);
        ObservableCollection<CTRLing> Get_WC3_Vista_Ctrling_Informe_Ctrlaccesoresumen_diaresumen(CTRLing Item);
        #endregion
        #region [ Informes ]
        ObservableCollection<CTRLing> GetCTRLing_Grid_Movimiento_IngSal_MesActual_InformeFuncionariosCtta(CTRLing Item);
        ObservableCollection<CTRLing> Get_WC3_Vista_Ctrling_InformeAccesosZonasControladas_diaresumen(CTRLing Item);
        ObservableCollection<CTRLing> GetCTRLing_Grid_Movimiento_IngSal_MesActual_Detalle_InformeFuncionariosCtta(CTRLing Item);
        #endregion
        #region [ Metodos ]
        #endregion

    }
}

