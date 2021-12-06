
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial interface IDALinksVideosV4
    {
        #region [ Consultas ]
        ObservableCollection<LinksVideosV4> GetVideoLinks(string VIEW_KEY);

        #endregion

        #region [ Metodos ]

        #endregion
    }
}
	