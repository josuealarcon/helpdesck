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

		#endregion

		#region [ Metodos ]
		public bool Save_A036_CURSOPROG_DOCS_mdte(ref A036_CursoProg_Docs item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("V4MVC_A036_CURSOPROG_DOCS_INSERT_MDTE");
							break;					
					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{						
						Instance.DAAgregarParametro("@CODIGO", item.CODIGO, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ID", item.ID, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);
						Instance.DAAgregarParametro("@BYTES", item.BYTES, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@NOMBRE", item.NOMBRE, SqlDbType.NVarChar, 200, ParameterDirection.Input);
					}

					if (Instance.DAExecuteNonQuery() > 0)
					{ return true; }
					else
					{ return false; }
				}
				else
				{ return true; }
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
