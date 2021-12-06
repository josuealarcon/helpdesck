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
	public partial class DACursoAmbitos
	{
		#region [ Consultas ]
		public ObservableCollection<CursoAmbitos> GetAllCursosAmbitos_Mdte()
        {
			try
			{
				var items = new ObservableCollection<CursoAmbitos>();
				Instance.DAAsignarProcedure("V4MVC_CURSO_AMBITOS_SELECT_CURSO_AMBITOS_MDTE");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						var item = new CursoAmbitos();
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
