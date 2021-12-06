
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;

using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLRegion
    {
        #region [ Consultas ]
        public ObservableCollection<Region> GetAllRegion_ControlLaboralCtta(string PAIS)
        {
            try
            {
                return Repository.GetAllRegion_ControlLaboralCtta(PAIS);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]

        #endregion
    }
}
	