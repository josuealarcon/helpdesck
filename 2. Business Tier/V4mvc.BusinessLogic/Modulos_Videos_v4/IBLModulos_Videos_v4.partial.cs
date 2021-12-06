
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial interface IBLModulos_Videos_v4
    {
        #region [ Consultas ]

        ObservableCollection<Modulos_Videos_v4> GetAllModulosVideosV4_VideosMdte();

        #endregion

        #region [ Metodos ]

        bool SaveModuloVideoV4_VideosMdte(ref Modulos_Videos_v4 modelo);

        #endregion
    }
}
	