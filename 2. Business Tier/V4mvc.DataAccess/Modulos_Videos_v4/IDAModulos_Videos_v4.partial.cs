
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial interface IDAModulos_Videos_v4
    {
        #region [ Consultas ]

        ObservableCollection<Modulos_Videos_v4> GetAllModulosVideosV4_VideosMdte();

        #endregion

        #region [ Metodos ]

        bool SaveModuloVideoV4_VideosMdte(ref Modulos_Videos_v4 modelo);

        #endregion
    }
}
	