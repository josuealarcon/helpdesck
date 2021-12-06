
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
    public partial class BLDocs_OST_Prevencionista : IBLDocs_OST_Prevencionista
    {
        #region [ Propiedades ]
        public IUnityContainer ContainerService { get; set; }

        [Dependency]
        public IDADocs_OST_Prevencionista Repository { get; set; }
        public IDAArchivos RepositoryArchivos { get; set; }
        #endregion

        #region [ Constructores ]
        public BLDocs_OST_Prevencionista(IDADocs_OST_Prevencionista x_container, IDAArchivos y_container)
        {
            Repository = x_container;
            RepositoryArchivos = y_container;
        }
        #endregion

        #region [ Consultas ]

        #endregion
    }
}
	