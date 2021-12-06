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
	public partial class DAGerencias_General
	{
		#region [ Consultas ]
		public ObservableCollection<Gerencias_General> GetGGeneralPorDivision(Gerencias_General model)
		{
			try
			{
				var items = new ObservableCollection<Gerencias_General>();
				Instance.DAAsignarProcedure("V4MVC_GGENERAL_POR_DIVISION_SELECT");
				Instance.DAAgregarParametro("@IDSITIO", model.IDSITIO, SqlDbType.NVarChar, 200, ParameterDirection.Input);
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						var item = new Gerencias_General();
						Loader.LoadEntity(reader, item);
						item.Instance = InstanceEntity.Unchanged;
						items.Add(item);
					}
				}
				return items;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]

		#endregion
	}
}
