using System;
using System.Collections.ObjectModel;

using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial interface IDADocs_Workers
	{

        #region [ Consultas ]

        ObservableCollection<Docs_Workers> GetDocumentacionEstadoDocCtta(string RUT, String DIVCOD, int ID_DOC, int? COMUN, string COMUN_DIV, string EMPRESA);
        //ObservableCollection<Docs_Workers> GetDocumentoDependenciaValidado(string RUT, int ID_DOC, string DIVCOD, string COMUN_DIV, int? COMUN, string IDEMPRESA);
        ObservableCollection<Docs_Workers> GetDocWorkersDocumentosHistorico(string RUT, int ID_DOC, string DIVCOD, string COMUN_DIV, int? COMUN, string IDEMPRESA);
        Docs_Workers GetDocWorkersDisputa(string ID, string DIVCOD, int ID_DISPUTA);
        ObservableCollection<Docs_Workers> GetDocWorkersByRut_FuncionariosCtta(string RUT, string EMPRESA = null);
        ObservableCollection<Docs_Workers> GetDocWorkersByRut_FuncionariosCtta(string RUT, string DIVISION, string EMPRESA);
        ObservableCollection<Docs_Workers> GetInformeDocsPendientesFuncionariosCtta(ref Docs_Workers model);

        #endregion

        #region [ Metodos ]

        bool SaveDocsWorkersDocumento(ref Docs_Workers item);
        bool SaveDocWorkersDefaults_FuncionariosCtta(ref Docs_Workers item);

        bool DeleteFiniqDocWorker_FuncionariosCtta(string DEL_DOC_ID, string RUT, string USUARIO, string EMPRESA , string DIVCOD);

        #endregion

        #region [ func_getdatos V3 ]

        ObservableCollection<Docs_Workers> GetDocsWorkersByIdDocCtta(string RUT, string CAMPO_COMUNDIV, string DIVISION, int? ID_DOC, string DIV_COMUN, int? EMP_COMUN, string EMPRESA);

        #endregion

    }
}
