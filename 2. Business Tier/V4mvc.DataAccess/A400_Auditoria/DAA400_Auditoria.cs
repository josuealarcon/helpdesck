
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
    public partial class DAA400_Auditoria : IDAA400_Auditoria
    {
        #region [ Propiedades ]
        public IUnityContainer containerService { get; set; }
        public LoaderEntity<A400_Auditoria> Loader { get; set; }
        public IDataAccessEnterprise Instance { get; set; }
        #endregion

        #region [ Constructores ]
        public DAA400_Auditoria(IDataAccessEnterprise container)
        {
            Loader = new LoaderEntity<A400_Auditoria>();
            A400_Auditoria item = new A400_Auditoria();
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
	