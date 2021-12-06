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
	public partial class DADocsGrupos
	{
		#region [ Consultas ]

		public ObservableCollection<DocsGrupos> GetAllByDivision(string DIVISION)
		{
			try
			{
				var items = new ObservableCollection<DocsGrupos>();
				Instance.DAAsignarProcedure("V4MVC_DOCS_GRUPOS_SELECT");
				Instance.DAAgregarParametro("@DIVISION", DIVISION, SqlDbType.NVarChar, 9, ParameterDirection.Input);

				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						var item = new DocsGrupos();
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
