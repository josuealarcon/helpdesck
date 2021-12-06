
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial interface IDATimeline
    {
        #region [ Consultas ]
        ObservableCollection<Timeline> GetAllTimeline_ControlLaboralCtta();
        #endregion

        #region [ Metodos ]

        #endregion
    }
}
	