using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLLiquidacion_Disputa
	{

        #region [ Consultas ]
        ObservableCollection<Liquidacion_Disputa> GetListliquidacionDisputaDocsApoyo_Mdte(string RUT, int ID_DISPUTA, string FECHA);

        #endregion

        #region [ Metodos ]

        #endregion

    }
}
