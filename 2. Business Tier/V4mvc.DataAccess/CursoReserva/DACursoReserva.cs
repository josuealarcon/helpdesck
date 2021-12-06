using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using V4mvc.Entities;
using Unity;

namespace V4mvc.DataAccess
{
	public partial class DACursoReserva : IDACursoReserva
	{
		#region [ Propiedades ]
		public IUnityContainer ContainerService { get; set; }
		public LoaderEntity<CursoReserva> Loader { get; set; }
        public IDataAccessEnterprise Instance { get; set; }
        #endregion

        #region [ Constructores ]
        public DACursoReserva(IDataAccessEnterprise container)
		{
			this.Instance = container;
			Loader = new LoaderEntity<CursoReserva>();
			CursoReserva item = new CursoReserva();
			Loader.EntityType = item.GetType();
		}
		#endregion

		#region [ Consultas ]
		public ObservableCollection<CursoReserva> GetAll(Int32 CODIGO)
		{
			try
			{
				ObservableCollection<CursoReserva> items = new ObservableCollection<CursoReserva>();
				CursoReserva item = new CursoReserva();
				Instance.DAAsignarProcedure("V4MVC_A142_RESERVAS_SELECT");
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
		public CursoReserva GetOne(Int32 CODIGO, String RUT)
		{
			try
			{
				CursoReserva item = new CursoReserva();
				Instance.DAAsignarProcedure("_SI_UnReg");
				Instance.DAAgregarParametro("@CODIGO", CODIGO, SqlDbType.Int, 4, ParameterDirection.Input);
				Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					if (reader.Read())
					{
						Loader.LoadEntity(reader, item);
						item.Instance = InstanceEntity.Unchanged;
					}
					else
					{ throw new Exception("No se encontro el registro."); }
				}
				return item;
			}
			catch (Exception ex)
			{ throw ex; }
		}
		#endregion

		#region [ Metodos ]
		public bool Save(ref CursoReserva item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("V4MVC_A036_CURSORESERVA_INSERT");
							Instance.DAAgregarParametro("@CODIGO", item.CODIGO, SqlDbType.Int, 4, ParameterDirection.Input);
							Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
							Instance.DAAgregarParametro("@ID_GERENCIA", item.ID_GERENCIA, SqlDbType.Int, 4, ParameterDirection.Input);
							break;
						case InstanceEntity.Modify:
							Instance.DAAsignarProcedure("_SU_UnReg");
							Instance.DAAgregarParametro("@CODIGO", item.CODIGO, SqlDbType.Int, 4, ParameterDirection.Input);
							Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
							break;
						case InstanceEntity.Delete:
							Instance.DAAsignarProcedure("V4MVC_A036_CURSORESERVA_DELETE");
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
						Instance.DAAgregarParametro("@ASISTIO", item.ASISTIO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@APROBO", item.APROBO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						Instance.DAAgregarParametro("@OBS", item.OBS, SqlDbType.NVarChar, 100, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ORADOR", item.ORADOR, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@NOTA", item.NOTA, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECHARESP", item.FECHARESP, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@HORARESP", item.HORARESP, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@AREA", item.AREA, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ROLLAB", item.ROLLAB, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@TURNO", item.TURNO, SqlDbType.NVarChar, 20, ParameterDirection.Input);
						Instance.DAAgregarParametro("@LOCALTRABAJO", item.LOCALTRABAJO, SqlDbType.NVarChar, 12, ParameterDirection.Input);
						Instance.DAAgregarParametro("@NOTAQV", item.NOTAQV, SqlDbType.Int, 4, ParameterDirection.Input);
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
