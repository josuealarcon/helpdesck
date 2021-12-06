using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.Entities;
using System.Data.SqlClient;

namespace V4mvc.DataAccess
{
    public partial interface IDADocs
    {

        #region [ Consultas ]

        ObservableCollection<Docs> GetAllDocumentacionDocsCtta(string DIVCOD, int? ID_DOC_OPCION);
        ObservableCollection<Docs> GetDocumentacionDocsObligatorioCtta(String DIVCOD, int ID_DOC);
        ObservableCollection<Docs> GetDocumentoDependencias(int ID_DOC, string DIVCOD, string RUT, string IDEMPRESA);
        ObservableCollection<Docs> GetDivisionesConduccionPase(string RUT, string IDEMPRESA);
        ObservableCollection<Docs> GetDocsDivision(string DIVCOD);
        ObservableCollection<Docs> GetDocsTipoPaseFecDivision(string DIVCOD);
        ObservableCollection<Docs> GetAllDocumentacionVehiculosCtta(string PATENTE, string DIVCOD);
        ObservableCollection<Docs> GetDocsDependenciasVehiculosCtta(string DIVCOD, string PATENTE, int ID_DOC, string IDEMPRESA);
        ObservableCollection<Docs> GetAllDocumentacionEmpresasCtta(string IDEMPRESA);
        Docs GetOneDocMixed(int ID_DOC);
        Docs GetOneDoc_v2_ControlLaboralCtta(int ID_TIPO_PROPIETARIO, int ID_DOC_OPCION, int ID_DOC);
        ObservableCollection<Docs> GetAllDocs_ContratOSTCtta(string NROOST, string MADRE, string IDEMPRESA, Int16 NIVEL);
        ObservableCollection<Docs> GetAllDocs_ControlLaboralCtta(ref Timeline parametros);
        Docs GetOneDoc_ControlLaboralCtta(int ID_DOC);
        Docs GetOneDocAprobacion_Subcontrato();

        #endregion

        #region [ Informes ]
        ObservableCollection<Docs> GetDocs_Grid_FichaVehiculoDetalle_InformeConsultaRapidaCtta(Docs request);
        ObservableCollection<Docs> GetDocs_Grid1_FichaFuncionarioDetalle_InformeFuncionariosCtta(Docs request);
        ObservableCollection<Docs> GetDocs_Grid2_FichaFuncionarioDetalle_InformeFuncionariosCtta(Docs request);

        int GetDocsScalarAccesoFaena_InformeFuncionariosCtta(string RUT, string IDEMPRESA, string TIPOPASE, string DIVCOD);
        #endregion

        #region [ Metodos ]
        bool SaveDocument_EmpresaCtta(ref Docs item, out bool result);
        bool DeleteDocument_EmpresaCtta(Guid ID, string ID_EMPRESA);
        #endregion

        #region [ func_getdatos V3 ]

        Docs GetDocsById_Doc(string ID_DOC);

        #endregion

    }
}
