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
    public partial class BLLotePasesFun : IBLLotePasesFun
    {

        #region [ Propiedades ]
        public IUnityContainer ContainerService { get; set; }

        [Dependency]
        public IDALotePasesFun Repository { get; set; }

        public IDALocal IDALocal_Repository { get; set; }

        public IDAWorkerZonaPase IDAWorkerZonaPase_Repository { get; set; }

        public IDAWorkerZonaPaseHst IDAWorkerZonaPaseHst_Repository { get; set; }
        public IDALotePases RepositoryLotePases { get; set; }
        public DAEnterprise IDAEnterprise_Repository { get; set; }

        #endregion

        #region [ Constructores ]
        public BLLotePasesFun(IDALotePasesFun x_container, IDALotePases xy_container, IDALocal y_container, IDAWorkerZonaPase z_container, IDAWorkerZonaPaseHst a_container, DAEnterprise b_container)
        {
            Repository = x_container;
            IDALocal_Repository = y_container;
            RepositoryLotePases = xy_container;
            IDAWorkerZonaPase_Repository = z_container;
            IDAWorkerZonaPaseHst_Repository = a_container;
            IDAEnterprise_Repository = b_container;
        }
        #endregion

        #region [ Consultas ]
        public ObservableCollection<LotePasesFun> GetAll()
        {
            try
            {
                return this.Repository.GetAll();
            }
            catch (Exception ex)
            { throw ex; }
        }
        public LotePasesFun GetOne()
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
        public Boolean Save(ref LotePasesFun Item)
        {
            try
            {
                return this.Repository.Save(ref Item);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Boolean Save(ref ObservableCollection<LotePasesFun> Items)
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
