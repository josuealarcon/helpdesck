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
	public partial class DADocs_Fec_Workers : IDADocs_Fec_Workers
	{
		#region [ Propiedades ]
		public IUnityContainer containerService { get; set; }
		public LoaderEntity<Docs_Fec_Workers> Loader { get; set; }
        public IDataAccessEnterprise Instance { get; set; }
        #endregion

        #region [ Constructores ]
        public DADocs_Fec_Workers(IDataAccessEnterprise container)
		{
			Loader = new LoaderEntity<Docs_Fec_Workers>();
			Docs_Fec_Workers item = new Docs_Fec_Workers();
			Loader.EntityType = item.GetType();
            Instance = container;
		}
		#endregion

		#region [ Consultas ]
		public ObservableCollection<Docs_Fec_Workers> GetAll()
		{
			try
			{
				ObservableCollection<Docs_Fec_Workers> items = new ObservableCollection<Docs_Fec_Workers>();
				Docs_Fec_Workers item = new Docs_Fec_Workers();
				Instance.DAAsignarProcedure("_SI_UnReg");
				using (IDataReader reader = Instance.DAExecuteReader())
				{
					while (reader.Read())
					{
						item = new Docs_Fec_Workers();
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
		public Docs_Fec_Workers GetOne(Guid Codigo)
		{ throw new NotImplementedException(); }

		#endregion

		#region [ Metodos ]

		public bool Save(ref Docs_Fec_Workers item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
							Instance.DAAsignarProcedure("V4MVC_DOCS_FEC_WORKERS_INSERT"); 
							break;
						case InstanceEntity.Modify:
							Instance.DAAsignarProcedure("V4MVC_DOCS_FEC_WORKERS_UPDATE");
							break;
						case InstanceEntity.Delete:
							Instance.DAAsignarProcedure("_SI_UnReg");
							break;
					} 
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@DIVISION", item.DIVISION, SqlDbType.NVarChar, 20, ParameterDirection.Input);
						Instance.DAAgregarParametro("@EMPRESA", item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						Instance.DAAgregarParametro("@ID_DOC_FEC", item.ID_DOC_FEC, SqlDbType.Int, 4, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECHA", item.FECHA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@FECHAMOD", item.FECHAMOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@HORAMOD", item.HORAMOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
						Instance.DAAgregarParametro("@USUARIO", item.USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
					}
					item.MENSAJE =  Convert.ToInt32( Instance.DAExecuteScalar());

					if (item.MENSAJE == 1)
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
        public bool SaveDocsFecWorkersFuncionario(ref Docs_Fec_Workers item)
        {
            try
            {
                if (item.Instance != InstanceEntity.Unchanged)
                {
                    switch (item.Instance)
                    {
                        case InstanceEntity.New:
                            Instance.DAAsignarProcedure("V4MVC_DOCS_FEC_WORKERS_FUNCIONARIO_INSERT");
                            break;
                        case InstanceEntity.Modify:
                            Instance.DAAsignarProcedure("V4MVC_DOCS_FEC_WORKERS_FUNCIONARIO_UPDATE");
                            break;
                        case InstanceEntity.Delete:
                            Instance.DAAsignarProcedure("_SI_UnReg");
                            break;
                    }
                    if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
                    {
                        Instance.DAAgregarParametro("@RUT", item.RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@DIVISION", item.DIVISION, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@EMPRESA", item.EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@ID_DOC_FEC", item.ID_DOC_FEC, SqlDbType.Int, 4, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@FECHA", item.FECHA, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@FECHAMOD", item.FECHAMOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@HORAMOD", item.HORAMOD, SqlDbType.NVarChar, 8, ParameterDirection.Input);
                        Instance.DAAgregarParametro("@USUARIO", item.USUARIO, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                    }
                    item.MENSAJE = Convert.ToInt32(Instance.DAExecuteScalar());

                    if (item.MENSAJE == 1)
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
