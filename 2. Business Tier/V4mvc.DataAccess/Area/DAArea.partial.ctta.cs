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
	public partial class DAArea
	{
		#region [ Consultas ]
		public ObservableCollection<Area> GetAreasCheckedByPatente_VehiculosDatos(string patente)
		{
			try
			{
				var items = new ObservableCollection<Area>();
				Instance.DAAsignarProcedure("V4MVC_AREA_SELECT_VEHICULOS_DATOS_CTTA");
				Instance.DAAgregarParametro("@PATENTE", patente, SqlDbType.NVarChar, 20, ParameterDirection.Input);
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						var item = new Area();
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
