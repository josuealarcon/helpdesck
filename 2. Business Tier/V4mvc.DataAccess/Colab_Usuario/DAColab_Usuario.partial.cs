using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Practices.EnterpriseLibrary.Data;
using V4mvc.Entities;

namespace V4mvc.DataAccess
{
	public partial class DAColab_Usuario
	{
        #region [ Consultas ]

        public Colab_Usuario ValidarLogin(String IdEmpresa, String Rut, String Clave)
        {
            try
            {
                Colab_Usuario item = new Colab_Usuario();
                Instance.DAAsignarProcedure("V4MVC_COLAB_USUARIO_VALIDAR_LOGIN");
                Instance.DAAgregarParametro("@IdEmpresa", IdEmpresa, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@Rut", Rut, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@Clave", Clave, SqlDbType.NVarChar, 50, ParameterDirection.Input);
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

        public ObservableCollection<Colab_Usuario> GetAllEnterprise(String IDEMPRESA)
        {
            try
            {
                ObservableCollection<Colab_Usuario> items = new ObservableCollection<Colab_Usuario>();
                Colab_Usuario item = new Colab_Usuario();
                Instance.DAAsignarProcedure("V4MVC_COLAB_USUARIO_ENTERPRISE_SELECT");
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                using (IDataReader reader = Instance.DAExecuteReader())
                {
                    while (reader.Read())
                    {
                        item = new Colab_Usuario();
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

        public Colab_Usuario GetColab_UsuarioEmailsCtta(string IDEMPRESA)
        {
            try
            {
                Colab_Usuario item = new Colab_Usuario();
                Instance.DAAsignarProcedure("V4MVC_COLAB_USUARIO_EMAILS_CTTA");
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
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

        public bool UpdateClaveColabUsuario(string IDEMPRESA, string RUT, string NEWPASSWORD)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_UPDATE_COLABUSUARIO_CAMBIOCLAVE");
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NEWPASSWORD", NEWPASSWORD, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveColabUsuarioNewEnterpriseCTTA(ref Colab_Usuario item)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_COLAB_USUARIO_INSERT_NEWENTERPRISECTTA");
                Instance.DAAgregarParametro("@IDEMPRESA", item.IdEmpresa, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", item.Rut, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CLAVE", item.Clave, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CORREO_ELECTRONICO", item.Correo_Electronico, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }

            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool SaveColabUsuario_EmpUsuariosCtta(Colab_Usuario colab)
        {
            try
            {
                
                Instance.DAAsignarProcedure("V4MVC_COLAB_USUARIO_UPSERT_EMPUSUARIOS_CTTA");
                Instance.DAAgregarParametro("@RUT", colab.Rut, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NOMBRES", colab.NOMBRES, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@APELLIDOS", colab.APELLIDOS, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@UCREADOR", colab.UCREADOR, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", colab.IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@TIPOUSUARIO", colab.TipoUsuario, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CLAVE", colab.Clave, SqlDbType.NVarChar, 50, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ACTIVO", colab.Activo, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                Instance.DAAgregarParametro("@ENVIO_ALERTAS", colab.EnvioAlertas, SqlDbType.NVarChar, 2, ParameterDirection.Input);
                Instance.DAAgregarParametro("@EMAIL", colab.Correo_Electronico, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }

            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool DelColabUsuario_EmpUsuariosCtta(string RUT, string EMPRESA, string USUARIO)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_COLAB_USUARIO_DELETE_EMPUSUARIOS_CTTA");
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", EMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@USUARIO", USUARIO, SqlDbType.NVarChar, 100, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }

            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool ChangePasswordCtta(string IDEMPRESA, string RUT,string CLAVEACTUAL, string NUEVACLAVE)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_COLAB_USUARIO_CHANGEPASSWORD_CTTA");
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@RUT", RUT, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CLAVEACTUAL", CLAVEACTUAL, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NUEVACLAVE", NUEVACLAVE, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                if ((int)Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }

            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool ValidarClaveCtta(string ID, string IDEMPRESA, string CLAVE)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_COLAB_USUARIO_VALIDARCLAVE_CTTA");
                Instance.DAAgregarParametro("@ID", ID, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CLAVE", CLAVE, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                return (int)Instance.DAExecuteScalar() > 0 ? true : false;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool ValidarClaveHistoricoCtta(string ID, string IDEMPRESA, string CLAVE)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_COLAB_USUARIO_VALIDARCLAVEHISTORICO_CTTA");
                Instance.DAAgregarParametro("@ID", ID, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);
                Instance.DAAgregarParametro("@CLAVE", CLAVE, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                return (int)Instance.DAExecuteScalar() > 0 ? true : false;
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool CambioClaveCtta(string ID, string IDEMPRESA, string NUEVACLAVE)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_COLAB_USUARIO_CAMBIOCLAVE_CTTA");
                Instance.DAAgregarParametro("@ID", ID, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NUEVACLAVE", NUEVACLAVE, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                if (Instance.DAExecuteNonQuery() > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public bool CambioClaveHistoricoCtta(string ID, string IDEMPRESA, string NUEVACLAVE, string IP)
        {
            try
            {
                Instance.DAAsignarProcedure("V4MVC_COLAB_USUARIO_CAMBIOCLAVE_HISTORICO_CTTA");
                Instance.DAAgregarParametro("@ID", ID, SqlDbType.NVarChar, 10, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IDEMPRESA", IDEMPRESA, SqlDbType.NVarChar, 11, ParameterDirection.Input);
                Instance.DAAgregarParametro("@NUEVACLAVE", NUEVACLAVE, SqlDbType.NVarChar, 20, ParameterDirection.Input);
                Instance.DAAgregarParametro("@IP", IP, SqlDbType.NVarChar, 50, ParameterDirection.Input);
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


