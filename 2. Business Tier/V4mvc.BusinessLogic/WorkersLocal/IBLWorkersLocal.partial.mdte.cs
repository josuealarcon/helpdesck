using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using System.Data;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLWorkersLocal
	{

        #region [ Consultas ]

        ObservableCollection<WorkersLocal> GetWorkersLocal_PasesFuncionarios(String RUT, String DIVCOD);
        ObservableCollection<WorkersLocal> GetWorkersLocal_Archivos(String RUT, int ID_DOC);
        #endregion
        #region [ Metodos ]
        bool SaveCertificadoFuncionario(ref WorkersLocal modelo);
        #endregion
    }
}
