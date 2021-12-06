
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
    public partial class BLDocs_Disputa_CLaboral : IBLDocs_Disputa_CLaboral
    {
        #region [ Propiedades ]
        public IUnityContainer ContainerService { get; set; }

        [Dependency]
        public IDADocs_Disputa_CLaboral Repository { get; set; }
        #endregion

        #region [ Constructores ]
        public BLDocs_Disputa_CLaboral(IDADocs_Disputa_CLaboral x_container)
        {
            Repository = x_container;
        }
        #endregion

        #region [ Consultas ]

        #endregion
    }
}
	