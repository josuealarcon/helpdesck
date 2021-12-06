
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial interface IDAVideos
    {
        #region [ Consultas ]
        Videos GetOneVideos(string ID);

        Videos GetOneVideos_VideosMdte(string ID);

        ObservableCollection<Videos> GetAllVideos_VideosMdte();

        #endregion

        #region [ Metodos ]

        bool SaveVideos_VideosMdte(ref Videos video);

        #endregion
    }
}
	