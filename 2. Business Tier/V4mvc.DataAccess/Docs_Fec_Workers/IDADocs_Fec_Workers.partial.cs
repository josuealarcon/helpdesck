using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial interface IDADocs_Fec_Workers
    {

        #region [ Consultas ]
        Docs_Fec_Workers GetDocumentacionFuncionarioFechaCtta(string RUT, int ID_DOC_FEC, string DIVCOD, string IDEMPRESA);
        Docs_Fec_Workers GetDocumentacionFechaCtta(string RUT, int ID_DOC_FEC, string DIVCOD, string IDEMPRESA);
        Docs_Fec_Workers GetDocumentacionTransportFechaCtta(string RUT, int ID_DOC_FEC, string DIVCOD, string IDEMPRESA);

        string getFechaWLocal(string RUT, int ID_DOC_FEC, string EMPRESA);
        #endregion

        #region [ Metodos ]
        bool setFechaWLocal(string RUT, int ID_DOC_FEC, string DIV, string EMPRESA, string FECHA, string USUARIO);

        bool setFechaEmpresa(int ID_DOC_FEC, string EMPRESA, string FECHA);
        #endregion

        #region [ func_getdatos V3 ]

        Docs_Fec_Workers GetDocs_Fec_Workers_ByIdDocFec(string RUT, string DIVISION, string EMPRESA, int ID_DOCUMENTO, int ID_DOC_FEC, int? COMUN, int? VALIDADO_MAYOR_HOY, int? EMPRESACOMUN);

        #endregion

    }
}