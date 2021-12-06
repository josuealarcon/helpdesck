using System;
using System.Collections.ObjectModel;
using V4mvc.BusinessLogic;
using V4mvc.Entities;
using Unity;

namespace V4mvc
{
    public partial class ServiceProxyClient : IServiceProxyClient
    {

        #region [ Propiedades ]

        [Dependency]
        public IBLA036_CursoParametros BL_A036_CursoParametros { get; set; }

        #endregion

        #region [ Constructor]

        public ServiceProxyClient(IBLA036_CursoParametros BL_A036_CursoParametros)
        {
            this.BL_A036_CursoParametros = BL_A036_CursoParametros;
        }

        #endregion

        #region [ Consultas ]

        public ObservableCollection<A036_CursoParametros> GetAllA036_CursoParametros()
        {
            try
            {
                return this.BL_A036_CursoParametros.GetAll();
            }
            catch (Exception ex)
            { throw ex; }
        }

        public A036_CursoParametros GetOneA036_CursoParametros()
        {
            try
            {
                return this.BL_A036_CursoParametros.GetOne();
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Métodos ]

        #endregion

    }
}