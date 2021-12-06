using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDAAprobacion_SubContratos
	{

        #region [ Consultas ]

        ObservableCollection<Aprobacion_SubContratos> GetAllAprobacion_SubContratosPendientes(string IDEMPRESA);

        ObservableCollection<Aprobacion_SubContratos> GetAllAprobacion_SubContratosEnProceso(string IDEMPRESA);
        ObservableCollection<Aprobacion_SubContratos> GetAllAprobacion_SubContratosEnProcesadas(string IDEMPRESA);
        #endregion

        #region [ Metodos ]
        bool Save_Aprobacion_SubContratos( Aprobacion_SubContratos item);
        #endregion
    }
}
