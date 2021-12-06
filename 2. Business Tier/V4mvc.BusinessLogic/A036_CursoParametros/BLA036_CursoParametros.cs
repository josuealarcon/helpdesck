using System;
using System.Collections.ObjectModel;
using V4mvc.DataAccess;
using V4mvc.Entities;
using Unity;

namespace V4mvc.BusinessLogic
{
    public partial class BLA036_CursoParametros : IBLA036_CursoParametros
    {

        #region [ Propiedades ]

        public IUnityContainer ContainerService { get; set; }

        [Dependency]
        public IDAA036_CursoParametros Repository { get; set; }

        #endregion

        #region [ Constructores ]

        public BLA036_CursoParametros(IDAA036_CursoParametros x_container)
        { Repository = x_container; }

        #endregion

        #region [ Consultas ]

        public ObservableCollection<A036_CursoParametros> GetAll()
        {
            try
            {
                return this.Repository.GetAll();
            }
            catch (Exception ex)
            { throw ex; }
        }

        public A036_CursoParametros GetOne()
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
