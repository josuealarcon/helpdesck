using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
	public partial interface IServiceProxyClient
	{

        #region [ Consultas ]

        ObservableCollection<Aprobacion_SubContratos> GetAllAprobacion_SubContratosPendientes(string IDEMPRESA);

        ObservableCollection<Aprobacion_SubContratos> GetAllAprobacion_SubContratosEnProceso(string IDEMPRESA);

        ObservableCollection<Aprobacion_SubContratos> GetAllAprobacion_SubContratosEnProcesadas(string IDEMPRESA);

        #endregion

        #region [ Metodos ]
        //Boolean SaveAprobacion_SubContratosEnProceso(ref Aprobacion_SubContratos Item);
        Boolean Save_Aprobacion_SubContratos( Aprobacion_SubContratos Item);
        #endregion

    }
}
