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
    public partial class BLTransport_Division : IBLTransport_Division
    {

        #region [ Propiedades ]
        public IUnityContainer ContainerService { get; set; }

        [Dependency]
        public IDATransport_Division Repository { get; set; }
        public IDATransport_Division_Pases RepositoryTransportDivisionPases { get; set; }
        public IDADocs RepositoryDocs { get; set; }
        public IDADocs_Transport RepositoryDocsTransport { get; set; }

        public IDADocs_Fec RepositoryDocsFec { get; set; }
        public IDADocs_Disputa_Trans RepositoryDocs_Disputa_Trans { get; set; }
        
        #endregion

        #region [ Constructores ]
        public BLTransport_Division(IDATransport_Division x_container
                                    , IDATransport_Division_Pases x_container1
                                    , IDADocs x_container2
                                    , IDADocs_Transport x_container3
                                    , IDADocs_Fec x_container4
                                    , IDADocs_Disputa_Trans x_container5)
        {
            Repository = x_container;
            RepositoryTransportDivisionPases = x_container1;
            RepositoryDocs = x_container2;
            RepositoryDocsTransport = x_container3;
            RepositoryDocsFec = x_container4;
            RepositoryDocs_Disputa_Trans = x_container5;
        }
        #endregion

        #region [ Consultas ]
        public ObservableCollection<Transport_Division> GetAll()
        {
            try
            {
                return this.Repository.GetAll();
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Transport_Division GetOne()
        {
            try
            {
                return null;// this.Repository.GetOne();
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Metodos ]
        public Boolean Save(ref Transport_Division Item)
        {
            try
            {
                return this.Repository.Save(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Boolean Save(ref ObservableCollection<Transport_Division> Items)
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
