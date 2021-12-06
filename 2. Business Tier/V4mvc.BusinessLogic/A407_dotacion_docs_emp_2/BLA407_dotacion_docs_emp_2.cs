using System;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using Unity;

namespace V4mvc.BusinessLogic
{
    public partial class BLA407_dotacion_docs_emp_2 : IBLA407_dotacion_docs_emp_2
    {
        #region [ Propiedades ]
        public IUnityContainer ContainerService { get; set; }

        [Dependency]
        public IDAA407_dotacion_docs_emp_2 Repository { get; set; }
        #endregion

        #region [ Constructores ]
        public BLA407_dotacion_docs_emp_2(IDAA407_dotacion_docs_emp_2 x_container)
        { Repository = x_container; }
        #endregion

        #region [ Consultas ]

        #endregion

        #region [ Metodos ]
        #endregion

    }
}
