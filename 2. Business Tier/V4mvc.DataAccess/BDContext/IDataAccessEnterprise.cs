using System.Data;
using System.Data.SqlClient;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
    public interface IDataAccessEnterprise
    {
        SqlCommand DASqlCommand { get; set; }

        void DAAgregarParametro(string x_parameterName, object x_value, SqlDbType x_sqlDbType);
        void DAAgregarParametro(string x_parameterName, object x_value, SqlDbType x_sqlDbType, byte x_precision, byte x_scale);
        void DAAgregarParametro(string x_parameterName, object x_value, SqlDbType x_sqlDbType, byte x_precision, byte x_scale, ParameterDirection x_direction);
        void DAAgregarParametro(string x_parameterName, object x_value, SqlDbType x_sqlDbType, int x_size);
        void DAAgregarParametro(string x_parameterName, object x_value, SqlDbType x_sqlDbType, int x_size, ParameterDirection x_direction);
        void DAAsignarProcedure(string x_procedure);
        void DAAsignarProcedure(string x_procedure, InstanceEntity x_accion);
        void DABeginTransaction();
        void DACommitTransaction();
        DataSet DAExecuteDataSet();
        int DAExecuteNonQuery();
        IDataReader DAExecuteReader();
        object DAExecuteScalar();
        void DARollbackTransaction();
    }
}