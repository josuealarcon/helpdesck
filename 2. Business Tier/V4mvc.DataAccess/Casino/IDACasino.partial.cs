using System.Collections.ObjectModel;
using V4mvc.Entities;
using System.Data;

namespace V4mvc.DataAccess
{
    public partial interface IDACasino
    {

        #region [ Consultas ]

        ObservableCollection<Casino> GetListCasino();
        ObservableCollection<Casino> GetCasinoFechasCtta(string FECHAINI, string FECHAFIN);
        DataSet GetAllCasinoServicioFecha(ref Casino model);
        ObservableCollection<Casino> GetAllCasinoServicioEmpresa(ref Casino model);
        ObservableCollection<Casino> GetCasinoServicioLocalCtta(ref Casino model);
        ObservableCollection<Casino> GetCasinoServicioLocalFechaCtta(ref Casino model);
        ObservableCollection<Casino> GetCasinoLocalesCtta(ref Casino model);
        ObservableCollection<Casino> GetCasinoSubtotalCtta(ref Casino model);
        ObservableCollection<Casino> GetCasinoTotalCtta(ref Casino model);
        ObservableCollection<Casino> GetCasinoDetalleCtta(ref Casino model);
        ObservableCollection<Casino> GetCasinoServicioCtta(ref Casino model);
        ObservableCollection<Casino> GetCasinoServicioDiaCtta(ref Casino model);

        #endregion

        #region [ Informes ]
        ObservableCollection<Casino> GetCasino_Grid_Consumo_Casino_MesActual_InformeFuncionariosCtta(Casino request);
        #endregion

        #region [ Métodos ]

        #endregion

    }
}
