using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using Unity;

namespace V4mvc.DataAccess
{
    public partial class DACheck : IDACheck
    {
        #region [ Propiedades ]
        public IUnityContainer containerService { get; set; }
        public LoaderEntity<Check> Loader { get; set; }
        public IDataAccessEnterprise Instance { get; set; }
        #endregion

        #region [ Constructores ]
        public DACheck(IDataAccessEnterprise container)
        {
            //Instance = container;
            Loader = new LoaderEntity<Check>();
            Check item = new Check();
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

