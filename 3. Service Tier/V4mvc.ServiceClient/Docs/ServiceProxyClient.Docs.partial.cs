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

        public ObservableCollection<Docs> GetAllDocumentacionDocsCtta(string RUT, string EMPRESA, string DIVCOD, int? ID_DOC_OPCION)
        {
            try
            {
                return this.BL_Docs.GetAllDocumentacionDocsCtta(RUT, EMPRESA, DIVCOD, ID_DOC_OPCION);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Docs> GetDocumentoDependencias(string RUT, string DIVCOD, int ID_DOC, string IDEMPRESA)
        {
            try
            {
                return this.BL_Docs.GetDocumentoDependencias(RUT, DIVCOD, ID_DOC, IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Docs GetOneDocsAndHistorico(string RUT, string DIVCOD, int ID_DOC, string IDEMPRESA)
        {
            try
            {
                return this.BL_Docs.GetOneDocsAndHistorico(RUT, DIVCOD, ID_DOC, IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Docs> GetDivisionesConduccionPase(string RUT, string IDEMPRESA)
        {
            try
            {
                return this.BL_Docs.GetDivisionesConduccionPase(RUT, IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Docs> GetAllDocsCertifiacionInfo(string RUT, string EMPRESA, string DIVCOD, int? ID_DOC_OPCION)
        {
            try
            {
                return this.BL_Docs.GetAllDocsCertifiacionInfo(RUT, EMPRESA, DIVCOD, ID_DOC_OPCION);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Docs> GetDocsDivision(string DIVCOD)
        {
            try
            {
                return this.BL_Docs.GetDocsDivision(DIVCOD);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Docs> GetDocsTipoPaseFecDivision(string DIVCOD)
        {
            try
            {
                return this.BL_Docs.GetDocsTipoPaseFecDivision(DIVCOD);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Docs GetDocumentoVehiculoCtta(string DIVCOD, string PATENTE, int ID_DOC, string IDEMPRESA)
        {
            try
            {
                return this.BL_Docs.GetDocumentoVehiculoCtta(DIVCOD, PATENTE, ID_DOC, IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Docs GetOneDocMixed(int ID_DOC, string IDEMPRESA)
        {
            try
            {
                return this.BL_Docs.GetOneDocMixed(ID_DOC, IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Docs GetOneDoc_v2_ControlLaboralCtta(int ID_TIPO_PROPIETARIO, int ID_DOC_OPCION, int ID_DOC)
        {
            try
            {
                return this.BL_Docs.GetOneDoc_v2_ControlLaboralCtta(ID_TIPO_PROPIETARIO, ID_DOC_OPCION, ID_DOC);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Docs> GetDocumentosEmpresaCtta(string IDEMPRESA)
        {
            try
            {
                return this.BL_Docs.GetDocumentosEmpresaCtta(IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Docs> GetAllDocs_ContratOSTCtta(string NROOST, string MADRE, string IDEMPRESA, Int16 NIVEL)
        {
            try
            {
                return this.BL_Docs.GetAllDocs_ContratOSTCtta(NROOST, MADRE, IDEMPRESA, NIVEL);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Docs> GetAllDocs_ControlLaboralCtta(ref Timeline parametros)
        {
            try
            {
                return this.BL_Docs.GetAllDocs_ControlLaboralCtta(ref parametros);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Docs GetOneDoc_ControlLaboralCtta(int ID_DOC)
        {
            try
            {
                return this.BL_Docs.GetOneDoc_ControlLaboralCtta(ID_DOC);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Docs GetOneDocAprobacion_Subcontrato()
        {
            try
            {
                return this.BL_Docs.GetOneDocAprobacion_Subcontrato();
            }
            catch (Exception ex)
            { throw ex; }
        }

        

        #endregion

        #region [ Informes ]
        public ObservableCollection<Docs> GetDocs_Grid_FichaVehiculoDetalle_InformeConsultaRapidaCtta(Docs request)
        {
            try
            {
                return this.BL_Docs.GetDocs_Grid_FichaVehiculoDetalle_InformeConsultaRapidaCtta(request);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Docs> GetDocs_Grid1_FichaFuncionarioDetalle_InformeFuncionariosCtta(Docs request)
        {
            try
            {
                return this.BL_Docs.GetDocs_Grid1_FichaFuncionarioDetalle_InformeFuncionariosCtta(request);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Docs> GetDocs_Grid2_FichaFuncionarioDetalle_InformeFuncionariosCtta(Docs request)
        {
            try
            {
                return this.BL_Docs.GetDocs_Grid2_FichaFuncionarioDetalle_InformeFuncionariosCtta(request);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public int GetDocsScalarAccesoFaena_InformeFuncionariosCtta(string RUT, string IDEMPRESA, string TIPOPASE, string DIVCOD)
        {
            try
            {
                return this.BL_Docs.GetDocsScalarAccesoFaena_InformeFuncionariosCtta(RUT, IDEMPRESA, TIPOPASE, DIVCOD);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]

        public bool SaveDocumentoCtta(Archivos archivo, string RUT, string IDEMPRESA, string USUARIO, ObservableCollection<Divisiones> divisiones, Docs documento)
        {
            try
            {
                return this.BL_Docs.SaveDocumentoCtta(archivo, RUT, IDEMPRESA, USUARIO, divisiones, documento);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveDocument_EmpresaCtta(Archivos archivo, ref Docs item)
        {
            try
            {
                return this.BL_Docs.SaveDocument_EmpresaCtta(archivo, ref item);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DeleteDocument_EmpresaCtta(Guid ID, string ID_EMPRESA)
        {
            try
            {
                return this.BL_Docs.DeleteDocument_EmpresaCtta(ID, ID_EMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveBatchDocs_ContratOSTCtta(ObservableCollection<Docs> docs)
        {
            try
            {
                return this.BL_Docs.SaveBatchDocs_ContratOSTCtta(docs);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

    }
}
