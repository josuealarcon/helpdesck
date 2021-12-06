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

        public ObservableCollection<Dotacion_Servicios_Ost> GetAllServiciosOST_Mdte(string OST, string MANDANTE, string USUARIO)
        {
            try
            {
                return this.BL_Dotacion_Servicios_Ost.GetAllServiciosOST_Mdte(OST, MANDANTE, USUARIO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        public bool SaveDotacionServiciosOST_Mdte(ref Dotacion_Servicios_Ost Item)
        {
            try
            {
                return this.BL_Dotacion_Servicios_Ost.SaveDotacionServiciosOST_Mdte(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveDotacionServiciosOST_Mdte(ObservableCollection<Dotacion_Servicios_Ost> Items)
        {
            try
            {
                return this.BL_Dotacion_Servicios_Ost.SaveDotacionServiciosOST_Mdte(Items);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
