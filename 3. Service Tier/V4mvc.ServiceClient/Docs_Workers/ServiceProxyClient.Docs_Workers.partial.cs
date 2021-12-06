using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.BusinessLogic;
using V4mvc.Entities;

namespace V4mvc
{
    public partial class ServiceProxyClient
    {

        #region [ Consultas ]

        public Docs_Workers GetDocWorkersDisputa(string ID, string DIVCOD, int ID_DISPUTA)
        {
            try
            {
                return this.BL_Docs_Workers.GetDocWorkersDisputa(ID, DIVCOD,  ID_DISPUTA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Docs_Workers> GetDocWorkersByRut_FuncionariosCtta(string RUT)
        {
            try
            {
                return this.BL_Docs_Workers.GetDocWorkersByRut_FuncionariosCtta(RUT);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Docs_Workers> GetInformeDocsPendientesFuncionariosCtta(ref Docs_Workers model)
        {
            try
            {
                return this.BL_Docs_Workers.GetInformeDocsPendientesFuncionariosCtta(ref model);
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
                return this.BL_Docs_Workers.DeleteFiniqDocWorker_FuncionariosCtta(DEL_DOC_ID, RUT, USUARIO, EMPRESA ,DIVCOD);
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
                return this.BL_Docs_Workers.GetDocsWorkersByIdDocCtta(RUT, CAMPO_COMUNDIV, DIVISION, ID_DOC, DIV_COMUN, EMP_COMUN, EMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
