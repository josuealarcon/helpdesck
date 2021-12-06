
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
    public partial class BLA056_Form30_1_Det : IBLA056_Form30_1_Det
    {
        #region [ Propiedades ]
        public IUnityContainer ContainerService { get; set; }

        [Dependency]
        public IDAA056_Form30_1_Det Repository { get; set; }
        #endregion

        #region [ Constructores ]
        public BLA056_Form30_1_Det(IDAA056_Form30_1_Det x_container)
        {
            Repository = x_container;
        }
        #endregion

        #region [ Consultas ]

        #endregion
    }
}
	