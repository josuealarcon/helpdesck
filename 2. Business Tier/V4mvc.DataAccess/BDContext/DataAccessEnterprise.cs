using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using System.Data.Sql;
using System.Data.SqlClient;
using V4mvc.Entities;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

namespace V4mvc.DataAccess
{

    public class DataAccessEnterprise : IDataAccessEnterprise
    {
        public DataAccessEnterprise()
        {
            try
            {
                DASqlDatabase = new SqlDatabase(ConfigurationManager.ConnectionStrings["Connection"].ConnectionString);
            }
            catch (Exception ex)
            { throw ex; }
        }


        #region [ DataAccess Enterprise ]

        #region [ Properties ]
        private SqlDatabase DASqlDatabase { get; set; }
        public SqlCommand DASqlCommand { get; set; }
        private SqlParameter DASqlParameter { get; set; }
        private SqlConnection DASqlConnection { get; set; }
        private SqlTransaction DASqlTransaction { get; set; }
        private Int32 m_timeout = 0;
        #endregion

        #region [ Procedure ]
        public void DAAsignarProcedure(String x_procedure)
        {
            try
            {
                DASqlCommand = (SqlCommand)DASqlDatabase.GetStoredProcCommand(x_procedure);
                DASqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                DASqlCommand.CommandTimeout = m_timeout;
            }
            catch (Exception ex)
            { throw ex; }
        }
        public void DAAsignarProcedure(String x_procedure, InstanceEntity x_accion)
        {
            try
            {
                DASqlCommand = (SqlCommand)DASqlDatabase.GetStoredProcCommand(x_procedure);
                DASqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                switch (x_accion)
                {
                    case InstanceEntity.New:
                        DAAgregarParametro("@Accion", "I", SqlDbType.NChar, 1, ParameterDirection.Input);
                        break;
                    case InstanceEntity.Modify:
                        DAAgregarParametro("@Accion", "U", SqlDbType.NChar, 1, ParameterDirection.Input);
                        break;
                    case InstanceEntity.Delete:
                        DAAgregarParametro("@Accion", "D", SqlDbType.NChar, 1, ParameterDirection.Input);
                        break;
                    default:
                        break;
                }
                DASqlCommand.CommandTimeout = m_timeout;
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Parameters ]
        public void DAAgregarParametro(String x_parameterName, Object x_value, System.Data.SqlDbType x_sqlDbType)
        {
            try
            {
                DASqlParameter = DASqlCommand.CreateParameter();
                DASqlParameter.ParameterName = x_parameterName;
                DASqlParameter.SqlDbType = x_sqlDbType;
                //DASqlParameter.Size = x_size;
                DASqlParameter.Value = x_value;
                DASqlParameter.Direction = ParameterDirection.Input;
                DASqlCommand.Parameters.Add(DASqlParameter);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public void DAAgregarParametro(String x_parameterName, Object x_value, System.Data.SqlDbType x_sqlDbType, int x_size)
        {
            try
            {
                DASqlParameter = DASqlCommand.CreateParameter();
                DASqlParameter.ParameterName = x_parameterName;
                DASqlParameter.SqlDbType = x_sqlDbType;
                DASqlParameter.Size = x_size;
                DASqlParameter.Value = x_value;
                DASqlParameter.Direction = ParameterDirection.Input;
                DASqlCommand.Parameters.Add(DASqlParameter);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public void DAAgregarParametro(String x_parameterName, Object x_value, System.Data.SqlDbType x_sqlDbType, byte x_precision, byte x_scale)
        {
            try
            {
                DASqlParameter = DASqlCommand.CreateParameter();
                DASqlParameter.ParameterName = x_parameterName;
                DASqlParameter.SqlDbType = x_sqlDbType;
                DASqlParameter.Precision = x_precision;
                DASqlParameter.Scale = x_scale;
                DASqlParameter.Value = x_value;
                DASqlParameter.Direction = ParameterDirection.Input;
                DASqlCommand.Parameters.Add(DASqlParameter);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public void DAAgregarParametro(String x_parameterName, Object x_value, System.Data.SqlDbType x_sqlDbType, int x_size, ParameterDirection x_direction)
        {
            try
            {
                DASqlParameter = DASqlCommand.CreateParameter();
                DASqlParameter.ParameterName = x_parameterName;
                DASqlParameter.SqlDbType = x_sqlDbType;
                DASqlParameter.Size = x_size;
                DASqlParameter.Value = x_value;
                DASqlParameter.Direction = x_direction;
                DASqlCommand.Parameters.Add(DASqlParameter);
            }
            catch (Exception ex)
            { throw ex; }
        }
        public void DAAgregarParametro(String x_parameterName, Object x_value, System.Data.SqlDbType x_sqlDbType, byte x_precision, byte x_scale, ParameterDirection x_direction)
        {
            try
            {
                DASqlParameter = DASqlCommand.CreateParameter();
                DASqlParameter.ParameterName = x_parameterName;
                DASqlParameter.SqlDbType = x_sqlDbType;
                DASqlParameter.Precision = x_precision;
                DASqlParameter.Scale = x_scale;
                DASqlParameter.Value = x_value;
                DASqlParameter.Direction = x_direction;
                DASqlCommand.Parameters.Add(DASqlParameter);
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Transactions ]
        public void DABeginTransaction()
        {
            try
            {
                DASqlConnection = (SqlConnection)DASqlDatabase.CreateConnection();
                DASqlConnection.Open();
                DASqlTransaction = DASqlConnection.BeginTransaction();
            }
            catch (Exception ex)
            { throw ex; }
        }
        public void DACommitTransaction()
        {
            try
            {
                if (DASqlTransaction != null)
                {
                    DASqlTransaction.Commit();
                    DASqlConnection.Close();
                    DASqlTransaction = null;
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
        public void DARollbackTransaction()
        {
            try
            {
                if (DASqlTransaction != null)
                {
                    DASqlTransaction.Rollback();
                    DASqlConnection.Close();
                    DASqlTransaction = null;
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #region [ Execution ]
        public Int32 DAExecuteNonQuery()
        {
            try
            {
                if (DASqlTransaction == null)
                { return DASqlDatabase.ExecuteNonQuery(DASqlCommand); }
                else
                { return DASqlDatabase.ExecuteNonQuery(DASqlCommand, DASqlTransaction); }
            }
            catch (Exception ex)
            { throw ex; }
        }
        public IDataReader DAExecuteReader()
        {
            try
            {
                if (DASqlTransaction == null)
                { return DASqlDatabase.ExecuteReader(DASqlCommand); }
                else
                { return DASqlDatabase.ExecuteReader(DASqlCommand, DASqlTransaction); }
            }
            catch (Exception ex)
            { throw ex; }
        }
        public DataSet DAExecuteDataSet()
        {
            try
            {
                if (DASqlTransaction == null)
                { return DASqlDatabase.ExecuteDataSet(DASqlCommand); }
                else
                { return DASqlDatabase.ExecuteDataSet(DASqlCommand, DASqlTransaction); }
            }
            catch (Exception ex)
            { throw ex; }
        }
        public Object DAExecuteScalar()
        {
            try
            {
                if (DASqlTransaction == null)
                { return DASqlDatabase.ExecuteScalar(DASqlCommand); }
                else
                { return DASqlDatabase.ExecuteScalar(DASqlCommand, DASqlTransaction); }
            }
            catch (Exception ex)
            { throw ex; }
        }
        #endregion

        #endregion

    }
}
