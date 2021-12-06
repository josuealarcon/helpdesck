
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;

using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLLinksVideosV4
    {
        #region [ Consultas ]
        public ObservableCollection<LinksVideosV4> GetVideoLinks(string VIEW_KEY)
        {
            try
            {
                return Repository.GetVideoLinks(VIEW_KEY);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]

        #endregion
    }
}
	