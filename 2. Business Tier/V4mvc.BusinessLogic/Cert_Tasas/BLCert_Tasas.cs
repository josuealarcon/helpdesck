
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
    public partial class BLCert_Tasas : IBLCert_Tasas
    {
        #region [ Propiedades ]
        public IUnityContainer ContainerService { get; set; }

        [Dependency]
        public IDACert_Tasas Repository { get; set; }
        public IDAArchivos RepositoryArchivos { get; set; }
        #endregion

        #region [ Constructores ]
        public BLCert_Tasas(IDACert_Tasas x_container, IDAArchivos y_container)
        {
            Repository = x_container;
            RepositoryArchivos = y_container;
        }
        #endregion

        #region [ Consultas ]

        #endregion
    }
}
	