
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial interface IBLLinksVideosV4
    {
        #region [ Consultas ]
        ObservableCollection<LinksVideosV4> GetVideoLinks(string VIEW_KEY);

        #endregion

        #region [ Metodos ]

        #endregion
    }
}
	