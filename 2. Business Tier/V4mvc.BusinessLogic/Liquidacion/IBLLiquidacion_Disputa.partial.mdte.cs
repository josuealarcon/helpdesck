using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLLiquidacion
    {

        #region [ Consultas ]
        Liquidacion GetOneLiquidacionDisputa_Mdte(int ID_DISPUTA);
        bool SaveDocsDisputaLiquidacion(Liquidacion Liquidacion);
        Liquidacion GetOneLiquidacionDisputaSendAlert_Mdte(int ID_DISPUTA);
        ObservableCollection<Liquidacion> GetListLiquidacion_Mdte(ref Liquidacion liquidacionvalid);
        Liquidacion GetOneLiquidacionValidada_Mdte(string RUT, string FECHA, string EMPRESA);
        #endregion

        #region [ Metodos ]
        bool SaveLiquidacionValidada_Mdte(ref Liquidacion items);

        bool SaveLiquidacionRechazada_Mdte(ref Liquidacion items);
        #endregion

    }
}
