
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
    public partial class DAPoliza_MuerteNatural : IDAPoliza_MuerteNatural
    {
        #region [ Propiedades ]
        public IUnityContainer containerService { get; set; }
        public LoaderEntity<Poliza_MuerteNatural> Loader { get; set; }
        public IDataAccessEnterprise Instance { get; set; }
        #endregion

        #region [ Constructores ]
        public DAPoliza_MuerteNatural(IDataAccessEnterprise container)
        {
            Loader = new LoaderEntity<Poliza_MuerteNatural>();
            Poliza_MuerteNatural item = new Poliza_MuerteNatural();
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
	