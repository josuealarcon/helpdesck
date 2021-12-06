using System;
using System.Linq;
using System.Text;
using System.Transactions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using Unity;

namespace V4mvc.BusinessLogic
{
    public partial class BLCursoProg : IBLCursoProg
    {

        #region [ Propiedades ]
        
        public IUnityContainer ContainerService { get; set; }

        [Dependency]
        public IDACursoProg Repository { get; set; }
        public IDAParametros_V2 RepositoryParametrosV2 { get; set; }
        public IDAA027_Mandantes RepositoryA027_Mandantes { get; set; }
        public IDADocs RepositoryDocs { get; set; }
        public IDADocs_Workers RepositoryDocs_Workers { get; set; }
        public IDADocs_Fec RepositoryDocs_Fec { get; set; }
        public IDADocs_Fec_Workers RepositoryDocs_Fec_Workers { get; set; }
        public IDAEnterprise RepositoryEnterprise { get; set; }
        public IDAWorkers RepositoryWorkers { get; set; }
        public IDAWorkersLocal RepositoryWorkersLocal { get; set; }

        #endregion

        #region [ Constructores ]
        
        public BLCursoProg(
                            IDACursoProg x_container, 
                            IDAParametros_V2 x_container1, 
                            IDAA027_Mandantes x_container2,
                            IDADocs x_container3,
                            IDADocs_Workers x_container4,
                            IDADocs_Fec x_container5,
                            IDADocs_Fec_Workers x_container6,
                            IDAWorkers x_container7,
                            IDAWorkersLocal x_container8,
                            IDAEnterprise x_container9
                            )
        {
            Repository = x_container;
            RepositoryParametrosV2 = x_container1;
            RepositoryA027_Mandantes = x_container2;
            RepositoryDocs = x_container3;
            RepositoryDocs_Workers = x_container4;
            RepositoryDocs_Fec = x_container5;
            RepositoryDocs_Fec_Workers = x_container6;
            RepositoryWorkers = x_container7;
            RepositoryWorkersLocal = x_container8;
            RepositoryEnterprise = x_container9;
        }

        #endregion

        #region [ Consultas ]

        public ObservableCollection<CursoProg> GetAll()
        {
            try
            {
                return this.Repository.GetAll();
            }
            catch (Exception ex)
            { throw ex; }
        }

        public CursoProg GetOne(Int32 CODIGO)
        {
            try
            {
                return this.Repository.GetOne(CODIGO);
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Metodos ]
        public Boolean Save(ref CursoProg Item)
        {
            try
            {
                return this.Repository.Save(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Boolean Save(ref ObservableCollection<CursoProg> Items)
        {
            try
            {
                using (TransactionScope tran = new TransactionScope())
                {
                    for (int i = 0; i < Items.Count; i++)
                    {
                        var item = Items.ElementAt(i);
                        this.Repository.Save(ref item);
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
