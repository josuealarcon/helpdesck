
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using System.Transactions;

namespace V4mvc.BusinessLogic
{
    public partial class BLDivAprobacionMedico
    {
        #region [ Consultas ]
        public DivAprobacionMedico GetOneDivAprobacionMedico_PasesCtta(string DIVCOD)
        {
            try
            {
                return this.Repository.GetOneDivAprobacionMedico_PasesCtta(DIVCOD);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]

        #endregion
    }
}
	