using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using Unity;

namespace V4mvc.DataAccess
{
    public partial class DACheck_Checkinginghead : IDACheck_Checkinginghead
    {
        #region [ Propiedades ]
        public IUnityContainer containerService { get; set; }
        public LoaderEntity<Check_Checkinginghead> Loader { get; set; }
        public IDataAccessEnterprise Instance { get; set; }
        #endregion

        #region [ Constructores ]
        public DACheck_Checkinginghead(IDataAccessEnterprise container)
        {
            //Instance = container;
            Loader = new LoaderEntity<Check_Checkinginghead>();
            Check_Checkinginghead item = new Check_Checkinginghead();
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

