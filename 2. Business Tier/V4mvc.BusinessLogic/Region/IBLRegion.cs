
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial interface IBLRegion
    {
        #region [ Consultas ]
        ObservableCollection<Region> GetAll();
        #endregion

        #region [ Metodos ]

        #endregion
    }
}
	