
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Unity;

using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
    public partial class ServiceProxyClient
    {

        #region [ Consultas ]
		
		public ObservableCollection<Modulos_Videos_v4> GetAllModulosVideosV4_VideosMdte()
        {
            try
            {
                return this.BL_Modulos_Videos_v4.GetAllModulosVideosV4_VideosMdte();
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
                return this.BL_Modulos_Videos_v4.SaveModuloVideoV4_VideosMdte(ref modelo);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
	