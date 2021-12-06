using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.EnterpriseLibrary.Data;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial class DAA036_CursoProg_Docs
    {
		#region [ Consultas ]

		public A036_CursoProg_Docs GetA036CursoProgDocsCodigoCtta(int CODIGO)
		{
			try
			{
				A036_CursoProg_Docs item = new A036_CursoProg_Docs();
				Instance.DAAsignarProcedure("V4MVC_A036_CURSOPROG_DOCS_SELECT");
				Instance.DAAgregarParametro("@CODIGO", CODIGO, SqlDbType.Int, 4, ParameterDirection.Input);
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
