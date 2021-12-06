using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using Unity;

namespace V4mvc.DataAccess
{
    public partial class DAA407_dotacion_docs_emp_2 : IDAA407_dotacion_docs_emp_2
    {
        #region [ Propiedades ]
        public IUnityContainer containerService { get; set; }
        public LoaderEntity<A407_dotacion_docs_emp_2> Loader { get; set; }
        public IDataAccessEnterprise Instance { get; set; }
        #endregion

        #region [ Constructores ]
        public DAA407_dotacion_docs_emp_2(IDataAccessEnterprise container)
        {
            //Instance = container;
            Loader = new LoaderEntity<A407_dotacion_docs_emp_2>();
            A407_dotacion_docs_emp_2 item = new A407_dotacion_docs_emp_2();
            Loader.EntityType = item.GetType();
            Instance = container;
        }
        #endregion
        #region [ Consultas ]
        #endregion
        #region [ Metodos ]
        #endregion
    }
}

