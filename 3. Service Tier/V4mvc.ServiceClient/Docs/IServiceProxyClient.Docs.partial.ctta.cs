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
        ObservableCollection<Docs> GetAllDGruposCtta();
        ObservableCollection<Docs> GetAllDocumentacionDocsCtta(string RUT, string EMPRESA, string DIVCOD, int? ID_DOC_OPCION);
        ObservableCollection<Docs> GetDocumentoDependencias(string RUT, string DIVCOD, int ID_DOC, string IDEMPRESA);
        Docs GetOneDocsAndHistorico(string RUT, string DIVCOD, int ID_DOC, string IDEMPRESA);
        ObservableCollection<Docs> GetDivisionesConduccionPase(string RUT, string IDEMPRESA);
        ObservableCollection<Docs> GetAllDocsCertifiacionInfo(string RUT, string EMPRESA, string DIVCOD, int? ID_DOC_OPCION);

        ObservableCollection<Docs> GetDocsDivision(string DIVCOD);
        ObservableCollection<Docs> GetDocsTipoPaseFecDivision(string DIVCOD);

        Docs GetDocumentoVehiculoCtta(string DIVCOD, string PATENTE, int ID_DOC, string IDEMPRESA);

        Docs GetOneDoc_v2_ControlLaboralCtta(int ID_TIPO_PROPIETARIO, int ID_DOC_OPCION, int ID_DOC);

        Docs GetOneDocMixed(int ID_DOC, string IDEMPRESA);

        ObservableCollection<Docs> GetDocumentosEmpresaCtta(string IDEMPRESA);

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

        bool SaveDocumentoCtta(Archivos archivo, string RUT, string IDEMPRESA, string USUARIO, ObservableCollection<Divisiones> divisiones, Docs documento);
        bool SaveDocument_EmpresaCtta(Archivos archivo, ref Docs item);

        bool DeleteDocument_EmpresaCtta(Guid ID, string ID_EMPRESA);

        bool SaveBatchDocs_ContratOSTCtta(ObservableCollection<Docs> docs);
        #endregion

    }
}
