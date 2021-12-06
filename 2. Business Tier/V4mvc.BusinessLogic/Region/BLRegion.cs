
using System;
using System.Linq;
using System.Text;
using System.Transactions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Unity;

using V4mvc.Entities;
using V4mvc.DataAccess;

namespace V4mvc.BusinessLogic
{
    public partial class BLRegion : IBLRegion
    {
        #region [ Propiedades ]
        public IUnityContainer ContainerService { get; set; }

        [Dependency]
        public IDARegion Repository { get; set; }
        #endregion

        #region [ Constructores ]
        public BLRegion(IDARegion x_container)
        {
            Repository = x_container;
        }
        #endregion

        #region [ Consultas ]
        public ObservableCollection<Region> GetAll()
        {
            try
            {
                return this.Repository.GetAll();
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
	