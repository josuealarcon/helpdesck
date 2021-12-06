
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
    public partial class BLColab_WC_SubMenu : IBLColab_WC_SubMenu
    {
        #region [ Propiedades ]
        public IUnityContainer ContainerService { get; set; }

        [Dependency]
        public IDAColab_WC_SubMenu Repository { get; set; }
        #endregion

        #region [ Constructores ]
        public BLColab_WC_SubMenu(IDAColab_WC_SubMenu x_container)
        {
            Repository = x_container;
        }
        #endregion

        #region [ Consultas ]

        #endregion
    }
}
	