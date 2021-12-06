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

        Docs_Workers GetDocWorkersDisputa(string ID, string DIVCOD,int ID_DISPUTA);
        ObservableCollection<Docs_Workers> GetDocWorkersByRut_FuncionariosCtta(string RUT);
        ObservableCollection<Docs_Workers> GetInformeDocsPendientesFuncionariosCtta(ref Docs_Workers model);

        #endregion

        #region [ Metodos ]
        bool DeleteFiniqDocWorker_FuncionariosCtta(string DEL_DOC_ID, string RUT, string USUARIO, string EMPRESA,string DIVCOD);
        #endregion

        #region [ func_getdatos V3 ]

        ObservableCollection<Docs_Workers> GetDocsWorkersByIdDocCtta(string RUT, string CAMPO_COMUNDIV, string DIVISION, int? ID_DOC, string DIV_COMUN, int? EMP_COMUN, string EMPRESA);

        #endregion

    }
}
