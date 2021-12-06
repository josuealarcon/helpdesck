using System;
using System.Data;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial class DAA036_CursoParametros
    {

        #region [ Consultas ]

        public A036_CursoParametros GetA036_CursoParametrosByParametro(int PARAMETRO)
        {
            try
            {
                A036_CursoParametros item = new A036_CursoParametros();
                Instance.DAAsignarProcedure("V4MVC_A036_CURSOPARAMETROS_BY_PARAMETRO_CTTA");
                Instance.DAAgregarParametro("@PARAMETRO", PARAMETRO, SqlDbType.Int, 4, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    if (reader.Read())
                    {
                        Loader.LoadEntity(reader, item);
                        item.Instance = InstanceEntity.Unchanged;
                    }
                    else
                    { return null; }
                }
                return item;
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

        #region [ Métodos ]

        #endregion

    }
}