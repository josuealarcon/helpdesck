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
        public ObservableCollection<Docs> GetExistencia_DOCS_Mdte()
        {
            try
            {
                return this.Repository.GetExistencia_DOCS_Mdte();
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Docs> GetAllDocsAcredFuncionario_Mdte(ref Docs modelo)
        {
            try
            {
                ObservableCollection<Docs> documentos = this.Repository.GetAllAcredFuncionarioDocs_Mdte(ref modelo);
                foreach (var documento in documentos)
                {
                    modelo.ID_DOC = documento.ID_DOC;
                    documento.LISTA_FECHAS = RepositoryDocsFec.GetDocumentacionFechasDocumentoMdte(ref modelo);
                }
                return documentos;
            }
            catch (Exception ex)
            { throw ex; }
        }


        public ObservableCollection<Docs> GetAllDocsAcredFuncionarioConduccion_Mdte(ref Docs modelo)
        {
            try
            {
                ObservableCollection<Docs> documentos = this.Repository.GetAllDocsAcredFuncionarioConduccion_Mdte(ref modelo);
                foreach (var documento in documentos)
                {
                    modelo.ID_DOC = documento.ID_DOC;
                    documento.LISTA_FECHAS = RepositoryDocsFec.GetDocumentacionFechasDocumentoMdte(ref modelo);
                }
                return documentos;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Docs> GetAllDocsAcredVehiculo_Mdte(ref Docs modelo)
        {
            try
            {
                ObservableCollection<Docs> documentos = this.Repository.GetAllDocsAcredVehiculo_Mdte(ref modelo);
                foreach (var documento in documentos)
                {
                    modelo.ID_DOC = documento.ID_DOC;
                    documento.LISTA_FECHAS = RepositoryDocsFec.GetDocumentacionFechasDocumentoVehiculosMdte(ref modelo);
                }
                return documentos;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public ObservableCollection<Docs> GetAllDocs_CertificacionMdte(string PATENTE, string DIVCOD, string TIPO_VEHICULO)
        {
            try
            {
                return this.Repository.GetAllDocs_CertificacionMdte(PATENTE, DIVCOD, TIPO_VEHICULO);
            }
            catch (Exception ex)
            { throw ex; }
        } 

        public ObservableCollection<Docs> GetAllDocs_CertificacionDocsMdte(ref Docs modelo)
        {
            try
            {
                var docs = this.Repository.GetAllDocs_CertificacionDocsMdte(ref modelo);
                foreach(var doc in docs)
                {
                    modelo.ID_DOC = doc.ID_DOC;
                    modelo.IDEMPRESA = doc.EMPRESA;
                    doc.LISTA_FECHAS = this.RepositoryDocsFec.GetAllDocsFec_CertificacionDocsMdte(ref modelo);
                }
                return docs;
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Docs GetListDocsDocumentos_Mdte(int ID_DOC, string PATENTE, string EMPRESA, string DIVCOD)
        {
            try
            {
                Docs docs = new Docs();
                docs.listNombreDocumento = Repository.GetOneDocsNombreArchivo_Mdte(ID_DOC, PATENTE, EMPRESA, DIVCOD);
                docs.listRequisitosValidacion = RepositoryReqValDocs.GetListRequisitos_Mdte(ID_DOC);
                docs.listEmpresasCertificadoras = RepositoryEmpresasCertificadoras.GetListEmpresasCertificadoras_Mdte();
                docs.ListDocsFecFechasNombres = RepositoryDocsFec.GetListDocsFecFechaNombre_Mdte(ID_DOC, PATENTE, EMPRESA, DIVCOD);
                docs.listDivisionesChecked = RepositoryA024_Divisiones.GetListDivisionesChecked_Mdte(DIVCOD);
                return docs;
            }
            catch (Exception ex)
            { throw ex; }

        }


        public ObservableCollection<Docs> GetAllCertificadosPases_Mdte(string RUT,  string DIVCOD, int NRO, int OPCION)
        {
            try
            {
                ObservableCollection<Docs> documentos = this.Repository.GetAllCertificadosPases_Mdte(RUT,DIVCOD, NRO, OPCION);
               
                foreach (var item in documentos)
                {                   
                    item.LISTA_EMPRESAS = RepositoryEnterprise.GetAllEnterprise_Mdte(RUT, DIVCOD);
                    foreach (var list in item.LISTA_EMPRESAS)
                    {
                        list.COMUN = item.COMUN;
                        ObservableCollection<Docs_Workers> docs_worker = RepositoryDocsWorkers.GetCertificadosPasesEstado_Mdte(RUT, DIVCOD, item.ID_DOC, item.COMUN, item.COMUN_DIV, list.IDEMPRESA);
                        if (docs_worker != null)
                        {
                            if (docs_worker.Count > 0)
                            {
                                item.ID = docs_worker.FirstOrDefault().ID;
                                item.VALIDADO = docs_worker.FirstOrDefault().VALIDADO;
                            }
                        }
                    }

                    

                    item.LISTA_FECHAS = RepositoryDocsFec.GetCertificadosPasesFechas_Mdte(RUT, DIVCOD,item.ID_DOC);   
                }
                return documentos;
            }
            catch (Exception ex)
            { throw ex; }
        }
        public ObservableCollection<Docs> GetListDocumentos_Mdte()
        {
            try
            {
                return this.Repository.GetListDocumentos_Mdte();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region [Metodos]

        public bool SaveDocsVehiculos_Mdte(ref Docs Docs)
        {
            try
            {
                using (TransactionScope tran = new TransactionScope())
                {
                    var archivo = Docs.ARCHIVO_CARGADO;
                    if (archivo.ARCHIVO != null)
                    {
                        this.RepositoryArchivos.SaveArchivo_Mdte(ref archivo);
                        Docs.ID = archivo.ID;
                    }

                    if (Docs != null)
                    {

                        foreach (var DIVISIONES    in Docs.listDivisionesChecked)
                        {
                            if (Docs.ListDocsFecFechasNombres != null)
                            {
                                foreach (var FECHAS in Docs.ListDocsFecFechasNombres)
                                {
                                    Docs_Fec_Workers docs_Fec_Workers = new Docs_Fec_Workers();
                                    docs_Fec_Workers.PATENTE = Docs.PATENTE;
                                    docs_Fec_Workers.ID_DOC_FEC = FECHAS.ID_DOC_FEC;
                                    docs_Fec_Workers.EMPRESA = Docs.EMPRESA;
                                    docs_Fec_Workers.DIVISION = Docs.DIVCOD;
                                    docs_Fec_Workers.FECHA = FECHAS.FECHA;
                                    docs_Fec_Workers.USUARIO = Docs.USUARIO;
                                    docs_Fec_Workers.ID_DOC = Docs.ID_DOC;
                                    docs_Fec_Workers.Instance = InstanceEntity.New;
                                    RepositoryDocsFecWorkers.SaveFechasDocs_Fec_Workers_Mdte(ref docs_Fec_Workers);

                                }
                            }
                             }

                        this.RepositoryDocsTransport.saveDocsTransport_Mdte(ref Docs);

                    }

                    tran.Complete();
                }

                return true;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion
    }
}

