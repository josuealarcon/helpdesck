
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
    public partial class BLModulos_Videos_v4 : IBLModulos_Videos_v4
    {
        #region [ Propiedades ]
        public IUnityContainer ContainerService { get; set; }

        [Dependency]
        public IDAModulos_Videos_v4 Repository { get; set; }
        #endregion

        #region [ Constructores ]
        public BLModulos_Videos_v4(IDAModulos_Videos_v4 x_container)
        {
            Repository = x_container;
        }
        #endregion

        #region [ Consultas ]

        #endregion
    }
}
	