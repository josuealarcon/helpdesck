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
	public partial class DADepartamento
	{
        #region [ Consultas ]

        public ObservableCollection<Departamento> GetAllDepartamentos_Mdte()
        {
            try
            {
                ObservableCollection<Departamento> items = new ObservableCollection<Departamento>();
                Departamento item = new Departamento();
                Instance.DAAsignarProcedure("V4MVC_DEPARTAMENTO_SELECT_MDTE");
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Departamento();
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

        #endregion
    }
}
