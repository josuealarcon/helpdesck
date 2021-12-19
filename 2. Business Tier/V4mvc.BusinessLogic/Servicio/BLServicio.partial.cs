using System;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial class BLServicio
	{

        #region [ Consultas ]

        public ObservableCollection<Servicio> GetAllServicioDivisionCtta(string DIVISION)
        {
            try
            {
                return this.Repository.GetAllServicioDivisionCtta(DIVISION);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<Servicio> GetListServiciosLocalesCasinoPermitidosAutorizaciones_Ctta()
        {
            try
            {
                return this.Repository.GetListServiciosLocalesCasinoPermitidosAutorizaciones_Ctta();
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
                return this.Repository.GetListSolicitudes_Usu(ref solicitud);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<Servicio> GetListSolicitudes_Adm(ref Solicitud solicitud)
        {
            try
            {
                return this.Repository.GetListSolicitudes_Adm(ref solicitud);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

    }
}
