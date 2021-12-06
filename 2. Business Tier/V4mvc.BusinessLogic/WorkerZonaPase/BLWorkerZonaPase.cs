
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
    public partial class BLWorkerZonaPase : IBLWorkerZonaPase
    {
        #region [ Propiedades ]
        public IUnityContainer ContainerService { get; set; }

        [Dependency]
        public IDAWorkerZonaPase Repository { get; set; }
        #endregion

        #region [ Constructores ]
        public BLWorkerZonaPase(IDAWorkerZonaPase x_container)
        {
            Repository = x_container;
        }
        #endregion

        #region [ Consultas ]

        #endregion
    }
}
	