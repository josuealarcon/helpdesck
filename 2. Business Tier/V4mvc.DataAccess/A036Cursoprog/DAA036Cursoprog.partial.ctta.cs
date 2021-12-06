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
	public partial class DAA036Cursoprog
	{
		#region [ Consultas ]

		#endregion

		#region [ Metodos ]
		public A036Cursoprog GetCourseCargarCursos(int code)
		{
			try
			{
				var item = new A036Cursoprog();
				Instance.DAAsignarProcedure("V4MVC_A141_CURSOS_SELECT_CARGARCURSO_CTTA");
				Instance.DAAgregarParametro("@CODIGO", code, SqlDbType.Int, 4, ParameterDirection.Input);
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
		public bool GuardarCurso_CargarCuso(ref A036Cursoprog curso)
		{
			try
			{
				Instance.DAAsignarProcedure("V4MVC_A141_CURSOS_CREATE_NUEVO_CURSO_CARGAR_CURSOS_CTTA");
				Instance.DAAgregarParametro("@CURSO", curso.CURSO, SqlDbType.Int, 4, ParameterDirection.Input);
				Instance.DAAgregarParametro("@FECHA", curso.FECHA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
				Instance.DAAgregarParametro("@ORADOR", curso.ORADOR, SqlDbType.NVarChar, 20, ParameterDirection.Input);
				Instance.DAAgregarParametro("@WHOMAKE", curso.WHOMAKE, SqlDbType.NVarChar, 20, ParameterDirection.Input);
				Instance.DAAgregarParametro("@OBSERVACION", curso.OBSERVACION, SqlDbType.NVarChar, 200, ParameterDirection.Input);
				Instance.DAAgregarParametro("@ID_DOC", curso.ID_DOC, SqlDbType.UniqueIdentifier, 16, ParameterDirection.Input);
				Instance.DAAgregarParametro("@NOMBRE", curso.NOMBRE, SqlDbType.NVarChar, 50, ParameterDirection.Input);
				Instance.DAAgregarParametro("@BYTES", curso.BYTES, SqlDbType.Int, 4, ParameterDirection.Input);
				Instance.DAAgregarParametro("@CODIGO", curso.CODIGO, SqlDbType.Int, 4, ParameterDirection.Output);

				if (Instance.DAExecuteNonQuery() > 0)
				{
					if (Instance.DASqlCommand.Parameters["@CODIGO"].Value != null)
					{
						curso.CODIGO = (int)Instance.DASqlCommand.Parameters["@CODIGO"].Value;
					}
					return true;
				}
				if (Instance.DASqlCommand.Parameters["@CODIGO"].Value != null)
				{
					curso.CODIGO = (int)Instance.DASqlCommand.Parameters["@CODIGO"].Value;
					return true;
				}
				else
				{ return false; }
			}
			catch (Exception ex)
			{ throw ex; }
		}
		public bool ActualizarOrador_CargarCurso(A036Cursoprog curso)
		{
			try
			{
				Instance.DAAsignarProcedure("V4MVC_A141_CURSOS_UPDATE_ORADOR_CARGAR_CURSOS_CTTA");
				Instance.DAAgregarParametro("@CURSO", curso.CURSO, SqlDbType.Int, 4, ParameterDirection.Input);
				Instance.DAAgregarParametro("@FECHA", curso.FECHA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
				Instance.DAAgregarParametro("@ORADOR", curso.ORADOR, SqlDbType.NVarChar, 20, ParameterDirection.Input);
				Instance.DAAgregarParametro("@WHOMAKE", curso.WHOMAKE, SqlDbType.NVarChar, 20, ParameterDirection.Input);
				Instance.DAAgregarParametro("@OBSERVACION", curso.OBSERVACION, SqlDbType.NVarChar, 200, ParameterDirection.Input);
				Instance.DAAgregarParametro("@CODIGO", curso.CODIGO, SqlDbType.Int, 4, ParameterDirection.Input);

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
