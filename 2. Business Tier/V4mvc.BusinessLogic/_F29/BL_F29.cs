
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
    public partial class BL_F29 : IBL_F29
    {
        #region [ Propiedades ]
        public IUnityContainer ContainerService { get; set; }

        [Dependency]
        public IDA_F29 Repository { get; set; }

        public IDAArchivos RepositoryArchivos { get; set; }
        #endregion

        #region [ Constructores ]
        public BL_F29(IDA_F29 x_container, IDAArchivos y_container)
        {
            Repository = x_container;
            RepositoryArchivos = y_container;
        }
        #endregion

        #region [ Consultas ]

        #endregion
    }
}
	