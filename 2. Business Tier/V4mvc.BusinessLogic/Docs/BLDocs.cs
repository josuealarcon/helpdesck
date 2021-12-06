using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using Unity;

namespace V4mvc.BusinessLogic
{
    public partial class BLDocs : IBLDocs
    {

        #region [ Propiedades ]
        public IUnityContainer ContainerService { get; set; }

        [Dependency]
        public IDADocs Repository { get; set; }
        public IDADocs_Workers RepositoryDocsWorkers { get; set; }
        public IDADocs_Fec RepositoryDocsFec { get; set; }
        public IDAMutualidad RepositoryMutualidad { get; set; }
        public IDATab_TipoContrato RepositoryTabTipoContrato { get; set; }
        public IDADocs_Formato RepositoryDocsFormato { get; set; }
        public IDALicencias RepositoryLicencias { get; set; }
        public IDADocs_Fec_Workers RepositoryDocsFecWorkers { get; set; }
        public IDADocs_Disputa RepositoryDocsDisputa { get; set; }
        public IDAA054_MotivoFiniquito RepositoryMotivoFiniquito { get; set; }
        public IDAArchivos RepositoryArchivos { get; set; }
        public IDADocs_Workers_Mutual RepositoryDocsWorkersMutual { get; set; }
        public IDAWorkers_Licencias RepositoryWorkersLicencias { get; set; }
        public IDAWorkers_MotivoFiniquito RepositoryWorkersMotivoFiniquito { get; set; }
        public IDADocs_Workers_Data RepositoryDocsWorkersData { get; set; }
        public IDADocs_Transport RepositoryDocsTransport { get; set; }
        public IDAReqVal_Docs RepositoryReqValDocs { get; set; }
        public IDATab_Combustible RepositoryTabCombustible { get; set; }
        public IDATab_Traccion RepositoryTabTraccion { get; set; }
        public IDALotePasesFun RepositoryLotePasesFun { get; set; }
        public IDAOSTArbol RepositoryOSTArbol { get; set; }
        public IDADocs_OST2 RepositoryDocsOST2 { get; set; }
        public IDAV_Ctrl_Lab_Ultimo RepositoryVCtrlLabUltimo { get; set; }
        public IDADireccion RepositoryDireccion { get; set; }
        public IDAA024_Divisiones RepositoryA024Divisiones { get; set; }
        public IDAWorkersLocal RepositoryIDAWorkersLocal { get; set; }

        public IDAParametros_V2 RepositoryParametrosV2 { get; set; }
        #endregion

        #region [ Constructores ]

        public BLDocs(IDADocs x_container, IDADocs_Workers x_container1, IDADocs_Fec x_container2
                    , IDAMutualidad x_container3, IDATab_TipoContrato x_container4, IDADocs_Formato x_container5
                    , IDALicencias x_container6, IDADocs_Fec_Workers x_container7, IDADocs_Disputa x_container8
                    , IDAA054_MotivoFiniquito x_container9, IDAArchivos x_container10, IDADocs_Workers_Mutual x_container11
                    , IDAWorkers_Licencias x_container12, IDAWorkers_MotivoFiniquito x_container13, IDADocs_Workers_Data x_container14
                    , IDADocs_Transport x_container15, IDAReqVal_Docs x_container16 , IDATab_Combustible x_container17, IDATab_Traccion x_container18
                    , IDALotePasesFun x_container19, IDAOSTArbol x_container20, IDAV_Ctrl_Lab_Ultimo x_container21, IDADocs_OST2 x_container22
                    , IDADireccion x_container23, IDAA024_Divisiones x_container24 , IDAWorkersLocal xcontainer25, IDAParametros_V2 x_container26)
        {
            Repository = x_container;
            RepositoryDocsWorkers = x_container1;
            RepositoryDocsFec = x_container2;
            RepositoryMutualidad = x_container3;
            RepositoryTabTipoContrato = x_container4;
            RepositoryDocsFormato = x_container5;
            RepositoryLicencias = x_container6;
            RepositoryDocsFecWorkers = x_container7;
            RepositoryDocsDisputa = x_container8;
            RepositoryMotivoFiniquito = x_container9;
            RepositoryArchivos = x_container10;
            RepositoryDocsWorkersMutual = x_container11;
            RepositoryWorkersLicencias = x_container12;
            RepositoryWorkersMotivoFiniquito = x_container13;
            RepositoryDocsWorkersData = x_container14;
            RepositoryDocsTransport = x_container15;
            RepositoryReqValDocs = x_container16;
            RepositoryTabCombustible = x_container17;
            RepositoryTabTraccion = x_container18;
            RepositoryLotePasesFun = x_container19;
            RepositoryOSTArbol = x_container20;
            RepositoryVCtrlLabUltimo = x_container21;
            RepositoryDocsOST2 = x_container22;
            RepositoryDireccion = x_container23;
            RepositoryA024Divisiones = x_container24;
            RepositoryIDAWorkersLocal = xcontainer25;
            RepositoryParametrosV2 = x_container26;
        }
        #endregion

        #region [ Consultas ]
        public ObservableCollection<Docs> GetAll()
        {
            try
            {
                return this.Repository.GetAll();
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Docs GetOne(int ID_DOC)
        {
            try
            {
                return this.Repository.GetOne(ID_DOC);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public Boolean Save(ref Docs Item)
        {
            try
            {
                return this.Repository.Save(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Boolean Save(ref ObservableCollection<Docs> Items)
        {
            try
            {
                for (int i = 0; i < Items.Count; i++)
                {
                    var item = Items.ElementAt(i);
                    this.Repository.Save(ref item);
                }
                return true;
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

    }
}
