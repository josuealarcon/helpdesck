using System;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using Unity;

namespace V4mvc.BusinessLogic
{
    public partial class BLCasino : IBLCasino
    {

        #region [ Propiedades ]

        public IUnityContainer ContainerService { get; set; }

        [Dependency]
        public IDACasino Repository { get; set; }

        #endregion

        #region [ Constructores ]

        public BLCasino(IDACasino x_container)
        { Repository = x_container; }

        #endregion

        #region [ Consultas ]

        public ObservableCollection<Casino> GetAll()
        {
            try
            {
                return this.Repository.GetAll();
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Casino GetOne()
        {
            try
            {
                return this.Repository.GetOne();
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Métodos ]

        #endregion

    }
}
