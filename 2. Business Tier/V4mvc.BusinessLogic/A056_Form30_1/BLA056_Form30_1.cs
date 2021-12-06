
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
    public partial class BLA056_Form30_1 : IBLA056_Form30_1
    {
        #region [ Propiedades ]
        public IUnityContainer ContainerService { get; set; }

        [Dependency]
        public IDAA056_Form30_1 Repository { get; set; }

        public IDAA056_Form30_1_Det RepositoryFormF301Det { get; set; }

        public IDAArchivos RepositoryArchivos { get; set; }

        #endregion

        #region [ Constructores ]
        public BLA056_Form30_1(IDAA056_Form30_1 x_container, IDAA056_Form30_1_Det y_container, IDAArchivos z_container)
        {
            Repository = x_container;
            RepositoryFormF301Det = y_container;
            RepositoryArchivos = z_container;
        }
        #endregion

        #region [ Consultas ]

        #endregion
    }
}
	