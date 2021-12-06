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
	public partial class DADotacion_Servicios_Ost
	{

		#region [ Consultas ]

		public ObservableCollection<Dotacion_Servicios_Ost> GetAllServiciosOST_Mdte(string OST, string MANDANTE, string USUARIO)
		{
			try
			{
				ObservableCollection<Dotacion_Servicios_Ost> items = new ObservableCollection<Dotacion_Servicios_Ost>();
				Dotacion_Servicios_Ost item = new Dotacion_Servicios_Ost();
				Instance.DAAsignarProcedure("V4MVC_SERVICIO_SELECT_OST_MDTE");
				Instance.DAAgregarParametro("@OST", OST, SqlDbType.NVarChar, 14, ParameterDirection.Input);
				Instance.DAAgregarParametro("@MANDANTE", MANDANTE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
				Instance.DAAgregarParametro("@USUARIO", USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Dotacion_Servicios_Ost();
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

		public bool SaveDotacionServiciosOST_Mdte(ref Dotacion_Servicios_Ost Item)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_DOTACION_SERVICIO_OST_SAVE_MDTE");
                Instance.DAAgregarParametro("@SERVICIO", Item.SERVICIO, SqlDbType.NVarChar, 12, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DIVISION", Item.DIVCOD, SqlDbType.NVarChar, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DOTACION", Item.DOTACION, SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@OST", Item.OST, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        #endregion

    }
}
