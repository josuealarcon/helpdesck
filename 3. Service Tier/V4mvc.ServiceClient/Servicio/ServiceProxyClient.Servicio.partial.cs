using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc
{
    public partial class ServiceProxyClient
    {

        #region [ Consultas ]

        public ObservableCollection<Servicio> GetAllServicioDivisionCtta(string DIVISION)
        {
            try
            {
                return this.BL_Servicio.GetAllServicioDivisionCtta(DIVISION);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<Servicio> GetListServiciosLocalesCasinoPermitidosAutorizaciones_Ctta()
        {
            try
            {
                return this.BL_Servicio.GetListServiciosLocalesCasinoPermitidosAutorizaciones_Ctta();
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Métodos ]
        public ObservableCollection<Servicio> GetListSolicitudes_Usu(ref Solicitud solicitud)
        {
            try
            {
                return this.BL_Servicio.GetListSolicitudes_Usu(ref solicitud);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<Servicio> GetListSolicitudes_Adm(ref Solicitud solicitud)
        {
            try
            {
                return this.BL_Servicio.GetListSolicitudes_Adm(ref solicitud);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

    }
}
