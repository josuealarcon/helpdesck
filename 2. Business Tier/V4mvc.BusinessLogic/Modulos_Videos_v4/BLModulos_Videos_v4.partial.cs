
using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Transactions;

using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLModulos_Videos_v4
    {
        #region [ Consultas ]

        public ObservableCollection<Modulos_Videos_v4> GetAllModulosVideosV4_VideosMdte()
        {
            try
            {
                return Repository.GetAllModulosVideosV4_VideosMdte();
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        public bool SaveModuloVideoV4_VideosMdte(ref Modulos_Videos_v4 modelo)
        {
            try
            {
                return Repository.SaveModuloVideoV4_VideosMdte(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
	