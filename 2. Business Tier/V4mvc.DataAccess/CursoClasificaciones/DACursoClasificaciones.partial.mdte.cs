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
	public partial class DACursoClasificaciones
	{
		#region [ Consultas ]
		public ObservableCollection<CursoClasificaciones> GetAllCursosClasificaciones_Mdte()
		{
			try
			{
				var items = new ObservableCollection<CursoClasificaciones>();
				Instance.DAAsignarProcedure("V4MVC_CURSO_CLASIFICACIONES_SELECT_CURSOSCALIFICACIONES_MDTE");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						var item = new CursoClasificaciones();
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
