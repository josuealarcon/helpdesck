using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLSector
    {
        #region [ Consultas ]

        public ObservableCollection<Sector> GetAllSector_Mdte()
        {
            try
            {
                return this.Repository.GetAllSector_Mdte();
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        #endregion
    }
}
