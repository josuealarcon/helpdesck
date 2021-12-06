
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial interface IBLVideos
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
	