using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
	public partial interface IBLDocs_Workers
	{
        #region [ Consultas ]
        ObservableCollection<Docs_Workers> GetListDocsWorkerDocsApoyo_Mdte(string RUT, int ID_DISPUTA, int ID_DOC);
        ObservableCollection<Docs_Workers> GetListDocsWorkerDocsApoyoVehiculos_Mdte(string PATENTE, string ID_DISPUTA, string ID_DOC);
        ObservableCollection<Docs_Workers> GetListDocsWorkerFuncionarioDisputa_Mdte(string RUT, int ID_DOC, Guid ID, string DIVISION, int ID_DISPUTA);

        #endregion

        #region [ Metodos ]

        #endregion
    }
}
