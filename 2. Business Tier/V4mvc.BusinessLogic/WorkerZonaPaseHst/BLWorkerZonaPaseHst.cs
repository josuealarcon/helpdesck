
using System;
using System.Linq;
using System.Text;
using System.Transactions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using Unity;
using V4mvc.DataAccess;

namespace V4mvc.BusinessLogic
{
    public partial class BLWorkerZonaPaseHst : IBLWorkerZonaPaseHst
    {
        #region [ Propiedades ]
        public IUnityContainer ContainerService { get; set; }

        [Dependency]
        public IDAWorkerZonaPaseHst Repository { get; set; }
        #endregion

        #region [ Constructores ]
        public BLWorkerZonaPaseHst(IDAWorkerZonaPaseHst x_container)
        {
            Repository = x_container;
        }
        #endregion

        #region [ Consultas ]

        #endregion
    }
}
	