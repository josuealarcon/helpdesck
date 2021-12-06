
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;

using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLTimeline
    {
        #region [ Consultas ]
        public ObservableCollection<Timeline> GetAllTimeline_ControlLaboralCtta()
        {
            try
            {
                return Repository.GetAllTimeline_ControlLaboralCtta();
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]

        #endregion
    }
}
	