using System;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using Unity;

namespace V4mvc.BusinessLogic
{
    public partial class BLCheck : IBLCheck
    {
        #region [ Propiedades ]
        public IUnityContainer ContainerService { get; set; }

        [Dependency]
        public IDACheck Repository { get; set; }
        #endregion

        #region [ Constructores ]
        public BLCheck(IDACheck x_container)
        { Repository = x_container; }
        #endregion

        #region [ Consultas ]

        #endregion

        #region [ Metodos ]
        #endregion

    }
}
