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
    public partial class DAA027_Mandantes
    {

		#region [ Consultas ]

		public A027_Mandantes GetA027_MandantesEmpresa(string EMPRESA)
		{
			try
			{
				A027_Mandantes item = new A027_Mandantes();
				Instance.DAAsignarProcedure("V4MVC_A027_MANDANTES_SELECT_BY_EMPRESA");
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
