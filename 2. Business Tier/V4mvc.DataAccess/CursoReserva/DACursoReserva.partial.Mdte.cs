using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public partial class DACursoReserva
    {
        #region [ Consultas ]
        public ObservableCollection<CursoReserva> GetList_A142_RESERVAS_Mdte(int CODIGO)
        {
            try
            {
                ObservableCollection<CursoReserva> items = new ObservableCollection<CursoReserva>();
                CursoReserva item = new CursoReserva();
                Instance.DAAsignarProcedure("V4MVC_A142_RESERVAS_SELECT_RESERVAS_MDTE");
                Instance.DAAgregarParametro("@CODIGO", CODIGO, SqlDbType.Int, 4, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new CursoReserva();
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
		public ObservableCollection<CursoReserva> GetList_A142_RESULTADOS_Mdte(int CODIGO)
		{
			try
			{
				ObservableCollection<CursoReserva> items = new ObservableCollection<CursoReserva>();
				CursoReserva item = new CursoReserva();
				Instance.DAAsignarProcedure("V4MVC_A142_CURSOS_SELECT_CURSOSRESULTADOS_MDTE");
				Instance.DAAgregarParametro("@CODIGO", CODIGO, SqlDbType.Int, 4, ParameterDirection.Input);
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new CursoReserva();
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

		public string ValidarReserva_Mdte(int CURSO, string RUT, int CODIGO)
		{
			try
			{
				string resultado = "";
				CursoReserva item = new CursoReserva();
				Instance.DAAsignarProcedure("V4MVC_A036_CURSORESERVA_SELECT_VALIDARRESERVA_MDTE");
				Instance.DAAgregarParametro("@CURSO", CURSO, SqlDbType.Int, 4, ParameterDirection.Input);
				Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 20, ParameterDirection.Input);
				Instance.DAAgregarParametro("@CODIGO", CODIGO, SqlDbType.Int, 4, ParameterDirection.Input);
				//var resultado = (int)Instance.DAExecuteScalar();
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						resultado = reader["RESPUESTA"].ToString();
					}
				}
				return resultado;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]
		public bool SaveCursoReserva_Mdte( CursoReserva item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("V4MVC_A036_CURSORESERVA_INSERT_MDTE");
							Instance.DAAgregarParametro("@CODIGO", item.CODIGO, SqlDbType.Int, 4, ParameterDirection.Input);
							Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 20, ParameterDirection.Input);
							break;
						case InstanceEntity.Modify:
							Instance.DAAsignarProcedure("_SU_UnReg");
							Instance.DAAgregarParametro("@CODIGO", item.CODIGO, SqlDbType.Int, 4, ParameterDirection.Input);
							Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
							break;
						case InstanceEntity.Delete:
							Instance.DAAsignarProcedure("V4MVC_A036_CURSORESERVA_DELETE_MDTE");
							Instance.DAAgregarParametro("@CODIGO", item.CODIGO, SqlDbType.Int, 4, ParameterDirection.Input);
							Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
							break;
					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						Instance.DAAgregarParametro("@EMPRESA", item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECHARES", item.FECHARES, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@HORARES", item.HORARES, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@WHOMAKE", item.WHOMAKE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ACRONIMO", item.ACRONIMO, SqlDbType.NVarChar, 100, ParameterDirection.Input);
						Instance.DAAgregarParametro("@NOMBRE", item.NOMBRE, SqlDbType.NVarChar, 100, ParameterDirection.Input);
						Instance.DAAgregarParametro("@NOMBRES", item.NOMBRES, SqlDbType.NVarChar, 100, ParameterDirection.Input);
						Instance.DAAgregarParametro("@APELLIDOS", item.APELLIDOS, SqlDbType.NVarChar, 100, ParameterDirection.Input);
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

        public bool SaveParticipanteCursoRsultado_Mdte( CursoReserva item)
        {
            try
            {

                if (item.Instance != InstanceEntity.Unchanged)
                {
                    switch (item.Instance)
                    {
                        case InstanceEntity.New:
                            Instance.DAAsignarProcedure("V4MVC_A036_CURSORESERVA_UPDATE_PARTICIPANTES_MDTE");
                            Instance.DAAgregarParametro("@CODIGO", item.CODIGO, SqlDbType.Int, 4, ParameterDirection.Input);
                            Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                            Instance.DAAgregarParametro("@APROBO", item.APROBO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                            Instance.DAAgregarParametro("@ASISTIO", item.ASISTIO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                            Instance.DAAgregarParametro("@ESQV", item.ESQV, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                            Instance.DAAgregarParametro("@NOTA", item.NOTA, SqlDbType.Int, 4, ParameterDirection.Input);
                            Instance.DAAgregarParametro("@USUARIO", item.USUARIO, SqlDbType.NVarChar, 11, ParameterDirection.Input);
                            Instance.DAAgregarParametro("@OBSERVACION", item.OBS, SqlDbType.NVarChar, 500, ParameterDirection.Input);
							Instance.DAAgregarParametro("@FINALIZADO", item.FINALIZADO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
							Instance.DAAgregarParametro("@NOTAQV", item.NOTAQV, SqlDbType.Int, 4, ParameterDirection.Input);
							Instance.DAAgregarParametro("@EMPRESA", item.EMPRESA, SqlDbType.NVarChar, 20, ParameterDirection.Input);
							Instance.DAAgregarParametro("@ACRONIMO", item.ACRONIMO, SqlDbType.NVarChar, 100, ParameterDirection.Input);
							Instance.DAAgregarParametro("@NOMBRE", item.ACRONIMO, SqlDbType.NVarChar, 100, ParameterDirection.Input);
							Instance.DAAgregarParametro("@NOMBRES", item.NOMBRES, SqlDbType.NVarChar, 100, ParameterDirection.Input);
							Instance.DAAgregarParametro("@APELLIDOS", item.APELLIDOS, SqlDbType.NVarChar, 100, ParameterDirection.Input);

							break;
                        case InstanceEntity.Modify:
                            Instance.DAAsignarProcedure("V4MVC_A036_CURSORESERVA_UPDATE_PARTICIPANTES_MDTE");
                            Instance.DAAgregarParametro("@CODIGO", item.CODIGO, SqlDbType.Int, 4, ParameterDirection.Input);
                            Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                            Instance.DAAgregarParametro("@APROBO", item.APROBO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                            Instance.DAAgregarParametro("@ASISTIO", item.ASISTIO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                            Instance.DAAgregarParametro("@ESQV", item.ESQV, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                            Instance.DAAgregarParametro("@NOTA", item.NOTA, SqlDbType.Int, 4, ParameterDirection.Input);
                            Instance.DAAgregarParametro("@USUARIO", item.USUARIO, SqlDbType.NVarChar, 11, ParameterDirection.Input);
                            Instance.DAAgregarParametro("@OBSERVACION", item.OBS, SqlDbType.NVarChar, 500, ParameterDirection.Input);
							Instance.DAAgregarParametro("@FINALIZADO", item.FINALIZADO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
							Instance.DAAgregarParametro("@NOTAQV", item.NOTAQV, SqlDbType.Int, 4, ParameterDirection.Input);
							Instance.DAAgregarParametro("@EMPRESA", item.EMPRESA, SqlDbType.NVarChar, 20, ParameterDirection.Input);
							Instance.DAAgregarParametro("@ACRONIMO", item.ACRONIMO, SqlDbType.NVarChar, 100, ParameterDirection.Input);
							Instance.DAAgregarParametro("@NOMBRE", item.ACRONIMO, SqlDbType.NVarChar, 100, ParameterDirection.Input);
							Instance.DAAgregarParametro("@NOMBRES", item.NOMBRES, SqlDbType.NVarChar, 100, ParameterDirection.Input);
							Instance.DAAgregarParametro("@APELLIDOS", item.APELLIDOS, SqlDbType.NVarChar, 100, ParameterDirection.Input);

							break;

                        case InstanceEntity.Delete:
                            Instance.DAAsignarProcedure("V4MVC_A036_CURSORESERVA_DELETE_PARTICIPANTES_MDTE");
                            Instance.DAAgregarParametro("@CODIGO", item.CODIGO, SqlDbType.Int, 4, ParameterDirection.Input);
                            Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                            break;
                    }
					if (Instance.DAExecuteNonQuery() > 0)
					{ return true; }
					return false;
				}
				return true;
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion
    }
}
