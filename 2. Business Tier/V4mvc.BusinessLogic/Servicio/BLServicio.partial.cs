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

        #endregion

    }
}
