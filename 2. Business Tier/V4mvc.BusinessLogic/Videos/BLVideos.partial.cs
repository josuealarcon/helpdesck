
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;

using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLVideos
    {
        #region [ Consultas ]
        public Videos GetOneVideos(string ID)
        {
            try
            {
                return Repository.GetOneVideos(ID);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Videos GetOneVideos_VideosMdte(string ID)
        {
            try
            {
                return Repository.GetOneVideos_VideosMdte(ID);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Videos> GetAllVideos_VideosMdte()
        {
            try
            {
                return Repository.GetAllVideos_VideosMdte();
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        public bool SaveVideos_VideosMdte(ref Videos video)
        {
            try
            {
                return Repository.SaveVideos_VideosMdte(ref video);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
	