
using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.EnterpriseLibrary.Data;
using V4mvc.Entities;
using Unity;

namespace V4mvc.DataAccess
{
    public partial class DAV_Ctrl_Lab_Ultimo : IDAV_Ctrl_Lab_Ultimo
    {
        #region [ Propiedades ]
        public IUnityContainer containerService { get; set; }
        public LoaderEntity<V_Ctrl_Lab_Ultimo> Loader { get; set; }
        public IDataAccessEnterprise Instance { get; set; }
        #endregion

        #region [ Constructores ]
        public DAV_Ctrl_Lab_Ultimo(IDataAccessEnterprise container)
        {
            Loader = new LoaderEntity<V_Ctrl_Lab_Ultimo>();
            V_Ctrl_Lab_Ultimo item = new V_Ctrl_Lab_Ultimo();
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
	