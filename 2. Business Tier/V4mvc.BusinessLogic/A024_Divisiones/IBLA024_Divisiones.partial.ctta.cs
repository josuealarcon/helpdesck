
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial interface IBLA024_Divisiones
    {
        #region [ Consultas ]
        ObservableCollection<A024_Divisiones> GetAllA024Divisiones_ControlLaboralCtta(string IDEMPRESA);
        #endregion

        #region [ Informes ]
        ObservableCollection<A024_Divisiones> GetAllA024Divisiones_InformeConsultaRapidaCtta(A024_Divisiones request);
        ObservableCollection<A024_Divisiones> GetA024Divisiones_GridFichaEmpresa_InformeConsultaRapidaCtta(A024_Divisiones request);
        ObservableCollection<A024_Divisiones> GetA024Divisiones_HistoricoBloqueoVehiculos_InformeConsultaRapidaCtta(A024_Divisiones request);
        #endregion
        #region [ Metodos ]

        #endregion

    }
}
	