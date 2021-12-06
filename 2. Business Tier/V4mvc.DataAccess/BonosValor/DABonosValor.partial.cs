using System;
using System.Data;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial class DABonosValor
	{

        #region [ Consultas ]

        public BonosValor GetBonosValorCtta(string TIPO_BONO, string PERIODO, string DIVISION)
        {
            try
            {
                BonosValor item = new BonosValor();
                Instance.DAAsignarProcedure("V4MVC_BONOSVALOR_SELECT_CTTA");
                Instance.DAAgregarParametro("@TIPO_BONO", TIPO_BONO, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@PERIODO", PERIODO, SqlDbType.NVarChar, 6, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", DIVISION, SqlDbType.NVarChar, 4, ParameterDirection.Input);
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

        #region [ Metodos ]

        #endregion

    }
}
