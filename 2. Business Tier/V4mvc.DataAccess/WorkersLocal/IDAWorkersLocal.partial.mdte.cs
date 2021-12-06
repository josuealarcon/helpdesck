using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using System.Data;

namespace V4mvc.DataAccess
{
	public partial interface IDAWorkersLocal
	{

        #region [ Consultas ]
        ObservableCollection<WorkersLocal> GetWorkersLocal_PasesFuncionarios(String EMPRESA, String DIVCOD);
        ObservableCollection<WorkersLocal> GetWorkersLocal_Archivos(String RUT, int ID_DOC);
        #endregion

        #region [ Informes ]

        #endregion
        #region [ Metodos ]
        bool SaveOneWorkersLocal_CertificacionMdte(Workers modelo);
        bool SaveCertificadoFuncionario(ref WorkersLocal modelo);
        #endregion

        #region [ func_getdatos V3 ]

        #endregion

    }
}
