using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial class DALiquidacion_Disputa
	{
		#region [ Consultas ]

		public Liquidacion_Disputa GetLiquidacion_DisputaTop1(string RUT, string PERIODO,string EMPRESA)
		{
			try
			{
				Liquidacion_Disputa item = new Liquidacion_Disputa();
				Instance.DAAsignarProcedure("V4MVC_LIQUIDACION_DISPUTA_SELECT_TOP1");
				Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
				Instance.DAAgregarParametro("@PERIODO", PERIODO, SqlDbType.NVarChar, 6, ParameterDirection.Input);
				Instance.DAAgregarParametro("@EMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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
