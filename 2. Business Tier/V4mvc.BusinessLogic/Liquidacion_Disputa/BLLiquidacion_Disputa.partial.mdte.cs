using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLLiquidacion_Disputa
	{

        #region [ Consultas ]
        public ObservableCollection<Liquidacion_Disputa> GetListliquidacionDisputaDocsApoyo_Mdte(string RUT, int ID_DISPUTA, string FECHA)
        {
            try
            {
                return this.Repository.GetListliquidacionDisputaDocsApoyo_Mdte(RUT, ID_DISPUTA, FECHA);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]

        #endregion

    }
}
