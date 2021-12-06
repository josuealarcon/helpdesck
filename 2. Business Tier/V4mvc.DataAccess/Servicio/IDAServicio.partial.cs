using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial interface IDAServicio
    {

        #region [ Consultas ]

        ObservableCollection<Servicio> GetAllServicioDivisionCtta(string DIVISION);
        ObservableCollection<Servicio> GetListServiciosLocalesCasinoPermitidosAutorizaciones_Ctta();

        #endregion

        #region [ Métodos ]

        #endregion

    }
}
