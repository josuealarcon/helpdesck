
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
    public partial class BLA024_Divisiones : IBLA024_Divisiones
    {
        #region [ Propiedades ]
        public IUnityContainer ContainerService { get; set; }

        [Dependency]
        public IDAA024_Divisiones Repository { get; set; }
        public DAEnterprise IDAEnterprise_Repository { get; set; }
        #endregion

        #region [ Constructores ]
        public BLA024_Divisiones(IDAA024_Divisiones x_container, DAEnterprise b_container)
        {
            Repository = x_container;
            IDAEnterprise_Repository = b_container;
        }
        #endregion

        #region [ Consultas ]

        #endregion
    }
}
	