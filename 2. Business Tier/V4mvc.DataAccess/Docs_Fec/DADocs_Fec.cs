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
	public partial class DADocs_Fec : IDADocs_Fec
	{
		#region [ Propiedades ]
		public IUnityContainer containerService { get; set; }
		public LoaderEntity<Docs_Fec> Loader { get; set; }

        public IDataAccessEnterprise Instance { get; set; }
        private readonly IDbFactory _dbFactory;
        #endregion

        #region [ Constructores ]
        public DADocs_Fec(IDataAccessEnterprise container)
		{
			Instance = container;
			Loader = new LoaderEntity<Docs_Fec>();
			Docs_Fec item = new Docs_Fec();
			Loader.EntityType = item.GetType();
            //_dbFactory = dbFactory;
		}
		#endregion

		#region [ Consultas ]
		public Docs_Fec GetOne()
		{ throw new NotImplementedException(); }

		#endregion

		#region [ Metodos ]
		public bool Save(ref Docs_Fec item)
		{
			try
			{
				if (item.Instance != InstanceEntity.Unchanged)
				{
					switch (item.Instance)
					{
						case InstanceEntity.New:
                            //Instance.DAAsignarProcedure("_SI_UnReg");
                            break;
						case InstanceEntity.Modify:
                            //Instance.DAAsignarProcedure("_SI_UnReg");
                            break;
						case InstanceEntity.Delete:
                            //Instance.DAAsignarProcedure("_SI_UnReg");
                            break;
					}
					if (item.Instance == InstanceEntity.New || item.Instance == InstanceEntity.Modify)
					{
						//Instance.DAAgregarParametro("@ID_DOC_FEC", item.ID_DOC_FEC, SqlDbType.Int, 4, ParameterDirection.Input);
						//Instance.DAAgregarParametro("@NOMBRE", item.NOMBRE, SqlDbType.NVarChar, 50, ParameterDirection.Input);
						//Instance.DAAgregarParametro("@ID_DOC_DEPEND", item.ID_DOC_DEPEND, SqlDbType.Int, 4, ParameterDirection.Input);
						//Instance.DAAgregarParametro("@CAMPO_BD", item.CAMPO_BD, SqlDbType.NVarChar, 30, ParameterDirection.Input);
						//Instance.DAAgregarParametro("@ACTIVO", item.ACTIVO, SqlDbType.NVarChar, 2, ParameterDirection.Input);
						//Instance.DAAgregarParametro("@WHOUPDATE", item.WHOUPDATE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
						//Instance.DAAgregarParametro("@VALIDO_MAYOR_HOY", item.VALIDO_MAYOR_HOY, SqlDbType.Int, 4, ParameterDirection.Input);
						//Instance.DAAgregarParametro("@ORDEN", item.ORDEN, SqlDbType.Int, 4, ParameterDirection.Input);
						//Instance.DAAgregarParametro("@COMUN", item.COMUN, SqlDbType.Int, 4, ParameterDirection.Input);
					}


                    //if (Instance.DAExecuteNonQuery() > 0)
                    //{ return true; }
                    //else
                    //{ return false; }
                    return true;
				}
				else
				{ return true; }
			}
			catch (Exception ex)
			{ throw ex; }
		}

        public ObservableCollection<Docs_Fec> GetAll()
        {
			try
			{
				ObservableCollection<Docs_Fec> items = new ObservableCollection<Docs_Fec>();
				return items;
			}
			catch (Exception ex)
			{ throw ex; }
		}
        #endregion
    }
}
