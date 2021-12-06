
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
    public partial class BLA056_Form30 : IBLA056_Form30
    {
        #region [ Propiedades ]
        public IUnityContainer ContainerService { get; set; }

        [Dependency]
        public IDAA056_Form30 Repository { get; set; }
        public IDAArchivos RepositoryArchivos { get; set; }
        #endregion

        #region [ Constructores ]
        public BLA056_Form30(IDAA056_Form30 x_container, IDAArchivos y_container)
        {
            Repository = x_container;
            RepositoryArchivos = y_container;
        }
        #endregion

        #region [ Consultas ]

        #endregion
    }
}
	