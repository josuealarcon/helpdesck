
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
		public Videos GetOneVideos(string ID)
        {
            try
            {
                return this.BL_Videos.GetOneVideos(ID);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Videos GetOneVideos_VideosMdte(string ID)
        {
            try
            {
                return this.BL_Videos.GetOneVideos_VideosMdte(ID);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Videos> GetAllVideos_VideosMdte()
        {
            try
            {
                return this.BL_Videos.GetAllVideos_VideosMdte();
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
                return this.BL_Videos.SaveVideos_VideosMdte(ref video);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}
	