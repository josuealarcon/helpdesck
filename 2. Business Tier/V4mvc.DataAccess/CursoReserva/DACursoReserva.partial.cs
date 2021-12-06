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

		public CursoReserva ValidateReserva(ref CursoReserva model)
		{
			try
			{
				CursoReserva item = new CursoReserva();
				Instance.DAAsignarProcedure("V4MVC_WORKERS_CURSOS_CTTA");
				Instance.DAAgregarParametro("@RUT", model.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
				Instance.DAAgregarParametro("@NOMBRES", model.NOMBRES, SqlDbType.NVarChar, 50, ParameterDirection.Input);
				Instance.DAAgregarParametro("@APELLIDOS", model.APELLIDOS, SqlDbType.NVarChar, 50, ParameterDirection.Input);
				Instance.DAAgregarParametro("@EMPRESA", model.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
				Instance.DAAgregarParametro("@CODIGO", model.CODIGO, SqlDbType.Int, 4, ParameterDirection.Input);
				Instance.DAAgregarParametro("@CURSO", model.CURSO, SqlDbType.Int, 4, ParameterDirection.Input);
				Instance.DAAgregarParametro("@CHARLA", model.CHARLA, SqlDbType.NVarChar, 50, ParameterDirection.Output);
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
		public ObservableCollection<CursoReserva> GetListFuncionariosInscritos_CargarCurso(int codigo)
		{
			try
			{
				ObservableCollection<CursoReserva> items = new ObservableCollection<CursoReserva>();
				CursoReserva item = new CursoReserva();
				Instance.DAAsignarProcedure("V4MVC_A142_CURSOS_SELECT_CARGARCURSOS_RESERVADOS_CTTA");
				Instance.DAAgregarParametro("@CODIGO", codigo, SqlDbType.Int, 4, ParameterDirection.Input);
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
		public bool CrearFuncionarioListaCargarCurso(CursoReserva cursoReserva)
		{
			try
			{
				Instance.DAAsignarProcedure("V4MVC_A036_CURSORESERVA_AGREGAR_FUNCIONARIO_CARGARCURSO_CTTA");
				Instance.DAAgregarParametro("@CODIGO", cursoReserva.CODIGO, SqlDbType.Int, 4, ParameterDirection.Input);
				Instance.DAAgregarParametro("@RUT", cursoReserva.RUT, SqlDbType.NVarChar, 20, ParameterDirection.Input);
				Instance.DAAgregarParametro("@NOMBRES", cursoReserva.NOMBRES, SqlDbType.NVarChar, 50, ParameterDirection.Input);
				Instance.DAAgregarParametro("@APELLIDOS", cursoReserva.APELLIDOS, SqlDbType.NVarChar, 50, ParameterDirection.Input);
				Instance.DAAgregarParametro("@WHOMAKE", cursoReserva.WHOMAKE, SqlDbType.NVarChar, 20, ParameterDirection.Input);
				Instance.DAAgregarParametro("@ORADOR", cursoReserva.ORADOR, SqlDbType.NVarChar, 20, ParameterDirection.Input);
				Instance.DAAgregarParametro("@ASISTIO", cursoReserva.ASISTIO, SqlDbType.NVarChar, 20, ParameterDirection.Input);
				Instance.DAAgregarParametro("@APROBO", cursoReserva.APROBO, SqlDbType.NVarChar, 20, ParameterDirection.Input);
				Instance.DAAgregarParametro("@OBS", cursoReserva.OBS, SqlDbType.NVarChar, 20, ParameterDirection.Input);
				Instance.DAAgregarParametro("@IDGERENCIA", cursoReserva.ID_GERENCIA, SqlDbType.Int, 4, ParameterDirection.Input);
				Instance.DAAgregarParametro("@IDEMPRESA", cursoReserva.EMPRESA, SqlDbType.NVarChar, 20, ParameterDirection.Input);

				if (Instance.DAExecuteNonQuery() > 0)
				{
					return true;
				}
				else
				{ return false; }
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public bool EliminarFuncionarioListaCargarCurso(CursoReserva cursoReserva)
		{
			try
			{
				Instance.DAAsignarProcedure("V4MVC_A036_CURSORESERVA_ELIMINAR_FUNCIONARIO_CARGARCURSO_CTTA");
				Instance.DAAgregarParametro("@CODIGO", cursoReserva.CODIGO, SqlDbType.Int, 4, ParameterDirection.Input);
				Instance.DAAgregarParametro("@RUT", cursoReserva.RUT, SqlDbType.NVarChar, 20, ParameterDirection.Input);
				if (Instance.DAExecuteNonQuery() > 0)
				{
					return true;
				}
				else
				{ return false; }
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public bool ActualizarFuncionarioListaCargarCurso(CursoReserva cursoReserva)
		{
			try
			{
				Instance.DAAsignarProcedure("V4MVC_A036_CURSORESERVA_ACTUALIZAR_FUNCIONARIO_CARGARCURSO_CTTA");
				Instance.DAAgregarParametro("@CODIGO", cursoReserva.CODIGO, SqlDbType.Int, 4, ParameterDirection.Input);
				Instance.DAAgregarParametro("@RUT", cursoReserva.RUT, SqlDbType.NVarChar, 20, ParameterDirection.Input);
				Instance.DAAgregarParametro("@ASISTIO", cursoReserva.ASISTIO, SqlDbType.NVarChar, 20, ParameterDirection.Input);
				Instance.DAAgregarParametro("@APROBO", cursoReserva.APROBO, SqlDbType.NVarChar, 20, ParameterDirection.Input);
				Instance.DAAgregarParametro("@OBS", cursoReserva.OBS, SqlDbType.NVarChar, 20, ParameterDirection.Input);
				if (Instance.DAExecuteNonQuery() > 0)
				{
					return true;
				}
				else
				{ return false; }
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public bool ActualizarCursoProgramadoCargarCurso(int codigo)
		{
			try
			{
				Instance.DAAsignarProcedure("V4MVC_A036_CURSOPROG_UPDATE_CARGARCURSO_CTTA");
				Instance.DAAgregarParametro("@CODIGO", codigo, SqlDbType.Int, 4, ParameterDirection.Input);
				if (Instance.DAExecuteNonQuery() > 0)
				{
					return true;
				}
				else
				{ return false; }
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion
	}
}
