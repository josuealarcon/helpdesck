
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
    public partial class DAA024_Divisiones : IDAA024_Divisiones
    {
        #region [ Propiedades ]
        public IUnityContainer containerService { get; set; }
        public LoaderEntity<A024_Divisiones> Loader { get; set; }
        public IDataAccessEnterprise Instance { get; set; }
        #endregion

        #region [ Constructores ]
        public DAA024_Divisiones(IDataAccessEnterprise container)
        {
            Loader = new LoaderEntity<A024_Divisiones>();
            A024_Divisiones item = new A024_Divisiones();
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
	