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
	public partial class DAAAQ_Puestos
	{
        #region [ Consultas ]



        #endregion

        #region [ Metodos ]
        public bool SaveUpdatePuestos_Mdte(ref AAQ_Puestos item)
        {
            try
            {
                Instance.DAAsignarProcedure("[V4MVC_AAQ_Q04891_PUESTOS_INSERT_UPDATE_MDTE]");
                Instance.DAAgregarParametro("@IDCATEGORIA", Convert.ToInt32(item.IDCATEGORIA), SqlDbType.Int, 4, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NOMBRE", item.NOMBRE, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                Instance.DAAgregarParametro("@DESCRIPCION", item.DESCRIPCION, SqlDbType.NVarChar, 200, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ACTIVO", item.ACTIVO, SqlDbType.Char, 2, ParameterDirection.Input);
                Instance.DAAgregarParametro("@HABILITACION", item.HABILITACION, SqlDbType.Char, 2, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDPUESTO", Convert.ToInt32(item.IDPUESTO), SqlDbType.Int, 4, ParameterDirection.Input);


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
