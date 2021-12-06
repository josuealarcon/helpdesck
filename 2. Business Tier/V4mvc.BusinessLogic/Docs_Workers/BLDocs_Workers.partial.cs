using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.DataAccess;
using V4mvc.Entities;

namespace V4mvc.BusinessLogic
{
    public partial class BLDocs_Workers
    {

        #region [ Consultas ]

        public Docs_Workers GetDocWorkersDisputa(string ID, string DIVCOD, int ID_DISPUTA)
        {
            try
            {

                Docs_Workers docs_Worker = Repository.GetDocWorkersDisputa(ID, DIVCOD, ID_DISPUTA);
                docs_Worker.docs_Tipo_Rechazos = Repository_Docs_Tipo_Rechazo.GetDocsTipoRechazoDisputa(DIVCOD, docs_Worker.COMUN_DIV, ID);
                if (docs_Worker.ID_DOC == 1)
                    docs_Worker.docs_Workers_Data = Repository_Docs_Workers_Data.GetDocWorkersDataDisputa(ID);
                return docs_Worker;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Docs_Workers> GetDocWorkersByRut_FuncionariosCtta(string RUT)
        {
            try
            {
                return Repository.GetDocWorkersByRut_FuncionariosCtta(RUT);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Docs_Workers> GetInformeDocsPendientesFuncionariosCtta(ref Docs_Workers model)
        {
            try
            {
                return Repository.GetInformeDocsPendientesFuncionariosCtta(ref model);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]
        public bool DeleteFiniqDocWorker_FuncionariosCtta(string DEL_DOC_ID, string RUT, string USUARIO, string EMPRESA, string DIVCOD)
        {
            try
            {
                return this.Repository.DeleteFiniqDocWorker_FuncionariosCtta(DEL_DOC_ID, RUT, USUARIO, EMPRESA , DIVCOD);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ func_getdatos V3 ]

        public ObservableCollection<Docs_Workers> GetDocsWorkersByIdDocCtta(string RUT, string CAMPO_COMUNDIV, string DIVISION, int? ID_DOC, string DIV_COMUN, int? EMP_COMUN, string EMPRESA)
        {
            try
            {
                return Repository.GetDocsWorkersByIdDocCtta(RUT, CAMPO_COMUNDIV, DIVISION, ID_DOC, DIV_COMUN, EMP_COMUN, EMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
