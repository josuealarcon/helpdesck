using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDADocs_Workers
	{
        #region [ Consultas ]
        ObservableCollection<Docs_Workers> GetListDocsWorkerDocsApoyo_Mdte(string RUT, int ID_DISPUTA, int ID_DOC);
        ObservableCollection<Docs_Workers> GetListDocsWorkerDocsApoyoVehiculos_Mdte(string PATENTE, string ID_DISPUTA, string ID_DOC);
        ObservableCollection<Docs_Workers> GetListDocsWorkerFuncionarioDisputa_Mdte(string RUT, int ID_DOC, Guid ID, string DIVISION, int ID_DISPUTA);
        ObservableCollection<Docs_Workers> GetCertificadosPasesEstado_Mdte(string RUT, string DIVCOD, int ID_DOC, int? COMUN, string COMUN_DIV, string IDEMPRESA);

        #endregion

        #region [ Metodos ]

        #endregion
    }
}
