using System;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using Unity;

namespace V4mvc.BusinessLogic
{
    public partial class BLDocs_Enterprise : IBLDocs_Enterprise
    {

        #region [ Propiedades ]

        public IUnityContainer ContainerService { get; set; }

        [Dependency]
        public IDADocs_Enterprise Repository { get; set; }

        #endregion

        #region [ Constructores ]

        public BLDocs_Enterprise(IDADocs_Enterprise x_container)
        { Repository = x_container; }

        #endregion

        #region [ Consultas ]

        public ObservableCollection<Docs_Enterprise> GetAll()
        {
            try
            {
                return this.Repository.GetAll();
            }
            catch (Exception ex)
            { throw ex; }
        }

        public Docs_Enterprise GetOne()
        {
            try
            {
                return this.Repository.GetOne();
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Métodos ]

        #endregion

    }
}
