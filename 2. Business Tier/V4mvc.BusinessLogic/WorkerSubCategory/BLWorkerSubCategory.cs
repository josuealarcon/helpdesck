using System;
using System.Linq;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using Unity;

namespace V4mvc.BusinessLogic
{
    public partial class BLWorkerSubCategory : IBLWorkerSubCategory
    {

        #region [ Propiedades ]

        [Dependency]
        public IDAWorkerSubCategory Repository { get; set; }

        #endregion

        #region [ Constructores ]
        public BLWorkerSubCategory(IDAWorkerSubCategory x_container)
        { 
            Repository = x_container;
        }
        #endregion

        #region [ Consultas ]
        #endregion

        #region [ Metodos ]
        #endregion

    }
}
