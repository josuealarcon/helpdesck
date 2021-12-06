
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
    public partial class DADocs_Disputa_CLaboral : IDADocs_Disputa_CLaboral
    {
        #region [ Propiedades ]
        public IUnityContainer containerService { get; set; }
        public LoaderEntity<Docs_Disputa_CLaboral> Loader { get; set; }
        public IDataAccessEnterprise Instance { get; set; }
        #endregion

        #region [ Constructores ]
        public DADocs_Disputa_CLaboral(IDataAccessEnterprise container)
        {
            Loader = new LoaderEntity<Docs_Disputa_CLaboral>();
            Docs_Disputa_CLaboral item = new Docs_Disputa_CLaboral();
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
	