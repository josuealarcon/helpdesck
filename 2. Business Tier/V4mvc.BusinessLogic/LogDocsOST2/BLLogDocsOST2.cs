
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
    public partial class BLLogDocsOST2 : IBLLogDocsOST2
    {
        #region [ Propiedades ]
        public IUnityContainer ContainerService { get; set; }

        [Dependency]
        public IDALogDocsOST2 Repository { get; set; }
        #endregion

        #region [ Constructores ]
        public BLLogDocsOST2(IDALogDocsOST2 x_container)
        {
            Repository = x_container;
        }
        #endregion

        #region [ Consultas ]

        #endregion
    }
}
	