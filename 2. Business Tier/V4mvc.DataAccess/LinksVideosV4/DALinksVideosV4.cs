
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
    public partial class DALinksVideosV4 : IDALinksVideosV4
    {
        #region [ Propiedades ]
        public IUnityContainer containerService { get; set; }
        public LoaderEntity<LinksVideosV4> Loader { get; set; }
        public IDataAccessEnterprise Instance { get; set; }
        #endregion

        #region [ Constructores ]
        public DALinksVideosV4(IDataAccessEnterprise container)
        {
            Loader = new LoaderEntity<LinksVideosV4>();
            LinksVideosV4 item = new LinksVideosV4();
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
	