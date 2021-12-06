using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using V4mvc.DataAccess;
using V4mvc.Entities;
using System.Threading.Tasks;
using System.Transactions;

namespace V4mvc.BusinessLogic
{
    public partial class BLDocs
    {

        #region [ Consultas ]

        public ObservableCollection<Docs> GetAllDocumentacionDocsCtta(string RUT, string EMPRESA, string DIVCOD, int? ID_DOC_OPCION)
        {
            try
            {
                ObservableCollection<Docs> documentos = new ObservableCollection<Docs>();
                var paseFuncionario = RepositoryIDAWorkersLocal.GetOneWorkersLocalPaseFuncionario_Ctta(RUT, DIVCOD, EMPRESA);
                if (paseFuncionario == null)
                {
                    documentos = new ObservableCollection<Docs>();
                    var DOC = new Docs();
                    DOC.RUT = RUT;
                    DOC.DIVCOD = DIVCOD;
                    DOC.ESTADO = "SI";
                    documentos.Add(DOC);
                    return documentos;

                }

                documentos = this.Repository.GetAllDocumentacionDocsCtta(DIVCOD, ID_DOC_OPCION);
                if (ID_DOC_OPCION == 1)
                {
                    LotePasesFun lotePaseFun = RepositoryLotePasesFun.GetLotePasesFun_Valida_Poseeconsuccionenfaena_FuncionariosCtta(RUT, DIVCOD);
                    if (lotePaseFun != null)
                    {
                        Docs poseeConsuccionEnFaena = new Docs();
                        poseeConsuccionEnFaena.VALIDADO = lotePaseFun.LICONDLT;
                        poseeConsuccionEnFaena.IDGRUPO = 0;
                        poseeConsuccionEnFaena.DIVCOD = DIVCOD;
                        poseeConsuccionEnFaena.COMUN = 1;
                        poseeConsuccionEnFaena.ID_DOC = -1;
                        poseeConsuccionEnFaena.SUBEDOC = "SI";
                        poseeConsuccionEnFaena.ORDEN = 1;
                        poseeConsuccionEnFaena.COMUN_DIV = "SI";
                        poseeConsuccionEnFaena.REDIRECCIONA = 0;
                        poseeConsuccionEnFaena.NOMBRE = "Posee Pase Conducción en Faena";
                        documentos.Insert(0, poseeConsuccionEnFaena);
                    }
                }
                foreach (var item in documentos)
                {

                    if (!string.IsNullOrEmpty(item.SUBEDOC))
                    {
                        if (item.SUBEDOC == "SI" && !string.IsNullOrEmpty(item.TIPOPASE))
                        {
                            item.OBLIGATORIO = "*";
                        }
                    }

                    ObservableCollection<Docs_Workers> docs_worker = RepositoryDocsWorkers.GetDocumentacionEstadoDocCtta(RUT, DIVCOD, item.ID_DOC, item.COMUN, item.COMUN_DIV, EMPRESA);
                    if (docs_worker != null)
                    {
                        if (docs_worker.Count > 0)
                        {
                            item.ID = docs_worker.FirstOrDefault().ID;
                            item.VALIDADO = docs_worker.FirstOrDefault().VALIDADO;
                            item.DISPUTA = RepositoryDocsDisputa.GetDocumentacionDisputaCtta(RUT, DIVCOD, item.ID_DOC, item.ID, item.COMUN_DIV, EMPRESA);
                        }
                    }

                    item.LISTA_FECHAS = RepositoryDocsFec.GetDocumentacionFechasDocumentoCtta(item.ID_DOC, DIVCOD, RUT, EMPRESA);

                    if (item.LISTA_FECHAS != null)
                    {
                        foreach (var fecha in item.LISTA_FECHAS)
                        {
                            if (!string.IsNullOrEmpty(fecha.TIPOPASE))
                            {
                                fecha.OBLIGATORIO = "*";
                            }

                            if (fecha.VALIDO_MAYOR_HOY > 0)
                            {
                                if (!string.IsNullOrEmpty(fecha.FECHA))
                                {
                                    if (Convert.ToInt32(fecha.FECHA) > Convert.ToInt32(fecha.FECHAHOY))
                                        fecha.ESTILO = "text-primary";
                                    else
                                        fecha.ESTILO = "text-danger";
                                }
                                else
                                {
                                    fecha.ESTILO = "text-danger";
                                }
                            }
                            else
                            {
                                fecha.ESTILO = "text-primary";
                            }
                        }
                    }
                    if (item.ID_DOC == 62)
                    {
                        item.LISTA_LICENCIAS_CADENA = string.Join(",", RepositoryLicencias.GetLicenciasConductores(RUT).Where(x => x.CHECKED == true).Select(x => x.DESCRIPCION).ToArray());
                    }
                    if (item.ID_DOC == 1)
                    {

                        item.LISTA_TIPOCONTRATO_CADENA = RepositoryTabTipoContrato.GetTiposContratoDocumentacionCtta(RUT, DIVCOD, EMPRESA).Where(x => x.CHECKED == true).Select(x => x.Descripcion).Distinct().FirstOrDefault();
                        if (item.LISTA_TIPOCONTRATO_CADENA == null)
                            item.LISTA_TIPOCONTRATO_CADENA = "";
                    }

                }
                return documentos;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Docs> GetDocumentoDependencias(string RUT, string DIVCOD, int ID_DOC, string IDEMPRESA)
        {
            try
            {
                ObservableCollection<Docs> documentos = this.Repository.GetDocumentoDependencias(ID_DOC, DIVCOD, RUT, IDEMPRESA);

                return documentos;

            }
            catch (Exception ex)
            { throw ex; }
        }

        public Docs GetOneDocMixed(int ID_DOC, string IDEMPRESA)
        {
            try
            {
                Docs item = this.Repository.GetOneDocMixed(ID_DOC);
                if (item.ID_DOC == 120)
                {
                    item.LIST_DIRECCION = RepositoryDireccion.GetAllCiudad();
                    item.LIST_A024DIVISIONES = RepositoryA024Divisiones.GetAllA024Divisiones_Ctta();
                }
                item.LISTA_FECHAS = RepositoryDocsFec.GetAllFechasDocsEmpresasCtta(IDEMPRESA, ID_DOC);
                return item;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Docs GetOneDoc_v2_ControlLaboralCtta(int ID_TIPO_PROPIETARIO, int ID_DOC_OPCION, int ID_DOC)
        {
            try
            {
                return Repository.GetOneDoc_v2_ControlLaboralCtta(ID_TIPO_PROPIETARIO, ID_DOC_OPCION, ID_DOC);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Docs GetOneDocsAndHistorico(string RUT, string DIVCOD, int ID_DOC, string IDEMPRESA)
        {
            try
            {
                Docs docs = this.Repository.GetOne(ID_DOC);
                if (docs != null)
                {
                    docs.parametros = RepositoryParametrosV2.GetParametros_SubidaDocsCtta(ID_DOC, DIVCOD, RUT, IDEMPRESA);

                    docs.LISTA_FECHAS = RepositoryDocsFec.GetDocumentacionFechasDocumentoCtta(ID_DOC, DIVCOD, RUT, IDEMPRESA);
                    if (docs.COMUN != null)
                        docs.LISTA_DOCS_WORKERS = RepositoryDocsWorkers.GetDocWorkersDocumentosHistorico(RUT, ID_DOC, DIVCOD, docs.COMUN_DIV, docs.COMUN, IDEMPRESA);
                    if (docs.SUBEDOC == "SI")
                    {
                        ObservableCollection<Docs_Formato> extensiones = RepositoryDocsFormato.GetDocsFormatDocumentacionCtta(ID_DOC);
                        docs.EXTENSIONES = extensiones != null ? string.Join(",", extensiones.Select(var => var.EXTENSION).ToList()).ToLower() : "";
                    }
                    switch (docs.ID_DOC)
                    {
                        case 1:
                            docs.LISTA_TIPOCONTRATO = RepositoryTabTipoContrato.GetTiposContratoDocumentacionCtta(RUT, DIVCOD, IDEMPRESA);
                            break;
                        case 3:
                            break;
                        case 53:

                            break;
                        case 18:
                            docs.LISTA_MOTIVOSFINIQUITOS = RepositoryMotivoFiniquito.GetA054_MotivoFiniquitosCertificacion(RUT, docs.ID_DOC, DIVCOD, IDEMPRESA);
                            break;
                        case 7:
                        case 81:
                            docs.LISTA_LICENCIAS = RepositoryLicencias.GetLicenciasConductores(RUT);
                            break;
                        case 62:
                            docs.LISTA_LICENCIAS = RepositoryLicencias.GetLicenciasConductores(RUT);
                            break;
                    }
                }
                return docs;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Docs> GetDivisionesConduccionPase(string RUT, string IDEMPRESA)
        {
            try
            {
                return Repository.GetDivisionesConduccionPase(RUT, IDEMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Docs> GetAllDocsCertifiacionInfo(string RUT, string EMPRESA, string DIVCOD, int? ID_DOC_OPCION)
        {
            try
            {
                ObservableCollection<Docs> documentos = this.Repository.GetAllDocumentacionDocsCtta(DIVCOD, ID_DOC_OPCION);
                foreach (var item in documentos)
                {
                    if (!string.IsNullOrEmpty(item.SUBEDOC))
                    {
                        if (item.SUBEDOC == "SI" && !string.IsNullOrEmpty(item.TIPOPASE))
                        {
                            item.OBLIGATORIO = "*";
                        }
                    }

                    ObservableCollection<Docs_Workers> docs_worker = RepositoryDocsWorkers.GetDocumentacionEstadoDocCtta(RUT, DIVCOD, item.ID_DOC, item.COMUN, item.COMUN_DIV, EMPRESA);
                    if (docs_worker != null)
                    {
                        if (docs_worker.Count > 0)
                        {
                            item.ID = docs_worker.FirstOrDefault().ID;
                            item.VALIDADO = docs_worker.FirstOrDefault().VALIDADO ?? "";
                        }
                    }

                    item.LISTA_FECHAS = RepositoryDocsFec.GetDocumentacionFechasDocumentoCtta(item.ID_DOC, DIVCOD, RUT, EMPRESA);
                    if (item.LISTA_FECHAS != null)
                    {
                        foreach (var fecha in item.LISTA_FECHAS)
                        {
                            if (!string.IsNullOrEmpty(fecha.TIPOPASE))
                            {
                                fecha.OBLIGATORIO = "*";
                            }

                            if (fecha.VALIDO_MAYOR_HOY > 0)
                            {
                                if (!string.IsNullOrEmpty(fecha.FECHA))
                                {
                                    if (Convert.ToInt32(fecha.FECHA) >= Convert.ToInt32(fecha.FECHAHOY))
                                        fecha.ESTILO = "text-primary";
                                    else
                                        fecha.ESTILO = "text-danger";
                                }
                                else
                                {
                                    fecha.ESTILO = "text-danger";
                                }
                            }
                            else
                            {
                                fecha.ESTILO = "text-primary";
                            }
                        }
                    }
                }
                return documentos;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Docs> GetDocsDivision(string DIVCOD)
        {
            try
            {
                return Repository.GetDocsDivision(DIVCOD);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Docs> GetDocsTipoPaseFecDivision(string DIVCOD)
        {
            try
            {
                return Repository.GetDocsTipoPaseFecDivision(DIVCOD);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Docs> GetAllDocs_ContratOSTCtta(string NROOST, string MADRE, string IDEMPRESA, Int16 NIVEL)
        {
            try
            {
                return Repository.GetAllDocs_ContratOSTCtta(NROOST, MADRE, IDEMPRESA, NIVEL);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Docs> GetAllDocs_ControlLaboralCtta(ref Timeline parametros)
        {
            try
            {
                ObservableCollection<Docs> docs = Repository.GetAllDocs_ControlLaboralCtta(ref parametros);
                foreach (var doc in docs)
                {
                    doc.LISTA_CONTROL_LAB_ULTIMO = RepositoryVCtrlLabUltimo.GetControlesUltimos_ControlLaboralCtta(parametros.IDEMPRESA, doc.ID_DOC);
                }
                return docs;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Docs GetOneDoc_ControlLaboralCtta(int ID_DOC)
        {
            try
            {
                return Repository.GetOneDoc_ControlLaboralCtta(ID_DOC);
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Docs GetOneDocAprobacion_Subcontrato()
        {
            try
            {
                return Repository.GetOneDocAprobacion_Subcontrato();
            }
            catch (Exception ex)
            { throw ex; }
        }

        #region [ Vehiculos Ctta]

        public Docs GetDocumentoVehiculoCtta(string DIVCOD, string PATENTE, int ID_DOC, string IDEMPRESA)
        {

            try
            {
                Docs docs = Repository.GetOne(ID_DOC);
                docs.LISTA_DEPENDENCIAS = Repository.GetDocsDependenciasVehiculosCtta(DIVCOD, PATENTE, ID_DOC, IDEMPRESA);
                docs.DIVCOD = DIVCOD;
                if (docs.LISTA_DEPENDENCIAS != null)
                {
                    if (docs.LISTA_DEPENDENCIAS.Count <= 0)
                    {
                        docs.LISTA_FECHAS = RepositoryDocsFec.GetDocsFecVehiculosCtta(ID_DOC, DIVCOD, PATENTE, IDEMPRESA);
                        if (docs.SUBEDOC == "SI")
                        {
                            ObservableCollection<Docs_Formato> extensiones = RepositoryDocsFormato.GetDocsFormatDocumentacionCtta(ID_DOC);
                            docs.EXTENSIONES = extensiones != null ? string.Join(",", extensiones.Select(var => var.EXTENSION).ToList()).ToLower() : "";
                        }
                        docs.LISTA_HISTORICO = RepositoryDocsTransport.GetDocsHistoricoVehiculosCtta(ID_DOC, PATENTE, DIVCOD);
                    }
                }

                return docs;
            }
            catch (Exception ex)
            { throw ex; }
        }


        #endregion

        #region [ Empresas Ctta]

        public ObservableCollection<Docs> GetDocumentosEmpresaCtta(string IDEMPRESA)
        {
            try
            {
                ObservableCollection<Docs> docs_enterprise = Repository.GetAllDocumentacionEmpresasCtta(IDEMPRESA);
                foreach (var item in docs_enterprise)
                {
                    item.LISTA_FECHAS = RepositoryDocsFec.GetAllFechasDocsEmpresasCtta(IDEMPRESA, item.ID_DOC);
                    foreach (var fecha in item.LISTA_FECHAS)
                    {
                        if (Convert.ToInt32(fecha.FECHA) >= Convert.ToInt32(fecha.FECHAHOY))
                            fecha.ESTILO = "color-green";
                        else
                            fecha.ESTILO = "color-red";
                    }
                }
                return docs_enterprise;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveDocument_EmpresaCtta(Archivos archivo, ref Docs item)
        {
            try
            {
                bool result = false;
                using (TransactionScope tran = new TransactionScope())
                {
                    RepositoryArchivos.Save(ref archivo);
                    item.ID = archivo.ID;
                    Repository.SaveDocument_EmpresaCtta(ref item, out result);
                    if (result)
                    {
                        if (item.LISTA_FECHAS != null)
                        {
                            foreach (var fec in item.LISTA_FECHAS)
                            {
                                RepositoryDocsFecWorkers.setFechaEmpresa(fec.ID_DOC_FEC, item.ID_EMPRESA, fec.FECHA);
                            }
                        }
                        tran.Complete();
                    }
                }
                return result;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DeleteDocument_EmpresaCtta(Guid ID, string ID_EMPRESA)
        {
            try
            {
                return Repository.DeleteDocument_EmpresaCtta(ID, ID_EMPRESA);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #endregion

        #region [ Informes ]
        public ObservableCollection<Docs> GetDocs_Grid_FichaVehiculoDetalle_InformeConsultaRapidaCtta(Docs request)
        {
            try
            {
                ObservableCollection<Docs> docs = Repository.GetDocs_Grid_FichaVehiculoDetalle_InformeConsultaRapidaCtta(request);
                if (docs != null)
                {
                    foreach (var doc in docs)
                    {
                        if (RepositoryDocsFecWorkers.GetDocumentacionFechaCtta(request.PATENTE, doc.ID_DOC_FEC, request.DIVCOD, request.IDEMPRESA) != null)
                        {
                            doc.FECHA = RepositoryDocsFecWorkers.GetDocumentacionFechaCtta(request.PATENTE, doc.ID_DOC_FEC, request.DIVCOD, request.IDEMPRESA).FECHA;
                        }

                    }
                }
                return docs;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Docs> GetDocs_Grid1_FichaFuncionarioDetalle_InformeFuncionariosCtta(Docs request)
        {
            try
            {
                ObservableCollection<Docs> docs = Repository.GetDocs_Grid1_FichaFuncionarioDetalle_InformeFuncionariosCtta(request);
                if (docs != null)
                {
                    foreach (var item in docs)
                    {
                        item.LISTA_FECHAS = RepositoryDocsFec.GetDocumentacionFechasDocumentoCtta(item.ID_DOC, request.DIVCOD, request.RUT, request.IDEMPRESA);
                        if (item.LISTA_FECHAS != null)
                        {
                            foreach (var fecha in item.LISTA_FECHAS)
                            {
                                if (!string.IsNullOrEmpty(fecha.TIPOPASE))
                                {
                                    fecha.OBLIGATORIO = "*";
                                }

                                if (fecha.VALIDO_MAYOR_HOY > 0)
                                {
                                    if (!string.IsNullOrEmpty(fecha.FECHA))
                                    {
                                        if (Convert.ToInt32(fecha.FECHA) >= Convert.ToInt32(fecha.FECHAHOY))
                                            fecha.ESTILO = "color-green";
                                        else
                                            fecha.ESTILO = "color-red";
                                    }
                                    else
                                    {
                                        fecha.ESTILO = "color-red";
                                    }
                                }
                                else
                                {
                                    fecha.ESTILO = "color-green";
                                }
                            }
                        }

                    }
                }
                return docs;
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<Docs> GetDocs_Grid2_FichaFuncionarioDetalle_InformeFuncionariosCtta(Docs request)
        {
            try
            {
                ObservableCollection<Docs> docs = Repository.GetDocs_Grid2_FichaFuncionarioDetalle_InformeFuncionariosCtta(request);
                if (docs != null)
                {
                    foreach (var item in docs)
                    {
                        if (!string.IsNullOrEmpty(item.SUBEDOC))
                        {
                            if (item.SUBEDOC == "SI" && !string.IsNullOrEmpty(item.TIPOPASE))
                            {
                                item.OBLIGATORIO = "*";
                            }
                        }
                        item.LISTA_FECHAS = RepositoryDocsFec.GetDocumentacionFechasDocumentoCtta(item.ID_DOC, request.DIVCOD, request.RUT, request.IDEMPRESA);
                        if (item.LISTA_FECHAS != null)
                        {
                            foreach (var fecha in item.LISTA_FECHAS)
                            {
                                if (!string.IsNullOrEmpty(fecha.TIPOPASE))
                                {
                                    fecha.OBLIGATORIO = "*";
                                }

                                if (fecha.VALIDO_MAYOR_HOY > 0)
                                {
                                    if (!string.IsNullOrEmpty(fecha.FECHA))
                                    {
                                        if (Convert.ToInt32(fecha.FECHA) >= Convert.ToInt32(fecha.FECHAHOY))
                                            fecha.ESTILO = "color-green";
                                        else
                                            fecha.ESTILO = "color-red";
                                    }
                                    else
                                    {
                                        fecha.ESTILO = "color-red";
                                    }
                                }
                                else
                                {
                                    fecha.ESTILO = "color-green";
                                }
                            }
                        }

                    }
                }
                return docs;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public int GetDocsScalarAccesoFaena_InformeFuncionariosCtta(string RUT, string IDEMPRESA, string TIPOPASE, string DIVCOD)
        {
            try
            {
                return Repository.GetDocsScalarAccesoFaena_InformeFuncionariosCtta(RUT, IDEMPRESA, TIPOPASE, DIVCOD);
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
                using (TransactionScope tran = new TransactionScope())
                {
                    if (archivo.ARCHIVO != null)
                        RepositoryArchivos.Save(ref archivo);
                    if (documento != null)
                    {
                        if (documento.LISTA_FECHAS != null)
                        {
                            foreach (var item in divisiones) 
                            {
                                foreach (var fecha in documento.LISTA_FECHAS)
                                {
                                    Docs_Fec_Workers docs_Fec_Workers = new Docs_Fec_Workers();
                                    docs_Fec_Workers.RUT = RUT;
                                    docs_Fec_Workers.ID_DOC_FEC = fecha.ID_DOC_FEC;
                                    docs_Fec_Workers.EMPRESA = IDEMPRESA;
                                    docs_Fec_Workers.DIVISION = item.DIVCOD;
                                    docs_Fec_Workers.FECHA = fecha.FECHA;
                                    docs_Fec_Workers.USUARIO = USUARIO;
                                    if (RepositoryDocsFecWorkers.GetDocumentacionFuncionarioFechaCtta(RUT, fecha.ID_DOC_FEC, item.DIVCOD, IDEMPRESA) != null)
                                        docs_Fec_Workers.Instance = InstanceEntity.Modify;
                                    else
                                        docs_Fec_Workers.Instance = InstanceEntity.New;
                                    RepositoryDocsFecWorkers.SaveDocsFecWorkersFuncionario(ref docs_Fec_Workers);
                                }
                            }
                        }

                        switch (documento.ID_DOC)
                        {
                            case 1:
                                if (documento.LISTA_TIPOCONTRATO != null)
                                {
                                    foreach (var tipo_contrato in documento.LISTA_TIPOCONTRATO)
                                    {
                                        Docs_Workers_Data docs_Workers_Data = new Docs_Workers_Data();
                                        docs_Workers_Data.ID_DOC = archivo.ID;
                                        docs_Workers_Data.SALARIO = documento.SALARIO;
                                        docs_Workers_Data.CARGO = documento.ID_CARGO;
                                        docs_Workers_Data.TURNO = documento.TURNO;
                                        docs_Workers_Data.OST = documento.OST;
                                        docs_Workers_Data.TIPOCONTRATO = tipo_contrato.TipoContrato;
                                        docs_Workers_Data.SUELDO_BASE = documento.SUELDO_BASE;
                                        docs_Workers_Data.Instance = InstanceEntity.New;
                                        RepositoryDocsWorkersData.Save(ref docs_Workers_Data);
                                    }
                                }
                                break;
                            case 3:
                            case 52:
                            case 53:
                                if (documento.LISTA_MUTUALIDAD != null)
                                {
                                    foreach (var mutual in documento.LISTA_MUTUALIDAD)
                                    {
                                        Docs_Workers_Mutual docs_workers_mutual = new Docs_Workers_Mutual();
                                        docs_workers_mutual.ID = archivo.ID;
                                        docs_workers_mutual.IDMUTUAL = mutual.IDMUTUAL;
                                        docs_workers_mutual.Instance = InstanceEntity.New;
                                        RepositoryDocsWorkersMutual.Save(ref docs_workers_mutual);
                                    }
                                }
                                break;
                            case 18:
                                if (documento.LISTA_MOTIVOSFINIQUITOS != null)
                                {
                                    /// FALTA

                                    foreach (var motivo_finiquito in documento.LISTA_MOTIVOSFINIQUITOS)
                                    {
                                        Workers_MotivoFiniquito workers_MotivoFiniquito = new Workers_MotivoFiniquito();
                                        workers_MotivoFiniquito.RUT = RUT;
                                        workers_MotivoFiniquito.EMPRESA = IDEMPRESA;
                                        workers_MotivoFiniquito.ID_DOC = documento.ID_DOC;
                                        workers_MotivoFiniquito.IDARCHIVO = archivo.ID;
                                        workers_MotivoFiniquito.USRREGISTRA = USUARIO;
                                        workers_MotivoFiniquito.USRMOD = USUARIO;
                                        workers_MotivoFiniquito.Instance = InstanceEntity.New;
                                        RepositoryWorkersMotivoFiniquito.Save(ref workers_MotivoFiniquito);
                                    }
                                }
                                break;
                            case 7:
                            case 81:
                                if (documento.LISTA_LICENCIAS != null)
                                {
                                    RepositoryLicencias.SaveWorkersLicenciasConductoresCtta(RUT, string.Join(",", documento.LISTA_LICENCIAS.Select(var => var.LICENCIAS)));
                                }
                                break;
                            case 62:
                                if (documento.LISTA_LICENCIAS != null)
                                {
                                    RepositoryLicencias.SaveWorkersLicenciasConductoresCtta(RUT, string.Join(",", documento.LISTA_LICENCIAS.Select(var => var.LICENCIAS)));
                                }
                                break;
                        }
                    }

                    if (divisiones != null)
                    {
                        foreach (var division in divisiones)
                        {
                            Docs_Workers docs_Workers = new Docs_Workers();
                            docs_Workers.RUT = RUT;
                            docs_Workers.EMPRESA = IDEMPRESA;
                            docs_Workers.ID_DOC = documento.ID_DOC;
                            docs_Workers.DIVISION = division.DIVCOD;
                            docs_Workers.USUARIO = USUARIO;
                            docs_Workers.ID = archivo.ID;
                            docs_Workers.VALIDADO = "NO";
                            docs_Workers.Instance = InstanceEntity.New;
                            RepositoryDocsWorkers.SaveDocsWorkersDocumento(ref docs_Workers);
                        }
                    }

                    tran.Complete();
                }
                return true;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveBatchDocs_ContratOSTCtta(ObservableCollection<Docs> docs)
        {
            try
            {
                bool result = true;
                using (TransactionScope tran = new TransactionScope())
                {
                    foreach (var doc in docs)
                    {
                        if (this.RepositoryOSTArbol.UpdateOSTArbol_ContratOSTCtta(doc.ID_DOC, doc.EEXT, doc.NROOST, doc.MADRE, doc.IDEMPRESA, doc.NIVEL))
                        {
                            Archivos archivo = doc.ADJUNTO;
                            if (RepositoryArchivos.Save(ref archivo))
                            {
                                this.RepositoryDocsOST2.InsertDocsOST2_ContratOSTCtta(archivo.ID, doc.ID_DOC, doc.NROOST, doc.MADRE, doc.IDEMPRESA, doc.NIVEL, doc.USUARIO);
                            }
                            else
                            {
                                result = false;
                                break;
                            }
                        }
                        else
                        {
                            result = false;
                            break;
                        }
                    }
                    tran.Complete();
                }
                return result;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}

