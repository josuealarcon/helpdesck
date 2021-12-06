
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
    public partial class BLRemuneraciones_Propio : IBLRemuneraciones_Propio
    {
        #region [ Propiedades ]
        public IUnityContainer ContainerService { get; set; }

        [Dependency]
        public IDARemuneraciones_Propio Repository { get; set; }

        public IDAArchivos RepositoryArchivos { get; set; }
        #endregion

        #region [ Constructores ]
        public BLRemuneraciones_Propio(IDARemuneraciones_Propio x_container, IDAArchivos y_container)
        {
            Repository = x_container;
            RepositoryArchivos = y_container;
        }
        #endregion

        #region [ Consultas ]

        #endregion
    }
}
	