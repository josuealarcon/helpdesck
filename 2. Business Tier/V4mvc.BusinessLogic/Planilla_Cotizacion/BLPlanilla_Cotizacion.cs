
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
    public partial class BLPlanilla_Cotizacion : IBLPlanilla_Cotizacion
    {
        #region [ Propiedades ]
        public IUnityContainer ContainerService { get; set; }

        [Dependency]
        public IDAPlanilla_Cotizacion Repository { get; set; }
        public IDAArchivos RepositoryArchivos { get; set; }

        #endregion

        #region [ Constructores ]
        public BLPlanilla_Cotizacion(IDAPlanilla_Cotizacion x_container, IDAArchivos y_container)
        {
            Repository = x_container;
            RepositoryArchivos = y_container;
        }
        #endregion

        #region [ Consultas ]

        #endregion
    }
}
	