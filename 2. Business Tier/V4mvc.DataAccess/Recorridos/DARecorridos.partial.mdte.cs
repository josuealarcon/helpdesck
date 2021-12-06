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
	public partial class DARecorridos
	{
		#region [ Consultas ]
		
			public ObservableCollection<Recorridos> GetListRecorridos_Mdte()
		{
			try
			{
				var items = new ObservableCollection<Recorridos>();
				Instance.DAAsignarProcedure("V4MVC_RECORRIDOS_SELECT_MDTE");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						var item = new Recorridos();
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
